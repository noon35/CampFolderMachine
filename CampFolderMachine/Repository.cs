using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;

namespace CampFolderMachine
{
    class Repository
    {
        private List<DirectoryInfo> rootFolders;

        public Repository()
        {
            rootFolders = new List<DirectoryInfo>();
        }


        public List<DirectoryInfo> RootFolders
        {
            get { return rootFolders; }
        }

        public void AddRootFolder(DirectoryInfo newFolder)
        {
            rootFolders.Add(newFolder);
        }
    }
}
