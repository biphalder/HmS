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
using System.Data;



namespace HospitalManagementSystem
{
    public partial class login : Form
    {
       

        public login()
        {
            InitializeComponent();
        }

       
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Biplob\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select ROLE from LOGIN where EMAIL='" + textBoxEmail.Text +"' and PASSWORD='" + textBoxPassword.Text +"'",con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MDIParent1 ss = new MDIParent1(dt.Rows[0][0].ToString());
                ss.Show();
            }
           

            else
            {
                MessageBox.Show("check ur email and password");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }
    }
}
