namespace WindowsFormsApp5
{
    partial class Addmember
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NUMBER = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Amount = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timing = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(343, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "FITNESS CENTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(313, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update And Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(55, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Member Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NUMBER
            // 
            this.NUMBER.AutoSize = true;
            this.NUMBER.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NUMBER.ForeColor = System.Drawing.Color.Navy;
            this.NUMBER.Location = new System.Drawing.Point(57, 183);
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.Size = new System.Drawing.Size(157, 23);
            this.NUMBER.TabIndex = 6;
            this.NUMBER.Text = "Phone Number";
            this.NUMBER.Click += new System.EventHandler(this.NUMBER_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(57, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(57, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(61, 447);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 35);
            this.Gender.TabIndex = 11;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Amount.ForeColor = System.Drawing.Color.Navy;
            this.Amount.Location = new System.Drawing.Point(55, 303);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(171, 23);
            this.Amount.TabIndex = 12;
            this.Amount.Text = "Monthly Amount";
            this.Amount.Click += new System.EventHandler(this.Amount_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 329);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(269, 22);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // timing
            // 
            this.timing.AutoSize = true;
            this.timing.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.timing.ForeColor = System.Drawing.Color.Navy;
            this.timing.Location = new System.Drawing.Point(57, 354);
            this.timing.Name = "timing";
            this.timing.Size = new System.Drawing.Size(68, 23);
            this.timing.TabIndex = 14;
            this.timing.Text = "Timing";
            this.timing.Click += new System.EventHandler(this.timing_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6-8",
            "9-11",
            "1-4",
            "6-10"});
            this.comboBox1.Location = new System.Drawing.Point(59, 380);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 35);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Location = new System.Drawing.Point(12, 501);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(103, 39);
            this.add.TabIndex = 16;
            this.add.Text = "Update";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(277, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(143, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(143, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 385);
            this.dataGridView1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(493, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Click On Member To Be Deleted";
            // 
            // Addmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.timing);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NUMBER);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addmember";
            this.Text = "Addmember";
            this.Load += new System.EventHandler(this.Addmember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NUMBER;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label timing;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
    }
}