namespace Entity_Project.Forms
{
    partial class SupplyOrder
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
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(444, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(388, 100);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 1;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(24, 118);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 2;
            label2.Text = "Supplier Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 4;
            label3.Text = "Supply Order NO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Column2, Column3, Column5, Column6 });
            dataGridView1.Location = new Point(31, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 137);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Item
            // 
            Item.HeaderText = "Item #";
            Item.Name = "Item";
            // 
            // Column2
            // 
            Column2.HeaderText = "QTY.";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Item Name";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Production Date";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Exp. Date";
            Column6.Name = "Column6";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(578, 343);
            button1.Name = "button1";
            button1.Size = new Size(133, 46);
            button1.TabIndex = 7;
            button1.Text = "Send Request";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(237, 9);
            label4.Name = "label4";
            label4.Size = new Size(212, 44);
            label4.TabIndex = 8;
            label4.Text = "Supply Order";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(8, 159);
            label5.Name = "label5";
            label5.Size = new Size(119, 19);
            label5.TabIndex = 10;
            label5.Text = "WareHouse Name";
            // 
            // SupplyOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 424);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "SupplyOrder";
            Text = "SupplyOrder";
            Load += SupplyOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label4;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBox4;
        private Label label5;
    }
}