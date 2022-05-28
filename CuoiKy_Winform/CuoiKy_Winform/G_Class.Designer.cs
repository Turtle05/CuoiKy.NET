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
            this.rtxtG63 = new System.Windows.Forms.RichTextBox();
            this.rtxtG400 = new System.Windows.Forms.RichTextBox();
            this.G63 = new System.Windows.Forms.PictureBox();
            this.G400 = new System.Windows.Forms.PictureBox();
            this.pnlGClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G400)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGClass
            // 
            this.lbGClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGClass.Location = new System.Drawing.Point(-3, -2);
            this.lbGClass.Name = "lbGClass";
            this.lbGClass.Size = new System.Drawing.Size(163, 37);
            this.lbGClass.TabIndex = 3;
            this.lbGClass.Text = "G Class";
            // 
            // pnlGClass
            // 
            this.pnlGClass.AutoScroll = true;
            this.pnlGClass.Controls.Add(this.rtxtG63);
            this.pnlGClass.Controls.Add(this.rtxtG400);
            this.pnlGClass.Controls.Add(this.G63);
            this.pnlGClass.Controls.Add(this.G400);
            this.pnlGClass.Location = new System.Drawing.Point(6, 32);
            this.pnlGClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGClass.Name = "pnlGClass";
            this.pnlGClass.Size = new System.Drawing.Size(952, 392);
            this.pnlGClass.TabIndex = 4;
            // 
            // rtxtG63
            // 
            this.rtxtG63.Location = new System.Drawing.Point(361, 240);
            this.rtxtG63.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtG63.Name = "rtxtG63";
            this.rtxtG63.Size = new System.Drawing.Size(540, 161);
            this.rtxtG63.TabIndex = 1;
            this.rtxtG63.Text = "";
            // 
            // rtxtG400
            // 
            this.rtxtG400.Location = new System.Drawing.Point(361, 31);
            this.rtxtG400.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtG400.Name = "rtxtG400";
            this.rtxtG400.Size = new System.Drawing.Size(540, 161);
            this.rtxtG400.TabIndex = 1;
            this.rtxtG400.Text = "";
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
            // 
            // G400
            // 
            this.G400.Image = global::CuoiKy_Winform.Properties.Resources.G400;
            this.G400.Location = new System.Drawing.Point(40, 32);
            this.G400.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.G400.Name = "G400";
            this.G400.Size = new System.Drawing.Size(258, 160);
            this.G400.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.G400.TabIndex = 0;
            this.G400.TabStop = false;
            // 
            // G_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 456);
            this.Controls.Add(this.pnlGClass);
            this.Controls.Add(this.lbGClass);
            this.Name = "G_Class";
            this.Text = "G_Class";
            this.Load += new System.EventHandler(this.G_Class_Load);
            this.pnlGClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.G63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G400)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGClass;
        private System.Windows.Forms.Panel pnlGClass;
        private System.Windows.Forms.RichTextBox rtxtG63;
        private System.Windows.Forms.RichTextBox rtxtG400;
        private System.Windows.Forms.PictureBox G63;
        private System.Windows.Forms.PictureBox G400;
    }
}