using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcessDesktoppery
{
    class Excess
    {
        public static void MoveUnusedFiles(string sourcePath, string targetPath)
        {
            List<string> files = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories).ToList();

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            foreach (string item in files)
            {
                try
                {
                    FileInfo file = new FileInfo(item);

                    if (file.LastAccessTime < DateTime.Now.AddDays(-30))
                    {
                        if (!(new FileInfo(targetPath + "\\" + file.Name).Exists))
                        {
                            file.MoveTo(targetPath + "\\" + file.Name);
                        }
                    }
                }
                catch (PathTooLongException)
                {

                    //throw;
                }
                

                


            }
        }
    }
}
