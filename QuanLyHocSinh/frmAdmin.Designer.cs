
namespace QuanLyHocSinh
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnHocPhi = new FontAwesome.Sharp.IconButton();
            this.btnThonTin = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnDiemSo = new FontAwesome.Sharp.IconButton();
            this.btnGVCN = new FontAwesome.Sharp.IconButton();
            this.btnQLLopHoc = new FontAwesome.Sharp.IconButton();
            this.btnQLHocSinh = new FontAwesome.Sharp.IconButton();
            this.btnDashBoard = new FontAwesome.Sharp.IconButton();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new QuanLyHocSinh.GradientPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureAvatar = new QuanLyHocSinh.CircularPictureBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.iconChange = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChange)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.panelMenu);
            this.panelLogo.Controls.Add(this.panel2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(208, 512);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnHocPhi);
            this.panelMenu.Controls.Add(this.btnThonTin);
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnDiemSo);
            this.panelMenu.Controls.Add(this.btnGVCN);
            this.panelMenu.Controls.Add(this.btnQLLopHoc);
            this.panelMenu.Controls.Add(this.btnQLHocSinh);
            this.panelMenu.Controls.Add(this.btnDashBoard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 69);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(204, 439);
            this.panelMenu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 69);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(75, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trường THPT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(83)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chuyên Lam Sơn";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(208, 49);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(726, 463);
            this.panelContent.TabIndex = 2;
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocPhi.FlatAppearance.BorderSize = 0;
            this.btnHocPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocPhi.ForeColor = System.Drawing.Color.DimGray;
            this.btnHocPhi.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnHocPhi.IconColor = System.Drawing.Color.DimGray;
            this.btnHocPhi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHocPhi.IconSize = 25;
            this.btnHocPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhi.Location = new System.Drawing.Point(0, 280);
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnHocPhi.Size = new System.Drawing.Size(204, 40);
            this.btnHocPhi.TabIndex = 16;
            this.btnHocPhi.Text = "Học Phí";
            this.btnHocPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocPhi.UseVisualStyleBackColor = true;
            this.btnHocPhi.Click += new System.EventHandler(this.btnHocPhi_Click);
            this.btnHocPhi.MouseHover += new System.EventHandler(this.btnHocPhi_MouseHover);
            // 
            // btnThonTin
            // 
            this.btnThonTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThonTin.FlatAppearance.BorderSize = 0;
            this.btnThonTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThonTin.ForeColor = System.Drawing.Color.DimGray;
            this.btnThonTin.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnThonTin.IconColor = System.Drawing.Color.DimGray;
            this.btnThonTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThonTin.IconSize = 25;
            this.btnThonTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThonTin.Location = new System.Drawing.Point(0, 240);
            this.btnThonTin.Name = "btnThonTin";
            this.btnThonTin.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnThonTin.Size = new System.Drawing.Size(204, 40);
            this.btnThonTin.TabIndex = 15;
            this.btnThonTin.Text = "Thông Tin";
            this.btnThonTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThonTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThonTin.UseVisualStyleBackColor = true;
            this.btnThonTin.MouseHover += new System.EventHandler(this.btnThonTin_MouseHover);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.DimGray;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnThongKe.IconColor = System.Drawing.Color.DimGray;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 25;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 200);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnThongKe.Size = new System.Drawing.Size(204, 40);
            this.btnThongKe.TabIndex = 14;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.MouseHover += new System.EventHandler(this.btnThongKe_MouseHover);
            // 
            // btnDiemSo
            // 
            this.btnDiemSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemSo.FlatAppearance.BorderSize = 0;
            this.btnDiemSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemSo.ForeColor = System.Drawing.Color.DimGray;
            this.btnDiemSo.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnDiemSo.IconColor = System.Drawing.Color.DimGray;
            this.btnDiemSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiemSo.IconSize = 25;
            this.btnDiemSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemSo.Location = new System.Drawing.Point(0, 160);
            this.btnDiemSo.Name = "btnDiemSo";
            this.btnDiemSo.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDiemSo.Size = new System.Drawing.Size(204, 40);
            this.btnDiemSo.TabIndex = 13;
            this.btnDiemSo.Text = "Điểm Số";
            this.btnDiemSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiemSo.UseVisualStyleBackColor = true;
            this.btnDiemSo.MouseHover += new System.EventHandler(this.btnDiemSo_MouseHover);
            // 
            // btnGVCN
            // 
            this.btnGVCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGVCN.FlatAppearance.BorderSize = 0;
            this.btnGVCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGVCN.ForeColor = System.Drawing.Color.DimGray;
            this.btnGVCN.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnGVCN.IconColor = System.Drawing.Color.DimGray;
            this.btnGVCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGVCN.IconSize = 25;
            this.btnGVCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGVCN.Location = new System.Drawing.Point(0, 120);
            this.btnGVCN.Name = "btnGVCN";
            this.btnGVCN.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnGVCN.Size = new System.Drawing.Size(204, 40);
            this.btnGVCN.TabIndex = 12;
            this.btnGVCN.Text = "Giáo Viên Chủ Nhiệm";
            this.btnGVCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGVCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGVCN.UseVisualStyleBackColor = true;
            this.btnGVCN.Click += new System.EventHandler(this.btnGVCN_Click);
            this.btnGVCN.MouseHover += new System.EventHandler(this.btnGVCN_MouseHover);
            // 
            // btnQLLopHoc
            // 
            this.btnQLLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLLopHoc.FlatAppearance.BorderSize = 0;
            this.btnQLLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLLopHoc.ForeColor = System.Drawing.Color.DimGray;
            this.btnQLLopHoc.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnQLLopHoc.IconColor = System.Drawing.Color.DimGray;
            this.btnQLLopHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLLopHoc.IconSize = 25;
            this.btnQLLopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLopHoc.Location = new System.Drawing.Point(0, 80);
            this.btnQLLopHoc.Name = "btnQLLopHoc";
            this.btnQLLopHoc.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnQLLopHoc.Size = new System.Drawing.Size(204, 40);
            this.btnQLLopHoc.TabIndex = 11;
            this.btnQLLopHoc.Text = "Quản Lý Lớp Học";
            this.btnQLLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLLopHoc.UseVisualStyleBackColor = true;
            this.btnQLLopHoc.MouseHover += new System.EventHandler(this.btnQLLopHoc_MouseHover);
            // 
            // btnQLHocSinh
            // 
            this.btnQLHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHocSinh.FlatAppearance.BorderSize = 0;
            this.btnQLHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHocSinh.ForeColor = System.Drawing.Color.DimGray;
            this.btnQLHocSinh.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnQLHocSinh.IconColor = System.Drawing.Color.DimGray;
            this.btnQLHocSinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLHocSinh.IconSize = 25;
            this.btnQLHocSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHocSinh.Location = new System.Drawing.Point(0, 40);
            this.btnQLHocSinh.Name = "btnQLHocSinh";
            this.btnQLHocSinh.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnQLHocSinh.Size = new System.Drawing.Size(204, 40);
            this.btnQLHocSinh.TabIndex = 10;
            this.btnQLHocSinh.Text = "Quản Lý Học Sinh";
            this.btnQLHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHocSinh.UseVisualStyleBackColor = true;
            this.btnQLHocSinh.Click += new System.EventHandler(this.btnQLHocSinh_Click);
            this.btnQLHocSinh.MouseHover += new System.EventHandler(this.btnQLHocSinh_MouseHover);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.DimGray;
            this.btnDashBoard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnDashBoard.IconColor = System.Drawing.Color.DimGray;
            this.btnDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashBoard.IconSize = 25;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDashBoard.Size = new System.Drawing.Size(204, 40);
            this.btnDashBoard.TabIndex = 9;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            this.btnDashBoard.MouseHover += new System.EventHandler(this.btnDashBoard_MouseHover);
            // 
            // btnLogo
            // 
            this.btnLogo.Image = global::QuanLyHocSinh.Properties.Resources.logo;
            this.btnLogo.Location = new System.Drawing.Point(21, 7);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(48, 40);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 180F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.gradientPanel1.Controls.Add(this.lblLogin);
            this.gradientPanel1.Controls.Add(this.pictureAvatar);
            this.gradientPanel1.Controls.Add(this.lblChange);
            this.gradientPanel1.Controls.Add(this.iconChange);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(208, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(726, 49);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(210)))));
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("VNI-Ariston", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(642, 11);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 22);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "label3";
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureAvatar.Image = global::QuanLyHocSinh.Properties.Resources.avata_02;
            this.pictureAvatar.Location = new System.Drawing.Point(606, 9);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(30, 30);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 2;
            this.pictureAvatar.TabStop = false;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChange.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChange.Location = new System.Drawing.Point(55, 14);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(88, 19);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "DashBoard";
            // 
            // iconChange
            // 
            this.iconChange.BackColor = System.Drawing.Color.Transparent;
            this.iconChange.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconChange.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChange.IconColor = System.Drawing.Color.Gainsboro;
            this.iconChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChange.IconSize = 29;
            this.iconChange.Location = new System.Drawing.Point(16, 9);
            this.iconChange.Name = "iconChange";
            this.iconChange.Size = new System.Drawing.Size(33, 29);
            this.iconChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconChange.TabIndex = 0;
            this.iconChange.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panelLogo);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panelLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnLogo;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lblChange;
        private FontAwesome.Sharp.IconPictureBox iconChange;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHocPhi;
        private FontAwesome.Sharp.IconButton btnThonTin;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnDiemSo;
        private FontAwesome.Sharp.IconButton btnGVCN;
        private FontAwesome.Sharp.IconButton btnQLLopHoc;
        private FontAwesome.Sharp.IconButton btnQLHocSinh;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private System.Windows.Forms.Panel panelContent;
        private CircularPictureBox pictureAvatar;
        private System.Windows.Forms.Label lblLogin;
    }
}