namespace CinemaManagement.GUI
{
    partial class fPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPromotion));
            this.label7 = new System.Windows.Forms.Label();
            this.txtValuePromotion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObjectPromotion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamePromotion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPromotion = new System.Windows.Forms.TextBox();
            this.cboPromotion = new System.Windows.Forms.ComboBox();
            this.txtSearchPromotion = new System.Windows.Forms.TextBox();
            this.btnSearchPromotion = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPromotion = new System.Windows.Forms.DataGridView();
            this.id_promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.toolTip_start = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_End = new System.Windows.Forms.ToolTip(this.components);
            this.picReload = new System.Windows.Forms.PictureBox();
            this.dtmStart = new System.Windows.Forms.DateTimePicker();
            this.dtmEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mức khuyến mãi";
            // 
            // txtValuePromotion
            // 
            this.txtValuePromotion.Location = new System.Drawing.Point(33, 354);
            this.txtValuePromotion.Name = "txtValuePromotion";
            this.txtValuePromotion.Size = new System.Drawing.Size(245, 22);
            this.txtValuePromotion.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Đối tượng";
            // 
            // txtObjectPromotion
            // 
            this.txtObjectPromotion.Location = new System.Drawing.Point(33, 289);
            this.txtObjectPromotion.Name = "txtObjectPromotion";
            this.txtObjectPromotion.Size = new System.Drawing.Size(245, 22);
            this.txtObjectPromotion.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên chương trình";
            // 
            // txtNamePromotion
            // 
            this.txtNamePromotion.Location = new System.Drawing.Point(33, 116);
            this.txtNamePromotion.Name = "txtNamePromotion";
            this.txtNamePromotion.Size = new System.Drawing.Size(245, 22);
            this.txtNamePromotion.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã khuyến mãi";
            // 
            // txtIDPromotion
            // 
            this.txtIDPromotion.Location = new System.Drawing.Point(33, 54);
            this.txtIDPromotion.Name = "txtIDPromotion";
            this.txtIDPromotion.Size = new System.Drawing.Size(245, 22);
            this.txtIDPromotion.TabIndex = 30;
            // 
            // cboPromotion
            // 
            this.cboPromotion.AllowDrop = true;
            this.cboPromotion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPromotion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPromotion.FormattingEnabled = true;
            this.cboPromotion.Items.AddRange(new object[] {
            "Tên chương trình",
            "Đối tượng",
            "Mức khuyến mãi"});
            this.cboPromotion.Location = new System.Drawing.Point(904, 66);
            this.cboPromotion.Name = "cboPromotion";
            this.cboPromotion.Size = new System.Drawing.Size(194, 24);
            this.cboPromotion.TabIndex = 29;
            // 
            // txtSearchPromotion
            // 
            this.txtSearchPromotion.Location = new System.Drawing.Point(531, 67);
            this.txtSearchPromotion.Name = "txtSearchPromotion";
            this.txtSearchPromotion.Size = new System.Drawing.Size(367, 22);
            this.txtSearchPromotion.TabIndex = 28;
            this.txtSearchPromotion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPromotion_KeyDown);
            // 
            // btnSearchPromotion
            // 
            this.btnSearchPromotion.Location = new System.Drawing.Point(418, 57);
            this.btnSearchPromotion.Name = "btnSearchPromotion";
            this.btnSearchPromotion.Size = new System.Drawing.Size(107, 46);
            this.btnSearchPromotion.TabIndex = 27;
            this.btnSearchPromotion.Text = "Tìm kiếm";
            this.btnSearchPromotion.UseVisualStyleBackColor = true;
            this.btnSearchPromotion.Click += new System.EventHandler(this.btnSearchPromotion_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 46);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(125, 589);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 46);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 589);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 46);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Promotion";
            // 
            // dgvPromotion
            // 
            this.dgvPromotion.AllowUserToAddRows = false;
            this.dgvPromotion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromotion.BackgroundColor = System.Drawing.Color.White;
            this.dgvPromotion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_promotion,
            this.name,
            this.start,
            this.end,
            this.objects,
            this.values});
            this.dgvPromotion.GridColor = System.Drawing.SystemColors.Window;
            this.dgvPromotion.Location = new System.Drawing.Point(3, 3);
            this.dgvPromotion.Name = "dgvPromotion";
            this.dgvPromotion.ReadOnly = true;
            this.dgvPromotion.RowHeadersWidth = 51;
            this.dgvPromotion.RowTemplate.Height = 24;
            this.dgvPromotion.Size = new System.Drawing.Size(804, 568);
            this.dgvPromotion.TabIndex = 21;
            this.dgvPromotion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromotion_CellClick);
            // 
            // id_promotion
            // 
            this.id_promotion.DataPropertyName = "id_promotion";
            this.id_promotion.HeaderText = "Mã khuyến mãi";
            this.id_promotion.MinimumWidth = 6;
            this.id_promotion.Name = "id_promotion";
            this.id_promotion.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name_promotion";
            this.name.HeaderText = "Tên chương trình";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // start
            // 
            this.start.DataPropertyName = "starttime_promotion";
            this.start.HeaderText = "Thời gian bắt đầu";
            this.start.MinimumWidth = 6;
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // end
            // 
            this.end.DataPropertyName = "endtime_promotion";
            this.end.HeaderText = "Thời gian kết thúc";
            this.end.MinimumWidth = 6;
            this.end.Name = "end";
            this.end.ReadOnly = true;
            // 
            // objects
            // 
            this.objects.DataPropertyName = "object_promotion";
            this.objects.HeaderText = "Đối tượng";
            this.objects.MinimumWidth = 6;
            this.objects.Name = "objects";
            this.objects.ReadOnly = true;
            // 
            // values
            // 
            this.values.DataPropertyName = "value_promotion";
            this.values.HeaderText = "Mức khuyến mãi (%)";
            this.values.MinimumWidth = 6;
            this.values.Name = "values";
            this.values.ReadOnly = true;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(12, 641);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(107, 46);
            this.btnCancelAdd.TabIndex = 42;
            this.btnCancelAdd.Text = "Hủy thêm";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // toolTip_start
            // 
            this.toolTip_start.ShowAlways = true;
            // 
            // toolTip_End
            // 
            this.toolTip_End.ShowAlways = true;
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(1116, 57);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(36, 33);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 43;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // dtmStart
            // 
            this.dtmStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmStart.Location = new System.Drawing.Point(37, 181);
            this.dtmStart.Name = "dtmStart";
            this.dtmStart.Size = new System.Drawing.Size(241, 22);
            this.dtmStart.TabIndex = 44;
            this.dtmStart.Value = new System.DateTime(2020, 11, 23, 0, 0, 0, 0);
            // 
            // dtmEnd
            // 
            this.dtmEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmEnd.Location = new System.Drawing.Point(37, 231);
            this.dtmEnd.Name = "dtmEnd";
            this.dtmEnd.Size = new System.Drawing.Size(241, 22);
            this.dtmEnd.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Thời gian kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Thời gian bắt đầu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPromotion);
            this.panel1.Location = new System.Drawing.Point(359, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 591);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtmStart);
            this.panel2.Controls.Add(this.dtmEnd);
            this.panel2.Controls.Add(this.txtIDPromotion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNamePromotion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtValuePromotion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtObjectPromotion);
            this.panel2.Location = new System.Drawing.Point(25, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 432);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(145, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 80);
            this.panel3.TabIndex = 48;
            // 
            // fPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 740);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picReload);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.cboPromotion);
            this.Controls.Add(this.txtSearchPromotion);
            this.Controls.Add(this.btnSearchPromotion);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "fPromotion";
            this.Text = "fPromotion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValuePromotion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObjectPromotion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamePromotion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPromotion;
        private System.Windows.Forms.ComboBox cboPromotion;
        private System.Windows.Forms.TextBox txtSearchPromotion;
        private System.Windows.Forms.Button btnSearchPromotion;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPromotion;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.ToolTip toolTip_start;
        private System.Windows.Forms.ToolTip toolTip_End;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_promotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn objects;
        private System.Windows.Forms.DataGridViewTextBoxColumn values;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.DateTimePicker dtmStart;
        private System.Windows.Forms.DateTimePicker dtmEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}