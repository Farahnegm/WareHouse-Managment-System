namespace Entity_Project
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmailtextBox = new TextBox();
            PasswordtextBox = new TextBox();
            Email = new Label();
            Password = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            SuspendLayout();
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(356, 102);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(182, 23);
            EmailtextBox.TabIndex = 0;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(356, 170);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(182, 23);
            PasswordtextBox.TabIndex = 1;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(276, 105);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 2;
            Email.Text = "Email";
            Email.Click += label1_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(265, 173);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(401, 275);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(390, 393);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create new Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(47, 27);
            label6.Name = "label6";
            label6.Size = new Size(117, 51);
            label6.TabIndex = 11;
            label6.Text = "Login";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(PasswordtextBox);
            Controls.Add(EmailtextBox);
            Name = "login";
            Text = "Form1";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailtextBox;
        private TextBox PasswordtextBox;
        private Label Email;
        private Label Password;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label6;
    }
}
