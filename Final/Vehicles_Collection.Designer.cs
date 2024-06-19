namespace Final
{
    partial class Vehicles_Collection
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            label1.Location = new Point(260, 77);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 0;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            label2.Location = new Point(626, 80);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            label3.Location = new Point(228, 150);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 2;
            label3.Text = "name_model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            label4.Location = new Point(626, 153);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 3;
            label4.Text = "year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            label5.Location = new Point(240, 238);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 4;
            label5.Text = "price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(705, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(390, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(705, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(390, 234);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button1.Location = new Point(280, 292);
            button1.Name = "button1";
            button1.Size = new Size(154, 49);
            button1.TabIndex = 10;
            button1.Text = "insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button2.Location = new Point(469, 294);
            button2.Name = "button2";
            button2.Size = new Size(154, 47);
            button2.TabIndex = 11;
            button2.Text = "update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button3.Location = new Point(676, 294);
            button3.Name = "button3";
            button3.Size = new Size(154, 47);
            button3.TabIndex = 12;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(244, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(636, 218);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            label6.Location = new Point(612, 237);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 14;
            label6.Text = "rented";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(705, 237);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cartoon_super_cars_vector;
            pictureBox1.Location = new Point(3, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 559);
            panel1.TabIndex = 17;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button6.Location = new Point(3, 430);
            button6.Name = "button6";
            button6.Size = new Size(204, 73);
            button6.TabIndex = 20;
            button6.Text = "logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button5.Location = new Point(25, 350);
            button5.Name = "button5";
            button5.Size = new Size(154, 47);
            button5.TabIndex = 19;
            button5.Text = "back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(899, 55);
            button4.TabIndex = 18;
            button4.Text = "vehicles mangment";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Vehicles_Collection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 577);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vehicles_Collection";
            Text = "Vehicles_Collection";
            Load += Vehicles_Collection_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button4;
        private Button button6;
        private Button button5;
    }
}