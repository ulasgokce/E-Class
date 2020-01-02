namespace EClass
{
    partial class Login
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Login1 = new System.Windows.Forms.Button();
            this.rbRememberMe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbShowHide = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(27, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(27, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // Login1
            // 
            this.Login1.Location = new System.Drawing.Point(94, 176);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(75, 23);
            this.Login1.TabIndex = 2;
            this.Login1.Text = "Giriş";
            this.Login1.UseVisualStyleBackColor = true;
            this.Login1.Click += new System.EventHandler(this.Login_Click);
            // 
            // rbRememberMe
            // 
            this.rbRememberMe.AutoSize = true;
            this.rbRememberMe.Location = new System.Drawing.Point(27, 139);
            this.rbRememberMe.Name = "rbRememberMe";
            this.rbRememberMe.Size = new System.Drawing.Size(79, 17);
            this.rbRememberMe.TabIndex = 3;
            this.rbRememberMe.Text = "Beni Hatırla";
            this.rbRememberMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // rbShowHide
            // 
            this.rbShowHide.AutoSize = true;
            this.rbShowHide.Location = new System.Drawing.Point(134, 105);
            this.rbShowHide.Name = "rbShowHide";
            this.rbShowHide.Size = new System.Drawing.Size(87, 17);
            this.rbShowHide.TabIndex = 6;
            this.rbShowHide.Text = "Şifreyi Göster";
            this.rbShowHide.UseVisualStyleBackColor = true;
            this.rbShowHide.CheckedChanged += new System.EventHandler(this.rbShowHide_CheckedChanged);
            this.rbShowHide.Click += new System.EventHandler(this.rbShowHide_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 279);
            this.Controls.Add(this.rbShowHide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRememberMe);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button Login1;
        private System.Windows.Forms.RadioButton rbRememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbShowHide;
    }
}

