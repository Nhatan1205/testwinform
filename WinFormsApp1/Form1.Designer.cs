namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblAddress = new Label();
            txtCmnd = new TextBox();
            dtbBirthday = new DateTimePicker();
            btnThem = new Button();
            gvHocSinh = new DataGridView();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lblCmnd = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            lblBirthday = new Label();
            btnGiaoVien = new Button();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            lblGioiTinh = new Label();
            lblEmail = new Label();
            lblSoDienThoai = new Label();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            btnXoaText = new Button();
            ((System.ComponentModel.ISupportInitialize)gvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ho va ten";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 75);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 20);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Dia chi";
            // 
            // txtCmnd
            // 
            txtCmnd.Location = new Point(295, 116);
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(125, 27);
            txtCmnd.TabIndex = 2;
            // 
            // dtbBirthday
            // 
            dtbBirthday.Location = new Point(170, 154);
            dtbBirthday.Name = "dtbBirthday";
            dtbBirthday.Size = new Size(250, 27);
            dtbBirthday.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(22, 480);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // gvHocSinh
            // 
            gvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHocSinh.Location = new Point(512, 12);
            gvHocSinh.Name = "gvHocSinh";
            gvHocSinh.RowHeadersWidth = 51;
            gvHocSinh.RowTemplate.Height = 29;
            gvHocSinh.Size = new Size(771, 497);
            gvHocSinh.TabIndex = 5;
            gvHocSinh.CellContentClick += gvHocSinh_CellContentClick;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(295, 72);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(295, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // lblCmnd
            // 
            lblCmnd.AutoSize = true;
            lblCmnd.Location = new Point(12, 116);
            lblCmnd.Name = "lblCmnd";
            lblCmnd.Size = new Size(53, 20);
            lblCmnd.TabIndex = 8;
            lblCmnd.Text = "CMND";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(138, 480);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(258, 480);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(12, 159);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(149, 20);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "Ngay thang nam sinh";
            // 
            // btnGiaoVien
            // 
            btnGiaoVien.Location = new Point(400, 480);
            btnGiaoVien.Name = "btnGiaoVien";
            btnGiaoVien.Size = new Size(94, 29);
            btnGiaoVien.TabIndex = 12;
            btnGiaoVien.Text = "Giao Vien";
            btnGiaoVien.UseVisualStyleBackColor = true;
            btnGiaoVien.Click += btnGiaoVien_Click;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(290, 293);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 13;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            rdoNam.CheckedChanged += rdoNam_CheckedChanged;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(371, 293);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(49, 24);
            rdoNu.TabIndex = 14;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nu";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(12, 297);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 15;
            lblGioiTinh.Text = "Gioi Tinh";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 204);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(12, 247);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(102, 20);
            lblSoDienThoai.TabIndex = 17;
            lblSoDienThoai.Text = "So Dien Thoai";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(295, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(295, 247);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(125, 27);
            txtSoDienThoai.TabIndex = 19;
            // 
            // btnXoaText
            // 
            btnXoaText.Location = new Point(197, 515);
            btnXoaText.Name = "btnXoaText";
            btnXoaText.Size = new Size(94, 29);
            btnXoaText.TabIndex = 20;
            btnXoaText.Text = "Xoa text";
            btnXoaText.UseVisualStyleBackColor = true;
            btnXoaText.Click += btnXoaText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1295, 591);
            Controls.Add(btnXoaText);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtEmail);
            Controls.Add(lblSoDienThoai);
            Controls.Add(lblEmail);
            Controls.Add(lblGioiTinh);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(btnGiaoVien);
            Controls.Add(lblBirthday);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(lblCmnd);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(gvHocSinh);
            Controls.Add(btnThem);
            Controls.Add(dtbBirthday);
            Controls.Add(txtCmnd);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "FHocSinh";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private TextBox txtCmnd;
        private DateTimePicker dtbBirthday;
        private Button btnThem;
        private DataGridView gvHocSinh;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lblCmnd;
        private Button btnXoa;
        private Button btnSua;
        private Label lblBirthday;
        private Button btnGiaoVien;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label lblGioiTinh;
        private Label lblEmail;
        private Label lblSoDienThoai;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private Button btnXoaText;
    }
}