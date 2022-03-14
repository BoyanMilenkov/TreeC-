using System;
using System.Collections.Generic;
using System.IO;

namespace BFStraversefolders
{
    class Program
    {
        static void Main(string[] args)
        {
            TraverseDirBFS(@"C:\Windows\assembly");
        }
        static void TraverseDirBFS(string directoryPath)
        {
            var visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));
            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);
                DirectoryInfo[] children = currentDir.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
                   

            }
        }
       
    }
}
