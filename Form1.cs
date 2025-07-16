using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fresh_Tomatoes_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string USER = "admin";
            string PASS = "123";

            // Get user and pass
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == USER && password == PASS)
            {
                // open Form2
                Form2 form2 = new Form2();
                form2.Show();

                // Hide and close this form
                this.Hide();
            }
            else
            {
                // Login Failed
                MessageBox.Show("Login Failed! Please check your username and password.");
            }
        }
    }
}
