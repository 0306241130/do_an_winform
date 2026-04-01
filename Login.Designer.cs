namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_dang_nhap = new MaterialSkin.Controls.MaterialButton();
            this.txt_mat_khau = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_ten_dang_nhap = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(104, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.btn_dang_nhap);
            this.materialCard1.Controls.Add(this.txt_mat_khau);
            this.materialCard1.Controls.Add(this.txt_ten_dang_nhap);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(104, 226);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(362, 245);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(13, 116);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Mật khẩu";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Tài khoản";
            // 
            // btn_dang_nhap
            // 
            this.btn_dang_nhap.AutoSize = false;
            this.btn_dang_nhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_dang_nhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_dang_nhap.Depth = 0;
            this.btn_dang_nhap.HighEmphasis = true;
            this.btn_dang_nhap.Icon = null;
            this.btn_dang_nhap.Location = new System.Drawing.Point(18, 176);
            this.btn_dang_nhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_dang_nhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_dang_nhap.Name = "btn_dang_nhap";
            this.btn_dang_nhap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_dang_nhap.Size = new System.Drawing.Size(327, 43);
            this.btn_dang_nhap.TabIndex = 1;
            this.btn_dang_nhap.Text = "Đăng nhập";
            this.btn_dang_nhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_dang_nhap.UseAccentColor = false;
            this.btn_dang_nhap.UseVisualStyleBackColor = true;
            this.btn_dang_nhap.Click += new System.EventHandler(this.btn_dang_nhap_Click);
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.AnimateReadOnly = false;
            this.txt_mat_khau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mat_khau.Depth = 0;
            this.txt_mat_khau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_mat_khau.LeadingIcon = null;
            this.txt_mat_khau.Location = new System.Drawing.Point(111, 98);
            this.txt_mat_khau.MaxLength = 50;
            this.txt_mat_khau.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_mat_khau.Multiline = false;
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.Password = true;
            this.txt_mat_khau.Size = new System.Drawing.Size(234, 50);
            this.txt_mat_khau.TabIndex = 0;
            this.txt_mat_khau.Text = "";
            this.txt_mat_khau.TrailingIcon = null;
            // 
            // txt_ten_dang_nhap
            // 
            this.txt_ten_dang_nhap.AnimateReadOnly = false;
            this.txt_ten_dang_nhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ten_dang_nhap.Depth = 0;
            this.txt_ten_dang_nhap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ten_dang_nhap.LeadingIcon = null;
            this.txt_ten_dang_nhap.Location = new System.Drawing.Point(111, 17);
            this.txt_ten_dang_nhap.MaxLength = 50;
            this.txt_ten_dang_nhap.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ten_dang_nhap.Multiline = false;
            this.txt_ten_dang_nhap.Name = "txt_ten_dang_nhap";
            this.txt_ten_dang_nhap.Size = new System.Drawing.Size(234, 50);
            this.txt_ten_dang_nhap.TabIndex = 0;
            this.txt_ten_dang_nhap.Text = "";
            this.txt_ten_dang_nhap.TrailingIcon = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 589);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btn_dang_nhap;
        private MaterialSkin.Controls.MaterialTextBox txt_mat_khau;
        private MaterialSkin.Controls.MaterialTextBox txt_ten_dang_nhap;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}