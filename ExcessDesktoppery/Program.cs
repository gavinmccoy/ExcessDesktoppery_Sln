using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcessDesktoppery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Moves files on the desktop that have not been accessed for 30 days to
            // a folder called Excess Desktoppery
            // Any improvements would be greatly appreciated!!!
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newFolder = path + "\\Excess Desktoppery".ToString();
            Excess.MoveUnusedFiles(path, newFolder);
        }
    }
}
