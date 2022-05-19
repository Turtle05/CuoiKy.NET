
namespace CuoiKy_Winform
{
    partial class Form_SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbClearField = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(131, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGN IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(22, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 2);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(22, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 2);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CuoiKy_Winform.Properties.Resources.tải_xuống__1_;
            this.pictureBox3.Location = new System.Drawing.Point(22, 393);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CuoiKy_Winform.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(22, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuoiKy_Winform.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(156, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbClearField
            // 
            this.lbClearField.AutoSize = true;
            this.lbClearField.BackColor = System.Drawing.Color.Transparent;
            this.lbClearField.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClearField.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbClearField.Location = new System.Drawing.Point(319, 490);
            this.lbClearField.Name = "lbClearField";
            this.lbClearField.Size = new System.Drawing.Size(108, 29);
            this.lbClearField.TabIndex = 7;
            this.lbClearField.Text = "Clear fields";
            this.lbClearField.Click += new System.EventHandler(this.lbClearField_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbExit.Location = new System.Drawing.Point(188, 597);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(65, 40);
            this.lbExit.TabIndex = 8;
            this.lbExit.Text = "Exit";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(75, 263);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 36);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(75, 399);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(352, 36);
            this.txtPassword.TabIndex = 9;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbMessage.Location = new System.Drawing.Point(36, 215);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 20);
            this.lbMessage.TabIndex = 10;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignIn.Font = new System.Drawing.Font("Sitka Subheading", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(22, 522);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(405, 58);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Form_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 673);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbClearField);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbClearField;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnSignIn;
    }
}