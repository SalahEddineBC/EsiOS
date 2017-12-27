using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;

namespace EsiOS
{
    public class Kernel : Sys.Kernel
    {
        public static bool isLogged;
        public static string current_directory = "0:\\";
        public static CosmosVFS vFS = new CosmosVFS();
        public static string[] Args;
        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(vFS);
            Console.WriteLine("Welcome To EsiOS");
            Console.WriteLine("Login:");
            Kernel.isLogged = false;
            vFS.CreateDirectory("0:\\x");


        }

        protected override void Run()
        {
            if (!Kernel.isLogged)
            {
                var p = new Login();

            }
            else
            {
                Console.Write(">");
                var command = Console.ReadLine();
                Kernel.Args = command.Split(' ');
                var tt = new FileSystem();
            }
        }
    }
}
