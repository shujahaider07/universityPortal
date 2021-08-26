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
            admnotxt.KeyUp += Admnotxt_KeyUp;
            fullnametxt.KeyUp += Fullnametxt_KeyUp;
            gendertext.KeyUp += Gendertext_KeyUp;
            coursetxt.KeyUp += Coursetxt_KeyUp;
            cnictxt.KeyUp += Cnictxt_KeyUp;
            religiontxt.KeyUp += Religiontxt_KeyUp;
            addresstxt.KeyUp += Addresstxt_KeyUp;
            citytxt.KeyUp += Citytxt_KeyUp;
            pincodetxt.KeyUp += Pincodetxt_KeyUp;
            countrytxt.KeyUp += Countrytxt_KeyUp;
            mobtxt.KeyUp += Mobtxt_KeyUp;
            emailtxt.KeyUp += Emailtxt_KeyUp;
        
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void Emailtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button4.Focus();
            }
        }

        private void Mobtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                emailtxt.Focus();
            }
        }

        private void Countrytxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                mobtxt.Focus();

            }
        }

        private void Pincodetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                countrytxt.Focus();
            }
        }

        private void Citytxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                pincodetxt.Focus();
            }
        }

        private void Addresstxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                citytxt.Focus();
            }
        }

        private void Religiontxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                addresstxt.Focus();
            }
        }

        private void Cnictxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                religiontxt.Focus();
            }
        }

        private void Coursetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                cnictxt.Focus();
            }
        }

        private void Gendertext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                coursetxt.Focus();
            }
        }

        private void Fullnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                gendertext.Focus();
            }
        }

        private void Admnotxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fullnametxt.Focus();
            }
        }

        public static string address;
        public static string pincode;
        public static string mobile;
        public static string country;
        public static string email;
        public static string name;
        public static string program;
        public static string religion;
        public static string gender;
        public static string cnic;
        public static int id;

        private void button4_Click(object sender, EventArgs e)
        {

            id = Convert.ToInt32(admnotxt.Text);
            name = fullnametxt.Text;
            program = coursetxt.Text;
            religion = religiontxt.Text;
            gender = gendertext.Text;
            cnic = cnictxt.Text;
            address = addresstxt.Text;
            pincode = pincodetxt.Text;
            mobile = mobtxt.Text;
            country = countrytxt.Text;
            email = emailtxt.Text;
          
        }

        public void admission_Load(object sender, EventArgs e)
        {
            
        }

        public void autoid()
        {
            con.Open();
            String qry = "select count(addmissionid)+1  from addmission";
            SqlDataAdapter da = new SqlDataAdapter(qry,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admnotxt.Text = dt.Rows[0][0].ToString();
            con.Close();
               
          
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PARENTS p = new PARENTS();
            p.Show();
            this.Hide();
        }

        private void admission_Load_1(object sender, EventArgs e)
        {
            autoid();
        }

        private void admnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void admnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pincodetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch))
            {
                e.Handled = false;
                
            }
            else if (ch == 8 )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }


}
