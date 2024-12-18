namespace De02
{
    partial class FrmSanpham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView LvSanpham;
        private System.Windows.Forms.ColumnHeader MaSP;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader NgayNhap;
        private System.Windows.Forms.ColumnHeader MaLoai;
        private System.Windows.Forms.TextBox TxtMaSP;
        private System.Windows.Forms.TextBox TxtTenSP;
        private System.Windows.Forms.DateTimePicker DtNgaynhap;
        private System.Windows.Forms.ComboBox CboLoaiSP;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.TextBox TxtTim;
        private System.Windows.Forms.Button BtnTim;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.LvSanpham = new System.Windows.Forms.ListView();
            this.MaSP = new System.Windows.Forms.ColumnHeader();
            this.TenSP = new System.Windows.Forms.ColumnHeader();
            this.NgayNhap = new System.Windows.Forms.ColumnHeader();
            this.MaLoai = new System.Windows.Forms.ColumnHeader();
            this.TxtMaSP = new System.Windows.Forms.TextBox();
            this.TxtTenSP = new System.Windows.Forms.TextBox();
            this.DtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.CboLoaiSP = new System.Windows.Forms.ComboBox();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.TxtTim = new System.Windows.Forms.TextBox();
            this.BtnTim = new System.Windows.Forms.Button();

            // 
            // LvSanpham
            // 
            this.LvSanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSP,
            this.TenSP,
            this.NgayNhap,
            this.MaLoai});
            this.LvSanpham.FullRowSelect = true;
            this.LvSanpham.GridLines = true;
            this.LvSanpham.HideSelection = false;
            this.LvSanpham.Location = new System.Drawing.Point(12, 12);
            this.LvSanpham.Name = "LvSanpham";
            this.LvSanpham.Size = new System.Drawing.Size(460, 200);
            this.LvSanpham.TabIndex = 0;
            this.LvSanpham.UseCompatibleStateImageBehavior = false;
            this.LvSanpham.View = System.Windows.Forms.View.Details;

            // 
            // MaSP, TenSP, NgayNhap, MaLoai
            // 
            this.MaSP.Text = "Mã SP";
            this.TenSP.Text = "Tên SP";
            this.NgayNhap.Text = "Ngày Nhập";
            this.MaLoai.Text = "Loại SP";

            // 
            // TxtMaSP, TxtTenSP, DtNgaynhap, CboLoaiSP
            // 
            this.TxtMaSP.Location = new System.Drawing.Point(12, 220);
            this.TxtMaSP.Name = "TxtMaSP";
            this.TxtMaSP.Size = new System.Drawing.Size(100, 20);
            this.TxtMaSP.TabIndex = 1;

            this.TxtTenSP.Location = new System.Drawing.Point(12, 250);
            this.TxtTenSP.Name = "TxtTenSP";
            this.TxtTenSP.Size = new System.Drawing.Size(200, 20);
            this.TxtTenSP.TabIndex = 2;

            this.DtNgaynhap.Location = new System.Drawing.Point(12, 280);
            this.DtNgaynhap.Name = "DtNgaynhap";
            this.DtNgaynhap.Size = new System.Drawing.Size(200, 20);
            this.DtNgaynhap.TabIndex = 3;

            this.CboLoaiSP.Location = new System.Drawing.Point(12, 310);
            this.CboLoaiSP.Name = "CboLoaiSP";
            this.CboLoaiSP.Size = new System.Drawing.Size(200, 21);
            this.CboLoaiSP.TabIndex = 4;

            // 
            // Buttons (BtnThem, BtnSua, BtnXoa, BtnLuu)
            // 
            this.BtnThem.Location = new System.Drawing.Point(240, 220);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 5;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);

            this.BtnSua.Location = new System.Drawing.Point(240, 250);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 6;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);

            this.BtnXoa.Location = new System.Drawing.Point(240, 280);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 7;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

            this.BtnLuu.Location = new System.Drawing.Point(240, 310);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(75, 23);
            this.BtnLuu.TabIndex = 8;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);

            // 
            // TxtTim, BtnTim
            // 
            this.TxtTim.Location = new System.Drawing.Point(350, 220);
            this.TxtTim.Name = "TxtTim";
            this.TxtTim.Size = new System.Drawing.Size(100, 20);
            this.TxtTim.TabIndex = 9;

            this.BtnTim.Location = new System.Drawing.Point(350, 250);
            this.BtnTim.Name = "BtnTim";
            this.BtnTim.Size = new System.Drawing.Size(75, 23);
            this.BtnTim.TabIndex = 10;
            this.BtnTim.Text = "Tìm";
            this.BtnTim.UseVisualStyleBackColor = true;
            this.BtnTim.Click += new System.EventHandler(this.BtnTim_Click);

            // 
            // FrmSanpham (Form settings)
            // 
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.LvSanpham);
            this.Controls.Add(this.TxtMaSP);
            this.Controls.Add(this.TxtTenSP);
            this.Controls.Add(this.DtNgaynhap);
            this.Controls.Add(this.CboLoaiSP);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnLuu);
            this.Controls.Add(this.TxtTim);
            this.Controls.Add(this.BtnTim);
            this.Name = "FrmSanpham";
            this.Text = "DANH MỤC SẢN PHẨM";
            this.Load += new System.EventHandler(this.FrmSanpham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
