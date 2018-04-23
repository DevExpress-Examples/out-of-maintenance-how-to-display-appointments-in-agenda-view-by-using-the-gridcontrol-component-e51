using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using System.Reflection;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraEditors.Controls;

namespace AgendViewComponent {
    public partial class AgendaViewControl : UserControl {

        SchedulerControl OwnerScheduler;
        bool _showResources = false;
        object selectedResourceId = null;
        Image noPhotoImage = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("AgendViewComponent.Resources.no_photo_icon.jpg"));

        ImageCollection appointmentImages;
        public AgendaViewControl(bool showResources, SchedulerControl scheduler) {
            InitializeComponent();

            OwnerScheduler = scheduler;
            ShowResources = showResources;
            DateTime selectedIntervalStart = OwnerScheduler.ActiveView.GetVisibleIntervals().Start;
            DateTime intervalStart = new DateTime(selectedIntervalStart.Year, selectedIntervalStart.Month, 1);
            AgendaViewDataGenerator.SelectedInterval = new TimeInterval(intervalStart, intervalStart.AddMonths(1));

            InitializeGridControlResources();
            InitializeGridControlAppointments();
            gridViewAppointments.ExpandAllGroups();

            appointmentImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("AgendViewComponent.Resources.AppointmentImages.png", System.Reflection.Assembly.GetExecutingAssembly(), new Size(15, 15));

            RepositoryItemImageComboBox reStatus = GridControlAppointments.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            CreateCustomColorsForStatuses(reStatus);
            gridViewAppointments.Columns["AgendaStatus"].ColumnEdit = reStatus;
        }

        #region Properties
        public bool ShowResources {
            get { return _showResources; }
            set {
                if(_showResources != value) {
                    _showResources = value;
                    SwitchResourcesVisibility();
                    GridControlAppointments.RefreshDataSource();
                }
            }
        }
        #endregion

        #region Methods
        void SwitchResourcesVisibility() {
            layoutControlItemResources.Visibility = ShowResources ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
        }

        void InitializeGridControlResources() {
            GridControlResources.DataSource = AgendaViewDataGenerator.GenerateResourcesCollection(OwnerScheduler.Storage);
        }

        public void InitializeGridControlAppointments() {
            GridControlAppointments.DataSource = AgendaViewDataGenerator.GenerateAgendaAppointmentCollection(OwnerScheduler.Storage);
        }

        private Color GetLightenColor(Color inColor, double inAmount) {
            return Color.FromArgb(
              inColor.A,
              (int)Math.Min(255, inColor.R + 255 * inAmount),
              (int)Math.Min(255, inColor.G + 255 * inAmount),
              (int)Math.Min(255, inColor.B + 255 * inAmount));
        }

        private void CreateCustomColorsForStatuses(RepositoryItemImageComboBox riImageComboBox) {
            foreach(AppointmentStatus status in OwnerScheduler.Storage.Appointments.Statuses) {
                riImageComboBox.Items.Add(new ImageComboBoxItem(status.Color.ToString(), status));
            }

            ImageList imagesColors = new ImageList();
            riImageComboBox.SmallImages = imagesColors;

            foreach(ImageComboBoxItem item in riImageComboBox.Items) {
                int iWidth = 16;
                int iHeight = 16;
                Bitmap bmp = new Bitmap(iWidth, iHeight);
                using(Graphics g = Graphics.FromImage(bmp)) {
                    g.DrawRectangle(new Pen(Color.Black, 2), 0, 0, iWidth, iHeight);
                    g.FillRectangle(new SolidBrush((item.Value as AppointmentStatus).Color), 1, 1, iWidth - 2, iHeight - 2);

                }
                imagesColors.Images.Add(bmp);
                item.ImageIndex = imagesColors.Images.Count - 1;
            }
        }

        #endregion


