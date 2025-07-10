using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
