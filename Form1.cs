using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fresh_Tomatoes_APP;

namespace Fresh_Tomatoes_APP
{
    public partial class Form1 : Form
    {
        public static Switch_Window switch_window = new Switch_Window();

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
                // Initialize the list of forms
                switch_window.AddForm(this);
                switch_window.AddForm(new Form2(tb_username.Text));
                switch_window.AddForm(new Form3(tb_username.Text));
                switch_window.AddForm(new Form4());


                // Old way to change Windows:
                // open Form2
                /*Form2 form2 = new Form2();
                form2.Show();

                // Hide and close this form
                this.Hide();*/

                // New way to change Windows using Switch_Window class:
                // go to Form 2:
                switch_window.ShowForm(2);
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
