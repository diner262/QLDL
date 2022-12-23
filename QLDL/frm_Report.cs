using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDL
{
    public partial class frm_Report : XtraForm
    {
        public frm_Report()
        {
            InitializeComponent();
        }

        private void frm_Report_Load(object sender, EventArgs e)
        {
            reportDesigner1.OpenReport(new Reports.XtraReportKH());
            reportDesigner1.OpenReport(new Reports.XtraReportDD());
        }
    }
}
