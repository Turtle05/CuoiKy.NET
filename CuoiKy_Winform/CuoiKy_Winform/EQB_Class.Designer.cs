namespace CuoiKy_Winform
{
    partial class EQB_Class
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
            this.lbEQBClass = new System.Windows.Forms.Label();
            this.pnlEQBClass = new System.Windows.Forms.Panel();
            this.rtxtEQB = new System.Windows.Forms.RichTextBox();
            this.EQB = new System.Windows.Forms.PictureBox();
            this.pnlEQBClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EQB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEQBClass
            // 
            this.lbEQBClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQBClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEQBClass.Location = new System.Drawing.Point(-2, -1);
            this.lbEQBClass.Name = "lbEQBClass";
            this.lbEQBClass.Size = new System.Drawing.Size(228, 46);
            this.lbEQBClass.TabIndex = 5;
            this.lbEQBClass.Text = " EQB Class";
            this.lbEQBClass.Click += new System.EventHandler(this.lbEQBClass_Click);
            // 
            // pnlEQBClass
            // 
            this.pnlEQBClass.AutoScroll = true;
            this.pnlEQBClass.Controls.Add(this.rtxtEQB);
            this.pnlEQBClass.Controls.Add(this.EQB);
            this.pnlEQBClass.Location = new System.Drawing.Point(4, 60);
            this.pnlEQBClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEQBClass.Name = "pnlEQBClass";
            this.pnlEQBClass.Size = new System.Drawing.Size(1077, 279);
            this.pnlEQBClass.TabIndex = 6;
            // 
            // rtxtEQB
            // 
            this.rtxtEQB.Location = new System.Drawing.Point(432, 37);
            this.rtxtEQB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtEQB.Name = "rtxtEQB";
            this.rtxtEQB.Size = new System.Drawing.Size(607, 200);
            this.rtxtEQB.TabIndex = 1;
            this.rtxtEQB.Text = "";
            // 
            // EQB
            // 
            this.EQB.Image = global::CuoiKy_Winform.Properties.Resources.EQB;
            this.EQB.Location = new System.Drawing.Point(46, 37);
            this.EQB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EQB.Name = "EQB";
            this.EQB.Size = new System.Drawing.Size(290, 200);
            this.EQB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EQB.TabIndex = 0;
            this.EQB.TabStop = false;
            // 
            // EQB_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 351);
            this.Controls.Add(this.pnlEQBClass);
            this.Controls.Add(this.lbEQBClass);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EQB_Class";
            this.Text = "EQB_Class";
            this.pnlEQBClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EQB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEQBClass;
        private System.Windows.Forms.Panel pnlEQBClass;
        private System.Windows.Forms.RichTextBox rtxtEQB;
        private System.Windows.Forms.PictureBox EQB;
    }
}