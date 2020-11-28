namespace CinemaManagement.GUI
{
    partial class ucMovie_Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMovie_Order));
            this.picImageMovie = new System.Windows.Forms.PictureBox();
            this.lblDirectorMovie = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.lblShowDirectorMovie = new System.Windows.Forms.Label();
            this.lblShowRunningTime = new System.Windows.Forms.Label();
            this.lblCategoryMovie = new System.Windows.Forms.Label();
            this.lblShowNameMovie = new System.Windows.Forms.Label();
            this.lblShowNameCategory = new System.Windows.Forms.Label();
            this.btnOrderMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Transparent;
            this.picImageMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("picImageMovie.Image")));
            this.picImageMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.InitialImage")));
            this.picImageMovie.Location = new System.Drawing.Point(10, 10);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(119, 144);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 4;
            this.picImageMovie.TabStop = false;
            // 
            // lblDirectorMovie
            // 
            this.lblDirectorMovie.AutoSize = true;
            this.lblDirectorMovie.Location = new System.Drawing.Point(135, 65);
            this.lblDirectorMovie.Name = "lblDirectorMovie";
            this.lblDirectorMovie.Size = new System.Drawing.Size(53, 13);
            this.lblDirectorMovie.TabIndex = 11;
            this.lblDirectorMovie.Text = "Đạo diễn:";
            this.lblDirectorMovie.MouseLeave += new System.EventHandler(this.lblDirectorMovie_MouseLeave);
            this.lblDirectorMovie.MouseHover += new System.EventHandler(this.lblDirectorMovie_MouseHover);
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Location = new System.Drawing.Point(135, 87);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(60, 13);
            this.lblRunningTime.TabIndex = 8;
            this.lblRunningTime.Text = "Thời lượng:";
            this.lblRunningTime.MouseLeave += new System.EventHandler(this.lblRunningTime_MouseLeave);
            this.lblRunningTime.MouseHover += new System.EventHandler(this.lblRunningTime_MouseHover);
            // 
            // lblShowDirectorMovie
            // 
            this.lblShowDirectorMovie.AutoSize = true;
            this.lblShowDirectorMovie.Location = new System.Drawing.Point(194, 65);
            this.lblShowDirectorMovie.Name = "lblShowDirectorMovie";
            this.lblShowDirectorMovie.Size = new System.Drawing.Size(48, 13);
            this.lblShowDirectorMovie.TabIndex = 12;
            this.lblShowDirectorMovie.Text = "dao-dien";
            this.lblShowDirectorMovie.MouseLeave += new System.EventHandler(this.lblShowDirectorMovie_MouseLeave);
            this.lblShowDirectorMovie.MouseHover += new System.EventHandler(this.lblShowDirectorMovie_MouseHover);
            // 
            // lblShowRunningTime
            // 
            this.lblShowRunningTime.AutoSize = true;
            this.lblShowRunningTime.Location = new System.Drawing.Point(205, 87);
            this.lblShowRunningTime.Name = "lblShowRunningTime";
            this.lblShowRunningTime.Size = new System.Drawing.Size(53, 13);
            this.lblShowRunningTime.TabIndex = 10;
            this.lblShowRunningTime.Text = "thoi-luong";
            this.lblShowRunningTime.MouseLeave += new System.EventHandler(this.lblShowRunningTime_MouseLeave);
            this.lblShowRunningTime.MouseHover += new System.EventHandler(this.lblShowRunningTime_MouseHover);
            // 
            // lblCategoryMovie
            // 
            this.lblCategoryMovie.AutoSize = true;
            this.lblCategoryMovie.Location = new System.Drawing.Point(135, 112);
            this.lblCategoryMovie.Name = "lblCategoryMovie";
            this.lblCategoryMovie.Size = new System.Drawing.Size(48, 13);
            this.lblCategoryMovie.TabIndex = 13;
            this.lblCategoryMovie.Text = "Thể loại:";
            this.lblCategoryMovie.MouseLeave += new System.EventHandler(this.lblCategoryMovie_MouseLeave);
            this.lblCategoryMovie.MouseHover += new System.EventHandler(this.lblCategoryMovie_MouseHover);
            // 
            // lblShowNameMovie
            // 
            this.lblShowNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameMovie.Location = new System.Drawing.Point(135, 10);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(170, 45);
            this.lblShowNameMovie.TabIndex = 5;
            this.lblShowNameMovie.Text = "Tên-phim";
            this.lblShowNameMovie.MouseLeave += new System.EventHandler(this.lblShowNameMovie_MouseLeave);
            this.lblShowNameMovie.MouseHover += new System.EventHandler(this.lblShowNameMovie_MouseHover);
            // 
            // lblShowNameCategory
            // 
            this.lblShowNameCategory.AutoSize = true;
            this.lblShowNameCategory.Location = new System.Drawing.Point(194, 112);
            this.lblShowNameCategory.Name = "lblShowNameCategory";
            this.lblShowNameCategory.Size = new System.Drawing.Size(41, 13);
            this.lblShowNameCategory.TabIndex = 14;
            this.lblShowNameCategory.Text = "the-loai";
            this.lblShowNameCategory.MouseLeave += new System.EventHandler(this.lblShowNameCategory_MouseLeave);
            this.lblShowNameCategory.MouseHover += new System.EventHandler(this.lblShowNameCategory_MouseHover);
            // 
            // btnOrderMovie
            // 
            this.btnOrderMovie.Location = new System.Drawing.Point(224, 128);
            this.btnOrderMovie.Name = "btnOrderMovie";
            this.btnOrderMovie.Size = new System.Drawing.Size(78, 42);
            this.btnOrderMovie.TabIndex = 7;
            this.btnOrderMovie.Text = "Đặt vé";
            this.btnOrderMovie.UseVisualStyleBackColor = true;
            this.btnOrderMovie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOrderMovie_MouseClick);
            this.btnOrderMovie.MouseLeave += new System.EventHandler(this.btnOrderMovie_MouseLeave);
            this.btnOrderMovie.MouseHover += new System.EventHandler(this.btnOrderMovie_MouseHover);
            // 
            // ucMovie_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOrderMovie);
            this.Controls.Add(this.lblShowNameCategory);
            this.Controls.Add(this.lblCategoryMovie);
            this.Controls.Add(this.lblShowNameMovie);
            this.Controls.Add(this.lblShowRunningTime);
            this.Controls.Add(this.lblDirectorMovie);
            this.Controls.Add(this.lblRunningTime);
            this.Controls.Add(this.lblShowDirectorMovie);
            this.Controls.Add(this.picImageMovie);
            this.Name = "ucMovie_Order";
            this.Size = new System.Drawing.Size(315, 183);
            this.MouseLeave += new System.EventHandler(this.ucMovie_Order_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ucMovie_Order_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageMovie;
        private System.Windows.Forms.Label lblDirectorMovie;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.Label lblShowDirectorMovie;
        private System.Windows.Forms.Label lblShowRunningTime;
        private System.Windows.Forms.Label lblCategoryMovie;
        private System.Windows.Forms.Label lblShowNameMovie;
        private System.Windows.Forms.Label lblShowNameCategory;
        private System.Windows.Forms.Button btnOrderMovie;
    }
}
