using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        MyDatabase db = new MyDatabase();

        String[,] userCredentials =
       {
            {"admin","1234","Carl Aranas" },
            {"bossing","Aray koo","Boss" }
        };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username!", "Validation");
                tbUsername.Focus();
            }
            else if(tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password!", "Validation");
                tbPassword.Focus();
            }
            else
            {
                DataTable dt = db.ExecuteReturnQuery("select * from tblLoginCredentials where user_username = @uname and user_password = @pword;",
         new MySqlParameter("@uname",tbUsername.Text),
         new MySqlParameter("@pword",tbPassword.Text));
                if (dt.Rows.Count == 1) { 
                    frmHome frm = new frmHome();
                    frm.Owner = this;
                    this.Hide();
                    frm.Show();
                }

            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            if (db.TestConnection() == true)
            {
                MessageBox.Show("Connected Successfully");
            }
            else
            {
                MessageBox.Show("Ayaw amp");
            }
        }
    }
}
