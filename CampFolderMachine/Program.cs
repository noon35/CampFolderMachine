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
            //these are all the folder in g:\camps that have more camps within them
            Repository r = new Repository();
            r.AddRootFolder("G:\\camps");
            r.AddRootFolder("G:\\camps\\ada");
            r.AddRootFolder("G:\\Camps\\YMCA Metuchen-Edison - Edison Branch");
            r.AddRootFolder("G:\\Camps\\YMCA of Greater Hartford");
            r.AddRootFolder("G:\\Camps\\Lake Geneva Youth Camp & Conference Center");

            //print them to the console to see that this is working
            foreach (System.IO.DirectoryInfo x in r.RootFolders)
            {
                Console.WriteLine(x.FullName);
                Console.WriteLine(x.GetDirectories().Count());
            }
            Console.ReadLine();
            
        }
    }
}
