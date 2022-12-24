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
    public partial class frmDangKy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDKDULICHEntities data = new QLDKDULICHEntities();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            dateTimeDangKy.Format = DateTimePickerFormat.Custom;
            getMaChuyen();
            getMaKH();
            load_Data();
        }

        private void load_Data()
        {
            tDangKyBindingSource.DataSource = data.tDangKy.ToList();
            btnSave.Enabled = false;
        }

        private void getMaChuyen()
        {
            cobbMaChuyen.DisplayMember = "MaChuyen";
            cobbMaChuyen.ValueMember = "MaChuyen";
            cobbMaChuyen.DataSource = data.tChuyenDuLich.ToList();
        }
        private void getMaKH()
        {
            cobbMaKH.DisplayMember = "TenKhach";
            cobbMaKH.ValueMember = "MaKhach";
            cobbMaKH.DataSource = data.tKhach.ToList();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            tDangKyBindingSource.AddNew();
            cobbMaChuyen.Focus();
            btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var d = new tDangKy()
            {
                MaChuyen = cobbMaChuyen.SelectedValue.ToString(),
                MaKhach = cobbMaKH.SelectedValue.ToString(),
                NgayDKy = dateTimeDangKy.Value.Date,
                STDTra = Double.Parse(txtSTDTra.Text.Trim()),
            };
            DialogResult alert = MessageBox.Show("Bạn muốn lưu dữ liệu?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (alert == DialogResult.OK)
            {
                data.tDangKy.Add(d);
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn sửa dữ liệu?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (alert == DialogResult.Yes)
            {
                var d = data.tDangKy
                           .Where(x => x.MaChuyen == cobbMaChuyen.SelectedValue & x.MaKhach == cobbMaKH.SelectedValue)
                           .FirstOrDefault();
                //del.MaChuyen = cobbMaChuyen.SelectedValue.ToString();
                //del.MaKhach = cobbMaKH.SelectedValue.ToString();
                d.NgayDKy = dateTimeDangKy.Value.Date;
                d.STDTra = float.Parse(txtSTDTra.Text.Trim());
                data.SaveChanges();
                load_Data();
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult alert = MessageBox.Show("Bạn muốn xóa dữ liệu này?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (alert.Equals(DialogResult.Yes))
            {
                var d = data.tDangKy
                            .Where(x => x.MaChuyen == cobbMaChuyen.SelectedValue & x.MaKhach == cobbMaKH.SelectedValue)
                            .FirstOrDefault();
                data.tDangKy.Remove(d);
                data.SaveChanges();
                load_Data();
            }
        }
    }
}