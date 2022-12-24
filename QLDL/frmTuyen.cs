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
    public partial class frmTuyen : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDKDULICHEntities data = new QLDKDULICHEntities();
        public frmTuyen()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            cobbSoNgay.SelectedItem = null;
            cobbSoNgay.SelectedText = "--Chọn số ngày--";
            load_Data();
        }

        private void load_Data()
        {
            tTuyenBindingSource.DataSource = data.tTuyen.ToList();
            btnSave.Enabled = false;
            txtMaTuyen.ReadOnly = true;
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            tTuyenBindingSource.AddNew();
            txtMaTuyen.Focus();
            txtMaTuyen.ReadOnly = false;
            btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new tTuyen()
            {
                MaTuyen = txtMaTuyen.Text.Trim(),
                TenTuyen = txtTenTuyen.Text.Trim(),
                SoNgay = int.Parse(cobbSoNgay.SelectedItem.ToString()),
                GhiChu = txtGhiChu.Text.Trim(),
            };
            DialogResult alert = MessageBox.Show("Bạn muốn lưu dữ liệu?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (alert == DialogResult.OK)
            {
                data.tTuyen.Add(t);
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn xóa?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (alert.Equals(DialogResult.Yes))
            {
                var ch = data.tChuyenDuLich.FirstOrDefault(x => x.MaTuyen.Contains(txtMaTuyen.Text.Trim()));
                if (ch != null)
                {
                    MessageBox.Show("Bạn không thể xóa tuyến này vì đã có trong dữ liệu đăng ký chuyến! Vui lòng thử lại");
                }
                else
                {
                    var t = data.tTuyen
                            .Where(x => x.MaTuyen == txtMaTuyen.Text.Trim())
                            .FirstOrDefault();
                    data.tTuyen.Remove(t);
                    data.SaveChanges();
                    load_Data();
                }
            }
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn sửa dữ liệu?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (alert == DialogResult.Yes)
            {
                var t = data.tTuyen
                        .Where(x => x.MaTuyen == txtMaTuyen.Text.Trim())
                        .FirstOrDefault();
                t.TenTuyen = txtTenTuyen.Text.Trim();
                t.SoNgay = int.Parse(cobbSoNgay.SelectedItem.ToString());
                t.GhiChu = txtGhiChu.Text.Trim();
                data.SaveChanges();
                load_Data();
            }
        }
    }
}