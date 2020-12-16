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
            this.components = new System.ComponentModel.Container();
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
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.cboInfoSearchCaMo = new System.Windows.Forms.ComboBox();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.txtSearchCategoryMovie = new System.Windows.Forms.TextBox();
            this.dgvCategoryMovie = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splctnBody)).BeginInit();
            this.splctnBody.Panel1.SuspendLayout();
            this.splctnBody.Panel2.SuspendLayout();
            this.splctnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splctnBodyRight)).BeginInit();
            this.splctnBodyRight.Panel1.SuspendLayout();
            this.splctnBodyRight.Panel2.SuspendLayout();
            this.splctnBodyRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splctnBody
            // 
            this.splctnBody.BackColor = System.Drawing.Color.Transparent;
            this.splctnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splctnBody.Location = new System.Drawing.Point(0, 0);
            this.splctnBody.Margin = new System.Windows.Forms.Padding(2);
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
            this.splctnBody.Size = new System.Drawing.Size(860, 435);
            this.splctnBody.SplitterDistance = 341;
            this.splctnBody.SplitterWidth = 3;
            this.splctnBody.TabIndex = 0;
            // 
            // btnDeleteCategoryMovie
            // 
            this.btnDeleteCategoryMovie.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategoryMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteCategoryMovie.Location = new System.Drawing.Point(187, 125);
            this.btnDeleteCategoryMovie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteCategoryMovie.Name = "btnDeleteCategoryMovie";
            this.btnDeleteCategoryMovie.Size = new System.Drawing.Size(82, 46);
            this.btnDeleteCategoryMovie.TabIndex = 27;
            this.btnDeleteCategoryMovie.Text = "Xóa";
            this.btnDeleteCategoryMovie.UseVisualStyleBackColor = false;
            this.btnDeleteCategoryMovie.Click += new System.EventHandler(this.btnDeleteCategoryMovie_Click);
            // 
            // btnInsertCategoryMovie
            // 
            this.btnInsertCategoryMovie.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsertCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCategoryMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsertCategoryMovie.Location = new System.Drawing.Point(10, 125);
            this.btnInsertCategoryMovie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInsertCategoryMovie.Name = "btnInsertCategoryMovie";
            this.btnInsertCategoryMovie.Size = new System.Drawing.Size(70, 46);
            this.btnInsertCategoryMovie.TabIndex = 25;
            this.btnInsertCategoryMovie.Text = "Thêm";
            this.btnInsertCategoryMovie.UseVisualStyleBackColor = false;
            this.btnInsertCategoryMovie.Click += new System.EventHandler(this.btnInsertCategoryMovie_Click);
            // 
            // btnUpdateCategoryMovie
            // 
            this.btnUpdateCategoryMovie.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategoryMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateCategoryMovie.Location = new System.Drawing.Point(94, 125);
            this.btnUpdateCategoryMovie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateCategoryMovie.Name = "btnUpdateCategoryMovie";
            this.btnUpdateCategoryMovie.Size = new System.Drawing.Size(76, 46);
            this.btnUpdateCategoryMovie.TabIndex = 26;
            this.btnUpdateCategoryMovie.Text = "Sửa";
            this.btnUpdateCategoryMovie.UseVisualStyleBackColor = false;
            this.btnUpdateCategoryMovie.Click += new System.EventHandler(this.btnUpdateCategoryMovie_Click);
            // 
            // txtNameCategoryMovie
            // 
            this.txtNameCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategoryMovie.Location = new System.Drawing.Point(118, 80);
            this.txtNameCategoryMovie.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameCategoryMovie.Name = "txtNameCategoryMovie";
            this.txtNameCategoryMovie.Size = new System.Drawing.Size(163, 23);
            this.txtNameCategoryMovie.TabIndex = 4;
            // 
            // lblNameCategoryMovie
            // 
            this.lblNameCategoryMovie.AutoSize = true;
            this.lblNameCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategoryMovie.Location = new System.Drawing.Point(15, 83);
            this.lblNameCategoryMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCategoryMovie.Name = "lblNameCategoryMovie";
            this.lblNameCategoryMovie.Size = new System.Drawing.Size(87, 17);
            this.lblNameCategoryMovie.TabIndex = 3;
            this.lblNameCategoryMovie.Text = "Tên thể loại:";
            // 
            // lblShowIDCategoryMovie
            // 
            this.lblShowIDCategoryMovie.AutoSize = true;
            this.lblShowIDCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowIDCategoryMovie.Location = new System.Drawing.Point(77, 55);
            this.lblShowIDCategoryMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowIDCategoryMovie.Name = "lblShowIDCategoryMovie";
            this.lblShowIDCategoryMovie.Size = new System.Drawing.Size(79, 17);
            this.lblShowIDCategoryMovie.TabIndex = 2;
            this.lblShowIDCategoryMovie.Text = "ma-the-loai";
            // 
            // lblIDCategoryMovie
            // 
            this.lblIDCategoryMovie.AutoSize = true;
            this.lblIDCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategoryMovie.Location = new System.Drawing.Point(19, 55);
            this.lblIDCategoryMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDCategoryMovie.Name = "lblIDCategoryMovie";
            this.lblIDCategoryMovie.Size = new System.Drawing.Size(81, 17);
            this.lblIDCategoryMovie.TabIndex = 1;
            this.lblIDCategoryMovie.Text = "Mã thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỂ LOẠI PHIM";
            // 
            // splctnBodyRight
            // 
            this.splctnBodyRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splctnBodyRight.Location = new System.Drawing.Point(0, 0);
            this.splctnBodyRight.Margin = new System.Windows.Forms.Padding(2);
            this.splctnBodyRight.Name = "splctnBodyRight";
            this.splctnBodyRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splctnBodyRight.Panel1
            // 
            this.splctnBodyRight.Panel1.Controls.Add(this.lblSearchFor);
            this.splctnBodyRight.Panel1.Controls.Add(this.cboInfoSearchCaMo);
            this.splctnBodyRight.Panel1.Controls.Add(this.picReload);
            this.splctnBodyRight.Panel1.Controls.Add(this.txtSearchCategoryMovie);
            // 
            // splctnBodyRight.Panel2
            // 
            this.splctnBodyRight.Panel2.Controls.Add(this.dgvCategoryMovie);
            this.splctnBodyRight.Size = new System.Drawing.Size(516, 435);
            this.splctnBodyRight.SplitterDistance = 61;
            this.splctnBodyRight.SplitterWidth = 3;
            this.splctnBodyRight.TabIndex = 0;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(4, 16);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(96, 17);
            this.lblSearchFor.TabIndex = 30;
            this.lblSearchFor.Text = "Tìm kiếm theo";
            // 
            // cboInfoSearchCaMo
            // 
            this.cboInfoSearchCaMo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInfoSearchCaMo.FormattingEnabled = true;
            this.cboInfoSearchCaMo.Items.AddRange(new object[] {
            "Mã thể loại",
            "Tên thể loại"});
            this.cboInfoSearchCaMo.Location = new System.Drawing.Point(106, 16);
            this.cboInfoSearchCaMo.Name = "cboInfoSearchCaMo";
            this.cboInfoSearchCaMo.Size = new System.Drawing.Size(131, 25);
            this.cboInfoSearchCaMo.TabIndex = 29;
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(462, 16);
            this.picReload.Margin = new System.Windows.Forms.Padding(2);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(27, 25);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 28;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // txtSearchCategoryMovie
            // 
            this.txtSearchCategoryMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategoryMovie.Location = new System.Drawing.Point(252, 16);
            this.txtSearchCategoryMovie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchCategoryMovie.Name = "txtSearchCategoryMovie";
            this.txtSearchCategoryMovie.Size = new System.Drawing.Size(182, 23);
            this.txtSearchCategoryMovie.TabIndex = 5;
            this.txtSearchCategoryMovie.TextChanged += new System.EventHandler(this.txtSearchCategoryMovie_TextChanged);
            // 
            // dgvCategoryMovie
            // 
            this.dgvCategoryMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoryMovie.Location = new System.Drawing.Point(0, 0);
            this.dgvCategoryMovie.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategoryMovie.Name = "dgvCategoryMovie";
            this.dgvCategoryMovie.RowHeadersWidth = 51;
            this.dgvCategoryMovie.Size = new System.Drawing.Size(516, 371);
            this.dgvCategoryMovie.TabIndex = 0;
            this.dgvCategoryMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryMovie_CellClick);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            // 
            // fCategoryMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 435);
            this.Controls.Add(this.splctnBody);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fCategoryMovie";
            this.Text = "Thể loại phim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fCategoryMovie_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCategoryMovie;
        private System.Windows.Forms.TextBox txtSearchCategoryMovie;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.ComboBox cboInfoSearchCaMo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
    }
}