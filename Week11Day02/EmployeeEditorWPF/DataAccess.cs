using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEditorWPF
{
    static class DataAccess
    {
        static Week08Day03Entities context = new Week08Day03Entities();

        public static Week08Day03Entities Context { get { return context; } }

        public static void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
