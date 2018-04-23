Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraLayout
Imports System.Windows.Forms
Imports System.Reflection
Imports System.IO
Imports System.Drawing
Imports DevExpress.Utils.Menu

Namespace AgendViewComponent
	Public NotInheritable Class AgendaViewHelper
		Private Shared AgendaView As AgendaViewControl
		Private Shared CurrentScheduler As SchedulerControl
		Private Shared navigator As DateNavigator

		Private Sub New()
		End Sub
		Public Shared Sub AddAgendaView(ByVal scheduler As SchedulerControl, ByVal dateNavigator As DateNavigator, ByVal showResources As Boolean)
			CurrentScheduler = scheduler
			navigator = dateNavigator
			If Not(TypeOf scheduler.Parent Is LayoutControl) Then
				MessageBox.Show("SchedulerControl should be located within a LayoutControl to enable AgendaView functionality")
			Else
				AgendaView = New AgendaViewControl(showResources, CurrentScheduler)
				AddHandler CurrentScheduler.PopupMenuShowing, AddressOf CurrentScheduler_PopupMenuShowing
				Dim currentLayout As LayoutControl = TryCast(scheduler.Parent, LayoutControl)
				Dim schedulerLayoutItem As LayoutControlItem = currentLayout.GetItemByControl(CurrentScheduler)
				'Create a layout item and add it to the root group.    
				Dim itemAgendaView As LayoutControlItem = TryCast(currentLayout.Root.AddItem(schedulerLayoutItem, DevExpress.XtraLayout.Utils.InsertType.Top), LayoutControlItem)
				' Set the item's Control and caption.
				itemAgendaView.Name = "layoutControlItemAgendaView"
				itemAgendaView.Control = AgendaView
				itemAgendaView.TextVisible = False

				ChangeControlsVisibility(CurrentScheduler, True)
				If navigator IsNot Nothing Then
					ChangeControlsVisibility(navigator, True)
				End If
				ChangeControlsVisibility(AgendaView, False)
			End If
		End Sub

		Private Shared Sub CurrentScheduler_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs)
            Dim imageStream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Report.png")
			For Each item As DXMenuItem In e.Menu.Items
				Dim menuItem As SchedulerPopupMenu = TryCast(item, SchedulerPopupMenu)
				If menuItem IsNot Nothing AndAlso menuItem.Id = SchedulerMenuItemId.SwitchViewMenu Then
					menuItem.Items.Add(New DXMenuItem("Agenda View", AddressOf OnSwitchToAgendaView, New Bitmap(Image.FromStream(imageStream), New Size(16, 16))))
				End If
			Next item
		End Sub

		Public Shared Sub SwitchToAgendaView()
			ChangeControlsVisibility(CurrentScheduler, False)
			If navigator IsNot Nothing Then
				ChangeControlsVisibility(navigator, False)
			End If

			AgendaView.InitializeGridControlAppointments()
			ChangeControlsVisibility(AgendaView, True)
		End Sub

		Public Shared Sub SwitchToNormalView()
			ChangeControlsVisibility(CurrentScheduler, True)
			If navigator IsNot Nothing Then
				ChangeControlsVisibility(navigator, True)
			End If
			ChangeControlsVisibility(AgendaView, False)
		End Sub

		Private Shared Sub OnSwitchToAgendaView(ByVal sender As Object, ByVal e As EventArgs)
			SwitchToAgendaView()
		End Sub

		Private Shared Sub ChangeControlsVisibility(ByVal someControl As Control, ByVal visibility As Boolean)
			If TypeOf someControl.Parent Is LayoutControl Then
				TryCast(someControl.Parent, LayoutControl).GetItemByControl(someControl).Visibility = If(visibility, DevExpress.XtraLayout.Utils.LayoutVisibility.Always, DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization)
			Else
				someControl.Visible = visibility
			End If
		End Sub

	End Class
End Namespace
