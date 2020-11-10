namespace CinemaManagement
{
    partial class fEmployee
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
            this.plMain = new System.Windows.Forms.Panel();
            this.plListMain = new System.Windows.Forms.Panel();
            this.plControl = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnLoadListEmployee = new System.Windows.Forms.Button();
            this.plList = new System.Windows.Forms.Panel();
            this.dgvListEmployee = new System.Windows.Forms.DataGridView();
            this.plSearch = new System.Windows.Forms.Panel();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.cbmTypeSearchEmployee = new System.Windows.Forms.ComboBox();
            this.plInforMain = new System.Windows.Forms.Panel();
            this.plInforContact = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.plAddress = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddressEmployee = new System.Windows.Forms.TextBox();
            this.plEmail = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailEmployee = new System.Windows.Forms.TextBox();
            this.plPhone = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneEmployee = new System.Windows.Forms.TextBox();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.plInfor = new System.Windows.Forms.Panel();
            this.plID = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.plIdentify = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndentity = new System.Windows.Forms.TextBox();
            this.plBirthDay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.plType = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.plName = new System.Windows.Forms.Panel();
            this.txtNameEmployee = new System.Windows.Forms.TextBox();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.plGender = new System.Windows.Forms.Panel();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.txtStateEmployee = new System.Windows.Forms.TextBox();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.cmbTypeEmployee = new System.Windows.Forms.ComboBox();
            this.cmbCinema = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.plMain.SuspendLayout();
            this.plListMain.SuspendLayout();
            this.plControl.SuspendLayout();
            this.plList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).BeginInit();
            this.plSearch.SuspendLayout();
            this.plInforMain.SuspendLayout();
            this.plInforContact.SuspendLayout();
            this.plAddress.SuspendLayout();
            this.plEmail.SuspendLayout();
            this.plPhone.SuspendLayout();
            this.plInfor.SuspendLayout();
            this.plID.SuspendLayout();
            this.pl.SuspendLayout();
            this.plIdentify.SuspendLayout();
            this.plBirthDay.SuspendLayout();
            this.plType.SuspendLayout();
            this.plName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.plGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.plListMain);
            this.plMain.Controls.Add(this.plInforMain);
            this.plMain.Location = new System.Drawing.Point(1, 3);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(937, 642);
            this.plMain.TabIndex = 0;
            // 
            // plListMain
            // 
            this.plListMain.Controls.Add(this.plControl);
            this.plListMain.Controls.Add(this.plList);
            this.plListMain.Controls.Add(this.plSearch);
            this.plListMain.Location = new System.Drawing.Point(3, 3);
            this.plListMain.Name = "plListMain";
            this.plListMain.Size = new System.Drawing.Size(504, 585);
            this.plListMain.TabIndex = 2;
            // 
            // plControl
            // 
            this.plControl.Controls.Add(this.btnDeleteEmployee);
            this.plControl.Controls.Add(this.btnLoadListEmployee);
            this.plControl.Location = new System.Drawing.Point(4, 520);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(495, 64);
            this.plControl.TabIndex = 2;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(297, 3);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(90, 58);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnLoadListEmployee
            // 
            this.btnLoadListEmployee.Location = new System.Drawing.Point(393, 3);
            this.btnLoadListEmployee.Name = "btnLoadListEmployee";
            this.btnLoadListEmployee.Size = new System.Drawing.Size(90, 58);
            this.btnLoadListEmployee.TabIndex = 1;
            this.btnLoadListEmployee.Text = "Load Data";
            this.btnLoadListEmployee.UseVisualStyleBackColor = true;
            this.btnLoadListEmployee.Click += new System.EventHandler(this.btnLoadListEmployee_Click);
            // 
            // plList
            // 
            this.plList.Controls.Add(this.dgvListEmployee);
            this.plList.Location = new System.Drawing.Point(4, 81);
            this.plList.Name = "plList";
            this.plList.Size = new System.Drawing.Size(496, 433);
            this.plList.TabIndex = 1;
            // 
            // dgvListEmployee
            // 
            this.dgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployee.Location = new System.Drawing.Point(1, 5);
            this.dgvListEmployee.Name = "dgvListEmployee";
            this.dgvListEmployee.Size = new System.Drawing.Size(495, 427);
            this.dgvListEmployee.TabIndex = 0;
            this.dgvListEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListEmployee_CellClick);
            // 
            // plSearch
            // 
            this.plSearch.Controls.Add(this.btnSearchEmployee);
            this.plSearch.Controls.Add(this.txtSearchEmployee);
            this.plSearch.Controls.Add(this.cbmTypeSearchEmployee);
            this.plSearch.Location = new System.Drawing.Point(3, 6);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(498, 68);
            this.plSearch.TabIndex = 0;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(404, 19);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(80, 37);
            this.btnSearchEmployee.TabIndex = 2;
            this.btnSearchEmployee.Text = "Tìm kiếm";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(129, 27);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(256, 20);
            this.txtSearchEmployee.TabIndex = 1;
            // 
            // cbmTypeSearchEmployee
            // 
            this.cbmTypeSearchEmployee.FormattingEnabled = true;
            this.cbmTypeSearchEmployee.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Số điện thoại",
            "Tên nhân viên",
            "CMND",
            "Chức vụ"});
            this.cbmTypeSearchEmployee.Location = new System.Drawing.Point(5, 26);
            this.cbmTypeSearchEmployee.Name = "cbmTypeSearchEmployee";
            this.cbmTypeSearchEmployee.Size = new System.Drawing.Size(95, 21);
            this.cbmTypeSearchEmployee.TabIndex = 0;
            // 
            // plInforMain
            // 
            this.plInforMain.Controls.Add(this.btnSave);
            this.plInforMain.Controls.Add(this.btnCancel);
            this.plInforMain.Controls.Add(this.btnEditEmployee);
            this.plInforMain.Controls.Add(this.plInforContact);
            this.plInforMain.Controls.Add(this.btnAddNewEmployee);
            this.plInforMain.Controls.Add(this.plInfor);
            this.plInforMain.Location = new System.Drawing.Point(507, 0);
            this.plInforMain.Name = "plInforMain";
            this.plInforMain.Size = new System.Drawing.Size(408, 588);
            this.plInforMain.TabIndex = 1;
            // 
            // plInforContact
            // 
            this.plInforContact.Controls.Add(this.panel1);
            this.plInforContact.Controls.Add(this.label8);
            this.plInforContact.Controls.Add(this.plAddress);
            this.plInforContact.Controls.Add(this.plEmail);
            this.plInforContact.Controls.Add(this.plPhone);
            this.plInforContact.Location = new System.Drawing.Point(6, 364);
            this.plInforContact.Name = "plInforContact";
            this.plInforContact.Size = new System.Drawing.Size(401, 210);
            this.plInforContact.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Contact:";
            // 
            // plAddress
            // 
            this.plAddress.Controls.Add(this.label7);
            this.plAddress.Controls.Add(this.txtAddressEmployee);
            this.plAddress.Location = new System.Drawing.Point(4, 133);
            this.plAddress.Name = "plAddress";
            this.plAddress.Size = new System.Drawing.Size(391, 36);
            this.plAddress.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtAddressEmployee
            // 
            this.txtAddressEmployee.Location = new System.Drawing.Point(138, 8);
            this.txtAddressEmployee.Name = "txtAddressEmployee";
            this.txtAddressEmployee.Size = new System.Drawing.Size(243, 20);
            this.txtAddressEmployee.TabIndex = 0;
            // 
            // plEmail
            // 
            this.plEmail.Controls.Add(this.label6);
            this.plEmail.Controls.Add(this.txtEmailEmployee);
            this.plEmail.Location = new System.Drawing.Point(4, 86);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(391, 41);
            this.plEmail.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email:";
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Location = new System.Drawing.Point(138, 14);
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.Size = new System.Drawing.Size(243, 20);
            this.txtEmailEmployee.TabIndex = 0;
            // 
            // plPhone
            // 
            this.plPhone.Controls.Add(this.label5);
            this.plPhone.Controls.Add(this.txtPhoneEmployee);
            this.plPhone.Location = new System.Drawing.Point(3, 37);
            this.plPhone.Name = "plPhone";
            this.plPhone.Size = new System.Drawing.Size(391, 43);
            this.plPhone.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SĐT:";
            // 
            // txtPhoneEmployee
            // 
            this.txtPhoneEmployee.Location = new System.Drawing.Point(138, 14);
            this.txtPhoneEmployee.Name = "txtPhoneEmployee";
            this.txtPhoneEmployee.Size = new System.Drawing.Size(243, 20);
            this.txtPhoneEmployee.TabIndex = 0;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(321, 7);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(80, 37);
            this.btnAddNewEmployee.TabIndex = 3;
            this.btnAddNewEmployee.Text = "Add new employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            // 
            // plInfor
            // 
            this.plInfor.Controls.Add(this.btnAddImg);
            this.plInfor.Controls.Add(this.txtStateEmployee);
            this.plInfor.Controls.Add(this.plGender);
            this.plInfor.Controls.Add(this.plID);
            this.plInfor.Controls.Add(this.pl);
            this.plInfor.Controls.Add(this.plIdentify);
            this.plInfor.Controls.Add(this.plBirthDay);
            this.plInfor.Controls.Add(this.plType);
            this.plInfor.Controls.Add(this.plName);
            this.plInfor.Controls.Add(this.picEmployee);
            this.plInfor.Location = new System.Drawing.Point(5, 50);
            this.plInfor.Name = "plInfor";
            this.plInfor.Size = new System.Drawing.Size(403, 308);
            this.plInfor.TabIndex = 0;
            // 
            // plID
            // 
            this.plID.Controls.Add(this.txtID);
            this.plID.Location = new System.Drawing.Point(18, 189);
            this.plID.Name = "plID";
            this.plID.Size = new System.Drawing.Size(142, 53);
            this.plID.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(23, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 20);
            this.txtID.TabIndex = 0;
            // 
            // pl
            // 
            this.pl.Controls.Add(this.label4);
            this.pl.Controls.Add(this.txtSalary);
            this.pl.Location = new System.Drawing.Point(165, 210);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(231, 44);
            this.pl.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lương:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(98, 13);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(122, 20);
            this.txtSalary.TabIndex = 0;
            // 
            // plIdentify
            // 
            this.plIdentify.Controls.Add(this.label3);
            this.plIdentify.Controls.Add(this.txtIndentity);
            this.plIdentify.Location = new System.Drawing.Point(165, 163);
            this.plIdentify.Name = "plIdentify";
            this.plIdentify.Size = new System.Drawing.Size(231, 44);
            this.plIdentify.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CMND:";
            // 
            // txtIndentity
            // 
            this.txtIndentity.Location = new System.Drawing.Point(98, 11);
            this.txtIndentity.Name = "txtIndentity";
            this.txtIndentity.Size = new System.Drawing.Size(122, 20);
            this.txtIndentity.TabIndex = 0;
            // 
            // plBirthDay
            // 
            this.plBirthDay.Controls.Add(this.label2);
            this.plBirthDay.Controls.Add(this.txtBirthday);
            this.plBirthDay.Location = new System.Drawing.Point(165, 113);
            this.plBirthDay.Name = "plBirthDay";
            this.plBirthDay.Size = new System.Drawing.Size(231, 44);
            this.plBirthDay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm sinh:";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(98, 13);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(122, 20);
            this.txtBirthday.TabIndex = 0;
            // 
            // plType
            // 
            this.plType.Controls.Add(this.cmbTypeEmployee);
            this.plType.Controls.Add(this.label1);
            this.plType.Location = new System.Drawing.Point(165, 68);
            this.plType.Name = "plType";
            this.plType.Size = new System.Drawing.Size(231, 44);
            this.plType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức vụ:";
            // 
            // plName
            // 
            this.plName.Controls.Add(this.txtNameEmployee);
            this.plName.Location = new System.Drawing.Point(165, 18);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(231, 44);
            this.plName.TabIndex = 1;
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Location = new System.Drawing.Point(32, 13);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(188, 20);
            this.txtNameEmployee.TabIndex = 0;
            // 
            // picEmployee
            // 
            this.picEmployee.Location = new System.Drawing.Point(16, 18);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(145, 164);
            this.picEmployee.TabIndex = 0;
            this.picEmployee.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCinema);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(4, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 36);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Rạp:";
            // 
            // plGender
            // 
            this.plGender.Controls.Add(this.rdbMale);
            this.plGender.Controls.Add(this.rdbFemale);
            this.plGender.Location = new System.Drawing.Point(165, 260);
            this.plGender.Name = "plGender";
            this.plGender.Size = new System.Drawing.Size(99, 36);
            this.plGender.TabIndex = 8;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(48, 15);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(47, 17);
            this.rdbMale.TabIndex = 1;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(3, 15);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(39, 17);
            this.rdbFemale.TabIndex = 0;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // txtStateEmployee
            // 
            this.txtStateEmployee.Location = new System.Drawing.Point(285, 272);
            this.txtStateEmployee.Name = "txtStateEmployee";
            this.txtStateEmployee.Size = new System.Drawing.Size(100, 20);
            this.txtStateEmployee.TabIndex = 9;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(235, 7);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(80, 37);
            this.btnEditEmployee.TabIndex = 5;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(41, 259);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(80, 37);
            this.btnAddImg.TabIndex = 10;
            this.btnAddImg.Text = "Thêm ảnh";
            this.btnAddImg.UseVisualStyleBackColor = true;
            // 
            // cmbTypeEmployee
            // 
            this.cmbTypeEmployee.FormattingEnabled = true;
            this.cmbTypeEmployee.Location = new System.Drawing.Point(98, 10);
            this.cmbTypeEmployee.Name = "cmbTypeEmployee";
            this.cmbTypeEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeEmployee.TabIndex = 2;
            // 
            // cmbCinema
            // 
            this.cmbCinema.FormattingEnabled = true;
            this.cmbCinema.Location = new System.Drawing.Point(137, 7);
            this.cmbCinema.Name = "cmbCinema";
            this.cmbCinema.Size = new System.Drawing.Size(233, 21);
            this.cmbCinema.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(55, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 603);
            this.Controls.Add(this.plMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fEmployee";
            this.Text = "fEmployee";
            this.plMain.ResumeLayout(false);
            this.plListMain.ResumeLayout(false);
            this.plControl.ResumeLayout(false);
            this.plList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).EndInit();
            this.plSearch.ResumeLayout(false);
            this.plSearch.PerformLayout();
            this.plInforMain.ResumeLayout(false);
            this.plInforContact.ResumeLayout(false);
            this.plInforContact.PerformLayout();
            this.plAddress.ResumeLayout(false);
            this.plAddress.PerformLayout();
            this.plEmail.ResumeLayout(false);
            this.plEmail.PerformLayout();
            this.plPhone.ResumeLayout(false);
            this.plPhone.PerformLayout();
            this.plInfor.ResumeLayout(false);
            this.plInfor.PerformLayout();
            this.plID.ResumeLayout(false);
            this.plID.PerformLayout();
            this.pl.ResumeLayout(false);
            this.pl.PerformLayout();
            this.plIdentify.ResumeLayout(false);
            this.plIdentify.PerformLayout();
            this.plBirthDay.ResumeLayout(false);
            this.plBirthDay.PerformLayout();
            this.plType.ResumeLayout(false);
            this.plType.PerformLayout();
            this.plName.ResumeLayout(false);
            this.plName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plGender.ResumeLayout(false);
            this.plGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel plListMain;
        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnLoadListEmployee;
        private System.Windows.Forms.Panel plList;
        private System.Windows.Forms.DataGridView dgvListEmployee;
        private System.Windows.Forms.Panel plSearch;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.ComboBox cbmTypeSearchEmployee;
        private System.Windows.Forms.Panel plInforMain;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Panel plInfor;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.Panel plInforContact;
        private System.Windows.Forms.Panel plID;
        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Panel plIdentify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndentity;
        private System.Windows.Forms.Panel plBirthDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Panel plType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plName;
        private System.Windows.Forms.TextBox txtNameEmployee;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel plAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddressEmployee;
        private System.Windows.Forms.Panel plEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailEmployee;
        private System.Windows.Forms.Panel plPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStateEmployee;
        private System.Windows.Forms.Panel plGender;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.ComboBox cmbTypeEmployee;
        private System.Windows.Forms.ComboBox cmbCinema;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}