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
using System.Xml.Linq;
using System.Xml;

namespace Fresh_Tomatoes_APP
{
    public partial class Form1 : Form
    {
        public static Switch_Window switch_window = new Switch_Window();
        public static XML_Manager xml_manager;

        public Form1()
        {
            InitializeComponent();
        }

        // Path to the XML file
        private string caminhoXML = "C:\\FreshTomatoes\\users.xml";

        private void btn_login_Click(object sender, EventArgs e)
        {
            //string USER = "admin";
            //string PASS = "123";


            // Get user and pass
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Preencha os dois campos.");
                return;
            }

            if (VerificarLogin(username, password))
            {
                tb_password.Clear();

                xml_manager = new XML_Manager(username, "C:\\FreshTomatoes\\produtos.xml");

                switch_window = new Switch_Window(); // nova instância limpa
                switch_window.AddForm(this);
                switch_window.AddForm(new Form2(username, xml_manager));
                switch_window.AddForm(new Form3(username, xml_manager));
                switch_window.AddForm(new Form4(username, xml_manager));

                switch_window.ShowForm(2);
                this.Hide();
            }
            else
            {
                // Login Failed
                MessageBox.Show("Login Failed! Please check your username and password.");
            }
        }

        private bool VerificarLogin(string username, string password)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminhoXML);

            foreach (XmlNode userNode in doc.SelectNodes("/users/user"))
            {
                string nome = userNode.Attributes["name"]?.Value;
                string pass = userNode.Attributes["password"]?.Value;

                if (nome == username && pass == password)
                {
                    return true;
                }
            }

            return false;
        }

        private bool UtilizadorExiste(string username)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminhoXML);

            foreach (XmlNode userNode in doc.SelectNodes("/users/user"))
            {
                string nome = userNode.Attributes["name"]?.Value;
                if (nome == username)
                    return true;
            }

            return false;
        }

        private void CriarUtilizador(string username, string password)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminhoXML);

            XmlNode root = doc.SelectSingleNode("/users");

            XmlElement novoUser = doc.CreateElement("user");
            novoUser.SetAttribute("name", username);
            novoUser.SetAttribute("password", password);

            root.AppendChild(novoUser);
            doc.Save(caminhoXML);

            MessageBox.Show("Utilizador criado com sucesso!");
        }

        private void btn_add_usar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Preencha os dois campos.");
                return;
            }

            if (UtilizadorExiste(username))
            {
                MessageBox.Show("Utilizador já existe.");
                return;
            }

            try
            {
                CriarUtilizador(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar utilizador: " + ex.Message);
            }
        }
    }
}
