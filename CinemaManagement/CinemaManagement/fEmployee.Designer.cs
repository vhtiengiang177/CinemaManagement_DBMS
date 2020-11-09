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
            this.plInforMain = new System.Windows.Forms.Panel();
            this.plListMain = new System.Windows.Forms.Panel();
            this.plSearch = new System.Windows.Forms.Panel();
            this.plList = new System.Windows.Forms.Panel();
            this.plControl = new System.Windows.Forms.Panel();
            this.dgvListEmployee = new System.Windows.Forms.DataGridView();
            this.plInfor = new System.Windows.Forms.Panel();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.cbmTypeSearchEmployee = new System.Windows.Forms.ComboBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnLoadListEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.plInforContact = new System.Windows.Forms.Panel();
            this.plMain.SuspendLayout();
            this.plInforMain.SuspendLayout();
            this.plListMain.SuspendLayout();
            this.plSearch.SuspendLayout();
            this.plList.SuspendLayout();
            this.plControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).BeginInit();
            this.plInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
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
            // plInforMain
            // 
            this.plInforMain.Controls.Add(this.plInforContact);
            this.plInforMain.Controls.Add(this.btnAddNewEmployee);
            this.plInforMain.Controls.Add(this.plInfor);
            this.plInforMain.Location = new System.Drawing.Point(507, 0);
            this.plInforMain.Name = "plInforMain";
            this.plInforMain.Size = new System.Drawing.Size(408, 588);
            this.plInforMain.TabIndex = 1;
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
            // plList
            // 
            this.plList.Controls.Add(this.dgvListEmployee);
            this.plList.Location = new System.Drawing.Point(4, 81);
            this.plList.Name = "plList";
            this.plList.Size = new System.Drawing.Size(496, 433);
            this.plList.TabIndex = 1;
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
            // dgvListEmployee
            // 
            this.dgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployee.Location = new System.Drawing.Point(1, 5);
            this.dgvListEmployee.Name = "dgvListEmployee";
            this.dgvListEmployee.Size = new System.Drawing.Size(495, 427);
            this.dgvListEmployee.TabIndex = 0;
            // 
            // plInfor
            // 
            this.plInfor.Controls.Add(this.picEmployee);
            this.plInfor.Location = new System.Drawing.Point(5, 50);
            this.plInfor.Name = "plInfor";
            this.plInfor.Size = new System.Drawing.Size(403, 268);
            this.plInfor.TabIndex = 0;
            // 
            // picEmployee
            // 
            this.picEmployee.Location = new System.Drawing.Point(16, 41);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(145, 164);
            this.picEmployee.TabIndex = 0;
            this.picEmployee.TabStop = false;
            // 
            // cbmTypeSearchEmployee
            // 
            this.cbmTypeSearchEmployee.FormattingEnabled = true;
            this.cbmTypeSearchEmployee.Location = new System.Drawing.Point(5, 26);
            this.cbmTypeSearchEmployee.Name = "cbmTypeSearchEmployee";
            this.cbmTypeSearchEmployee.Size = new System.Drawing.Size(95, 21);
            this.cbmTypeSearchEmployee.TabIndex = 0;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(129, 27);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(256, 20);
            this.txtSearchEmployee.TabIndex = 1;
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
            // btnLoadListEmployee
            // 
            this.btnLoadListEmployee.Location = new System.Drawing.Point(393, 3);
            this.btnLoadListEmployee.Name = "btnLoadListEmployee";
            this.btnLoadListEmployee.Size = new System.Drawing.Size(90, 58);
            this.btnLoadListEmployee.TabIndex = 1;
            this.btnLoadListEmployee.Text = "Load Data";
            this.btnLoadListEmployee.UseVisualStyleBackColor = true;
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
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(321, 7);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(80, 37);
            this.btnAddNewEmployee.TabIndex = 3;
            this.btnAddNewEmployee.Text = "Thêm nhân viên";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            // 
            // plInforContact
            // 
            this.plInforContact.Location = new System.Drawing.Point(6, 322);
            this.plInforContact.Name = "plInforContact";
            this.plInforContact.Size = new System.Drawing.Size(401, 252);
            this.plInforContact.TabIndex = 4;
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 603);
            this.Controls.Add(this.plMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEmployee";
            this.Text = "fEmployee";
            this.plMain.ResumeLayout(false);
            this.plInforMain.ResumeLayout(false);
            this.plListMain.ResumeLayout(false);
            this.plSearch.ResumeLayout(false);
            this.plSearch.PerformLayout();
            this.plList.ResumeLayout(false);
            this.plControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).EndInit();
            this.plInfor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
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
    }
}