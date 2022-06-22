namespace CuoiKy_Winform
{
    partial class EQS_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQS_Class));
            this.lbEQSClass = new System.Windows.Forms.Label();
            this.pnlEQSClass = new System.Windows.Forms.Panel();
            this.lbEQS = new System.Windows.Forms.Label();
            this.EQS = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pnlEQSClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EQS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEQSClass
            // 
            this.lbEQSClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQSClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEQSClass.Location = new System.Drawing.Point(12, 9);
            this.lbEQSClass.Name = "lbEQSClass";
            this.lbEQSClass.Size = new System.Drawing.Size(184, 46);
            this.lbEQSClass.TabIndex = 4;
            this.lbEQSClass.Text = "EQS Class";
            this.lbEQSClass.Click += new System.EventHandler(this.lbEQSClass_Click);
            // 
            // pnlEQSClass
            // 
            this.pnlEQSClass.AutoScroll = true;
            this.pnlEQSClass.Controls.Add(this.lbEQS);
            this.pnlEQSClass.Controls.Add(this.EQS);
            this.pnlEQSClass.Location = new System.Drawing.Point(2, 60);
            this.pnlEQSClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEQSClass.Name = "pnlEQSClass";
            this.pnlEQSClass.Size = new System.Drawing.Size(1099, 270);
            this.pnlEQSClass.TabIndex = 5;
            // 
            // lbEQS
            // 
            this.lbEQS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQS.Location = new System.Drawing.Point(379, 31);
            this.lbEQS.Name = "lbEQS";
            this.lbEQS.Size = new System.Drawing.Size(675, 200);
            this.lbEQS.TabIndex = 5;
            // 
            // EQS
            // 
            this.EQS.Image = global::CuoiKy_Winform.Properties.Resources.EQS;
            this.EQS.Location = new System.Drawing.Point(35, 31);
            this.EQS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EQS.Name = "EQS";
            this.EQS.Size = new System.Drawing.Size(290, 200);
            this.EQS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EQS.TabIndex = 0;
            this.EQS.TabStop = false;
            this.EQS.Click += new System.EventHandler(this.EQS_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBooking.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(892, 9);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(209, 38);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // EQS_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1130, 350);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pnlEQSClass);
            this.Controls.Add(this.lbEQSClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EQS_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EQS_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EQS_Class_FormClosing);
            this.Load += new System.EventHandler(this.EQS_Class_Load);
            this.pnlEQSClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EQS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEQSClass;
        private System.Windows.Forms.Panel pnlEQSClass;
        private System.Windows.Forms.PictureBox EQS;
        private System.Windows.Forms.Label lbEQS;
        private System.Windows.Forms.Button btnBooking;
    }
}