namespace CuoiKy_Winform
{
    partial class G_Class
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
            this.lbGClass = new System.Windows.Forms.Label();
            this.pnlGClass = new System.Windows.Forms.Panel();
            this.lbG63 = new System.Windows.Forms.Label();
            this.lbG400 = new System.Windows.Forms.Label();
            this.G63 = new System.Windows.Forms.PictureBox();
            this.G400 = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pnlGClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G400)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGClass
            // 
            this.lbGClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGClass.Location = new System.Drawing.Point(11, 2);
            this.lbGClass.Name = "lbGClass";
            this.lbGClass.Size = new System.Drawing.Size(163, 37);
            this.lbGClass.TabIndex = 3;
            this.lbGClass.Text = "G Class";
            // 
            // pnlGClass
            // 
            this.pnlGClass.AutoScroll = true;
            this.pnlGClass.Controls.Add(this.lbG63);
            this.pnlGClass.Controls.Add(this.lbG400);
            this.pnlGClass.Controls.Add(this.G63);
            this.pnlGClass.Controls.Add(this.G400);
            this.pnlGClass.Location = new System.Drawing.Point(11, 41);
            this.pnlGClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGClass.Name = "pnlGClass";
            this.pnlGClass.Size = new System.Drawing.Size(960, 415);
            this.pnlGClass.TabIndex = 4;
            // 
            // lbG63
            // 
            this.lbG63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbG63.Location = new System.Drawing.Point(338, 241);
            this.lbG63.Name = "lbG63";
            this.lbG63.Size = new System.Drawing.Size(600, 160);
            this.lbG63.TabIndex = 7;
            // 
            // lbG400
            // 
            this.lbG400.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbG400.Location = new System.Drawing.Point(338, 22);
            this.lbG400.Name = "lbG400";
            this.lbG400.Size = new System.Drawing.Size(600, 160);
            this.lbG400.TabIndex = 7;
            // 
            // G63
            // 
            this.G63.Image = global::CuoiKy_Winform.Properties.Resources.G63;
            this.G63.Location = new System.Drawing.Point(40, 241);
            this.G63.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.G63.Name = "G63";
            this.G63.Size = new System.Drawing.Size(258, 160);
            this.G63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G63.TabIndex = 0;
            this.G63.TabStop = false;
            this.G63.Click += new System.EventHandler(this.G63_Click);
            // 
            // G400
            // 
            this.G400.Image = global::CuoiKy_Winform.Properties.Resources.G400;
            this.G400.Location = new System.Drawing.Point(40, 22);
            this.G400.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.G400.Name = "G400";
            this.G400.Size = new System.Drawing.Size(258, 160);
            this.G400.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G400.TabIndex = 0;
            this.G400.TabStop = false;
            this.G400.Click += new System.EventHandler(this.G400_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(785, 2);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(186, 30);
            this.btnBooking.TabIndex = 8;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // G_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 465);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pnlGClass);
            this.Controls.Add(this.lbGClass);
            this.Name = "G_Class";
            this.Text = "G_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.G_Class_FormClosing);
            this.Load += new System.EventHandler(this.G_Class_Load);
            this.pnlGClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.G63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G400)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGClass;
        private System.Windows.Forms.Panel pnlGClass;
        private System.Windows.Forms.PictureBox G63;
        private System.Windows.Forms.PictureBox G400;
        private System.Windows.Forms.Label lbG63;
        private System.Windows.Forms.Label lbG400;
        private System.Windows.Forms.Button btnBooking;
    }
}