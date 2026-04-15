using BUS;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Admin : MaterialForm
    {
        public Admin()
        {
            InitializeComponent();
        }
        DataView dvSanPham = null;

        string path = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "Images");
        private void Admin_Load(object sender, EventArgs e)
        {
            SanPhamBUS sanPhamBUS = new SanPhamBUS();
            dvSanPham = sanPhamBUS.getDanhSachSanPham().DefaultView;
            dgv_ds_san_pham.DataSource = dvSanPham;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "HinhAnh";
            imgCol.HeaderText = "Hình";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgv_ds_san_pham.Columns.Insert(0, imgCol);

            dgv_ds_san_pham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgv_ds_san_pham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgv_ds_san_pham.Columns["Gia"].HeaderText = "Giá";
            dgv_ds_san_pham.Columns["TrangThai"].HeaderText = "Trạng Thái";
            load_hinh_anh();

            LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();
            cbx_loai_sanPham_tim_tk.DataSource = loaiSanPhamBUS.load_loai_san_pham();
            cbx_loai_sanPham_tim_tk.DisplayMember = "TenLoai";
            cbx_loai_sanPham_tim_tk.ValueMember = "MaLoai";

            dgv_ds_san_pham.Columns["MaLoai"].Visible = false;
            var cbxColumn = new DataGridViewComboBoxColumn
            {
                DataSource = loaiSanPhamBUS.load_loai_san_pham(),
                DisplayMember = "TenLoai",
                ValueMember = "MaLoai",
                HeaderText = "Loại Sản Phẩm",
                DataPropertyName = "MaLoai"
            };

            dgv_ds_san_pham.Columns.Insert(2, cbxColumn);

            cbx_loai.DataSource = loaiSanPhamBUS.load_loai_san_pham();
            cbx_loai.DisplayMember = "TenLoai";
            cbx_loai.ValueMember = "MaLoai";

        }
        Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

        public void load_hinh_anh()
        {


            foreach (DataGridViewRow row in dgv_ds_san_pham.Rows)
            {

                string tenSP = row.Cells["TenSP"].Value.ToString();
                string imagePath = Path.Combine(path, tenSP + ".jpg");

                if (!File.Exists(imagePath)) continue;

                if (imageCache.ContainsKey(imagePath))
                {
                    row.Cells["HinhAnh"].Value = imageCache[imagePath];
                    continue;
                }
                Image temp = Image.FromFile(imagePath);
                imageCache[imagePath] = temp;
                row.Cells["HinhAnh"].Value = temp;

            }

        }


        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            dvSanPham.RowFilter = $"TenSP LIKE '%{txt_loc_san_pham_ten.Text}%'";
            if (ck_tk_loai.Checked)
            {
                dvSanPham.RowFilter += $" AND MaLoai={cbx_loai_sanPham_tim_tk.SelectedValue}";
            }
            load_hinh_anh();
        }

        private void dgv_ds_san_pham_Sorted(object sender, EventArgs e)
        {
            load_hinh_anh();
        }

        private void txt_gia_tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txt_gia_tien.Text.Contains('.') && txt_gia_tien.Text.Length > 0) return;
            e.Handled = true;
        }

        private void dgv_ds_san_pham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_ds_san_pham.SelectedRows)
            {
                ptb_san_pham.Image = (Image)row.Cells["HinhAnh"].Value ?? null;
                txt_ten_san_pham.Text = row.Cells["TenSP"].Value.ToString();
                txt_so_luong.Text = row.Cells["SoLuong"].Value.ToString();
                cbx_loai.SelectedValue = row.Cells["MaLoai"].Value;
                txt_gia_tien.Text = row.Cells["Gia"].Value.ToString();
                swt_trang_thai.Checked = (bool)row.Cells["TrangThai"].Value;
            }
        }

        private void txt_so_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        OpenFileDialog openFileDialog = null;
        string ten_hinh = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Image Files (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptb_san_pham.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        //them san pham moi

        public void kiemTraThongTin()
        {
            if (string.IsNullOrEmpty(txt_ten_san_pham.Text)
               || string.IsNullOrEmpty(txt_so_luong.Text)
               || string.IsNullOrEmpty(txt_gia_tien.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ptb_san_pham.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            kiemTraThongTin();
            SanPhamBUS sanPhamBUS = new SanPhamBUS();
            if (sanPhamBUS.kiemTraTenSanPham(txt_ten_san_pham.Text))
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.TenSp = txt_ten_san_pham.Text;
                sp.Gia = float.Parse(txt_gia_tien.Text);
                sp.SoLuong = int.Parse(txt_so_luong.Text);
                sp.MaLoai = (int)cbx_loai.SelectedValue;
                sp.TrangThai = swt_trang_thai.Checked ? 1 : 0;

                if (ptb_san_pham.Image != null)
                {
                    ptb_san_pham.Image.Dispose();
                    ptb_san_pham.Image = null;
                }
                //doi ten file anh thanh ten san pham
                File.Move(openFileDialog.FileName, Path.Combine(Path.GetDirectoryName(openFileDialog.FileName), txt_ten_san_pham.Text + ".jpg"));
                //lay duong dan moi cua file anh
                string ten_hinh_path = Path.Combine(Path.GetDirectoryName(openFileDialog.FileName), txt_ten_san_pham.Text + ".jpg");

                if (!File.Exists(Path.Combine(path, txt_ten_san_pham.Text + ".jpg")))
                {
                    File.Copy(ten_hinh_path, Path.Combine(path, txt_ten_san_pham.Text + ".jpg"));
                }

                int res = sanPhamBUS.themSanPham(sp);
                if (res > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dvSanPham = sanPhamBUS.getDanhSachSanPham().DefaultView;
                    dgv_ds_san_pham.DataSource = dvSanPham;
                    load_hinh_anh();
                    reset_form();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //rest thong tin tren form
        public void reset_form()
        {
            txt_ten_san_pham.Text = "";
            txt_so_luong.Text = "";
            txt_gia_tien.Text = "";
            cbx_loai.SelectedIndex = 0;
            swt_trang_thai.Checked = true;
        }
    }
}

