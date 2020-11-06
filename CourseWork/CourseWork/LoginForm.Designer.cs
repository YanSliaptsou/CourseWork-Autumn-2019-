namespace CourseWork
{
    partial class LoginForm
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userEntranceButton = new System.Windows.Forms.Button();
            this.guestEntranceButton = new System.Windows.Forms.Button();
            this.gotoRegisterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(369, 103);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(181, 22);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(369, 48);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(181, 22);
            this.textBoxUsername.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя пользователя:";
            // 
            // userEntranceButton
            // 
            this.userEntranceButton.Location = new System.Drawing.Point(271, 158);
            this.userEntranceButton.Name = "userEntranceButton";
            this.userEntranceButton.Size = new System.Drawing.Size(167, 53);
            this.userEntranceButton.TabIndex = 9;
            this.userEntranceButton.Text = "Войти в систему";
            this.userEntranceButton.UseVisualStyleBackColor = true;
            this.userEntranceButton.Click += new System.EventHandler(this.userEntranceButton_Click);
            // 
            // guestEntranceButton
            // 
            this.guestEntranceButton.Location = new System.Drawing.Point(271, 240);
            this.guestEntranceButton.Name = "guestEntranceButton";
            this.guestEntranceButton.Size = new System.Drawing.Size(167, 53);
            this.guestEntranceButton.TabIndex = 10;
            this.guestEntranceButton.Text = "Войти в кач.гостя";
            this.guestEntranceButton.UseVisualStyleBackColor = true;
            this.guestEntranceButton.Click += new System.EventHandler(this.guestEntranceButton_Click);
            // 
            // gotoRegisterButton
            // 
            this.gotoRegisterButton.Location = new System.Drawing.Point(271, 320);
            this.gotoRegisterButton.Name = "gotoRegisterButton";
            this.gotoRegisterButton.Size = new System.Drawing.Size(167, 53);
            this.gotoRegisterButton.TabIndex = 11;
            this.gotoRegisterButton.Text = "Перейти к регистрации";
            this.gotoRegisterButton.UseVisualStyleBackColor = true;
            this.gotoRegisterButton.Click += new System.EventHandler(this.gotoRegisterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(271, 397);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 53);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 471);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gotoRegisterButton);
            this.Controls.Add(this.guestEntranceButton);
            this.Controls.Add(this.userEntranceButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userEntranceButton;
        private System.Windows.Forms.Button guestEntranceButton;
        private System.Windows.Forms.Button gotoRegisterButton;
        private System.Windows.Forms.Button exitButton;
    }
}