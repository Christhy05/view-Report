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
    public partial class Form3 : Form
    {
        public  String S_name,S_address;
        public int S_age;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblDetails.Text += "Student Name    : " + S_name + "\n";
            lblDetails.Text += "Student Age     : "+ S_age+ "\n";
            lblDetails.Text += "Student Address : "+S_address+ "\n";
        }
    }
}
