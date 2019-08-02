using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Data.Models
{
    public class File
    {
        public int id { set; get; }

        public string fileName { set; get; }

        public Node parentNode { set; get; }
    }
}
