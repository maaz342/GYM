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
    public partial class Addmember: Form
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = VIEW.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = VIEW.SelectedRows[0].Cells[2].Value.ToString();
            AgeTb.Text = VIEW.SelectedRows[0].Cells[4].Value.ToString();
            GenderTb.Text = VIEW.SelectedRows[0].Cells[3].Value.ToString();
            TimeTb.Text = VIEW.SelectedRows[0].Cells[5].Value.ToString();
            AmountTb.Text = VIEW.SelectedRows[0].Cells[6].Value.ToString();


        }
    }
}
