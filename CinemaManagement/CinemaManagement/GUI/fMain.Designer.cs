namespace CinemaManagement.GUI
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trpHome_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.trpEmployeeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.trgEmpManager = new System.Windows.Forms.ToolStripMenuItem();
            this.trgShiftManager = new System.Windows.Forms.ToolStripMenuItem();
            this.trpCustomerManager = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trpFilmManager = new System.Windows.Forms.ToolStripMenuItem();
            this.trpFilmCategoryManager = new System.Windows.Forms.ToolStripMenuItem();
            this.trpShowTimeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.trpPromotionManager = new System.Windows.Forms.ToolStripMenuItem();
            this.trpSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.trgCinemaManager = new System.Windows.Forms.ToolStripMenuItem();
            this.plOpenChildForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbNameEmployeeMain = new System.Windows.Forms.Label();
            this.lbIdEmployeeMain = new System.Windows.Forms.Label();
            this.lbChangeAccount = new System.Windows.Forms.Label();
            this.picEmployeeMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trpHome_Order,
            this.trpEmployeeManager,
            this.trpCustomerManager,
            this.quảnLýPhimToolStripMenuItem,
            this.trpPromotionManager,
            this.trpSatis,
            this.trgCinemaManager});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1488, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trpHome_Order
            // 
            this.trpHome_Order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trpHome_Order.Name = "trpHome_Order";
            this.trpHome_Order.Size = new System.Drawing.Size(100, 27);
            this.trpHome_Order.Text = "Trang chủ";
            this.trpHome_Order.Click += new System.EventHandler(this.trpHome_Order_Click);
            // 
            // trpEmployeeManager
            // 
            this.trpEmployeeManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trgEmpManager,
            this.trgShiftManager});
            this.trpEmployeeManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trpEmployeeManager.Name = "trpEmployeeManager";
            this.trpEmployeeManager.Size = new System.Drawing.Size(163, 27);
            this.trpEmployeeManager.Text = "Quản lý nhân viên";
            // 
            // trgEmpManager
            // 
            this.trgEmpManager.Name = "trgEmpManager";
            this.trgEmpManager.Size = new System.Drawing.Size(233, 28);
            this.trgEmpManager.Text = "Quản lý nhân viên";
            this.trgEmpManager.Click += new System.EventHandler(this.trgEmpManager_Click);
            // 
            // trgShiftManager
            // 
            this.trgShiftManager.Name = "trgShiftManager";
            this.trgShiftManager.Size = new System.Drawing.Size(233, 28);
            this.trgShiftManager.Text = "Xếp ca làm việc";
            this.trgShiftManager.Click += new System.EventHandler(this.trgShiftManager_Click);
            // 
            // trpCustomerManager
            // 
            this.trpCustomerManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trpCustomerManager.Name = "trpCustomerManager";
            this.trpCustomerManager.Size = new System.Drawing.Size(177, 27);
            this.trpCustomerManager.Text = "Quản lý khách hàng";
            this.trpCustomerManager.Click += new System.EventHandler(this.trpCustomerManager_Click);
            // 
            // quảnLýPhimToolStripMenuItem
            // 
            this.quảnLýPhimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trpFilmManager,
            this.trpFilmCategoryManager,
            this.trpShowTimeManager});
            this.quảnLýPhimToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quảnLýPhimToolStripMenuItem.Name = "quảnLýPhimToolStripMenuItem";
            this.quảnLýPhimToolStripMenuItem.Size = new System.Drawing.Size(127, 27);
            this.quảnLýPhimToolStripMenuItem.Text = "Quản lý phim";
            // 
            // trpFilmManager
            // 
            this.trpFilmManager.Name = "trpFilmManager";
            this.trpFilmManager.Size = new System.Drawing.Size(229, 28);
            this.trpFilmManager.Text = "Quản lý phim";
            this.trpFilmManager.Click += new System.EventHandler(this.trpFilmManager_Click);
            // 
            // trpFilmCategoryManager
            // 
            this.trpFilmCategoryManager.Name = "trpFilmCategoryManager";
            this.trpFilmCategoryManager.Size = new System.Drawing.Size(229, 28);
            this.trpFilmCategoryManager.Text = "Quản lý loại phim";
            this.trpFilmCategoryManager.Click += new System.EventHandler(this.trpFilmCategoryManager_Click);
            // 
            // trpShowTimeManager
            // 
            this.trpShowTimeManager.Name = "trpShowTimeManager";
            this.trpShowTimeManager.Size = new System.Drawing.Size(229, 28);
            this.trpShowTimeManager.Text = "Xếp lịch chiếu";
            this.trpShowTimeManager.Click += new System.EventHandler(this.trpShowTimeManager_Click);
            // 
            // trpPromotionManager
            // 
            this.trpPromotionManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trpPromotionManager.Name = "trpPromotionManager";
            this.trpPromotionManager.Size = new System.Drawing.Size(176, 27);
            this.trpPromotionManager.Text = "Quản lý khuyến mãi";
            this.trpPromotionManager.Click += new System.EventHandler(this.trpPromotionManager_Click);
            // 
            // trpSatis
            // 
            this.trpSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trpSatis.Name = "trpSatis";
            this.trpSatis.Size = new System.Drawing.Size(95, 27);
            this.trpSatis.Text = "Thống kê";
            this.trpSatis.Click += new System.EventHandler(this.trpSatis_Click);
            // 
            // trgCinemaManager
            // 
            this.trgCinemaManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trgCinemaManager.Name = "trgCinemaManager";
            this.trgCinemaManager.Size = new System.Drawing.Size(113, 27);
            this.trgCinemaManager.Text = "Quản lý rạp";
            this.trgCinemaManager.Click += new System.EventHandler(this.trgCinemaManager_Click);
            // 
            // plOpenChildForm
            // 
            this.plOpenChildForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plOpenChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.plOpenChildForm.Location = new System.Drawing.Point(260, 31);
            this.plOpenChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.plOpenChildForm.MaximumSize = new System.Drawing.Size(1228, 841);
            this.plOpenChildForm.MinimumSize = new System.Drawing.Size(1228, 841);
            this.plOpenChildForm.Name = "plOpenChildForm";
            this.plOpenChildForm.Size = new System.Drawing.Size(1228, 841);
            this.plOpenChildForm.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lbLogout);
            this.panel2.Controls.Add(this.lbNameEmployeeMain);
            this.panel2.Controls.Add(this.lbIdEmployeeMain);
            this.panel2.Controls.Add(this.lbChangeAccount);
            this.panel2.Controls.Add(this.picEmployeeMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 827);
            this.panel2.TabIndex = 0;
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.DarkGray;
            this.lbLogout.Location = new System.Drawing.Point(80, 740);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(84, 20);
            this.lbLogout.TabIndex = 6;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbNameEmployeeMain
            // 
            this.lbNameEmployeeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameEmployeeMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNameEmployeeMain.Location = new System.Drawing.Point(8, 292);
            this.lbNameEmployeeMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameEmployeeMain.Name = "lbNameEmployeeMain";
            this.lbNameEmployeeMain.Size = new System.Drawing.Size(255, 33);
            this.lbNameEmployeeMain.TabIndex = 5;
            this.lbNameEmployeeMain.Text = "Name";
            this.lbNameEmployeeMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIdEmployeeMain
            // 
            this.lbIdEmployeeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEmployeeMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIdEmployeeMain.Location = new System.Drawing.Point(4, 245);
            this.lbIdEmployeeMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdEmployeeMain.Name = "lbIdEmployeeMain";
            this.lbIdEmployeeMain.Size = new System.Drawing.Size(252, 28);
            this.lbIdEmployeeMain.TabIndex = 4;
            this.lbIdEmployeeMain.Text = "ID";
            this.lbIdEmployeeMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChangeAccount
            // 
            this.lbChangeAccount.AutoSize = true;
            this.lbChangeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeAccount.ForeColor = System.Drawing.Color.DarkGray;
            this.lbChangeAccount.Location = new System.Drawing.Point(62, 705);
            this.lbChangeAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChangeAccount.Name = "lbChangeAccount";
            this.lbChangeAccount.Size = new System.Drawing.Size(144, 20);
            this.lbChangeAccount.TabIndex = 3;
            this.lbChangeAccount.Text = "Thay đổi tài khoản";
            this.lbChangeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbChangeAccount.Click += new System.EventHandler(this.lbChangeAccount_Click);
            // 
            // picEmployeeMain
            // 
            this.picEmployeeMain.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picEmployeeMain.ErrorImage")));
            this.picEmployeeMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("picEmployeeMain.InitialImage")));
            this.picEmployeeMain.Location = new System.Drawing.Point(31, 27);
            this.picEmployeeMain.Margin = new System.Windows.Forms.Padding(4);
            this.picEmployeeMain.Name = "picEmployeeMain";
            this.picEmployeeMain.Size = new System.Drawing.Size(201, 214);
            this.picEmployeeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmployeeMain.TabIndex = 0;
            this.picEmployeeMain.TabStop = false;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 858);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plOpenChildForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1506, 905);
            this.MinimumSize = new System.Drawing.Size(1506, 883);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rạp chiếu phim BYTG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trpHome_Order;
        private System.Windows.Forms.Panel plOpenChildForm;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picEmployeeMain;
        private System.Windows.Forms.Label lbChangeAccount;
        private System.Windows.Forms.Label lbNameEmployeeMain;
        private System.Windows.Forms.Label lbIdEmployeeMain;
        private System.Windows.Forms.ToolStripMenuItem trpEmployeeManager;
        private System.Windows.Forms.ToolStripMenuItem trpCustomerManager;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trpFilmManager;
        private System.Windows.Forms.ToolStripMenuItem trpFilmCategoryManager;
        private System.Windows.Forms.ToolStripMenuItem trpShowTimeManager;
        private System.Windows.Forms.ToolStripMenuItem trpPromotionManager;
        private System.Windows.Forms.ToolStripMenuItem trpSatis;
        private System.Windows.Forms.ToolStripMenuItem trgCinemaManager;
        private System.Windows.Forms.ToolStripMenuItem trgEmpManager;
        private System.Windows.Forms.ToolStripMenuItem trgShiftManager;
        private System.Windows.Forms.Label lbLogout;
    }
}

