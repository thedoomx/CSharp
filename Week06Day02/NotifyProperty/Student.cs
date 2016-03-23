using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Student : INotifyPropertyChanged
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public bool hasDog { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
