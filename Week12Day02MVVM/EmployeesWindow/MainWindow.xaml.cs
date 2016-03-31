using System;
using System.Collections.Generic;
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

namespace EmployeesWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void employeesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.SelectedEmployee = employeesGrid.SelectedItem as Employee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.SaveChanges();
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Employee selectedEmployee;

        public List<Employee> Employees
        {
            get
            {
                return DataAccess.Context.Employees.ToList();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Employee SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
