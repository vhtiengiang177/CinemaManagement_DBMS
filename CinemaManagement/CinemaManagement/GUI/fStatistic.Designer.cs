﻿namespace CinemaManagement.GUI
{
    partial class fStatistic
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.cboTimeStatistic = new System.Windows.Forms.ComboBox();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmovie = new System.Windows.Forms.Label();
            this.lbTotalPro = new System.Windows.Forms.Label();
            this.lbTotalReal = new System.Windows.Forms.Label();
            this.lbCinema = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCinema = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCtrl = new System.Windows.Forms.Button();
            this.btnOrgan = new System.Windows.Forms.Button();
            this.lbNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn tháng";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcel.Location = new System.Drawing.Point(701, 71);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(94, 26);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Xuất file Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cboTimeStatistic
            // 
            this.cboTimeStatistic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeStatistic.Enabled = false;
            this.cboTimeStatistic.FormattingEnabled = true;
            this.cboTimeStatistic.Items.AddRange(new object[] {
            "Cả năm",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cboTimeStatistic.Location = new System.Drawing.Point(287, 64);
            this.cboTimeStatistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTimeStatistic.Name = "cboTimeStatistic";
            this.cboTimeStatistic.Size = new System.Drawing.Size(92, 21);
            this.cboTimeStatistic.TabIndex = 11;
            this.cboTimeStatistic.SelectedIndexChanged += new System.EventHandler(this.cboTimeStatistic_SelectedIndexChanged);
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.num,
            this.total,
            this.promotion,
            this.real});
            this.dgvStatistic.Location = new System.Drawing.Point(35, 162);
            this.dgvStatistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 24;
            this.dgvStatistic.Size = new System.Drawing.Size(507, 307);
            this.dgvStatistic.TabIndex = 12;
            // 
            // name
            // 
            this.name.DataPropertyName = "TenPhim";
            this.name.HeaderText = "Tên Phim";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // num
            // 
            this.num.DataPropertyName = "SoLuong";
            this.num.HeaderText = "Số vé";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            // 
            // total
            // 
            this.total.DataPropertyName = "Tong";
            this.total.HeaderText = "Tổng doanh số bán ra";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // promotion
            // 
            this.promotion.DataPropertyName = "TongGiam";
            this.promotion.HeaderText = "Tổng giảm";
            this.promotion.MinimumWidth = 6;
            this.promotion.Name = "promotion";
            // 
            // real
            // 
            this.real.DataPropertyName = "TongThu";
            this.real.HeaderText = "Tổng thực thu";
            this.real.MinimumWidth = 6;
            this.real.Name = "real";
            // 
            // lbmovie
            // 
            this.lbmovie.AutoSize = true;
            this.lbmovie.Location = new System.Drawing.Point(172, 35);
            this.lbmovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmovie.Name = "lbmovie";
            this.lbmovie.Size = new System.Drawing.Size(13, 13);
            this.lbmovie.TabIndex = 21;
            this.lbmovie.Text = "0";
            // 
            // lbTotalPro
            // 
            this.lbTotalPro.AutoSize = true;
            this.lbTotalPro.Location = new System.Drawing.Point(172, 125);
            this.lbTotalPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPro.Name = "lbTotalPro";
            this.lbTotalPro.Size = new System.Drawing.Size(13, 13);
            this.lbTotalPro.TabIndex = 20;
            this.lbTotalPro.Text = "0";
            // 
            // lbTotalReal
            // 
            this.lbTotalReal.AutoSize = true;
            this.lbTotalReal.Location = new System.Drawing.Point(172, 94);
            this.lbTotalReal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalReal.Name = "lbTotalReal";
            this.lbTotalReal.Size = new System.Drawing.Size(13, 13);
            this.lbTotalReal.TabIndex = 19;
            this.lbTotalReal.Text = "0";
            // 
            // lbCinema
            // 
            this.lbCinema.AutoSize = true;
            this.lbCinema.Location = new System.Drawing.Point(172, 11);
            this.lbCinema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCinema.Name = "lbCinema";
            this.lbCinema.Size = new System.Drawing.Size(13, 13);
            this.lbCinema.TabIndex = 17;
            this.lbCinema.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng giảm cho khuyến mãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng doanh số thực tế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng phim ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chọn rạp";
            // 
            // cboCinema
            // 
            this.cboCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinema.Enabled = false;
            this.cboCinema.FormattingEnabled = true;
            this.cboCinema.Location = new System.Drawing.Point(444, 64);
            this.cboCinema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCinema.Name = "cboCinema";
            this.cboCinema.Size = new System.Drawing.Size(99, 21);
            this.cboCinema.TabIndex = 16;
            this.cboCinema.SelectedIndexChanged += new System.EventHandler(this.cboCinema_SelectedIndexChanged);
            this.cboCinema.TextChanged += new System.EventHandler(this.cboCinema_TextChanged);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Enabled = false;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(97, 64);
            this.cboYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(99, 21);
            this.cboYear.TabIndex = 18;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            this.cboYear.TextChanged += new System.EventHandler(this.cboYear_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chọn năm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbmovie);
            this.panel2.Controls.Add(this.lbTotalPro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbTotalReal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbCinema);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(563, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 155);
            this.panel2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-23, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(472, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "_____________________________________________________________________________-";
            // 
            // txtCtrl
            // 
            this.txtCtrl.BackColor = System.Drawing.Color.White;
            this.txtCtrl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCtrl.Location = new System.Drawing.Point(214, 96);
            this.txtCtrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCtrl.Name = "txtCtrl";
            this.txtCtrl.Size = new System.Drawing.Size(146, 26);
            this.txtCtrl.TabIndex = 23;
            this.txtCtrl.Text = "Tùy chỉnh thống kê";
            this.txtCtrl.UseVisualStyleBackColor = false;
            this.txtCtrl.Click += new System.EventHandler(this.txtCtrl_Click);
            // 
            // btnOrgan
            // 
            this.btnOrgan.BackColor = System.Drawing.Color.White;
            this.btnOrgan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOrgan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrgan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrgan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOrgan.Location = new System.Drawing.Point(40, 96);
            this.btnOrgan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrgan.Name = "btnOrgan";
            this.btnOrgan.Size = new System.Drawing.Size(162, 26);
            this.btnOrgan.TabIndex = 24;
            this.btnOrgan.Text = "Thống kê mặc định";
            this.btnOrgan.UseVisualStyleBackColor = false;
            this.btnOrgan.Click += new System.EventHandler(this.btnOrgan_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Location = new System.Drawing.Point(107, 141);
            this.lbNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(414, 13);
            this.lbNotice.TabIndex = 25;
            this.lbNotice.Text = "THỐNG KÊ DOANH SỐ CỦA TOÀN HỆ THỐNG TRONG QUÁ TRÌNH HOẠT ĐỘNG";
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(897, 519);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.btnOrgan);
            this.Controls.Add(this.txtCtrl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCinema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.cboTimeStatistic);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fStatistic";
            this.Text = "Khuyến mãi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox cboTimeStatistic;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn real;
        private System.Windows.Forms.Label lbmovie;
        private System.Windows.Forms.Label lbTotalPro;
        private System.Windows.Forms.Label lbTotalReal;
        private System.Windows.Forms.Label lbCinema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCinema;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button txtCtrl;
        private System.Windows.Forms.Button btnOrgan;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Label label8;
    }
}