using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EsiOS
{
    public class FileSystem
    {
        private string[] commands = { "ls", "mkdir", "cd" };
        public FileSystem()
        {
            switch(Kernel.Args[0])
            {
                case "ls":
                    foreach(var t in Directory.GetDirectories(Kernel.current_directory))
                    {
                        Console.WriteLine("\t"+t);
                        Console.Write("lol");
                        
                    }
                    break;
                case "cd":
                    if(Directory.Exists(Kernel.Args[1]))
                    {
                        Directory.SetCurrentDirectory("0:\\" + Kernel.Args[1]);
                    }
                    else
                    {
                        Console.WriteLine("dir doesn't exist");
                    }
                    break;

                    
            }
        }
    }
}
