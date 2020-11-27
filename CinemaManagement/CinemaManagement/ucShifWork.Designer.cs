namespace CinemaManagement
{
    partial class ucShifWork
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFull = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoEverning = new System.Windows.Forms.RadioButton();
            this.rdoMorning = new System.Windows.Forms.RadioButton();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkFull);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 130);
            this.panel1.TabIndex = 0;
            // 
            // chkFull
            // 
            this.chkFull.AutoSize = true;
            this.chkFull.Location = new System.Drawing.Point(8, 109);
            this.chkFull.Name = "chkFull";
            this.chkFull.Size = new System.Drawing.Size(45, 17);
            this.chkFull.TabIndex = 5;
            this.chkFull.Text = "Full ";
            this.chkFull.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoEverning);
            this.panel2.Controls.Add(this.rdoMorning);
            this.panel2.Location = new System.Drawing.Point(-1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 52);
            this.panel2.TabIndex = 4;
            // 
            // rdoEverning
            // 
            this.rdoEverning.AutoSize = true;
            this.rdoEverning.Location = new System.Drawing.Point(5, 26);
            this.rdoEverning.Name = "rdoEverning";
            this.rdoEverning.Size = new System.Drawing.Size(40, 17);
            this.rdoEverning.TabIndex = 1;
            this.rdoEverning.TabStop = true;
            this.rdoEverning.Text = "Tối";
            this.rdoEverning.UseVisualStyleBackColor = true;
            // 
            // rdoMorning
            // 
            this.rdoMorning.AutoSize = true;
            this.rdoMorning.Location = new System.Drawing.Point(5, 3);
            this.rdoMorning.Name = "rdoMorning";
            this.rdoMorning.Size = new System.Drawing.Size(50, 17);
            this.rdoMorning.TabIndex = 0;
            this.rdoMorning.TabStop = true;
            this.rdoMorning.Text = "Sáng";
            this.rdoMorning.UseVisualStyleBackColor = true;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(13, 5);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(31, 20);
            this.txtDay.TabIndex = 3;
            // 
            // ucShifWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucShifWork";
            this.Size = new System.Drawing.Size(57, 132);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkFull;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoEverning;
        private System.Windows.Forms.RadioButton rdoMorning;
        private System.Windows.Forms.TextBox txtDay;
    }
}
