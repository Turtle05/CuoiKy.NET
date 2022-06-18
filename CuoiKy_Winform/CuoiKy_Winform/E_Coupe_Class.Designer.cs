namespace CuoiKy_Winform
{
    partial class E_Coupe_Class
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
            this.pnlE_COUPE = new System.Windows.Forms.Panel();
            this.lbE400_Coupe = new System.Windows.Forms.Label();
            this.lbE300_Coupe = new System.Windows.Forms.Label();
            this.E400_Coupe = new System.Windows.Forms.PictureBox();
            this.E300_Coupe = new System.Windows.Forms.PictureBox();
            this.pnlE_COUPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.E400_Coupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E300_Coupe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGClass
            // 
            this.lbGClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGClass.Location = new System.Drawing.Point(12, 8);
            this.lbGClass.Name = "lbGClass";
            this.lbGClass.Size = new System.Drawing.Size(253, 46);
            this.lbGClass.TabIndex = 4;
            this.lbGClass.Text = "E COUPE Class";
            // 
            // pnlE_COUPE
            // 
            this.pnlE_COUPE.AutoScroll = true;
            this.pnlE_COUPE.Controls.Add(this.lbE400_Coupe);
            this.pnlE_COUPE.Controls.Add(this.lbE300_Coupe);
            this.pnlE_COUPE.Controls.Add(this.E400_Coupe);
            this.pnlE_COUPE.Controls.Add(this.E300_Coupe);
            this.pnlE_COUPE.Location = new System.Drawing.Point(1, 55);
            this.pnlE_COUPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlE_COUPE.Name = "pnlE_COUPE";
            this.pnlE_COUPE.Size = new System.Drawing.Size(1112, 519);
            this.pnlE_COUPE.TabIndex = 5;
            // 
            // lbE400_Coupe
            // 
            this.lbE400_Coupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE400_Coupe.Location = new System.Drawing.Point(394, 290);
            this.lbE400_Coupe.Name = "lbE400_Coupe";
            this.lbE400_Coupe.Size = new System.Drawing.Size(675, 200);
            this.lbE400_Coupe.TabIndex = 5;
            // 
            // lbE300_Coupe
            // 
            this.lbE300_Coupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE300_Coupe.Location = new System.Drawing.Point(394, 24);
            this.lbE300_Coupe.Name = "lbE300_Coupe";
            this.lbE300_Coupe.Size = new System.Drawing.Size(675, 200);
            this.lbE300_Coupe.TabIndex = 5;
            // 
            // E400_Coupe
            // 
            this.E400_Coupe.Image = global::CuoiKy_Winform.Properties.Resources.E400_Coupe;
            this.E400_Coupe.Location = new System.Drawing.Point(45, 290);
            this.E400_Coupe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.E400_Coupe.Name = "E400_Coupe";
            this.E400_Coupe.Size = new System.Drawing.Size(290, 200);
            this.E400_Coupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.E400_Coupe.TabIndex = 0;
            this.E400_Coupe.TabStop = false;
            // 
            // E300_Coupe
            // 
            this.E300_Coupe.Image = global::CuoiKy_Winform.Properties.Resources.E300_Coupe;
            this.E300_Coupe.Location = new System.Drawing.Point(45, 24);
            this.E300_Coupe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.E300_Coupe.Name = "E300_Coupe";
            this.E300_Coupe.Size = new System.Drawing.Size(290, 200);
            this.E300_Coupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.E300_Coupe.TabIndex = 0;
            this.E300_Coupe.TabStop = false;
            // 
            // E_Coupe_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 585);
            this.Controls.Add(this.pnlE_COUPE);
            this.Controls.Add(this.lbGClass);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "E_Coupe_Class";
            this.Text = "E_Coupe_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.E_Coupe_Class_FormClosing);
            this.Load += new System.EventHandler(this.E_Coupe_Class_Load);
            this.pnlE_COUPE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.E400_Coupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E300_Coupe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGClass;
        private System.Windows.Forms.Panel pnlE_COUPE;
        private System.Windows.Forms.PictureBox E400_Coupe;
        private System.Windows.Forms.PictureBox E300_Coupe;
        private System.Windows.Forms.Label lbE400_Coupe;
        private System.Windows.Forms.Label lbE300_Coupe;
    }
}