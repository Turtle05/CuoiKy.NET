namespace CuoiKy_Winform
{
    partial class Form_EditInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbNationality = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNationality);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.lbMemberName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lbNationality);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.lbMail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Information:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(583, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 36);
            this.txtEmail.TabIndex = 44;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(207, 182);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(228, 36);
            this.txtNationality.TabIndex = 43;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(207, 114);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(228, 36);
            this.txtGender.TabIndex = 42;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberName.Location = new System.Drawing.Point(14, 47);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(187, 29);
            this.lbMemberName.TabIndex = 34;
            this.lbMemberName.Text = "Member_Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(583, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(225, 36);
            this.txtPhone.TabIndex = 41;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(14, 117);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(100, 29);
            this.lbGender.TabIndex = 39;
            this.lbGender.Text = "Gender:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(583, 42);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 36);
            this.txtAddress.TabIndex = 37;
            // 
            // lbNationality
            // 
            this.lbNationality.AutoSize = true;
            this.lbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationality.Location = new System.Drawing.Point(14, 185);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(131, 29);
            this.lbNationality.TabIndex = 32;
            this.lbNationality.Text = "Nationality:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(207, 47);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(228, 36);
            this.txtMemberName.TabIndex = 35;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(469, 42);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(108, 29);
            this.lbAddress.TabIndex = 36;
            this.lbAddress.Text = "Address:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(469, 116);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(89, 29);
            this.lbPhone.TabIndex = 40;
            this.lbPhone.Text = "Phone:";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(469, 183);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(64, 29);
            this.lbMail.TabIndex = 33;
            this.lbMail.Text = "Mail:";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(197, 306);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(174, 46);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(458, 306);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(174, 46);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 360);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_EditInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbNationality;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbMail;
    }
}