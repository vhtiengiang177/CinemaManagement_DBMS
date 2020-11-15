namespace CinemaManagement.GUI
{
    partial class fCategoryMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCategoryMovie));
            this.splctnBody = new System.Windows.Forms.SplitContainer();
            this.btnDeleteCategoryMovie = new System.Windows.Forms.Button();
            this.btnInsertCategoryMovie = new System.Windows.Forms.Button();
            this.btnUpdateCategoryMovie = new System.Windows.Forms.Button();
            this.txtNameCategoryMovie = new System.Windows.Forms.TextBox();
            this.lblNameCategoryMovie = new System.Windows.Forms.Label();
            this.lblShowIDCategoryMovie = new System.Windows.Forms.Label();
            this.lblIDCategoryMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splctnBodyRight = new System.Windows.Forms.SplitContainer();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.btnSearchCategoryMovie = new System.Windows.Forms.Button();
            this.txtSearchCategoryMovie = new System.Windows.Forms.TextBox();
            this.dtgCategoryMovie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splctnBody)).BeginInit();
            this.splctnBody.Panel1.SuspendLayout();
            this.splctnBody.Panel2.SuspendLayout();
            this.splctnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).BeginInit();
            this.splctnBodyRight.Panel1.SuspendLayout();
            this.splctnBodyRight.Panel2.SuspendLayout();
            this.splctnBodyRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoryMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // splctnBody
            // 
            this.splctnBody.BackColor = System.Drawing.Color.Transparent;
            this.splctnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splctnBody.Location = new System.Drawing.Point(0, 0);
            this.splctnBody.Name = "splctnBody";
            // 
            // splctnBody.Panel1
            // 
            this.splctnBody.Panel1.Controls.Add(this.btnDeleteCategoryMovie);
            this.splctnBody.Panel1.Controls.Add(this.btnInsertCategoryMovie);
            this.splctnBody.Panel1.Controls.Add(this.btnUpdateCategoryMovie);
            this.splctnBody.Panel1.Controls.Add(this.txtNameCategoryMovie);
            this.splctnBody.Panel1.Controls.Add(this.lblNameCategoryMovie);
            this.splctnBody.Panel1.Controls.Add(this.lblShowIDCategoryMovie);
            this.splctnBody.Panel1.Controls.Add(this.lblIDCategoryMovie);
            this.splctnBody.Panel1.Controls.Add(this.label1);
            // 
            // splctnBody.Panel2
            // 
            this.splctnBody.Panel2.Controls.Add(this.splctnBodyRight);
            this.splctnBody.Size = new System.Drawing.Size(778, 381);
            this.splctnBody.SplitterDistance = 357;
            this.splctnBody.TabIndex = 0;
            // 
            // btnDeleteCategoryMovie
            // 
            this.btnDeleteCategoryMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteCategoryMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategoryMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCategoryMovie.Location = new System.Drawing.Point(237, 164);
            this.btnDeleteCategoryMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteCategoryMovie.Name = "btnDeleteCategoryMovie";
            this.btnDeleteCategoryMovie.Size = new System.Drawing.Size(106, 34);
            this.btnDeleteCategoryMovie.TabIndex = 27;
            this.btnDeleteCategoryMovie.Text = "Xóa";
            this.btnDeleteCategoryMovie.UseVisualStyleBackColor = false;
            // 
            // btnInsertCategoryMovie
            // 
            this.btnInsertCategoryMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsertCategoryMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCategoryMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertCategoryMovie.Location = new System.Drawing.Point(13, 164);
            this.btnInsertCategoryMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertCategoryMovie.Name = "btnInsertCategoryMovie";
            this.btnInsertCategoryMovie.Size = new System.Drawing.Size(106, 34);
            this.btnInsertCategoryMovie.TabIndex = 25;
            this.btnInsertCategoryMovie.Text = "Thêm";
            this.btnInsertCategoryMovie.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCategoryMovie
            // 
            this.btnUpdateCategoryMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateCategoryMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategoryMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateCategoryMovie.Location = new System.Drawing.Point(125, 164);
            this.btnUpdateCategoryMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateCategoryMovie.Name = "btnUpdateCategoryMovie";
            this.btnUpdateCategoryMovie.Size = new System.Drawing.Size(106, 34);
            this.btnUpdateCategoryMovie.TabIndex = 26;
            this.btnUpdateCategoryMovie.Text = "Sửa";
            this.btnUpdateCategoryMovie.UseVisualStyleBackColor = false;
            // 
            // txtNameCategoryMovie
            // 
            this.txtNameCategoryMovie.Location = new System.Drawing.Point(106, 105);
            this.txtNameCategoryMovie.Name = "txtNameCategoryMovie";
            this.txtNameCategoryMovie.Size = new System.Drawing.Size(216, 25);
            this.txtNameCategoryMovie.TabIndex = 4;
            // 
            // lblNameCategoryMovie
            // 
            this.lblNameCategoryMovie.AutoSize = true;
            this.lblNameCategoryMovie.Location = new System.Drawing.Point(20, 108);
            this.lblNameCategoryMovie.Name = "lblNameCategoryMovie";
            this.lblNameCategoryMovie.Size = new System.Drawing.Size(87, 17);
            this.lblNameCategoryMovie.TabIndex = 3;
            this.lblNameCategoryMovie.Text = "Tên thể loại:";
            // 
            // lblShowIDCategoryMovie
            // 
            this.lblShowIDCategoryMovie.AutoSize = true;
            this.lblShowIDCategoryMovie.Location = new System.Drawing.Point(103, 72);
            this.lblShowIDCategoryMovie.Name = "lblShowIDCategoryMovie";
            this.lblShowIDCategoryMovie.Size = new System.Drawing.Size(81, 17);
            this.lblShowIDCategoryMovie.TabIndex = 2;
            this.lblShowIDCategoryMovie.Text = "ma-the-loai";
            // 
            // lblIDCategoryMovie
            // 
            this.lblIDCategoryMovie.AutoSize = true;
            this.lblIDCategoryMovie.Location = new System.Drawing.Point(25, 72);
            this.lblIDCategoryMovie.Name = "lblIDCategoryMovie";
            this.lblIDCategoryMovie.Size = new System.Drawing.Size(81, 17);
            this.lblIDCategoryMovie.TabIndex = 1;
            this.lblIDCategoryMovie.Text = "Mã thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỂ LOẠI PHIM";
            // 
            // splctnBodyRight
            // 
            this.splctnBodyRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splctnBodyRight.Location = new System.Drawing.Point(0, 0);
            this.splctnBodyRight.Name = "splctnBodyRight";
            this.splctnBodyRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splctnBodyRight.Panel1
            // 
            this.splctnBodyRight.Panel1.Controls.Add(this.picReload);
            this.splctnBodyRight.Panel1.Controls.Add(this.btnSearchCategoryMovie);
            this.splctnBodyRight.Panel1.Controls.Add(this.txtSearchCategoryMovie);
            // 
            // splctnBodyRight.Panel2
            // 
            this.splctnBodyRight.Panel2.Controls.Add(this.dtgCategoryMovie);
            this.splctnBodyRight.Size = new System.Drawing.Size(417, 381);
            this.splctnBodyRight.SplitterDistance = 56;
            this.splctnBodyRight.TabIndex = 0;
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(370, 7);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(36, 33);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 28;
            this.picReload.TabStop = false;
            // 
            // btnSearchCategoryMovie
            // 
            this.btnSearchCategoryMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchCategoryMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCategoryMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchCategoryMovie.Location = new System.Drawing.Point(258, 8);
            this.btnSearchCategoryMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchCategoryMovie.Name = "btnSearchCategoryMovie";
            this.btnSearchCategoryMovie.Size = new System.Drawing.Size(106, 34);
            this.btnSearchCategoryMovie.TabIndex = 6;
            this.btnSearchCategoryMovie.Text = "Tìm kiếm";
            this.btnSearchCategoryMovie.UseVisualStyleBackColor = false;
            // 
            // txtSearchCategoryMovie
            // 
            this.txtSearchCategoryMovie.Location = new System.Drawing.Point(11, 14);
            this.txtSearchCategoryMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCategoryMovie.Name = "txtSearchCategoryMovie";
            this.txtSearchCategoryMovie.Size = new System.Drawing.Size(241, 25);
            this.txtSearchCategoryMovie.TabIndex = 5;
            // 
            // dtgCategoryMovie
            // 
            this.dtgCategoryMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoryMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCategoryMovie.Location = new System.Drawing.Point(0, 0);
            this.dtgCategoryMovie.Name = "dtgCategoryMovie";
            this.dtgCategoryMovie.Size = new System.Drawing.Size(417, 321);
            this.dtgCategoryMovie.TabIndex = 0;
            // 
            // fCategoryMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 381);
            this.Controls.Add(this.splctnBody);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fCategoryMovie";
            this.Text = "Thể loại phim";
            this.splctnBody.Panel1.ResumeLayout(false);
            this.splctnBody.Panel1.PerformLayout();
            this.splctnBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splctnBody)).EndInit();
            this.splctnBody.ResumeLayout(false);
            this.splctnBodyRight.Panel1.ResumeLayout(false);
            this.splctnBodyRight.Panel1.PerformLayout();
            this.splctnBodyRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).EndInit();
            this.splctnBodyRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoryMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splctnBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameCategoryMovie;
        private System.Windows.Forms.Label lblShowIDCategoryMovie;
        private System.Windows.Forms.Label lblIDCategoryMovie;
        private System.Windows.Forms.TextBox txtNameCategoryMovie;
        private System.Windows.Forms.Button btnDeleteCategoryMovie;
        private System.Windows.Forms.Button btnInsertCategoryMovie;
        private System.Windows.Forms.Button btnUpdateCategoryMovie;
        private System.Windows.Forms.SplitContainer splctnBodyRight;
        private System.Windows.Forms.DataGridView dtgCategoryMovie;
        private System.Windows.Forms.Button btnSearchCategoryMovie;
        private System.Windows.Forms.TextBox txtSearchCategoryMovie;
        private System.Windows.Forms.PictureBox picReload;
    }
}