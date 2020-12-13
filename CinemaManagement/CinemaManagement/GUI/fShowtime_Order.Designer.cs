namespace CinemaManagement.GUI
{
    partial class fShowtime_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowtime_Order));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picImageMovie = new System.Windows.Forms.PictureBox();
            this.lblShowNameRoom = new System.Windows.Forms.Label();
            this.lblShowNameMovie = new System.Windows.Forms.Label();
            this.lblShowStarttime = new System.Windows.Forms.Label();
            this.lblShowDate_Showtime = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblShiftShow = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.plCinema1 = new System.Windows.Forms.Panel();
            this.flpShiftTime = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fplShiftShow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExitShowTimeOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            this.panel4.SuspendLayout();
            this.plCinema1.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 412);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.picImageMovie);
            this.panel2.Controls.Add(this.lblShowNameRoom);
            this.panel2.Controls.Add(this.lblShowNameMovie);
            this.panel2.Controls.Add(this.lblShowStarttime);
            this.panel2.Controls.Add(this.lblShowDate_Showtime);
            this.panel2.Controls.Add(this.lblRoom);
            this.panel2.Controls.Add(this.lblShiftShow);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 402);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.plCinema1);
            this.panel3.Controls.Add(this.fplShiftShow);
            this.panel3.Location = new System.Drawing.Point(218, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 402);
            this.panel3.TabIndex = 1;
=======
            // splBody
            // 
            this.splBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splBody.Location = new System.Drawing.Point(0, 0);
            this.splBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splBody.Name = "splBody";
            // 
            // splBody.Panel1
            // 
            this.splBody.Panel1.Controls.Add(this.picImageMovie);
            this.splBody.Panel1.Controls.Add(this.pnlBodyLeft);
            // 
            // splBody.Panel2
            // 
            this.splBody.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splBody.Panel2.Controls.Add(this.btnNext);
            this.splBody.Panel2.Controls.Add(this.btnBack);
            this.splBody.Panel2.Controls.Add(this.panel1);
            this.splBody.Panel2.Controls.Add(this.plCinema1);
            this.splBody.Panel2.Controls.Add(this.fplShiftShow);
            this.splBody.Size = new System.Drawing.Size(1040, 555);
            this.splBody.SplitterDistance = 292;
            this.splBody.SplitterWidth = 5;
            this.splBody.TabIndex = 1;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Maroon;
            this.picImageMovie.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.ErrorImage")));
            this.picImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("picImageMovie.Image")));
            this.picImageMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.InitialImage")));
<<<<<<< HEAD
            this.picImageMovie.Location = new System.Drawing.Point(45, 21);
            this.picImageMovie.Margin = new System.Windows.Forms.Padding(2);
=======
            this.picImageMovie.Location = new System.Drawing.Point(40, 10);
            this.picImageMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(133, 167);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 29;
            this.picImageMovie.TabStop = false;
<<<<<<< HEAD
            this.picImageMovie.Click += new System.EventHandler(this.picImageMovie_Click);
=======
            // 
            // pnlBodyLeft
            // 
            this.pnlBodyLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.pnlBodyLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodyLeft.Controls.Add(this.lblShowNameRoom);
            this.pnlBodyLeft.Controls.Add(this.lblShowNameMovie);
            this.pnlBodyLeft.Controls.Add(this.lblShowStarttime);
            this.pnlBodyLeft.Controls.Add(this.lblShowDate_Showtime);
            this.pnlBodyLeft.Controls.Add(this.lblRoom);
            this.pnlBodyLeft.Controls.Add(this.lblShiftShow);
            this.pnlBodyLeft.Controls.Add(this.lblDate);
            this.pnlBodyLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBodyLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBodyLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBodyLeft.Name = "pnlBodyLeft";
            this.pnlBodyLeft.Size = new System.Drawing.Size(292, 555);
            this.pnlBodyLeft.TabIndex = 23;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            // 
            // lblShowNameRoom
            // 
            this.lblShowNameRoom.AutoSize = true;
            this.lblShowNameRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.lblShowNameRoom.Location = new System.Drawing.Point(118, 291);
            this.lblShowNameRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowNameRoom.Name = "lblShowNameRoom";
            this.lblShowNameRoom.Size = new System.Drawing.Size(93, 18);
            this.lblShowNameRoom.TabIndex = 28;
