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

        private void FEES_Load(object sender, EventArgs e)
        {

            //Class2.sql.Open();
            //string qrry = "select * from fees ";
            //SqlDataAdapter da = new SqlDataAdapter(qrry,Class2.sql);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //Class2.sql.Close();









        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
