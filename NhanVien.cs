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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class NhanVien : MaterialForm
    {
        public NhanVien(string taiKhoan,string matKhau)
        {
            

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green400, Primary.Green800, Accent.Green700, TextShade.BLACK);

            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            NhanVienDTO nv = nhanVienBUS.thong_tin_nhan_vien(taiKhoan,matKhau);
            lbl_ten_nhan_vien.Text = nv.TenNV;
            lbl_ma_nv.Text=nv.MaNV.ToString();
            loadLoaiThanhToan();
            load();

        }
        public void load()
        {
            tableLayoutPanel8.BackColor = Color.DarkSeaGreen;
            tableLayoutPanel7.BackColor = Color.Chartreuse;
            tableLayoutPanel9.BackColor = Color.SpringGreen;
            tableLayoutPanel16.BackColor=Color.AliceBlue;
            tableLayoutPanel17.BackColor = Color.AliceBlue;
            tableLayoutPanel18.BackColor = Color.AliceBlue;
            lbl_doanh_thu.Font = new Font(SystemFonts.DefaultFont.FontFamily,(float)22.2, FontStyle.Bold^FontStyle.Italic);
            lbl_so_loi.Font = new Font(SystemFonts.DefaultFont.FontFamily, (float)22.2, FontStyle.Bold ^ FontStyle.Italic);
            lbl_nhap_hang.Font = new Font(SystemFonts.DefaultFont.FontFamily, (float)22.2, FontStyle.Bold ^ FontStyle.Italic);
            lbl_doanh_thu1.Font = new Font(SystemFonts.DefaultFont.FontFamily, (float)13.8, FontStyle.Bold);
            lbl_so_loi_1.Font = new Font(SystemFonts.DefaultFont.FontFamily, (float)13.8, FontStyle.Bold);
            lbl_nhap_hang1.Font = new Font(SystemFonts.DefaultFont.FontFamily, (float)13.8, FontStyle.Bold);
            label9.Font = new Font(SystemFonts.DefaultFont.FontFamily, 12, FontStyle.Bold);
            label11.Font = new Font(SystemFonts.DefaultFont.FontFamily,12, FontStyle.Bold);
            label13.Font = new Font(SystemFonts.DefaultFont.FontFamily, 12, FontStyle.Bold);


        }
        string path=Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "Images");
        List<SanPhamDTO>SanPhamList = null;
        public void loadSanPham(int loai=1) {
            SanPhamBUS sanPhamBUS = new SanPhamBUS();

             SanPhamList = sanPhamBUS.load_sanPham_NhanVien(loai);

            foreach (var sanPham in SanPhamList)
            {


                if (File.Exists(Path.Combine(path, sanPham.TenSp.ToString() + ".jpg")))
                {
                    // Load ảnh từ file
                    Image img = Image.FromFile(Path.Combine(path, sanPham.TenSp.ToString() + ".jpg"));
                    if (!image_list_sp.Images.ContainsKey(sanPham.TenSp))
                    {
                        image_list_sp.Images.Add($"{sanPham.TenSp}", img);
                    }

                    // MessageBox.Show(image_list_sp.Images.Count.ToString());
                    ListViewItem item = new ListViewItem();
                    item.Text = (sanPham.TenSp + "\n" + (sanPham.Gia).ToString("N0")) + "đ";
                    item.SubItems.Add(sanPham.Gia.ToString());
                    item.SubItems.Add(sanPham.MaSP.ToString());

                    item.ImageKey = sanPham.TenSp;
                    lv_san_pham.Items.Add(item);
                }

            }
        }

        public void loadLoaiThanhToan()
        {
            LoaiThanhToanBUS loaiThanhToanBUS = new LoaiThanhToanBUS();
            cbx_loai_thanh_toan.DataSource = loaiThanhToanBUS.getLoaiThanhToan();
            cbx_loai_thanh_toan.DisplayMember = "TenPhuongThucThanhToan";
            cbx_loai_thanh_toan.ValueMember = "MaLoaiThanhToan";
        }

        public void loadDoanhThu()
        {
            DoanhThuBUS doanhThuBUS = new DoanhThuBUS();
            
            float doanh_thu = doanhThuBUS.doanhThuTheoNgay(0, dt_doanh_thu.Value.Date);
            float so_loi = doanhThuBUS.doanhThuTheoNgay(1, dt_doanh_thu.Value.Date);
            float nhap_hang = doanhThuBUS.doanhThuTheoNgay(2, dt_doanh_thu.Value.Date);
            float doanh_thu_hom_qua = doanhThuBUS.doanhThuTheoNgay(3, dt_doanh_thu.Value.Date);
            float nhap_hang_hom_qua = doanhThuBUS.doanhThuTheoNgay(4, dt_doanh_thu.Value.Date);
            float so_loi_hom_qua = doanhThuBUS.doanhThuTheoNgay(5, dt_doanh_thu.Value.Date);
            lbl_doanh_thu1.Text = doanh_thu.ToString("N0") + "đ";
            lbl_so_loi_1.Text = so_loi.ToString("N0") + "đ";
            lbl_nhap_hang1.Text = nhap_hang.ToString("N0") + "đ";
            lbl_doanh_thu_hom_qua.Text=doanh_thu_hom_qua.ToString("N0") + "đ";
            lbl_nhap_hang_hom_qua.Text = nhap_hang_hom_qua.ToString("N0") + "đ";
            lbl_lai_hom_qua.Text = so_loi_hom_qua.ToString("N0") + "đ";
        }

        public void loadPhieuNhap()
        {
           
            CT_PhieuNhapBUS phieuNhapBUS = new CT_PhieuNhapBUS();
            DataTable dataTable = phieuNhapBUS.getCTPhieuNhap();
            dataTable.Clear();
            dgv_phieu_nhap.DataSource = dataTable;
            dgv_phieu_nhap.Columns["MaCT_HD"].Visible = false;
            dgv_phieu_nhap.Columns["MaPN"].Visible = false;
            dgv_phieu_nhap.Columns["MaSP"].Visible = false;

            SanPhamBUS sanPhamBUS = new SanPhamBUS();
            DataTable sanPhamTable = sanPhamBUS.getDanhSachSanPham();
            
            var columnSanPham = new DataGridViewComboBoxColumn{
                Name = "TenSP",
                HeaderText = "Tên sản phẩm",
                DataSource = sanPhamTable,
                DisplayMember = "TenSp",
                ValueMember = "MaSP",
                DataPropertyName = "MaSP"
            };
            dgv_phieu_nhap.Columns.Insert(0, columnSanPham);
            dgv_phieu_nhap.AllowUserToResizeColumns = true;
            dgv_phieu_nhap.Columns["ThanhTien"].ReadOnly = true;

            dgv_phieu_nhap.Columns["Gia_nhap"].HeaderText = "Giá Nhập";
            dgv_phieu_nhap.Columns["SoLuongNhap"].HeaderText = "Số Lượng Nhập";
            dgv_phieu_nhap.Columns["ThanhTien"].HeaderText = "Thành Tiền";

        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            
            loadSanPham();
            loadDoanhThu();
            loadPhieuNhap();
        }

        private void btn_but_muc_Click(object sender, EventArgs e)
        {
            lv_san_pham.Clear();
            loadSanPham(1);
          
        }

        private void btn_but_chi_Click(object sender, EventArgs e)
        {
            lv_san_pham.Clear();
            loadSanPham(2);
        }

        private void btn_tap_viet_Click(object sender, EventArgs e)
        {
            lv_san_pham.Clear();
            loadSanPham(3);
        }

        private void btn_giay_Click(object sender, EventArgs e)
        {
            lv_san_pham.Clear();
            loadSanPham(4);
        }

        private void btn_may_tinh_Click(object sender, EventArgs e)
        {
            lv_san_pham.Clear();
            loadSanPham(5);
        }

        private void btn_keo_Click(object sender, EventArgs e)
        {
            lv_san_pham.Clear();
            loadSanPham(6);
        }

        private void btn_hop_mau_Click(object sender, EventArgs e)
        {
            lv_san_pham.Clear();
            loadSanPham(10);
        }

        public bool kiemTraSoLuongSanPham(int soLuongTrenManHinh,int maSP)
        {
            foreach(SanPhamDTO sp in SanPhamList)
            {
                if(sp.MaSP == maSP)
                {
                    if (soLuongTrenManHinh <= sp.SoLuong)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void lv_san_pham_Click(object sender, EventArgs e)
        {
            if(lv_san_pham.SelectedItems.Count > 0)
            {
                ListViewItem itm = new ListViewItem();
                foreach (ListViewItem item in lv_san_pham.SelectedItems)
                {
                    itm = item;
                    
                }
                if (!kiemTraSoLuongSanPham( 1, int.Parse(itm.SubItems[2].Text)))
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ để thêm vào giỏ hàng", "Thông báo");
                    return;
                }


                foreach (ListViewItem item in lv_cho_thanh_toan.Items)
                {
                    if (itm.SubItems[2].Text == item.SubItems[4].Text)
                    {
                        if (!kiemTraSoLuongSanPham(Int32.Parse(item.SubItems[1].Text) + 1, int.Parse(itm.SubItems[2].Text)))
                        {
                            MessageBox.Show("Số lượng sản phẩm không đủ để thêm vào giỏ hàng", "Thông báo");
                            return;
                        }
                    }
                   
                    if (item.SubItems[4].Text == itm.SubItems[2].Text)
                    {
                      
                        item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                        item.SubItems[3].Text = (int.Parse(item.SubItems[1].Text) * int.Parse(itm.SubItems[1].Text)).ToString("N0") + "đ";
                        tinh_tong_tien();
                        if (lv_cho_thanh_toan.SelectedItems.Count > 0)
                        {
                            foreach (ListViewItem item1 in lv_cho_thanh_toan.SelectedItems)
                            {
                                txt_thanh_toan_so_luong.Text = item1.SubItems[1].Text;
                            }
                        }
                        return;
                    }
                }

             



                foreach (ListViewItem item in lv_san_pham.SelectedItems)
                {
                    ListViewItem item1 = new ListViewItem();
                    item1.Text = item.Text.Split('\n')[0];
                    item1.SubItems.Add("1");
                    item1.SubItems.Add(Int32.Parse((item.SubItems[1].Text)).ToString("N0") + "đ");
                    item1.SubItems.Add(Int32.Parse(item.SubItems[1].Text).ToString("N0") + "đ");
                    item1.SubItems.Add(item.SubItems[2].Text);
                    lv_cho_thanh_toan.Items.Add(item1);
                }
                tinh_tong_tien();
            }
        }

        private void lv_cho_thanh_toan_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lv_cho_thanh_toan.SelectedItems)
            {
               txt_thanh_toan_so_luong.Text =item.SubItems[1].Text ;
              
            }
            if(lv_cho_thanh_toan.SelectedItems.Count == 0)
            {
                txt_thanh_toan_so_luong.Text = "";
            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            if (lv_cho_thanh_toan.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lv_cho_thanh_toan.SelectedItems)
                {
                    if (!kiemTraSoLuongSanPham(Int32.Parse(item.SubItems[1].Text) + 1, int.Parse(item.SubItems[4].Text)))
                    {
                        MessageBox.Show("Số lượng sản phẩm không đủ để thêm vào giỏ hàng", "Thông báo");
                        txt_thanh_toan_so_luong.Text = item.SubItems[1].Text;
                        return;
                    }

                    item.SubItems[1].Text = (Int32.Parse(txt_thanh_toan_so_luong.Text) + 1).ToString();
                }
                int so_luong = Int32.Parse(txt_thanh_toan_so_luong.Text) + 1;
                txt_thanh_toan_so_luong.Text = so_luong.ToString();

                tinh_lai_thanh_tien();
                tinh_tong_tien();
            }
        }

       

        public void tinh_lai_thanh_tien()
        {
            foreach (ListViewItem item in lv_cho_thanh_toan.Items)
            {
                string gia_str = format_tong_tien(item.SubItems[2].Text);
                item.SubItems[3].Text = (int.Parse(item.SubItems[1].Text) * int.Parse(gia_str)).ToString("N0") + "đ";
            }
        }

        private void btn_giam_Click(object sender, EventArgs e)
        {

            if (lv_cho_thanh_toan.SelectedItems.Count > 0)
            {
                int so_luong = Int32.Parse(txt_thanh_toan_so_luong.Text);
                if (so_luong > 1)
                {
                    so_luong -= 1;
                }
                txt_thanh_toan_so_luong.Text = so_luong.ToString();
                foreach (ListViewItem item in lv_cho_thanh_toan.SelectedItems)
                {
                    item.SubItems[1].Text = txt_thanh_toan_so_luong.Text;
                }
                tinh_lai_thanh_tien();
                tinh_tong_tien();
            }
        }

        public void tinh_tong_tien()
        {
            float tong_tien = 0;
            foreach (ListViewItem item in lv_cho_thanh_toan.Items)
            {
                string gia_str =format_tong_tien(item.SubItems[3].Text);
                tong_tien += float.Parse(gia_str);
            }
            lbl_tong_tien.Text =tong_tien.ToString("N0") + "đ";
        }

        public string format_tong_tien(string tien)
        {   
            tien = tien.Replace("đ", "").Trim();
            tien = tien.Replace(",", "").Trim();
            return tien;
        }
        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            HoaDonDTO hoaDonDTO = new HoaDonDTO();
            CT_HoaDonDTO ct_HoaDonDTO = new CT_HoaDonDTO();

            hoaDonDTO.MaNV = Int32.Parse(lbl_ma_nv.Text);
            hoaDonDTO.MaLoaiThanhToan = (int)cbx_loai_thanh_toan.SelectedValue;
            hoaDonDTO.TrangThai = 2;

            hoaDonDTO.NgayLap = DateTime.Now;
           
            string tong_tien_str = format_tong_tien(lbl_tong_tien.Text);
            hoaDonDTO.TongTien = float.Parse(tong_tien_str);
         
            HoaDonBUS hoaDonBUS = new HoaDonBUS();
            int t = hoaDonBUS.themHoaDon(hoaDonDTO);
           // MessageBox.Show($"Thêm {t} hóa đơn thành công ");

            List<CT_HoaDonDTO> ct_HoaDonDTOs = new List<CT_HoaDonDTO>();
            foreach (ListViewItem item in lv_cho_thanh_toan.Items)
            {
                CT_HoaDonDTO ct = new CT_HoaDonDTO();
                ct.MaSP = Int32.Parse(item.SubItems[4].Text);
                ct.SoLuong = Int32.Parse(item.SubItems[1].Text);
                string gia_str = format_tong_tien(item.SubItems[2].Text);
             
                ct.DonGia = float.Parse(gia_str);
                string thanh_tien_str = format_tong_tien(item.SubItems[3].Text);
             
                ct.ThanhTien = float.Parse(thanh_tien_str);
                ct_HoaDonDTOs.Add(ct);
            }

            hoaDonBUS.themCT_HoaDon(ct_HoaDonDTOs);
            MessageBox.Show("Thanh toán thành công");
             lv_cho_thanh_toan.Items.Clear();
             lbl_tong_tien.Text = "0đ";
            txt_thanh_toan_so_luong.Text = "";
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lv_cho_thanh_toan.SelectedItems)
            {
                lv_cho_thanh_toan.Items.Remove(item);
                txt_thanh_toan_so_luong.Text = "";
                tinh_tong_tien();
            }
        }

        private void dt_doanh_thu_ValueChanged(object sender, EventArgs e)
        {
            loadDoanhThu();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex == 1) {
                loadDoanhThu();
            }
        }

        private void dgv_phieu_nhap_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_phieu_nhap.CurrentCell.ColumnIndex != 2)
            {
                TextBox txt = ((TextBox)e.Control);

                txt.KeyPress += (s, ev) =>
                {
                    if (char.IsControl(ev.KeyChar) || char.IsDigit(ev.KeyChar)) {
                        return;
                    }

                    if (dgv_phieu_nhap.CurrentCell.ColumnIndex == 3)
                    {
                        if (ev.KeyChar == '.' && !txt.Text.Contains('.') && txt.Text.Length > 0) {   
                            return;
                        }
                    }
                    ev.Handled = true;
                };
                
            }
        }

        public void tinh_thanh_tien_phieu_nhap()
        {
            foreach (DataGridViewRow row in dgv_phieu_nhap.Rows)
            {
                if (row.IsNewRow) break;
                if (row.Cells["Gia_nhap"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Gia_nhap"].Value.ToString())&&
                    row.Cells["SoLuongNhap"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["SoLuongNhap"].Value.ToString()))
                {
                    float gia = float.Parse(row.Cells["Gia_nhap"].Value.ToString());
                    int so_luong = int.Parse(row.Cells["SoLuongNhap"].Value.ToString());
                    float thanh_tien = gia * so_luong;
                    row.Cells["ThanhTien"].Value = thanh_tien;
                }
            }
        }

        private void btn_tao_phieu_Click(object sender, EventArgs e)
        {
            PhieuNhapDTO phieuNhapDTO  = new PhieuNhapDTO();
            
            float tong_tien = 0;
            foreach (DataGridViewRow row in dgv_phieu_nhap.Rows)
            {
                if (row.IsNewRow) break;
                if (row.Cells["ThanhTien"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["ThanhTien"].Value.ToString()))
                {
                    tong_tien += float.Parse(row.Cells["ThanhTien"].Value.ToString());
                }
            }
            phieuNhapDTO.TongTien = tong_tien;
            phieuNhapDTO.MaNV = Int32.Parse(lbl_ma_nv.Text);
            phieuNhapDTO.NgayNhap = DateTime.Now;

            PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
            
            int maPN = phieuNhapBUS.themPhieuNhap(phieuNhapDTO);
            
            foreach(DataGridViewRow row in dgv_phieu_nhap.Rows)
            {
                CT_PhieuNhapDTO ct_PhieuNhapDTO = new CT_PhieuNhapDTO();
                if (row.IsNewRow) break;
                if (row.Cells["MaSP"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["MaSP"].Value.ToString()) &&
                    row.Cells["Gia_nhap"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Gia_nhap"].Value.ToString()) &&
                    row.Cells["SoLuongNhap"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["SoLuongNhap"].Value.ToString()))
                {
                    ct_PhieuNhapDTO.MaPN = phieuNhapBUS.getMaPN();
                    ct_PhieuNhapDTO.MaSP = int.Parse(row.Cells["MaSP"].Value.ToString());
                    ct_PhieuNhapDTO.GiaNhap = float.Parse(row.Cells["Gia_nhap"].Value.ToString());
                    ct_PhieuNhapDTO.SoLuong = int.Parse(row.Cells["SoLuongNhap"].Value.ToString());
                    ct_PhieuNhapDTO.ThanhTien = ct_PhieuNhapDTO.GiaNhap * ct_PhieuNhapDTO.SoLuong;
                    CT_PhieuNhapBUS ct_PhieuNhapBUS = new CT_PhieuNhapBUS();
                    ct_PhieuNhapBUS.themCT(ct_PhieuNhapDTO);   
                }
            }
            ((DataTable)dgv_phieu_nhap.DataSource).Rows.Clear();
            if (maPN > 0)
            {
                MessageBox.Show("Tạo phiếu nhập thành công");
            }

        }

        private void dgv_phieu_nhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tinh_thanh_tien_phieu_nhap();
        }

        private void btn_dang_xuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
