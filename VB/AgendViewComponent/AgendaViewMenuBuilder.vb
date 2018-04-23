Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraGrid.Menu
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Reflection

Namespace AgendViewComponent
	Public NotInheritable Class AgendaViewMenuBuilder
        Private Shared privateScheduler As SchedulerControl
		Public Shared Property Scheduler() As SchedulerControl
			Get
				Return privateScheduler
			End Get
			Set(ByVal value As SchedulerControl)
				privateScheduler = value
			End Set
		End Property
        Private Shared privateCurrentAppointment As Appointment
		Public Shared Property CurrentAppointment() As Appointment
			Get
				Return privateCurrentAppointment
			End Get
			Set(ByVal value As Appointment)
				privateCurrentAppointment = value
			End Set
		End Property

        Private Shared privateViewControl As AgendaViewControl
		Public Shared Property ViewControl() As AgendaViewControl
			Get
				Return privateViewControl
			End Get
			Set(ByVal value As AgendaViewControl)
				privateViewControl = value
			End Set
		End Property

		Private Sub New()
		End Sub
        Public Shared Sub GenerateContextMenu(ByVal parViewControl As AgendaViewControl, ByVal contextMenu As GridViewMenu, ByVal control As SchedulerControl, ByVal apt As Appointment)
            Scheduler = control
            CurrentAppointment = apt
            ViewControl = parViewControl
            If apt IsNot Nothing Then
                contextMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Open appointment", AddressOf OnOpenCurrentAppointment))
                contextMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Delete appointment", AddressOf OnDeleteCurrentAppointment, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Delete.png"))))
            End If

            Dim nextInterval As New DevExpress.Utils.Menu.DXMenuItem("Go to the next month", AddressOf OnNextInterval, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("NextArrow.png")))
            nextInterval.BeginGroup = True

            contextMenu.Items.Add(nextInterval)
            contextMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Go to the previous month", AddressOf OnPreviousInterval, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("PrevArrow.png"))))
            contextMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Go to the specific date", AddressOf OnGoToSpecificDate))

            Dim switchView As New DevExpress.Utils.Menu.DXSubMenuItem("Change view to")
            switchView.BeginGroup = True
            contextMenu.Items.Add(switchView)

            If Scheduler.DayView.Enabled Then
                switchView.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Day View", AddressOf OnSwitchToDayView, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DayView.png"))))
            End If
            If Scheduler.WorkWeekView.Enabled Then
                switchView.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Work Week View", AddressOf OnSwitchToWorkWeekView, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("WorkWeekView.png"))))
            End If
            If Scheduler.WeekView.Enabled Then
                switchView.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Week View", AddressOf OnSwitchToWeekView, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("WeekView.png"))))
            End If
            If Scheduler.MonthView.Enabled Then
                switchView.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Month View", AddressOf OnSwitchToMonthView, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("MonthView.png"))))
            End If
            If Scheduler.TimelineView.Enabled Then
                switchView.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Timeline View", AddressOf OnSwitchToTimelineView, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("TimelineView.png"))))
            End If
            If Scheduler.GanttView.Enabled Then
                switchView.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Gantt View", AddressOf OnSwitchToGanttView, Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("GanttView.png"))))
            End If

            If apt IsNot Nothing Then
                contextMenu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem(If(viewControl.ShowResources, "Show all appointments", "Group appointments by resources"), AddressOf OnSwitchResourcesVisibility))
            End If
        End Sub

		Public Shared Sub OnOpenCurrentAppointment(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.ShowEditAppointmentForm(CurrentAppointment, CurrentAppointment.IsRecurring)
			ViewControl.InitializeGridControlAppointments()
		End Sub

		Public Shared Sub OnDeleteCurrentAppointment(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.DeleteAppointment(CurrentAppointment)
			ViewControl.InitializeGridControlAppointments()
		End Sub

		Public Shared Sub OnGoToSpecificDate(ByVal sender As Object, ByVal e As EventArgs)
			Dim dateDialog As New GoToDateDialog()
			dateDialog.SelectedDate = AgendaViewDataGenerator.SelectedInterval.Start
			Dim result As DialogResult = dateDialog.ShowDialog()
			If result = DialogResult.OK Then
				Dim intervalStart As New DateTime(dateDialog.SelectedDate.Year, dateDialog.SelectedDate.Month, 1)
				AgendaViewDataGenerator.SelectedInterval = New TimeInterval(intervalStart, intervalStart.AddMonths(1))
				ViewControl.InitializeGridControlAppointments()
				ViewControl.GenerateAgndaViewCaption()
			End If
		End Sub

		Public Shared Sub OnNextInterval(ByVal sender As Object, ByVal e As EventArgs)
			AgendaViewDataGenerator.SelectedInterval = New TimeInterval(AgendaViewDataGenerator.SelectedInterval.End, AgendaViewDataGenerator.SelectedInterval.End.AddMonths(1))
			ViewControl.InitializeGridControlAppointments()
			ViewControl.GenerateAgndaViewCaption()
		End Sub

		Public Shared Sub OnPreviousInterval(ByVal sender As Object, ByVal e As EventArgs)
			AgendaViewDataGenerator.SelectedInterval = New TimeInterval(AgendaViewDataGenerator.SelectedInterval.Start.AddMonths(-1), AgendaViewDataGenerator.SelectedInterval.Start)
			ViewControl.InitializeGridControlAppointments()
			ViewControl.GenerateAgndaViewCaption()
		End Sub

		Public Shared Sub OnSwitchToDayView(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.ActiveViewType = SchedulerViewType.Day
			AgendaViewHelper.SwitchToNormalView()
		End Sub

		Public Shared Sub OnSwitchToWorkWeekView(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.ActiveViewType = SchedulerViewType.WorkWeek
			AgendaViewHelper.SwitchToNormalView()
		End Sub

		Public Shared Sub OnSwitchToWeekView(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.ActiveViewType = SchedulerViewType.Week
			AgendaViewHelper.SwitchToNormalView()
		End Sub

		Public Shared Sub OnSwitchToMonthView(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.ActiveViewType = SchedulerViewType.Month
			AgendaViewHelper.SwitchToNormalView()
		End Sub

		Public Shared Sub OnSwitchToTimelineView(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.ActiveViewType = SchedulerViewType.Timeline
			AgendaViewHelper.SwitchToNormalView()
		End Sub

		Public Shared Sub OnSwitchToGanttView(ByVal sender As Object, ByVal e As EventArgs)
			Scheduler.ActiveViewType = SchedulerViewType.Gantt
			AgendaViewHelper.SwitchToNormalView()
		End Sub

		Public Shared Sub OnSwitchResourcesVisibility(ByVal sender As Object, ByVal e As EventArgs)
			ViewControl.ShowResources = Not ViewControl.ShowResources
		End Sub
	End Class
End Namespace
