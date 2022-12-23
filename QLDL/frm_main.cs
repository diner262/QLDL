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
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDKDULICHEntities data = new QLDKDULICHEntities();
        public frm_main()
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
            Form frmTuyen = new frm_Tuyen();
            frmTuyen.Show();
        }

        private void barTourist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmChuyen = new frm_ChuyenDuLich();
            frmChuyen.Show();
        }

        private void barPlace_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDD = new frm_DiaDiemThamQuan();
            frmDD.Show();
        }

        private void barCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmKH = new frm_KhachHang();
            frmKH.Show();
        }

        private void barRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDangKy = new frm_DangKy();
            frmDangKy.Show();
        }

        private void barAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmAbout = new frm_About();
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
            Form frmRP = new frm_Report();
            frmRP.Show();
        }
    }
}
