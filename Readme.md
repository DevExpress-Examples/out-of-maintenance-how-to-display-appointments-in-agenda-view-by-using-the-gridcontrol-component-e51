<!-- default file list -->
*Files to look at*:

* [AgendaViewControl.cs](./CS/AgendViewComponent/AgendaViewControl.cs) (VB: [AgendaViewControl.Designer.vb](./VB/AgendViewComponent/AgendaViewControl.Designer.vb))
* [AgendaViewControl.Designer.cs](./CS/AgendViewComponent/AgendaViewControl.Designer.cs) (VB: [AgendaViewControl.Designer.vb](./VB/AgendViewComponent/AgendaViewControl.Designer.vb))
* [AgendaViewDataGenerator.cs](./CS/AgendViewComponent/AgendaViewDataGenerator.cs) (VB: [AgendaViewDataGenerator.vb](./VB/AgendViewComponent/AgendaViewDataGenerator.vb))
* [AgendaViewHelper.cs](./CS/AgendViewComponent/AgendaViewHelper.cs) (VB: [AgendaViewHelper.vb](./VB/AgendViewComponent/AgendaViewHelper.vb))
* [AgendaViewMenuBuilder.cs](./CS/AgendViewComponent/AgendaViewMenuBuilder.cs) (VB: [AgendaViewMenuBuilder.vb](./VB/AgendViewComponent/AgendaViewMenuBuilder.vb))
* [GoToDateDialog.cs](./CS/AgendViewComponent/GoToDateDialog.cs) (VB: [GoToDateDialog.vb](./VB/AgendViewComponent/GoToDateDialog.vb))
* [CustomObjects.cs](./CS/WindowsFormsApplication1/CustomObjects.cs) (VB: [CustomObjects.vb](./VB/WindowsFormsApplication1/CustomObjects.vb))
* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
<!-- default file list end -->
# How to display appointments in Agenda View by using the GridControl component


<p>In fact, the Agenda view is a list of upcoming events grouped by the appointment's date. This list can be displayed in the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument3464"><u>GridControl component</u></a>.</p>
<p>This example demonstrates how to implement this behavior.</p>
<br />
<p>Switching between the SchedulerControl's view and a GridControl instance (used as an AgendaView) is implemented by switching the visibility of the SchedulerControl and GridControl instances.</p>
<p>Since multi-day appointments should be displayed as several GridView rows (such appointments should be displayed in each "Day" group in accordance with the appointment's duration), we used a separate AgendaAppointment class to store the appointment's data.</p>
<p>To get existing appointments from the SchedulerStorage and generate a corresponding collection of AgendaAppointment instances, the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_GetAppointmentstopic1830"><u>SchedulerStorage.GetAppointments</u></a> method is used.</p>
<p>By default, a month interval is used to fetch appointments for the AgendaView.<br /><br /></p>
<p><strong>Please see the "Implementation Details" (click the corresponding link below this text) to learn more about technical aspects of this approach implementation.</strong></p>


<h3>Description</h3>

<p>As you can see, in this example several static classes are used:</p>
<p><strong>AgendaViewDataGenerator</strong> - used to generate a list of AgendaAppointment instances depending on existing appointments.</p>
<p><strong>AgendaViewMenuBuilder</strong> - used to generate the GridControl's context menu with the following commands: Open appointment, Delete appointment, Go to the next interval, Go to the previous interval, Switch to other views</p>
<p><strong>AgendaViewHelper</strong> - used to add the Agenda view functionality into an existing project and add a corresponding menu item into the SchedulerControl's context menu.</p>
<br />
<p>The GridControl is used to display the AgendaView located within the "<strong>AgendaViewControl</strong>" UserControl.</p>
<p><br />The main condition for adding the AgendaView functionality into the existing project is that the SchedulerControl (and DateNavigator if it is used in an application) are located within the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument2210"><u>LayoutControl instance</u></a>.</p>
<p>All classes that support the AgendaView functionality are created within a separate Class Library project. To include the AgendaView functionality into the existing application, you can simply add a reference to the AgendViewComponent.dll library and write the following code line in the main form:</p>
<code lang="cs">AgendaViewHelper.AddAgendaView(schedulerControl1, dateNavigator1, true);</code>
<code lang="vb">AgendaViewHelper.AddAgendaView(schedulerControl1, dateNavigator1, True)</code>

<br/>


