using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenameChallenge
{
    public class FolderReader
    {
        public string FolderPath { get; set; }

        public IEnumerable<FileInfo> Files 
        {
            get
            {
                return this.Folder.EnumerateFiles();
            }
        }

        public DirectoryInfo Folder { get; set; }

        public FolderReader(string folderPath) 
        { 
            this.FolderPath = folderPath;
            this.Folder = new DirectoryInfo(folderPath);
        }

        public void RenameToCamelCase()
        {
            foreach (FileInfo file in this.Files)
            {
                string oldName = file.Name;
                string newName = oldName[0].ToString().ToUpper() + oldName.Substring(1, oldName.Length - 1).ToLower();
                newName = newName.Replace("asd", "Pass");
                newName = newName.Replace("Asd", "Pass");
                file.MoveTo(file.Directory + "\\" + newName);
            }
        }

        public void RenameBasedOnFirstLine()
        {
            foreach(FileInfo file in this.Files)
            {
                string firstLine = File.ReadAllLines(file.FullName).First();
                file.MoveTo(file.Directory + "\\" + firstLine + file.Extension);

            }
        }

    }
}
