using System;
using System.Collections.Generic;
using System.IO;
using learning.Abstract;
using learning.Commands;
using learning.States;

namespace learning
{
    class Program
    {
        static void Main()
        {
            //var manager = new StateManager();
            //manager.Run(new MainMenuState(manager));
            var directoryInfo = new DirectoryInfo("/Users/etah/");

            

            foreach(FileInfo info in directoryInfo.GetFiles())
            {
                Console.WriteLine("{0}-{1}", info.Name, info.Length);
            }

            Console.WriteLine("------------");

            foreach(DirectoryInfo info in directoryInfo.GetDirectories())
            {
                Console.WriteLine("{0}", info.Name);
            }

            Console.ReadKey();
        }
    }
}