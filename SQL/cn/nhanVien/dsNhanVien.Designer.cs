﻿
namespace SQL.cn.nhanVien
{
    partial class dsNhanVien
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.labelList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 530);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 219;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(521, 59);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(251, 64);
            this.btnOwner.TabIndex = 218;
            this.btnOwner.Text = "Chủ nhà";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(780, 59);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(269, 64);
            this.btnStaff.TabIndex = 216;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(274, 59);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(239, 64);
            this.btnPost.TabIndex = 217;
            this.btnPost.Text = "Bài đăng";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(14, 59);
            this.btnCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(252, 64);
            this.btnCus.TabIndex = 215;
            this.btnCus.Text = "Khách hàng";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 214;
            this.label1.Text = "Xin chào, CHINHANH01";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 212;
            this.button1.Text = "Cá nhân";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(948, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 213;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(14, 156);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowHeadersWidth = 51;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(1031, 366);
            this.dataGridViewNhanVien.TabIndex = 211;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(11, 127);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(142, 17);
            this.labelList.TabIndex = 210;
            this.labelList.Text = "Danh sách nhân viên";
            // 
            // dsNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 574);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.labelList);
            this.Name = "dsNhanVien";
            this.Text = "dsNhanVien";
            this.Load += new System.EventHandler(this.dsNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.Label labelList;
    }
}