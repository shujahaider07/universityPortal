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
    public partial class admission : Form
    {
        public admission()
        {
            InitializeComponent();
           
        }
        //SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
    
    private void button4_Click(object sender, EventArgs e)
        {
            Class2.sql.Open();
            string query = "insert into addmission ( studentname,program,religion,   gender ,  CNIC , address, pincode , contact ,country,email) values('" + fullnametxt.Text + "','" + coursetxt.Text + "','" + religiontxt.Text + "','" + gendertext.Text + "','" + cnictxt.Text + "','" + addresstxt.Text + "','" + pincodetxt.Text + "','" + mobtxt.Text + "','" + countrytxt.Text + "','"+emailtxt.Text+"')";


            SqlCommand cmd = new SqlCommand(query,Class2.sql);
                cmd.ExecuteNonQuery();
            addresstxt.Clear();
            fullnametxt.Clear();
            gendertext.Clear();
            countrytxt.Clear();
            cnictxt.Clear();
            religiontxt.Clear();
            addresstxt.Clear();
            citytxt.Clear();
            coursetxt.Clear();
            //emailtxt.Clear();
            pincodetxt.Clear();
            countrytxt.Clear();
            mobtxt.Clear();
            emailtxt.Clear();
            admnotxt.Clear();
            autoid();



           MessageBox.Show("Record added");



            Class2.sql.Close();
        }

        private void admission_Load(object sender, EventArgs e)
        {
            autoid();

        }
    
        public void autoid()
        {
            
            String qry = "select count(addmissionid)+1  from addmission";
            SqlDataAdapter da = new SqlDataAdapter(qry,Class2.sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admnotxt.Text = dt.Rows[0][0].ToString();
          
        }
    }


}
