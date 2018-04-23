Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraEditors.Controls

Namespace AgendViewComponent
    Partial Public Class AgendaViewControl
        Inherits UserControl

        Private OwnerScheduler As SchedulerControl
        Private _showResources As Boolean = False
        Private selectedResourceId As Object = Nothing
        Private noPhotoImage As Image = Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("no_photo_icon.jpg"))

        Private appointmentImages As ImageCollection
        Public Sub New(ByVal showResources As Boolean, ByVal scheduler As SchedulerControl)
            InitializeComponent()

            OwnerScheduler = scheduler
            Me.ShowResources = showResources
            Dim selectedIntervalStart As DateTime = OwnerScheduler.ActiveView.GetVisibleIntervals().Start
            Dim intervalStart As New DateTime(selectedIntervalStart.Year, selectedIntervalStart.Month, 1)
            AgendaViewDataGenerator.SelectedInterval = New TimeInterval(intervalStart, intervalStart.AddMonths(1))

            InitializeGridControlResources()
            InitializeGridControlAppointments()
            gridViewAppointments.ExpandAllGroups()

            appointmentImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("AppointmentImages.png", System.Reflection.Assembly.GetExecutingAssembly(), New Size(15, 15))

            Dim reStatus As RepositoryItemImageComboBox = TryCast(GridControlAppointments.RepositoryItems.Add("ImageComboBoxEdit"), RepositoryItemImageComboBox)
            CreateCustomColorsForStatuses(reStatus)
            gridViewAppointments.Columns("AgendaStatus").ColumnEdit = reStatus
        End Sub

#Region "Properties"
        Public Property ShowResources() As Boolean
            Get
                Return _showResources
            End Get
            Set(ByVal value As Boolean)
                If _showResources <> value Then
                    _showResources = value
                    SwitchResourcesVisibility()
                    GridControlAppointments.RefreshDataSource()
                End If
            End Set
        End Property
#End Region

#Region "Methods"
        Private Sub SwitchResourcesVisibility()
            layoutControlItemResources.Visibility = If(ShowResources, DevExpress.XtraLayout.Utils.LayoutVisibility.Always, DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization)
        End Sub

        Private Sub InitializeGridControlResources()
            GridControlResources.DataSource = AgendaViewDataGenerator.GenerateResourcesCollection(OwnerScheduler.Storage)
        End Sub

        Public Sub InitializeGridControlAppointments()
            GridControlAppointments.DataSource = AgendaViewDataGenerator.GenerateAgendaAppointmentCollection(OwnerScheduler.Storage)
        End Sub

        Private Function GetLightenColor(ByVal inColor As Color, ByVal inAmount As Double) As Color
            Return Color.FromArgb(inColor.A, CInt(Fix(Math.Min(255, inColor.R + 255 * inAmount))), CInt(Fix(Math.Min(255, inColor.G + 255 * inAmount))), CInt(Fix(Math.Min(255, inColor.B + 255 * inAmount))))
        End Function

        Private Sub CreateCustomColorsForStatuses(ByVal riImageComboBox As RepositoryItemImageComboBox)
            For Each status As AppointmentStatus In OwnerScheduler.Storage.Appointments.Statuses
                riImageComboBox.Items.Add(New ImageComboBoxItem(status.Color.ToString(), status))
            Next status

            Dim imagesColors As New ImageList()
            riImageComboBox.SmallImages = imagesColors

            For Each item As ImageComboBoxItem In riImageComboBox.Items
                Dim iWidth As Integer = 16
                Dim iHeight As Integer = 16
                Dim bmp As New Bitmap(iWidth, iHeight)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.DrawRectangle(New Pen(Color.Black, 2), 0, 0, iWidth, iHeight)
                    g.FillRectangle(New SolidBrush((TryCast(item.Value, AppointmentStatus)).Color), 1, 1, iWidth - 2, iHeight - 2)

                End Using
                imagesColors.Images.Add(bmp)
                item.ImageIndex = imagesColors.Images.Count - 1
            Next item
        End Sub

#End Region


