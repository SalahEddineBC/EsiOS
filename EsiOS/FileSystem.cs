using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;
using Cosmos.Core;

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
                        Console.WriteLine("\t" + t);
                    }
                    break;
                case "cd":
                    if (Kernel.Args[1] != "")
                    {
                        if (Directory.Exists(Kernel.current_directory + Kernel.Args[1]))
                        {
                            Directory.SetCurrentDirectory(Kernel.current_directory + Kernel.Args[1] + "\\");
                            Kernel.current_directory = Kernel.current_directory + Kernel.Args[1] + "\\";

                        }
                        else
                        {
                            Console.WriteLine("dir doesn't exist");
                        }
                    }
                    else
                    {
                        Console.WriteLine("is here");
                        Directory.SetCurrentDirectory("0:\\");
                        Kernel.current_directory = "0:\\";
                    }
                    break;
                case "mkdir":
                    if(!Directory.Exists(Kernel.current_directory+Kernel.Args[1]))
                    {
                        Kernel.vFS.CreateDirectory(Kernel.current_directory + Kernel.Args[1]);
                    }
                    else
                    {
                        Console.WriteLine("dir exist");
                    }
                    break;
                case "cls":
                    Console.Clear();
                    break;
                case "shutdown":
                    break;
                default:
                    Console.WriteLine(Kernel.Args[0] + " doesnt exist");
                    break;
            }
        }
    }
}
