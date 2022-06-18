
namespace CuoiKy_Winform
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.fpnlBooking = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fpnlBooking
            // 
            this.fpnlBooking.AutoScroll = true;
            this.fpnlBooking.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlBooking.Location = new System.Drawing.Point(27, 12);
            this.fpnlBooking.Name = "fpnlBooking";
            this.fpnlBooking.Size = new System.Drawing.Size(1074, 482);
            this.fpnlBooking.TabIndex = 0;
            this.fpnlBooking.WrapContents = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPayment.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(859, 506);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(242, 48);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 566);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.fpnlBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.Text = "Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Booking_Form_Closing);
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlBooking;
        private System.Windows.Forms.Button btnPayment;
    }
}