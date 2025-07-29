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
        public Form4(string username, XML_Manager manager)
        {
            InitializeComponent();

            // start Connections and get products
            this.product_manager = manager;
            //product_manager.Refresh_List();

            // load ComboBox with categories
            list_categories();

            // load ComboBox Order By:
            cbb_order_by.Items.Add("A -> Z");
            cbb_order_by.Items.Add("Z -> A");
            //cbb_order_by.Items.Add("Rating: Low -> High");
            //cbb_order_by.Items.Add("Rating: High -> Low");
            cbb_order_by.SelectedIndex = 0; // default selection

            // F#### Y## Bug!!!
            lbl_orber_by.Visible = false;
            cbb_order_by.Visible = false;

            list_products();
        }
        XML_Manager product_manager;

        private void btn_back_Click(object sender, EventArgs e)
        {
            // go to Form 2:
            Form1.switch_window.ShowForm(2);
            this.Hide();
        }

        private void list_categories()
        {
            cbb_category.Items.Add("All");
            foreach (string category in product_manager.Get_Categories())
            {
                cbb_category.Items.Add(category);
            }
            cbb_category.SelectedIndex = 0;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            list_products();
            list_categories();
        }

        public void list_products()
        {
            // Read Filters
            lb_products.Items.Clear();
            string order_by = "A -> Z";
            int min_rating = Convert.ToInt32(num_min_stars.Value);
            int max_rating = Convert.ToInt32(num_stars_max.Value);
            string category = cbb_category.SelectedItem.ToString();

            // get products based on sorting parameters
            List<Product> products = product_manager.SortProducts(order_by, min_rating, max_rating, category);

            // display products! :)
            foreach (Product product in products)
            {
                lb_products.Items.Add(
                    $"{product.GetName()} - {product.GetDescription()} - {product.GetCategory()} - Rating: {product.GetRating()}"
                );
            }
        }


        // Event Handlers for UI Controls => Just List products when a filter changes 
        private void cbb_order_by_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_products();
        }

        private void num_min_stars_ValueChanged(object sender, EventArgs e)
        {
            list_products();
        }

        private void num_stars_max_ValueChanged(object sender, EventArgs e)
        {
            list_products();
        }

        private void cbb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_products();
        }
    }
}
