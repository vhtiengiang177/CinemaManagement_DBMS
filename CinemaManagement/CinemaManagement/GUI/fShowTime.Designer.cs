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
            this.iconClose = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboSearchST);
            this.panel1.Controls.Add(this.btnSearchShowtimes);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(130, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 71);
            this.panel1.TabIndex = 0;
            // 
            // cboSearchST
            // 
            this.cboSearchST.FormattingEnabled = true;
            this.cboSearchST.Items.AddRange(new object[] {
            "Tên Phim"});
            this.cboSearchST.Location = new System.Drawing.Point(386, 27);
            this.cboSearchST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSearchST.Name = "cboSearchST";
            this.cboSearchST.Size = new System.Drawing.Size(160, 24);
            this.cboSearchST.TabIndex = 6;
            // 
            // btnSearchShowtimes
            // 
            this.btnSearchShowtimes.Location = new System.Drawing.Point(12, 15);
            this.btnSearchShowtimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchShowtimes.Name = "btnSearchShowtimes";
            this.btnSearchShowtimes.Size = new System.Drawing.Size(86, 46);
            this.btnSearchShowtimes.TabIndex = 3;
            this.btnSearchShowtimes.Text = "Tìm";
            this.btnSearchShowtimes.UseVisualStyleBackColor = true;
            this.btnSearchShowtimes.Click += new System.EventHandler(this.btnSearchShowtimes_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(104, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvShowtimes);
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 487);
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
            this.dgvShowtimes.Location = new System.Drawing.Point(3, 4);
            this.dgvShowtimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowtimes.Name = "dgvShowtimes";
            this.dgvShowtimes.RowHeadersWidth = 51;
            this.dgvShowtimes.RowTemplate.Height = 24;
            this.dgvShowtimes.Size = new System.Drawing.Size(755, 481);
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
            this.panel3.Location = new System.Drawing.Point(790, 174);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 427);
            this.panel3.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.dtmDateShow);
            this.panel9.Location = new System.Drawing.Point(15, 130);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(359, 70);
            this.panel9.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày chiếu";
            // 
            // dtmDateShow
            // 
            this.dtmDateShow.Enabled = false;
            this.dtmDateShow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateShow.Location = new System.Drawing.Point(4, 40);
            this.dtmDateShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmDateShow.Name = "dtmDateShow";
            this.dtmDateShow.Size = new System.Drawing.Size(343, 22);
            this.dtmDateShow.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cboRoom);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(15, 206);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(359, 62);
            this.panel8.TabIndex = 19;
            // 
            // cboRoom
            // 
            this.cboRoom.Enabled = false;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(4, 37);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(340, 24);
            this.cboRoom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sắp xếp lịch chiếu";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.cboNameMovie);
            this.panel7.Location = new System.Drawing.Point(15, 285);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(363, 63);
            this.panel7.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên  Phim";
            // 
            // cboNameMovie
            // 
            this.cboNameMovie.DisplayMember = "id_movie";
            this.cboNameMovie.Enabled = false;
            this.cboNameMovie.FormattingEnabled = true;
            this.cboNameMovie.Location = new System.Drawing.Point(7, 28);
            this.cboNameMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNameMovie.Name = "cboNameMovie";
            this.cboNameMovie.Size = new System.Drawing.Size(340, 24);
            this.cboNameMovie.TabIndex = 14;
            this.cboNameMovie.ValueMember = "id_movie";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboShiftShow);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(15, 354);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(363, 69);
            this.panel6.TabIndex = 17;
            // 
            // cboShiftShow
            // 
            this.cboShiftShow.Enabled = false;
            this.cboShiftShow.FormattingEnabled = true;
            this.cboShiftShow.Location = new System.Drawing.Point(4, 33);
            this.cboShiftShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboShiftShow.Name = "cboShiftShow";
            this.cboShiftShow.Size = new System.Drawing.Size(340, 24);
            this.cboShiftShow.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ca chiếu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteSS);
            this.panel5.Controls.Add(this.btnAddShowtimes);
            this.panel5.Location = new System.Drawing.Point(15, 34);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 82);
            this.panel5.TabIndex = 1;
            // 
            // btnDeleteSS
            // 
            this.btnDeleteSS.Location = new System.Drawing.Point(110, 14);
            this.btnDeleteSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSS.Name = "btnDeleteSS";
            this.btnDeleteSS.Size = new System.Drawing.Size(75, 54);
            this.btnDeleteSS.TabIndex = 2;
            this.btnDeleteSS.Text = "Xóa";
            this.btnDeleteSS.UseVisualStyleBackColor = true;
            this.btnDeleteSS.Click += new System.EventHandler(this.btnDeleteSS_Click);
            // 
            // btnAddShowtimes
            // 
            this.btnAddShowtimes.Location = new System.Drawing.Point(17, 14);
            this.btnAddShowtimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddShowtimes.Name = "btnAddShowtimes";
            this.btnAddShowtimes.Size = new System.Drawing.Size(74, 54);
            this.btnAddShowtimes.TabIndex = 0;
            this.btnAddShowtimes.Text = "Thêm mới";
            this.btnAddShowtimes.UseVisualStyleBackColor = true;
            this.btnAddShowtimes.Click += new System.EventHandler(this.btnAddShowtimes_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(790, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 59);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản lí Lịch chiếu";
            // 
            // iconClose
            // 
            this.iconClose.Location = new System.Drawing.Point(28, 37);
            this.iconClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(83, 63);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 5;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // fShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnDeleteSS;
        private System.Windows.Forms.Button btnAddShowtimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNameMovie;
        private System.Windows.Forms.DateTimePicker dtmDateShow;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.PictureBox iconClose;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}