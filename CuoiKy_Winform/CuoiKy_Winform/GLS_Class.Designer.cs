namespace CuoiKy_Winform
{
    partial class GLS_Class
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
            this.lbGLSClass = new System.Windows.Forms.Label();
            this.pnlGLSClass = new System.Windows.Forms.Panel();
            this.lbGLS500 = new System.Windows.Forms.Label();
            this.lbGLS400 = new System.Windows.Forms.Label();
            this.GLS500 = new System.Windows.Forms.PictureBox();
            this.GLS400 = new System.Windows.Forms.PictureBox();
            this.pnlGLSClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GLS500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLS400)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGLSClass
            // 
            this.lbGLSClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLSClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGLSClass.Location = new System.Drawing.Point(21, 8);
            this.lbGLSClass.Name = "lbGLSClass";
            this.lbGLSClass.Size = new System.Drawing.Size(183, 46);
            this.lbGLSClass.TabIndex = 2;
            this.lbGLSClass.Text = "GLS Class";
            // 
            // pnlGLSClass
            // 
            this.pnlGLSClass.AutoScroll = true;
            this.pnlGLSClass.Controls.Add(this.lbGLS500);
            this.pnlGLSClass.Controls.Add(this.lbGLS400);
            this.pnlGLSClass.Controls.Add(this.GLS500);
            this.pnlGLSClass.Controls.Add(this.GLS400);
            this.pnlGLSClass.Location = new System.Drawing.Point(12, 55);
            this.pnlGLSClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGLSClass.Name = "pnlGLSClass";
            this.pnlGLSClass.Size = new System.Drawing.Size(1079, 529);
            this.pnlGLSClass.TabIndex = 3;
            // 
            // lbGLS500
            // 
            this.lbGLS500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLS500.Location = new System.Drawing.Point(384, 302);
            this.lbGLS500.Name = "lbGLS500";
            this.lbGLS500.Size = new System.Drawing.Size(675, 200);
            this.lbGLS500.TabIndex = 6;
            // 
            // lbGLS400
            // 
            this.lbGLS400.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLS400.Location = new System.Drawing.Point(384, 19);
            this.lbGLS400.Name = "lbGLS400";
            this.lbGLS400.Size = new System.Drawing.Size(675, 200);
            this.lbGLS400.TabIndex = 6;
            // 
            // GLS500
            // 
            this.GLS500.Image = global::CuoiKy_Winform.Properties.Resources.GLS500;
            this.GLS500.Location = new System.Drawing.Point(45, 302);
            this.GLS500.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GLS500.Name = "GLS500";
            this.GLS500.Size = new System.Drawing.Size(290, 200);
            this.GLS500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLS500.TabIndex = 0;
            this.GLS500.TabStop = false;
            // 
            // GLS400
            // 
            this.GLS400.Image = global::CuoiKy_Winform.Properties.Resources.GLS400;
            this.GLS400.Location = new System.Drawing.Point(45, 19);
            this.GLS400.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GLS400.Name = "GLS400";
            this.GLS400.Size = new System.Drawing.Size(290, 200);
            this.GLS400.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GLS400.TabIndex = 0;
            this.GLS400.TabStop = false;
            // 
            // GLS_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 594);
            this.Controls.Add(this.pnlGLSClass);
            this.Controls.Add(this.lbGLSClass);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GLS_Class";
            this.Text = "GLS_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GLS_Class_FormClosing);
            this.Load += new System.EventHandler(this.GLS_Class_Load);
            this.pnlGLSClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GLS500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLS400)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGLSClass;
        private System.Windows.Forms.Panel pnlGLSClass;
        private System.Windows.Forms.PictureBox GLS500;
        private System.Windows.Forms.PictureBox GLS400;
        private System.Windows.Forms.Label lbGLS500;
        private System.Windows.Forms.Label lbGLS400;
    }
}