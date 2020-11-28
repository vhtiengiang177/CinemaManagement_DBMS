namespace CinemaManagement.GUI
{
    partial class fAddShowtimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddShowtimes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseDay = new System.Windows.Forms.Button();
            this.btnCheckDay = new System.Windows.Forms.Button();
            this.dtmChooseDay = new System.Windows.Forms.DateTimePicker();
            this.txtCountMovieInDay = new System.Windows.Forms.TextBox();
            this.txtShiftEmpty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckShift = new System.Windows.Forms.Button();
            this.btnChooseShift = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.txtCountShift = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCheckCategoryMovie = new System.Windows.Forms.Button();
            this.btnChooseMovie = new System.Windows.Forms.Button();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCountMovie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTypeMovie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChoosrRoom = new System.Windows.Forms.Button();
            this.txtCountRoom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.movieTableAdapter = new CinemaManagement.cinemaDBMSDataSet1TableAdapters.MovieTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChooseDay);
            this.panel1.Controls.Add(this.btnCheckDay);
            this.panel1.Controls.Add(this.dtmChooseDay);
            this.panel1.Controls.Add(this.txtCountMovieInDay);
            this.panel1.Controls.Add(this.txtShiftEmpty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(55, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 213);
            this.panel1.TabIndex = 0;
            // 
            // btnChooseDay
            // 
            this.btnChooseDay.Location = new System.Drawing.Point(204, 168);
            this.btnChooseDay.Name = "btnChooseDay";
            this.btnChooseDay.Size = new System.Drawing.Size(75, 28);
            this.btnChooseDay.TabIndex = 38;
            this.btnChooseDay.Text = "Chọn";
            this.btnChooseDay.UseVisualStyleBackColor = true;
            this.btnChooseDay.Click += new System.EventHandler(this.btnChooseDay_Click);
            // 
            // btnCheckDay
            // 
            this.btnCheckDay.Location = new System.Drawing.Point(41, 71);
            this.btnCheckDay.Name = "btnCheckDay";
            this.btnCheckDay.Size = new System.Drawing.Size(75, 23);
            this.btnCheckDay.TabIndex = 15;
            this.btnCheckDay.Text = "Check";
            this.btnCheckDay.UseVisualStyleBackColor = true;
            this.btnCheckDay.Click += new System.EventHandler(this.btnCheckDay_Click);
            // 
            // dtmChooseDay
            // 
            this.dtmChooseDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmChooseDay.Location = new System.Drawing.Point(40, 38);
            this.dtmChooseDay.Name = "dtmChooseDay";
            this.dtmChooseDay.Size = new System.Drawing.Size(200, 22);
            this.dtmChooseDay.TabIndex = 13;
            // 
            // txtCountMovieInDay
            // 
            this.txtCountMovieInDay.Location = new System.Drawing.Point(38, 126);
            this.txtCountMovieInDay.Name = "txtCountMovieInDay";
            this.txtCountMovieInDay.Size = new System.Drawing.Size(100, 22);
            this.txtCountMovieInDay.TabIndex = 8;
            // 
            // txtShiftEmpty
            // 
            this.txtShiftEmpty.Location = new System.Drawing.Point(36, 174);
            this.txtShiftEmpty.Name = "txtShiftEmpty";
            this.txtShiftEmpty.Size = new System.Drawing.Size(100, 22);
            this.txtShiftEmpty.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng phim đã xếp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chọn ngày xếp lịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng ca còn trống";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCheckShift);
            this.panel2.Controls.Add(this.btnChooseShift);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cboShift);
            this.panel2.Controls.Add(this.txtCountShift);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(379, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 214);
            this.panel2.TabIndex = 1;
            // 
            // btnCheckShift
            // 
            this.btnCheckShift.Location = new System.Drawing.Point(35, 72);
            this.btnCheckShift.Name = "btnCheckShift";
            this.btnCheckShift.Size = new System.Drawing.Size(75, 23);
            this.btnCheckShift.TabIndex = 38;
            this.btnCheckShift.Text = "Check";
            this.btnCheckShift.UseVisualStyleBackColor = true;
            this.btnCheckShift.Click += new System.EventHandler(this.btnCheckShift_Click);
            // 
            // btnChooseShift
            // 
            this.btnChooseShift.Location = new System.Drawing.Point(188, 169);
            this.btnChooseShift.Name = "btnChooseShift";
            this.btnChooseShift.Size = new System.Drawing.Size(75, 28);
            this.btnChooseShift.TabIndex = 37;
            this.btnChooseShift.Text = "Chọn";
            this.btnChooseShift.UseVisualStyleBackColor = true;
            this.btnChooseShift.Click += new System.EventHandler(this.btnChooseShift_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Chọn ca chiếu";
            // 
            // cboShift
            // 
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Items.AddRange(new object[] {
            "9am-11am",
            "11am-1pm",
            "1pm-3pm",
            "3pm-5pm"});
            this.cboShift.Location = new System.Drawing.Point(24, 37);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(121, 24);
            this.cboShift.TabIndex = 20;
            // 
            // txtCountShift
            // 
            this.txtCountShift.Location = new System.Drawing.Point(24, 127);
            this.txtCountShift.Name = "txtCountShift";
            this.txtCountShift.Size = new System.Drawing.Size(100, 22);
            this.txtCountShift.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số lượt chọn ca còn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCheckCategoryMovie);
            this.panel3.Controls.Add(this.btnChooseMovie);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtCountMovie);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboTypeMovie);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cboMovie);
            this.panel3.Location = new System.Drawing.Point(1039, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 214);
            this.panel3.TabIndex = 2;
            // 
            // btnCheckCategoryMovie
            // 
            this.btnCheckCategoryMovie.Location = new System.Drawing.Point(14, 61);
            this.btnCheckCategoryMovie.Name = "btnCheckCategoryMovie";
            this.btnCheckCategoryMovie.Size = new System.Drawing.Size(75, 23);
            this.btnCheckCategoryMovie.TabIndex = 39;
            this.btnCheckCategoryMovie.Text = "Check";
            this.btnCheckCategoryMovie.UseVisualStyleBackColor = true;
            this.btnCheckCategoryMovie.Click += new System.EventHandler(this.btnCheckCategoryMovie_Click);
            // 
            // btnChooseMovie
            // 
            this.btnChooseMovie.Location = new System.Drawing.Point(230, 168);
            this.btnChooseMovie.Name = "btnChooseMovie";
            this.btnChooseMovie.Size = new System.Drawing.Size(75, 28);
            this.btnChooseMovie.TabIndex = 38;
            this.btnChooseMovie.Text = "Chọn";
            this.btnChooseMovie.UseVisualStyleBackColor = true;
            this.btnChooseMovie.Click += new System.EventHandler(this.btnChooseMovie_Click);
            // 
            // iconClose
            // 
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(1191, 294);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(72, 50);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 4;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Số lượng phim";
            // 
            // txtCountMovie
            // 
            this.txtCountMovie.Location = new System.Drawing.Point(188, 112);
            this.txtCountMovie.Name = "txtCountMovie";
            this.txtCountMovie.Size = new System.Drawing.Size(100, 22);
            this.txtCountMovie.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chọn thể loại phim";
            // 
            // cboTypeMovie
            // 
            this.cboTypeMovie.FormattingEnabled = true;
            this.cboTypeMovie.Location = new System.Drawing.Point(14, 31);
            this.cboTypeMovie.Name = "cboTypeMovie";
            this.cboTypeMovie.Size = new System.Drawing.Size(121, 24);
            this.cboTypeMovie.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Chọn phim";
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Location = new System.Drawing.Point(14, 113);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(121, 24);
            this.cboMovie.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtRoom);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtMovie);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtShift);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtDay);
            this.panel4.Location = new System.Drawing.Point(414, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 193);
            this.panel4.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "Sửa lịch chiếu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 34);
            this.button5.TabIndex = 28;
            this.button5.Text = "Hủy lịch chiếu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(489, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Phòng chiếu";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(485, 66);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(118, 22);
            this.txtRoom.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Phim ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm lịch chiếu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(330, 66);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(120, 22);
            this.txtMovie.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ca chiếu";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(168, 66);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(123, 22);
            this.txtShift.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ngày chiếu";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(28, 66);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(112, 22);
            this.txtDay.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnChoosrRoom);
            this.panel5.Controls.Add(this.txtCountRoom);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.cboRoom);
            this.panel5.Location = new System.Drawing.Point(694, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 214);
            this.panel5.TabIndex = 4;
            // 
            // btnChoosrRoom
            // 
            this.btnChoosrRoom.Location = new System.Drawing.Point(196, 169);
            this.btnChoosrRoom.Name = "btnChoosrRoom";
            this.btnChoosrRoom.Size = new System.Drawing.Size(75, 28);
            this.btnChoosrRoom.TabIndex = 36;
            this.btnChoosrRoom.Text = "Chọn";
            this.btnChoosrRoom.UseVisualStyleBackColor = true;
            this.btnChoosrRoom.Click += new System.EventHandler(this.btnChoosrRoom_Click);
            // 
            // txtCountRoom
            // 
            this.txtCountRoom.Location = new System.Drawing.Point(23, 124);
            this.txtCountRoom.Name = "txtCountRoom";
            this.txtCountRoom.Size = new System.Drawing.Size(118, 22);
            this.txtCountRoom.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Số lượt chọn phòng còn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Chọn phòng chiếu";
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Items.AddRange(new object[] {
            "9am-11am",
            "11am-1pm",
            "1pm-3pm",
            "3pm-5pm"});
            this.cboRoom.Location = new System.Drawing.Point(22, 37);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(121, 24);
            this.cboRoom.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // fAddShowtimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 508);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddShowtimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddShowtimes";
            this.Load += new System.EventHandler(this.fAddShowtimes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtmChooseDay;
        private System.Windows.Forms.TextBox txtCountMovieInDay;
        private System.Windows.Forms.TextBox txtShiftEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboShift;
        private System.Windows.Forms.TextBox txtCountShift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTypeMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCountMovie;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.Button btnCheckDay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnChooseDay;
        private System.Windows.Forms.Button btnChooseShift;
        private System.Windows.Forms.Button btnChooseMovie;
        private System.Windows.Forms.Button btnChoosrRoom;
        private System.Windows.Forms.TextBox txtCountRoom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCheckShift;
        private System.Windows.Forms.Button btnCheckCategoryMovie;
        private System.Windows.Forms.Button button3;
        private cinemaDBMSDataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
    }
}