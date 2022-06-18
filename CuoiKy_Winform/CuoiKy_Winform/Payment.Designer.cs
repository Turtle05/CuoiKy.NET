
namespace CuoiKy_Winform
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.fpnlPayment = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // fpnlPayment
            // 
            this.fpnlPayment.AutoScroll = true;
            this.fpnlPayment.Controls.Add(this.label1);
            this.fpnlPayment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlPayment.Location = new System.Drawing.Point(43, 29);
            this.fpnlPayment.Name = "fpnlPayment";
            this.fpnlPayment.Size = new System.Drawing.Size(858, 362);
            this.fpnlPayment.TabIndex = 1;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.fpnlPayment);
            this.Name = "Payment";
            this.Text = "Payment";
            this.fpnlPayment.ResumeLayout(false);
            this.fpnlPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fpnlPayment;
    }
}