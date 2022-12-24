﻿
namespace QLDL
{
    partial class frmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateTimeDangKy = new System.Windows.Forms.DateTimePicker();
            this.tDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTDTra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cobbMaChuyen = new System.Windows.Forms.ComboBox();
            this.cobbMaKH = new System.Windows.Forms.ComboBox();
            this.txtSTDTra = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colSTDTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltChuyenDuLich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTDTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnAdd,
            this.btnSave,
            this.btnEdit,
            this.btnDelete});
            this.ribbon.LargeImages = this.imageCollection1;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1022, 157);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.LargeImageIndex = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.ImageOptions.LargeImageIndex = 3;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 3;
            this.btnEdit.ImageOptions.LargeImageIndex = 2;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.ImageOptions.LargeImageIndex = 1;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "add-file.png");
            this.imageCollection1.Images.SetKeyName(1, "delete_icon.png");
            this.imageCollection1.Images.SetKeyName(2, "file-edit.png");
            this.imageCollection1.Images.SetKeyName(3, "Save_icon.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HOME";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEdit, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thêm / Xóa / Sửa";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 525);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1022, 22);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateTimeDangKy);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.cobbMaChuyen);
            this.layoutControl1.Controls.Add(this.cobbMaKH);
            this.layoutControl1.Controls.Add(this.txtSTDTra);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 157);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1022, 368);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateTimeDangKy
            // 
            this.dateTimeDangKy.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tDangKyBindingSource, "NgayDKy", true));
            this.dateTimeDangKy.Location = new System.Drawing.Point(118, 95);
            this.dateTimeDangKy.Name = "dateTimeDangKy";
            this.dateTimeDangKy.Size = new System.Drawing.Size(148, 21);
            this.dateTimeDangKy.TabIndex = 9;
            // 
            // tDangKyBindingSource
            // 
            this.tDangKyBindingSource.DataSource = typeof(QLDL.tDangKy);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tDangKyBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(459, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(551, 328);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhach,
            this.colNgayDKy,
            this.colMaChuyen,
            this.colSTDTra1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaKhach
            // 
            this.colMaKhach.FieldName = "MaKhach";
            this.colMaKhach.Name = "colMaKhach";
            this.colMaKhach.Visible = true;
            this.colMaKhach.VisibleIndex = 1;
            // 
            // colNgayDKy
            // 
            this.colNgayDKy.FieldName = "NgayDKy";
            this.colNgayDKy.Name = "colNgayDKy";
            this.colNgayDKy.Visible = true;
            this.colNgayDKy.VisibleIndex = 2;
            // 
            // colMaChuyen
            // 
            this.colMaChuyen.FieldName = "MaChuyen";
            this.colMaChuyen.Name = "colMaChuyen";
            this.colMaChuyen.Visible = true;
            this.colMaChuyen.VisibleIndex = 0;
            // 
            // colSTDTra1
            // 
            this.colSTDTra1.FieldName = "STDTra";
            this.colSTDTra1.Name = "colSTDTra1";
            this.colSTDTra1.Visible = true;
            this.colSTDTra1.VisibleIndex = 3;
            // 
            // cobbMaChuyen
            // 
            this.cobbMaChuyen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tDangKyBindingSource, "MaChuyen", true));
            this.cobbMaChuyen.FormattingEnabled = true;
            this.cobbMaChuyen.Location = new System.Drawing.Point(118, 45);
            this.cobbMaChuyen.Name = "cobbMaChuyen";
            this.cobbMaChuyen.Size = new System.Drawing.Size(325, 21);
            this.cobbMaChuyen.TabIndex = 7;
            // 
            // cobbMaKH
            // 
            this.cobbMaKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tDangKyBindingSource, "MaKhach", true));
            this.cobbMaKH.FormattingEnabled = true;
            this.cobbMaKH.Location = new System.Drawing.Point(118, 70);
            this.cobbMaKH.Name = "cobbMaKH";
            this.cobbMaKH.Size = new System.Drawing.Size(325, 21);
            this.cobbMaKH.TabIndex = 5;
            // 
            // txtSTDTra
            // 
            this.txtSTDTra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tDangKyBindingSource, "STDTra", true));
            this.txtSTDTra.Location = new System.Drawing.Point(364, 95);
            this.txtSTDTra.MenuManager = this.ribbon;
            this.txtSTDTra.Name = "txtSTDTra";
            this.txtSTDTra.Size = new System.Drawing.Size(79, 20);
            this.txtSTDTra.StyleController = this.layoutControl1;
            this.txtSTDTra.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1022, 368);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 119);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(447, 229);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(447, 119);
            this.layoutControlGroup1.Text = "Thêm thông tin đăng ký";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cobbMaKH;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 25);
            this.layoutControlItem2.Text = "Mã Khách Hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cobbMaChuyen;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(423, 25);
            this.layoutControlItem4.Text = "Mã Chuyến";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateTimeDangKy;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(246, 24);
            this.layoutControlItem3.Text = "Ngày Đăng Ký";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSTDTra;
            this.layoutControlItem1.Location = new System.Drawing.Point(246, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(177, 24);
            this.layoutControlItem1.Text = "Số Tiền Đã Trả";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(447, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(555, 348);
            this.layoutControlItem5.Text = "Danh sách đăng ký";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 13);
            // 
            // colSTDTra
            // 
            this.colSTDTra.FieldName = "STDTra";
            this.colSTDTra.Name = "colSTDTra";
            // 
            // coltChuyenDuLich
            // 
            this.coltChuyenDuLich.FieldName = "tChuyenDuLich";
            this.coltChuyenDuLich.Name = "coltChuyenDuLich";
            // 
            // coltKhach
            // 
            this.coltKhach.FieldName = "tKhach";
            this.coltKhach.Name = "coltKhach";
            // 
            // frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 547);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frm_DangKy";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý thông tin Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tDangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTDTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.ComboBox cobbMaChuyen;
        private System.Windows.Forms.ComboBox cobbMaKH;
        private DevExpress.XtraEditors.TextEdit txtSTDTra;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.DateTimePicker dateTimeDangKy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource tDangKyBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhach;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDKy;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colSTDTra1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTDTra;
        private DevExpress.XtraGrid.Columns.GridColumn coltChuyenDuLich;
        private DevExpress.XtraGrid.Columns.GridColumn coltKhach;
    }
}