#Region "Event Handlers"
        Private Sub layoutViewResources_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles layoutViewResources.CustomUnboundColumnData
            If e.Column.FieldName = "ResourceImage" AndAlso e.IsGetData Then
                Dim resourceImage As Image = (TryCast(e.Row, DevExpress.XtraScheduler.Resource)).Image
                If resourceImage Is Nothing Then
                    resourceImage = noPhotoImage
                End If
                e.Value = resourceImage
            End If
        End Sub

        Private Sub layoutViewResources_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles layoutViewResources.FocusedRowChanged
            selectedResourceId = (TryCast((TryCast(sender, ColumnView)).GetRow(e.FocusedRowHandle), Resource)).Id
            gridViewAppointments.RefreshData()
            GenerateAgndaViewCaption()
        End Sub

        Private Sub gridViewAppointments_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs) Handles gridViewAppointments.CustomRowFilter
            If ShowResources AndAlso selectedResourceId IsNot Nothing Then
                Dim sourceAppointment As Appointment = (TryCast((TryCast(sender, ColumnView)).GetRow(e.ListSourceRow), AgendaAppointment)).SourceAppointment
                e.Visible = sourceAppointment.ResourceIds.Contains(selectedResourceId)
                e.Handled = True
            End If

        End Sub

        Private Sub gridViewAppointments_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles gridViewAppointments.CustomUnboundColumnData
            Dim currentApt As Appointment = (TryCast(e.Row, AgendaAppointment)).SourceAppointment
            If e.Column.FieldName = "gridColumnRecurring" AndAlso e.IsGetData AndAlso currentApt.IsRecurring Then
                e.Value = appointmentImages.Images(2)
            End If

            If e.Column.FieldName = "gridColumnReminder" AndAlso e.IsGetData AndAlso currentApt.HasReminder Then
                e.Value = appointmentImages.Images(4)
            End If
        End Sub

        Private Sub gridViewAppointments_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridViewAppointments.RowStyle
            Dim currentView As GridView = TryCast(sender, GridView)
            If (Not currentView.IsGroupRow(e.RowHandle)) Then
                Dim currentAppointment As AgendaAppointment = TryCast((TryCast(sender, GridView)).GetRow(e.RowHandle), AgendaAppointment)
                e.Appearance.BackColor = currentAppointment.AgendaLabel
            End If
        End Sub

        Private Sub gridViewAppointments_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridViewAppointments.PopupMenuShowing
            If e.HitInfo.HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell Then
                Dim currentView As GridView = TryCast(sender, GridView)
                Dim agendaAppointment As AgendaAppointment = TryCast(currentView.GetRow(e.HitInfo.RowHandle), AgendaAppointment)
                AgendaViewMenuBuilder.GenerateContextMenu(Me, e.Menu, OwnerScheduler, agendaAppointment.SourceAppointment)
            End If
            If e.HitInfo.HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.EmptyRow Then
                If e.Menu Is Nothing Then
                    e.Menu = New DevExpress.XtraGrid.Menu.GridViewMenu(TryCast(sender, GridView))
                End If
                AgendaViewMenuBuilder.GenerateContextMenu(Me, e.Menu, OwnerScheduler, Nothing)
            End If
        End Sub

        Private Sub gridViewAppointments_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs) Handles gridViewAppointments.CustomDrawGroupRow
            Dim view As GridView = TryCast(sender, GridView)
            If e.RowHandle = view.FocusedRowHandle Then
                e.Appearance.Font = view.Appearance.GroupRow.Font
                e.Appearance.BackColor = view.Appearance.GroupRow.GetBackColor()
            End If
        End Sub

        Private Sub gridViewAppointments_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs) Handles gridViewAppointments.CustomDrawCell
            Dim view As GridView = TryCast(sender, GridView)
            If e.RowHandle = view.FocusedRowHandle Then
                If (Not view.IsGroupRow(e.RowHandle)) Then
                    Dim currentAppointment As AgendaAppointment = TryCast((TryCast(sender, GridView)).GetRow(e.RowHandle), AgendaAppointment)
                    e.Appearance.BackColor = GetLightenColor(currentAppointment.AgendaLabel, 0.1)
                End If
            End If
        End Sub

        Private Sub gridViewAppointments_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridViewAppointments.DoubleClick
            Dim currentView As GridView = TryCast(sender, GridView)
            If (Not currentView.IsGroupRow(currentView.FocusedRowHandle)) Then
                AgendaViewMenuBuilder.Scheduler = OwnerScheduler
                Dim agendaAppointment As AgendaAppointment = TryCast(currentView.GetRow(currentView.FocusedRowHandle), AgendaAppointment)
                AgendaViewMenuBuilder.CurrentAppointment = agendaAppointment.SourceAppointment
                AgendaViewMenuBuilder.ViewControl = Me
                AgendaViewMenuBuilder.OnOpenCurrentAppointment(Nothing, Nothing)
            End If
        End Sub

        Public Sub GenerateAgndaViewCaption()
            Dim currentMonth As String = AgendaViewDataGenerator.SelectedInterval.Start.ToString("MMMM")
            Dim rowCount As Integer = gridViewAppointments.RowCount
            If rowCount = 0 Then
                gridViewAppointments.ViewCaption = currentMonth & " (no data)"
            ElseIf ShowResources Then
                Dim resourceCaption As Object = layoutViewResources.GetFocusedRowCellValue("Caption")
                If resourceCaption Is Nothing Then
                    gridViewAppointments.ViewCaption = currentMonth
                Else
                    gridViewAppointments.ViewCaption = currentMonth & " (" & resourceCaption.ToString() & ")"
                End If

            Else
                gridViewAppointments.ViewCaption = currentMonth
            End If

        End Sub
#End Region
    End Class
End Namespace
