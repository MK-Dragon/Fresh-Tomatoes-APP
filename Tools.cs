using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Fresh_Tomatoes_APP;
using MySql.Data.MySqlClient;

namespace Fresh_Tomatoes_APP
{
    internal class FileManager
    {
        private string FolderPATH;
        private string FileExtention = "txt";

        public FileManager(string folderPath)
        {
            FolderPATH = folderPath;
        }
        public FileManager(string folderPath, string fileExtention)
        {
            FolderPATH = folderPath;
            FileExtention = fileExtention;
        }

        // Funtions
        public List<string> ReadFile(string fileName)// Reads File and returns List with all the Lines
        {
            List<string> textLines = new List<string>();

            string filePath = $"{FolderPATH}//{fileName}.{FileExtention}";
            StreamReader leitura = File.OpenText(filePath);

            string linha = null;
            while ((linha = leitura.ReadLine()) != null)
            {
                //Console.WriteLine(linha);
                textLines.Add(linha);

            }
            leitura.Close();
            return textLines;
        }
        public void WriteFile(string fileName, List<string> textLines)// THIS Overwrites the FILE!!!! ^_^
        {
            string filePath = $"{FolderPATH}//{fileName}.{FileExtention}";
            FileInfo ficheiro = new FileInfo(filePath);
            StreamWriter write = ficheiro.CreateText();
            foreach (string line in textLines)
            {
                write.WriteLine(line);
            }
            write.Close();
        }
        public List<string> ListFiles() // Lists All Files without extention
        {
            List<string> listOfFiles = new List<string>();

            DirectoryInfo pasta = new DirectoryInfo(FolderPATH);
            FileInfo[] ficheiros_txt = pasta.GetFiles($"*.{FileExtention}");

            foreach (FileInfo file in ficheiros_txt)
            {
                string fileName = file.Name.Replace($".{FileExtention}", "");

                //Console.WriteLine($"> {fileName}");
                listOfFiles.Add(fileName);
            }
            return listOfFiles;
        }

        public bool FileExists(string fileName)
        {
            List<string> listFiles = ListFiles();
            if (listFiles.FindIndex(f => f == fileName) == -1)
            { return false; }
            return true;
        }
    }
}


public class Switch_Window
{
    List<Form> forms = new List<Form>();

    public Switch_Window()
    {
        // Constructor for the window switcher
        // This can be used to manage multiple forms/windows in the application
    }

    public void ShowForm(int idx_form)
    {
        // This method can be used to switch to a specific form

        // Check if the index is valid
        if (idx_form < 1 || idx_form > forms.Count)
        {
            throw new ArgumentOutOfRangeException("Invalid form index.");
        }

        // Hide all forms
        foreach (Form form in forms)
        {
            form.Hide();
        }
        CenterForms();

        // Show the selected form
        forms[idx_form - 1].Show();
    }

    public void AddForm(Form form)
    {
        // This method can be used to add a new form to the switcher
        forms.Add(form);
    }

    public void CenterForms()
    {
        foreach (Form form in forms)
        {
            form.SetDesktopLocation(
                (Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2
            );
        }
    }
}





internal interface ProductManager
{
    // This Interface makes it possible to use XML and later change to SQL ;)
    // Because we only need to change the instance of the Manager to use the XML/SQL implementation! :D
    void Refresh_List();
    Product Get_Product(int index);
    List<Product> Get_Product_List();
    void Change_Product(int index, Product product);
    void Add_Product(Product product);
    void Remove_Product(int index);

    List<string> Get_Categories();

    List<Product> SortProducts(string sort_by, int min_ration, int max_rating, string category);
}





public class XML_Manager : ProductManager
{
    private string FilePATH;
    private XmlDocument doc = new XmlDocument();
    private XmlNodeList nodeList;
    public string UserName;


    public XML_Manager(string userName, string filePath)
    {
        UserName = userName;

        FilePATH = filePath;
        Refresh_List();
    }

    public void Refresh_List()
    {
        doc.Load(FilePATH);
        nodeList = doc.SelectNodes(@"/lista/produto");
    }

    public Product Get_Product(int index)
    {
        XmlNode node = nodeList.Item(index);

        XmlElement element = node as XmlElement;
        string name = element.Attributes.GetNamedItem("name").Value;
        string description = element.Attributes.GetNamedItem("description").Value;
        string category = element.Attributes.GetNamedItem("category").Value;
        int rating = int.Parse(element.Attributes.GetNamedItem("rating").Value);

        Product product = new Product(UserName, name, description, category, rating);
        return product;
    }

    public List<Product> Get_Product_List()
    {
        List<Product> Product_List = new List<Product>();

        foreach (XmlNode node in nodeList)
        {
            XmlElement element = node as XmlElement;
            string name = element.Attributes.GetNamedItem("name").Value;
            string description = element.Attributes.GetNamedItem("description").Value;
            string category = element.Attributes.GetNamedItem("category").Value;
            int rating = int.Parse(element.Attributes.GetNamedItem("rating").Value);

            if (UserName == element.Attributes.GetNamedItem("user").Value)
            {
                // Only add products that belong to the current user
                Product product = new Product(UserName, name, description, category, rating);
                Product_List.Add(product);
            }
                
        }

        return Product_List.Where(x => x.GetUserName() == UserName).ToList();
    }

