using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class DirectoryTraversal
    {
        public static IEnumerable<string> IterateDirectory(DirectoryInfo dir)
        {
            foreach (DirectoryInfo item in dir.GetDirectories())
            {
                yield return item.Name;

                foreach (FileInfo file in dir.GetFiles())
                {
                    yield return file.Name;
                }

                foreach (var inner in IterateDirectory(item))
                {
                    yield return inner;
                }
            }
        }
    }
}
