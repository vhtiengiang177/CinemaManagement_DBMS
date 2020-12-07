﻿namespace CinemaManagement.GUI
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
            this.splBody = new System.Windows.Forms.SplitContainer();
            this.fplShiftShow = new System.Windows.Forms.FlowLayoutPanel();
            this.plCinema1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpShiftTime = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlBodyLeft = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShiftShow = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblShowDate_Showtime = new System.Windows.Forms.Label();
            this.lblShowStarttime = new System.Windows.Forms.Label();
            this.lblShowNameMovie = new System.Windows.Forms.Label();
            this.lblShowNameRoom = new System.Windows.Forms.Label();
            this.picImageMovie = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splBody)).BeginInit();
            this.splBody.Panel1.SuspendLayout();
            this.splBody.Panel2.SuspendLayout();
            this.splBody.SuspendLayout();
            this.plCinema1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBodyLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splBody
            // 
            this.splBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splBody.Location = new System.Drawing.Point(0, 0);
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
            this.splBody.Size = new System.Drawing.Size(780, 452);
            this.splBody.SplitterDistance = 219;
            this.splBody.TabIndex = 1;
            // 
            // fplShiftShow
            // 
            this.fplShiftShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fplShiftShow.Location = new System.Drawing.Point(6, 70);
            this.fplShiftShow.Name = "fplShiftShow";
            this.fplShiftShow.Size = new System.Drawing.Size(542, 83);
            this.fplShiftShow.TabIndex = 0;
            // 
            // plCinema1
            // 
            this.plCinema1.Controls.Add(this.flpShiftTime);
            this.plCinema1.Controls.Add(this.label1);
            this.plCinema1.Location = new System.Drawing.Point(3, 182);
            this.plCinema1.Name = "plCinema1";
            this.plCinema1.Size = new System.Drawing.Size(551, 139);
            this.plCinema1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CGV Thủ Đức";
            // 
            // flpShiftTime
            // 
            this.flpShiftTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpShiftTime.Location = new System.Drawing.Point(3, 37);
            this.flpShiftTime.Name = "flpShiftTime";
            this.flpShiftTime.Size = new System.Drawing.Size(538, 87);
            this.flpShiftTime.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 41);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày chiếu";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(371, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Maroon;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(452, 412);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Tiếp";
            this.btnNext.UseVisualStyleBackColor = false;
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
            this.pnlBodyLeft.Name = "pnlBodyLeft";
            this.pnlBodyLeft.Size = new System.Drawing.Size(219, 452);
            this.pnlBodyLeft.TabIndex = 23;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(12, 245);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày:";
            // 
            // lblShiftShow
            // 
            this.lblShiftShow.AutoSize = true;
            this.lblShiftShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShiftShow.Location = new System.Drawing.Point(12, 290);
            this.lblShiftShow.Name = "lblShiftShow";
            this.lblShiftShow.Size = new System.Drawing.Size(82, 19);
            this.lblShiftShow.TabIndex = 1;
            this.lblShiftShow.Text = "Ca chiếu:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoom.Location = new System.Drawing.Point(12, 336);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(112, 19);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Phòng chiếu:";
            // 
            // lblShowDate_Showtime
            // 
            this.lblShowDate_Showtime.AutoSize = true;
            this.lblShowDate_Showtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDate_Showtime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowDate_Showtime.Location = new System.Drawing.Point(75, 245);
            this.lblShowDate_Showtime.Name = "lblShowDate_Showtime";
            this.lblShowDate_Showtime.Size = new System.Drawing.Size(83, 18);
            this.lblShowDate_Showtime.TabIndex = 3;
            this.lblShowDate_Showtime.Text = "ngày-chiếu";
            // 
            // lblShowStarttime
            // 
            this.lblShowStarttime.AutoSize = true;
            this.lblShowStarttime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowStarttime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowStarttime.Location = new System.Drawing.Point(93, 290);
            this.lblShowStarttime.Name = "lblShowStarttime";
            this.lblShowStarttime.Size = new System.Drawing.Size(74, 18);
            this.lblShowStarttime.TabIndex = 4;
            this.lblShowStarttime.Text = "giờ-chiếu";
            // 
            // lblShowNameMovie
            // 
            this.lblShowNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameMovie.Location = new System.Drawing.Point(11, 195);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(195, 40);
            this.lblShowNameMovie.TabIndex = 22;
            this.lblShowNameMovie.Text = "Tên-phim";
            this.lblShowNameMovie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblShowNameRoom
            // 
            this.lblShowNameRoom.AutoSize = true;
            this.lblShowNameRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowNameRoom.Location = new System.Drawing.Point(118, 336);
            this.lblShowNameRoom.Name = "lblShowNameRoom";
            this.lblShowNameRoom.Size = new System.Drawing.Size(93, 18);
            this.lblShowNameRoom.TabIndex = 5;
            this.lblShowNameRoom.Text = "phòng-chiếu";
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Maroon;
            this.picImageMovie.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.ErrorImage")));
            this.picImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("picImageMovie.Image")));
            this.picImageMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.InitialImage")));
            this.picImageMovie.Location = new System.Drawing.Point(40, 10);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(133, 167);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 21;
            this.picImageMovie.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(780, 500);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 2;
            // 
            // fShowtime_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fShowtime_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fShowtime_Order";
            this.splBody.Panel1.ResumeLayout(false);
            this.splBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBody)).EndInit();
            this.splBody.ResumeLayout(false);
            this.plCinema1.ResumeLayout(false);
            this.plCinema1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBodyLeft.ResumeLayout(false);
            this.pnlBodyLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splBody;
        private System.Windows.Forms.PictureBox picImageMovie;
        private System.Windows.Forms.Panel pnlBodyLeft;
        private System.Windows.Forms.Label lblShowNameRoom;
        private System.Windows.Forms.Label lblShowNameMovie;
        private System.Windows.Forms.Label lblShowStarttime;
        private System.Windows.Forms.Label lblShowDate_Showtime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblShiftShow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plCinema1;
        private System.Windows.Forms.FlowLayoutPanel flpShiftTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fplShiftShow;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}