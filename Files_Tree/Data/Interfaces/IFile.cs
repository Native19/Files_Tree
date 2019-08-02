using Files_Tree.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Data.Interfaces
{
    public interface IFile
    {
        IEnumerable<File> AllFiles { get; }

        File getFile(int fileId);
    }
}
