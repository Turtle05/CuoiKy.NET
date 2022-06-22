namespace CuoiKy_Winform
{
    partial class C_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_Class));
            this.lbCClass = new System.Windows.Forms.Label();
            this.pnlCClass = new System.Windows.Forms.Panel();
            this.lbC43 = new System.Windows.Forms.Label();
            this.lbC300 = new System.Windows.Forms.Label();
            this.lbC200 = new System.Windows.Forms.Label();
            this.C43 = new System.Windows.Forms.PictureBox();
            this.C300 = new System.Windows.Forms.PictureBox();
            this.C200 = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pnlCClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C300)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C200)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCClass
            // 
            this.lbCClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCClass.Location = new System.Drawing.Point(26, 9);
            this.lbCClass.Name = "lbCClass";
            this.lbCClass.Size = new System.Drawing.Size(163, 46);
            this.lbCClass.TabIndex = 1;
            this.lbCClass.Text = "C Class";
            this.lbCClass.Click += new System.EventHandler(this.lbCClass_Click);
            // 
            // pnlCClass
            // 
            this.pnlCClass.AutoScroll = true;
            this.pnlCClass.Controls.Add(this.lbC43);
            this.pnlCClass.Controls.Add(this.lbC300);
            this.pnlCClass.Controls.Add(this.lbC200);
            this.pnlCClass.Controls.Add(this.C43);
            this.pnlCClass.Controls.Add(this.C300);
            this.pnlCClass.Controls.Add(this.C200);
            this.pnlCClass.Location = new System.Drawing.Point(2, 57);
            this.pnlCClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCClass.Name = "pnlCClass";
            this.pnlCClass.Size = new System.Drawing.Size(1141, 490);
            this.pnlCClass.TabIndex = 2;
            // 
            // lbC43
            // 
            this.lbC43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC43.Location = new System.Drawing.Point(396, 561);
            this.lbC43.Name = "lbC43";
            this.lbC43.Size = new System.Drawing.Size(696, 200);
            this.lbC43.TabIndex = 2;
            // 
            // lbC300
            // 
            this.lbC300.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC300.Location = new System.Drawing.Point(396, 290);
            this.lbC300.Name = "lbC300";
            this.lbC300.Size = new System.Drawing.Size(675, 200);
            this.lbC300.TabIndex = 2;
            // 
            // lbC200
            // 
            this.lbC200.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC200.Location = new System.Drawing.Point(396, 23);
            this.lbC200.Name = "lbC200";
            this.lbC200.Size = new System.Drawing.Size(675, 200);
            this.lbC200.TabIndex = 2;
            // 
            // C43
            // 
            this.C43.Image = global::CuoiKy_Winform.Properties.Resources.C43;
            this.C43.Location = new System.Drawing.Point(40, 561);
            this.C43.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C43.Name = "C43";
            this.C43.Size = new System.Drawing.Size(290, 200);
            this.C43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C43.TabIndex = 0;
            this.C43.TabStop = false;
            this.C43.Click += new System.EventHandler(this.C43_Click);
            // 
            // C300
            // 
            this.C300.Image = global::CuoiKy_Winform.Properties.Resources.C300;
            this.C300.Location = new System.Drawing.Point(40, 290);
            this.C300.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C300.Name = "C300";
            this.C300.Size = new System.Drawing.Size(290, 200);
            this.C300.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C300.TabIndex = 0;
            this.C300.TabStop = false;
            this.C300.Click += new System.EventHandler(this.C300_Click);
            // 
            // C200
            // 
            this.C200.Image = global::CuoiKy_Winform.Properties.Resources.C200;
            this.C200.Location = new System.Drawing.Point(40, 23);
            this.C200.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C200.Name = "C200";
            this.C200.Size = new System.Drawing.Size(290, 200);
            this.C200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C200.TabIndex = 0;
            this.C200.TabStop = false;
            this.C200.Click += new System.EventHandler(this.C200_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBooking.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(910, 9);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(209, 38);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // C_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 574);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pnlCClass);
            this.Controls.Add(this.lbCClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "C_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.C_Class_FormClosing);
            this.Load += new System.EventHandler(this.C_Class_Load);
            this.pnlCClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C300)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C200)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCClass;
        private System.Windows.Forms.Panel pnlCClass;
        private System.Windows.Forms.PictureBox C43;
        private System.Windows.Forms.PictureBox C300;
        private System.Windows.Forms.PictureBox C200;
        private System.Windows.Forms.Label lbC43;
        private System.Windows.Forms.Label lbC300;
        private System.Windows.Forms.Label lbC200;
        private System.Windows.Forms.Button btnBooking;
    }
}