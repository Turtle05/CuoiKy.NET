
namespace CuoiKy_Winform
{
    partial class SUV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUV));
            this.grbSUV = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbGLSClass = new System.Windows.Forms.Label();
            this.lbGLEClass = new System.Windows.Forms.Label();
            this.lbEQBClass = new System.Windows.Forms.Label();
            this.lbGClass = new System.Windows.Forms.Label();
            this.lbGLCClass = new System.Windows.Forms.Label();
            this.pcbGLS_Class = new System.Windows.Forms.PictureBox();
            this.pcbGLE_Class = new System.Windows.Forms.PictureBox();
            this.pcbEQB_Class = new System.Windows.Forms.PictureBox();
            this.pcbG_Class = new System.Windows.Forms.PictureBox();
            this.pcbGLC_Class = new System.Windows.Forms.PictureBox();
            this.grbSUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGLS_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGLE_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEQB_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbG_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGLC_Class)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSUV
            // 
            this.grbSUV.Controls.Add(this.btnExit);
            this.grbSUV.Controls.Add(this.lbGLSClass);
            this.grbSUV.Controls.Add(this.lbGLEClass);
            this.grbSUV.Controls.Add(this.lbEQBClass);
            this.grbSUV.Controls.Add(this.lbGClass);
            this.grbSUV.Controls.Add(this.lbGLCClass);
            this.grbSUV.Controls.Add(this.pcbGLS_Class);
            this.grbSUV.Controls.Add(this.pcbGLE_Class);
            this.grbSUV.Controls.Add(this.pcbEQB_Class);
            this.grbSUV.Controls.Add(this.pcbG_Class);
            this.grbSUV.Controls.Add(this.pcbGLC_Class);
            this.grbSUV.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSUV.Location = new System.Drawing.Point(16, 15);
            this.grbSUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSUV.Name = "grbSUV";
            this.grbSUV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSUV.Size = new System.Drawing.Size(1056, 586);
            this.grbSUV.TabIndex = 1;
            this.grbSUV.TabStop = false;
            this.grbSUV.Text = "SUV";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(904, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbGLSClass
            // 
            this.lbGLSClass.AutoSize = true;
            this.lbGLSClass.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLSClass.Location = new System.Drawing.Point(825, 246);
            this.lbGLSClass.Name = "lbGLSClass";
            this.lbGLSClass.Size = new System.Drawing.Size(114, 24);
            this.lbGLSClass.TabIndex = 1;
            this.lbGLSClass.Text = "GLS - Class";
            this.lbGLSClass.Click += new System.EventHandler(this.lbGLSClass_Click);
            // 
            // lbGLEClass
            // 
            this.lbGLEClass.AutoSize = true;
            this.lbGLEClass.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLEClass.Location = new System.Drawing.Point(464, 246);
            this.lbGLEClass.Name = "lbGLEClass";
            this.lbGLEClass.Size = new System.Drawing.Size(117, 24);
            this.lbGLEClass.TabIndex = 1;
            this.lbGLEClass.Text = "GLE - Class";
            this.lbGLEClass.Click += new System.EventHandler(this.lbGLEClass_Click);
            // 
            // lbEQBClass
            // 
            this.lbEQBClass.AutoSize = true;
            this.lbEQBClass.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQBClass.Location = new System.Drawing.Point(477, 529);
            this.lbEQBClass.Name = "lbEQBClass";
            this.lbEQBClass.Size = new System.Drawing.Size(117, 24);
            this.lbEQBClass.TabIndex = 1;
            this.lbEQBClass.Text = "EQB - Class";
            this.lbEQBClass.Click += new System.EventHandler(this.lbEQBClass_Click);
            // 
            // lbGClass
            // 
            this.lbGClass.AutoSize = true;
            this.lbGClass.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGClass.Location = new System.Drawing.Point(120, 529);
            this.lbGClass.Name = "lbGClass";
            this.lbGClass.Size = new System.Drawing.Size(87, 24);
            this.lbGClass.TabIndex = 1;
            this.lbGClass.Text = "G - Class";
            this.lbGClass.Click += new System.EventHandler(this.lbGClass_Click);
            // 
            // lbGLCClass
            // 
            this.lbGLCClass.AutoSize = true;
            this.lbGLCClass.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGLCClass.Location = new System.Drawing.Point(106, 246);
            this.lbGLCClass.Name = "lbGLCClass";
            this.lbGLCClass.Size = new System.Drawing.Size(114, 24);
            this.lbGLCClass.TabIndex = 1;
            this.lbGLCClass.Text = "GLC - Class";
            this.lbGLCClass.Click += new System.EventHandler(this.lbGLCClass_Click);
            // 
            // pcbGLS_Class
            // 
            this.pcbGLS_Class.Image = ((System.Drawing.Image)(resources.GetObject("pcbGLS_Class.Image")));
            this.pcbGLS_Class.Location = new System.Drawing.Point(758, 42);
            this.pcbGLS_Class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGLS_Class.Name = "pcbGLS_Class";
            this.pcbGLS_Class.Size = new System.Drawing.Size(267, 189);
            this.pcbGLS_Class.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGLS_Class.TabIndex = 0;
            this.pcbGLS_Class.TabStop = false;
            this.pcbGLS_Class.Click += new System.EventHandler(this.pcbGLS_Class_Click);
            // 
            // pcbGLE_Class
            // 
            this.pcbGLE_Class.Image = ((System.Drawing.Image)(resources.GetObject("pcbGLE_Class.Image")));
            this.pcbGLE_Class.Location = new System.Drawing.Point(393, 42);
            this.pcbGLE_Class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGLE_Class.Name = "pcbGLE_Class";
            this.pcbGLE_Class.Size = new System.Drawing.Size(286, 189);
            this.pcbGLE_Class.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGLE_Class.TabIndex = 0;
            this.pcbGLE_Class.TabStop = false;
            this.pcbGLE_Class.Click += new System.EventHandler(this.pcbGLE_Class_Click);
            // 
            // pcbEQB_Class
            // 
            this.pcbEQB_Class.Image = ((System.Drawing.Image)(resources.GetObject("pcbEQB_Class.Image")));
            this.pcbEQB_Class.Location = new System.Drawing.Point(393, 317);
            this.pcbEQB_Class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbEQB_Class.Name = "pcbEQB_Class";
            this.pcbEQB_Class.Size = new System.Drawing.Size(286, 189);
            this.pcbEQB_Class.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEQB_Class.TabIndex = 0;
            this.pcbEQB_Class.TabStop = false;
            this.pcbEQB_Class.Click += new System.EventHandler(this.pcbEQB_Class_Click);
            // 
            // pcbG_Class
            // 
            this.pcbG_Class.Image = ((System.Drawing.Image)(resources.GetObject("pcbG_Class.Image")));
            this.pcbG_Class.Location = new System.Drawing.Point(34, 317);
            this.pcbG_Class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbG_Class.Name = "pcbG_Class";
            this.pcbG_Class.Size = new System.Drawing.Size(278, 189);
            this.pcbG_Class.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbG_Class.TabIndex = 0;
            this.pcbG_Class.TabStop = false;
            this.pcbG_Class.Click += new System.EventHandler(this.pcbG_Class_Click);
            // 
            // pcbGLC_Class
            // 
            this.pcbGLC_Class.Image = ((System.Drawing.Image)(resources.GetObject("pcbGLC_Class.Image")));
            this.pcbGLC_Class.Location = new System.Drawing.Point(34, 42);
            this.pcbGLC_Class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGLC_Class.Name = "pcbGLC_Class";
            this.pcbGLC_Class.Size = new System.Drawing.Size(278, 189);
            this.pcbGLC_Class.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGLC_Class.TabIndex = 0;
            this.pcbGLC_Class.TabStop = false;
            this.pcbGLC_Class.Click += new System.EventHandler(this.pcbGLC_Class_Click);
            // 
            // SUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1090, 617);
            this.Controls.Add(this.grbSUV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SUV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUV";
            this.grbSUV.ResumeLayout(false);
            this.grbSUV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGLS_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGLE_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEQB_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbG_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGLC_Class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSUV;
        private System.Windows.Forms.Label lbGLSClass;
        private System.Windows.Forms.Label lbGLEClass;
        private System.Windows.Forms.Label lbGClass;
        private System.Windows.Forms.Label lbGLCClass;
        private System.Windows.Forms.PictureBox pcbGLS_Class;
        private System.Windows.Forms.PictureBox pcbGLE_Class;
        private System.Windows.Forms.PictureBox pcbG_Class;
        private System.Windows.Forms.PictureBox pcbGLC_Class;
        private System.Windows.Forms.Label lbEQBClass;
        private System.Windows.Forms.PictureBox pcbEQB_Class;
        private System.Windows.Forms.Button btnExit;
    }
}