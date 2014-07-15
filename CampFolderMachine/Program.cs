using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampFolderMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            Repository R = new Repository();
            R.AddRootFolder(new System.IO.DirectoryInfo("G:\\camps"));
            Console.WriteLine(R.RootFolders[0].FullName.ToString());
        }
    }
}
