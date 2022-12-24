using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QLDL
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDKDULICHEntities data = new QLDKDULICHEntities();
        public frmMain()
        {
            InitializeComponent();
        }

        private void navBarRoute_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navigationFrameData.SelectedPage = naviPageTuyen;
        }

        private void navBarTour_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navigationFrameData.SelectedPage = naviPageChuyen;
        }
        private void navBarPlace_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navigationFrameData.SelectedPage = naviPageDiaDiem;
        }
        private void navBarKH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navigationFrameData.SelectedPage = naviPageKH;
        }

        private void navBarRegister_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            navigationFrameData.SelectedPage = naviPageDangKy;

        }
        private void gridControlTuyen_Load_1(object sender, EventArgs e)
        {
            tTuyenBindingSource.DataSource = data.tTuyen.ToList();
        }

        private void gridControlChuyen_Load(object sender, EventArgs e)
        {
            tChuyenDuLichBindingSource.DataSource = data.tChuyenDuLich.ToList();
        }

        private void gridControlDiaDiem_Load(object sender, EventArgs e)
        {
            tDiaDiemThamQuanBindingSource.DataSource = data.tDiaDiemThamQuan.ToList();
        }


        private void gridControlKH_Load(object sender, EventArgs e)
        {
            tKhachBindingSource.DataSource = data.tKhach.ToList();
        }

        private void gridControlDangKy_Load(object sender, EventArgs e)
        {
            tDangKyBindingSource.DataSource = data.tDangKy.ToList();
        }

        private void barRoute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmTuyen = new frmTuyen();
            frmTuyen.Show();
        }

        private void barTourist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmChuyen = new frmChuyenDuLich();
            frmChuyen.Show();
        }

        private void barPlace_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDD = new frmDiaDiemThamQuan();
            frmDD.Show();
        }

        private void barCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmKH = new frmKhachHang();
            frmKH.Show();
        }

        private void barRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDangKy = new frmDangKy();
            frmDangKy.Show();
        }

        private void barAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void barExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        public event EventHandler Logout;
        private void barLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void barReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmRP = new frmReport();
            frmRP.Show();
        }

        private void barDashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDashboardview = new frmDashboardview();
            frmDashboardview.Show();
        }

        private void barDBControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDashboard = new frmDashboard();
            frmDashboard.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(40);
            }
        }
    }
}
