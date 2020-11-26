namespace CinemaManagement.Ticket1
{
    partial class fShowtimesTicket
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
            this.lbTenPhim = new System.Windows.Forms.Label();
            this.flpShowtimesTicket = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbTenPhim
            // 
            this.lbTenPhim.AutoSize = true;
            this.lbTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhim.Location = new System.Drawing.Point(24, 9);
            this.lbTenPhim.Name = "lbTenPhim";
            this.lbTenPhim.Size = new System.Drawing.Size(64, 25);
            this.lbTenPhim.TabIndex = 0;
            this.lbTenPhim.Text = "label1";
            // 
            // flpShowtimesTicket
            // 
            this.flpShowtimesTicket.Location = new System.Drawing.Point(55, 82);
            this.flpShowtimesTicket.Name = "flpShowtimesTicket";
            this.flpShowtimesTicket.Size = new System.Drawing.Size(635, 444);
            this.flpShowtimesTicket.TabIndex = 1;
            // 
            // fShowtimesTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 571);
            this.Controls.Add(this.flpShowtimesTicket);
            this.Controls.Add(this.lbTenPhim);
            this.Name = "fShowtimesTicket";
            this.Text = "fShowtimesTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenPhim;
        private System.Windows.Forms.FlowLayoutPanel flpShowtimesTicket;
    }
}