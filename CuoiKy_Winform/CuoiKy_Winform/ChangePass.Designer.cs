
namespace CuoiKy_Winform
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.lbMKcu = new System.Windows.Forms.Label();
            this.lbMKmoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lbCurPass = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.cbNewPass = new System.Windows.Forms.CheckBox();
            this.cbConfirmPass = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // lbMKcu
            // 
            this.lbMKcu.AutoSize = true;
            this.lbMKcu.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKcu.Location = new System.Drawing.Point(70, 113);
            this.lbMKcu.Name = "lbMKcu";
            this.lbMKcu.Size = new System.Drawing.Size(187, 28);
            this.lbMKcu.TabIndex = 1;
            this.lbMKcu.Text = "Current password";
            // 
            // lbMKmoi
            // 
            this.lbMKmoi.AutoSize = true;
            this.lbMKmoi.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKmoi.Location = new System.Drawing.Point(70, 200);
            this.lbMKmoi.Name = "lbMKmoi";
            this.lbMKmoi.Size = new System.Drawing.Size(152, 28);
            this.lbMKmoi.TabIndex = 1;
            this.lbMKmoi.Text = "New password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirm password";
            // 
            // txtCurPass
            // 
            this.txtCurPass.Location = new System.Drawing.Point(309, 113);
            this.txtCurPass.Name = "txtCurPass";
            this.txtCurPass.PasswordChar = '*';
            this.txtCurPass.Size = new System.Drawing.Size(353, 26);
            this.txtCurPass.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(309, 204);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(353, 26);
            this.txtNewPass.TabIndex = 2;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(309, 301);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(353, 26);
            this.txtConfirmPass.TabIndex = 2;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangePass.Font = new System.Drawing.Font("Sitka Subheading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(267, 359);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(293, 61);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "CHANGE";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lbCurPass
            // 
            this.lbCurPass.AutoSize = true;
            this.lbCurPass.ForeColor = System.Drawing.Color.Red;
            this.lbCurPass.Location = new System.Drawing.Point(305, 81);
            this.lbCurPass.Name = "lbCurPass";
            this.lbCurPass.Size = new System.Drawing.Size(0, 20);
            this.lbCurPass.TabIndex = 4;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.ForeColor = System.Drawing.Color.Red;
            this.lbNewPass.Location = new System.Drawing.Point(305, 168);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(0, 20);
            this.lbNewPass.TabIndex = 4;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmPass.Location = new System.Drawing.Point(305, 267);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(0, 20);
            this.lbConfirmPass.TabIndex = 4;
            // 
            // cbNewPass
            // 
            this.cbNewPass.AutoSize = true;
            this.cbNewPass.Location = new System.Drawing.Point(684, 209);
            this.cbNewPass.Name = "cbNewPass";
            this.cbNewPass.Size = new System.Drawing.Size(22, 21);
            this.cbNewPass.TabIndex = 5;
            this.cbNewPass.UseVisualStyleBackColor = true;
            this.cbNewPass.CheckedChanged += new System.EventHandler(this.cbNewPass_CheckedChanged);
            // 
            // cbConfirmPass
            // 
            this.cbConfirmPass.AutoSize = true;
            this.cbConfirmPass.Location = new System.Drawing.Point(684, 306);
            this.cbConfirmPass.Name = "cbConfirmPass";
            this.cbConfirmPass.Size = new System.Drawing.Size(22, 21);
            this.cbConfirmPass.TabIndex = 5;
            this.cbConfirmPass.UseVisualStyleBackColor = true;
            this.cbConfirmPass.CheckedChanged += new System.EventHandler(this.cbConfirmPass_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(698, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 55);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 430);
            this.Controls.Add(this.cbConfirmPass);
            this.Controls.Add(this.cbNewPass);
            this.Controls.Add(this.lbConfirmPass);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.lbCurPass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMKmoi);
            this.Controls.Add(this.lbMKcu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMKcu;
        private System.Windows.Forms.Label lbMKmoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lbCurPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.CheckBox cbNewPass;
        private System.Windows.Forms.CheckBox cbConfirmPass;
        private System.Windows.Forms.Button btnBack;
    }
}