using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CampFolderMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Repository r = new Repository();
            r.AddRootFolder("G:\\camps");
            r.AddRootFolder("G:\\camps\\ada");
            r.AddRootFolder("G:\\Camps\\YMCA Metuchen-Edison - Edison Branch");
            r.AddRootFolder("G:\\Camps\\YMCA of Greater Hartford");
            r.AddRootFolder("G:\\Camps\\Lake Geneva Youth Camp & Conference Center");

            foreach (System.IO.DirectoryInfo x in r.RootFolders)
            {
                Console.WriteLine(x.FullName);
                Console.WriteLine(x.GetDirectories().Count());
            }
            Console.ReadLine();
            
        }
    }
}
