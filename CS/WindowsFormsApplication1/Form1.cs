using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;
using System.Reflection;
using System.IO;
using AgendViewComponent;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public static Random RandomInstance = new Random();

        private BindingList<CustomResource> CustomResourceCollection = new BindingList<CustomResource>();
        private BindingList<CustomAppointment> CustomEventList = new BindingList<CustomAppointment>();

        private void Form1_Load(object sender, EventArgs e) {
            InitResources();
            InitAppointments();
            schedulerControl1.Start = DateTime.Now;
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;

            AgendaViewHelper.AddAgendaView(schedulerControl1, dateNavigator1, true);
            //AgendViewHelper.AddAgendaView(schedulerControl1, null, true);
            AgendaViewHelper.SwitchToAgendaView();
        }

        private void InitResources() {
            ResourceMappingInfo mappings = this.schedulerStorage1.Resources.Mappings;
            mappings.Id = "ResID";
            mappings.Caption = "Name";
            mappings.Image = "ResImage";

            CustomResourceCollection.Add(CreateCustomResource(1, "Max Fowler", Color.PowderBlue, Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.MaxFowlerPhoto.jpg")));
            CustomResourceCollection.Add(CreateCustomResource(2, "Nancy Drewmore", Color.PaleVioletRed, Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.NancyDrewmorePhoto.jpg")));
            CustomResourceCollection.Add(CreateCustomResource(3, "Pak Jang", Color.PeachPuff, null));
            this.schedulerStorage1.Resources.DataSource = CustomResourceCollection;
        }

        private CustomResource CreateCustomResource(int res_id, string caption, Color ResColor, Stream imageStream) {
            CustomResource cr = new CustomResource();
            cr.ResID = res_id;
            cr.Name = caption;
            if(imageStream != null) {
                cr.ResImage = Image.FromStream(imageStream);
            }

            return cr;
        }



        private void InitAppointments() {
            AppointmentMappingInfo mappings = this.schedulerStorage1.Appointments.Mappings;
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "OwnerId";
            mappings.Status = "Status";
            mappings.Type = "EventType";

            GenerateEvents(CustomEventList);
            this.schedulerStorage1.Appointments.DataSource = CustomEventList;
        }


        private void GenerateEvents(BindingList<CustomAppointment> eventList) {
            int count = schedulerStorage1.Resources.Count;

            for(int i = 0; i < count; i++) {
                Resource resource = schedulerStorage1.Resources[i];
                string subjPrefix = resource.Caption + "'s ";
                eventList.Add(CreateEvent(subjPrefix + "meeting", "meeting", resource.Id, 2, 5, 0, "office"));
                eventList.Add(CreateEvent(subjPrefix + "travel", "travel", resource.Id, 3, 6, 0, "out of the city"));
                eventList.Add(CreateEvent(subjPrefix + "phone call", "phone call", resource.Id, 0, 10, 0, "office"));
                eventList.Add(CreateEvent(subjPrefix + "business trip", "business trip", resource.Id, 3, 6, 3, "San-Francisco"));
                eventList.Add(CreateEvent(subjPrefix + "double personal day", "double personal day", resource.Id, 0, 10, 2, "out of the city"));
                eventList.Add(CreateEvent(subjPrefix + "personal day", "personal day", resource.Id, 0, 10, 1, "out of the city"));
            }



        }
        private CustomAppointment CreateEvent(string description, string subject, object resourceId, int status, int label, int days, string location) {
            CustomAppointment apt = new CustomAppointment();
            apt.Subject = subject;
            apt.Description = description;
            apt.OwnerId = resourceId;
            Random rnd = RandomInstance;
            int rangeInMinutes = 60 * 24;
            if(days == 2) {
                apt.StartTime = DateTime.Today;
                apt.EndTime = DateTime.Today.AddDays(2);
            }
            else if(days == 1) {
                apt.StartTime = DateTime.Today;
                apt.EndTime = DateTime.Today.AddDays(1);
            }
            else {
                apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
                apt.EndTime = apt.StartTime.AddDays(days) + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            }
            apt.Location = location;
            apt.Status = status;
            apt.Label = label;
            return apt;
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void appointmentStatusEdit1_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
