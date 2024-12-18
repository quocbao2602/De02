namespace De02
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using De02.model;

    public partial class FrmSanpham : Form
    {
        private Model1 context = new Model1();
        private bool isAddingNew = false;

        public FrmSanpham()
        {
            InitializeComponent();
        }

        private void FrmSanpham_Load(object sender, EventArgs e)
        {
            // Lấy tất cả sản phẩm từ cơ sở dữ liệu và hiển thị trong ListView
            var sanPhams = context.SanPhams.ToList();
            LvSanpham.Items.Clear();
            foreach (var sp in sanPhams)
            {
                ListViewItem item = new ListViewItem(sp.MaSP);
                item.SubItems.Add(sp.TenSP);
                item.SubItems.Add(sp.NgayNhap?.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sp.MaLoai);
                LvSanpham.Items.Add(item);
            }

            // Nạp danh sách loại sản phẩm vào ComboBox
            var loaiSPs = context.SanPhams.Select(sp => sp.MaLoai).Distinct().ToList();
            CboLoaiSP.DataSource = loaiSPs;
            CboLoaiSP.DisplayMember = "MaLoai";
        }

        private void LvSanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có item được chọn trong ListView
            if (LvSanpham.SelectedItems.Count > 0)
            {
                var item = LvSanpham.SelectedItems[0];

                // Điền thông tin vào các TextBox, ComboBox và DateTimePicker
                TxtMaSP.Text = item.Text; // Mã SP
                TxtTenSP.Text = item.SubItems[1].Text; // Tên SP
                DtNgaynhap.Value = DateTime.Parse(item.SubItems[2].Text); // Ngày nhập
                CboLoaiSP.SelectedItem = item.SubItems[3].Text; // Loại SP

                BtnLuu.Visible = true;
                BtnThem.Visible = false;

               
                isAddingNew = false;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            TxtMaSP.Clear();
            TxtTenSP.Clear();
            DtNgaynhap.Value = DateTime.Now;
            CboLoaiSP.SelectedIndex = 0;

            BtnLuu.Visible = true;
            BtnThem.Visible = true;
            isAddingNew = true;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                var sanPham = new SanPham
                {
                    MaSP = TxtMaSP.Text,
                    TenSP = TxtTenSP.Text,
                    NgayNhap = DtNgaynhap.Value,
                    MaLoai = CboLoaiSP.SelectedValue.ToString()
                };

                context.SanPhams.Add(sanPham);
                context.SaveChanges();
                MessageBox.Show("Sản phẩm đã được thêm thành công!");

                // Nạp lại dữ liệu trong ListView
                FrmSanpham_Load(sender, e);
                isAddingNew = false;
                BtnThem.Visible = true;
                BtnLuu.Visible = false;
            }
        }


        private void BtnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã sản phẩm đã có trong cơ sở dữ liệu chưa
            var maSP = TxtMaSP.Text;
            var sanPham = context.SanPhams.SingleOrDefault(sp => sp.MaSP == maSP);

            if (sanPham != null)
            {
                // Cập nhật thông tin sản phẩm
                sanPham.TenSP = TxtTenSP.Text;
                sanPham.NgayNhap = DtNgaynhap.Value;
                sanPham.MaLoai = CboLoaiSP.SelectedValue.ToString();

                context.SaveChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                MessageBox.Show("Cập nhật sản phẩm thành công!");

                // Nạp lại dữ liệu trong ListView
                FrmSanpham_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại.");
            }
        }


        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var maSP = TxtMaSP.Text;
            var sanPham = context.SanPhams.SingleOrDefault(sp => sp.MaSP == maSP);

            if (sanPham != null)
            {
                context.SanPhams.Remove(sanPham);  // Xóa sản phẩm khỏi DbContext
                context.SaveChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                MessageBox.Show("Sản phẩm đã được xóa thành công!");

                // Nạp lại dữ liệu trong ListView
                FrmSanpham_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại.");
            }
        }


        private void BtnTim_Click(object sender, EventArgs e)
        {
            var tenSP = TxtTim.Text;
            var sanPhams = context.SanPhams.Where(sp => sp.TenSP.Contains(tenSP)).ToList();

            LvSanpham.Items.Clear();
            foreach (var sp in sanPhams)
            {
                ListViewItem item = new ListViewItem(sp.MaSP);
                item.SubItems.Add(sp.TenSP);
                item.SubItems.Add(sp.NgayNhap?.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sp.MaLoai);
                LvSanpham.Items.Add(item);
            }
        }
    }
}
