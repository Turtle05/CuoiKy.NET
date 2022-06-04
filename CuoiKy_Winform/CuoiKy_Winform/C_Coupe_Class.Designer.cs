namespace CuoiKy_Winform
{
    partial class C_Coupe_Class
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
            this.lbC_COUPE_CClass = new System.Windows.Forms.Label();
            this.pnlC_COUPEClass = new System.Windows.Forms.Panel();
            this.C300_Coupe = new System.Windows.Forms.PictureBox();
            this.C200_Coupe = new System.Windows.Forms.PictureBox();
            this.lbC200_Coupe = new System.Windows.Forms.Label();
            this.lbC300_Coupe = new System.Windows.Forms.Label();
            this.pnlC_COUPEClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C300_Coupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C200_Coupe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbC_COUPE_CClass
            // 
            this.lbC_COUPE_CClass.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC_COUPE_CClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbC_COUPE_CClass.Location = new System.Drawing.Point(-11, -1);
            this.lbC_COUPE_CClass.Name = "lbC_COUPE_CClass";
            this.lbC_COUPE_CClass.Size = new System.Drawing.Size(237, 37);
            this.lbC_COUPE_CClass.TabIndex = 6;
            this.lbC_COUPE_CClass.Text = " C COUPE Class";
            // 
            // pnlC_COUPEClass
            // 
            this.pnlC_COUPEClass.AutoScroll = true;
            this.pnlC_COUPEClass.Controls.Add(this.lbC300_Coupe);
            this.pnlC_COUPEClass.Controls.Add(this.lbC200_Coupe);
            this.pnlC_COUPEClass.Controls.Add(this.C300_Coupe);
            this.pnlC_COUPEClass.Controls.Add(this.C200_Coupe);
            this.pnlC_COUPEClass.Location = new System.Drawing.Point(9, 32);
            this.pnlC_COUPEClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlC_COUPEClass.Name = "pnlC_COUPEClass";
            this.pnlC_COUPEClass.Size = new System.Drawing.Size(978, 404);
            this.pnlC_COUPEClass.TabIndex = 7;
            // 
            // C300_Coupe
            // 
            this.C300_Coupe.Image = global::CuoiKy_Winform.Properties.Resources.C300_Coupe;
            this.C300_Coupe.Location = new System.Drawing.Point(33, 232);
            this.C300_Coupe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C300_Coupe.Name = "C300_Coupe";
            this.C300_Coupe.Size = new System.Drawing.Size(258, 160);
            this.C300_Coupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C300_Coupe.TabIndex = 0;
            this.C300_Coupe.TabStop = false;
            // 
            // C200_Coupe
            // 
            this.C200_Coupe.Image = global::CuoiKy_Winform.Properties.Resources.C200_Coupe;
            this.C200_Coupe.Location = new System.Drawing.Point(33, 21);
            this.C200_Coupe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C200_Coupe.Name = "C200_Coupe";
            this.C200_Coupe.Size = new System.Drawing.Size(258, 160);
            this.C200_Coupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C200_Coupe.TabIndex = 0;
            this.C200_Coupe.TabStop = false;
            // 
            // lbC200_Coupe
            // 
            this.lbC200_Coupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC200_Coupe.Location = new System.Drawing.Point(344, 21);
            this.lbC200_Coupe.Name = "lbC200_Coupe";
            this.lbC200_Coupe.Size = new System.Drawing.Size(600, 160);
            this.lbC200_Coupe.TabIndex = 4;
            // 
            // lbC300_Coupe
            // 
            this.lbC300_Coupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC300_Coupe.Location = new System.Drawing.Point(344, 232);
            this.lbC300_Coupe.Name = "lbC300_Coupe";
            this.lbC300_Coupe.Size = new System.Drawing.Size(600, 160);
            this.lbC300_Coupe.TabIndex = 4;
            // 
            // C_Coupe_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.pnlC_COUPEClass);
            this.Controls.Add(this.lbC_COUPE_CClass);
            this.Name = "C_Coupe_Class";
            this.Text = "C_Coupe_Class";
            this.Load += new System.EventHandler(this.C_Coupe_Class_Load);
            this.pnlC_COUPEClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C300_Coupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C200_Coupe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbC_COUPE_CClass;
        private System.Windows.Forms.Panel pnlC_COUPEClass;
        private System.Windows.Forms.PictureBox C300_Coupe;
        private System.Windows.Forms.PictureBox C200_Coupe;
        private System.Windows.Forms.Label lbC300_Coupe;
        private System.Windows.Forms.Label lbC200_Coupe;
    }
}