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
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=FAHAD12-PC;Initial Catalog=GYM;Integrated Security=True");
        //GRID VIEW MEMBER DATA
        private void popu()
        {
            Con.Open();
            string Q = "Select * from MBRTable";
            SqlDataAdapter sda = new SqlDataAdapter(Q,Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
          VIEW.DataSource=ds.Tables[0];
            Con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            popu();

        }
    }
}
