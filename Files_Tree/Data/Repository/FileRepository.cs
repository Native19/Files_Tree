using Files_Tree.Data.Interfaces;
using Files_Tree.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Data.Repository
{
    public class FileRepository : IFile
    {
        private readonly AppDBContent appDBContent;

        public FileRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<File> AllFiles => appDBContent.File;

        public File getFile(int fileId) => appDBContent.File.FirstOrDefault(file => file.id == fileId);
    }
}
