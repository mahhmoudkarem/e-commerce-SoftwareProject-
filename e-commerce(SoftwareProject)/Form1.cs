using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_commerce_SoftwareProject_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btnclear_Click(object sender, EventArgs e)
        {
            formName.Clear();
            formPass.Clear();
        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked == false)
                formPass.UseSystemPasswordChar = true;
            else
                formPass.UseSystemPasswordChar = false;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
