namespace Entity_Project.Forms
{
    partial class WareHouse
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            warehouseLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(223, 325);
            button1.Name = "button1";
            button1.Size = new Size(105, 44);
            button1.TabIndex = 0;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Add_Button;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Location = new Point(376, 325);
            button2.Name = "button2";
            button2.Size = new Size(97, 44);
            button2.TabIndex = 1;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 529);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 210);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(376, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(420, 247);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // warehouseLabel
            // 
            warehouseLabel.AutoSize = true;
            warehouseLabel.Location = new Point(12, 66);
            warehouseLabel.Name = "warehouseLabel";
            warehouseLabel.Size = new Size(82, 15);
            warehouseLabel.TabIndex = 10;
            warehouseLabel.Text = "WareHouse ID";
            warehouseLabel.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 102);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 11;
            label2.Text = "WareHouse Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 12;
            label3.Text = "Location";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 185);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 13;
            label4.Text = "Responsible Person ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(442, 12);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(299, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(376, 14);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 15;
            label5.Text = "Search";
            label5.Click += label5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(136, 63);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(222, 23);
            textBox6.TabIndex = 16;
            // 
            // WareHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(warehouseLabel);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "WareHouse";
            Text = "WareHouse";
            Load += WareHouse_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label warehouseLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
    }
}