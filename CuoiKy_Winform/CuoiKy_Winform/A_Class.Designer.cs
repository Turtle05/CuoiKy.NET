
namespace CuoiKy_Winform
{
    partial class A_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Class));
            this.pnlAClass = new System.Windows.Forms.Panel();
            this.rtxtA45 = new System.Windows.Forms.RichTextBox();
            this.rtxtA220 = new System.Windows.Forms.RichTextBox();
            this.rtxtA200 = new System.Windows.Forms.RichTextBox();
            this.lbAClass = new System.Windows.Forms.Label();
            this.A45 = new System.Windows.Forms.PictureBox();
            this.A220 = new System.Windows.Forms.PictureBox();
            this.A200 = new System.Windows.Forms.PictureBox();
            this.pnlAClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A220)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A200)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAClass
            // 
            this.pnlAClass.AutoScroll = true;
            this.pnlAClass.Controls.Add(this.rtxtA45);
            this.pnlAClass.Controls.Add(this.rtxtA220);
            this.pnlAClass.Controls.Add(this.rtxtA200);
            this.pnlAClass.Controls.Add(this.A45);
            this.pnlAClass.Controls.Add(this.A220);
            this.pnlAClass.Controls.Add(this.A200);
            this.pnlAClass.Location = new System.Drawing.Point(5, 46);
            this.pnlAClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAClass.Name = "pnlAClass";
            this.pnlAClass.Size = new System.Drawing.Size(947, 392);
            this.pnlAClass.TabIndex = 1;
            // 
            // rtxtA45
            // 
            this.rtxtA45.Location = new System.Drawing.Point(361, 496);
            this.rtxtA45.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtA45.Name = "rtxtA45";
            this.rtxtA45.Size = new System.Drawing.Size(540, 158);
            this.rtxtA45.TabIndex = 1;
            this.rtxtA45.Text = "";
            // 
            // rtxtA220
            // 
            this.rtxtA220.Location = new System.Drawing.Point(361, 271);
            this.rtxtA220.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtA220.Name = "rtxtA220";
            this.rtxtA220.Size = new System.Drawing.Size(540, 161);
            this.rtxtA220.TabIndex = 1;
            this.rtxtA220.Text = "";
            this.rtxtA220.TextChanged += new System.EventHandler(this.rtxtA220_TextChanged);
            // 
            // rtxtA200
            // 
            this.rtxtA200.Location = new System.Drawing.Point(361, 53);
            this.rtxtA200.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtA200.Name = "rtxtA200";
            this.rtxtA200.Size = new System.Drawing.Size(540, 161);
            this.rtxtA200.TabIndex = 1;
            this.rtxtA200.Text = "";
            this.rtxtA200.TextChanged += new System.EventHandler(this.rtxtA200_TextChanged);
            // 
            // lbAClass
            // 
            this.lbAClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAClass.Location = new System.Drawing.Point(12, 9);
            this.lbAClass.Name = "lbAClass";
            this.lbAClass.Size = new System.Drawing.Size(145, 37);
            this.lbAClass.TabIndex = 0;
            this.lbAClass.Text = "A Class";
            // 
            // A45
            // 
            this.A45.Image = global::CuoiKy_Winform.Properties.Resources.A45;
            this.A45.Location = new System.Drawing.Point(41, 496);
            this.A45.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A45.Name = "A45";
            this.A45.Size = new System.Drawing.Size(258, 160);
            this.A45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A45.TabIndex = 0;
            this.A45.TabStop = false;
            // 
            // A220
            // 
            this.A220.Image = ((System.Drawing.Image)(resources.GetObject("A220.Image")));
            this.A220.Location = new System.Drawing.Point(41, 272);
            this.A220.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A220.Name = "A220";
            this.A220.Size = new System.Drawing.Size(258, 160);
            this.A220.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A220.TabIndex = 0;
            this.A220.TabStop = false;
            // 
            // A200
            // 
            this.A200.Image = global::CuoiKy_Winform.Properties.Resources.A200;
            this.A200.Location = new System.Drawing.Point(41, 54);
            this.A200.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A200.Name = "A200";
            this.A200.Size = new System.Drawing.Size(258, 160);
            this.A200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A200.TabIndex = 0;
            this.A200.TabStop = false;
            this.A200.Click += new System.EventHandler(this.A200_Click);
            // 
            // A_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 456);
            this.Controls.Add(this.pnlAClass);
            this.Controls.Add(this.lbAClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_Class";
            this.pnlAClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A220)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A200)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAClass;
        private System.Windows.Forms.PictureBox A200;
        private System.Windows.Forms.RichTextBox rtxtA45;
        private System.Windows.Forms.RichTextBox rtxtA220;
        private System.Windows.Forms.RichTextBox rtxtA200;
        private System.Windows.Forms.PictureBox A45;
        private System.Windows.Forms.PictureBox A220;
        private System.Windows.Forms.Label lbAClass;
    }
}