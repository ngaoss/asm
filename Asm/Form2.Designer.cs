namespace Asm
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            btnExit = new Button();
            btnLogin = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Password = new Label();
            Username = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(467, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += buttonExit;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(195, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += buttonLogin;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 213);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 110);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 23);
            textBox1.TabIndex = 8;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(175, 216);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 7;
            Password.Text = "Password";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(172, 113);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 6;
            Username.Text = "Username";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Password);
            Controls.Add(Username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label Password;
        private Label Username;
    }
}