    public void Change_Product(int index, Product product)
    {
        XmlNode node = nodeList.Item(index);
        XmlElement element = node as XmlElement;
        element.SetAttribute("user", product.GetUserName());
        element.SetAttribute("name", product.GetName());
        element.SetAttribute("description", product.GetDescription());
        element.SetAttribute("category", product.GetCategory());
        element.SetAttribute("rating", product.GetRating().ToString());
        doc.Save(FilePATH);
    }

    public void Add_Product(Product product)
    {
        XmlNode node = doc.SelectSingleNode("/lista");
        XmlElement newProduct = doc.CreateElement("produto");

        newProduct.SetAttribute("user", product.GetUserName());
        newProduct.SetAttribute("name", product.GetName());
        newProduct.SetAttribute("description", product.GetDescription());
        newProduct.SetAttribute("category", product.GetCategory());
        newProduct.SetAttribute("rating", product.GetRating().ToString());
        node.AppendChild(newProduct);

        doc.Save(FilePATH);
        Refresh_List();
    }

    public void Remove_Product(int index)
    {
        XmlNode node = nodeList.Item(index);
        XmlElement element = node as XmlElement;
        element.ParentNode.RemoveChild(node);

        doc.Save(FilePATH);
        Refresh_List();
    }

    public List<string> Get_Categories()
    {
        List<string> categories = new List<string>();
        foreach (XmlNode node in nodeList)
        {
            XmlElement element = node as XmlElement;
            string category = element.Attributes.GetNamedItem("category").Value;
            string user = element.Attributes.GetNamedItem("user").Value;

            if (!categories.Contains(category) && user == UserName)
            {
                categories.Add(category);
            }
        }
        return categories;
    }

    public List<Product> SortProducts(string sort_by, int min_ration, int max_rating, string category)
    {
        // get products from XML
        List<Product> products = Get_Product_List();

        // Sort products based on the sort_by parameter
        switch (sort_by)
        {
            case "A -> Z":
                products.Sort((x, y) => string.Compare(x.GetName(), y.GetName()));
                break;
            case "Z -> A":
                products.Sort((x, y) => string.Compare(y.GetName(), x.GetName()));
                break;
            case "Rating: Low -> High":
                // Implement sorting logic for Rating: Low -> High
                break;
            case "Rating: High -> Low":
                // Implement sorting logic for Rating: High -> Low
                break;

            default:
                break;
        }

        // Filter products based on rating
        List<Product> new_products = new List<Product>();
        foreach (Product pro in products)
        {
            if (min_ration <= pro.GetRating() && pro.GetRating() <= max_rating)
            {
                if (category == "All" || pro.GetCategory() == category)
                {
                    new_products.Add(pro);
                }
            }
        }

        // Return the sorted and filtered list of products
        return new_products;
    }
}





internal class SQL_Manager : ProductManager
{
    private string connectionString = "server=192.168.0.30;port=3306;database=fresh_tomatoes;uid=fresh;pwd=123;";

    public SQL_Manager()
    {
        // Constructor for the SQL manager
    }



    public void Refresh_List()
    {
        //
    }
    public Product Get_Product(int index)
    {
        //
        return new Product("user", "name", "description", "category", 5); // Example return
    }
    public List<Product> Get_Product_List()
    {
        return new List<Product>
        {
            new Product("user1", "Product1", "Description1", "Category1", 5),
            new Product("user2", "Product2", "Description2", "Category2", 4)
        }; // Example return
    }
    public void Change_Product(int index, Product product)
    {
        //
    }
    public void Add_Product(Product product)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            string query = @"INSERT INTO Produto 
                        (nome, avaliacao, opiniao, id_categoria, imagem_path) 
                         VALUES 
                        (@nome, @avaliacao, @opiniao, @id_categoria, @imagem_path);";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // TODO: find id_categoria
                int idCategoria = 1;

                cmd.Parameters.AddWithValue("@nome", product.GetName());
                cmd.Parameters.AddWithValue("@avaliacao", product.GetRating());
                cmd.Parameters.AddWithValue("@opiniao", product.GetDescription());
                cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                cmd.Parameters.AddWithValue("@imagem_path", product.GetImagePath());

                cmd.ExecuteNonQuery();
            }
        }
    }
    public void Remove_Product(int index)
    {
        //
    }

    public List<string> Get_Categories()
    {
        return new List<string>
        {
            "Category1",
            "Category2",
            "Category3"
        }; // Example return
    }

    public List<Product> SortProducts(string sort_by, int min_ration, int max_rating, string category)
    {
        switch (sort_by)
        {
            case "A -> Z":
                // Implement sorting logic for A -> Z
                break;
            case "Z -> A":
                // Implement sorting logic for Z -> A
                break;
            case "Rating: Low -> High":
                // Implement sorting logic for Rating: Low -> High
                break;
            case "Rating: High -> Low":
                // Implement sorting logic for Rating: High -> Low
                break;

            default:
                break;
        }
        return new List<Product>
        {
            new Product("user1", "Product1", "Description1", "Category1", 5),
            new Product("user2", "Product2", "Description2", "Category2", 4)
        }; // Example return, sorting logic can be added later
    }
}