=======
            this.lblShowNameRoom.Location = new System.Drawing.Point(157, 336);
            this.lblShowNameRoom.Name = "lblShowNameRoom";
            this.lblShowNameRoom.Size = new System.Drawing.Size(115, 23);
            this.lblShowNameRoom.TabIndex = 5;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.lblShowNameRoom.Text = "phòng-chiếu";
            // 
            // lblShowNameMovie
            // 
            this.lblShowNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblShowNameMovie.Location = new System.Drawing.Point(8, 176);
            this.lblShowNameMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(146, 32);
            this.lblShowNameMovie.TabIndex = 30;
=======
            this.lblShowNameMovie.Location = new System.Drawing.Point(11, 194);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(195, 39);
            this.lblShowNameMovie.TabIndex = 22;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.lblShowNameMovie.Text = "Tên-phim";
            this.lblShowNameMovie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblShowStarttime
            // 
            this.lblShowStarttime.AutoSize = true;
            this.lblShowStarttime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowStarttime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.lblShowStarttime.Location = new System.Drawing.Point(89, 254);
            this.lblShowStarttime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowStarttime.Name = "lblShowStarttime";
            this.lblShowStarttime.Size = new System.Drawing.Size(74, 18);
            this.lblShowStarttime.TabIndex = 27;
=======
            this.lblShowStarttime.Location = new System.Drawing.Point(119, 290);
            this.lblShowStarttime.Name = "lblShowStarttime";
            this.lblShowStarttime.Size = new System.Drawing.Size(90, 23);
            this.lblShowStarttime.TabIndex = 4;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.lblShowStarttime.Text = "giờ-chiếu";
            // 
            // lblShowDate_Showtime
            // 
            this.lblShowDate_Showtime.AutoSize = true;
            this.lblShowDate_Showtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDate_Showtime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.lblShowDate_Showtime.Location = new System.Drawing.Point(62, 217);
            this.lblShowDate_Showtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowDate_Showtime.Name = "lblShowDate_Showtime";
            this.lblShowDate_Showtime.Size = new System.Drawing.Size(83, 18);
            this.lblShowDate_Showtime.TabIndex = 26;
=======
            this.lblShowDate_Showtime.Location = new System.Drawing.Point(83, 245);
            this.lblShowDate_Showtime.Name = "lblShowDate_Showtime";
            this.lblShowDate_Showtime.Size = new System.Drawing.Size(104, 23);
            this.lblShowDate_Showtime.TabIndex = 3;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.lblShowDate_Showtime.Text = "ngày-chiếu";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.lblRoom.Location = new System.Drawing.Point(9, 291);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(112, 19);
            this.lblRoom.TabIndex = 25;
=======
            this.lblRoom.Location = new System.Drawing.Point(12, 336);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(135, 24);
            this.lblRoom.TabIndex = 2;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.lblRoom.Text = "Phòng chiếu:";
            // 
            // lblShiftShow
            // 
            this.lblShiftShow.AutoSize = true;
            this.lblShiftShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.lblShiftShow.Location = new System.Drawing.Point(9, 254);
            this.lblShiftShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiftShow.Name = "lblShiftShow";
            this.lblShiftShow.Size = new System.Drawing.Size(82, 19);
            this.lblShiftShow.TabIndex = 24;
=======
            this.lblShiftShow.Location = new System.Drawing.Point(12, 290);
            this.lblShiftShow.Name = "lblShiftShow";
            this.lblShiftShow.Size = new System.Drawing.Size(99, 24);
            this.lblShiftShow.TabIndex = 1;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.lblShiftShow.Text = "Ca chiếu:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.lblDate.Location = new System.Drawing.Point(9, 217);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 19);
            this.lblDate.TabIndex = 23;
=======
            this.lblDate.Location = new System.Drawing.Point(12, 245);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 24);
            this.lblDate.TabIndex = 0;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.lblDate.Text = "Ngày:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Maroon;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.btnNext.Location = new System.Drawing.Point(458, 337);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 36);
            this.btnNext.TabIndex = 3;
=======
            this.btnNext.Location = new System.Drawing.Point(611, 455);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 44);
            this.btnNext.TabIndex = 0;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.btnNext.Text = "Tiếp";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.btnBack.Location = new System.Drawing.Point(380, 337);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 36);
            this.btnBack.TabIndex = 5;
