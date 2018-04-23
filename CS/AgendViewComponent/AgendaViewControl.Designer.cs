namespace AgendViewComponent {
    partial class AgendaViewControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControlResources = new DevExpress.XtraGrid.GridControl();
            this.layoutViewResources = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumnName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Item1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Item2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.GridControlAppointments = new DevExpress.XtraGrid.GridControl();
            this.gridViewAppointments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEditIcon = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumnRecurring = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnReminder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAgendaDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemAppointments = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemResources = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemResources)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GridControlResources);
            this.layoutControl1.Controls.Add(this.GridControlAppointments);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(777, 562);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GridControlResources
            // 
            this.GridControlResources.Location = new System.Drawing.Point(2, 2);
            this.GridControlResources.MainView = this.layoutViewResources;
            this.GridControlResources.Name = "GridControlResources";
            this.GridControlResources.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.GridControlResources.Size = new System.Drawing.Size(241, 558);
            this.GridControlResources.TabIndex = 5;
            this.GridControlResources.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutViewResources});
            // 
            // layoutViewResources
            // 
            this.layoutViewResources.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutViewResources.Appearance.CardCaption.Options.UseFont = true;
            this.layoutViewResources.CardCaptionFormat = "{2}";
            this.layoutViewResources.CardMinSize = new System.Drawing.Size(157, 160);
            this.layoutViewResources.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumnName,
            this.layoutViewColumn1});
            this.layoutViewResources.GridControl = this.GridControlResources;
            this.layoutViewResources.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1});
            this.layoutViewResources.Name = "layoutViewResources";
            this.layoutViewResources.OptionsBehavior.Editable = false;
            this.layoutViewResources.OptionsCustomization.AllowFilter = false;
            this.layoutViewResources.OptionsCustomization.AllowSort = false;
            this.layoutViewResources.OptionsView.AllowHotTrackFields = false;
            this.layoutViewResources.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None;
            this.layoutViewResources.OptionsView.ShowCardBorderIfCaptionHidden = false;
            this.layoutViewResources.OptionsView.ShowCardExpandButton = false;
            this.layoutViewResources.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.layoutViewResources.OptionsView.ShowHeaderPanel = false;
            this.layoutViewResources.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column;
            this.layoutViewResources.TemplateCard = this.layoutViewCard1;
            this.layoutViewResources.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.layoutViewResources_FocusedRowChanged);
            this.layoutViewResources.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.layoutViewResources_CustomUnboundColumnData);
            // 
            // layoutViewColumnName
            // 
            this.layoutViewColumnName.Caption = "Name";
            this.layoutViewColumnName.FieldName = "Caption";
            this.layoutViewColumnName.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumnName.Name = "layoutViewColumnName";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 140;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(120, 110);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(31, 13);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 5;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.layoutViewColumn1.FieldName = "ResourceImage";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1_1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            this.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 96;
            this.layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(17, 0);
            this.layoutViewField_layoutViewColumn1_1.MaxSize = new System.Drawing.Size(100, 100);
            this.layoutViewField_layoutViewColumn1_1.MinSize = new System.Drawing.Size(100, 100);
            this.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            this.layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(100, 100);
            this.layoutViewField_layoutViewColumn1_1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn1_1.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn1_1.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1_1,
            this.emptySpaceItem1,
            this.Item1,
            this.Item2});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(117, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(20, 100);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Item1
            // 
            this.Item1.AllowHotTrack = false;
            this.Item1.CustomizationFormText = "Item1";
            this.Item1.Location = new System.Drawing.Point(0, 100);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(137, 21);
            this.Item1.Text = "Item1";
            this.Item1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Item2
            // 
            this.Item2.AllowHotTrack = false;
            this.Item2.CustomizationFormText = "Item2";
            this.Item2.Location = new System.Drawing.Point(0, 0);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(17, 100);
            this.Item2.Text = "Item2";
            this.Item2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // GridControlAppointments
            // 
            this.GridControlAppointments.Location = new System.Drawing.Point(247, 2);
            this.GridControlAppointments.MainView = this.gridViewAppointments;
            this.GridControlAppointments.Name = "GridControlAppointments";
            this.GridControlAppointments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEditIcon});
            this.GridControlAppointments.Size = new System.Drawing.Size(528, 558);
            this.GridControlAppointments.TabIndex = 4;
            this.GridControlAppointments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAppointments});
            // 
            // gridViewAppointments
            // 
            this.gridViewAppointments.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.gridViewAppointments.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewAppointments.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gridViewAppointments.Appearance.Preview.ForeColor = System.Drawing.Color.Blue;
            this.gridViewAppointments.Appearance.Preview.Options.UseFont = true;
            this.gridViewAppointments.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewAppointments.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewAppointments.Appearance.Row.Options.UseFont = true;
            this.gridViewAppointments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnStatus,
            this.gridColumnRecurring,
            this.gridColumnReminder,
            this.gridColumnSubject,
            this.gridColumnDuration,
            this.gridColumnLocation,
            this.gridColumnAgendaDate});
            this.gridViewAppointments.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewAppointments.GridControl = this.GridControlAppointments;
            this.gridViewAppointments.GroupCount = 1;
            this.gridViewAppointments.GroupFormat = "{1}";
            this.gridViewAppointments.GroupRowHeight = 50;
            this.gridViewAppointments.Name = "gridViewAppointments";
            this.gridViewAppointments.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewAppointments.OptionsBehavior.Editable = false;
            this.gridViewAppointments.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewAppointments.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewAppointments.OptionsView.ColumnAutoWidth = false;
            this.gridViewAppointments.OptionsView.ShowColumnHeaders = false;
            this.gridViewAppointments.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewAppointments.OptionsView.ShowGroupPanel = false;
            this.gridViewAppointments.OptionsView.ShowPreview = true;
            this.gridViewAppointments.OptionsView.ShowViewCaption = true;
            this.gridViewAppointments.PreviewFieldName = "AgendaDescription";
            this.gridViewAppointments.RowHeight = 30;
            this.gridViewAppointments.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnAgendaDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewAppointments.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewAppointments_CustomDrawCell);
            this.gridViewAppointments.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridViewAppointments_CustomDrawGroupRow);
            this.gridViewAppointments.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewAppointments_RowStyle);
            this.gridViewAppointments.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewAppointments_PopupMenuShowing);
            this.gridViewAppointments.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewAppointments_CustomUnboundColumnData);
            this.gridViewAppointments.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridViewAppointments_CustomRowFilter);
            this.gridViewAppointments.DoubleClick += new System.EventHandler(this.gridViewAppointments_DoubleClick);
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = " ";
            this.gridColumnStatus.ColumnEdit = this.repositoryItemPictureEditIcon;
            this.gridColumnStatus.FieldName = "AgendaStatus";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.OptionsColumn.AllowEdit = false;
            this.gridColumnStatus.OptionsColumn.FixedWidth = true;
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 0;
            this.gridColumnStatus.Width = 41;
            // 
            // repositoryItemPictureEditIcon
            // 
            this.repositoryItemPictureEditIcon.Name = "repositoryItemPictureEditIcon";
            this.repositoryItemPictureEditIcon.NullText = " ";
            // 
            // gridColumnRecurring
            // 
            this.gridColumnRecurring.Caption = " ";
            this.gridColumnRecurring.ColumnEdit = this.repositoryItemPictureEditIcon;
            this.gridColumnRecurring.FieldName = "gridColumnRecurring";
            this.gridColumnRecurring.Name = "gridColumnRecurring";
            this.gridColumnRecurring.OptionsColumn.FixedWidth = true;
            this.gridColumnRecurring.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumnRecurring.Visible = true;
            this.gridColumnRecurring.VisibleIndex = 1;
            this.gridColumnRecurring.Width = 20;
            // 
            // gridColumnReminder
            // 
            this.gridColumnReminder.Caption = " ";
            this.gridColumnReminder.ColumnEdit = this.repositoryItemPictureEditIcon;
            this.gridColumnReminder.FieldName = "gridColumnReminder";
            this.gridColumnReminder.Name = "gridColumnReminder";
            this.gridColumnReminder.OptionsColumn.FixedWidth = true;
            this.gridColumnReminder.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumnReminder.Visible = true;
            this.gridColumnReminder.VisibleIndex = 2;
            this.gridColumnReminder.Width = 20;
            // 
            // gridColumnSubject
            // 
            this.gridColumnSubject.Caption = "Subject";
            this.gridColumnSubject.FieldName = "AgendaSubject";
            this.gridColumnSubject.Name = "gridColumnSubject";
            this.gridColumnSubject.Visible = true;
            this.gridColumnSubject.VisibleIndex = 3;
            this.gridColumnSubject.Width = 166;
            // 
            // gridColumnDuration
            // 
            this.gridColumnDuration.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gridColumnDuration.AppearanceCell.Options.UseFont = true;
            this.gridColumnDuration.Caption = "Duration";
            this.gridColumnDuration.FieldName = "AgendaDuration";
            this.gridColumnDuration.Name = "gridColumnDuration";
            this.gridColumnDuration.Visible = true;
            this.gridColumnDuration.VisibleIndex = 4;
            this.gridColumnDuration.Width = 128;
            // 
            // gridColumnLocation
            // 
            this.gridColumnLocation.Caption = "Location";
            this.gridColumnLocation.FieldName = "AgendaLocation";
            this.gridColumnLocation.Name = "gridColumnLocation";
            this.gridColumnLocation.Visible = true;
            this.gridColumnLocation.VisibleIndex = 5;
            this.gridColumnLocation.Width = 98;
            // 
            // gridColumnAgendaDate
            // 
            this.gridColumnAgendaDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 16F);
            this.gridColumnAgendaDate.AppearanceCell.Options.UseFont = true;
            this.gridColumnAgendaDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 16F);
            this.gridColumnAgendaDate.AppearanceHeader.Options.UseFont = true;
            this.gridColumnAgendaDate.DisplayFormat.FormatString = "dd (dddd) - MMMM - yyyy";
            this.gridColumnAgendaDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnAgendaDate.FieldName = "AgendaDate";
            this.gridColumnAgendaDate.GroupFormat.FormatString = "dd (dddd) - MMMM - yyyy";
            this.gridColumnAgendaDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnAgendaDate.Name = "gridColumnAgendaDate";
            this.gridColumnAgendaDate.Visible = true;
            this.gridColumnAgendaDate.VisibleIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemAppointments,
            this.layoutControlItemResources});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(777, 562);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemAppointments
            // 
            this.layoutControlItemAppointments.Control = this.GridControlAppointments;
            this.layoutControlItemAppointments.CustomizationFormText = "layoutControlItemAppointments";
            this.layoutControlItemAppointments.Location = new System.Drawing.Point(245, 0);
            this.layoutControlItemAppointments.Name = "layoutControlItemAppointments";
            this.layoutControlItemAppointments.Size = new System.Drawing.Size(532, 562);
            this.layoutControlItemAppointments.Text = "layoutControlItemAppointments";
            this.layoutControlItemAppointments.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemAppointments.TextToControlDistance = 0;
            this.layoutControlItemAppointments.TextVisible = false;
            // 
            // layoutControlItemResources
            // 
            this.layoutControlItemResources.Control = this.GridControlResources;
            this.layoutControlItemResources.CustomizationFormText = "layoutControlItemResources";
            this.layoutControlItemResources.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemResources.Name = "layoutControlItemResources";
            this.layoutControlItemResources.Size = new System.Drawing.Size(245, 562);
            this.layoutControlItemResources.Text = "layoutControlItemResources";
            this.layoutControlItemResources.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemResources.TextToControlDistance = 0;
            this.layoutControlItemResources.TextVisible = false;
            // 
            // AgendaViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "AgendaViewControl";
            this.Size = new System.Drawing.Size(777, 562);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl GridControlResources;
        private DevExpress.XtraGrid.GridControl GridControlAppointments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAppointments;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAppointments;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemResources;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutViewResources;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumnName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem Item1;
        private DevExpress.XtraLayout.EmptySpaceItem Item2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRecurring;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnReminder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDuration;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLocation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAgendaDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditIcon;
    }
}
