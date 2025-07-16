using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fresh_Tomatoes_APP
{
    internal class Product
    {
        private string product_name;
        private string product_description;
        private string product_category;
        private int product_rating;

        Product(string name, string description, string category, int rating)
        {
            product_name = name;
            product_description = description;
            product_category = category;
            product_rating = rating;
        }



        public string GetName()
        {
            return product_name;
        }
        public string GetDescription()
        {
            return product_description;
        }
        public string GetCategory()
        {
            return product_category;
        }
        public int GetRating()
        {
            return product_rating;
        }



        public void SetName(string name)
        {
            product_name = name;
        }
        public void SetDescription(string description)
        {
            product_description = description;
        }
        public void SetCategory(string category)
        {
            product_category = category;
        }
        public void SetRating(int rating)
        {
            if (rating < 0 || rating > 5)
            {
                throw new ArgumentOutOfRangeException("Rating must be between 0 and 5.");
            }
            product_rating = rating;
        }
    }
}
