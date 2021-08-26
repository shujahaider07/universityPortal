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
    public partial class PARENTS : Form
    {
        public PARENTS()
        {
            InitializeComponent();

            fnametxt.KeyUp += Fnametxt_KeyUp;
            mnametxt.KeyUp += Mnametxt_KeyUp;
            foc.KeyUp += Foc_KeyUp;
            moccutxt.KeyUp += Moccutxt_KeyUp;
            incometxt.KeyUp += Incometxt_KeyUp;
        
        }

        private void Incometxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button4.Focus();
            }
        }

        private void Moccutxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                incometxt.Focus();
            }
        }

        private void Foc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                moccutxt.Focus();
            }
        }

        private void Mnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                foc.Focus();
            }
        }

        private void Fnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                mnametxt.Focus();
            }
        }

        private void PARENTS_Load(object sender, EventArgs e)
        {

        }

        public  void button4_Click(object sender, EventArgs e)
        {

         



            Class2.sql.Open();
            //  string query = "insert into addmission (addmissionid,studentname,program,religion,   gender ,  CNIC , address, pincode , contact ,country,email,fathername, fOccupation ,income , mothername, mOccupation ) values('" + admission.id+"','"+admission.name+ "','"+admission.program+ "','"+admission.religion+ "''"+admission.gender+ "','"+admission.cnic+ "''"+admission.address+ "''"+admission.pincode+ "','"+admission.mobile+ "', '"+admission.country+ "','"+admission.email+ "','"+fnametxt.Text+ "','"+foc.Text+ "','"+incometxt.Text+ "','"+mnametxt.Text+ "','"+moccutxt.Text+"')";
            string qry = "insert into addmission ( studentname, program , gender , religion , contact , cnic , address ,pincode, country , email , fathername , mothername , fOccupation, mOccupation, income) values ('"+admission.name+ "','"+admission.program+ "','"+admission.gender+ "','"+admission.religion+ "','"+admission.mobile+ "','"+admission.cnic+ "','"+admission.address+ "','"+admission.pincode+ "','"+admission.country+ "','"+admission.email+ "','"+fnametxt.Text+ "','"+mnametxt.Text+ "','"+foc.Text+ "','"+moccutxt.Text+ "','"+incometxt.Text+"')";
            SqlCommand cmd = new SqlCommand(qry, Class2.sql);
            cmd.ExecuteNonQuery();
            admission ad = new admission();
            admission.address = "";
            fnametxt.Clear();
            mnametxt.Clear();
            admission.country = "";
            moccutxt.Clear();
            incometxt.Clear();
          
       
            foc.Clear();

            admission.email = "";
            admission.country = "";
            admission.mobile = "";
            admission.pincode = "";
            admission.email = "";
            
            admission.name = " ";
            admission.program="";
            admission.gender = "";
            admission.cnic = "";
            admission.address = "";



               




            MessageBox.Show("Record added"); 
            
            //autoid();


            Class2.sql.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FEES f = new FEES();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void moccutxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admission ad = new admission();
            ad.Show();
            this.Hide();
        }
    }
    }

