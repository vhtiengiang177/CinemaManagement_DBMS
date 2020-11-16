namespace CinemaManagement.GUI
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
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.picImageMovie = new System.Windows.Forms.PictureBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.splctnBodyRight = new System.Windows.Forms.SplitContainer();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.cboSortMovie = new System.Windows.Forms.ComboBox();
            this.dtgMovie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splcBody)).BeginInit();
            this.splcBody.Panel1.SuspendLayout();
            this.splcBody.Panel2.SuspendLayout();
            this.splcBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).BeginInit();
            this.splctnBodyRight.Panel1.SuspendLayout();
            this.splctnBodyRight.Panel2.SuspendLayout();
            this.splctnBodyRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchMovie.Location = new System.Drawing.Point(387, 14);
            this.btnSearchMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(106, 34);
            this.btnSearchMovie.TabIndex = 3;
            this.btnSearchMovie.Text = "Tìm kiếm";
            this.btnSearchMovie.UseVisualStyleBackColor = false;
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Location = new System.Drawing.Point(140, 20);
            this.txtSearchMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(241, 25);
            this.txtSearchMovie.TabIndex = 2;
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Transparent;
            this.picImageMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImageMovie.Location = new System.Drawing.Point(57, 34);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(133, 167);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 3;
            this.picImageMovie.TabStop = false;
            // 
            // lblInfoMovie
            // 
            this.lblInfoMovie.AutoSize = true;
            this.lblInfoMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfoMovie.Location = new System.Drawing.Point(112, 9);
            this.lblInfoMovie.Name = "lblInfoMovie";
            this.lblInfoMovie.Size = new System.Drawing.Size(141, 19);
            this.lblInfoMovie.TabIndex = 4;
            this.lblInfoMovie.Text = "THÔNG TIN PHIM";
            // 
            // lblIDMovie
            // 
            this.lblIDMovie.AutoSize = true;
            this.lblIDMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblIDMovie.Location = new System.Drawing.Point(55, 204);
            this.lblIDMovie.Name = "lblIDMovie";
            this.lblIDMovie.Size = new System.Drawing.Size(67, 17);
            this.lblIDMovie.TabIndex = 6;
            this.lblIDMovie.Text = "Mã phim:";
            // 
            // lblShowIDMovie
            // 
            this.lblShowIDMovie.AutoSize = true;
            this.lblShowIDMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowIDMovie.Location = new System.Drawing.Point(121, 204);
            this.lblShowIDMovie.Name = "lblShowIDMovie";
            this.lblShowIDMovie.Size = new System.Drawing.Size(66, 17);
            this.lblShowIDMovie.TabIndex = 7;
            this.lblShowIDMovie.Text = "ma-phim";
            // 
            // lblNameMovie
            // 
            this.lblNameMovie.AutoSize = true;
            this.lblNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMovie.Location = new System.Drawing.Point(44, 238);
            this.lblNameMovie.Name = "lblNameMovie";
            this.lblNameMovie.Size = new System.Drawing.Size(73, 17);
            this.lblNameMovie.TabIndex = 8;
            this.lblNameMovie.Text = "Tên phim:";
            // 
            // txtNameMovie
            // 
            this.txtNameMovie.Location = new System.Drawing.Point(132, 235);
            this.txtNameMovie.Name = "txtNameMovie";
            this.txtNameMovie.Size = new System.Drawing.Size(215, 25);
            this.txtNameMovie.TabIndex = 9;
            // 
            // lblDirectorMovie
            // 
            this.lblDirectorMovie.AutoSize = true;
            this.lblDirectorMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorMovie.Location = new System.Drawing.Point(47, 283);
            this.lblDirectorMovie.Name = "lblDirectorMovie";
            this.lblDirectorMovie.Size = new System.Drawing.Size(70, 17);
            this.lblDirectorMovie.TabIndex = 10;
            this.lblDirectorMovie.Text = "Đạo diễn:";
            // 
            // lblCategoryMovie
            // 
            this.lblCategoryMovie.AutoSize = true;
            this.lblCategoryMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryMovie.Location = new System.Drawing.Point(54, 328);
            this.lblCategoryMovie.Name = "lblCategoryMovie";
            this.lblCategoryMovie.Size = new System.Drawing.Size(63, 17);
            this.lblCategoryMovie.TabIndex = 11;
            this.lblCategoryMovie.Text = "Thể loại:";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRunningTime.Location = new System.Drawing.Point(33, 372);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(85, 17);
            this.lblRunningTime.TabIndex = 12;
            this.lblRunningTime.Text = "Thời lượng:";
            // 
            // lblLanguageMovie
            // 
            this.lblLanguageMovie.AutoSize = true;
            this.lblLanguageMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguageMovie.Location = new System.Drawing.Point(41, 462);
            this.lblLanguageMovie.Name = "lblLanguageMovie";
            this.lblLanguageMovie.Size = new System.Drawing.Size(76, 17);
            this.lblLanguageMovie.TabIndex = 13;
            this.lblLanguageMovie.Text = "Ngôn ngữ:";
            // 
            // txtDirectorMovie
            // 
            this.txtDirectorMovie.Location = new System.Drawing.Point(132, 280);
            this.txtDirectorMovie.Name = "txtDirectorMovie";
            this.txtDirectorMovie.Size = new System.Drawing.Size(216, 25);
            this.txtDirectorMovie.TabIndex = 14;
            // 
            // cboCategoryMovie
            // 
            this.cboCategoryMovie.FormattingEnabled = true;
            this.cboCategoryMovie.Location = new System.Drawing.Point(132, 325);
            this.cboCategoryMovie.Name = "cboCategoryMovie";
            this.cboCategoryMovie.Size = new System.Drawing.Size(215, 25);
            this.cboCategoryMovie.TabIndex = 15;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseDate.Location = new System.Drawing.Point(3, 421);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(116, 17);
            this.lblReleaseDate.TabIndex = 16;
            this.lblReleaseDate.Text = "Ngày khởi chiếu:";
            // 
            // lblStateMovie
            // 
            this.lblStateMovie.AutoSize = true;
            this.lblStateMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblStateMovie.Location = new System.Drawing.Point(41, 504);
            this.lblStateMovie.Name = "lblStateMovie";
            this.lblStateMovie.Size = new System.Drawing.Size(76, 17);
            this.lblStateMovie.TabIndex = 17;
            this.lblStateMovie.Text = "Trạng thái:";
            // 
            // rdoActiveMovie
            // 
            this.rdoActiveMovie.AutoSize = true;
            this.rdoActiveMovie.BackColor = System.Drawing.Color.Transparent;
            this.rdoActiveMovie.Location = new System.Drawing.Point(132, 502);
            this.rdoActiveMovie.Name = "rdoActiveMovie";
            this.rdoActiveMovie.Size = new System.Drawing.Size(129, 21);
            this.rdoActiveMovie.TabIndex = 18;
            this.rdoActiveMovie.TabStop = true;
            this.rdoActiveMovie.Text = "Đang hoạt động";
            this.rdoActiveMovie.UseVisualStyleBackColor = false;
            // 
            // rdoInactiveMovie
            // 
            this.rdoInactiveMovie.AutoSize = true;
            this.rdoInactiveMovie.BackColor = System.Drawing.Color.Transparent;
            this.rdoInactiveMovie.Location = new System.Drawing.Point(132, 525);
            this.rdoInactiveMovie.Name = "rdoInactiveMovie";
            this.rdoInactiveMovie.Size = new System.Drawing.Size(138, 21);
            this.rdoInactiveMovie.TabIndex = 19;
            this.rdoInactiveMovie.TabStop = true;
            this.rdoInactiveMovie.Text = "Ngừng hoạt động";
            this.rdoInactiveMovie.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 459);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 25);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 25);
            this.textBox2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 415);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 25);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            // 
            // btnInsertMovie
            // 
            this.btnInsertMovie.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsertMovie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertMovie.Location = new System.Drawing.Point(12, 555);
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
            this.btnUpdateMovie.Location = new System.Drawing.Point(124, 555);
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
            this.btnDeleteMovie.Location = new System.Drawing.Point(236, 555);
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
            this.splcBody.Location = new System.Drawing.Point(0, 0);
            this.splcBody.Name = "splcBody";
            // 
            // splcBody.Panel1
            // 
            this.splcBody.Panel1.Controls.Add(this.button1);
            this.splcBody.Panel1.Controls.Add(this.btnDeleteMovie);
            this.splcBody.Panel1.Controls.Add(this.btnInsertMovie);
            this.splcBody.Panel1.Controls.Add(this.btnUpdateMovie);
            this.splcBody.Panel1.Controls.Add(this.picImageMovie);
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
            this.splcBody.Size = new System.Drawing.Size(921, 603);
            this.splcBody.SplitterDistance = 362;
            this.splcBody.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(199, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Thêm hình";
            this.button1.UseVisualStyleBackColor = false;
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
            this.splctnBodyRight.Panel1.Controls.Add(this.btnSearchMovie);
            this.splctnBodyRight.Panel1.Controls.Add(this.txtSearchMovie);
            this.splctnBodyRight.Panel1.Controls.Add(this.cboSortMovie);
            // 
            // splctnBodyRight.Panel2
            // 
            this.splctnBodyRight.Panel2.Controls.Add(this.dtgMovie);
            this.splctnBodyRight.Size = new System.Drawing.Size(555, 603);
            this.splctnBodyRight.SplitterDistance = 61;
            this.splctnBodyRight.TabIndex = 0;
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(507, 15);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(36, 33);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 4;
            this.picReload.TabStop = false;
            // 
            // cboSortMovie
            // 
            this.cboSortMovie.FormattingEnabled = true;
            this.cboSortMovie.Items.AddRange(new object[] {
            "Tất cả",
            "Tên phim",
            "Đạo diễn",
            "Đang hoạt động",
            "Ngừng hoạt động"});
            this.cboSortMovie.Location = new System.Drawing.Point(13, 20);
            this.cboSortMovie.Name = "cboSortMovie";
            this.cboSortMovie.Size = new System.Drawing.Size(121, 25);
            this.cboSortMovie.TabIndex = 0;
            // 
            // dtgMovie
            // 
            this.dtgMovie.AllowUserToAddRows = false;
            this.dtgMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMovie.Location = new System.Drawing.Point(0, 0);
            this.dtgMovie.Name = "dtgMovie";
            this.dtgMovie.ReadOnly = true;
            this.dtgMovie.Size = new System.Drawing.Size(555, 538);
            this.dtgMovie.TabIndex = 0;
            // 
            // fMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 603);
            this.Controls.Add(this.splcBody);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMovie";
            this.Text = "fMovie";
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            this.splcBody.Panel1.ResumeLayout(false);
            this.splcBody.Panel1.PerformLayout();
            this.splcBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcBody)).EndInit();
            this.splcBody.ResumeLayout(false);
            this.splctnBodyRight.Panel1.ResumeLayout(false);
            this.splctnBodyRight.Panel1.PerformLayout();
            this.splctnBodyRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).EndInit();
            this.splctnBodyRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.PictureBox picImageMovie;
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
        private System.Windows.Forms.ComboBox cboSortMovie;
        private System.Windows.Forms.DataGridView dtgMovie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picReload;
    }
}