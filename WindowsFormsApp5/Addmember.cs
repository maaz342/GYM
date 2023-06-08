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
    public partial class Addmember : Form
    {
        public Addmember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=FAHAD12-PC;Initial Catalog=GYM;Integrated Security=True");
        //GRID VIEW MEMBER DATA
        private void popu()
        {
            Con.Open();
            string Q = "Select * from MBRTable";
            SqlDataAdapter sda = new SqlDataAdapter(Q, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            VIEW.DataSource = ds.Tables[0];
            Con.Close();

        }
        int key = 0;
        private void VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(VIEW.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = VIEW.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = VIEW.SelectedRows[0].Cells[2].Value.ToString();

            GenderTb.Text = VIEW.SelectedRows[0].Cells[3].Value.ToString();
            AgeTb.Text = VIEW.SelectedRows[0].Cells[4].Value.ToString();
            TimeTb.Text = VIEW.SelectedRows[0].Cells[5].Value.ToString();
            AmountTb.Text = VIEW.SelectedRows[0].Cells[6].Value.ToString();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            key = Convert.ToInt32(VIEW.SelectedRows[0].Cells[0].Value.ToString());

            if (key == 0 || NameTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "" || PhoneTb.Text == "" || GenderTb.Text == "" || TimeTb.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    Con.Open();
                    string q = "UPDATE MBRTable SET MName='" + NameTb.Text + "', MPhone='" + PhoneTb.Text + "', MGen='" + GenderTb.Text + "', MAge=" + AgeTb.Text + ", MTiming='" + TimeTb.Text + "', MAmount=" + AmountTb.Text + " WHERE MId=" + key + ";";

                    SqlCommand cmd = new SqlCommand(q, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("MEMBER UPDATED SUCCESSFULLY");
                    Con.Close();
                    popu();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            NameTb.Text = "";
            AgeTb.Text = "";
            GenderTb.Text = "";
            AmountTb.Text = "";
            TimeTb.Text = "";
            PhoneTb.Text = "";

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            key = Convert.ToInt32(VIEW.SelectedRows[0].Cells[0].Value.ToString());

            if (key==0)
            {
                MessageBox.Show("SELECT MEMBER TO BE DELETED");
            }
            else
            {
                try
                {
                    Con.Open();
                    string qu = "delete from MBRTable where MId =" + key + ";";
                    SqlCommand cm = new SqlCommand(qu, Con);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("DELETED!!!");
                    Con.Close();
                    popu();

;                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUMBER_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addmember_Load(object sender, EventArgs e)
        {
            popu();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timing_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
