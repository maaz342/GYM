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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.NUMBER = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenderTb = new System.Windows.Forms.ComboBox();
            this.Amount = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.timing = new System.Windows.Forms.Label();
            this.TimeTb = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VIEW = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VIEW)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Member Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(44, 153);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(269, 22);
            this.NameTb.TabIndex = 5;
            this.NameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NUMBER
            // 
            this.NUMBER.AutoSize = true;
            this.NUMBER.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NUMBER.ForeColor = System.Drawing.Color.Navy;
            this.NUMBER.Location = new System.Drawing.Point(42, 178);
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.Size = new System.Drawing.Size(157, 23);
            this.NUMBER.TabIndex = 6;
            this.NUMBER.Text = "Phone Number";
            this.NUMBER.Click += new System.EventHandler(this.NUMBER_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(44, 214);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(269, 22);
            this.PhoneTb.TabIndex = 7;
            this.PhoneTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(42, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(44, 272);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(269, 22);
            this.AgeTb.TabIndex = 9;
            this.AgeTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(42, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // GenderTb
            // 
            this.GenderTb.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.GenderTb.FormattingEnabled = true;
            this.GenderTb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderTb.Location = new System.Drawing.Point(46, 442);
            this.GenderTb.Name = "GenderTb";
            this.GenderTb.Size = new System.Drawing.Size(121, 35);
            this.GenderTb.TabIndex = 11;
            this.GenderTb.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Amount.ForeColor = System.Drawing.Color.Navy;
            this.Amount.Location = new System.Drawing.Point(40, 298);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(171, 23);
            this.Amount.TabIndex = 12;
            this.Amount.Text = "Monthly Amount";
            this.Amount.Click += new System.EventHandler(this.Amount_Click);
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(46, 324);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(269, 22);
            this.AmountTb.TabIndex = 13;
            this.AmountTb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // timing
            // 
            this.timing.AutoSize = true;
            this.timing.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.timing.ForeColor = System.Drawing.Color.Navy;
            this.timing.Location = new System.Drawing.Point(42, 349);
            this.timing.Name = "timing";
            this.timing.Size = new System.Drawing.Size(68, 23);
            this.timing.TabIndex = 14;
            this.timing.Text = "Timing";
            this.timing.Click += new System.EventHandler(this.timing_Click);
            // 
            // TimeTb
            // 
            this.TimeTb.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TimeTb.FormattingEnabled = true;
            this.TimeTb.Items.AddRange(new object[] {
            "6-8",
            "9-11",
            "1-4",
            "6-10"});
            this.TimeTb.Location = new System.Drawing.Point(44, 375);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(121, 35);
            this.TimeTb.TabIndex = 15;
            this.TimeTb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Location = new System.Drawing.Point(-3, 496);
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
            this.button1.Location = new System.Drawing.Point(262, 496);
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
            this.button2.Location = new System.Drawing.Point(128, 546);
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
            this.button3.Location = new System.Drawing.Point(128, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VIEW
            // 
            this.VIEW.BackgroundColor = System.Drawing.Color.White;
            this.VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VIEW.Location = new System.Drawing.Point(386, 131);
            this.VIEW.Name = "VIEW";
            this.VIEW.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.VIEW.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.VIEW.RowTemplate.Height = 24;
            this.VIEW.Size = new System.Drawing.Size(1052, 474);
            this.VIEW.TabIndex = 20;
            this.VIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VIEW_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(624, 105);
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
            this.ClientSize = new System.Drawing.Size(1450, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VIEW);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.TimeTb);
            this.Controls.Add(this.timing);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.GenderTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.NUMBER);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addmember";
            this.Text = "Addmember";
            this.Load += new System.EventHandler(this.Addmember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label NUMBER;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GenderTb;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label timing;
        private System.Windows.Forms.ComboBox TimeTb;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView VIEW;
        private System.Windows.Forms.Label label4;
    }
}