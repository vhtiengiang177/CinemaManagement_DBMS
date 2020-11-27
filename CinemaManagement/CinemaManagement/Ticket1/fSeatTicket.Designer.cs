namespace CinemaManagement.Ticket1
{
    partial class fSeatTicket
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
            this.flpSeatTicket = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpSeatTicket
            // 
            this.flpSeatTicket.Location = new System.Drawing.Point(40, 62);
            this.flpSeatTicket.Name = "flpSeatTicket";
            this.flpSeatTicket.Size = new System.Drawing.Size(646, 333);
            this.flpSeatTicket.TabIndex = 0;
            // 
            // fSeatTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpSeatTicket);
            this.Name = "fSeatTicket";
            this.Text = "fSeatTicket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSeatTicket;
    }
}