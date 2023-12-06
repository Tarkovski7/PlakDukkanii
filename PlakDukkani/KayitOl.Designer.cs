namespace PlakDukkani
{
    partial class KayitOl
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
            btnSignIn = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(264, 322);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(277, 23);
            btnSignIn.TabIndex = 32;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 276);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 31;
            label5.Text = "Confirm Password  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 232);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 30;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 190);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 29;
            label3.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 28;
            label2.Text = "Last Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 109);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 27;
            label1.Text = "First Name :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.ImeMode = ImeMode.NoControl;
            txtConfirmPassword.Location = new Point(377, 273);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(184, 23);
            txtConfirmPassword.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(377, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(184, 23);
            txtPassword.TabIndex = 25;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(377, 187);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(184, 23);
            txtUserName.TabIndex = 24;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(377, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(184, 23);
            txtLastName.TabIndex = 23;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(377, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(184, 23);
            txtFirstName.TabIndex = 22;
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignIn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "KayitOl";
            Text = "KayitOl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
    }
}