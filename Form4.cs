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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            list_products();
        }
        XML_Manager product_manager;

        private void btn_back_Click(object sender, EventArgs e)
        {
            // go to Form 2:
            Form1.switch_window.ShowForm(2);
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            list_products();
        }

        public void list_products()
        {
            lb_products.Items.Clear();

            product_manager = new XML_Manager("admin", "C:\\Users\\MC\\Documents\\MK Code\\C _harp\\Fresh Tomatoes APP\\produtos.xml");

            foreach (Product product in product_manager.Get_Product_List())
            {
                lb_products.Items.Add(
                    $"{product.GetName()} - {product.GetDescription()} - {product.GetCategory()} - Rating: {product.GetRating()}"
                );
            }
        }
    }
}
