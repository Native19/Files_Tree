using Files_Tree.Data.Models;
using Files_Tree.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.File.Any())
                content.File.AddRange(Files);

            if (!content.Node.Any())
            {
                content.Node.AddRange(
                    new Node { nodeName = "Bass Folder", status = folderStatus.close, parentNode = null, files = new List<File> { new File { fileName = "File1" }, new File { fileName = "File2" }, new File { fileName = "File3" } } },
                    new Node { nodeName = "Folder 1", status = folderStatus.close, files = Files.FindAll(file => file.fileName == "File1" | file.fileName == "File3") },
                    new Node { nodeName = "Folder 2", status = folderStatus.open, files = Files.FindAll(file => file.fileName == "File2" | file.fileName == "File1") },
                    new Node { nodeName = "Folder 3", status = folderStatus.open, files = Files.FindAll(file => file.fileName == "File4" | file.fileName == "File1") }
                    );
            }
            content.SaveChanges();
        }

        private static List<File> file;
        public static List<File> Files
        {
            get
            {
                if (file == null)
                {
                    var allFilesList = new List<File>
                    {  
                        new File { fileName = "File1"}, new File { fileName = "File2"},
                        new File { fileName = "File3"}, new File { fileName = "File4"}
                    };

                    file = new List<File>();
                    foreach (File element in allFilesList)
                        file.Add(element);
                }
                return file;
            }
        }
    }
}