=======
            this.btnBack.Location = new System.Drawing.Point(507, 455);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 44);
            this.btnBack.TabIndex = 1;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
<<<<<<< HEAD
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(6, 29);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(544, 33);
            this.panel4.TabIndex = 7;
=======
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 41);
            this.panel1.TabIndex = 2;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày chiếu";
            // 
            // plCinema1
            // 
            this.plCinema1.Controls.Add(this.flpShiftTime);
            this.plCinema1.Controls.Add(this.label1);
<<<<<<< HEAD
            this.plCinema1.Location = new System.Drawing.Point(6, 161);
            this.plCinema1.Margin = new System.Windows.Forms.Padding(2);
            this.plCinema1.Name = "plCinema1";
            this.plCinema1.Size = new System.Drawing.Size(544, 113);
            this.plCinema1.TabIndex = 6;
=======
            this.plCinema1.Location = new System.Drawing.Point(8, 234);
            this.plCinema1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plCinema1.Name = "plCinema1";
            this.plCinema1.Size = new System.Drawing.Size(725, 139);
            this.plCinema1.TabIndex = 1;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            // 
            // flpShiftTime
            // 
            this.flpShiftTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
<<<<<<< HEAD
            this.flpShiftTime.Location = new System.Drawing.Point(2, 30);
            this.flpShiftTime.Margin = new System.Windows.Forms.Padding(2);
=======
            this.flpShiftTime.Location = new System.Drawing.Point(3, 37);
            this.flpShiftTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.flpShiftTime.Name = "flpShiftTime";
            this.flpShiftTime.Size = new System.Drawing.Size(719, 87);
            this.flpShiftTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CGV Thủ Đức";
            // 
            // fplShiftShow
            // 
            this.fplShiftShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
<<<<<<< HEAD
            this.fplShiftShow.Location = new System.Drawing.Point(6, 66);
            this.fplShiftShow.Margin = new System.Windows.Forms.Padding(2);
            this.fplShiftShow.Name = "fplShiftShow";
            this.fplShiftShow.Size = new System.Drawing.Size(542, 79);
            this.fplShiftShow.TabIndex = 4;
            // 
            // btnExitShowTimeOrder
            // 
            this.btnExitShowTimeOrder.BackColor = System.Drawing.Color.Maroon;
            this.btnExitShowTimeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitShowTimeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitShowTimeOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitShowTimeOrder.Location = new System.Drawing.Point(736, 5);
            this.btnExitShowTimeOrder.Name = "btnExitShowTimeOrder";
            this.btnExitShowTimeOrder.Size = new System.Drawing.Size(30, 28);
            this.btnExitShowTimeOrder.TabIndex = 1;
            this.btnExitShowTimeOrder.Text = "X";
            this.btnExitShowTimeOrder.UseVisualStyleBackColor = false;
            this.btnExitShowTimeOrder.Click += new System.EventHandler(this.btnExitShowTimeOrder_Click);
=======
            this.fplShiftShow.Location = new System.Drawing.Point(8, 122);
            this.fplShiftShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fplShiftShow.Name = "fplShiftShow";
            this.fplShiftShow.Size = new System.Drawing.Size(722, 83);
            this.fplShiftShow.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splBody);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Size = new System.Drawing.Size(1040, 615);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 2;
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            // 
            // fShowtime_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(780, 458);
            this.Controls.Add(this.btnExitShowTimeOrder);
            this.Controls.Add(this.panel1);
=======
            this.ClientSize = new System.Drawing.Size(1040, 615);
            this.Controls.Add(this.splitContainer1);
>>>>>>> b4183d7e756664a910294d6c40288372efefe17b
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fShowtime_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fShowtime_Order";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.plCinema1.ResumeLayout(false);
            this.plCinema1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImageMovie;
        private System.Windows.Forms.Label lblShowNameRoom;
        private System.Windows.Forms.Label lblShowNameMovie;
        private System.Windows.Forms.Label lblShowStarttime;
        private System.Windows.Forms.Label lblShowDate_Showtime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblShiftShow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plCinema1;
        private System.Windows.Forms.FlowLayoutPanel flpShiftTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fplShiftShow;
        private System.Windows.Forms.Button btnExitShowTimeOrder;
    }
}