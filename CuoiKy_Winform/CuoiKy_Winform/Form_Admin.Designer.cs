namespace CuoiKy_Winform
{
    partial class Form_Admin
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
            this.components = new System.ComponentModel.Container();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btUserAccount = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btCar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.lbNameRole = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDesktop.Controls.Add(this.btExit);
            this.panelDesktop.Controls.Add(this.btUserAccount);
            this.panelDesktop.Controls.Add(this.btUser);
            this.panelDesktop.Controls.Add(this.btCar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(0, 83);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(860, 551);
            this.panelDesktop.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btExit.FlatAppearance.BorderSize = 5;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btExit.Location = new System.Drawing.Point(289, 433);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(265, 74);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btUserAccount
            // 
            this.btUserAccount.BackColor = System.Drawing.Color.DodgerBlue;
            this.btUserAccount.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btUserAccount.FlatAppearance.BorderSize = 5;
            this.btUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btUserAccount.Location = new System.Drawing.Point(289, 300);
            this.btUserAccount.Name = "btUserAccount";
            this.btUserAccount.Size = new System.Drawing.Size(265, 74);
            this.btUserAccount.TabIndex = 4;
            this.btUserAccount.Text = "List User";
            this.btUserAccount.UseVisualStyleBackColor = false;
            this.btUserAccount.Click += new System.EventHandler(this.btUserAccount_Click);
            // 
            // btUser
            // 
            this.btUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btUser.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btUser.FlatAppearance.BorderSize = 5;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btUser.Location = new System.Drawing.Point(289, 29);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(265, 74);
            this.btUser.TabIndex = 2;
            this.btUser.Text = "User";
            this.btUser.UseVisualStyleBackColor = false;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btCar
            // 
            this.btCar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btCar.FlatAppearance.BorderSize = 5;
            this.btCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCar.Location = new System.Drawing.Point(289, 161);
            this.btCar.Name = "btCar";
            this.btCar.Size = new System.Drawing.Size(265, 74);
            this.btCar.TabIndex = 3;
            this.btCar.Text = "Car";
            this.btCar.UseVisualStyleBackColor = false;
            this.btCar.Click += new System.EventHandler(this.btCar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.lbNameRole);
            this.panel2.Controls.Add(this.lbRole);
            this.panel2.Controls.Add(this.lbNameUser);
            this.panel2.Controls.Add(this.lbWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 90);
            this.panel2.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(697, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(139, 29);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // lbNameRole
            // 
            this.lbNameRole.AutoSize = true;
            this.lbNameRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameRole.Location = new System.Drawing.Point(558, 30);
            this.lbNameRole.Name = "lbNameRole";
            this.lbNameRole.Size = new System.Drawing.Size(81, 29);
            this.lbNameRole.TabIndex = 3;
            this.lbNameRole.Text = "Admin";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(477, 30);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(75, 29);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Role:";
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUser.Location = new System.Drawing.Point(146, 31);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(287, 29);
            this.lbNameUser.TabIndex = 1;
            this.lbNameUser.Text = "Nguyễn Nho Song Hoàng";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(11, 30);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(129, 29);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Admin";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Admin";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panelDesktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNameRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btUserAccount;
        private System.Windows.Forms.Button btCar;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}