namespace PlakDukkani
{
    partial class SifreDegistirme
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
            txtConfirmNewPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            btnChangePassword = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(384, 237);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(189, 23);
            txtConfirmNewPassword.TabIndex = 20;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(384, 191);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(189, 23);
            txtNewPassword.TabIndex = 19;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(384, 142);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(189, 23);
            txtCurrentPassword.TabIndex = 18;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(283, 286);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(270, 23);
            btnChangePassword.TabIndex = 17;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 240);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 16;
            label3.Text = "Confirm New Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 194);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 15;
            label2.Text = "New Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 145);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 14;
            label1.Text = "Current Password :";
            // 
            // SifreDegistirme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(btnChangePassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SifreDegistirme";
            Text = "SifreDegistirme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConfirmNewPassword;
        private TextBox txtNewPassword;
        private TextBox txtCurrentPassword;
        private Button btnChangePassword;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}