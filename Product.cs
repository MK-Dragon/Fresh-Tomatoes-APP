using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fresh_Tomatoes_APP;

namespace Fresh_Tomatoes_APP
{
    public class Product
    {
        private string user_name;
        private string product_name;
        private string product_description;
        private string product_category;
        private int product_rating;

        public Product(string username, string name, string description, string category, int rating)
        {
            user_name = username;
            product_name = name;
            product_description = description;
            product_category = category;
            product_rating = rating;
        }


        public string GetUserName()
        {
            return user_name;
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
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Product name cannot be null or empty.");
            }
            product_name = name;
        }

        public void SetUserName(string username)
        {
            user_name = username; 
        }

        public void SetDescription(string description)
        {
            product_description = description;
        }

        public void SetCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentException("Product category cannot be null or empty.");
            }
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
