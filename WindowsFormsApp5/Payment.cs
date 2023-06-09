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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=FAHAD12-PC;Initial Catalog=GYM;Integrated Security=True");
        private void FillName()
        {
            Con.Open();
            SqlCommand cm = new SqlCommand("select MName from MBRTable", Con);
            SqlDataReader rd;
            rd = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rd);
            TimeTb.ValueMember = "MName";
            TimeTb.DataSource = dt;
            Con.Close();



        }
        private void FilterByName()
        {
            Con.Open();
            string Q = "Select * from PayTbl where PId='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Q, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            VIEW.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void popu()
        {
            Con.Open();
            string Q = "Select * from PayTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Q, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            VIEW.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TimeTb.Text == "" || AMNT.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                string pay = timepick.Value.Month.ToString() + timepick.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PayTbl where PMember='" + TimeTb.SelectedValue.ToString() + "'and PMonth='" + pay + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("ALREADY PAID FOR THIS MONTH");

                }

                else
                {
                    string tbl = "insert into PayTbl values ('" + pay + "','" + TimeTb.SelectedValue.ToString() + "'," + AMNT.Text + ")";
                    SqlCommand cmd = new SqlCommand(tbl, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PAID SUCCESSFULLY");
                }
                Con.Close();
                popu();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AMNT.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm b = new MainForm();
            b.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            popu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilterByName();
        }

        private void VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            popu();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
