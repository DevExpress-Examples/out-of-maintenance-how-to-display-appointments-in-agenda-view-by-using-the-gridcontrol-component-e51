Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports System.Reflection
Imports System.IO
Imports AgendViewComponent

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Shared RandomInstance As New Random()

		Private CustomResourceCollection As New BindingList(Of CustomResource)()
		Private CustomEventList As New BindingList(Of CustomAppointment)()

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitResources()
			InitAppointments()
			schedulerControl1.Start = DateTime.Now
			schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource

			AgendaViewHelper.AddAgendaView(schedulerControl1, dateNavigator1, True)
			'AgendViewHelper.AddAgendaView(schedulerControl1, null, true);
			AgendaViewHelper.SwitchToAgendaView()
		End Sub

		Private Sub InitResources()
			Dim mappings As ResourceMappingInfo = Me.schedulerStorage1.Resources.Mappings
			mappings.Id = "ResID"
			mappings.Caption = "Name"
			mappings.Image = "ResImage"

            CustomResourceCollection.Add(CreateCustomResource(1, "Max Fowler", Color.PowderBlue, System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("MaxFowlerPhoto.jpg")))
            CustomResourceCollection.Add(CreateCustomResource(2, "Nancy Drewmore", Color.PaleVioletRed, System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("NancyDrewmorePhoto.jpg")))
			CustomResourceCollection.Add(CreateCustomResource(3, "Pak Jang", Color.PeachPuff, Nothing))
			Me.schedulerStorage1.Resources.DataSource = CustomResourceCollection
		End Sub

		Private Function CreateCustomResource(ByVal res_id As Integer, ByVal caption As String, ByVal ResColor As Color, ByVal imageStream As Stream) As CustomResource
			Dim cr As New CustomResource()
			cr.ResID = res_id
			cr.Name = caption
			If imageStream IsNot Nothing Then
				cr.ResImage = Image.FromStream(imageStream)
			End If

			Return cr
		End Function



		Private Sub InitAppointments()
			Dim mappings As AppointmentMappingInfo = Me.schedulerStorage1.Appointments.Mappings
			mappings.Start = "StartTime"
			mappings.End = "EndTime"
			mappings.Subject = "Subject"
			mappings.AllDay = "AllDay"
			mappings.Description = "Description"
			mappings.Label = "Label"
			mappings.Location = "Location"
			mappings.RecurrenceInfo = "RecurrenceInfo"
			mappings.ReminderInfo = "ReminderInfo"
			mappings.ResourceId = "OwnerId"
			mappings.Status = "Status"
			mappings.Type = "EventType"

			GenerateEvents(CustomEventList)
			Me.schedulerStorage1.Appointments.DataSource = CustomEventList
		End Sub


		Private Sub GenerateEvents(ByVal eventList As BindingList(Of CustomAppointment))
			Dim count As Integer = schedulerStorage1.Resources.Count

			For i As Integer = 0 To count - 1
				Dim resource As Resource = schedulerStorage1.Resources(i)
				Dim subjPrefix As String = resource.Caption & "'s "
				eventList.Add(CreateEvent(subjPrefix & "meeting", "meeting", resource.Id, 2, 5, 0, "office"))
				eventList.Add(CreateEvent(subjPrefix & "travel", "travel", resource.Id, 3, 6, 0, "out of the city"))
				eventList.Add(CreateEvent(subjPrefix & "phone call", "phone call", resource.Id, 0, 10, 0, "office"))
				eventList.Add(CreateEvent(subjPrefix & "business trip", "business trip", resource.Id, 3, 6, 3, "San-Francisco"))
				eventList.Add(CreateEvent(subjPrefix & "double personal day", "double personal day", resource.Id, 0, 10, 2, "out of the city"))
				eventList.Add(CreateEvent(subjPrefix & "personal day", "personal day", resource.Id, 0, 10, 1, "out of the city"))
			Next i



		End Sub
		Private Function CreateEvent(ByVal description As String, ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer, ByVal days As Integer, ByVal location As String) As CustomAppointment
			Dim apt As New CustomAppointment()
			apt.Subject = subject
			apt.Description = description
			apt.OwnerId = resourceId
			Dim rnd As Random = RandomInstance
			Dim rangeInMinutes As Integer = 60 * 24
			If days = 2 Then
				apt.StartTime = DateTime.Today
				apt.EndTime = DateTime.Today.AddDays(2)
			ElseIf days = 1 Then
				apt.StartTime = DateTime.Today
				apt.EndTime = DateTime.Today.AddDays(1)
			Else
				apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
				apt.EndTime = apt.StartTime.AddDays(days) + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4))
			End If
			apt.Location = location
			apt.Status = status
			apt.Label = label
			Return apt
		End Function

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub appointmentStatusEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace
