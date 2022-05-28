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
            this.lbEQSClass = new System.Windows.Forms.Label();
            this.pnlEQSClass = new System.Windows.Forms.Panel();
            this.rtxtEQS = new System.Windows.Forms.RichTextBox();
            this.EQS = new System.Windows.Forms.PictureBox();
            this.pnlEQSClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EQS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEQSClass
            // 
            this.lbEQSClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQSClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEQSClass.Location = new System.Drawing.Point(-4, -1);
            this.lbEQSClass.Name = "lbEQSClass";
            this.lbEQSClass.Size = new System.Drawing.Size(164, 37);
            this.lbEQSClass.TabIndex = 4;
            this.lbEQSClass.Text = "EQS Class";
            this.lbEQSClass.Click += new System.EventHandler(this.lbEQSClass_Click);
            // 
            // pnlEQSClass
            // 
            this.pnlEQSClass.AutoScroll = true;
            this.pnlEQSClass.Controls.Add(this.rtxtEQS);
            this.pnlEQSClass.Controls.Add(this.EQS);
            this.pnlEQSClass.Location = new System.Drawing.Point(2, 48);
            this.pnlEQSClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEQSClass.Name = "pnlEQSClass";
            this.pnlEQSClass.Size = new System.Drawing.Size(957, 345);
            this.pnlEQSClass.TabIndex = 5;
            // 
            // rtxtEQS
            // 
            this.rtxtEQS.Location = new System.Drawing.Point(379, 42);
            this.rtxtEQS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtEQS.Name = "rtxtEQS";
            this.rtxtEQS.Size = new System.Drawing.Size(540, 161);
            this.rtxtEQS.TabIndex = 1;
            this.rtxtEQS.Text = "";
            // 
            // EQS
            // 
            this.EQS.Image = global::CuoiKy_Winform.Properties.Resources.EQS;
            this.EQS.Location = new System.Drawing.Point(46, 43);
            this.EQS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EQS.Name = "EQS";
            this.EQS.Size = new System.Drawing.Size(258, 160);
            this.EQS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EQS.TabIndex = 0;
            this.EQS.TabStop = false;
            // 
            // EQS_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 474);
            this.Controls.Add(this.pnlEQSClass);
            this.Controls.Add(this.lbEQSClass);
            this.Name = "EQS_Class";
            this.Text = "EQS_Class";
            this.pnlEQSClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EQS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEQSClass;
        private System.Windows.Forms.Panel pnlEQSClass;
        private System.Windows.Forms.RichTextBox rtxtEQS;
        private System.Windows.Forms.PictureBox EQS;
    }
}