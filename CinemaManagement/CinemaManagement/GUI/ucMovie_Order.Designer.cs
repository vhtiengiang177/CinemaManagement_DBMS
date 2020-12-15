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
            this.picImageMovie.Location = new System.Drawing.Point(12, 12);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(138, 166);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 4;
            this.picImageMovie.TabStop = false;
            // 
            // lblDirectorMovie
            // 
            this.lblDirectorMovie.AutoSize = true;
            this.lblDirectorMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorMovie.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblDirectorMovie.Location = new System.Drawing.Point(157, 75);
            this.lblDirectorMovie.Name = "lblDirectorMovie";
            this.lblDirectorMovie.Size = new System.Drawing.Size(60, 15);
            this.lblDirectorMovie.TabIndex = 11;
            this.lblDirectorMovie.Text = "Đạo diễn:";
            this.lblDirectorMovie.MouseLeave += new System.EventHandler(this.lblDirectorMovie_MouseLeave);
            this.lblDirectorMovie.MouseHover += new System.EventHandler(this.lblDirectorMovie_MouseHover);
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningTime.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblRunningTime.Location = new System.Drawing.Point(157, 100);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(68, 15);
            this.lblRunningTime.TabIndex = 8;
            this.lblRunningTime.Text = "Thời lượng:";
            this.lblRunningTime.MouseLeave += new System.EventHandler(this.lblRunningTime_MouseLeave);
            this.lblRunningTime.MouseHover += new System.EventHandler(this.lblRunningTime_MouseHover);
            // 
            // lblShowDirectorMovie
            // 
            this.lblShowDirectorMovie.AutoSize = true;
            this.lblShowDirectorMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDirectorMovie.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblShowDirectorMovie.Location = new System.Drawing.Point(226, 75);
            this.lblShowDirectorMovie.Name = "lblShowDirectorMovie";
            this.lblShowDirectorMovie.Size = new System.Drawing.Size(56, 15);
            this.lblShowDirectorMovie.TabIndex = 12;
            this.lblShowDirectorMovie.Text = "dao-dien";
            this.lblShowDirectorMovie.MouseLeave += new System.EventHandler(this.lblShowDirectorMovie_MouseLeave);
            this.lblShowDirectorMovie.MouseHover += new System.EventHandler(this.lblShowDirectorMovie_MouseHover);
            // 
            // lblShowRunningTime
            // 
            this.lblShowRunningTime.AutoSize = true;
            this.lblShowRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRunningTime.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblShowRunningTime.Location = new System.Drawing.Point(239, 100);
            this.lblShowRunningTime.Name = "lblShowRunningTime";
            this.lblShowRunningTime.Size = new System.Drawing.Size(62, 15);
            this.lblShowRunningTime.TabIndex = 10;
            this.lblShowRunningTime.Text = "thoi-luong";
            this.lblShowRunningTime.MouseLeave += new System.EventHandler(this.lblShowRunningTime_MouseLeave);
            this.lblShowRunningTime.MouseHover += new System.EventHandler(this.lblShowRunningTime_MouseHover);
            // 
            // lblCategoryMovie
            // 
            this.lblCategoryMovie.AutoSize = true;
            this.lblCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryMovie.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblCategoryMovie.Location = new System.Drawing.Point(157, 129);
            this.lblCategoryMovie.Name = "lblCategoryMovie";
            this.lblCategoryMovie.Size = new System.Drawing.Size(54, 15);
            this.lblCategoryMovie.TabIndex = 13;
            this.lblCategoryMovie.Text = "Thể loại:";
            this.lblCategoryMovie.MouseLeave += new System.EventHandler(this.lblCategoryMovie_MouseLeave);
            this.lblCategoryMovie.MouseHover += new System.EventHandler(this.lblCategoryMovie_MouseHover);
            // 
            // lblShowNameMovie
            // 
            this.lblShowNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameMovie.ForeColor = System.Drawing.SystemColors.Window;
            this.lblShowNameMovie.Location = new System.Drawing.Point(157, 12);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(198, 52);
            this.lblShowNameMovie.TabIndex = 5;
            this.lblShowNameMovie.Text = "Tên-phim";
            this.lblShowNameMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowNameMovie.MouseLeave += new System.EventHandler(this.lblShowNameMovie_MouseLeave);
            this.lblShowNameMovie.MouseHover += new System.EventHandler(this.lblShowNameMovie_MouseHover);
            // 
            // lblShowNameCategory
            // 
            this.lblShowNameCategory.AutoSize = true;
            this.lblShowNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameCategory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblShowNameCategory.Location = new System.Drawing.Point(226, 129);
            this.lblShowNameCategory.Name = "lblShowNameCategory";
            this.lblShowNameCategory.Size = new System.Drawing.Size(48, 15);
            this.lblShowNameCategory.TabIndex = 14;
            this.lblShowNameCategory.Text = "the-loai";
            this.lblShowNameCategory.MouseLeave += new System.EventHandler(this.lblShowNameCategory_MouseLeave);
            this.lblShowNameCategory.MouseHover += new System.EventHandler(this.lblShowNameCategory_MouseHover);
            // 
            // btnOrderMovie
            // 
            this.btnOrderMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.btnOrderMovie.FlatAppearance.BorderSize = 0;
            this.btnOrderMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMovie.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOrderMovie.Location = new System.Drawing.Point(261, 159);
            this.btnOrderMovie.Name = "btnOrderMovie";
            this.btnOrderMovie.Size = new System.Drawing.Size(91, 37);
            this.btnOrderMovie.TabIndex = 7;
            this.btnOrderMovie.Text = "Đặt vé";
            this.btnOrderMovie.UseVisualStyleBackColor = false;
            this.btnOrderMovie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOrderMovie_MouseClick);
            this.btnOrderMovie.MouseLeave += new System.EventHandler(this.btnOrderMovie_MouseLeave);
            this.btnOrderMovie.MouseHover += new System.EventHandler(this.btnOrderMovie_MouseHover);
            // 
            // ucMovie_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnOrderMovie);
            this.Controls.Add(this.lblShowNameCategory);
            this.Controls.Add(this.lblCategoryMovie);
            this.Controls.Add(this.lblShowNameMovie);
            this.Controls.Add(this.lblShowRunningTime);
            this.Controls.Add(this.lblDirectorMovie);
            this.Controls.Add(this.lblRunningTime);
            this.Controls.Add(this.lblShowDirectorMovie);
            this.Controls.Add(this.picImageMovie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucMovie_Order";
            this.Size = new System.Drawing.Size(365, 209);
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
