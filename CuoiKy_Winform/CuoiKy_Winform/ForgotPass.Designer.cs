
namespace CuoiKy_Winform
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbNewPass = new System.Windows.Forms.CheckBox();
            this.cbConfirmPass = new System.Windows.Forms.CheckBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(177, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forget Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "New password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirm password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(312, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(312, 216);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(353, 26);
            this.txtNewPass.TabIndex = 3;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(312, 304);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(353, 26);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangePass.Font = new System.Drawing.Font("Sitka Subheading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(272, 367);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(293, 61);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "CHANGE";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(694, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 55);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbNewPass
            // 
            this.cbNewPass.AutoSize = true;
            this.cbNewPass.Location = new System.Drawing.Point(684, 216);
            this.cbNewPass.Name = "cbNewPass";
            this.cbNewPass.Size = new System.Drawing.Size(22, 21);
            this.cbNewPass.TabIndex = 6;
            this.cbNewPass.UseVisualStyleBackColor = true;
            this.cbNewPass.CheckedChanged += new System.EventHandler(this.cbNewPass_CheckedChanged);
            // 
            // cbConfirmPass
            // 
            this.cbConfirmPass.AutoSize = true;
            this.cbConfirmPass.Location = new System.Drawing.Point(684, 309);
            this.cbConfirmPass.Name = "cbConfirmPass";
            this.cbConfirmPass.Size = new System.Drawing.Size(22, 21);
            this.cbConfirmPass.TabIndex = 6;
            this.cbConfirmPass.UseVisualStyleBackColor = true;
            this.cbConfirmPass.CheckedChanged += new System.EventHandler(this.cbConfirmPass_CheckedChanged);
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.ForeColor = System.Drawing.Color.Red;
            this.lbNewPass.Location = new System.Drawing.Point(308, 174);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(0, 30);
            this.lbNewPass.TabIndex = 7;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmPass.Location = new System.Drawing.Point(308, 266);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(0, 30);
            this.lbConfirmPass.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(308, 90);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 30);
            this.lbEmail.TabIndex = 7;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 434);
            this.Controls.Add(this.lbConfirmPass);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.cbConfirmPass);
            this.Controls.Add(this.cbNewPass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbNewPass;
        private System.Windows.Forms.CheckBox cbConfirmPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.Label lbEmail;
    }
}