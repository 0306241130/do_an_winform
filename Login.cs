using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace WindowsFormsApp1
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green400, Primary.Green800, Accent.Green700, TextShade.BLACK);

            
        }
        public void dang_nhap()
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.TenDangNhap = txt_ten_dang_nhap.Text;
            nhanVien.MatKhau = txt_mat_khau.Text;
            
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            int kq = nhanVienBUS.dangNhap(nhanVien);

            if (kq == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                NhanVien nv = new NhanVien(nhanVien.TenDangNhap,nhanVien.MatKhau);
          
                nv.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

    

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten_dang_nhap.Text) || string.IsNullOrEmpty(txt_mat_khau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            dang_nhap();
        }
    }
}
