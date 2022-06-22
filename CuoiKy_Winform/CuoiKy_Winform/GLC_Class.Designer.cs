namespace CuoiKy_Winform
{
    partial class GLC_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GLC_Class));
            this.lbGLCClass = new System.Windows.Forms.Label();
            this.pnlGLCClass = new System.Windows.Forms.Panel();
            this.lbGLC400 = new System.Windows.Forms.Label();
            this.lbGLC350 = new System.Windows.Forms.Label();
            this.lbGLC300 = new System.Windows.Forms.Label();
            this.GLC400 = new System.Windows.Forms.PictureBox();
            this.GLC350 = new System.Windows.Forms.PictureBox();
            this.GLC300 = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pnlGLCClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GLC400)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLC350)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLC300)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGLCClass
            // 
            this.lbGLCClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLCClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGLCClass.Location = new System.Drawing.Point(12, 6);
            this.lbGLCClass.Name = "lbGLCClass";
            this.lbGLCClass.Size = new System.Drawing.Size(188, 46);
            this.lbGLCClass.TabIndex = 4;
            this.lbGLCClass.Text = "GLC Class";
            // 
            // pnlGLCClass
            // 
            this.pnlGLCClass.AutoScroll = true;
            this.pnlGLCClass.Controls.Add(this.lbGLC400);
            this.pnlGLCClass.Controls.Add(this.lbGLC350);
            this.pnlGLCClass.Controls.Add(this.lbGLC300);
            this.pnlGLCClass.Controls.Add(this.GLC400);
            this.pnlGLCClass.Controls.Add(this.GLC350);
            this.pnlGLCClass.Controls.Add(this.GLC300);
            this.pnlGLCClass.Location = new System.Drawing.Point(-3, 54);
            this.pnlGLCClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGLCClass.Name = "pnlGLCClass";
            this.pnlGLCClass.Size = new System.Drawing.Size(1109, 488);
            this.pnlGLCClass.TabIndex = 5;
            // 
            // lbGLC400
            // 
            this.lbGLC400.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLC400.Location = new System.Drawing.Point(387, 572);
            this.lbGLC400.Name = "lbGLC400";
            this.lbGLC400.Size = new System.Drawing.Size(675, 200);
            this.lbGLC400.TabIndex = 5;
            // 
            // lbGLC350
            // 
            this.lbGLC350.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLC350.Location = new System.Drawing.Point(387, 305);
            this.lbGLC350.Name = "lbGLC350";
            this.lbGLC350.Size = new System.Drawing.Size(675, 200);
            this.lbGLC350.TabIndex = 5;
            // 
            // lbGLC300
            // 
            this.lbGLC300.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLC300.Location = new System.Drawing.Point(387, 32);
            this.lbGLC300.Name = "lbGLC300";
            this.lbGLC300.Size = new System.Drawing.Size(675, 200);
            this.lbGLC300.TabIndex = 5;
            // 
            // GLC400
            // 
            this.GLC400.Image = global::CuoiKy_Winform.Properties.Resources.GLC400;
            this.GLC400.Location = new System.Drawing.Point(40, 592);
            this.GLC400.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GLC400.Name = "GLC400";
            this.GLC400.Size = new System.Drawing.Size(290, 200);
            this.GLC400.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLC400.TabIndex = 0;
            this.GLC400.TabStop = false;
            this.GLC400.Click += new System.EventHandler(this.GLC400_Click);
            // 
            // GLC350
            // 
            this.GLC350.Image = global::CuoiKy_Winform.Properties.Resources.GLC350;
            this.GLC350.Location = new System.Drawing.Point(40, 305);
            this.GLC350.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GLC350.Name = "GLC350";
            this.GLC350.Size = new System.Drawing.Size(290, 200);
            this.GLC350.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLC350.TabIndex = 0;
            this.GLC350.TabStop = false;
            this.GLC350.Click += new System.EventHandler(this.GLC350_Click);
            // 
            // GLC300
            // 
            this.GLC300.Image = global::CuoiKy_Winform.Properties.Resources.GLC300;
            this.GLC300.Location = new System.Drawing.Point(40, 32);
            this.GLC300.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GLC300.Name = "GLC300";
            this.GLC300.Size = new System.Drawing.Size(290, 200);
            this.GLC300.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLC300.TabIndex = 0;
            this.GLC300.TabStop = false;
            this.GLC300.Click += new System.EventHandler(this.GLC300_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBooking.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(876, 6);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(209, 38);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // GLC_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 569);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pnlGLCClass);
            this.Controls.Add(this.lbGLCClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GLC_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLC_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GLC_Class_FormClosing);
            this.Load += new System.EventHandler(this.GLC_Class_Load);
            this.pnlGLCClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GLC400)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLC350)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLC300)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGLCClass;
        private System.Windows.Forms.Panel pnlGLCClass;
        private System.Windows.Forms.PictureBox GLC400;
        private System.Windows.Forms.PictureBox GLC350;
        private System.Windows.Forms.PictureBox GLC300;
        private System.Windows.Forms.Label lbGLC400;
        private System.Windows.Forms.Label lbGLC350;
        private System.Windows.Forms.Label lbGLC300;
        private System.Windows.Forms.Button btnBooking;
    }
}