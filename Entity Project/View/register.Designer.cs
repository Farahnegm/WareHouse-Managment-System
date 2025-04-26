namespace Entity_Project.Forms
{
    partial class register
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
            firstName = new TextBox();
            LastName = new TextBox();
            EmailtextBox = new TextBox();
            phonetextBox = new TextBox();
            Fname = new Label();
            Lname = new Label();
            Email = new Label();
            Password = new Label();
            passwordd = new TextBox();
            Cpassword = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            Cpasswordd = new TextBox();
            FaxtextBox = new TextBox();
            MobiletextBox = new TextBox();
            Phone = new Label();
            Mobile = new Label();
            Fax = new Label();
            button1 = new Button();
            WebsitetextBox = new TextBox();
            Website = new Label();
            EmployeecomboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.Location = new Point(142, 115);
            firstName.Name = "firstName";
            firstName.Size = new Size(122, 23);
            firstName.TabIndex = 0;
            firstName.TextChanged += textBox1_TextChanged;
            // 
            // LastName
            // 
            LastName.Location = new Point(395, 114);
            LastName.Name = "LastName";
            LastName.Size = new Size(124, 23);
            LastName.TabIndex = 1;
            LastName.TextChanged += textBox2_TextChanged;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(142, 173);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(159, 23);
            EmailtextBox.TabIndex = 2;
            // 
            // phonetextBox
            // 
            phonetextBox.Location = new Point(142, 233);
            phonetextBox.Name = "phonetextBox";
            phonetextBox.Size = new Size(159, 23);
            phonetextBox.TabIndex = 3;
            phonetextBox.TextChanged += textBox4_TextChanged;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Segoe UI", 10F);
            Fname.Location = new Point(45, 112);
            Fname.Name = "Fname";
            Fname.Size = new Size(75, 19);
            Fname.TabIndex = 4;
            Fname.Text = "First Name";
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Font = new Font("Segoe UI", 10F);
            Lname.Location = new Point(315, 119);
            Lname.Name = "Lname";
            Lname.Size = new Size(74, 19);
            Lname.TabIndex = 5;
            Lname.Text = "Last Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10F);
            Email.Location = new Point(45, 173);
            Email.Name = "Email";
            Email.Size = new Size(41, 19);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 10F);
            Password.Location = new Point(36, 292);
            Password.Name = "Password";
            Password.Size = new Size(67, 19);
            Password.TabIndex = 7;
            Password.Text = "Password";
            Password.Click += label4_Click;
            // 
            // passwordd
            // 
            passwordd.Location = new Point(142, 288);
            passwordd.Name = "passwordd";
            passwordd.Size = new Size(159, 23);
            passwordd.TabIndex = 8;
            // 
            // Cpassword
            // 
            Cpassword.AutoSize = true;
            Cpassword.Font = new Font("Segoe UI", 10F);
            Cpassword.Location = new Point(-4, 356);
            Cpassword.Name = "Cpassword";
            Cpassword.Size = new Size(124, 19);
            Cpassword.TabIndex = 9;
            Cpassword.Text = " Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(263, 20);
            label6.Name = "label6";
            label6.Size = new Size(159, 51);
            label6.TabIndex = 10;
            label6.Text = "Register";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(623, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(531, 51);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 12;
            label7.Text = "User Type";
            label7.Click += label7_Click;
            // 
            // Cpasswordd
            // 
            Cpasswordd.Location = new Point(142, 352);
            Cpasswordd.Name = "Cpasswordd";
            Cpasswordd.Size = new Size(159, 23);
            Cpasswordd.TabIndex = 13;
            // 
            // FaxtextBox
            // 
            FaxtextBox.Location = new Point(395, 177);
            FaxtextBox.Name = "FaxtextBox";
            FaxtextBox.Size = new Size(159, 23);
            FaxtextBox.TabIndex = 14;
            // 
            // MobiletextBox
            // 
            MobiletextBox.Location = new Point(395, 244);
            MobiletextBox.Name = "MobiletextBox";
            MobiletextBox.Size = new Size(159, 23);
            MobiletextBox.TabIndex = 15;
            MobiletextBox.TextChanged += MobiletextBox_TextChanged;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI", 10F);
            Phone.Location = new Point(45, 234);
            Phone.Name = "Phone";
            Phone.Size = new Size(48, 19);
            Phone.TabIndex = 16;
            Phone.Text = "Phone";
            Phone.Click += label8_Click;
            // 
            // Mobile
            // 
            Mobile.AutoSize = true;
            Mobile.Font = new Font("Segoe UI", 10F);
            Mobile.Location = new Point(338, 245);
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(51, 19);
            Mobile.TabIndex = 17;
            Mobile.Text = "Mobile";
            Mobile.Click += Mobile_Click;
            // 
            // Fax
            // 
            Fax.AutoSize = true;
            Fax.Font = new Font("Segoe UI", 10F);
            Fax.Location = new Point(347, 177);
            Fax.Name = "Fax";
            Fax.Size = new Size(29, 19);
            Fax.TabIndex = 18;
            Fax.Text = "Fax";
            // 
            // button1
            // 
            button1.Location = new Point(583, 352);
            button1.Name = "button1";
            button1.Size = new Size(94, 47);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WebsitetextBox
            // 
            WebsitetextBox.Location = new Point(395, 288);
            WebsitetextBox.Name = "WebsitetextBox";
            WebsitetextBox.Size = new Size(159, 23);
            WebsitetextBox.TabIndex = 20;
            // 
            // Website
            // 
            Website.AutoSize = true;
            Website.Font = new Font("Segoe UI", 10F);
            Website.Location = new Point(338, 292);
            Website.Name = "Website";
            Website.Size = new Size(57, 19);
            Website.TabIndex = 21;
            Website.Text = "Website";
            // 
            // EmployeecomboBox
            // 
            EmployeecomboBox.FormattingEnabled = true;
            EmployeecomboBox.Location = new Point(635, 92);
            EmployeecomboBox.Name = "EmployeecomboBox";
            EmployeecomboBox.Size = new Size(121, 23);
            EmployeecomboBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 95);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 23;
            label1.Text = "Employee Role";
            label1.Click += label1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(EmployeecomboBox);
            Controls.Add(Website);
            Controls.Add(WebsitetextBox);
            Controls.Add(button1);
            Controls.Add(Fax);
            Controls.Add(Mobile);
            Controls.Add(Phone);
            Controls.Add(MobiletextBox);
            Controls.Add(FaxtextBox);
            Controls.Add(Cpasswordd);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(Cpassword);
            Controls.Add(passwordd);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Lname);
            Controls.Add(Fname);
            Controls.Add(phonetextBox);
            Controls.Add(EmailtextBox);
            Controls.Add(LastName);
            Controls.Add(firstName);
            Name = "register";
            Text = "register";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstName;
        private TextBox LastName;
        private TextBox EmailtextBox;
        private TextBox phonetextBox;
        private Label Fname;
        private Label Lname;
        private Label Email;
        private Label Password;
        private TextBox passwordd;
        private Label Cpassword;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox Cpasswordd;
        private TextBox FaxtextBox;
        private TextBox MobiletextBox;
        private Label Phone;
        private Label Mobile;
        private Label Fax;
        private Button button1;
        private TextBox WebsitetextBox;
        private Label Website;
        private ComboBox EmployeecomboBox;
        private Label label1;
    }
}