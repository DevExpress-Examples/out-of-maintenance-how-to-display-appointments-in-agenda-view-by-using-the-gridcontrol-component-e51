using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AgendViewComponent {
    public partial class GoToDateDialog : XtraForm {
        public GoToDateDialog() {
            InitializeComponent();
        }

        private void GoToDateDialog_Load(object sender, EventArgs e) {

        }

        public DateTime SelectedDate {
            get { return dateEditGoToDate.DateTime; }
            set { dateEditGoToDate.EditValue = value; }
        }
    }
}
