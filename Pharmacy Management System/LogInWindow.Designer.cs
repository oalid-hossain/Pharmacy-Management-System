namespace Pharmacy_Management_System
{
    partial class LogInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogWinMinimize = new System.Windows.Forms.Button();
            this.btnLogWinFullScreen = new System.Windows.Forms.Button();
            this.btnLogWinClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLwErrorPassword = new System.Windows.Forms.Label();
            this.lblLwErrorUserName = new System.Windows.Forms.Label();
            this.chkLwShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogWinSignIn = new System.Windows.Forms.Button();
            this.btnLwClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLwPassword = new System.Windows.Forms.TextBox();
            this.txtLwUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 770);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(149, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 40);
            this.label7.TabIndex = 2;
            this.label7.Text = "System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pharmacy Management \r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 770);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblLwErrorPassword);
            this.panel2.Controls.Add(this.lblLwErrorUserName);
            this.panel2.Controls.Add(this.chkLwShowPassword);
            this.panel2.Controls.Add(this.btnLogWinSignIn);
            this.panel2.Controls.Add(this.btnLwClear);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtLwPassword);
            this.panel2.Controls.Add(this.txtLwUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(505, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 770);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLogWinMinimize);
            this.panel6.Controls.Add(this.btnLogWinFullScreen);
            this.panel6.Controls.Add(this.btnLogWinClose);
            this.panel6.Location = new System.Drawing.Point(588, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 26);
            this.panel6.TabIndex = 15;
            // 
            // btnLogWinMinimize
            // 
            this.btnLogWinMinimize.Location = new System.Drawing.Point(3, 3);
            this.btnLogWinMinimize.Name = "btnLogWinMinimize";
            this.btnLogWinMinimize.Size = new System.Drawing.Size(75, 23);
            this.btnLogWinMinimize.TabIndex = 2;
            this.btnLogWinMinimize.Text = "Minimize";
            this.btnLogWinMinimize.UseVisualStyleBackColor = true;
            this.btnLogWinMinimize.Click += new System.EventHandler(this.btnLogWinMinimize_Click);
            // 
            // btnLogWinFullScreen
            // 
            this.btnLogWinFullScreen.Location = new System.Drawing.Point(80, 3);
            this.btnLogWinFullScreen.Name = "btnLogWinFullScreen";
            this.btnLogWinFullScreen.Size = new System.Drawing.Size(106, 23);
            this.btnLogWinFullScreen.TabIndex = 1;
            this.btnLogWinFullScreen.Text = "Full Screen";
            this.btnLogWinFullScreen.UseVisualStyleBackColor = true;
            this.btnLogWinFullScreen.Click += new System.EventHandler(this.btnLogWinFullScreen_Click);
            // 
            // btnLogWinClose
            // 
            this.btnLogWinClose.Location = new System.Drawing.Point(192, 3);
            this.btnLogWinClose.Name = "btnLogWinClose";
            this.btnLogWinClose.Size = new System.Drawing.Size(75, 23);
            this.btnLogWinClose.TabIndex = 0;
            this.btnLogWinClose.Text = "Close";
            this.btnLogWinClose.UseVisualStyleBackColor = true;
            this.btnLogWinClose.Click += new System.EventHandler(this.btnLogWinClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login Information";
            // 
            // lblLwErrorPassword
            // 
            this.lblLwErrorPassword.AutoSize = true;
            this.lblLwErrorPassword.Location = new System.Drawing.Point(295, 452);
            this.lblLwErrorPassword.Name = "lblLwErrorPassword";
            this.lblLwErrorPassword.Size = new System.Drawing.Size(0, 16);
            this.lblLwErrorPassword.TabIndex = 9;
            // 
            // lblLwErrorUserName
            // 
            this.lblLwErrorUserName.AutoSize = true;
            this.lblLwErrorUserName.Location = new System.Drawing.Point(295, 383);
            this.lblLwErrorUserName.Name = "lblLwErrorUserName";
            this.lblLwErrorUserName.Size = new System.Drawing.Size(0, 16);
            this.lblLwErrorUserName.TabIndex = 8;
            // 
            // chkLwShowPassword
            // 
            this.chkLwShowPassword.AutoSize = true;
            this.chkLwShowPassword.Location = new System.Drawing.Point(587, 429);
            this.chkLwShowPassword.Name = "chkLwShowPassword";
            this.chkLwShowPassword.Size = new System.Drawing.Size(125, 20);
            this.chkLwShowPassword.TabIndex = 7;
            this.chkLwShowPassword.Text = "Show Password";
            this.chkLwShowPassword.UseVisualStyleBackColor = true;
            this.chkLwShowPassword.CheckedChanged += new System.EventHandler(this.chkLwShowPassword_CheckedChanged);
            // 
            // btnLogWinSignIn
            // 
            this.btnLogWinSignIn.Location = new System.Drawing.Point(449, 520);
            this.btnLogWinSignIn.Name = "btnLogWinSignIn";
            this.btnLogWinSignIn.Size = new System.Drawing.Size(132, 54);
            this.btnLogWinSignIn.TabIndex = 6;
            this.btnLogWinSignIn.Text = "Sign in";
            this.btnLogWinSignIn.UseVisualStyleBackColor = true;
            this.btnLogWinSignIn.Click += new System.EventHandler(this.btnLogWinSignIn_Click);
            // 
            // btnLwClear
            // 
            this.btnLwClear.Location = new System.Drawing.Point(298, 520);
            this.btnLwClear.Name = "btnLwClear";
            this.btnLwClear.Size = new System.Drawing.Size(132, 54);
            this.btnLwClear.TabIndex = 5;
            this.btnLwClear.Text = "Clear";
            this.btnLwClear.UseVisualStyleBackColor = true;
            this.btnLwClear.Click += new System.EventHandler(this.btnLogWinClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // txtLwPassword
            // 
            this.txtLwPassword.Location = new System.Drawing.Point(298, 427);
            this.txtLwPassword.Name = "txtLwPassword";
            this.txtLwPassword.Size = new System.Drawing.Size(283, 22);
            this.txtLwPassword.TabIndex = 2;
            this.txtLwPassword.UseSystemPasswordChar = true;
            // 
            // txtLwUserName
            // 
            this.txtLwUserName.Location = new System.Drawing.Point(298, 358);
            this.txtLwUserName.Name = "txtLwUserName";
            this.txtLwUserName.Size = new System.Drawing.Size(283, 22);
            this.txtLwUserName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkLwShowPassword;
        private System.Windows.Forms.Button btnLogWinSignIn;
        private System.Windows.Forms.Button btnLwClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLwPassword;
        private System.Windows.Forms.TextBox txtLwUserName;
        private System.Windows.Forms.Label lblLwErrorPassword;
        private System.Windows.Forms.Label lblLwErrorUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLogWinMinimize;
        private System.Windows.Forms.Button btnLogWinFullScreen;
        private System.Windows.Forms.Button btnLogWinClose;
    }
}

