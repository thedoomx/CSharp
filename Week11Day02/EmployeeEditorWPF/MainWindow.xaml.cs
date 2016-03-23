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

namespace EmployeeEditorWPF
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
            viewModel.SelectedEmp = employeeGrid.SelectedItem as Employee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            DataAccess.SaveChanges();
        }

        private void buttonCreateNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            var window = new CreateEmployee();
            window.Owner = this;
            window.Show();
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Employee selectedEmp;
        
        public List<Employee> Employees
        {
            get { return DataAccess.Context.Employees.ToList(); }
        }

        public Employee SelectedEmp
        {
            get
            {
                return selectedEmp;
            }
            set
            {
                selectedEmp = value;
                OnPropertChanged("SelectedEmp");
                
            }
        }

        protected virtual void OnPropertChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
