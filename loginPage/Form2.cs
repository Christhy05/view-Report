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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.S_name = txtname.Text;
            form3.S_address = txtaddress.Text;
            form3.S_age = Convert.ToInt32(txtage.Text);

            form3.Show();
        }
    }
}
