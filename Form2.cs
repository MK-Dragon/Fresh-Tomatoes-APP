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
    public partial class Form2 : Form
    {
        private string user;
        XML_Manager product_manager;

        public Form2(string username)
        {
            InitializeComponent();
            user = username;
            // TODO : add: load products from database/file
            product_manager = new XML_Manager(this.user, "C:\\Users\\MC\\Documents\\MK Code\\C _harp\\Fresh Tomatoes APP\\produtos.xml");
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // go to Form 1:
            Form1.switch_window.ShowForm(1);
            this.Hide();

            // TODO: add: clear memory for next user
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            // go to Form 3:
            Form1.switch_window.ShowForm(3);
            this.Hide();
        }

        private void btn_list_products_Click(object sender, EventArgs e)
        {
            // go to Form 4:
            Form1.switch_window.ShowForm(4);
            this.Hide();
        }
    }
}
