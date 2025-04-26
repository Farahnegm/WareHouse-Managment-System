namespace Entity_Project.Forms
{
    partial class Customer
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SearchtextBox = new TextBox();
            dataGridView1 = new DataGridView();
            Addbutton = new Button();
            Updatebutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(115, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(115, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(192, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(115, 306);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(192, 23);
            textBox6.TabIndex = 5;
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(477, 48);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(264, 23);
            SearchtextBox.TabIndex = 6;
            SearchtextBox.TextChanged += textBox7_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(411, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 234);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Addbutton
            // 
            Addbutton.BackColor = Color.Green;
            Addbutton.Location = new Point(393, 381);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(99, 40);
            Addbutton.TabIndex = 8;
            Addbutton.Text = "ADD";
            Addbutton.UseVisualStyleBackColor = false;
            Addbutton.Click += button1_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.Firebrick;
            Updatebutton.Font = new Font("Segoe UI", 10F);
            Updatebutton.Location = new Point(525, 381);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(99, 40);
            Updatebutton.TabIndex = 9;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = false;
            Updatebutton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(0, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 10;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(36, 93);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 11;
            label2.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 12;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(36, 204);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(45, 256);
            label5.Name = "label5";
            label5.Size = new Size(29, 19);
            label5.TabIndex = 14;
            label5.Text = "Fax";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(36, 314);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 15;
            label6.Text = "Website";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(411, 49);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 16;
            label7.Text = "Search";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Updatebutton);
            Controls.Add(Addbutton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchtextBox);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox SearchtextBox;
        private DataGridView dataGridView1;
        private Button Addbutton;
        private Button Updatebutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}