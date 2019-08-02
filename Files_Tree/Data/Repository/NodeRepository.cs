using Files_Tree.Data.Interfaces;
using Files_Tree.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Data.Repository
{
    public class NodeRepository : INode
    {
        private readonly AppDBContent appDBContent;

        public NodeRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Node> AllNodes => appDBContent.Node;

        public Node getNode(int nodeId) => appDBContent.Node.FirstOrDefault(node => node.id == nodeId);
    }
}
