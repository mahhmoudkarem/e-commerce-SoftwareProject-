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

namespace e_commerce_SoftwareProject_
{
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahmo\OneDrive\Documents\E-CommerceMS(SoftwareProject).mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            formUserName.Clear();
            formFullName.Clear();
            formPassword.Clear();
            formRepass.Clear();
            formPhone.Clear();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (formPassword.Text != formRepass.Text)
                {
                    MessageBox.Show("Password did not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO Users(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
                    cm.Parameters.AddWithValue("@username", formUserName.Text);
                    cm.Parameters.AddWithValue("@fullname", formFullName.Text);
                    cm.Parameters.AddWithValue("@password", formPassword.Text);
                    cm.Parameters.AddWithValue("@phone", formPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
            saveBtn.Enabled = true;
            UpdateBtn.Enabled = false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (formPassword.Text != formRepass.Text)
                {
                    MessageBox.Show("Password did not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("UPDATE Users SET fullname = @fullname, password=@password, phone=@phone WHERE username LIKE '" + formUserName.Text + "' ", con);
                    cm.Parameters.AddWithValue("@username", formUserName.Text);
                    cm.Parameters.AddWithValue("@fullname", formFullName.Text);
                    cm.Parameters.AddWithValue("@password", formPassword.Text);
                    cm.Parameters.AddWithValue("@phone", formPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
