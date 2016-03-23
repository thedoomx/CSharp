using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> container = new Dictionary<string, int>();
            //DirectoryInfo dir = new DirectoryInfo(@"D:\Movies\");

            //container = GetFileOccurences(dir, container);

            //foreach (KeyValuePair<string, int> kvp in container)
            //{
            //    Console.WriteLine(kvp.Key + ": " + kvp.Value);
            //}

            DirectoryInfo targetDir = new DirectoryInfo(@"C:\");
            DirectoryInfo dir = new DirectoryInfo(@"D:\Movies\Windows Loader v2.2.1 by Daz");

            //string readPath = "D:\\Movies\\Windows Loader v2.2.1 by Daz\\Read me.txt";
            //string writePath = "D:\\Movies\\Windows Loader v2.2.1 by Daz\\New.txt";

            //FileToUpper(readPath, writePath);

            //string fileName = "D:\\Movies\\Windows Loader v2.2.1 by Daz\\NewSerializable.txt";
            //IFormatter formatter = new BinaryFormatter();
            //Program.SerializeItem(fileName, formatter);
            //Author a = DeserializeItem(fileName, formatter);
            //Console.WriteLine(a.Name + " " + a.Email);


        }

        public static Author DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            return (Author)formatter.Deserialize(s);
            
        }

        public static void SerializeItem(string fileName, IFormatter formatter)
        {
            Author a = new Author();
            a.Name = "Gosho";
            a.Email = "gosho@abv.bg";

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, a);
            s.Close();
        }

        public static void FileToUpper(string readPath, string writePath)
        {
            using (StreamReader sr = new StreamReader(readPath))
            {
                using (StreamWriter sw = new StreamWriter(writePath))
                {
                    string line = "";

                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.ToUpper();

                        sw.WriteLine(line);
                    }
                }
            }
        }

        public static Dictionary<string, int> GetFileOccurences(DirectoryInfo dir, Dictionary<string, int> container)
        {
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (var item in dirs)
            {
                GetFileOccurences(item, container);

                FileInfo[] files = item.GetFiles();

                foreach (var file in files)
                {
                    if(container.ContainsKey(file.ToString()))
                    {
                        container[file.ToString()]++;
                    }
                    else
                    {
                        container.Add(file.ToString(), 1);
                    }
                }
            }

            return container;
        }
        
    }
}
