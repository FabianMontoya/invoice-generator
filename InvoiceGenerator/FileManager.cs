using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    internal class FileManager
    {

        private string initialPath = $"{Application.StartupPath}tempFiles";

        public FileManager()
        {
            VerifyFilesFolder();
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

        public Boolean MoveFileToTempFolder(string filePath)
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

            File.Copy(filePath, $"{initialPath}\\{Guid.NewGuid().ToString()}{extension}", true);

            return true;
        }
    }
}
