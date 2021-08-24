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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            rolecombo.KeyUp += Rolecombo_KeyUp;
        }

        private void Rolecombo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
            
                if (rolecombo.SelectedIndex==0)
                {
                    usertxt.Focus();
                    usertxt.Items.Clear();
                    usertxt.Text = "";
                    Class2.sql.Open();
                    string qry = "select username from administration where role = 'admin'";

                    SqlCommand cmd = new SqlCommand(qry, Class2.sql);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) { 
                    usertxt.Items.Add(reader["username"]);
                    
                    }

                    


                    Class2.sql.Close();
                }


             else if (rolecombo.SelectedIndex == 1)
                {
                    usertxt.Focus();
                    usertxt.Items.Clear();
                    usertxt.Text = "";
                    Class2.sql.Open();
                    string qry = "select username from administration where role = 'admission'";

                    SqlCommand cmd = new SqlCommand(qry, Class2.sql);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usertxt.Items.Add(reader["username"]);
                       
                    }
                    Class2.sql.Close();
                }


              else  if (rolecombo.SelectedIndex == 2)
                {
                    usertxt.Focus();
                    usertxt.Text = "";

                    usertxt.Items.Clear();
                    Class2.sql.Open();
                    string qry = "select username from administration where role = 'fees'";

                    SqlCommand cmd = new SqlCommand(qry, Class2.sql);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usertxt.Items.Add(reader["username"]);
                       
                    }
                    Class2.sql.Close();
                }


            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            /*string[] rolecombo1 = { "ADMIN", "ADDMISSION", "FEES" };
            foreach (string item in rolecombo1)
            {
                rolecombo.Items.Add(item);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            






            Class2.sql.Open();
            string qry = "select * from administration where username = @user and password = @pass ";
            SqlCommand cmd = new SqlCommand(qry,Class2.sql);
            cmd.Parameters.AddWithValue("@user",usertxt.Text);
            cmd.Parameters.AddWithValue("@pass",passtxt.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login successfull");
                if (rolecombo.SelectedItem=="admission")
                {
                    admission ad = new admission();
                    ad.Show();
                    this.Hide();

                }

              else  if (rolecombo.SelectedItem=="FEES")
                {
                    FEES f = new FEES();
                    f.Show();
                    this.Hide();

                }


            }
            else
            {
                MessageBox.Show(" LOGIN FAILED");
            }









            Class2.sql.Close();
        }

        private void rolecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rolecombo_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
