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
    public partial class Form3 : Form
    {
        private string user;
        XML_Manager product_manager;

        public Form3(string user)
        {
            InitializeComponent();
            this.user = user;
            product_manager = new XML_Manager(this.user, "C:\\Users\\MC\\Documents\\MK Code\\C _harp\\Fresh Tomatoes APP\\produtos.xml");
            refrersh_cbb();
        }

        string new_category = "";

        private void btn_back_Click(object sender, EventArgs e)
        {
            // go to Form 2:
            Form1.switch_window.ShowForm(2);
            this.Hide();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            // get values
            string productName = tb_product_name.Text;
            string productDescription = rtb_description.Text;
            int ration = Convert.ToInt32(num_rating.Value);

            string category = new_category;
            if (new_category == "")
            {
                category = cbb_category.SelectedItem.ToString();
            }
            
            // create a new product
            Product newProduct = new Product(user, productName, productDescription, category, ration);

            // add product to the XML file
            product_manager.Add_Product(newProduct);

            // reset fields
            tb_product_name.Text = "";
            rtb_description.Text = "";
            num_rating.Value = 1;
            cbb_category.SelectedIndex = -1; // ????
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refrersh_cbb()
        {
            foreach (string category in product_manager.Get_Categories())
            {
                cbb_category.Items.Add(category);
            }
        }

        private void btn_new_category_Click(object sender, EventArgs e)
        {
            string new_cat = cbb_category.Text.Trim();
            if (new_cat != "")
            {
                cbb_category.Items.Add(new_cat);
                cbb_category.SelectedIndex = cbb_category.Items.Count - 1; // Select the newly added category
            }
        }
    }
}
