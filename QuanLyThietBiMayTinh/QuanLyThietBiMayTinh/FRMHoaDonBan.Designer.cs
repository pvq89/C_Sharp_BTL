﻿
namespace QuanLyThietBiMayTinh
{
    partial class FRMHoaDonBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.grvHDBan = new System.Windows.Forms.DataGridView();
            this.iMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvHDBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên Nhập";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(209, 30);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(173, 32);
            this.cbNhanVien.TabIndex = 1;
            // 
            // grvHDBan
            // 
            this.grvHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHDBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaHD,
            this.sTenNV,
            this.dNgaytao,
            this.fTongTien});
            this.grvHDBan.Location = new System.Drawing.Point(12, 129);
            this.grvHDBan.Name = "grvHDBan";
            this.grvHDBan.RowHeadersWidth = 51;
            this.grvHDBan.RowTemplate.Height = 24;
            this.grvHDBan.Size = new System.Drawing.Size(849, 309);
            this.grvHDBan.TabIndex = 2;
            // 
            // iMaHD
            // 
            this.iMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iMaHD.DataPropertyName = "iMaHD";
            this.iMaHD.HeaderText = "Mã Hóa dơn";
            this.iMaHD.MinimumWidth = 6;
            this.iMaHD.Name = "iMaHD";
            // 
            // sTenNV
            // 
            this.sTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTenNV.DataPropertyName = "sTenNV";
            this.sTenNV.HeaderText = "nhân viên bán";
            this.sTenNV.MinimumWidth = 6;
            this.sTenNV.Name = "sTenNV";
            // 
            // dNgaytao
            // 
            this.dNgaytao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dNgaytao.DataPropertyName = "dNgayTao";
            this.dNgaytao.HeaderText = "ngày tạo";
            this.dNgaytao.MinimumWidth = 6;
            this.dNgaytao.Name = "dNgaytao";
            // 
            // fTongTien
            // 
            this.fTongTien.DataPropertyName = "fTongTien";
            this.fTongTien.HeaderText = "tổng tiền";
            this.fTongTien.MinimumWidth = 6;
            this.fTongTien.Name = "fTongTien";
            this.fTongTien.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(53, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(161, 87);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 87);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // numericMin
            // 
            this.numericMin.Location = new System.Drawing.Point(501, 31);
            this.numericMin.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(98, 22);
            this.numericMin.TabIndex = 7;
            // 
            // numericMax
            // 
            this.numericMax.Location = new System.Drawing.Point(637, 30);
            this.numericMax.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(98, 22);
            this.numericMax.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(753, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "to";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(389, 87);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Location = new System.Drawing.Point(492, 87);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(148, 23);
            this.btnPrintOrder.TabIndex = 36;
            this.btnPrintOrder.Text = "in hóa đơn";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click_1);
            // 
            // FRMHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.btnPrintOrder);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.numericMax);
            this.Controls.Add(this.numericMin);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grvHDBan);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "FRMHoaDonBan";
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.FRMHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHDBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.DataGridView grvHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnPrintOrder;
    }
}