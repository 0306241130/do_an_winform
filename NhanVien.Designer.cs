namespace WindowsFormsApp1
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lv_san_pham = new System.Windows.Forms.ListView();
            this.image_list_sp = new System.Windows.Forms.ImageList(this.components);
            this.lbl_ma_nv = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ten_nhan_vien = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tong_tien = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_xoa = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_giam = new System.Windows.Forms.Button();
            this.txt_thanh_toan_so_luong = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_than_toan = new MaterialSkin.Controls.MaterialButton();
            this.lv_cho_thanh_toan = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_hop_mau = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_but_muc = new MaterialSkin.Controls.MaterialButton();
            this.btn_but_chi = new MaterialSkin.Controls.MaterialButton();
            this.btn_tap_viet = new MaterialSkin.Controls.MaterialButton();
            this.btn_giay = new MaterialSkin.Controls.MaterialButton();
            this.btn_may_tinh = new MaterialSkin.Controls.MaterialButton();
            this.btn_keo = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1541, 788);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lv_san_pham);
            this.tabPage1.Controls.Add(this.lbl_ma_nv);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.lbl_ten_nhan_vien);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1533, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang Chủ";
            // 
            // lv_san_pham
            // 
            this.lv_san_pham.HideSelection = false;
            this.lv_san_pham.LargeImageList = this.image_list_sp;
            this.lv_san_pham.Location = new System.Drawing.Point(255, 20);
            this.lv_san_pham.Margin = new System.Windows.Forms.Padding(4);
            this.lv_san_pham.MultiSelect = false;
            this.lv_san_pham.Name = "lv_san_pham";
            this.lv_san_pham.Size = new System.Drawing.Size(613, 681);
            this.lv_san_pham.TabIndex = 9;
            this.lv_san_pham.UseCompatibleStateImageBehavior = false;
            this.lv_san_pham.Click += new System.EventHandler(this.lv_san_pham_Click);
            // 
            // image_list_sp
            // 
            this.image_list_sp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_list_sp.ImageStream")));
            this.image_list_sp.TransparentColor = System.Drawing.Color.Transparent;
            this.image_list_sp.Images.SetKeyName(0, "Zoo-Logos-11.png");
            // 
            // lbl_ma_nv
            // 
            this.lbl_ma_nv.AutoSize = true;
            this.lbl_ma_nv.Depth = 0;
            this.lbl_ma_nv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ma_nv.Location = new System.Drawing.Point(1432, 719);
            this.lbl_ma_nv.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ma_nv.Name = "lbl_ma_nv";
            this.lbl_ma_nv.Size = new System.Drawing.Size(28, 19);
            this.lbl_ma_nv.TabIndex = 8;
            this.lbl_ma_nv.Text = "Mã:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(1391, 719);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(28, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Mã:";
            // 
            // lbl_ten_nhan_vien
            // 
            this.lbl_ten_nhan_vien.AutoSize = true;
            this.lbl_ten_nhan_vien.Depth = 0;
            this.lbl_ten_nhan_vien.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ten_nhan_vien.Location = new System.Drawing.Point(129, 719);
            this.lbl_ten_nhan_vien.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ten_nhan_vien.Name = "lbl_ten_nhan_vien";
            this.lbl_ten_nhan_vien.Size = new System.Drawing.Size(78, 19);
            this.lbl_ten_nhan_vien.TabIndex = 8;
            this.lbl_ten_nhan_vien.Text = "Nhân Viên:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(12, 719);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(78, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Nhân Viên:";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tableLayoutPanel5);
            this.materialCard1.Controls.Add(this.tableLayoutPanel4);
            this.materialCard1.Controls.Add(this.tableLayoutPanel3);
            this.materialCard1.Controls.Add(this.tableLayoutPanel2);
            this.materialCard1.Controls.Add(this.lv_cho_thanh_toan);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(885, 25);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(610, 681);
            this.materialCard1.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.26109F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.73891F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_tong_tien, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 456);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(609, 80);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại Thanh Toán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng Tiền:";
            // 
            // lbl_tong_tien
            // 
            this.lbl_tong_tien.AutoSize = true;
            this.lbl_tong_tien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong_tien.Location = new System.Drawing.Point(303, 45);
            this.lbl_tong_tien.Name = "lbl_tong_tien";
            this.lbl_tong_tien.Size = new System.Drawing.Size(303, 35);
            this.lbl_tong_tien.TabIndex = 7;
            this.lbl_tong_tien.Text = "0đ";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(303, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_xoa, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 542);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(610, 47);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_xoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_xoa.Depth = 0;
            this.btn_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xoa.HighEmphasis = true;
            this.btn_xoa.Icon = null;
            this.btn_xoa.Location = new System.Drawing.Point(4, 6);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_xoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_xoa.Size = new System.Drawing.Size(602, 35);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_xoa.UseAccentColor = false;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0237F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.71564F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.26066F));
            this.tableLayoutPanel3.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_giam, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_thanh_toan_so_luong, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 592);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(605, 44);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // btn_them
            // 
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(3, 2);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(266, 40);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "+";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_giam
            // 
            this.btn_giam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_giam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giam.Location = new System.Drawing.Point(333, 2);
            this.btn_giam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_giam.Name = "btn_giam";
            this.btn_giam.Size = new System.Drawing.Size(269, 40);
            this.btn_giam.TabIndex = 1;
            this.btn_giam.Text = "-";
            this.btn_giam.UseVisualStyleBackColor = true;
            this.btn_giam.Click += new System.EventHandler(this.btn_giam_Click);
            // 
            // txt_thanh_toan_so_luong
            // 
            this.txt_thanh_toan_so_luong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_thanh_toan_so_luong.Enabled = false;
            this.txt_thanh_toan_so_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanh_toan_so_luong.Location = new System.Drawing.Point(275, 2);
            this.txt_thanh_toan_so_luong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_thanh_toan_so_luong.Multiline = true;
            this.txt_thanh_toan_so_luong.Name = "txt_thanh_toan_so_luong";
            this.txt_thanh_toan_so_luong.Size = new System.Drawing.Size(52, 40);
            this.txt_thanh_toan_so_luong.TabIndex = 2;
            this.txt_thanh_toan_so_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_than_toan, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 626);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(605, 50);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btn_than_toan
            // 
            this.btn_than_toan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_than_toan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_than_toan.Depth = 0;
            this.btn_than_toan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_than_toan.HighEmphasis = true;
            this.btn_than_toan.Icon = null;
            this.btn_than_toan.Location = new System.Drawing.Point(4, 8);
            this.btn_than_toan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_than_toan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_than_toan.Name = "btn_than_toan";
            this.btn_than_toan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_than_toan.Size = new System.Drawing.Size(597, 36);
            this.btn_than_toan.TabIndex = 0;
            this.btn_than_toan.Text = "Thanh Toán";
            this.btn_than_toan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_than_toan.UseAccentColor = false;
            this.btn_than_toan.UseVisualStyleBackColor = true;
            this.btn_than_toan.Click += new System.EventHandler(this.btn_than_toan_Click);
            // 
            // lv_cho_thanh_toan
            // 
            this.lv_cho_thanh_toan.AutoSizeTable = false;
            this.lv_cho_thanh_toan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_cho_thanh_toan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_cho_thanh_toan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_cho_thanh_toan.Depth = 0;
            this.lv_cho_thanh_toan.FullRowSelect = true;
            this.lv_cho_thanh_toan.HideSelection = false;
            this.lv_cho_thanh_toan.Location = new System.Drawing.Point(0, 0);
            this.lv_cho_thanh_toan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_cho_thanh_toan.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv_cho_thanh_toan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_cho_thanh_toan.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_cho_thanh_toan.Name = "lv_cho_thanh_toan";
            this.lv_cho_thanh_toan.OwnerDraw = true;
            this.lv_cho_thanh_toan.Size = new System.Drawing.Size(609, 451);
            this.lv_cho_thanh_toan.TabIndex = 4;
            this.lv_cho_thanh_toan.UseCompatibleStateImageBehavior = false;
            this.lv_cho_thanh_toan.View = System.Windows.Forms.View.Details;
            this.lv_cho_thanh_toan.SelectedIndexChanged += new System.EventHandler(this.lv_cho_thanh_toan_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Sản Phẩm";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 168;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_hop_mau, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_but_muc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_but_chi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_tap_viet, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_giay, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_may_tinh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_keo, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.98833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.01167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 681);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_hop_mau
            // 
            this.btn_hop_mau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_hop_mau.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_hop_mau.Depth = 0;
            this.btn_hop_mau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hop_mau.HighEmphasis = true;
            this.btn_hop_mau.Icon = null;
            this.btn_hop_mau.Location = new System.Drawing.Point(5, 628);
            this.btn_hop_mau.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_hop_mau.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_hop_mau.Name = "btn_hop_mau";
            this.btn_hop_mau.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_hop_mau.Size = new System.Drawing.Size(230, 46);
            this.btn_hop_mau.TabIndex = 5;
            this.btn_hop_mau.Text = "USB";
            this.btn_hop_mau.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_hop_mau.UseAccentColor = false;
            this.btn_hop_mau.UseVisualStyleBackColor = true;
            this.btn_hop_mau.Click += new System.EventHandler(this.btn_hop_mau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Zoo_Logos_111;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_but_muc
            // 
            this.btn_but_muc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_but_muc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_but_muc.Depth = 0;
            this.btn_but_muc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_but_muc.HighEmphasis = true;
            this.btn_but_muc.Icon = null;
            this.btn_but_muc.Location = new System.Drawing.Point(5, 265);
            this.btn_but_muc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_but_muc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_but_muc.Name = "btn_but_muc";
            this.btn_but_muc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_but_muc.Size = new System.Drawing.Size(230, 56);
            this.btn_but_muc.TabIndex = 1;
            this.btn_but_muc.Text = "Bút Mực";
            this.btn_but_muc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_but_muc.UseAccentColor = false;
            this.btn_but_muc.UseVisualStyleBackColor = true;
            this.btn_but_muc.Click += new System.EventHandler(this.btn_but_muc_Click);
            // 
            // btn_but_chi
            // 
            this.btn_but_chi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_but_chi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_but_chi.Depth = 0;
            this.btn_but_chi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_but_chi.HighEmphasis = true;
            this.btn_but_chi.Icon = null;
            this.btn_but_chi.Location = new System.Drawing.Point(5, 334);
            this.btn_but_chi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_but_chi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_but_chi.Name = "btn_but_chi";
            this.btn_but_chi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_but_chi.Size = new System.Drawing.Size(230, 45);
            this.btn_but_chi.TabIndex = 2;
            this.btn_but_chi.Text = "bút chì";
            this.btn_but_chi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_but_chi.UseAccentColor = false;
            this.btn_but_chi.UseVisualStyleBackColor = true;
            this.btn_but_chi.Click += new System.EventHandler(this.btn_but_chi_Click);
            // 
            // btn_tap_viet
            // 
            this.btn_tap_viet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_tap_viet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_tap_viet.Depth = 0;
            this.btn_tap_viet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tap_viet.HighEmphasis = true;
            this.btn_tap_viet.Icon = null;
            this.btn_tap_viet.Location = new System.Drawing.Point(5, 392);
            this.btn_tap_viet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_tap_viet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_tap_viet.Name = "btn_tap_viet";
            this.btn_tap_viet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_tap_viet.Size = new System.Drawing.Size(230, 47);
            this.btn_tap_viet.TabIndex = 3;
            this.btn_tap_viet.Text = "Tập Viết";
            this.btn_tap_viet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_tap_viet.UseAccentColor = false;
            this.btn_tap_viet.UseVisualStyleBackColor = true;
            this.btn_tap_viet.Click += new System.EventHandler(this.btn_tap_viet_Click);
            // 
            // btn_giay
            // 
            this.btn_giay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_giay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_giay.Depth = 0;
            this.btn_giay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_giay.HighEmphasis = true;
            this.btn_giay.Icon = null;
            this.btn_giay.Location = new System.Drawing.Point(5, 452);
            this.btn_giay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_giay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_giay.Name = "btn_giay";
            this.btn_giay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_giay.Size = new System.Drawing.Size(230, 46);
            this.btn_giay.TabIndex = 3;
            this.btn_giay.Text = "Giấy";
            this.btn_giay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_giay.UseAccentColor = false;
            this.btn_giay.UseVisualStyleBackColor = true;
            this.btn_giay.Click += new System.EventHandler(this.btn_giay_Click);
            // 
            // btn_may_tinh
            // 
            this.btn_may_tinh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_may_tinh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_may_tinh.Depth = 0;
            this.btn_may_tinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_may_tinh.HighEmphasis = true;
            this.btn_may_tinh.Icon = null;
            this.btn_may_tinh.Location = new System.Drawing.Point(5, 511);
            this.btn_may_tinh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_may_tinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_may_tinh.Name = "btn_may_tinh";
            this.btn_may_tinh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_may_tinh.Size = new System.Drawing.Size(230, 48);
            this.btn_may_tinh.TabIndex = 3;
            this.btn_may_tinh.Text = "Máy tính";
            this.btn_may_tinh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_may_tinh.UseAccentColor = false;
            this.btn_may_tinh.UseVisualStyleBackColor = true;
            this.btn_may_tinh.Click += new System.EventHandler(this.btn_may_tinh_Click);
            // 
            // btn_keo
            // 
            this.btn_keo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_keo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_keo.Depth = 0;
            this.btn_keo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_keo.HighEmphasis = true;
            this.btn_keo.Icon = null;
            this.btn_keo.Location = new System.Drawing.Point(5, 572);
            this.btn_keo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_keo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_keo.Name = "btn_keo";
            this.btn_keo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_keo.Size = new System.Drawing.Size(230, 43);
            this.btn_keo.TabIndex = 3;
            this.btn_keo.Text = "Kéo";
            this.btn_keo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_keo.UseAccentColor = false;
            this.btn_keo.UseVisualStyleBackColor = true;
            this.btn_keo.Click += new System.EventHandler(this.btn_keo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1533, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh Thu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(41, 33);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Doanh Thu:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(187, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(731, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(788, 623);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(782, 592);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(543, 623);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 592);
            this.dataGridView1.TabIndex = 0;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 854);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhanVien";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_giam;
        private System.Windows.Forms.TextBox txt_thanh_toan_so_luong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btn_than_toan;
        private MaterialSkin.Controls.MaterialListView lv_cho_thanh_toan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_but_muc;
        private MaterialSkin.Controls.MaterialButton btn_but_chi;
        private MaterialSkin.Controls.MaterialButton btn_tap_viet;
        private MaterialSkin.Controls.MaterialButton btn_giay;
        private MaterialSkin.Controls.MaterialButton btn_may_tinh;
        private MaterialSkin.Controls.MaterialButton btn_keo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lbl_ten_nhan_vien;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ImageList image_list_sp;
        private System.Windows.Forms.ListView lv_san_pham;
        private MaterialSkin.Controls.MaterialButton btn_hop_mau;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel lbl_ma_nv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialButton btn_xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tong_tien;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}