namespace PlakDukkani
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
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnLogin = new Button();
            linklblKayit = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(359, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 19;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(359, 136);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(177, 23);
            txtUserName.TabIndex = 18;
            txtUserName.TextChanged += this.txtUserName_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(264, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(272, 29);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // linklblKayit
            // 
            linklblKayit.AutoSize = true;
            linklblKayit.Location = new Point(476, 300);
            linklblKayit.Name = "linklblKayit";
            linklblKayit.Size = new Size(40, 15);
            linklblKayit.TabIndex = 16;
            linklblKayit.TabStop = true;
            linklblKayit.Text = "SignIn";
            linklblKayit.LinkClicked += this.linklblKayit_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 195);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 15;
            label3.Text = "Password :";
            label3.Click += this.label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 139);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 14;
            label2.Text = "User Name :";
            label2.Click += this.label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Controls.Add(linklblKayit);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private LinkLabel linklblKayit;
        private Label label3;
        private Label label2;
    }
}