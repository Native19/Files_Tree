using Files_Tree.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Data.Interfaces
{
    public interface INode
    {
        IEnumerable<Node> AllNodes { get; }

        Node getNode(int nodeId);
    }
}
