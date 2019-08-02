using Files_Tree.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Data.Models
{
    public class Node
    {
        public Node()
        {
            this.subNodes = new List<Node>();
            this.files = new List<File>();
        }

        public int id { set; get; }

        public string nodeName { set; get; }

        public List<Node> subNodes { set; get; }

        public Node parentNode { set; get; }

        public List<File> files { set; get; }

        public folderStatus status { set; get; }
    }
}
