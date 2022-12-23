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
    public partial class frm_ChuyenDuLich : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDKDULICHEntities data = new QLDKDULICHEntities();
        public frm_ChuyenDuLich()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            getMaTuyen();
            load_Data();
        }

        private void load_Data()
        {
            tChuyenDuLichBindingSource.DataSource = data.tChuyenDuLich.ToList();
            btnSave.Enabled = false;
            txtMaChuyen.ReadOnly = true;
            cobbMaTuyen.Enabled = false;
            
        }

        private void getMaTuyen()
        {
            cobbMaTuyen.DisplayMember = "TenTuyen";
            cobbMaTuyen.ValueMember = "MaTuyen";
            cobbMaTuyen.DataSource = data.tTuyen.ToList();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            tChuyenDuLichBindingSource.AddNew();
            txtMaChuyen.Focus();
            txtMaChuyen.ReadOnly = false;
            cobbMaTuyen.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new tChuyenDuLich()
            {
                MaChuyen = txtMaChuyen.Text.Trim(),
                MaTuyen = cobbMaTuyen.SelectedValue.ToString(),
                PhuongTien = cobbPhuongTien.SelectedItem.ToString(),
                TenHDVien = txtTenHDVien.Text.Trim(),
                DonGia = Double.Parse(txtDonGia.Text.Trim()),
            };
            DialogResult alert = MessageBox.Show("Bạn muốn lưu dữ liệu?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (alert == DialogResult.OK)
            {
                data.tChuyenDuLich.Add(t);
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn sửa dữ liệu?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (alert == DialogResult.Yes)
            {
                var c = data.tChuyenDuLich
                      .Where(x => x.MaChuyen == txtMaChuyen.Text.Trim())
                      .FirstOrDefault();
                c.MaChuyen = txtMaChuyen.Text.Trim();
                c.MaTuyen = cobbMaTuyen.SelectedValue.ToString();
                c.PhuongTien = cobbPhuongTien.SelectedItem.ToString();
                c.TenHDVien = txtTenHDVien.Text.Trim();
                c.DonGia = float.Parse(txtDonGia.Text.Trim());
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}