namespace WinFormsApp1
{
    partial class FGiaoVien
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
            lblBirthday = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            lblCmnd = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            gvGiaoVien = new DataGridView();
            btnThem = new Button();
            dtbBirthday = new DateTimePicker();
            txtCmnd = new TextBox();
            lblAddress = new Label();
            lblName = new Label();
            btnHocSinh = new Button();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            lblGioiTinh = new Label();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            btnXoaText = new Button();
            ((System.ComponentModel.ISupportInitialize)gvGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(1, 200);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(149, 20);
            lblBirthday.TabIndex = 23;
            lblBirthday.Text = "Ngay thang nam sinh";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(253, 479);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(128, 479);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblCmnd
            // 
            lblCmnd.AutoSize = true;
            lblCmnd.Location = new Point(1, 157);
            lblCmnd.Name = "lblCmnd";
            lblCmnd.Size = new Size(53, 20);
            lblCmnd.TabIndex = 20;
            lblCmnd.Text = "CMND";
            // 
            // txtName
            // 
            txtName.Location = new Point(284, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(284, 113);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 18;
            // 
            // gvGiaoVien
            // 
            gvGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvGiaoVien.Location = new Point(500, 22);
            gvGiaoVien.Name = "gvGiaoVien";
            gvGiaoVien.RowHeadersWidth = 51;
            gvGiaoVien.RowTemplate.Height = 29;
            gvGiaoVien.Size = new Size(796, 496);
            gvGiaoVien.TabIndex = 17;
            gvGiaoVien.CellContentClick += gvGiaoVien_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 479);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 16;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtbBirthday
            // 
            dtbBirthday.Location = new Point(159, 195);
            dtbBirthday.Name = "dtbBirthday";
            dtbBirthday.Size = new Size(250, 27);
            dtbBirthday.TabIndex = 15;
            // 
            // txtCmnd
            // 
            txtCmnd.Location = new Point(284, 157);
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(125, 27);
            txtCmnd.TabIndex = 14;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(1, 116);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 20);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "Dia chi";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(1, 73);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 20);
            lblName.TabIndex = 12;
            lblName.Text = "Ho va ten";
            // 
            // btnHocSinh
            // 
            btnHocSinh.Location = new Point(366, 479);
            btnHocSinh.Name = "btnHocSinh";
            btnHocSinh.Size = new Size(94, 29);
            btnHocSinh.TabIndex = 24;
            btnHocSinh.Text = "Hoc Sinh";
            btnHocSinh.UseVisualStyleBackColor = true;
            btnHocSinh.Click += btnHocSinh_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(284, 292);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(125, 27);
            txtSoDienThoai.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 30;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(1, 292);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(102, 20);
            lblSoDienThoai.TabIndex = 29;
            lblSoDienThoai.Text = "So Dien Thoai";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(1, 249);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(1, 340);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 27;
            lblGioiTinh.Text = "Gioi Tinh";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(366, 338);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(49, 24);
            rdoNu.TabIndex = 26;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nu";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(285, 338);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 25;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnXoaText
            // 
            btnXoaText.Location = new Point(187, 514);
            btnXoaText.Name = "btnXoaText";
            btnXoaText.Size = new Size(94, 29);
            btnXoaText.TabIndex = 32;
            btnXoaText.Text = "Xoa text";
            btnXoaText.UseVisualStyleBackColor = true;
            btnXoaText.Click += btnXoaText_Click;
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 225, 197);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1308, 554);
            Controls.Add(btnXoaText);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtEmail);
            Controls.Add(lblSoDienThoai);
            Controls.Add(lblEmail);
            Controls.Add(lblGioiTinh);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(btnHocSinh);
            Controls.Add(lblBirthday);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(lblCmnd);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(gvGiaoVien);
            Controls.Add(btnThem);
            Controls.Add(dtbBirthday);
            Controls.Add(txtCmnd);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            Load += FGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)gvGiaoVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBirthday;
        private Button btnSua;
        private Button btnXoa;
        private Label lblCmnd;
        private TextBox txtName;
        private TextBox txtAddress;
        private DataGridView gvGiaoVien;
        private Button btnThem;
        private DateTimePicker dtbBirthday;
        private TextBox txtCmnd;
        private Label lblAddress;
        private Label lblName;
        private Button btnHocSinh;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
        private Label lblSoDienThoai;
        private Label lblEmail;
        private Label lblGioiTinh;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Button btnXoaText;
    }
}