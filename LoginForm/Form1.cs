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
        String[,] userCredentials =
        {
            {"admin","1234","Carl Aranas" },
            {"bossing","Aray koo","Boss" }
        };
        public Form1()
        {
            InitializeComponent();
        }

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
                for (int x = 0; x < userCredentials.GetLength(0); x++)
                {
                    if (tbUsername.Text == userCredentials[x, 0])
                    {
                        if (tbPassword.Text == userCredentials[x, 1])
                        {
                            frmHome frm = new frmHome();
                            MessageBox.Show("Welcome " + userCredentials[x, 2]);
                            this.Hide();
                            frm.Owner = this;
                            frm.Show(); 
                            break;
                        }
                        else
                        {
                            MessageBox.Show("invalid Username/Password");
                            break;
                        }
                    }
                }
            }
        }
    }
}
