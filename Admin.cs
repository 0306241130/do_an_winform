using BUS;
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
            var cbxColumn = new DataGridViewComboBoxColumn { 
                DataSource = loaiSanPhamBUS.load_loai_san_pham(),
                DisplayMember = "TenLoai",
                ValueMember = "MaLoai",
                HeaderText = "Loại Sản Phẩm",
                DataPropertyName = "MaLoai"
            };

            dgv_ds_san_pham.Columns.Insert(2,cbxColumn);

        }
        Dictionary<string, Image> imageCache = new Dictionary<string, Image>();
        
        public void load_hinh_anh()
        {

            if(dgv_ds_san_pham.Rows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in dgv_ds_san_pham.Rows)
            {
                if (row.IsNewRow) continue;

                string tenSP = row.Cells["TenSP"].Value.ToString();
                if (string.IsNullOrEmpty(tenSP)) continue;
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
    }
}
