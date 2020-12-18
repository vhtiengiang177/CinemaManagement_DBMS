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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowTime));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSearchST = new System.Windows.Forms.ComboBox();
            this.btnSearchShowtimes = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvShowtimes = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmDateShow = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNameMovie = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboShiftShow = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteSS = new System.Windows.Forms.Button();
            this.btnAddShowtimes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            //this.iconClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboSearchST);
            this.panel1.Controls.Add(this.btnSearchShowtimes);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(98, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 58);
            this.panel1.TabIndex = 0;
            // 
            // cboSearchST
            // 
            this.cboSearchST.FormattingEnabled = true;
            this.cboSearchST.Items.AddRange(new object[] {
            "Tên Phim"});
            this.cboSearchST.Location = new System.Drawing.Point(290, 23);
            this.cboSearchST.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSearchST.Name = "cboSearchST";
            this.cboSearchST.Size = new System.Drawing.Size(121, 21);
            this.cboSearchST.TabIndex = 6;
            // 
            // btnSearchShowtimes
            // 
            this.btnSearchShowtimes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchShowtimes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearchShowtimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchShowtimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchShowtimes.Location = new System.Drawing.Point(9, 12);
            this.btnSearchShowtimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchShowtimes.Name = "btnSearchShowtimes";
            this.btnSearchShowtimes.Size = new System.Drawing.Size(64, 37);
            this.btnSearchShowtimes.TabIndex = 3;
            this.btnSearchShowtimes.Text = "Tìm";
            this.btnSearchShowtimes.UseVisualStyleBackColor = true;
            this.btnSearchShowtimes.Click += new System.EventHandler(this.btnSearchShowtimes_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvShowtimes);
            this.panel2.Location = new System.Drawing.Point(9, 156);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 396);
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
            this.idTime,
            this.IdShift,
            this.IdMovie,
            this.IdRoom});
            this.dgvShowtimes.Location = new System.Drawing.Point(2, 3);
            this.dgvShowtimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvShowtimes.Name = "dgvShowtimes";
            this.dgvShowtimes.RowHeadersWidth = 51;
            this.dgvShowtimes.RowTemplate.Height = 24;
            this.dgvShowtimes.Size = new System.Drawing.Size(566, 391);
            this.dgvShowtimes.TabIndex = 0;
            this.dgvShowtimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtimes_CellClick);
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
            // IdShift
            // 
            this.IdShift.DataPropertyName = "IdShift";
            this.IdShift.HeaderText = "Mã ca";
            this.IdShift.MinimumWidth = 6;
            this.IdShift.Name = "IdShift";
            this.IdShift.Visible = false;
            // 
            // IdMovie
            // 
            this.IdMovie.DataPropertyName = "IdMovie";
            this.IdMovie.HeaderText = "Mã phim";
            this.IdMovie.MinimumWidth = 6;
            this.IdMovie.Name = "IdMovie";
            this.IdMovie.Visible = false;
            // 
            // IdRoom
            // 
            this.IdRoom.DataPropertyName = "IdRoom";
            this.IdRoom.HeaderText = "Mã phòng";
            this.IdRoom.MinimumWidth = 6;
            this.IdRoom.Name = "IdRoom";
            this.IdRoom.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(596, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 347);
            this.panel3.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.dtmDateShow);
            this.panel9.Location = new System.Drawing.Point(11, 106);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 57);
            this.panel9.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày chiếu";
            // 
            // dtmDateShow
            // 
            this.dtmDateShow.Enabled = false;
            this.dtmDateShow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateShow.Location = new System.Drawing.Point(3, 32);
            this.dtmDateShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmDateShow.Name = "dtmDateShow";
            this.dtmDateShow.Size = new System.Drawing.Size(258, 21);
            this.dtmDateShow.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cboRoom);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(11, 167);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(269, 61);
            this.panel8.TabIndex = 19;
            // 
            // cboRoom
            // 
            this.cboRoom.Enabled = false;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(3, 30);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(256, 23);
            this.cboRoom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sắp xếp lịch chiếu";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.cboNameMovie);
            this.panel7.Location = new System.Drawing.Point(11, 232);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(272, 51);
            this.panel7.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên  Phim";
            // 
            // cboNameMovie
            // 
            this.cboNameMovie.DisplayMember = "id_movie";
            this.cboNameMovie.Enabled = false;
            this.cboNameMovie.FormattingEnabled = true;
            this.cboNameMovie.Location = new System.Drawing.Point(5, 23);
            this.cboNameMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNameMovie.Name = "cboNameMovie";
            this.cboNameMovie.Size = new System.Drawing.Size(256, 23);
            this.cboNameMovie.TabIndex = 14;
            this.cboNameMovie.ValueMember = "id_movie";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboShiftShow);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(11, 288);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 56);
            this.panel6.TabIndex = 17;
            // 
            // cboShiftShow
            // 
            this.cboShiftShow.Enabled = false;
            this.cboShiftShow.FormattingEnabled = true;
            this.cboShiftShow.Location = new System.Drawing.Point(3, 27);
            this.cboShiftShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboShiftShow.Name = "cboShiftShow";
            this.cboShiftShow.Size = new System.Drawing.Size(256, 23);
            this.cboShiftShow.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ca chiếu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteSS);
            this.panel5.Controls.Add(this.btnAddShowtimes);
            this.panel5.Location = new System.Drawing.Point(11, 28);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 67);
            this.panel5.TabIndex = 1;
            // 
            // btnDeleteSS
            // 
            this.btnDeleteSS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteSS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteSS.Location = new System.Drawing.Point(82, 11);
            this.btnDeleteSS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteSS.Name = "btnDeleteSS";
            this.btnDeleteSS.Size = new System.Drawing.Size(56, 44);
            this.btnDeleteSS.TabIndex = 2;
            this.btnDeleteSS.Text = "Xóa";
            this.btnDeleteSS.UseVisualStyleBackColor = true;
            this.btnDeleteSS.Click += new System.EventHandler(this.btnDeleteSS_Click);
            // 
            // btnAddShowtimes
            // 
            this.btnAddShowtimes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddShowtimes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddShowtimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShowtimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddShowtimes.Location = new System.Drawing.Point(13, 11);
            this.btnAddShowtimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddShowtimes.Name = "btnAddShowtimes";
            this.btnAddShowtimes.Size = new System.Drawing.Size(56, 44);
            this.btnAddShowtimes.TabIndex = 0;
            this.btnAddShowtimes.Text = "Thêm mới";
            this.btnAddShowtimes.UseVisualStyleBackColor = true;
            this.btnAddShowtimes.Click += new System.EventHandler(this.btnAddShowtimes_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(596, 112);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 35);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản lí Lịch chiếu";
            // 
            // iconClose
            // 
            //this.iconClose.Location = new System.Drawing.Point(28, 37);
            //this.iconClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.iconClose.Name = "iconClose";
            //this.iconClose.Size = new System.Drawing.Size(83, 63);
            //this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.iconClose.TabIndex = 5;
            //this.iconClose.TabStop = false;
            //this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(341, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "CINEMA BYTG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // fShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(938, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fShowTime";
            this.Text = "fShowTime";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnDeleteSS;
        private System.Windows.Forms.Button btnAddShowtimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNameMovie;
        private System.Windows.Forms.DateTimePicker dtmDateShow;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRoom;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}