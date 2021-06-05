namespace CinemaManagement.GUI
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.txtCtrl = new System.Windows.Forms.Button();
            this.btnOrgan = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboChooseMovie = new System.Windows.Forms.ComboBox();
            this.cboChooseCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbTime = new System.Windows.Forms.RadioButton();
            this.rbMovie = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTotalReal = new System.Windows.Forms.Label();
            this.lbTotalPro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalAll = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcel.Location = new System.Drawing.Point(1039, 131);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 49);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Xuất file Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhim,
            this.SoLuong,
            this.Tong,
            this.TongGiam,
            this.TongThu});
            this.dgvStatistic.Location = new System.Drawing.Point(25, 212);
            this.dgvStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 24;
            this.dgvStatistic.Size = new System.Drawing.Size(1094, 378);
            this.dgvStatistic.TabIndex = 12;
            // 
            // txtCtrl
            // 
            this.txtCtrl.BackColor = System.Drawing.Color.White;
            this.txtCtrl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCtrl.Location = new System.Drawing.Point(941, 131);
            this.txtCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCtrl.Name = "txtCtrl";
            this.txtCtrl.Size = new System.Drawing.Size(92, 49);
            this.txtCtrl.TabIndex = 23;
            this.txtCtrl.Text = "Tùy chỉnh";
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
            this.btnOrgan.Location = new System.Drawing.Point(843, 131);
            this.btnOrgan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrgan.Name = "btnOrgan";
            this.btnOrgan.Size = new System.Drawing.Size(92, 49);
            this.btnOrgan.TabIndex = 24;
            this.btnOrgan.Text = "Mặc định";
            this.btnOrgan.UseVisualStyleBackColor = false;
            this.btnOrgan.Click += new System.EventHandler(this.btnOrgan_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(11, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(148, 22);
            this.dtpFrom.TabIndex = 26;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(196, 35);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(153, 22);
            this.dtpTo.TabIndex = 27;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Từ ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Đến ngày";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(716, 137);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(79, 36);
            this.btnFilter.TabIndex = 36;
            this.btnFilter.Text = "Xem";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Chọn phim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "Chọn thể loại";
            // 
            // cboChooseMovie
            // 
            this.cboChooseMovie.FormattingEnabled = true;
            this.cboChooseMovie.Items.AddRange(new object[] {
            "Tất cả"});
            this.cboChooseMovie.Location = new System.Drawing.Point(164, 33);
            this.cboChooseMovie.Name = "cboChooseMovie";
            this.cboChooseMovie.Size = new System.Drawing.Size(131, 24);
            this.cboChooseMovie.TabIndex = 46;
            // 
            // cboChooseCategory
            // 
            this.cboChooseCategory.FormattingEnabled = true;
            this.cboChooseCategory.Location = new System.Drawing.Point(18, 33);
            this.cboChooseCategory.Name = "cboChooseCategory";
            this.cboChooseCategory.Size = new System.Drawing.Size(126, 24);
            this.cboChooseCategory.TabIndex = 45;
            this.cboChooseCategory.SelectedIndexChanged += new System.EventHandler(this.cboChooseCategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(25, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 70);
            this.panel1.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboChooseMovie);
            this.panel3.Controls.Add(this.cboChooseCategory);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(391, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 70);
            this.panel3.TabIndex = 50;
            // 
            // rbTime
            // 
            this.rbTime.AutoSize = true;
            this.rbTime.Location = new System.Drawing.Point(45, 84);
            this.rbTime.Name = "rbTime";
            this.rbTime.Size = new System.Drawing.Size(120, 21);
            this.rbTime.TabIndex = 51;
            this.rbTime.TabStop = true;
            this.rbTime.Text = "Theo thời gian";
            this.rbTime.UseVisualStyleBackColor = true;
            this.rbTime.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // rbMovie
            // 
            this.rbMovie.AutoSize = true;
            this.rbMovie.Location = new System.Drawing.Point(201, 84);
            this.rbMovie.Name = "rbMovie";
            this.rbMovie.Size = new System.Drawing.Size(100, 21);
            this.rbMovie.TabIndex = 52;
            this.rbMovie.TabStop = true;
            this.rbMovie.Text = "Theo  phim";
            this.rbMovie.UseVisualStyleBackColor = true;
            this.rbMovie.CheckedChanged += new System.EventHandler(this.rbMovie_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(307, 84);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(69, 21);
            this.rbAll.TabIndex = 53;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Cả hai";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(312, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(490, 29);
            this.label13.TabIndex = 54;
            this.label13.Text = "THỐNG KÊ DOANH SỐ CỦA HỆ THỐNG";
            // 
            // lbTotalReal
            // 
            this.lbTotalReal.AutoSize = true;
            this.lbTotalReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalReal.Location = new System.Drawing.Point(935, 633);
            this.lbTotalReal.Name = "lbTotalReal";
            this.lbTotalReal.Size = new System.Drawing.Size(84, 25);
            this.lbTotalReal.TabIndex = 55;
            this.lbTotalReal.Text = "000000";
            // 
            // lbTotalPro
            // 
            this.lbTotalPro.AutoSize = true;
            this.lbTotalPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPro.Location = new System.Drawing.Point(738, 633);
            this.lbTotalPro.Name = "lbTotalPro";
            this.lbTotalPro.Size = new System.Drawing.Size(84, 25);
            this.lbTotalPro.TabIndex = 58;
            this.lbTotalPro.Text = "000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tổng";
            // 
            // lbTotalAll
            // 
            this.lbTotalAll.AutoSize = true;
            this.lbTotalAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAll.Location = new System.Drawing.Point(513, 633);
            this.lbTotalAll.Name = "lbTotalAll";
            this.lbTotalAll.Size = new System.Drawing.Size(84, 25);
            this.lbTotalAll.TabIndex = 60;
            this.lbTotalAll.Text = "000000";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(311, 633);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(84, 25);
            this.lbCount.TabIndex = 61;
            this.lbCount.Text = "000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(711, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(911, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "|";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(900, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "__________________________________________________________________________";
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số vé";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "Tong";
            this.Tong.HeaderText = "Tổng doanh số bán ra";
            this.Tong.MinimumWidth = 6;
            this.Tong.Name = "Tong";
            // 
            // TongGiam
            // 
            this.TongGiam.DataPropertyName = "TongGiam";
            this.TongGiam.HeaderText = "Tổng giảm";
            this.TongGiam.MinimumWidth = 6;
            this.TongGiam.Name = "TongGiam";
            // 
            // TongThu
            // 
            this.TongThu.DataPropertyName = "TongThu";
            this.TongThu.HeaderText = "Tổng thực thu";
            this.TongThu.MinimumWidth = 6;
            this.TongThu.Name = "TongThu";
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1196, 708);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbTotalAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotalPro);
            this.Controls.Add(this.lbTotalReal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbMovie);
            this.Controls.Add(this.rbTime);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnOrgan);
            this.Controls.Add(this.txtCtrl);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.btnExcel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fStatistic";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Button txtCtrl;
        private System.Windows.Forms.Button btnOrgan;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboChooseMovie;
        private System.Windows.Forms.ComboBox cboChooseCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbTime;
        private System.Windows.Forms.RadioButton rbMovie;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotalReal;
        private System.Windows.Forms.Label lbTotalPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalAll;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongThu;
    }
}