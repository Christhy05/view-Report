using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form1 : Form
    {
        string Username, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtuname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Username = txtuname.Text;
            password = txtpassword.Text;

            if(Username=="Admin2" && password == "123@")
            {
                // MessageBox.Show("Access Granted");
                //this.Close();

                Form2 form2 = new Form2();
                form2.Show();

            }
            else if(Username=="Admin2" && password != "123@")
            {
                MessageBox.Show("Password is wrong, try again");
                //txtuname.Clear();
                txtpassword.Clear();
            }
            else if(Username!="Admin2" && password == "123@")
            {
                MessageBox.Show("Username is wrong, try again");
                txtuname.Clear();
                //txtpassword.Clear();
            }
            else
            {
                MessageBox.Show("Access Failed");
            }
        }
    }
}
