namespace CinemaManagement.GUI
{
    partial class fShowTime
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowTime));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picReloadShowtimes = new System.Windows.Forms.PictureBox();
            this.cboSearchST = new System.Windows.Forms.ComboBox();
            this.btnSearchShowtimes = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvShowtimes = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtmDateShow = new System.Windows.Forms.DateTimePicker();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboNameMovie = new System.Windows.Forms.ComboBox();
            this.cboShiftShow = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditShowtimes = new System.Windows.Forms.Button();
            this.btnAddShowtimes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.cinemaDBMSDataSet1 = new CinemaManagement.cinemaDBMSDataSet1();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDBMSDataSet = new CinemaManagement.cinemaDBMSDataSet();
            this.cinemaDBMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadShowtimes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picReloadShowtimes);
            this.panel1.Controls.Add(this.cboSearchST);
            this.panel1.Controls.Add(this.btnSearchShowtimes);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(15, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 66);
            this.panel1.TabIndex = 0;
            // 
            // picReloadShowtimes
            // 
            this.picReloadShowtimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReloadShowtimes.Image = ((System.Drawing.Image)(resources.GetObject("picReloadShowtimes.Image")));
            this.picReloadShowtimes.Location = new System.Drawing.Point(655, 33);
            this.picReloadShowtimes.Name = "picReloadShowtimes";
            this.picReloadShowtimes.Size = new System.Drawing.Size(37, 30);
            this.picReloadShowtimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReloadShowtimes.TabIndex = 44;
            this.picReloadShowtimes.TabStop = false;
            this.picReloadShowtimes.Click += new System.EventHandler(this.picReloadShowtimes_Click);
            // 
            // cboSearchST
            // 
            this.cboSearchST.FormattingEnabled = true;
            this.cboSearchST.Items.AddRange(new object[] {
            "Tên Phim"});
            this.cboSearchST.Location = new System.Drawing.Point(489, 33);
            this.cboSearchST.Name = "cboSearchST";
            this.cboSearchST.Size = new System.Drawing.Size(160, 24);
            this.cboSearchST.TabIndex = 6;
            // 
            // btnSearchShowtimes
            // 
            this.btnSearchShowtimes.Location = new System.Drawing.Point(15, 34);
            this.btnSearchShowtimes.Name = "btnSearchShowtimes";
            this.btnSearchShowtimes.Size = new System.Drawing.Size(101, 23);
            this.btnSearchShowtimes.TabIndex = 3;
            this.btnSearchShowtimes.Text = "Tìm";
            this.btnSearchShowtimes.UseVisualStyleBackColor = true;
            this.btnSearchShowtimes.Click += new System.EventHandler(this.btnSearchShowtimes_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(122, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(361, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvShowtimes);
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 488);
            this.panel2.TabIndex = 1;
            // 
            // dgvShowtimes
            // 
            this.dgvShowtimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowtimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.room,
            this.namemovie,
            this.idTime});
            this.dgvShowtimes.Location = new System.Drawing.Point(3, 4);
            this.dgvShowtimes.Name = "dgvShowtimes";
            this.dgvShowtimes.RowHeadersWidth = 51;
            this.dgvShowtimes.RowTemplate.Height = 24;
            this.dgvShowtimes.Size = new System.Drawing.Size(755, 481);
            this.dgvShowtimes.TabIndex = 0;
            this.dgvShowtimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtimes_CellClick);
            this.dgvShowtimes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtimes_CellContentClick);
            // 
            // date
            // 
            this.date.DataPropertyName = "NgayChieu";
            this.date.HeaderText = "Ngày chiếu";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // room
            // 
            this.room.DataPropertyName = "PhongChieu";
            this.room.HeaderText = "Phòng chiếu";
            this.room.MinimumWidth = 6;
            this.room.Name = "room";
            // 
            // namemovie
            // 
            this.namemovie.DataPropertyName = "TenPhim";
            this.namemovie.HeaderText = "Tên Phim";
            this.namemovie.MinimumWidth = 6;
            this.namemovie.Name = "namemovie";
            // 
            // idTime
            // 
            this.idTime.DataPropertyName = "CaChieu";
            this.idTime.HeaderText = "Ca chiếu";
            this.idTime.MinimumWidth = 6;
            this.idTime.Name = "idTime";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtmDateShow);
            this.panel3.Controls.Add(this.cboRoom);
            this.panel3.Controls.Add(this.cboNameMovie);
            this.panel3.Controls.Add(this.cboShiftShow);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(788, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 488);
            this.panel3.TabIndex = 2;
            // 
            // dtmDateShow
            // 
            this.dtmDateShow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateShow.Location = new System.Drawing.Point(18, 146);
            this.dtmDateShow.Name = "dtmDateShow";
            this.dtmDateShow.Size = new System.Drawing.Size(343, 22);
            this.dtmDateShow.TabIndex = 16;
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(18, 211);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(340, 24);
            this.cboRoom.TabIndex = 15;
            // 
            // cboNameMovie
            // 
            this.cboNameMovie.DataSource = this.movieBindingSource;
            this.cboNameMovie.DisplayMember = "name_movie";
            this.cboNameMovie.FormattingEnabled = true;
            this.cboNameMovie.Location = new System.Drawing.Point(15, 268);
            this.cboNameMovie.Name = "cboNameMovie";
            this.cboNameMovie.Size = new System.Drawing.Size(340, 24);
            this.cboNameMovie.TabIndex = 14;
            this.cboNameMovie.ValueMember = "id_movie";
            // 
            // cboShiftShow
            // 
            this.cboShiftShow.FormattingEnabled = true;
            this.cboShiftShow.Location = new System.Drawing.Point(15, 341);
            this.cboShiftShow.Name = "cboShiftShow";
            this.cboShiftShow.Size = new System.Drawing.Size(340, 24);
            this.cboShiftShow.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ca chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên  Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày chiếu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnEditShowtimes);
            this.panel5.Controls.Add(this.btnAddShowtimes);
            this.panel5.Location = new System.Drawing.Point(15, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 51);
            this.panel5.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEditShowtimes
            // 
            this.btnEditShowtimes.Location = new System.Drawing.Point(133, 14);
            this.btnEditShowtimes.Name = "btnEditShowtimes";
            this.btnEditShowtimes.Size = new System.Drawing.Size(75, 23);
            this.btnEditShowtimes.TabIndex = 1;
            this.btnEditShowtimes.Text = "Sửa";
            this.btnEditShowtimes.UseVisualStyleBackColor = true;
            this.btnEditShowtimes.Click += new System.EventHandler(this.btnEditShowtimes_Click);
            // 
            // btnAddShowtimes
            // 
            this.btnAddShowtimes.Location = new System.Drawing.Point(3, 14);
            this.btnAddShowtimes.Name = "btnAddShowtimes";
            this.btnAddShowtimes.Size = new System.Drawing.Size(101, 23);
            this.btnAddShowtimes.TabIndex = 0;
            this.btnAddShowtimes.Text = "Thêm mới";
            this.btnAddShowtimes.UseVisualStyleBackColor = true;
            this.btnAddShowtimes.Click += new System.EventHandler(this.btnAddShowtimes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sắp xếp lịch chiếu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(781, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 66);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản lí Lịch chiếu";
            // 
            // iconClose
            // 
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(1042, 30);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(82, 63);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 5;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // cinemaDBMSDataSet1
            // 
            this.cinemaDBMSDataSet1.DataSetName = "cinemaDBMSDataSet1";
            this.cinemaDBMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.cinemaDBMSDataSet1;
            // 
            // cinemaDBMSDataSet
            // 
            this.cinemaDBMSDataSet.DataSetName = "cinemaDBMSDataSet";
            this.cinemaDBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemaDBMSDataSetBindingSource
            // 
            this.cinemaDBMSDataSetBindingSource.DataSource = this.cinemaDBMSDataSet;
            this.cinemaDBMSDataSetBindingSource.Position = 0;
            // 
            // fShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 631);
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fShowTime";
            this.Text = "fShowTime";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadShowtimes)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboSearchST;
        private System.Windows.Forms.Button btnSearchShowtimes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvShowtimes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboShiftShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditShowtimes;
        private System.Windows.Forms.Button btnAddShowtimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNameMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTime;
        private System.Windows.Forms.DateTimePicker dtmDateShow;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.PictureBox picReloadShowtimes;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private cinemaDBMSDataSet1 cinemaDBMSDataSet1;
        private cinemaDBMSDataSet cinemaDBMSDataSet;
        private System.Windows.Forms.BindingSource cinemaDBMSDataSetBindingSource;
    }
}