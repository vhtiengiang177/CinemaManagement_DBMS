﻿
namespace CinemaManagement.GUI
{
    partial class fChangeAccount
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ckbShowAgainPass = new System.Windows.Forms.CheckBox();
            this.ckbShowNewPass = new System.Windows.Forms.CheckBox();
            this.ckShowPassOld = new System.Windows.Forms.CheckBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtAgainPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlMain.Controls.Add(this.ckbShowAgainPass);
            this.pnlMain.Controls.Add(this.ckbShowNewPass);
            this.pnlMain.Controls.Add(this.ckShowPassOld);
            this.pnlMain.Controls.Add(this.btnHuy);
            this.pnlMain.Controls.Add(this.btnCapNhat);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.txtTDN);
            this.pnlMain.Controls.Add(this.txtAgainPass);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtPassW);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtNewPass);
            this.pnlMain.Location = new System.Drawing.Point(2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(456, 265);
            this.pnlMain.TabIndex = 1;
            // 
            // ckbShowAgainPass
            // 
            this.ckbShowAgainPass.AutoSize = true;
            this.ckbShowAgainPass.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowAgainPass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ckbShowAgainPass.Location = new System.Drawing.Point(362, 146);
            this.ckbShowAgainPass.Margin = new System.Windows.Forms.Padding(2);
            this.ckbShowAgainPass.Name = "ckbShowAgainPass";
            this.ckbShowAgainPass.Size = new System.Drawing.Size(52, 20);
            this.ckbShowAgainPass.TabIndex = 38;
            this.ckbShowAgainPass.Text = "Hiện";
            this.ckbShowAgainPass.UseVisualStyleBackColor = true;
            this.ckbShowAgainPass.CheckedChanged += new System.EventHandler(this.ckbShowAgainPass_CheckedChanged);
            // 
            // ckbShowNewPass
            // 
            this.ckbShowNewPass.AutoSize = true;
            this.ckbShowNewPass.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowNewPass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ckbShowNewPass.Location = new System.Drawing.Point(362, 115);
            this.ckbShowNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.ckbShowNewPass.Name = "ckbShowNewPass";
            this.ckbShowNewPass.Size = new System.Drawing.Size(52, 20);
            this.ckbShowNewPass.TabIndex = 37;
            this.ckbShowNewPass.Text = "Hiện";
            this.ckbShowNewPass.UseVisualStyleBackColor = true;
            this.ckbShowNewPass.CheckedChanged += new System.EventHandler(this.ckbShowNewPass_CheckedChanged);
            // 
            // ckShowPassOld
            // 
            this.ckShowPassOld.AutoSize = true;
            this.ckShowPassOld.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckShowPassOld.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ckShowPassOld.Location = new System.Drawing.Point(362, 84);
            this.ckShowPassOld.Margin = new System.Windows.Forms.Padding(2);
            this.ckShowPassOld.Name = "ckShowPassOld";
            this.ckShowPassOld.Size = new System.Drawing.Size(52, 20);
            this.ckShowPassOld.TabIndex = 36;
            this.ckShowPassOld.Text = "Hiện";
            this.ckShowPassOld.UseVisualStyleBackColor = true;
            this.ckShowPassOld.CheckedChanged += new System.EventHandler(this.ckShowPassOld_CheckedChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Coral;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHuy.Location = new System.Drawing.Point(329, 186);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 28);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Coral;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCapNhat.Location = new System.Drawing.Point(230, 186);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 28);
            this.btnCapNhat.TabIndex = 34;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(28, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tên Đăng Nhập";
            // 
            // txtTDN
            // 
            this.txtTDN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDN.Location = new System.Drawing.Point(160, 51);
            this.txtTDN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.ReadOnly = true;
            this.txtTDN.Size = new System.Drawing.Size(189, 25);
            this.txtTDN.TabIndex = 32;
            // 
            // txtAgainPass
            // 
            this.txtAgainPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgainPass.Location = new System.Drawing.Point(160, 142);
            this.txtAgainPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgainPass.Name = "txtAgainPass";
            this.txtAgainPass.Size = new System.Drawing.Size(189, 25);
            this.txtAgainPass.TabIndex = 31;
            this.txtAgainPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(28, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtPassW
            // 
            this.txtPassW.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassW.Location = new System.Drawing.Point(160, 84);
            this.txtPassW.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassW.Name = "txtPassW";
            this.txtPassW.Size = new System.Drawing.Size(189, 25);
            this.txtPassW.TabIndex = 29;
            this.txtPassW.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mật khẩu";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(160, 114);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(189, 25);
            this.txtNewPass.TabIndex = 26;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // fChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 271);
            this.Controls.Add(this.pnlMain);
            this.Name = "fChangeAccount";
            this.Text = "changeAccount";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckBox ckbShowAgainPass;
        private System.Windows.Forms.CheckBox ckbShowNewPass;
        private System.Windows.Forms.CheckBox ckShowPassOld;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtAgainPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
    }
}