using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDatabinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee emp = new Employee()
        {
            FirstName = "Peter",
            LastName = "Petrov",
            Address = "default"
        };

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>()
        {
            new Employee()
            {
            FirstName = "Peter",
            LastName = "Petrov",
            Address = "default"
            },

            new Employee()
            {
            FirstName = "Peter",
            LastName = "Petrov",
            Address = "default"
            },

            new Employee()
            {
                FirstName = "3",
                LastName = "4",
                Address = "5"
            }
        };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = employees;
        }
    }

    public class Employee : INotifyPropertyChanged
    {
        string firstName = "";
        string lastName = "";
        string address = "";

        public event PropertyChangedEventHandler PropertyChanged;


        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }
}
