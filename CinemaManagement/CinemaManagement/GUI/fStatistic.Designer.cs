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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cboTopMovie = new System.Windows.Forms.ComboBox();
            this.dgvTopMovie = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalReal = new System.Windows.Forms.Label();
            this.lbTotalPro = new System.Windows.Forms.Label();
            this.lbmovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(30, 365);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sum";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(671, 262);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống kê doanh số ";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(561, 20);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(126, 32);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Xuất file Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cboTopMovie
            // 
            this.cboTopMovie.FormattingEnabled = true;
            this.cboTopMovie.Items.AddRange(new object[] {
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
            this.cboTopMovie.Location = new System.Drawing.Point(195, 25);
            this.cboTopMovie.Name = "cboTopMovie";
            this.cboTopMovie.Size = new System.Drawing.Size(121, 24);
            this.cboTopMovie.TabIndex = 11;
            this.cboTopMovie.SelectedIndexChanged += new System.EventHandler(this.cboTopMovie_SelectedIndexChanged);
            // 
            // dgvTopMovie
            // 
            this.dgvTopMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.num,
            this.total,
            this.promotion,
            this.real});
            this.dgvTopMovie.Location = new System.Drawing.Point(25, 76);
            this.dgvTopMovie.Name = "dgvTopMovie";
            this.dgvTopMovie.RowHeadersWidth = 51;
            this.dgvTopMovie.RowTemplate.Height = 24;
            this.dgvTopMovie.Size = new System.Drawing.Size(676, 260);
            this.dgvTopMovie.TabIndex = 12;
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
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(746, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 260);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng phim ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số chi nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng doanh số thực tế";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng giảm cho khuyến mãi";
            // 
            // btnResset
            // 
            this.btnResset.Location = new System.Drawing.Point(746, 20);
            this.btnResset.Name = "btnResset";
            this.btnResset.Size = new System.Drawing.Size(87, 32);
            this.btnResset.TabIndex = 14;
            this.btnResset.Text = "Reset data";
            this.btnResset.UseVisualStyleBackColor = true;
            this.btnResset.Click += new System.EventHandler(this.btnResset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "1";
            // 
            // lbTotalReal
            // 
            this.lbTotalReal.AutoSize = true;
            this.lbTotalReal.Location = new System.Drawing.Point(231, 87);
            this.lbTotalReal.Name = "lbTotalReal";
            this.lbTotalReal.Size = new System.Drawing.Size(16, 17);
            this.lbTotalReal.TabIndex = 19;
            this.lbTotalReal.Text = "0";
            // 
            // lbTotalPro
            // 
            this.lbTotalPro.AutoSize = true;
            this.lbTotalPro.Location = new System.Drawing.Point(231, 125);
            this.lbTotalPro.Name = "lbTotalPro";
            this.lbTotalPro.Size = new System.Drawing.Size(16, 17);
            this.lbTotalPro.TabIndex = 20;
            this.lbTotalPro.Text = "0";
            // 
            // lbmovie
            // 
            this.lbmovie.AutoSize = true;
            this.lbmovie.Location = new System.Drawing.Point(231, 53);
            this.lbmovie.Name = "lbmovie";
            this.lbmovie.Size = new System.Drawing.Size(16, 17);
            this.lbmovie.TabIndex = 21;
            this.lbmovie.Text = "0";
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 639);
            this.Controls.Add(this.btnResset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTopMovie);
            this.Controls.Add(this.cboTopMovie);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Name = "fStatistic";
            this.Text = "fStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox cboTopMovie;
        private System.Windows.Forms.DataGridView dgvTopMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn real;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbmovie;
        private System.Windows.Forms.Label lbTotalPro;
        private System.Windows.Forms.Label lbTotalReal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResset;
    }
}