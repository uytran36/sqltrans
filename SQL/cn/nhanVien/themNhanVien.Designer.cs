﻿
namespace SQL.cn.nhanVien
{
    partial class themNhanVien
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
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.labelDetail = new System.Windows.Forms.Label();
            this.tbIDChiNhanh = new System.Windows.Forms.TextBox();
            this.labelIDChiNhanh = new System.Windows.Forms.Label();
            this.tbThanhPho = new System.Windows.Forms.TextBox();
            this.labelThanhPho = new System.Windows.Forms.Label();
            this.tbKhuVuc = new System.Windows.Forms.TextBox();
            this.labelKhuVuc = new System.Windows.Forms.Label();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.labelSdt = new System.Windows.Forms.Label();
            this.tbQuan = new System.Windows.Forms.TextBox();
            this.tbDuong = new System.Windows.Forms.TextBox();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbIDNhanVien = new System.Windows.Forms.TextBox();
            this.labelQuan = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelDuong = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelIDNhanVien = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.labelGT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(545, 61);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(251, 64);
            this.btnOwner.TabIndex = 263;
            this.btnOwner.Text = "Chủ nhà";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(804, 61);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(269, 64);
            this.btnStaff.TabIndex = 261;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(298, 61);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(239, 64);
            this.btnPost.TabIndex = 262;
            this.btnPost.Text = "Bài đăng";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(38, 61);
            this.btnCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(252, 64);
            this.btnCus.TabIndex = 260;
            this.btnCus.Text = "Khách hàng";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(41, 133);
            this.labelDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(117, 17);
            this.labelDetail.TabIndex = 259;
            this.labelDetail.Text = "Chi tiết nhân viên";
            // 
            // tbIDChiNhanh
            // 
            this.tbIDChiNhanh.Location = new System.Drawing.Point(529, 432);
            this.tbIDChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDChiNhanh.Name = "tbIDChiNhanh";
            this.tbIDChiNhanh.Size = new System.Drawing.Size(279, 22);
            this.tbIDChiNhanh.TabIndex = 258;
            // 
            // labelIDChiNhanh
            // 
            this.labelIDChiNhanh.AutoSize = true;
            this.labelIDChiNhanh.Location = new System.Drawing.Point(313, 432);
            this.labelIDChiNhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDChiNhanh.Name = "labelIDChiNhanh";
            this.labelIDChiNhanh.Size = new System.Drawing.Size(97, 17);
            this.labelIDChiNhanh.TabIndex = 257;
            this.labelIDChiNhanh.Text = "Mã chi nhánh:";
            // 
            // tbThanhPho
            // 
            this.tbThanhPho.Location = new System.Drawing.Point(529, 342);
            this.tbThanhPho.Margin = new System.Windows.Forms.Padding(4);
            this.tbThanhPho.Name = "tbThanhPho";
            this.tbThanhPho.Size = new System.Drawing.Size(279, 22);
            this.tbThanhPho.TabIndex = 256;
            // 
            // labelThanhPho
            // 
            this.labelThanhPho.AutoSize = true;
            this.labelThanhPho.Location = new System.Drawing.Point(313, 342);
            this.labelThanhPho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThanhPho.Name = "labelThanhPho";
            this.labelThanhPho.Size = new System.Drawing.Size(81, 17);
            this.labelThanhPho.TabIndex = 255;
            this.labelThanhPho.Text = "Thành phố:";
            // 
            // tbKhuVuc
            // 
            this.tbKhuVuc.Location = new System.Drawing.Point(529, 372);
            this.tbKhuVuc.Margin = new System.Windows.Forms.Padding(4);
            this.tbKhuVuc.Name = "tbKhuVuc";
            this.tbKhuVuc.Size = new System.Drawing.Size(279, 22);
            this.tbKhuVuc.TabIndex = 254;
            // 
            // labelKhuVuc
            // 
            this.labelKhuVuc.AutoSize = true;
            this.labelKhuVuc.Location = new System.Drawing.Point(313, 372);
            this.labelKhuVuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKhuVuc.Name = "labelKhuVuc";
            this.labelKhuVuc.Size = new System.Drawing.Size(63, 17);
            this.labelKhuVuc.TabIndex = 253;
            this.labelKhuVuc.Text = "Khu vực:";
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(529, 402);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(279, 22);
            this.tbSdt.TabIndex = 252;
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Location = new System.Drawing.Point(313, 402);
            this.labelSdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(95, 17);
            this.labelSdt.TabIndex = 251;
            this.labelSdt.Text = "Số điện thoại:";
            // 
            // tbQuan
            // 
            this.tbQuan.Location = new System.Drawing.Point(529, 310);
            this.tbQuan.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuan.Name = "tbQuan";
            this.tbQuan.Size = new System.Drawing.Size(279, 22);
            this.tbQuan.TabIndex = 250;
            // 
            // tbDuong
            // 
            this.tbDuong.Location = new System.Drawing.Point(529, 279);
            this.tbDuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbDuong.Name = "tbDuong";
            this.tbDuong.Size = new System.Drawing.Size(279, 22);
            this.tbDuong.TabIndex = 249;
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Location = new System.Drawing.Point(529, 218);
            this.tbNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(279, 22);
            this.tbNgaySinh.TabIndex = 248;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(529, 188);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(279, 22);
            this.tbName.TabIndex = 247;
            // 
            // tbIDNhanVien
            // 
            this.tbIDNhanVien.Location = new System.Drawing.Point(529, 156);
            this.tbIDNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDNhanVien.Name = "tbIDNhanVien";
            this.tbIDNhanVien.Size = new System.Drawing.Size(279, 22);
            this.tbIDNhanVien.TabIndex = 246;
            // 
            // labelQuan
            // 
            this.labelQuan.AutoSize = true;
            this.labelQuan.Location = new System.Drawing.Point(313, 310);
            this.labelQuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuan.Name = "labelQuan";
            this.labelQuan.Size = new System.Drawing.Size(47, 17);
            this.labelQuan.TabIndex = 244;
            this.labelQuan.Text = "Quận:";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(313, 218);
            this.labelNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(75, 17);
            this.labelNgaySinh.TabIndex = 243;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelDuong
            // 
            this.labelDuong.AutoSize = true;
            this.labelDuong.Location = new System.Drawing.Point(313, 279);
            this.labelDuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuong.Name = "labelDuong";
            this.labelDuong.Size = new System.Drawing.Size(54, 17);
            this.labelDuong.TabIndex = 245;
            this.labelDuong.Text = "Đường:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(313, 187);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(103, 17);
            this.labelName.TabIndex = 242;
            this.labelName.Text = "Tên nhân viên:";
            // 
            // labelIDNhanVien
            // 
            this.labelIDNhanVien.AutoSize = true;
            this.labelIDNhanVien.Location = new System.Drawing.Point(313, 156);
            this.labelIDNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDNhanVien.Name = "labelIDNhanVien";
            this.labelIDNhanVien.Size = new System.Drawing.Size(97, 17);
            this.labelIDNhanVien.TabIndex = 241;
            this.labelIDNhanVien.Text = "Mã nhân viên:";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(36, 32);
            this.labelHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(158, 17);
            this.labelHello.TabIndex = 240;
            this.labelHello.Text = "Xin chào, CHINHANH01";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(863, 26);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 28);
            this.btnUser.TabIndex = 238;
            this.btnUser.Text = "Cá nhân";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(971, 26);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 239;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(545, 492);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 264;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(437, 492);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 265;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(529, 250);
            this.tbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(279, 22);
            this.tbGioiTinh.TabIndex = 267;
            // 
            // labelGT
            // 
            this.labelGT.AutoSize = true;
            this.labelGT.Location = new System.Drawing.Point(313, 250);
            this.labelGT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGT.Name = "labelGT";
            this.labelGT.Size = new System.Drawing.Size(64, 17);
            this.labelGT.TabIndex = 266;
            this.labelGT.Text = "Giới tính:";
            // 
            // themNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 548);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.labelGT);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.tbIDChiNhanh);
            this.Controls.Add(this.labelIDChiNhanh);
            this.Controls.Add(this.tbThanhPho);
            this.Controls.Add(this.labelThanhPho);
            this.Controls.Add(this.tbKhuVuc);
            this.Controls.Add(this.labelKhuVuc);
            this.Controls.Add(this.tbSdt);
            this.Controls.Add(this.labelSdt);
            this.Controls.Add(this.tbQuan);
            this.Controls.Add(this.tbDuong);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbIDNhanVien);
            this.Controls.Add(this.labelQuan);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelDuong);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelIDNhanVien);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Name = "themNhanVien";
            this.Text = "themNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.TextBox tbIDChiNhanh;
        private System.Windows.Forms.Label labelIDChiNhanh;
        private System.Windows.Forms.TextBox tbThanhPho;
        private System.Windows.Forms.Label labelThanhPho;
        private System.Windows.Forms.TextBox tbKhuVuc;
        private System.Windows.Forms.Label labelKhuVuc;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Label labelSdt;
        private System.Windows.Forms.TextBox tbQuan;
        private System.Windows.Forms.TextBox tbDuong;
        private System.Windows.Forms.TextBox tbNgaySinh;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIDNhanVien;
        private System.Windows.Forms.Label labelQuan;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelDuong;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelIDNhanVien;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Label labelGT;
    }
}