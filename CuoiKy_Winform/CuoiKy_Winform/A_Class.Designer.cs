
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
            this.A45 = new System.Windows.Forms.PictureBox();
            this.A220 = new System.Windows.Forms.PictureBox();
            this.A200 = new System.Windows.Forms.PictureBox();
            this.lbAClass = new System.Windows.Forms.Label();
            this.lbA200 = new System.Windows.Forms.Label();
            this.lbA220 = new System.Windows.Forms.Label();
            this.lbA45 = new System.Windows.Forms.Label();
            this.pnlAClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A220)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A200)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAClass
            // 
            this.pnlAClass.AutoScroll = true;
            this.pnlAClass.Controls.Add(this.lbA45);
            this.pnlAClass.Controls.Add(this.lbA220);
            this.pnlAClass.Controls.Add(this.lbA200);
            this.pnlAClass.Controls.Add(this.A45);
            this.pnlAClass.Controls.Add(this.A220);
            this.pnlAClass.Controls.Add(this.A200);
            this.pnlAClass.Location = new System.Drawing.Point(6, 58);
            this.pnlAClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAClass.Name = "pnlAClass";
            this.pnlAClass.Size = new System.Drawing.Size(1129, 490);
            this.pnlAClass.TabIndex = 2;
            // 
            // A45
            // 
            this.A45.Image = global::CuoiKy_Winform.Properties.Resources.A45;
            this.A45.Location = new System.Drawing.Point(46, 586);
            this.A45.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A45.Name = "A45";
            this.A45.Size = new System.Drawing.Size(290, 200);
            this.A45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A45.TabIndex = 0;
            this.A45.TabStop = false;
            // 
            // A220
            // 
            this.A220.Image = ((System.Drawing.Image)(resources.GetObject("A220.Image")));
            this.A220.Location = new System.Drawing.Point(46, 301);
            this.A220.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A220.Name = "A220";
            this.A220.Size = new System.Drawing.Size(290, 200);
            this.A220.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A220.TabIndex = 0;
            this.A220.TabStop = false;
            // 
            // A200
            // 
            this.A200.Image = global::CuoiKy_Winform.Properties.Resources.A200;
            this.A200.Location = new System.Drawing.Point(46, 24);
            this.A200.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A200.Name = "A200";
            this.A200.Size = new System.Drawing.Size(290, 200);
            this.A200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A200.TabIndex = 0;
            this.A200.TabStop = false;
            this.A200.Click += new System.EventHandler(this.A200_Click);
            // 
            // lbAClass
            // 
            this.lbAClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAClass.Location = new System.Drawing.Point(14, 11);
            this.lbAClass.Name = "lbAClass";
            this.lbAClass.Size = new System.Drawing.Size(163, 46);
            this.lbAClass.TabIndex = 0;
            this.lbAClass.Text = "A Class";
            // 
            // lbA200
            // 
            this.lbA200.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA200.Location = new System.Drawing.Point(402, 24);
            this.lbA200.Name = "lbA200";
            this.lbA200.Size = new System.Drawing.Size(662, 200);
            this.lbA200.TabIndex = 1;
            // 
            // lbA220
            // 
            this.lbA220.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA220.Location = new System.Drawing.Point(402, 301);
            this.lbA220.Name = "lbA220";
            this.lbA220.Size = new System.Drawing.Size(662, 200);
            this.lbA220.TabIndex = 2;
            // 
            // lbA45
            // 
            this.lbA45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA45.Location = new System.Drawing.Point(402, 586);
            this.lbA45.Name = "lbA45";
            this.lbA45.Size = new System.Drawing.Size(662, 200);
            this.lbA45.TabIndex = 2;
            // 
            // A_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1153, 575);
            this.Controls.Add(this.pnlAClass);
            this.Controls.Add(this.lbAClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "A_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.A_Class_FormClosing);
            this.Load += new System.EventHandler(this.A_Class_Load);
            this.pnlAClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A220)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A200)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAClass;
        private System.Windows.Forms.PictureBox A200;
        private System.Windows.Forms.PictureBox A45;
        private System.Windows.Forms.PictureBox A220;
        private System.Windows.Forms.Label lbAClass;
        private System.Windows.Forms.Label lbA200;
        private System.Windows.Forms.Label lbA45;
        private System.Windows.Forms.Label lbA220;
    }
}