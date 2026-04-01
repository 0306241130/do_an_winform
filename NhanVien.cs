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

        }
        string path=Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "Images");

        public void loadSanPham(int loai=1) {
            SanPhamBUS sanPhamBUS = new SanPhamBUS();

            var SanPhamList = sanPhamBUS.load_sanPham_NhanVien(loai);

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


        private void NhanVien_Load(object sender, EventArgs e)
        {
            
            loadSanPham();
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

        private void lv_san_pham_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

                foreach (ListViewItem item in lv_cho_thanh_toan.Items)
                {

                    if (item.Text == itm.Text.Split('\n')[0])
                    {
                        item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                        item.SubItems[3].Text = (int.Parse(item.SubItems[1].Text) * int.Parse(itm.SubItems[1].Text)).ToString("N0") + "đ";
                        tinh_tong_tien();
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
        }

       
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (lv_cho_thanh_toan.SelectedItems.Count > 0)
            {
                int so_luong = Int32.Parse(txt_thanh_toan_so_luong.Text) + 1;
                txt_thanh_toan_so_luong.Text = so_luong.ToString();
                foreach (ListViewItem item in lv_cho_thanh_toan.SelectedItems)
                {
                    item.SubItems[1].Text = txt_thanh_toan_so_luong.Text;
                }
                tinh_lai_thanh_tien();
                tinh_tong_tien();
            }
        }

        public void tinh_lai_thanh_tien()
        {
            foreach (ListViewItem item in lv_cho_thanh_toan.Items)
            {
                string gia_str = item.SubItems[2].Text;
                gia_str = gia_str.Replace("đ", "").Trim();
                gia_str = gia_str.Replace(",", "").Trim();
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
            int tong_tien = 0;
            foreach (ListViewItem item in lv_cho_thanh_toan.Items)
            {
                string gia_str = item.SubItems[3].Text;
                gia_str = gia_str.Replace("đ", "").Trim();
                gia_str = gia_str.Replace(",", "").Trim();
                tong_tien += int.Parse(gia_str);
            }
            lbl_tong_tien.Text = "Tổng tiền: " + tong_tien.ToString("N0") + "đ";
        }
    }
}
