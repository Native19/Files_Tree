using Files_Tree.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.ViewModels
{
    public class AllNodesListViewModel
    {
        public IEnumerable<Node> getAllNodes { get; set;}
        public IEnumerable<File> getAllFiles { get; set; }
    }
}
