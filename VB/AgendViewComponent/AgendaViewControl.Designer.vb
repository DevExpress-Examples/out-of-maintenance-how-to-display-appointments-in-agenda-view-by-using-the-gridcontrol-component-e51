Imports Microsoft.VisualBasic
Imports System
Namespace AgendViewComponent
	Partial Public Class AgendaViewControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.GridControlResources = New DevExpress.XtraGrid.GridControl()
			Me.layoutViewResources = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.layoutViewColumnName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.layoutViewField_layoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.Item1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.Item2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.GridControlAppointments = New DevExpress.XtraGrid.GridControl()
			Me.gridViewAppointments = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumnStatus = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEditIcon = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.gridColumnRecurring = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnReminder = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnDuration = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnLocation = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnAgendaDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItemAppointments = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItemResources = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.GridControlResources, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewResources, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Item1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Item2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GridControlAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEditIcon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItemAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItemResources, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.GridControlResources)
			Me.layoutControl1.Controls.Add(Me.GridControlAppointments)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(777, 562)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' GridControlResources
			' 
			Me.GridControlResources.Location = New System.Drawing.Point(2, 2)
			Me.GridControlResources.MainView = Me.layoutViewResources
			Me.GridControlResources.Name = "GridControlResources"
			Me.GridControlResources.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.GridControlResources.Size = New System.Drawing.Size(241, 558)
			Me.GridControlResources.TabIndex = 5
			Me.GridControlResources.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutViewResources})
			' 
			' layoutViewResources
			' 
			Me.layoutViewResources.Appearance.CardCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.layoutViewResources.Appearance.CardCaption.Options.UseFont = True
			Me.layoutViewResources.CardCaptionFormat = "{2}"
			Me.layoutViewResources.CardMinSize = New System.Drawing.Size(157, 160)
			Me.layoutViewResources.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.layoutViewColumnName, Me.layoutViewColumn1})
			Me.layoutViewResources.GridControl = Me.GridControlResources
			Me.layoutViewResources.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_layoutViewColumn1})
			Me.layoutViewResources.Name = "layoutViewResources"
			Me.layoutViewResources.OptionsBehavior.Editable = False
			Me.layoutViewResources.OptionsCustomization.AllowFilter = False
			Me.layoutViewResources.OptionsCustomization.AllowSort = False
			Me.layoutViewResources.OptionsView.AllowHotTrackFields = False
			Me.layoutViewResources.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None
			Me.layoutViewResources.OptionsView.ShowCardBorderIfCaptionHidden = False
			Me.layoutViewResources.OptionsView.ShowCardExpandButton = False
			Me.layoutViewResources.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
			Me.layoutViewResources.OptionsView.ShowHeaderPanel = False
			Me.layoutViewResources.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column
			Me.layoutViewResources.TemplateCard = Me.layoutViewCard1
