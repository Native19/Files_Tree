using Files_Tree.Data;
using Files_Tree.Data.Interfaces;
using Files_Tree.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Files_Tree.Controllers
{
    public class TreeController : Controller 
    {
        private readonly INode _allNodes;
        private readonly IFile _allFiles;

        public TreeController (INode allNodes, IFile allFiles)
        {
            _allNodes = allNodes;
            _allFiles = allFiles;
        }

        public ViewResult AllNodesList ()
        {
            AllNodesListViewModel obj = new AllNodesListViewModel();
            obj.getAllNodes = _allNodes.AllNodes;
            obj.getAllFiles = _allFiles.AllFiles;
            ViewBag.Title = "Files";
            return View(obj);
        }
    }
}
