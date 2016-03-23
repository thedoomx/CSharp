using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_File_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file location..");
            //string fileLoc = Console.ReadLine();
            string fileLoc = "D:\\Movies\\Windows Loader v2.2.1 by Daz\\Read me.txt";
            

        }

        public static void AppendText(string fileloc, StringBuilder text)
        {
            File.AppendAllText(fileloc, text.ToString());
        }

        public static void LineCount(string fileloc)
        {
            using (StreamReader sr = new StreamReader(fileloc))
            {
                string line;
                int counter = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    counter++;
                }

                Console.WriteLine(counter);
            }
        }

        public static void AppendLine(string fileloc, string line)
        {
            using (StreamWriter sw = File.AppendText(fileloc))
            {
                sw.WriteLine(line);
            }
        }

        public static void ListContent(string fileloc)
        {
            using (StreamReader sr = new StreamReader(fileloc))
            {
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void ClearContent(string fileloc)
        {
            File.WriteAllText(fileloc, String.Empty);
        }
    }
}