'			Me.layoutViewResources.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.layoutViewResources_FocusedRowChanged);
'			Me.layoutViewResources.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.layoutViewResources_CustomUnboundColumnData);
			' 
			' layoutViewColumnName
			' 
			Me.layoutViewColumnName.Caption = "Name"
			Me.layoutViewColumnName.FieldName = "Caption"
			Me.layoutViewColumnName.LayoutViewField = Me.layoutViewField_layoutViewColumn1
			Me.layoutViewColumnName.Name = "layoutViewColumnName"
			' 
			' layoutViewField_layoutViewColumn1
			' 
			Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 140
			Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
			Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(120, 110)
			Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(31, 13)
			Me.layoutViewField_layoutViewColumn1.TextToControlDistance = 5
			' 
			' layoutViewColumn1
			' 
			Me.layoutViewColumn1.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.layoutViewColumn1.FieldName = "ResourceImage"
			Me.layoutViewColumn1.LayoutViewField = Me.layoutViewField_layoutViewColumn1_1
			Me.layoutViewColumn1.Name = "layoutViewColumn1"
			Me.layoutViewColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Object
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.ReadOnly = True
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
			' 
			' layoutViewField_layoutViewColumn1_1
			' 
			Me.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 96
			Me.layoutViewField_layoutViewColumn1_1.Location = New System.Drawing.Point(17, 0)
			Me.layoutViewField_layoutViewColumn1_1.MaxSize = New System.Drawing.Size(100, 100)
			Me.layoutViewField_layoutViewColumn1_1.MinSize = New System.Drawing.Size(100, 100)
			Me.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1"
			Me.layoutViewField_layoutViewColumn1_1.Size = New System.Drawing.Size(100, 100)
			Me.layoutViewField_layoutViewColumn1_1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutViewField_layoutViewColumn1_1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_layoutViewColumn1_1.TextToControlDistance = 0
			Me.layoutViewField_layoutViewColumn1_1.TextVisible = False
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_layoutViewColumn1_1, Me.emptySpaceItem1, Me.Item1, Me.Item2})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(117, 0)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(20, 100)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' Item1
			' 
			Me.Item1.AllowHotTrack = False
			Me.Item1.CustomizationFormText = "Item1"
			Me.Item1.Location = New System.Drawing.Point(0, 100)
			Me.Item1.Name = "Item1"
			Me.Item1.Size = New System.Drawing.Size(137, 21)
			Me.Item1.Text = "Item1"
			Me.Item1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' Item2
			' 
			Me.Item2.AllowHotTrack = False
			Me.Item2.CustomizationFormText = "Item2"
			Me.Item2.Location = New System.Drawing.Point(0, 0)
			Me.Item2.Name = "Item2"
			Me.Item2.Size = New System.Drawing.Size(17, 100)
			Me.Item2.Text = "Item2"
			Me.Item2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' GridControlAppointments
			' 
			Me.GridControlAppointments.Location = New System.Drawing.Point(247, 2)
			Me.GridControlAppointments.MainView = Me.gridViewAppointments
			Me.GridControlAppointments.Name = "GridControlAppointments"
			Me.GridControlAppointments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEditIcon})
			Me.GridControlAppointments.Size = New System.Drawing.Size(528, 558)
			Me.GridControlAppointments.TabIndex = 4
			Me.GridControlAppointments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewAppointments})
			' 
			' gridViewAppointments
			' 
			Me.gridViewAppointments.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold)
			Me.gridViewAppointments.Appearance.GroupRow.Options.UseFont = True
			Me.gridViewAppointments.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 10F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle)))
			Me.gridViewAppointments.Appearance.Preview.ForeColor = System.Drawing.Color.Blue
			Me.gridViewAppointments.Appearance.Preview.Options.UseFont = True
			Me.gridViewAppointments.Appearance.Preview.Options.UseForeColor = True
			Me.gridViewAppointments.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.gridViewAppointments.Appearance.Row.Options.UseFont = True
			Me.gridViewAppointments.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumnStatus, Me.gridColumnRecurring, Me.gridColumnReminder, Me.gridColumnSubject, Me.gridColumnDuration, Me.gridColumnLocation, Me.gridColumnAgendaDate})
			Me.gridViewAppointments.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
			Me.gridViewAppointments.GridControl = Me.GridControlAppointments
			Me.gridViewAppointments.GroupCount = 1
			Me.gridViewAppointments.GroupFormat = "{1}"
			Me.gridViewAppointments.GroupRowHeight = 50
			Me.gridViewAppointments.Name = "gridViewAppointments"
			Me.gridViewAppointments.OptionsBehavior.AutoExpandAllGroups = True
			Me.gridViewAppointments.OptionsBehavior.Editable = False
			Me.gridViewAppointments.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridViewAppointments.OptionsSelection.EnableAppearanceFocusedRow = False
			Me.gridViewAppointments.OptionsView.ColumnAutoWidth = False
			Me.gridViewAppointments.OptionsView.ShowColumnHeaders = False
			Me.gridViewAppointments.OptionsView.ShowGroupExpandCollapseButtons = False
			Me.gridViewAppointments.OptionsView.ShowGroupPanel = False
			Me.gridViewAppointments.OptionsView.ShowPreview = True
			Me.gridViewAppointments.OptionsView.ShowViewCaption = True
			Me.gridViewAppointments.PreviewFieldName = "AgendaDescription"
			Me.gridViewAppointments.RowHeight = 30
			Me.gridViewAppointments.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumnAgendaDate, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridViewAppointments.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridViewAppointments_CustomDrawCell);
