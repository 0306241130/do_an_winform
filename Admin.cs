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
            btn_lam_moi.Text = "🔄 làm mới";
            btn_lam_moi_nv.Text = "🔄 làm mới";
            btn_them.Text += " ➕";
            btn_sua.Text += " 🔨";
            btn_xoa.Text += " 🗑";
            btn_cap_nhat_nv.Text += " 🔨";
            btn_them_nv.Text += " ➕";
            btn_xoa_nv.Text += " 🗑";    

            loadSanPham();
        }
        //------------------------------SAN PHAM-----------------------------
        public void loadSanPham()
        {
            SanPhamBUS sanPhamBUS = new SanPhamBUS();
            dvSanPham = new DataView(sanPhamBUS.getDanhSachSanPham());
            dgv_ds_san_pham.DataSource = dvSanPham;

            

            LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();
            cbx_loai_sanPham_tim_tk.DataSource = loaiSanPhamBUS.load_loai_san_pham();
            cbx_loai_sanPham_tim_tk.DisplayMember = "TenLoai";
            cbx_loai_sanPham_tim_tk.ValueMember = "MaLoai";

            dgv_ds_san_pham.Columns["MaLoai"].Visible = false;
            if(!dgv_ds_san_pham.Columns.Contains("cbxLoaiSP"))
            {
               
            
                var cbxColumn = new DataGridViewComboBoxColumn
                {
                    DataSource = loaiSanPhamBUS.load_loai_san_pham(),
                    DisplayMember = "TenLoai",
                    ValueMember = "MaLoai",
                    HeaderText = "Loại Sản Phẩm",
                    DataPropertyName = "MaLoai",
                    Name= "cbxLoaiSP"
                };

                dgv_ds_san_pham.Columns.Insert(4, cbxColumn);

                cbx_loai.DataSource = loaiSanPhamBUS.load_loai_san_pham();
                cbx_loai.DisplayMember = "TenLoai";
                cbx_loai.ValueMember = "MaLoai";
            }

            dgv_ds_san_pham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgv_ds_san_pham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgv_ds_san_pham.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgv_ds_san_pham.Columns["Gia"].HeaderText = "Giá";
            dgv_ds_san_pham.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgv_ds_san_pham.Columns["MaLoai"].HeaderText = "Loại Sản Phẩm";
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
                Image temp = new Bitmap(imagePath);
                imageCache[imagePath] = temp;
                row.Cells["HinhAnh"].Value = temp;

            }

        }


        private void dgv_ds_san_pham_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!dgv_ds_san_pham.Columns.Contains("HinhAnh"))
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "HinhAnh";
                imgCol.HeaderText = "Hình Ảnh";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgv_ds_san_pham.Columns.Insert(0, imgCol);
            }
            //stt(dgv_ds_san_pham);
            load_hinh_anh();
        }


        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            dvSanPham.RowFilter = $"TenSP LIKE '%{txt_loc_san_pham_ten.Text}%'";
            if (ck_tk_loai.Checked)
            {
                dvSanPham.RowFilter += $" AND MaLoai={cbx_loai_sanPham_tim_tk.SelectedValue}";
            }
        }

        private void txt_gia_tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txt_gia_tien.Text.Contains('.') && txt_gia_tien.Text.Length > 0) return;
            e.Handled = true;
        }

        bool flag = false;
        private void dgv_ds_san_pham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ptb_san_pham.Image = (Image)dgv_ds_san_pham.SelectedRows[0].Cells["HinhAnh"].Value ?? null;
            txt_ten_san_pham.Text = dgv_ds_san_pham.SelectedRows[0].Cells["TenSP"].Value.ToString();
            txt_so_luong.Text = dgv_ds_san_pham.SelectedRows[0].Cells["SoLuong"].Value.ToString();
            cbx_loai.SelectedValue = dgv_ds_san_pham.SelectedRows[0].Cells["MaLoai"].Value;
            txt_gia_tien.Text = dgv_ds_san_pham.SelectedRows[0].Cells["Gia"].Value.ToString();
            swt_trang_thai.Checked = (bool)dgv_ds_san_pham.SelectedRows[0].Cells["TrangThai"].Value;
            flag = true;
        }

        private void txt_so_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        OpenFileDialog openFileDialog = null;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Image Files (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (ptb_san_pham.Image != null)
                {
                    ptb_san_pham.Image.Dispose();
                }
                ptb_san_pham.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        //them san pham moi

        public bool kiemTraThongTin()
        {
           
            if (string.IsNullOrEmpty(txt_ten_san_pham.Text)
               || string.IsNullOrEmpty(txt_so_luong.Text)
               || string.IsNullOrEmpty(txt_gia_tien.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;

        }
    //them san pham
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            if (kiemTraThongTin()) return;
            if (flag)
            {
                MessageBox.Show("Vui lòng làm mới form sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }
            if (ptb_san_pham.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                sp.TenSp = txt_ten_san_pham.Text.Trim();
                sp.Gia = float.Parse(txt_gia_tien.Text);
                sp.SoLuong = int.Parse(txt_so_luong.Text);
                sp.MaLoai = (int)cbx_loai.SelectedValue;
                sp.TrangThai = swt_trang_thai.Checked ? 1 : 0;

                if (ptb_san_pham.Image != null)
                {
                    ptb_san_pham.Image.Dispose();
                    ptb_san_pham.Image = null;
                }

                if (!File.Exists(Path.Combine(path, Path.GetFileName(openFileDialog.FileName))))
                {
                    File.Copy(openFileDialog.FileName, Path.Combine(path, Path.GetFileName(openFileDialog.FileName)));
                    File.Move(Path.Combine(path, Path.GetFileName(openFileDialog.FileName)), Path.Combine(path, txt_ten_san_pham.Text + ".jpg"));
                }

                int res = sanPhamBUS.themSanPham(sp);
                if (res > 0)
                {                    
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset_form();
                    
                    dvSanPham = sanPhamBUS.getDanhSachSanPham().DefaultView;
                    dgv_ds_san_pham.DataSource = dvSanPham;
                    
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
            ptb_san_pham.Image = null;
            openFileDialog = null;
            dgv_ds_san_pham.ClearSelection();
            dgv_ds_san_pham.CurrentCell = null;
        }

        public void thay_doi_anh(SanPhamBUS sanPhamBUS, string txt_ten_cu)
        {
            if (ptb_san_pham.Image != null)
            {
                ptb_san_pham.Image.Dispose();
            }

                if (!sanPhamBUS.kiemTraTenSanPham(txt_ten_san_pham.Text) && openFileDialog == null)
            {
                if (File.Exists(Path.Combine(path, txt_ten_cu + ".jpg")))
                {

                    File.Move(Path.Combine(path, txt_ten_cu + ".jpg"), Path.Combine(path, txt_ten_san_pham.Text + ".jpg"));

                    imageCache.Remove(Path.Combine(path, txt_ten_cu + ".jpg"));
                    Image temp = new Bitmap(Path.Combine(path, txt_ten_san_pham.Text + ".jpg"));
                    imageCache[Path.Combine(path, txt_ten_san_pham.Text + ".jpg")] = temp;
                }
            }
            if (openFileDialog != null)
            {
                if (!sanPhamBUS.kiemTraTenSanPham(txt_ten_san_pham.Text))
                {
                    doiTenAnh(txt_ten_cu);
                }
                else
                {
                    doiTenAnh(txt_ten_cu);
                }
            }
        }

        public void doiTenAnh(string txt_ten_cu)
        {
            if (ptb_san_pham.Image != null)
            {
                ptb_san_pham.Image.Dispose();
                ptb_san_pham.Image = null;
            }
            if (File.Exists(Path.Combine(path, txt_ten_cu + ".jpg")))
            {
                dgv_ds_san_pham.SelectedRows[0].Cells["HinhAnh"].Value = null;
                File.Delete(Path.Combine(path, txt_ten_cu + ".jpg"));
            }

            if (!File.Exists(Path.Combine(path, Path.GetFileName(openFileDialog.FileName))))
            {
                File.Copy(openFileDialog.FileName, Path.Combine(path, Path.GetFileName(openFileDialog.FileName)));
                File.Move(Path.Combine(path, Path.GetFileName(openFileDialog.FileName)), Path.Combine(path, txt_ten_san_pham.Text + ".jpg"));
                imageCache.Remove(Path.Combine(path, txt_ten_cu + ".jpg"));
                Image temp = new Bitmap(Path.Combine(path, txt_ten_san_pham.Text + ".jpg"));
                imageCache[Path.Combine(path, txt_ten_san_pham.Text + ".jpg")] = temp;
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (kiemTraThongTin()) return;
                string tenSP = txt_ten_san_pham.Text;
                DialogResult result = MessageBox.Show($"Bạn có chắc cập nhật sản phẩm '{tenSP}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                SanPhamDTO sp = new SanPhamDTO();
                sp.TenSp = txt_ten_san_pham.Text.Trim();
                sp.Gia = float.Parse(txt_gia_tien.Text);
                sp.SoLuong = int.Parse(txt_so_luong.Text);
                sp.MaLoai = (int)cbx_loai.SelectedValue;
                sp.TrangThai = swt_trang_thai.Checked ? 1 : 0;
                sp.MaSP = (int)dgv_ds_san_pham.SelectedRows[0].Cells["MaSP"].Value;
                string txt_ten_cu = dgv_ds_san_pham.SelectedRows[0].Cells["TenSP"].Value.ToString();
                SanPhamBUS sanPhamBUS = new SanPhamBUS();
                thay_doi_anh(sanPhamBUS, txt_ten_cu);

                int res = sanPhamBUS.capNhatSanPham(sp);
                if (res > 0)
                {
                    MessageBox.Show($"Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset_form();
                   // dgv_ds_san_pham.DataSource = null;
                    dvSanPham = sanPhamBUS.getDanhSachSanPham().DefaultView;
                    dgv_ds_san_pham.DataSource = dvSanPham;
                    

                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                flag = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //xoa san pham
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SanPhamBUS sanPhamBUS = new SanPhamBUS();
            if (flag)
            {
                int maSP = (int)dgv_ds_san_pham.SelectedRows[0].Cells["MaSP"].Value;
                string tenSP = txt_ten_san_pham.Text;
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm '{tenSP}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int res = sanPhamBUS.xoaSanPham(maSP);
                    if (res > 0)
                    {
                        if(ptb_san_pham.Image != null)
                        {
                            ptb_san_pham.Image.Dispose();
                            //ptb_san_pham.Image = null;
                        }
                        reset_form();
                        File.Delete(Path.Combine(path, tenSP + ".jpg"));
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dvSanPham = sanPhamBUS.getDanhSachSanPham().DefaultView;
                        dgv_ds_san_pham.DataSource = dvSanPham;
                        imageCache.Remove(Path.Combine(path, tenSP + ".jpg"));
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    flag = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_lam_moi_Click(object sender, EventArgs e)
        {
            reset_form();
            flag = false;
        }
        public void stt(DataGridView dgv)
        {
            if(!dgv.Columns.Contains("STT"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.Name = "STT";
                sttColumn.HeaderText = "STT";
                dgv.Columns.Insert(0, sttColumn);
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells["STT"].Value = (row.Index + 1).ToString();
            }
        }

        //------------------------------NHAN VIEN-----------------------------
        string pathNhanVien = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "ImagesNhanVien");   
        Dictionary<string, Image> imageCacheNhanVien = new Dictionary<string, Image>();
        DataView dvNhanVien = new DataView();
        public void loadNhanVien()
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            dvNhanVien= nhanVienBUS.loadNhanVien().DefaultView;
            dgv_ds_nhan_vien.DataSource = dvNhanVien;
            dgv_ds_nhan_vien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgv_ds_nhan_vien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgv_ds_nhan_vien.Columns["TaiKhoan"].HeaderText = "Tên Tài Khoản";
            dgv_ds_nhan_vien.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgv_ds_nhan_vien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgv_ds_nhan_vien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgv_ds_nhan_vien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgv_ds_nhan_vien.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }


        private void load_hinh_anh_nhan_vien()
        {
            foreach (DataGridViewRow row in dgv_ds_nhan_vien.Rows)
            {
                string taiKhoan = row.Cells["TaiKhoan"].Value.ToString().Trim();
                string imagePath = Path.Combine(pathNhanVien, taiKhoan + ".jpg");
                if (!File.Exists(imagePath)) continue;
                if (imageCacheNhanVien.ContainsKey(imagePath))
                {
                    row.Cells["HinhAnh"].Value = imageCacheNhanVien[imagePath];
                    continue;
                }
                Image temp = new Bitmap(imagePath);
                imageCacheNhanVien[imagePath] = temp;
                row.Cells["HinhAnh"].Value =temp;
            }
        }

        private void btn_tim_kiem_nv_Click(object sender, EventArgs e)
        {
            dvNhanVien.RowFilter = $"HoTen LIKE '%{txt_tim_kiem_nv.Text}%'";
            if (tk_nv.Checked)
            {
                dvNhanVien.RowFilter += $" AND NgaySinh = '{dtp_nv.Value.ToShortDateString()}'";
            }
        }

        private void dgv_ds_nhan_vien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!dgv_ds_nhan_vien.Columns.Contains("HinhAnh")) { 
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "HinhAnh";
                imgCol.HeaderText = "Hình Ảnh";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgv_ds_nhan_vien.Columns.Insert(0, imgCol);
            }
            stt(dgv_ds_nhan_vien);
            load_hinh_anh_nhan_vien();
        }

        OpenFileDialog openFileDialogNV = null;

        private void btn_nv_Click(object sender, EventArgs e)
        {
            openFileDialogNV = new OpenFileDialog();
            openFileDialogNV.Title = "Chọn hình ảnh nhân viên";
            openFileDialogNV.Filter = "Image Files (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialogNV.ShowDialog() == DialogResult.OK)
            {
                if (ptb_nhan_vien.Image != null)
                {
                    ptb_nhan_vien.Image.Dispose();
                }
                ptb_nhan_vien.Image = new Bitmap(openFileDialogNV.FileName);
            }
        }

        public int kiemTraThongTinNV()
        {
            if (string.IsNullOrEmpty(txt_tai_khoan.Text)
               || string.IsNullOrEmpty(txt_mat_khau.Text)
               || string.IsNullOrEmpty(txt_ho_ten.Text)
               || string.IsNullOrEmpty(txt_dia_chi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 1;
            }
            return -1;
        } 

        public void resetFormNhanVien()
        {
            txt_tai_khoan.Clear();
            txt_mat_khau.Clear();
            txt_ho_ten.Clear();
            txt_dia_chi.Clear();
            rbt_nam.Checked = true;
            dtp_ngay_sinh.Value = DateTime.Now;
            swt_trang_thai_nv.Checked = false;
            ptb_nhan_vien.Image = null;
            openFileDialog = null;
        }

        private void btn_them_nv_Click(object sender, EventArgs e)
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            if (kiemTraThongTinNV() == 1) return;
            if (flagNV)
            {
                MessageBox.Show("Vui lòng làm mới form Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nhanVienBUS.kiemTraTaiKhoan(txt_tai_khoan.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(DateTime.Now.Year - dtp_ngay_sinh.Value.Year < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (openFileDialogNV == null || ptb_nhan_vien.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ptb_nhan_vien.Image != null )
            {
                ptb_nhan_vien.Image.Dispose();
                ptb_nhan_vien.Image = null;
            }

            if (!File.Exists(Path.Combine(pathNhanVien, Path.GetFileName(openFileDialogNV.FileName))))
            {
                File.Copy(openFileDialogNV.FileName, Path.Combine(pathNhanVien, Path.GetFileName(openFileDialogNV.FileName)));
                File.Move(Path.Combine(pathNhanVien, Path.GetFileName(openFileDialogNV.FileName)), Path.Combine(pathNhanVien, txt_tai_khoan.Text + ".jpg"));
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.TenDangNhap = txt_tai_khoan.Text;
                nv.MatKhau = txt_mat_khau.Text;
                nv.TenNV = txt_ho_ten.Text;
                nv.GioiTinh = rbt_nam.Checked ? "Nam" : "Nữ";
                nv.NgaySinh = dtp_ngay_sinh.Value.ToShortDateString();
                nv.DiaChi = txt_dia_chi.Text;
                nv.TrangThai = swt_trang_thai_nv.Checked ? 1 : 0;
                int res = nhanVienBUS.ThemNhanVien(nv);
                if (res > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dvNhanVien = nhanVienBUS.loadNhanVien().DefaultView;
                    dgv_ds_nhan_vien.DataSource = dvNhanVien  ;
                    resetFormNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_ds_nhan_vien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool flagNV = false;
        private void dgv_ds_nhan_vien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_dia_chi.Text = dgv_ds_nhan_vien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txt_ho_ten.Text = dgv_ds_nhan_vien.SelectedRows[0].Cells["HoTen"].Value.ToString();
            txt_tai_khoan.Text = dgv_ds_nhan_vien.SelectedRows[0].Cells["TaiKhoan"].Value.ToString();
            txt_mat_khau.Text = dgv_ds_nhan_vien.SelectedRows[0].Cells["MatKhau"].Value.ToString();
            dtp_ngay_sinh.Value = DateTime.Parse(dgv_ds_nhan_vien.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
            rbt_nam.Checked = dgv_ds_nhan_vien.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nam";
            rbt_nu.Checked = dgv_ds_nhan_vien.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nữ";
            swt_trang_thai_nv.Checked = (bool)dgv_ds_nhan_vien.SelectedRows[0].Cells["TrangThai"].Value;
            ptb_nhan_vien.Image = (Image)dgv_ds_nhan_vien.SelectedRows[0].Cells["HinhAnh"].Value ?? null;
            flagNV = true;
        }

        public void thay_doi_anhNV(NhanVienBUS nhanVienBUS, string txt_tk_cu)
        {

            if (!nhanVienBUS.kiemTraTaiKhoan(txt_tai_khoan.Text) && openFileDialogNV == null)
            {
                if (File.Exists(Path.Combine(pathNhanVien, txt_tk_cu + ".jpg")))
                {

                    File.Move(Path.Combine(pathNhanVien, txt_tk_cu + ".jpg"), Path.Combine(pathNhanVien, txt_tai_khoan.Text + ".jpg"));

                    imageCache.Remove(Path.Combine(pathNhanVien, txt_tk_cu + ".jpg"));
                    Image temp = new Bitmap(Path.Combine(pathNhanVien, txt_tai_khoan.Text + ".jpg"));
                    imageCacheNhanVien[Path.Combine(pathNhanVien, txt_tai_khoan.Text + ".jpg")] = temp;
                }
            }
            if (openFileDialogNV != null)
            {
                if (!nhanVienBUS.kiemTraTaiKhoan(txt_tai_khoan.Text))
                {
                    doiTenAnhNV(txt_tk_cu);
                }
                else
                {
                    doiTenAnhNV(txt_tk_cu);
                }
            }
        }

        public void doiTenAnhNV(string txt_tk_cu)
        {
            if (ptb_nhan_vien.Image != null)
            {
                ptb_nhan_vien.Image.Dispose();
                ptb_nhan_vien.Image = null;
            }
            if (File.Exists(Path.Combine(pathNhanVien, txt_tk_cu + ".jpg")))
            {
                dgv_ds_nhan_vien.SelectedRows[0].Cells["HinhAnh"].Value = null;
                File.Delete(Path.Combine(pathNhanVien, txt_tk_cu + ".jpg"));
            }

            if (!File.Exists(Path.Combine(pathNhanVien, Path.GetFileName(openFileDialogNV.FileName))))
            {
                File.Copy(openFileDialogNV.FileName, Path.Combine(pathNhanVien, Path.GetFileName(openFileDialogNV.FileName)));
                File.Move(Path.Combine(pathNhanVien, Path.GetFileName(openFileDialogNV.FileName)), Path.Combine(pathNhanVien, txt_tai_khoan.Text + ".jpg"));
                imageCacheNhanVien.Remove(Path.Combine(pathNhanVien, txt_tk_cu + ".jpg"));
                Image temp = new Bitmap(Path.Combine(pathNhanVien, txt_tai_khoan.Text + ".jpg"));
                imageCacheNhanVien[Path.Combine(pathNhanVien, txt_tai_khoan.Text + ".jpg")] = temp;
            }

        }
      


        private void btn_cap_nhat_nv_Click(object sender, EventArgs e)
        {
            if (flagNV)
            {
                if (kiemTraThongTinNV() == 1) return;
                string tenNV = txt_ho_ten.Text;
                DialogResult result = MessageBox.Show($"Bạn có chắc cập nhật nhân viên '{tenNV}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                NhanVienDTO nv = new NhanVienDTO();
                nv.TenNV = txt_ho_ten.Text.Trim();
                nv.GioiTinh = rbt_nam.Checked ? "Nam" : "Nữ";
                nv.NgaySinh = dtp_ngay_sinh.Value.ToShortDateString();
                nv.DiaChi = txt_dia_chi.Text.Trim();
                nv.TrangThai = swt_trang_thai.Checked ? 1 : 0;
                string tkCu = dgv_ds_nhan_vien.SelectedRows[0].Cells["TaiKhoan"].Value.ToString();
                nv.TenDangNhap = txt_tai_khoan.Text.Trim();
                nv.MatKhau = txt_mat_khau.Text.Trim();
                nv.TrangThai = swt_trang_thai_nv.Checked ? 1 : 0;
                NhanVienBUS nhanVienBUS = new NhanVienBUS();
                thay_doi_anhNV(nhanVienBUS, tkCu);
                int res = nhanVienBUS.capNhatNhanVien(nv);
                if (res > 0)
                {
                    MessageBox.Show($"Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dvNhanVien = nhanVienBUS.loadNhanVien().DefaultView;
                    dgv_ds_nhan_vien.DataSource = dvNhanVien;
                    resetFormNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                flagNV = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_lam_moi_nv_Click(object sender, EventArgs e)
        {
            resetFormNhanVien();
            flagNV = false;
        }

        private void btn_xoa_nv_Click(object sender, EventArgs e)
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            if (flagNV)
            {
                int maNV = (int)dgv_ds_nhan_vien.SelectedRows[0].Cells["MaNV"].Value;
                string tenNV = txt_ho_ten.Text;
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên '{tenNV}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int res = nhanVienBUS.xoaNhanVien(maNV);
                    if (res > 0)
                    {
                        if (ptb_san_pham.Image != null)
                        {
                            ptb_san_pham.Image.Dispose();
                            //ptb_san_pham.Image = null;
                        }
                        resetFormNhanVien();
                        File.Delete(Path.Combine(pathNhanVien, txt_tai_khoan.Text.Trim() + ".jpg"));
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dvNhanVien = nhanVienBUS.loadNhanVien().DefaultView;
                        dgv_ds_nhan_vien.DataSource = dvNhanVien;
                        imageCache.Remove(Path.Combine(pathNhanVien, txt_tai_khoan.Text.Trim() + ".jpg"));
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    flagNV = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tab_admin_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (tab_admin.SelectedTab.Name == "tab_nhan_vien")
            {
                loadNhanVien();
            }
        }
    }
}

