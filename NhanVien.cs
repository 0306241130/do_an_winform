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
        public NhanVien()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green400, Primary.Green800, Accent.Green700, TextShade.BLACK);
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
            }
        }
    }
}
