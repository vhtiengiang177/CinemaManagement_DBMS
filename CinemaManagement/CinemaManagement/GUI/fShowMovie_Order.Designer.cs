namespace CinemaManagement.GUI
{
    partial class fShowMovie_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fShowMovie_Order));
            this.splBody = new System.Windows.Forms.SplitContainer();
            this.lblShowLanguage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowRunningTime = new System.Windows.Forms.Label();
            this.lblShowNameCategory = new System.Windows.Forms.Label();
            this.lblShowDirector = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.picImageMovie = new System.Windows.Forms.PictureBox();
            this.lblShowNameMovie = new System.Windows.Forms.Label();
            this.lblDirectorMovie = new System.Windows.Forms.Label();
            this.lblCategoryMovie = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.lblLanguageMovie = new System.Windows.Forms.Label();
            this.splBodyRight = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.flpnlMovie = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splBody)).BeginInit();
            this.splBody.Panel1.SuspendLayout();
            this.splBody.Panel2.SuspendLayout();
            this.splBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splBodyRight)).BeginInit();
            this.splBodyRight.Panel1.SuspendLayout();
            this.splBodyRight.Panel2.SuspendLayout();
            this.splBodyRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // splBody
            // 
            this.splBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splBody.Location = new System.Drawing.Point(0, 0);
            this.splBody.Name = "splBody";
            // 
            // splBody.Panel1
            // 
            this.splBody.Panel1.Controls.Add(this.lblShowLanguage);
            this.splBody.Panel1.Controls.Add(this.label1);
            this.splBody.Panel1.Controls.Add(this.lblShowRunningTime);
            this.splBody.Panel1.Controls.Add(this.lblShowNameCategory);
            this.splBody.Panel1.Controls.Add(this.lblShowDirector);
            this.splBody.Panel1.Controls.Add(this.btnOrder);
            this.splBody.Panel1.Controls.Add(this.picImageMovie);
            this.splBody.Panel1.Controls.Add(this.lblShowNameMovie);
            this.splBody.Panel1.Controls.Add(this.lblDirectorMovie);
            this.splBody.Panel1.Controls.Add(this.lblCategoryMovie);
            this.splBody.Panel1.Controls.Add(this.lblReleaseDate);
            this.splBody.Panel1.Controls.Add(this.lblRunningTime);
            this.splBody.Panel1.Controls.Add(this.lblLanguageMovie);
            // 
            // splBody.Panel2
            // 
            this.splBody.Panel2.Controls.Add(this.splBodyRight);
            this.splBody.Size = new System.Drawing.Size(972, 513);
            this.splBody.SplitterDistance = 231;
            this.splBody.TabIndex = 0;
            // 
            // lblShowLanguage
            // 
            this.lblShowLanguage.AutoSize = true;
            this.lblShowLanguage.Location = new System.Drawing.Point(106, 342);
            this.lblShowLanguage.Name = "lblShowLanguage";
            this.lblShowLanguage.Size = new System.Drawing.Size(52, 13);
            this.lblShowLanguage.TabIndex = 31;
            this.lblShowLanguage.Text = "ngôn-ngữ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ngày-khởi-chiếu";
            // 
            // lblShowRunningTime
            // 
            this.lblShowRunningTime.AutoSize = true;
            this.lblShowRunningTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRunningTime.Location = new System.Drawing.Point(105, 284);
            this.lblShowRunningTime.Name = "lblShowRunningTime";
            this.lblShowRunningTime.Size = new System.Drawing.Size(57, 13);
            this.lblShowRunningTime.TabIndex = 29;
            this.lblShowRunningTime.Text = "Thời-lượng";
            // 
            // lblShowNameCategory
            // 
            this.lblShowNameCategory.AutoSize = true;
            this.lblShowNameCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameCategory.Location = new System.Drawing.Point(105, 257);
            this.lblShowNameCategory.Name = "lblShowNameCategory";
            this.lblShowNameCategory.Size = new System.Drawing.Size(45, 13);
            this.lblShowNameCategory.TabIndex = 28;
            this.lblShowNameCategory.Text = "Thể-loại";
            // 
            // lblShowDirector
            // 
            this.lblShowDirector.AutoSize = true;
            this.lblShowDirector.BackColor = System.Drawing.Color.Transparent;
            this.lblShowDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDirector.Location = new System.Drawing.Point(105, 229);
            this.lblShowDirector.Name = "lblShowDirector";
            this.lblShowDirector.Size = new System.Drawing.Size(50, 13);
            this.lblShowDirector.TabIndex = 27;
            this.lblShowDirector.Text = "Đạo-diễn";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(69, 394);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 49);
            this.btnOrder.TabIndex = 26;
            this.btnOrder.Text = "Đặt vé";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Transparent;
            this.picImageMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("picImageMovie.Image")));
            this.picImageMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.InitialImage")));
            this.picImageMovie.Location = new System.Drawing.Point(69, 12);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(133, 167);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 17;
            this.picImageMovie.TabStop = false;
            // 
            // lblShowNameMovie
            // 
            this.lblShowNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNameMovie.Location = new System.Drawing.Point(26, 186);
            this.lblShowNameMovie.Name = "lblShowNameMovie";
            this.lblShowNameMovie.Size = new System.Drawing.Size(225, 40);
            this.lblShowNameMovie.TabIndex = 20;
            this.lblShowNameMovie.Text = "Tên-phim";
            this.lblShowNameMovie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDirectorMovie
            // 
            this.lblDirectorMovie.AutoSize = true;
            this.lblDirectorMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorMovie.Location = new System.Drawing.Point(46, 229);
            this.lblDirectorMovie.Name = "lblDirectorMovie";
            this.lblDirectorMovie.Size = new System.Drawing.Size(53, 13);
            this.lblDirectorMovie.TabIndex = 21;
            this.lblDirectorMovie.Text = "Đạo diễn:";
            // 
            // lblCategoryMovie
            // 
            this.lblCategoryMovie.AutoSize = true;
            this.lblCategoryMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryMovie.Location = new System.Drawing.Point(51, 257);
            this.lblCategoryMovie.Name = "lblCategoryMovie";
            this.lblCategoryMovie.Size = new System.Drawing.Size(48, 13);
            this.lblCategoryMovie.TabIndex = 22;
            this.lblCategoryMovie.Text = "Thể loại:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(12, 313);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(87, 13);
            this.lblReleaseDate.TabIndex = 25;
            this.lblReleaseDate.Text = "Ngày khởi chiếu:";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningTime.Location = new System.Drawing.Point(39, 284);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(60, 13);
            this.lblRunningTime.TabIndex = 23;
            this.lblRunningTime.Text = "Thời lượng:";
            // 
            // lblLanguageMovie
            // 
            this.lblLanguageMovie.AutoSize = true;
            this.lblLanguageMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguageMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageMovie.Location = new System.Drawing.Point(42, 342);
            this.lblLanguageMovie.Name = "lblLanguageMovie";
            this.lblLanguageMovie.Size = new System.Drawing.Size(57, 13);
            this.lblLanguageMovie.TabIndex = 24;
            this.lblLanguageMovie.Text = "Ngôn ngữ:";
            // 
            // splBodyRight
            // 
            this.splBodyRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splBodyRight.Location = new System.Drawing.Point(0, 0);
            this.splBodyRight.Name = "splBodyRight";
            this.splBodyRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splBodyRight.Panel1
            // 
            this.splBodyRight.Panel1.Controls.Add(this.label2);
            // 
            // splBodyRight.Panel2
            // 
            this.splBodyRight.Panel2.Controls.Add(this.flpnlMovie);
            this.splBodyRight.Size = new System.Drawing.Size(735, 511);
            this.splBodyRight.SplitterDistance = 44;
            this.splBodyRight.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHỌN PHIM";
            // 
            // flpnlMovie
            // 
            this.flpnlMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlMovie.Location = new System.Drawing.Point(0, 0);
            this.flpnlMovie.Name = "flpnlMovie";
            this.flpnlMovie.Size = new System.Drawing.Size(735, 463);
            this.flpnlMovie.TabIndex = 0;
            // 
            // fShowMovie_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 513);
            this.Controls.Add(this.splBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fShowMovie_Order";
            this.Text = "fShowMovie_Order";
            this.splBody.Panel1.ResumeLayout(false);
            this.splBody.Panel1.PerformLayout();
            this.splBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBody)).EndInit();
            this.splBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            this.splBodyRight.Panel1.ResumeLayout(false);
            this.splBodyRight.Panel1.PerformLayout();
            this.splBodyRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBodyRight)).EndInit();
            this.splBodyRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splBody;
        private System.Windows.Forms.Label lblShowDirector;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox picImageMovie;
        private System.Windows.Forms.Label lblShowNameMovie;
        private System.Windows.Forms.Label lblDirectorMovie;
        private System.Windows.Forms.Label lblCategoryMovie;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.Label lblLanguageMovie;
        private System.Windows.Forms.Label lblShowLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowRunningTime;
        private System.Windows.Forms.Label lblShowNameCategory;
        private System.Windows.Forms.SplitContainer splBodyRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpnlMovie;
    }
}