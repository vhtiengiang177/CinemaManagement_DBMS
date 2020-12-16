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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            this.panel4.SuspendLayout();
            this.plCinema1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.plCinema1);
            this.panel1.Controls.Add(this.fplShiftShow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 615);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 615);
            this.panel2.TabIndex = 0;
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Maroon;
            this.picImageMovie.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.ErrorImage")));
            this.picImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("picImageMovie.Image")));
            this.picImageMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.InitialImage")));
            this.picImageMovie.Location = new System.Drawing.Point(72, 23);
            this.picImageMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(133, 167);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 29;
            this.picImageMovie.TabStop = false;
            this.picImageMovie.Click += new System.EventHandler(this.picImageMovie_Click);
            // 
            // lblShowNameRoom
            // 
            this.lblShowNameRoom.AutoSize = true;
            this.lblShowNameRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowNameRoom.Location = new System.Drawing.Point(160, 318);
            this.lblShowNameRoom.Name = "lblShowNameRoom";
            this.lblShowNameRoom.Size = new System.Drawing.Size(115, 23);
            this.lblShowNameRoom.TabIndex = 28;
            this.lblShowNameRoom.Text = "phòng-chiếu";
            this.lblShowNameRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowNameMovie
            // 
            this.lblShowNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowNameMovie.Location = new System.Drawing.Point(9, 193);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(271, 32);
            this.lblShowNameMovie.TabIndex = 30;
            this.lblShowNameMovie.Text = "Tên-phim";
            this.lblShowNameMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowStarttime
            // 
            this.lblShowStarttime.AutoSize = true;
            this.lblShowStarttime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowStarttime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowStarttime.Location = new System.Drawing.Point(124, 281);
            this.lblShowStarttime.Name = "lblShowStarttime";
            this.lblShowStarttime.Size = new System.Drawing.Size(90, 23);
            this.lblShowStarttime.TabIndex = 27;
            this.lblShowStarttime.Text = "giờ-chiếu";
            this.lblShowStarttime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowDate_Showtime
            // 
            this.lblShowDate_Showtime.AutoSize = true;
            this.lblShowDate_Showtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDate_Showtime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowDate_Showtime.Location = new System.Drawing.Point(95, 244);
            this.lblShowDate_Showtime.Name = "lblShowDate_Showtime";
            this.lblShowDate_Showtime.Size = new System.Drawing.Size(104, 23);
            this.lblShowDate_Showtime.TabIndex = 26;
            this.lblShowDate_Showtime.Text = "ngày-chiếu";
            this.lblShowDate_Showtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoom.Location = new System.Drawing.Point(19, 318);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(135, 24);
            this.lblRoom.TabIndex = 25;
            this.lblRoom.Text = "Phòng chiếu:";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShiftShow
            // 
            this.lblShiftShow.AutoSize = true;
            this.lblShiftShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShiftShow.Location = new System.Drawing.Point(19, 281);
            this.lblShiftShow.Name = "lblShiftShow";
            this.lblShiftShow.Size = new System.Drawing.Size(99, 24);
            this.lblShiftShow.TabIndex = 24;
            this.lblShiftShow.Text = "Ca chiếu:";
            this.lblShiftShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(19, 244);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 24);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Ngày:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Maroon;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(850, 550);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(139, 36);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Tiếp";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(700, 550);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 36);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(298, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(652, 33);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày chiếu";
            // 
            // plCinema1
            // 
            this.plCinema1.Controls.Add(this.flpShiftTime);
            this.plCinema1.Controls.Add(this.label1);
            this.plCinema1.Location = new System.Drawing.Point(298, 235);
            this.plCinema1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plCinema1.Name = "plCinema1";
            this.plCinema1.Size = new System.Drawing.Size(735, 204);
            this.plCinema1.TabIndex = 11;
            // 
            // flpShiftTime
            // 
            this.flpShiftTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpShiftTime.Location = new System.Drawing.Point(3, 38);
            this.flpShiftTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpShiftTime.Name = "flpShiftTime";
            this.flpShiftTime.Size = new System.Drawing.Size(714, 150);
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
            this.fplShiftShow.Location = new System.Drawing.Point(296, 59);
            this.fplShiftShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fplShiftShow.Name = "fplShiftShow";
            this.fplShiftShow.Size = new System.Drawing.Size(717, 150);
            this.fplShiftShow.TabIndex = 9;
            // 
            // fShowtime_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1040, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fShowtime_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fShowtime_Order";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.plCinema1.ResumeLayout(false);
            this.plCinema1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}