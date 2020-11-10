namespace CinemaManagement
{
    partial class fMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMovie));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.picPosterMovie = new System.Windows.Forms.PictureBox();
            this.lblInfoMovie = new System.Windows.Forms.Label();
            this.lblIDMovie = new System.Windows.Forms.Label();
            this.lblShowIDMovie = new System.Windows.Forms.Label();
            this.lblNameMovie = new System.Windows.Forms.Label();
            this.txtNameMovie = new System.Windows.Forms.TextBox();
            this.lblDirectorMovie = new System.Windows.Forms.Label();
            this.lblCategoryMovie = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.lblLanguageMovie = new System.Windows.Forms.Label();
            this.txtDirectorMovie = new System.Windows.Forms.TextBox();
            this.cboCategoryMovie = new System.Windows.Forms.ComboBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblStateMovie = new System.Windows.Forms.Label();
            this.rdoActiveMovie = new System.Windows.Forms.RadioButton();
            this.rdoInactiveMovie = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnInsertMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.splcBody = new System.Windows.Forms.SplitContainer();
            this.splctnBodyRight = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSortMovie = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPosterMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splcBody)).BeginInit();
            this.splcBody.Panel1.SuspendLayout();
            this.splcBody.Panel2.SuspendLayout();
            this.splcBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).BeginInit();
            this.splctnBodyRight.Panel1.SuspendLayout();
            this.splctnBodyRight.Panel2.SuspendLayout();
            this.splctnBodyRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnSearchMovie);
            this.pnlHeader.Controls.Add(this.txtSearchMovie);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(921, 55);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchMovie.Location = new System.Drawing.Point(545, 13);
            this.btnSearchMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(106, 34);
            this.btnSearchMovie.TabIndex = 3;
            this.btnSearchMovie.Text = "Tìm kiếm";
            this.btnSearchMovie.UseVisualStyleBackColor = false;
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Location = new System.Drawing.Point(271, 19);
            this.txtSearchMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(268, 25);
            this.txtSearchMovie.TabIndex = 2;
            // 
            // picPosterMovie
            // 
            this.picPosterMovie.BackColor = System.Drawing.Color.Transparent;
            this.picPosterMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPosterMovie.Image = ((System.Drawing.Image)(resources.GetObject("picPosterMovie.Image")));
            this.picPosterMovie.Location = new System.Drawing.Point(31, 37);
            this.picPosterMovie.Name = "picPosterMovie";
            this.picPosterMovie.Size = new System.Drawing.Size(133, 167);
            this.picPosterMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPosterMovie.TabIndex = 3;
            this.picPosterMovie.TabStop = false;
            // 
            // lblInfoMovie
            // 
            this.lblInfoMovie.AutoSize = true;
            this.lblInfoMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfoMovie.Location = new System.Drawing.Point(118, 8);
            this.lblInfoMovie.Name = "lblInfoMovie";
            this.lblInfoMovie.Size = new System.Drawing.Size(141, 19);
            this.lblInfoMovie.TabIndex = 4;
            this.lblInfoMovie.Text = "THÔNG TIN PHIM";
            // 
            // lblIDMovie
            // 
            this.lblIDMovie.AutoSize = true;
            this.lblIDMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblIDMovie.Location = new System.Drawing.Point(36, 207);
            this.lblIDMovie.Name = "lblIDMovie";
            this.lblIDMovie.Size = new System.Drawing.Size(67, 17);
            this.lblIDMovie.TabIndex = 6;
            this.lblIDMovie.Text = "Mã phim:";
            // 
            // lblShowIDMovie
            // 
            this.lblShowIDMovie.AutoSize = true;
            this.lblShowIDMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowIDMovie.Location = new System.Drawing.Point(98, 207);
            this.lblShowIDMovie.Name = "lblShowIDMovie";
            this.lblShowIDMovie.Size = new System.Drawing.Size(66, 17);
            this.lblShowIDMovie.TabIndex = 7;
            this.lblShowIDMovie.Text = "ma-phim";
            // 
            // lblNameMovie
            // 
            this.lblNameMovie.AutoSize = true;
            this.lblNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMovie.Location = new System.Drawing.Point(57, 247);
            this.lblNameMovie.Name = "lblNameMovie";
            this.lblNameMovie.Size = new System.Drawing.Size(73, 17);
            this.lblNameMovie.TabIndex = 8;
            this.lblNameMovie.Text = "Tên phim:";
            // 
            // txtNameMovie
            // 
            this.txtNameMovie.Location = new System.Drawing.Point(157, 241);
            this.txtNameMovie.Name = "txtNameMovie";
            this.txtNameMovie.Size = new System.Drawing.Size(215, 25);
            this.txtNameMovie.TabIndex = 9;
            // 
            // lblDirectorMovie
            // 
            this.lblDirectorMovie.AutoSize = true;
            this.lblDirectorMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorMovie.Location = new System.Drawing.Point(57, 289);
            this.lblDirectorMovie.Name = "lblDirectorMovie";
            this.lblDirectorMovie.Size = new System.Drawing.Size(70, 17);
            this.lblDirectorMovie.TabIndex = 10;
            this.lblDirectorMovie.Text = "Đạo diễn:";
            // 
            // lblCategoryMovie
            // 
            this.lblCategoryMovie.AutoSize = true;
            this.lblCategoryMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryMovie.Location = new System.Drawing.Point(57, 335);
            this.lblCategoryMovie.Name = "lblCategoryMovie";
            this.lblCategoryMovie.Size = new System.Drawing.Size(63, 17);
            this.lblCategoryMovie.TabIndex = 11;
            this.lblCategoryMovie.Text = "Thể loại:";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRunningTime.Location = new System.Drawing.Point(57, 380);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(85, 17);
            this.lblRunningTime.TabIndex = 12;
            this.lblRunningTime.Text = "Thời lượng:";
            // 
            // lblLanguageMovie
            // 
            this.lblLanguageMovie.AutoSize = true;
            this.lblLanguageMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguageMovie.Location = new System.Drawing.Point(57, 468);
            this.lblLanguageMovie.Name = "lblLanguageMovie";
            this.lblLanguageMovie.Size = new System.Drawing.Size(76, 17);
            this.lblLanguageMovie.TabIndex = 13;
            this.lblLanguageMovie.Text = "Ngôn ngữ:";
            // 
            // txtDirectorMovie
            // 
            this.txtDirectorMovie.Location = new System.Drawing.Point(157, 286);
            this.txtDirectorMovie.Name = "txtDirectorMovie";
            this.txtDirectorMovie.Size = new System.Drawing.Size(216, 25);
            this.txtDirectorMovie.TabIndex = 14;
            // 
            // cboCategoryMovie
            // 
            this.cboCategoryMovie.FormattingEnabled = true;
            this.cboCategoryMovie.Location = new System.Drawing.Point(157, 331);
            this.cboCategoryMovie.Name = "cboCategoryMovie";
            this.cboCategoryMovie.Size = new System.Drawing.Size(216, 25);
            this.cboCategoryMovie.TabIndex = 15;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseDate.Location = new System.Drawing.Point(57, 426);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(116, 17);
            this.lblReleaseDate.TabIndex = 16;
            this.lblReleaseDate.Text = "Ngày khởi chiếu:";
            // 
            // lblStateMovie
            // 
            this.lblStateMovie.AutoSize = true;
            this.lblStateMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblStateMovie.Location = new System.Drawing.Point(57, 507);
            this.lblStateMovie.Name = "lblStateMovie";
            this.lblStateMovie.Size = new System.Drawing.Size(76, 17);
            this.lblStateMovie.TabIndex = 17;
            this.lblStateMovie.Text = "Trạng thái:";
            // 
            // rdoActiveMovie
            // 
            this.rdoActiveMovie.AutoSize = true;
            this.rdoActiveMovie.BackColor = System.Drawing.Color.Transparent;
            this.rdoActiveMovie.Location = new System.Drawing.Point(141, 507);
            this.rdoActiveMovie.Name = "rdoActiveMovie";
            this.rdoActiveMovie.Size = new System.Drawing.Size(92, 21);
            this.rdoActiveMovie.TabIndex = 18;
            this.rdoActiveMovie.TabStop = true;
            this.rdoActiveMovie.Text = "Hoạt động";
            this.rdoActiveMovie.UseVisualStyleBackColor = false;
            // 
            // rdoInactiveMovie
            // 
            this.rdoInactiveMovie.AutoSize = true;
            this.rdoInactiveMovie.BackColor = System.Drawing.Color.Transparent;
            this.rdoInactiveMovie.Location = new System.Drawing.Point(240, 507);
            this.rdoInactiveMovie.Name = "rdoInactiveMovie";
            this.rdoInactiveMovie.Size = new System.Drawing.Size(138, 21);
            this.rdoInactiveMovie.TabIndex = 19;
            this.rdoInactiveMovie.TabStop = true;
            this.rdoInactiveMovie.Text = "Ngừng hoạt động";
            this.rdoInactiveMovie.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 25);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 375);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 25);
            this.textBox2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 421);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            // 
            // btnInsertMovie
            // 
            this.btnInsertMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsertMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertMovie.Location = new System.Drawing.Point(224, 49);
            this.btnInsertMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertMovie.Name = "btnInsertMovie";
            this.btnInsertMovie.Size = new System.Drawing.Size(106, 34);
            this.btnInsertMovie.TabIndex = 4;
            this.btnInsertMovie.Text = "Thêm";
            this.btnInsertMovie.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateMovie.Location = new System.Drawing.Point(224, 108);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(106, 34);
            this.btnUpdateMovie.TabIndex = 23;
            this.btnUpdateMovie.Text = "Sửa";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteMovie.Location = new System.Drawing.Point(224, 170);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(106, 34);
            this.btnDeleteMovie.TabIndex = 24;
            this.btnDeleteMovie.Text = "Xóa";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            // 
            // splcBody
            // 
            this.splcBody.BackColor = System.Drawing.Color.Transparent;
            this.splcBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcBody.Location = new System.Drawing.Point(0, 55);
            this.splcBody.Name = "splcBody";
            // 
            // splcBody.Panel1
            // 
            this.splcBody.Panel1.Controls.Add(this.btnDeleteMovie);
            this.splcBody.Panel1.Controls.Add(this.btnInsertMovie);
            this.splcBody.Panel1.Controls.Add(this.btnUpdateMovie);
            this.splcBody.Panel1.Controls.Add(this.picPosterMovie);
            this.splcBody.Panel1.Controls.Add(this.lblInfoMovie);
            this.splcBody.Panel1.Controls.Add(this.dateTimePicker1);
            this.splcBody.Panel1.Controls.Add(this.lblIDMovie);
            this.splcBody.Panel1.Controls.Add(this.textBox2);
            this.splcBody.Panel1.Controls.Add(this.lblShowIDMovie);
            this.splcBody.Panel1.Controls.Add(this.textBox1);
            this.splcBody.Panel1.Controls.Add(this.lblNameMovie);
            this.splcBody.Panel1.Controls.Add(this.rdoInactiveMovie);
            this.splcBody.Panel1.Controls.Add(this.txtNameMovie);
            this.splcBody.Panel1.Controls.Add(this.rdoActiveMovie);
            this.splcBody.Panel1.Controls.Add(this.lblDirectorMovie);
            this.splcBody.Panel1.Controls.Add(this.lblStateMovie);
            this.splcBody.Panel1.Controls.Add(this.lblCategoryMovie);
            this.splcBody.Panel1.Controls.Add(this.lblReleaseDate);
            this.splcBody.Panel1.Controls.Add(this.lblRunningTime);
            this.splcBody.Panel1.Controls.Add(this.cboCategoryMovie);
            this.splcBody.Panel1.Controls.Add(this.lblLanguageMovie);
            this.splcBody.Panel1.Controls.Add(this.txtDirectorMovie);
            // 
            // splcBody.Panel2
            // 
            this.splcBody.Panel2.AccessibleName = "";
            this.splcBody.Panel2.Controls.Add(this.splctnBodyRight);
            this.splcBody.Size = new System.Drawing.Size(921, 548);
            this.splcBody.SplitterDistance = 406;
            this.splcBody.TabIndex = 25;
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
            this.splctnBodyRight.Panel1.Controls.Add(this.btnSortMovie);
            this.splctnBodyRight.Panel1.Controls.Add(this.comboBox1);
            // 
            // splctnBodyRight.Panel2
            // 
            this.splctnBodyRight.Panel2.Controls.Add(this.dataGridView1);
            this.splctnBodyRight.Size = new System.Drawing.Size(511, 548);
            this.splctnBodyRight.SplitterDistance = 57;
            this.splctnBodyRight.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // btnSortMovie
            // 
            this.btnSortMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSortMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSortMovie.Location = new System.Drawing.Point(307, 11);
            this.btnSortMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortMovie.Name = "btnSortMovie";
            this.btnSortMovie.Size = new System.Drawing.Size(106, 34);
            this.btnSortMovie.TabIndex = 4;
            this.btnSortMovie.Text = "Sắp xếp";
            this.btnSortMovie.UseVisualStyleBackColor = false;
            // 
            // fMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 603);
            this.Controls.Add(this.splcBody);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMovie";
            this.Text = "fMovie";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPosterMovie)).EndInit();
            this.splcBody.Panel1.ResumeLayout(false);
            this.splcBody.Panel1.PerformLayout();
            this.splcBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcBody)).EndInit();
            this.splcBody.ResumeLayout(false);
            this.splctnBodyRight.Panel1.ResumeLayout(false);
            this.splctnBodyRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).EndInit();
            this.splctnBodyRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.PictureBox picPosterMovie;
        private System.Windows.Forms.Label lblInfoMovie;
        private System.Windows.Forms.Label lblIDMovie;
        private System.Windows.Forms.Label lblShowIDMovie;
        private System.Windows.Forms.Label lblNameMovie;
        private System.Windows.Forms.TextBox txtNameMovie;
        private System.Windows.Forms.Label lblDirectorMovie;
        private System.Windows.Forms.Label lblCategoryMovie;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.Label lblLanguageMovie;
        private System.Windows.Forms.TextBox txtDirectorMovie;
        private System.Windows.Forms.ComboBox cboCategoryMovie;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblStateMovie;
        private System.Windows.Forms.RadioButton rdoActiveMovie;
        private System.Windows.Forms.RadioButton rdoInactiveMovie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnInsertMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.SplitContainer splcBody;
        private System.Windows.Forms.SplitContainer splctnBodyRight;
        private System.Windows.Forms.Button btnSortMovie;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}