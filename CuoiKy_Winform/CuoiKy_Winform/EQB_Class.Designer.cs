﻿namespace CuoiKy_Winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQB_Class));
            this.lbEQBClass = new System.Windows.Forms.Label();
            this.pnlEQBClass = new System.Windows.Forms.Panel();
            this.lbEQB = new System.Windows.Forms.Label();
            this.EQB = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
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
            this.pnlEQBClass.Controls.Add(this.lbEQB);
            this.pnlEQBClass.Controls.Add(this.EQB);
            this.pnlEQBClass.Location = new System.Drawing.Point(4, 60);
            this.pnlEQBClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEQBClass.Name = "pnlEQBClass";
            this.pnlEQBClass.Size = new System.Drawing.Size(1109, 279);
            this.pnlEQBClass.TabIndex = 6;
            // 
            // lbEQB
            // 
            this.lbEQB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQB.Location = new System.Drawing.Point(395, 38);
            this.lbEQB.Name = "lbEQB";
            this.lbEQB.Size = new System.Drawing.Size(675, 200);
            this.lbEQB.TabIndex = 7;
            // 
            // EQB
            // 
            this.EQB.Image = global::CuoiKy_Winform.Properties.Resources.EQB;
            this.EQB.Location = new System.Drawing.Point(46, 38);
            this.EQB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EQB.Name = "EQB";
            this.EQB.Size = new System.Drawing.Size(290, 200);
            this.EQB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EQB.TabIndex = 0;
            this.EQB.TabStop = false;
            this.EQB.Click += new System.EventHandler(this.EQB_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBooking.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(904, 7);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(209, 38);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // EQB_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 351);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pnlEQBClass);
            this.Controls.Add(this.lbEQBClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EQB_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EQB_Class";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EQB_Class_FormClosing);
            this.Load += new System.EventHandler(this.EQB_Class_Load);
            this.pnlEQBClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EQB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEQBClass;
        private System.Windows.Forms.Panel pnlEQBClass;
        private System.Windows.Forms.PictureBox EQB;
        private System.Windows.Forms.Label lbEQB;
        private System.Windows.Forms.Button btnBooking;
    }
}