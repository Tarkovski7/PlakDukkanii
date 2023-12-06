namespace PlakDukkani
{
    partial class Girisyap
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
            label1 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnLogin = new Button();
            linklblKayit = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(273, 15);
            label1.TabIndex = 26;
            label1.Text = "Plak Dükkanı Album Kayıt Programına Hoşgeldiniz";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 25;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(127, 81);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(177, 23);
            txtUserName.TabIndex = 24;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(101, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(203, 29);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // linklblKayit
            // 
            linklblKayit.AutoSize = true;
            linklblKayit.Location = new Point(32, 169);
            linklblKayit.Name = "linklblKayit";
            linklblKayit.Size = new Size(48, 15);
            linklblKayit.TabIndex = 22;
            linklblKayit.TabStop = true;
            linklblKayit.Text = "Kayıt Ol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 124);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 21;
            label4.Text = "Şifre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 84);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 20;
            label5.Text = "Kullanıcı Adı :";
            // 
            // Girisyap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 234);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Controls.Add(linklblKayit);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "Girisyap";
            Text = "Plak Dükkanı Giriş Ekranı";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private LinkLabel linklblKayit;
        private Label label4;
        private Label label5;
    }
}