using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("D:\\Graphs\\");


            DFS(dir);
        }

        private static void DFS(DirectoryInfo dir)
        {
            Stack<DirectoryInfo> dirs = new Stack<DirectoryInfo>();
            HashSet<DirectoryInfo> hash = new HashSet<DirectoryInfo>();
            dirs.Push(dir);
            hash.Add(dir);

            DFS(dir, dirs, hash);
        }


        private static void DFS(DirectoryInfo dir, Stack<DirectoryInfo> dirs, HashSet<DirectoryInfo> hash)
        {
            while (dirs.Count > 0)
            {
                DirectoryInfo current = dirs.Pop();
                Console.WriteLine(current.Name);

                foreach (var item in current.GetDirectories())
                {
                    if (!hash.Contains(item))
                    {
                        dirs.Push(item);
                        DFS(item, dirs, hash);
                    }
                }
            }
        }

        private static void BFS(DirectoryInfo dir)
        {
            Queue<DirectoryInfo> q = new Queue<DirectoryInfo>();
            HashSet<DirectoryInfo> hash = new HashSet<DirectoryInfo>();
            q.Enqueue(dir);
            hash.Add(dir);

            while (q.Count > 0)
            {
                DirectoryInfo current = q.Dequeue();
                Console.WriteLine(current.Name);


                foreach (var item in current.GetDirectories())
                {
                    if (!hash.Contains(item))
                    {
                        q.Enqueue(item);
                        hash.Add(item);
                    }
                }
            }
        }
    }
}
