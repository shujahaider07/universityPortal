using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace universityPortal
{
    public partial class FEES : Form
    {
        public FEES()

        {
            InitializeComponent();
        }

       SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void FEES_Load(object sender, EventArgs e)
        {
            con.Open();
            string qrry = "select * from fees ";
            SqlDataAdapter da = new SqlDataAdapter(qrry,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


         


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   con.Open();
            string qry1 = "insert into fees (studentid,amount, PAID , remaining, PROGRAM  ) values('" + rolltxt.Text + "','" + fullnametxt.Text + "','" + coursetxt.Text + "','" + ammounttxt.Text + "','" + paidtxt.Text + "','" + remaintxt.Text + "')";
            SqlCommand cmd = new SqlCommand(qry1, con);
            cmd.ExecuteNonQuery();



            con.Close();*/

        }
    }
}
