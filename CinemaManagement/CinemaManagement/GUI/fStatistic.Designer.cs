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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbmovie = new System.Windows.Forms.Label();
            this.lbTotalPro = new System.Windows.Forms.Label();
            this.lbTotalReal = new System.Windows.Forms.Label();
            this.lbCinema = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCinema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTimeStatistic = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(24, 372);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sum";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(507, 205);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
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
            this.dgvStatistic.Location = new System.Drawing.Point(24, 159);
            this.dgvStatistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 24;
            this.dgvStatistic.Size = new System.Drawing.Size(507, 194);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lbmovie);
            this.panel1.Controls.Add(this.lbTotalPro);
            this.panel1.Controls.Add(this.lbTotalReal);
            this.panel1.Controls.Add(this.lbCinema);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(563, 202);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 138);
            this.panel1.TabIndex = 13;
            // 
            // lbmovie
            // 
            this.lbmovie.AutoSize = true;
            this.lbmovie.Location = new System.Drawing.Point(175, 43);
            this.lbmovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmovie.Name = "lbmovie";
            this.lbmovie.Size = new System.Drawing.Size(14, 15);
            this.lbmovie.TabIndex = 21;
            this.lbmovie.Text = "0";
            // 
            // lbTotalPro
            // 
            this.lbTotalPro.AutoSize = true;
            this.lbTotalPro.Location = new System.Drawing.Point(176, 102);
            this.lbTotalPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPro.Name = "lbTotalPro";
            this.lbTotalPro.Size = new System.Drawing.Size(14, 15);
            this.lbTotalPro.TabIndex = 20;
            this.lbTotalPro.Text = "0";
            // 
            // lbTotalReal
            // 
            this.lbTotalReal.AutoSize = true;
            this.lbTotalReal.Location = new System.Drawing.Point(176, 71);
            this.lbTotalReal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalReal.Name = "lbTotalReal";
            this.lbTotalReal.Size = new System.Drawing.Size(14, 15);
            this.lbTotalReal.TabIndex = 19;
            this.lbTotalReal.Text = "0";
            // 
            // lbCinema
            // 
            this.lbCinema.AutoSize = true;
            this.lbCinema.Location = new System.Drawing.Point(174, 20);
            this.lbCinema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCinema.Name = "lbCinema";
            this.lbCinema.Size = new System.Drawing.Size(14, 15);
            this.lbCinema.TabIndex = 17;
            this.lbCinema.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng giảm cho khuyến mãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng doanh số thực tế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng phim ";
            // 
            // btnResset
            // 
            this.btnResset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResset.Location = new System.Drawing.Point(565, 167);
            this.btnResset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResset.Name = "btnResset";
            this.btnResset.Size = new System.Drawing.Size(65, 26);
            this.btnResset.TabIndex = 14;
            this.btnResset.Text = "Reset data";
            this.btnResset.UseVisualStyleBackColor = true;
            this.btnResset.Click += new System.EventHandler(this.btnResset_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboCinema);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboTimeStatistic);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(21, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 54);
            this.panel2.TabIndex = 15;
            // 
            // cboCinema
            // 
            this.cboCinema.FormattingEnabled = true;
            this.cboCinema.Location = new System.Drawing.Point(291, 13);
            this.cboCinema.Margin = new System.Windows.Forms.Padding(2);
            this.cboCinema.Name = "cboCinema";
            this.cboCinema.Size = new System.Drawing.Size(99, 23);
            this.cboCinema.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chọn rạp";
            // 
            // cboTimeStatistic
            // 
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
            this.cboTimeStatistic.Location = new System.Drawing.Point(128, 13);
            this.cboTimeStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.cboTimeStatistic.Name = "cboTimeStatistic";
            this.cboTimeStatistic.Size = new System.Drawing.Size(92, 23);
            this.cboTimeStatistic.TabIndex = 19;
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcel.Location = new System.Drawing.Point(399, 11);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(94, 26);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Xuất file Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thống kê doanh số ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(337, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "CINEMA BYTG";
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(905, 644);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnResset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fStatistic";
            this.Text = "fStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn real;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbmovie;
        private System.Windows.Forms.Label lbTotalPro;
        private System.Windows.Forms.Label lbTotalReal;
        private System.Windows.Forms.Label lbCinema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTimeStatistic;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}