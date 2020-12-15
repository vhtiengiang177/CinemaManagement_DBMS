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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMovie));
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.picImageMovie = new System.Windows.Forms.PictureBox();
            this.lblInfoMovie = new System.Windows.Forms.Label();
            this.lblIDMovie = new System.Windows.Forms.Label();
            this.lblShowIDMovie = new System.Windows.Forms.Label();
            this.txtNameMovie = new System.Windows.Forms.TextBox();
            this.txtDirectorMovie = new System.Windows.Forms.TextBox();
            this.cboCategoryMovie = new System.Windows.Forms.ComboBox();
            this.categoryMovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDBMSDataSet = new CinemaManagement.cinemaDBMSDataSet();
            this.lblStateMovie = new System.Windows.Forms.Label();
            this.rdoActiveMovie = new System.Windows.Forms.RadioButton();
            this.rdoInactiveMovie = new System.Windows.Forms.RadioButton();
            this.txtLanguageMovie = new System.Windows.Forms.TextBox();
            this.txtRunningTimeMovie = new System.Windows.Forms.TextBox();
            this.dtmReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsertMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.splcBody = new System.Windows.Forms.SplitContainer();
            this.btnInsertCategory = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.splctnBodyRight = new System.Windows.Forms.SplitContainer();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.cboInfoSearchMovie = new System.Windows.Forms.ComboBox();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.categoryMovieTableAdapter = new CinemaManagement.cinemaDBMSDataSetTableAdapters.CategoryMovieTableAdapter();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameMovie = new System.Windows.Forms.Label();
            this.lblDirectorMovie = new System.Windows.Forms.Label();
            this.lblCategoryMovie = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.lblLanguageMovie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryMovieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splcBody)).BeginInit();
            this.splcBody.Panel1.SuspendLayout();
            this.splcBody.Panel2.SuspendLayout();
            this.splcBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).BeginInit();
            this.splctnBodyRight.Panel1.SuspendLayout();
            this.splctnBodyRight.Panel2.SuspendLayout();
            this.splctnBodyRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.Location = new System.Drawing.Point(228, 23);
            this.txtSearchMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(279, 20);
            this.txtSearchMovie.TabIndex = 16;
            this.toolTip.SetToolTip(this.txtSearchMovie, "Nhập vào thông tin tìm kiếm");
            this.txtSearchMovie.TextChanged += new System.EventHandler(this.txtSearchMovie_TextChanged);
            // 
            // picImageMovie
            // 
            this.picImageMovie.BackColor = System.Drawing.Color.Transparent;
            this.picImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("picImageMovie.Image")));
            this.picImageMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImageMovie.InitialImage")));
            this.picImageMovie.Location = new System.Drawing.Point(57, 53);
            this.picImageMovie.Name = "picImageMovie";
            this.picImageMovie.Size = new System.Drawing.Size(133, 167);
            this.picImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageMovie.TabIndex = 3;
            this.picImageMovie.TabStop = false;
            this.toolTip.SetToolTip(this.picImageMovie, "Thêm hình ảnh cho phim.");
            // 
            // lblInfoMovie
            // 
            this.lblInfoMovie.AutoSize = true;
            this.lblInfoMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfoMovie.Location = new System.Drawing.Point(112, 19);
            this.lblInfoMovie.Name = "lblInfoMovie";
            this.lblInfoMovie.Size = new System.Drawing.Size(106, 15);
            this.lblInfoMovie.TabIndex = 4;
            this.lblInfoMovie.Text = "THÔNG TIN PHIM";
            // 
            // lblIDMovie
            // 
            this.lblIDMovie.AutoSize = true;
            this.lblIDMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblIDMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMovie.Location = new System.Drawing.Point(55, 223);
            this.lblIDMovie.Name = "lblIDMovie";
            this.lblIDMovie.Size = new System.Drawing.Size(59, 15);
            this.lblIDMovie.TabIndex = 6;
            this.lblIDMovie.Text = "Mã phim:";
            // 
            // lblShowIDMovie
            // 
            this.lblShowIDMovie.AutoSize = true;
            this.lblShowIDMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblShowIDMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowIDMovie.Location = new System.Drawing.Point(121, 223);
            this.lblShowIDMovie.Name = "lblShowIDMovie";
            this.lblShowIDMovie.Size = new System.Drawing.Size(46, 13);
            this.lblShowIDMovie.TabIndex = 7;
            this.lblShowIDMovie.Text = "ma-phim";
            // 
            // txtNameMovie
            // 
            this.txtNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameMovie.Location = new System.Drawing.Point(115, 254);
            this.txtNameMovie.Name = "txtNameMovie";
            this.txtNameMovie.Size = new System.Drawing.Size(215, 20);
            this.txtNameMovie.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtNameMovie, "Nhập vào tên phim. Lưu ý: Không nhập tên phim đã có trong danh sách.");
            // 
            // txtDirectorMovie
            // 
            this.txtDirectorMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorMovie.Location = new System.Drawing.Point(115, 299);
            this.txtDirectorMovie.Name = "txtDirectorMovie";
            this.txtDirectorMovie.Size = new System.Drawing.Size(216, 20);
            this.txtDirectorMovie.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtDirectorMovie, "Nhập tên đạo diễn của phim.");
            // 
            // cboCategoryMovie
            // 
            this.cboCategoryMovie.DataSource = this.categoryMovieBindingSource;
            this.cboCategoryMovie.DisplayMember = "name_categorymovie";
            this.cboCategoryMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoryMovie.FormattingEnabled = true;
            this.cboCategoryMovie.Location = new System.Drawing.Point(115, 344);
            this.cboCategoryMovie.Name = "cboCategoryMovie";
            this.cboCategoryMovie.Size = new System.Drawing.Size(184, 21);
            this.cboCategoryMovie.TabIndex = 5;
            this.toolTip.SetToolTip(this.cboCategoryMovie, "Chọn thể loại phim.");
            this.cboCategoryMovie.ValueMember = "id_categorymovie";
            // 
            // categoryMovieBindingSource
            // 
            this.categoryMovieBindingSource.DataMember = "CategoryMovie";
            this.categoryMovieBindingSource.DataSource = this.cinemaDBMSDataSet;
            // 
            // cinemaDBMSDataSet
            // 
            this.cinemaDBMSDataSet.DataSetName = "cinemaDBMSDataSet";
            this.cinemaDBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStateMovie
            // 
            this.lblStateMovie.AutoSize = true;
            this.lblStateMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblStateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateMovie.Location = new System.Drawing.Point(41, 523);
            this.lblStateMovie.Name = "lblStateMovie";
            this.lblStateMovie.Size = new System.Drawing.Size(58, 13);
            this.lblStateMovie.TabIndex = 17;
            this.lblStateMovie.Text = "Trạng thái:";
            // 
            // rdoActiveMovie
            // 
            this.rdoActiveMovie.AutoSize = true;
            this.rdoActiveMovie.BackColor = System.Drawing.Color.Transparent;
            this.rdoActiveMovie.Checked = true;
            this.rdoActiveMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoActiveMovie.Location = new System.Drawing.Point(115, 521);
            this.rdoActiveMovie.Name = "rdoActiveMovie";
            this.rdoActiveMovie.Size = new System.Drawing.Size(103, 17);
            this.rdoActiveMovie.TabIndex = 10;
            this.rdoActiveMovie.TabStop = true;
            this.rdoActiveMovie.Text = "Đang hoạt động";
            this.rdoActiveMovie.UseVisualStyleBackColor = false;
            // 
            // rdoInactiveMovie
            // 
            this.rdoInactiveMovie.AutoSize = true;
            this.rdoInactiveMovie.BackColor = System.Drawing.Color.Transparent;
            this.rdoInactiveMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInactiveMovie.Location = new System.Drawing.Point(115, 544);
            this.rdoInactiveMovie.Name = "rdoInactiveMovie";
            this.rdoInactiveMovie.Size = new System.Drawing.Size(109, 17);
            this.rdoInactiveMovie.TabIndex = 11;
            this.rdoInactiveMovie.TabStop = true;
            this.rdoInactiveMovie.Text = "Ngưng hoạt động";
            this.rdoInactiveMovie.UseVisualStyleBackColor = false;
            // 
            // txtLanguageMovie
            // 
            this.txtLanguageMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguageMovie.Location = new System.Drawing.Point(115, 478);
            this.txtLanguageMovie.Name = "txtLanguageMovie";
            this.txtLanguageMovie.Size = new System.Drawing.Size(216, 20);
            this.txtLanguageMovie.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtLanguageMovie, "Nhập ngôn ngữ của phim.");
            // 
            // txtRunningTimeMovie
            // 
            this.txtRunningTimeMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunningTimeMovie.Location = new System.Drawing.Point(115, 388);
            this.txtRunningTimeMovie.Name = "txtRunningTimeMovie";
            this.txtRunningTimeMovie.Size = new System.Drawing.Size(216, 20);
            this.txtRunningTimeMovie.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtRunningTimeMovie, "Nhập vào thời lượng của phim.");
            // 
            // dtmReleaseDate
            // 
            this.dtmReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmReleaseDate.Location = new System.Drawing.Point(115, 434);
            this.dtmReleaseDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtmReleaseDate.Name = "dtmReleaseDate";
            this.dtmReleaseDate.Size = new System.Drawing.Size(215, 20);
            this.dtmReleaseDate.TabIndex = 8;
            this.toolTip.SetToolTip(this.dtmReleaseDate, "Chọn ngày khởi chiếu của phim.");
            this.dtmReleaseDate.Value = new System.DateTime(2020, 11, 23, 0, 0, 0, 0);
            // 
            // btnInsertMovie
            // 
            this.btnInsertMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.btnInsertMovie.FlatAppearance.BorderSize = 0;
            this.btnInsertMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertMovie.Location = new System.Drawing.Point(40, 579);
            this.btnInsertMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertMovie.Name = "btnInsertMovie";
            this.btnInsertMovie.Size = new System.Drawing.Size(61, 20);
            this.btnInsertMovie.TabIndex = 12;
            this.btnInsertMovie.Text = "Thêm";
            this.toolTip.SetToolTip(this.btnInsertMovie, "Thêm phim vào danh sách.");
            this.btnInsertMovie.UseVisualStyleBackColor = false;
            this.btnInsertMovie.Click += new System.EventHandler(this.btnInsertMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.btnUpdateMovie.FlatAppearance.BorderSize = 0;
            this.btnUpdateMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateMovie.Location = new System.Drawing.Point(152, 579);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(66, 20);
            this.btnUpdateMovie.TabIndex = 13;
            this.btnUpdateMovie.Text = "Sửa";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.btnDeleteMovie.FlatAppearance.BorderSize = 0;
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteMovie.Location = new System.Drawing.Point(264, 579);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(63, 20);
            this.btnDeleteMovie.TabIndex = 14;
            this.btnDeleteMovie.Text = "Xóa";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // splcBody
            // 
            this.splcBody.BackColor = System.Drawing.Color.Transparent;
            this.splcBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splcBody.Location = new System.Drawing.Point(0, 0);
            this.splcBody.Name = "splcBody";
            // 
            // splcBody.Panel1
            // 
            this.splcBody.Panel1.Controls.Add(this.panel1);
            this.splcBody.Panel1.Controls.Add(this.btnInsertCategory);
            this.splcBody.Panel1.Controls.Add(this.btnDeleteImage);
            this.splcBody.Panel1.Controls.Add(this.btnInsertImage);
            this.splcBody.Panel1.Controls.Add(this.btnDeleteMovie);
            this.splcBody.Panel1.Controls.Add(this.btnInsertMovie);
            this.splcBody.Panel1.Controls.Add(this.btnUpdateMovie);
            this.splcBody.Panel1.Controls.Add(this.picImageMovie);
            this.splcBody.Panel1.Controls.Add(this.lblInfoMovie);
            this.splcBody.Panel1.Controls.Add(this.dtmReleaseDate);
            this.splcBody.Panel1.Controls.Add(this.lblIDMovie);
            this.splcBody.Panel1.Controls.Add(this.txtRunningTimeMovie);
            this.splcBody.Panel1.Controls.Add(this.lblShowIDMovie);
            this.splcBody.Panel1.Controls.Add(this.txtLanguageMovie);
            this.splcBody.Panel1.Controls.Add(this.rdoInactiveMovie);
            this.splcBody.Panel1.Controls.Add(this.txtNameMovie);
            this.splcBody.Panel1.Controls.Add(this.rdoActiveMovie);
            this.splcBody.Panel1.Controls.Add(this.lblStateMovie);
            this.splcBody.Panel1.Controls.Add(this.cboCategoryMovie);
            this.splcBody.Panel1.Controls.Add(this.txtDirectorMovie);
            this.splcBody.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splcBody.Panel2
            // 
            this.splcBody.Panel2.AccessibleName = "";
            this.splcBody.Panel2.Controls.Add(this.splctnBodyRight);
            this.splcBody.Size = new System.Drawing.Size(938, 603);
            this.splcBody.SplitterDistance = 368;
            this.splcBody.TabIndex = 25;
            // 
            // btnInsertCategory
            // 
            this.btnInsertCategory.Location = new System.Drawing.Point(305, 344);
            this.btnInsertCategory.Name = "btnInsertCategory";
            this.btnInsertCategory.Size = new System.Drawing.Size(26, 23);
            this.btnInsertCategory.TabIndex = 6;
            this.btnInsertCategory.Text = "+";
            this.toolTip.SetToolTip(this.btnInsertCategory, "Nhấn vào đây để thêm, chỉnh sửa, xóa thể loại");
            this.btnInsertCategory.UseVisualStyleBackColor = true;
            this.btnInsertCategory.Click += new System.EventHandler(this.btnInsertCategory_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.btnDeleteImage.FlatAppearance.BorderSize = 0;
            this.btnDeleteImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDeleteImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteImage.Location = new System.Drawing.Point(206, 186);
            this.btnDeleteImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(87, 25);
            this.btnDeleteImage.TabIndex = 2;
            this.btnDeleteImage.Text = "Xóa hình";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.btnInsertImage.FlatAppearance.BorderSize = 0;
            this.btnInsertImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnInsertImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnInsertImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertImage.Location = new System.Drawing.Point(206, 149);
            this.btnInsertImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(87, 25);
            this.btnInsertImage.TabIndex = 1;
            this.btnInsertImage.Text = "Thêm hình";
            this.btnInsertImage.UseVisualStyleBackColor = false;
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
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
            this.splctnBodyRight.Panel1.Controls.Add(this.lblSearchFor);
            this.splctnBodyRight.Panel1.Controls.Add(this.picReload);
            this.splctnBodyRight.Panel1.Controls.Add(this.txtSearchMovie);
            this.splctnBodyRight.Panel1.Controls.Add(this.cboInfoSearchMovie);
            // 
            // splctnBodyRight.Panel2
            // 
            this.splctnBodyRight.Panel2.Controls.Add(this.dgvMovie);
            this.splctnBodyRight.Size = new System.Drawing.Size(566, 603);
            this.splctnBodyRight.SplitterDistance = 61;
            this.splctnBodyRight.TabIndex = 0;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.Location = new System.Drawing.Point(3, 23);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(85, 15);
            this.lblSearchFor.TabIndex = 5;
            this.lblSearchFor.Text = "Tìm kiếm theo";
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(522, 19);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(36, 33);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 4;
            this.picReload.TabStop = false;
            this.toolTip.SetToolTip(this.picReload, "Làm mới nội dung.");
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // cboInfoSearchMovie
            // 
            this.cboInfoSearchMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInfoSearchMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInfoSearchMovie.FormattingEnabled = true;
            this.cboInfoSearchMovie.Items.AddRange(new object[] {
            "Mã phim",
            "Tên phim",
            "Đạo diễn",
            "Thể loại",
            "Thời lượng",
            "Ngày khởi chiếu",
            "Ngôn ngữ",
            "Đang hoạt động",
            "Ngừng hoạt động"});
            this.cboInfoSearchMovie.Location = new System.Drawing.Point(94, 22);
            this.cboInfoSearchMovie.Name = "cboInfoSearchMovie";
            this.cboInfoSearchMovie.Size = new System.Drawing.Size(128, 21);
            this.cboInfoSearchMovie.TabIndex = 15;
            this.toolTip.SetToolTip(this.cboInfoSearchMovie, "Chọn trường bạn muốn tìm kiếm");
            this.cboInfoSearchMovie.SelectedIndexChanged += new System.EventHandler(this.cboInfoSearchMovie_SelectedIndexChanged);
            // 
            // dgvMovie
            // 
            this.dgvMovie.AllowUserToAddRows = false;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovie.Location = new System.Drawing.Point(0, 0);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.ReadOnly = true;
            this.dgvMovie.Size = new System.Drawing.Size(566, 538);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellClick);
            // 
            // categoryMovieTableAdapter
            // 
            this.categoryMovieTableAdapter.ClearBeforeFill = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNameMovie);
            this.panel1.Controls.Add(this.lblDirectorMovie);
            this.panel1.Controls.Add(this.lblCategoryMovie);
            this.panel1.Controls.Add(this.lblReleaseDate);
            this.panel1.Controls.Add(this.lblRunningTime);
            this.panel1.Controls.Add(this.lblLanguageMovie);
            this.panel1.Location = new System.Drawing.Point(22, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 246);
            this.panel1.TabIndex = 18;
            // 
            // lblNameMovie
            // 
            this.lblNameMovie.AutoSize = true;
            this.lblNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMovie.Location = new System.Drawing.Point(2, 25);
            this.lblNameMovie.Name = "lblNameMovie";
            this.lblNameMovie.Size = new System.Drawing.Size(54, 13);
            this.lblNameMovie.TabIndex = 17;
            this.lblNameMovie.Text = "Tên phim:";
            // 
            // lblDirectorMovie
            // 
            this.lblDirectorMovie.AutoSize = true;
            this.lblDirectorMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorMovie.Location = new System.Drawing.Point(3, 51);
            this.lblDirectorMovie.Name = "lblDirectorMovie";
            this.lblDirectorMovie.Size = new System.Drawing.Size(53, 13);
            this.lblDirectorMovie.TabIndex = 18;
            this.lblDirectorMovie.Text = "Đạo diễn:";
            // 
            // lblCategoryMovie
            // 
            this.lblCategoryMovie.AutoSize = true;
            this.lblCategoryMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryMovie.Location = new System.Drawing.Point(3, 96);
            this.lblCategoryMovie.Name = "lblCategoryMovie";
            this.lblCategoryMovie.Size = new System.Drawing.Size(48, 13);
            this.lblCategoryMovie.TabIndex = 19;
            this.lblCategoryMovie.Text = "Thể loại:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(1, 189);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(87, 13);
            this.lblReleaseDate.TabIndex = 22;
            this.lblReleaseDate.Text = "Ngày khởi chiếu:";
            // 
            // lblRunningTime
            // 
            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningTime.Location = new System.Drawing.Point(2, 140);
            this.lblRunningTime.Name = "lblRunningTime";
            this.lblRunningTime.Size = new System.Drawing.Size(60, 13);
            this.lblRunningTime.TabIndex = 20;
            this.lblRunningTime.Text = "Thời lượng:";
            // 
            // lblLanguageMovie
            // 
            this.lblLanguageMovie.AutoSize = true;
            this.lblLanguageMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguageMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageMovie.Location = new System.Drawing.Point(4, 230);
            this.lblLanguageMovie.Name = "lblLanguageMovie";
            this.lblLanguageMovie.Size = new System.Drawing.Size(57, 13);
            this.lblLanguageMovie.TabIndex = 21;
            this.lblLanguageMovie.Text = "Ngôn ngữ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // fMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(938, 603);
            this.Controls.Add(this.splcBody);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMovie";
            ((System.ComponentModel.ISupportInitialize)(this.picImageMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryMovieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDBMSDataSet)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.PictureBox picImageMovie;
        private System.Windows.Forms.Label lblInfoMovie;
        private System.Windows.Forms.Label lblIDMovie;
        private System.Windows.Forms.Label lblShowIDMovie;
        private System.Windows.Forms.TextBox txtNameMovie;
        private System.Windows.Forms.TextBox txtDirectorMovie;
        private System.Windows.Forms.ComboBox cboCategoryMovie;
        private System.Windows.Forms.Label lblStateMovie;
        private System.Windows.Forms.RadioButton rdoActiveMovie;
        private System.Windows.Forms.RadioButton rdoInactiveMovie;
        private System.Windows.Forms.TextBox txtLanguageMovie;
        private System.Windows.Forms.TextBox txtRunningTimeMovie;
        private System.Windows.Forms.DateTimePicker dtmReleaseDate;
        private System.Windows.Forms.Button btnInsertMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.SplitContainer splcBody;
        private System.Windows.Forms.SplitContainer splctnBodyRight;
        private System.Windows.Forms.ComboBox cboInfoSearchMovie;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.Button btnInsertImage;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.Button btnDeleteImage;
        private cinemaDBMSDataSet cinemaDBMSDataSet;
        private System.Windows.Forms.BindingSource categoryMovieBindingSource;
        private cinemaDBMSDataSetTableAdapters.CategoryMovieTableAdapter categoryMovieTableAdapter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnInsertCategory;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameMovie;
        private System.Windows.Forms.Label lblDirectorMovie;
        private System.Windows.Forms.Label lblCategoryMovie;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.Label lblLanguageMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}