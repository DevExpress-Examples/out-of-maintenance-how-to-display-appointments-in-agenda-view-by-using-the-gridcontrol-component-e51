using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraScheduler;
using DevExpress.XtraLayout;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Drawing;
using DevExpress.Utils.Menu;

namespace AgendViewComponent {
    public static class AgendaViewHelper {
        private static AgendaViewControl AgendaView;
        private static SchedulerControl CurrentScheduler;
        private static DateNavigator navigator;

        public static void AddAgendaView(SchedulerControl scheduler, DateNavigator dateNavigator, bool showResources) {
            CurrentScheduler = scheduler;
            navigator = dateNavigator;
            if(!(scheduler.Parent is LayoutControl)) {
                MessageBox.Show("SchedulerControl should be located within a LayoutControl to enable AgendaView functionality");                
            }
            else {
                AgendaView = new AgendaViewControl(showResources, CurrentScheduler);
                CurrentScheduler.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(CurrentScheduler_PopupMenuShowing);
                LayoutControl currentLayout = scheduler.Parent as LayoutControl;
                LayoutControlItem schedulerLayoutItem = currentLayout.GetItemByControl(CurrentScheduler);
                //Create a layout item and add it to the root group.    
                LayoutControlItem itemAgendaView = currentLayout.Root.AddItem(schedulerLayoutItem, DevExpress.XtraLayout.Utils.InsertType.Top) as LayoutControlItem;
                // Set the item's Control and caption.
                itemAgendaView.Name = "layoutControlItemAgendaView";
                itemAgendaView.Control = AgendaView;
                itemAgendaView.TextVisible = false;

                ChangeControlsVisibility(CurrentScheduler, true);
                if(navigator != null) ChangeControlsVisibility(navigator, true);
                ChangeControlsVisibility(AgendaView, false);
            }
        }

        static void CurrentScheduler_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e) {
            Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.Report.png");
            foreach(DXMenuItem item in e.Menu.Items) {
                SchedulerPopupMenu menuItem = item as SchedulerPopupMenu;
                if(menuItem != null && menuItem.Id == SchedulerMenuItemId.SwitchViewMenu) {
                    menuItem.Items.Add(new DXMenuItem("Agenda View", OnSwitchToAgendaView, new Bitmap(Image.FromStream(imageStream), new Size(16, 16))));
                }
            }            
        }

        public static void SwitchToAgendaView() {
            ChangeControlsVisibility(CurrentScheduler, false);
            if(navigator != null) ChangeControlsVisibility(navigator, false);

            AgendaView.InitializeGridControlAppointments();
            ChangeControlsVisibility(AgendaView, true);                
        }

        public static void SwitchToNormalView() {
            ChangeControlsVisibility(CurrentScheduler, true);
            if(navigator != null) ChangeControlsVisibility(navigator, true);
            ChangeControlsVisibility(AgendaView, false);                
        }

        static void OnSwitchToAgendaView(object sender, EventArgs e) {
            SwitchToAgendaView();
        }

        static void ChangeControlsVisibility(Control someControl, bool visibility) {
            if(someControl.Parent is LayoutControl) {
                (someControl.Parent as LayoutControl).GetItemByControl(someControl).Visibility = visibility ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            }
            else someControl.Visible = visibility;
        }

    }
}
