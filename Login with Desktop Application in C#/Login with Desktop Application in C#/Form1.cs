using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_with_Desktop_Application_in_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "sappo" && textBox2.Text == "1234")
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
