using DevExpress.XtraBars;
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
    public partial class frm_DiaDiemThamQuan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDKDULICHEntities data = new QLDKDULICHEntities();
        public frm_DiaDiemThamQuan()
        {
            InitializeComponent();
        }

        private void gridControlDD_Load(object sender, EventArgs e)
        {
            cobbTenTT.SelectedItem = null;
            cobbTenTT.SelectedText = "--Chọn tỉnh thành--";
            load_Data();
        }

        private void load_Data()
        {
            tDiaDiemThamQuanBindingSource.DataSource = data.tDiaDiemThamQuan.ToList();
            btnSave.Enabled = false;
            txtMaDD.ReadOnly = true;
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            tDiaDiemThamQuanBindingSource.AddNew();
            txtMaDD.Focus();
            txtMaDD.ReadOnly = false;
            btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var d = new tDiaDiemThamQuan()
            {
                MaDD = txtMaDD.Text.Trim(),
                TenDD = txtTenDD.Text.Trim(),
                TenTinhThanh = cobbTenTT.SelectedItem.ToString(),
            };

            DialogResult alert = MessageBox.Show("Bạn muốn lưu dữ liệu?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (alert == DialogResult.OK)
            {
                data.tDiaDiemThamQuan.Add(d);
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn xóa dữ liệu này?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (alert.Equals(DialogResult.Yes))
            {
                var d = data.tDiaDiemThamQuan
                        .Where(x => x.MaDD == txtMaDD.Text.Trim())
                        .FirstOrDefault();
                data.tDiaDiemThamQuan.Remove(d);
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult sv = MessageBox.Show("Bạn muốn sửa dữ liệu?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sv == DialogResult.Yes)
            {
                var d = data.tDiaDiemThamQuan
                        .Where(x => x.MaDD == txtMaDD.Text.Trim())
                        .FirstOrDefault();
                d.TenDD = txtTenDD.Text.Trim();
                d.TenTinhThanh = cobbTenTT.SelectedItem.ToString();
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frmRP = new Reports.frm_ReportDD();
            frmRP.Show();
        }
    }
}