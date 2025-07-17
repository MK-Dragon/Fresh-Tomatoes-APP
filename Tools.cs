using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Fresh_Tomatoes_APP;

namespace Fresh_Tomatoes_APP
{
    internal class Tools
    {

    }

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
}

internal class XML_Manager : ProductManager
{
    private string FilePATH;
    private XmlDocument doc = new XmlDocument();
    private XmlNodeList nodeList;


    public XML_Manager(string filePath)
    {
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

        Product product = new Product(name, description, category, rating);
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
            Product product = new Product(name, description, category, rating);
            Product_List.Add(product);
        }

        return Product_List;
    }

    public void Change_Product(int index, Product product)
    {
        XmlNode node = nodeList.Item(index);
        XmlElement element = node as XmlElement;
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
        // For example, form.Show(); and this.Hide();
        if (idx_form < 1 || idx_form > forms.Count)
        {
            throw new ArgumentOutOfRangeException("Invalid form index.");
        }
        forms[idx_form - 1].Show();
    }
    public void AddForm(Form form)
    {
        // This method can be used to add a new form to the switcher
        forms.Add(form);
    }
}