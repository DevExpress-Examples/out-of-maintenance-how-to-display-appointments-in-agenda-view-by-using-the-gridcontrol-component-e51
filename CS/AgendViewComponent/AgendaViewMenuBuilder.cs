using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraScheduler;
using DevExpress.XtraGrid.Menu;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace AgendViewComponent {
    public static class AgendaViewMenuBuilder {
        public static SchedulerControl Scheduler { get; set; }
        public static Appointment CurrentAppointment { get; set; }

        public static AgendaViewControl ViewControl { get; set; }

        public static void GenerateContextMenu(AgendaViewControl viewControl, GridViewMenu contextMenu, SchedulerControl control, Appointment apt) {
            Scheduler = control;
            CurrentAppointment = apt;
            ViewControl = viewControl;
            if(apt != null) {
                contextMenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Open appointment", OnOpenCurrentAppointment));
                contextMenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete appointment", OnDeleteCurrentAppointment, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.Delete.png"))));                
            }
            
            DevExpress.Utils.Menu.DXMenuItem nextInterval = new DevExpress.Utils.Menu.DXMenuItem("Go to the next month", OnNextInterval, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.NextArrow.png")));
            nextInterval.BeginGroup = true;
            
            contextMenu.Items.Add(nextInterval);
            contextMenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Go to the previous month", OnPreviousInterval, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.PrevArrow.png"))));
            contextMenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Go to the specific date", OnGoToSpecificDate));

            DevExpress.Utils.Menu.DXSubMenuItem switchView = new DevExpress.Utils.Menu.DXSubMenuItem("Change view to");
            switchView.BeginGroup = true;
            contextMenu.Items.Add(switchView);

            if(Scheduler.DayView.Enabled) switchView.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Day View", OnSwitchToDayView, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.DayView.png"))));
            if(Scheduler.WorkWeekView.Enabled) switchView.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Work Week View", OnSwitchToWorkWeekView, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.WorkWeekView.png"))));
            if(Scheduler.WeekView.Enabled) switchView.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Week View", OnSwitchToWeekView, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.WeekView.png"))));
            if(Scheduler.MonthView.Enabled) switchView.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Month View", OnSwitchToMonthView, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.MonthView.png"))));
            if(Scheduler.TimelineView.Enabled) switchView.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Timeline View", OnSwitchToTimelineView, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.TimelineView.png"))));
            if(Scheduler.GanttView.Enabled) switchView.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Gantt View", OnSwitchToGanttView, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.GanttView.png"))));

            if(apt != null) {
                contextMenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem(ViewControl.ShowResources ? "Show all appointments" : "Group appointments by resources", OnSwitchResourcesVisibility));
            }
        }

        public static void OnOpenCurrentAppointment(object sender, EventArgs e) {
            Scheduler.ShowEditAppointmentForm(CurrentAppointment, CurrentAppointment.IsRecurring);
            ViewControl.InitializeGridControlAppointments();
        }

        public static void OnDeleteCurrentAppointment(object sender, EventArgs e) {
            Scheduler.DeleteAppointment(CurrentAppointment);
            ViewControl.InitializeGridControlAppointments();
        }

        public static void OnGoToSpecificDate(object sender, EventArgs e) {
            GoToDateDialog dateDialog = new GoToDateDialog();
            dateDialog.SelectedDate = AgendaViewDataGenerator.SelectedInterval.Start;
            DialogResult result = dateDialog.ShowDialog();
            if(result == DialogResult.OK) {
                DateTime intervalStart = new DateTime(dateDialog.SelectedDate.Year, dateDialog.SelectedDate.Month, 1);
                AgendaViewDataGenerator.SelectedInterval = new TimeInterval(intervalStart, intervalStart.AddMonths(1));
                ViewControl.InitializeGridControlAppointments();
                ViewControl.GenerateAgndaViewCaption();
            }
        }

        public static void OnNextInterval(object sender, EventArgs e) {
            AgendaViewDataGenerator.SelectedInterval = new TimeInterval(AgendaViewDataGenerator.SelectedInterval.End, AgendaViewDataGenerator.SelectedInterval.End.AddMonths(1));
            ViewControl.InitializeGridControlAppointments();
            ViewControl.GenerateAgndaViewCaption();
        }

        public static void OnPreviousInterval(object sender, EventArgs e) {
            AgendaViewDataGenerator.SelectedInterval = new TimeInterval(AgendaViewDataGenerator.SelectedInterval.Start.AddMonths(-1), AgendaViewDataGenerator.SelectedInterval.Start);
            ViewControl.InitializeGridControlAppointments();
            ViewControl.GenerateAgndaViewCaption();
        }

        public static void OnSwitchToDayView(object sender, EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.Day;
            AgendaViewHelper.SwitchToNormalView();
        }

        public static void OnSwitchToWorkWeekView(object sender, EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.WorkWeek;
            AgendaViewHelper.SwitchToNormalView();
        }

        public static void OnSwitchToWeekView(object sender, EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.Week;
            AgendaViewHelper.SwitchToNormalView();
        }

        public static void OnSwitchToMonthView(object sender, EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.Month;
            AgendaViewHelper.SwitchToNormalView();
        }

        public static void OnSwitchToTimelineView(object sender, EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.Timeline;
            AgendaViewHelper.SwitchToNormalView();
        }

        public static void OnSwitchToGanttView(object sender, EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.Gantt;
            AgendaViewHelper.SwitchToNormalView();
        }

        public static void OnSwitchResourcesVisibility(object sender, EventArgs e) {
            ViewControl.ShowResources = !ViewControl.ShowResources;
        }
    }
}
