
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
            this.lbBooking = new System.Windows.Forms.Label();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.cbTatCa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fpnlBooking
            // 
            this.fpnlBooking.AutoScroll = true;
            this.fpnlBooking.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlBooking.Location = new System.Drawing.Point(27, 75);
            this.fpnlBooking.Name = "fpnlBooking";
            this.fpnlBooking.Size = new System.Drawing.Size(1159, 539);
            this.fpnlBooking.TabIndex = 0;
            this.fpnlBooking.WrapContents = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPayment.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(918, 635);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(268, 48);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lbBooking
            // 
            this.lbBooking.AutoSize = true;
            this.lbBooking.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbBooking.Location = new System.Drawing.Point(19, 3);
            this.lbBooking.Name = "lbBooking";
            this.lbBooking.Size = new System.Drawing.Size(150, 46);
            this.lbBooking.TabIndex = 2;
            this.lbBooking.Text = "Booking";
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluong.Location = new System.Drawing.Point(1027, 33);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(0, 26);
            this.lbSoluong.TabIndex = 3;
            // 
            // cbTatCa
            // 
            this.cbTatCa.AutoSize = true;
            this.cbTatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTatCa.Location = new System.Drawing.Point(27, 635);
            this.cbTatCa.Name = "cbTatCa";
            this.cbTatCa.Size = new System.Drawing.Size(102, 30);
            this.cbTatCa.TabIndex = 4;
            this.cbTatCa.Text = "Tất cả";
            this.cbTatCa.UseVisualStyleBackColor = true;
            this.cbTatCa.CheckedChanged += new System.EventHandler(this.cbTatCa_CheckedChanged);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1215, 693);
            this.Controls.Add(this.cbTatCa);
            this.Controls.Add(this.lbSoluong);
            this.Controls.Add(this.lbBooking);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.fpnlBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Booking_Form_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlBooking;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lbBooking;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.CheckBox cbTatCa;
    }
}