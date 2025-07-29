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

        public Form2(string user, XML_Manager manager)
        {
            InitializeComponent();
            this.user = user;
            this.product_manager = manager;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // go to Form 1:

            // Fechar todas as Forms (excepto o Form1 que é o login)
            Form1.switch_window = new Switch_Window(); // reinicia a lista de Forms

            // Voltar ao Form1
            Form1.switch_window.AddForm(new Form1()); // recria Form1 limpo
            Form1.switch_window.ShowForm(1);

            // Esconder o Form2
            this.Hide();
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