'			Me.gridViewAppointments.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridViewAppointments_CustomDrawGroupRow);
'			Me.gridViewAppointments.RowStyle += New DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(Me.gridViewAppointments_RowStyle);
'			Me.gridViewAppointments.CustomRowCellEdit += New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(Me.gridViewAppointments_CustomRowCellEdit);
'			Me.gridViewAppointments.CustomRowCellEditForEditing += New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(Me.gridViewAppointments_CustomRowCellEditForEditing);
'			Me.gridViewAppointments.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(Me.gridViewAppointments_PopupMenuShowing);
'			Me.gridViewAppointments.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridViewAppointments_CustomUnboundColumnData);
'			Me.gridViewAppointments.CustomRowFilter += New DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(Me.gridViewAppointments_CustomRowFilter);
'			Me.gridViewAppointments.DoubleClick += New System.EventHandler(Me.gridViewAppointments_DoubleClick);
			' 
			' gridColumnStatus
			' 
			Me.gridColumnStatus.Caption = " "
			Me.gridColumnStatus.ColumnEdit = Me.repositoryItemPictureEditIcon
			Me.gridColumnStatus.FieldName = "AgendaStatus"
			Me.gridColumnStatus.Name = "gridColumnStatus"
			Me.gridColumnStatus.OptionsColumn.AllowEdit = False
			Me.gridColumnStatus.OptionsColumn.FixedWidth = True
			Me.gridColumnStatus.Visible = True
			Me.gridColumnStatus.VisibleIndex = 0
			Me.gridColumnStatus.Width = 41
			' 
			' repositoryItemPictureEditIcon
			' 
			Me.repositoryItemPictureEditIcon.Name = "repositoryItemPictureEditIcon"
			Me.repositoryItemPictureEditIcon.NullText = " "
			' 
			' gridColumnRecurring
			' 
			Me.gridColumnRecurring.Caption = " "
			Me.gridColumnRecurring.ColumnEdit = Me.repositoryItemPictureEditIcon
			Me.gridColumnRecurring.FieldName = "gridColumnRecurring"
			Me.gridColumnRecurring.Name = "gridColumnRecurring"
			Me.gridColumnRecurring.OptionsColumn.FixedWidth = True
			Me.gridColumnRecurring.UnboundType = DevExpress.Data.UnboundColumnType.Object
			Me.gridColumnRecurring.Visible = True
			Me.gridColumnRecurring.VisibleIndex = 1
			Me.gridColumnRecurring.Width = 20
			' 
			' gridColumnReminder
			' 
			Me.gridColumnReminder.Caption = " "
			Me.gridColumnReminder.ColumnEdit = Me.repositoryItemPictureEditIcon
			Me.gridColumnReminder.FieldName = "gridColumnReminder"
			Me.gridColumnReminder.Name = "gridColumnReminder"
			Me.gridColumnReminder.OptionsColumn.FixedWidth = True
			Me.gridColumnReminder.UnboundType = DevExpress.Data.UnboundColumnType.Object
			Me.gridColumnReminder.Visible = True
			Me.gridColumnReminder.VisibleIndex = 2
			Me.gridColumnReminder.Width = 20
			' 
			' gridColumnSubject
			' 
			Me.gridColumnSubject.Caption = "Subject"
			Me.gridColumnSubject.FieldName = "AgendaSubject"
			Me.gridColumnSubject.Name = "gridColumnSubject"
			Me.gridColumnSubject.Visible = True
			Me.gridColumnSubject.VisibleIndex = 3
			Me.gridColumnSubject.Width = 166
			' 
			' gridColumnDuration
			' 
			Me.gridColumnDuration.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle)))
			Me.gridColumnDuration.AppearanceCell.Options.UseFont = True
			Me.gridColumnDuration.Caption = "Duration"
			Me.gridColumnDuration.FieldName = "AgendaDuration"
			Me.gridColumnDuration.Name = "gridColumnDuration"
			Me.gridColumnDuration.Visible = True
			Me.gridColumnDuration.VisibleIndex = 4
			Me.gridColumnDuration.Width = 128
			' 
			' gridColumnLocation
			' 
			Me.gridColumnLocation.Caption = "Location"
			Me.gridColumnLocation.FieldName = "AgendaLocation"
			Me.gridColumnLocation.Name = "gridColumnLocation"
			Me.gridColumnLocation.Visible = True
			Me.gridColumnLocation.VisibleIndex = 5
			Me.gridColumnLocation.Width = 98
			' 
			' gridColumnAgendaDate
			' 
			Me.gridColumnAgendaDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 16F)
			Me.gridColumnAgendaDate.AppearanceCell.Options.UseFont = True
			Me.gridColumnAgendaDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 16F)
			Me.gridColumnAgendaDate.AppearanceHeader.Options.UseFont = True
			Me.gridColumnAgendaDate.DisplayFormat.FormatString = "dd (dddd) - MMMM - yyyy"
			Me.gridColumnAgendaDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.gridColumnAgendaDate.FieldName = "AgendaDate"
			Me.gridColumnAgendaDate.GroupFormat.FormatString = "dd (dddd) - MMMM - yyyy"
			Me.gridColumnAgendaDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.gridColumnAgendaDate.Name = "gridColumnAgendaDate"
			Me.gridColumnAgendaDate.Visible = True
			Me.gridColumnAgendaDate.VisibleIndex = 6
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItemAppointments, Me.layoutControlItemResources})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(777, 562)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItemAppointments
			' 
			Me.layoutControlItemAppointments.Control = Me.GridControlAppointments
			Me.layoutControlItemAppointments.CustomizationFormText = "layoutControlItemAppointments"
			Me.layoutControlItemAppointments.Location = New System.Drawing.Point(245, 0)
			Me.layoutControlItemAppointments.Name = "layoutControlItemAppointments"
			Me.layoutControlItemAppointments.Size = New System.Drawing.Size(532, 562)
			Me.layoutControlItemAppointments.Text = "layoutControlItemAppointments"
			Me.layoutControlItemAppointments.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItemAppointments.TextToControlDistance = 0
			Me.layoutControlItemAppointments.TextVisible = False
			' 
			' layoutControlItemResources
			' 
			Me.layoutControlItemResources.Control = Me.GridControlResources
			Me.layoutControlItemResources.CustomizationFormText = "layoutControlItemResources"
			Me.layoutControlItemResources.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItemResources.Name = "layoutControlItemResources"
			Me.layoutControlItemResources.Size = New System.Drawing.Size(245, 562)
			Me.layoutControlItemResources.Text = "layoutControlItemResources"
			Me.layoutControlItemResources.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItemResources.TextToControlDistance = 0
			Me.layoutControlItemResources.TextVisible = False
			' 
			' AgendaViewControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "AgendaViewControl"
			Me.Size = New System.Drawing.Size(777, 562)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.GridControlResources, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewResources, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Item1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Item2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GridControlAppointments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewAppointments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEditIcon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItemAppointments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItemResources, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private GridControlResources As DevExpress.XtraGrid.GridControl
		Private GridControlAppointments As DevExpress.XtraGrid.GridControl
		Private WithEvents gridViewAppointments As DevExpress.XtraGrid.Views.Grid.GridView
		Private layoutControlItemAppointments As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItemResources As DevExpress.XtraLayout.LayoutControlItem
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private WithEvents layoutViewResources As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private layoutViewColumnName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_layoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private Item1 As DevExpress.XtraLayout.EmptySpaceItem
		Private Item2 As DevExpress.XtraLayout.EmptySpaceItem
		Private gridColumnStatus As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnRecurring As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnReminder As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnDuration As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnLocation As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnAgendaDate As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemPictureEditIcon As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
	End Class
End Namespace
