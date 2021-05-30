namespace CinemaManagement.GUI
{
    partial class fEmployee_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployee_New));
            this.cboTypeSearchEmployee = new System.Windows.Forms.ComboBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.dgvListEmployee = new System.Windows.Forms.DataGridView();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTypeEmployee = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpkBirthDateEmp = new System.Windows.Forms.DateTimePicker();
            this.txtIndentity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnGender = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCinema = new System.Windows.Forms.ComboBox();
            this.txtAddressEmployee = new System.Windows.Forms.TextBox();
            this.txtEmailEmployee = new System.Windows.Forms.TextBox();
            this.txtPhoneEmployee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSortTypeEmployee = new System.Windows.Forms.ComboBox();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.rdoInactive = new System.Windows.Forms.RadioButton();
            this.pnState = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.pnGender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.pnState.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTypeSearchEmployee
            // 
            this.cboTypeSearchEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeSearchEmployee.FormattingEnabled = true;
            this.cboTypeSearchEmployee.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên",
            "Số điện thoại",
            "CMND"});
            this.cboTypeSearchEmployee.Location = new System.Drawing.Point(41, 23);
            this.cboTypeSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cboTypeSearchEmployee.Name = "cboTypeSearchEmployee";
            this.cboTypeSearchEmployee.Size = new System.Drawing.Size(186, 30);
            this.cboTypeSearchEmployee.TabIndex = 1;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(249, 26);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(553, 30);
            this.txtSearchEmployee.TabIndex = 2;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // dgvListEmployee
            // 
            this.dgvListEmployee.AllowUserToAddRows = false;
            this.dgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployee.Location = new System.Drawing.Point(24, 67);
            this.dgvListEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListEmployee.Name = "dgvListEmployee";
            this.dgvListEmployee.ReadOnly = true;
            this.dgvListEmployee.RowHeadersWidth = 82;
            this.dgvListEmployee.RowTemplate.Height = 33;
            this.dgvListEmployee.Size = new System.Drawing.Size(846, 746);
            this.dgvListEmployee.TabIndex = 3;
            this.dgvListEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListEmployee_CellClick);
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Location = new System.Drawing.Point(1159, 759);
            this.btnInsertEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(92, 55);
            this.btnInsertEmployee.TabIndex = 4;
            this.btnInsertEmployee.Text = "Thêm";
            this.btnInsertEmployee.UseVisualStyleBackColor = true;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(1262, 759);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(90, 55);
            this.btnUpdateEmployee.TabIndex = 5;
            this.btnUpdateEmployee.Text = "Sửa";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.BackColor = System.Drawing.Color.Transparent;
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picEmployee.ErrorImage")));
            this.picEmployee.Image = ((System.Drawing.Image)(resources.GetObject("picEmployee.Image")));
            this.picEmployee.InitialImage = ((System.Drawing.Image)(resources.GetObject("picEmployee.InitialImage")));
            this.picEmployee.Location = new System.Drawing.Point(13, 72);
            this.picEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(159, 205);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmployee.TabIndex = 8;
            this.picEmployee.TabStop = false;
            this.picEmployee.DoubleClick += new System.EventHandler(this.picEmployee_DoubleClick);
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEmployee.Location = new System.Drawing.Point(270, 160);
            this.txtNameEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(146, 28);
            this.txtNameEmployee.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên:";
            // 
            // cboTypeEmployee
            // 
            this.cboTypeEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeEmployee.FormattingEnabled = true;
            this.cboTypeEmployee.Location = new System.Drawing.Point(186, 72);
            this.cboTypeEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cboTypeEmployee.Name = "cboTypeEmployee";
            this.cboTypeEmployee.Size = new System.Drawing.Size(253, 33);
            this.cboTypeEmployee.TabIndex = 11;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(269, 122);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(64, 22);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "em001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "D.O.B:";
            // 
            // dpkBirthDateEmp
            // 
            this.dpkBirthDateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkBirthDateEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkBirthDateEmp.Location = new System.Drawing.Point(269, 198);
            this.dpkBirthDateEmp.Margin = new System.Windows.Forms.Padding(2);
            this.dpkBirthDateEmp.Name = "dpkBirthDateEmp";
            this.dpkBirthDateEmp.Size = new System.Drawing.Size(147, 28);
            this.dpkBirthDateEmp.TabIndex = 14;
            this.dpkBirthDateEmp.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // txtIndentity
            // 
            this.txtIndentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndentity.Location = new System.Drawing.Point(269, 237);
            this.txtIndentity.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndentity.Name = "txtIndentity";
            this.txtIndentity.Size = new System.Drawing.Size(149, 28);
            this.txtIndentity.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "CMND:";
            // 
            // pnGender
            // 
            this.pnGender.Controls.Add(this.rdoFemale);
            this.pnGender.Controls.Add(this.rdoMale);
            this.pnGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnGender.Location = new System.Drawing.Point(273, 278);
            this.pnGender.Margin = new System.Windows.Forms.Padding(2);
            this.pnGender.Name = "pnGender";
            this.pnGender.Size = new System.Drawing.Size(165, 34);
            this.pnGender.TabIndex = 18;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(87, 2);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(58, 26);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(2, 2);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(72, 26);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giới tính:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 39);
            this.panel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "LIÊN HỆ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbCinema);
            this.panel3.Controls.Add(this.txtAddressEmployee);
            this.panel3.Controls.Add(this.txtEmailEmployee);
            this.panel3.Controls.Add(this.txtPhoneEmployee);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(895, 535);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 206);
            this.panel3.TabIndex = 21;
            // 
            // cmbCinema
            // 
            this.cmbCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCinema.FormattingEnabled = true;
            this.cmbCinema.Location = new System.Drawing.Point(99, 152);
            this.cmbCinema.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinema.Name = "cmbCinema";
            this.cmbCinema.Size = new System.Drawing.Size(312, 30);
            this.cmbCinema.TabIndex = 26;
            // 
            // txtAddressEmployee
            // 
            this.txtAddressEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressEmployee.Location = new System.Drawing.Point(99, 117);
            this.txtAddressEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressEmployee.Name = "txtAddressEmployee";
            this.txtAddressEmployee.Size = new System.Drawing.Size(312, 28);
            this.txtAddressEmployee.TabIndex = 27;
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmployee.Location = new System.Drawing.Point(99, 82);
            this.txtEmailEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.Size = new System.Drawing.Size(312, 28);
            this.txtEmailEmployee.TabIndex = 26;
            // 
            // txtPhoneEmployee
            // 
            this.txtPhoneEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneEmployee.Location = new System.Drawing.Point(99, 47);
            this.txtPhoneEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneEmployee.Name = "txtPhoneEmployee";
            this.txtPhoneEmployee.Size = new System.Drawing.Size(312, 28);
            this.txtPhoneEmployee.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rạp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Điện thoại:";
            // 
            // cboSortTypeEmployee
            // 
            this.cboSortTypeEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortTypeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortTypeEmployee.FormattingEnabled = true;
            this.cboSortTypeEmployee.Location = new System.Drawing.Point(895, 21);
            this.cboSortTypeEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cboSortTypeEmployee.Name = "cboSortTypeEmployee";
            this.cboSortTypeEmployee.Size = new System.Drawing.Size(457, 33);
            this.cboSortTypeEmployee.TabIndex = 23;
            this.cboSortTypeEmployee.SelectedIndexChanged += new System.EventHandler(this.cboSortTypeEmployee_SelectedIndexChanged);
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(815, 23);
            this.picReload.Margin = new System.Windows.Forms.Padding(2);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(37, 38);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 25;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.Location = new System.Drawing.Point(41, 281);
            this.btnDeleteImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(97, 49);
            this.btnDeleteImage.TabIndex = 26;
            this.btnDeleteImage.Text = "Xóa hình";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã NV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(197, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Lương:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // numSalary
            // 
            this.numSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSalary.Location = new System.Drawing.Point(271, 317);
            this.numSalary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(147, 28);
            this.numSalary.TabIndex = 32;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Location = new System.Drawing.Point(116, 5);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(118, 26);
            this.rdoActive.TabIndex = 0;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Hoạt động";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "Trạng thái:";
            // 
            // rdoInactive
            // 
            this.rdoInactive.AutoSize = true;
            this.rdoInactive.Location = new System.Drawing.Point(239, 5);
            this.rdoInactive.Name = "rdoInactive";
            this.rdoInactive.Size = new System.Drawing.Size(173, 26);
            this.rdoInactive.TabIndex = 1;
            this.rdoInactive.TabStop = true;
            this.rdoInactive.Text = "Ngưng hoạt động";
            this.rdoInactive.UseVisualStyleBackColor = true;
            // 
            // pnState
            // 
            this.pnState.Controls.Add(this.rdoInactive);
            this.pnState.Controls.Add(this.label12);
            this.pnState.Controls.Add(this.rdoActive);
            this.pnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnState.Location = new System.Drawing.Point(13, 384);
            this.pnState.Name = "pnState";
            this.pnState.Size = new System.Drawing.Size(437, 34);
            this.pnState.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnState);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picEmployee);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.btnDeleteImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboTypeEmployee);
            this.panel1.Controls.Add(this.numSalary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNameEmployee);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dpkBirthDateEmp);
            this.panel1.Controls.Add(this.txtIndentity);
            this.panel1.Controls.Add(this.pnGender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(895, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 433);
            this.panel1.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 39);
            this.panel4.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(6, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // fEmployee_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 987);
            this.Controls.Add(this.picReload);
            this.Controls.Add(this.cboSortTypeEmployee);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnInsertEmployee);
            this.Controls.Add(this.dgvListEmployee);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.cboTypeSearchEmployee);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fEmployee_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.pnGender.ResumeLayout(false);
            this.pnGender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.pnState.ResumeLayout(false);
            this.pnState.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTypeSearchEmployee;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.DataGridView dgvListEmployee;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTypeEmployee;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpkBirthDateEmp;
        private System.Windows.Forms.TextBox txtIndentity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddressEmployee;
        private System.Windows.Forms.TextBox txtEmailEmployee;
        private System.Windows.Forms.ComboBox cboSortTypeEmployee;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.ComboBox cmbCinema;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Panel pnState;
        private System.Windows.Forms.RadioButton rdoInactive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdoActive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
    }
}