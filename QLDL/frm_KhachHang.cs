using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
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
    public partial class frm_KhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDKDULICHEntities data = new QLDKDULICHEntities();
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            load_Data();
        }

        private void load_Data()
        {
            tKhachBindingSource.DataSource = data.tKhach.ToList();
            btnSave.Enabled = false;
            txtMaKH.ReadOnly = true;
        }
        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var k = new tKhach()
            {
                MaKhach = txtMaKH.Text.Trim(),
                TenKhach = txtTenKH.Text.Trim(),
                DienThoai = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
            };
            DialogResult alert = MessageBox.Show("Bạn muốn lưu dữ liệu?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (alert == DialogResult.OK)
            {
                data.tKhach.Add(k);
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn xóa dữ liệu này?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (alert.Equals(DialogResult.Yes))
            {
                var kh = data.tDangKy.FirstOrDefault(x => x.MaKhach.Contains(txtMaKH.Text.Trim()));
                if (kh != null)
                {
                    MessageBox.Show("Bạn không thể xóa khách hàng này vì đã có trong dữ liệu đăng ký! Vui lòng thử lại");
                }
                else
                {
                    var k = data.tKhach
                            .Where(x => x.MaKhach == txtMaKH.Text.Trim())
                            .FirstOrDefault();
                    data.tKhach.Remove(k);
                    data.SaveChanges();
                    load_Data();
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            tKhachBindingSource.AddNew();
            txtMaKH.Focus();
            txtMaKH.ReadOnly = false;
            btnSave.Enabled = true;
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn sửa dữ liệu?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (alert == DialogResult.Yes)
            {
                var k = data.tKhach
                      .Where(x => x.MaKhach == txtMaKH.Text.Trim())
                      .FirstOrDefault();
                k.TenKhach = txtTenKH.Text.Trim();
                k.DienThoai = txtSDT.Text.Trim();
                k.DiaChi = txtDiaChi.Text.Trim();
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Reports.XtraReportKH report = new Reports.XtraReportKH();
            //ReportDesignTool designTool = new ReportDesignTool(report);
            //designTool.ShowDesignerDialog();
            Form frmRP = new Reports.frm_ReportKH();
            frmRP.Show();
        }
    }
}