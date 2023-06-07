using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=FAHAD12-PC;Initial Catalog=GYM;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == ""||PhoneTb.Text=="")
            {
                MessageBox.Show("MISSING INFO");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Table values ('" + NameTb.Text + "','" + PhoneTb.Text + "','" + comboBox2.SelectedItem.ToString() + "','" + AgeTb.Text + "','" + AmountTb.Text + "','" + comboBox1.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("MEMBER ADDED SUCESSFULLY");
                    Con.Close();
                    

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
