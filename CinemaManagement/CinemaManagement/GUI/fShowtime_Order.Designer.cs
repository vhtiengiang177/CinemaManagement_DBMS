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
            this.splBody = new System.Windows.Forms.SplitContainer();
            this.picImageMovie = new System.Windows.Forms.PictureBox();
            this.lblShowNameMovie = new System.Windows.Forms.Label();
            this.pnlBodyLeft = new System.Windows.Forms.Panel();
            this.lblShowNameRoom = new System.Windows.Forms.Label();
            this.lblShowStarttime = new System.Windows.Forms.Label();
            this.lblShowDate_Showtime = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblShiftShow = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splBody)).BeginInit();
            this.splBody.Panel1.SuspendLayout();
            this.splBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            this.pnlBodyLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
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
            this.splBody.Panel1.Controls.Add(this.lblShowNameMovie);
            this.splBody.Panel1.Controls.Add(this.pnlBodyLeft);
            this.splBody.Size = new System.Drawing.Size(780, 452);
            this.splBody.SplitterDistance = 219;
            this.splBody.TabIndex = 1;
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Transparent;
            this.picImageMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("picImageMovie.Image")));
            this.picImageMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.InitialImage")));
            this.picImageMovie.Location = new System.Drawing.Point(40, 10);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(133, 167);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 21;
            this.picImageMovie.TabStop = false;
            // 
            // lblShowNameMovie
            // 
            this.lblShowNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameMovie.Location = new System.Drawing.Point(11, 182);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(195, 40);
            this.lblShowNameMovie.TabIndex = 22;
            this.lblShowNameMovie.Text = "Tên-phim";
            this.lblShowNameMovie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlBodyLeft
            // 
            this.pnlBodyLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodyLeft.Controls.Add(this.lblShowNameRoom);
            this.pnlBodyLeft.Controls.Add(this.lblShowStarttime);
            this.pnlBodyLeft.Controls.Add(this.lblShowDate_Showtime);
            this.pnlBodyLeft.Controls.Add(this.lblRoom);
            this.pnlBodyLeft.Controls.Add(this.lblShiftShow);
            this.pnlBodyLeft.Controls.Add(this.lblDate);
            this.pnlBodyLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBodyLeft.Name = "pnlBodyLeft";
            this.pnlBodyLeft.Size = new System.Drawing.Size(219, 452);
            this.pnlBodyLeft.TabIndex = 23;
            // 
            // lblShowNameRoom
            // 
            this.lblShowNameRoom.AutoSize = true;
            this.lblShowNameRoom.Location = new System.Drawing.Point(87, 292);
            this.lblShowNameRoom.Name = "lblShowNameRoom";
            this.lblShowNameRoom.Size = new System.Drawing.Size(66, 13);
            this.lblShowNameRoom.TabIndex = 5;
            this.lblShowNameRoom.Text = "phòng-chiếu";
            // 
            // lblShowStarttime
            // 
            this.lblShowStarttime.AutoSize = true;
            this.lblShowStarttime.Location = new System.Drawing.Point(69, 263);
            this.lblShowStarttime.Name = "lblShowStarttime";
            this.lblShowStarttime.Size = new System.Drawing.Size(50, 13);
            this.lblShowStarttime.TabIndex = 4;
            this.lblShowStarttime.Text = "giờ-chiếu";
            // 
            // lblShowDate_Showtime
            // 
            this.lblShowDate_Showtime.AutoSize = true;
            this.lblShowDate_Showtime.Location = new System.Drawing.Point(52, 234);
            this.lblShowDate_Showtime.Name = "lblShowDate_Showtime";
            this.lblShowDate_Showtime.Size = new System.Drawing.Size(59, 13);
            this.lblShowDate_Showtime.TabIndex = 3;
            this.lblShowDate_Showtime.Text = "ngày-chiếu";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(11, 292);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(70, 13);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Phòng chiếu:";
            // 
            // lblShiftShow
            // 
            this.lblShiftShow.AutoSize = true;
            this.lblShiftShow.Location = new System.Drawing.Point(11, 263);
            this.lblShiftShow.Name = "lblShiftShow";
            this.lblShiftShow.Size = new System.Drawing.Size(52, 13);
            this.lblShiftShow.TabIndex = 1;
            this.lblShiftShow.Text = "Ca chiếu:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 234);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày:";
            // 
            // splitContainer1
            // 
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
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Panel2.Controls.Add(this.btnNext);
            this.splitContainer1.Size = new System.Drawing.Size(780, 500);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(693, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(601, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.splBody)).EndInit();
            this.splBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            this.pnlBodyLeft.ResumeLayout(false);
            this.pnlBodyLeft.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splBody;
        private System.Windows.Forms.PictureBox picImageMovie;
        private System.Windows.Forms.Label lblShowNameMovie;
        private System.Windows.Forms.Panel pnlBodyLeft;
        private System.Windows.Forms.Label lblShowNameRoom;
        private System.Windows.Forms.Label lblShowStarttime;
        private System.Windows.Forms.Label lblShowDate_Showtime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblShiftShow;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}