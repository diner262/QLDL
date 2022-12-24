using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDL
{
    public partial class frmDashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new ucDashboard() { Dock = DockStyle.Fill });
        }
    }
}