        #region Event Handlers
        private void layoutViewResources_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if(e.Column.FieldName == "ResourceImage" && e.IsGetData) {
                Image resourceImage = (e.Row as DevExpress.XtraScheduler.Resource).Image;
                if(resourceImage == null) {
                    resourceImage = noPhotoImage;
                }
                e.Value = resourceImage;
            }
        }

        private void layoutViewResources_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            selectedResourceId = ((sender as ColumnView).GetRow(e.FocusedRowHandle) as Resource).Id;
            gridViewAppointments.RefreshData();
            GenerateAgndaViewCaption();
        }

        private void gridViewAppointments_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e) {
            if(ShowResources && selectedResourceId != null) {
                Appointment sourceAppointment = ((sender as ColumnView).GetRow(e.ListSourceRow) as AgendaAppointment).SourceAppointment;
                e.Visible = sourceAppointment.ResourceIds.Contains(selectedResourceId);
                e.Handled = true;
            }

        }

        private void gridViewAppointments_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            Appointment currentApt = (e.Row as AgendaAppointment).SourceAppointment;
            if(e.Column.FieldName == "gridColumnRecurring" && e.IsGetData && currentApt.IsRecurring) {
                e.Value = appointmentImages.Images[2];
            }

            if(e.Column.FieldName == "gridColumnReminder" && e.IsGetData && currentApt.HasReminder) {
                e.Value = appointmentImages.Images[4];
            }
        }

        private void gridViewAppointments_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e) {
            GridView currentView = sender as GridView;
            if(!currentView.IsGroupRow(e.RowHandle)) {
                AgendaAppointment currentAppointment = (sender as GridView).GetRow(e.RowHandle) as AgendaAppointment;
                e.Appearance.BackColor = currentAppointment.AgendaLabel;
            }
        }

        private void gridViewAppointments_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
            if(e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell) {
                GridView currentView = sender as GridView;
                AgendaAppointment agendaAppointment = currentView.GetRow(e.HitInfo.RowHandle) as AgendaAppointment;
                AgendaViewMenuBuilder.GenerateContextMenu(this, e.Menu, OwnerScheduler, agendaAppointment.SourceAppointment);
            }
            if(e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.EmptyRow) {
                if(e.Menu == null)
                    e.Menu = new DevExpress.XtraGrid.Menu.GridViewMenu(sender as GridView);
                AgendaViewMenuBuilder.GenerateContextMenu(this, e.Menu, OwnerScheduler, null);
            }
        }

        private void gridViewAppointments_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e) {
            GridView view = sender as GridView;
            if(e.RowHandle == view.FocusedRowHandle) {
                e.Appearance.Font = view.Appearance.GroupRow.Font;
                e.Appearance.BackColor = view.Appearance.GroupRow.GetBackColor();
            }
        }

        private void gridViewAppointments_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
            GridView view = sender as GridView;
            if(e.RowHandle == view.FocusedRowHandle) {
                if(!view.IsGroupRow(e.RowHandle)) {
                    AgendaAppointment currentAppointment = (sender as GridView).GetRow(e.RowHandle) as AgendaAppointment;
                    e.Appearance.BackColor = GetLightenColor(currentAppointment.AgendaLabel, 0.1);
                }
            }
        }

        private void gridViewAppointments_DoubleClick(object sender, EventArgs e) {
            GridView currentView = sender as GridView;
            if(!currentView.IsGroupRow(currentView.FocusedRowHandle)) {
                AgendaViewMenuBuilder.Scheduler = OwnerScheduler;
                AgendaAppointment agendaAppointment = currentView.GetRow(currentView.FocusedRowHandle) as AgendaAppointment;
                AgendaViewMenuBuilder.CurrentAppointment = agendaAppointment.SourceAppointment;
                AgendaViewMenuBuilder.ViewControl = this;
                AgendaViewMenuBuilder.OnOpenCurrentAppointment(null, null);
            }
        }

        public void GenerateAgndaViewCaption() {
            string currentMonth = AgendaViewDataGenerator.SelectedInterval.Start.ToString("MMMM");
            int rowCount =gridViewAppointments.RowCount;
            if(rowCount == 0) {
                gridViewAppointments.ViewCaption = currentMonth + " (no data)";
            }
            else if(ShowResources) {
                object resourceCaption = layoutViewResources.GetFocusedRowCellValue("Caption");
                if(resourceCaption == null)
                    gridViewAppointments.ViewCaption = currentMonth;
                else
                    gridViewAppointments.ViewCaption = currentMonth + " (" + resourceCaption + ")";

            }
            else
                gridViewAppointments.ViewCaption = currentMonth;
        
        }
        #endregion 
    }
}
