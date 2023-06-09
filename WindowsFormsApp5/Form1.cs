using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else if (textBox1.Text == "ADMIN" && textBox2.Text == "ADMIN" || textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("LOGGED IN SUCESSFULLY");
                MainForm n = new MainForm();
                n.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WRONG ID OR PASSWORD");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
    }

