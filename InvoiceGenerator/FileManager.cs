using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    internal class FileManager
    {

        private readonly string initialPath = $"{Application.StartupPath}tempFiles";
        private string finalFilePath = "";

        public FileManager()
        {
            VerifyFilesFolder();
        }

        public string GetFilePath()
        {
            return finalFilePath;
        }

        private void VerifyFilesFolder()
        {
            if (!Directory.Exists(initialPath))
            {
                Directory.CreateDirectory(initialPath);
            }
        }

        public void DeleteFilesInFolder()
        {
            finalFilePath = "";

            System.IO.DirectoryInfo di = new DirectoryInfo(initialPath);
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }

        /// <summary>
        /// Copy the file passed and return if the copy was success or not
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool MoveFileToTempFolder(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            string extension = Path.GetExtension(filePath);

            if (extension.Length == 0)
            {
                return false;
            }

            finalFilePath = $"{initialPath}\\{Guid.NewGuid().ToString()}{extension}";

            File.Copy(filePath, finalFilePath, true);

            return true;
        }

        public void DeleteTempFile()
        {
            if (!File.Exists(finalFilePath))
            {
                return;
            }

            File.Delete(finalFilePath);
            finalFilePath = "";
        }
    }
}
