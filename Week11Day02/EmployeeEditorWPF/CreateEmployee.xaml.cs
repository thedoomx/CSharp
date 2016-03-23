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
using System.Windows.Shapes;

namespace EmployeeEditorWPF
{
    /// <summary>
    /// Interaction logic for CreateEmployee.xaml
    /// </summary>
    public partial class CreateEmployee : Window
    {
        public CreateEmployee()
        {
            InitializeComponent();
            DataContext = new CreateEmployeeWindowViewModel();
        }

        
    }

    public class CreateEmployeeWindowViewModel : IDataErrorInfo
    {
        public CreateEmployeeWindowViewModel()
        {

        }

        public string ValidateInputText
        {
            get;
            set;
        }

        public ICommand ValidateInputCommand
        {
            get { return new RelayCommand(); }

        }

        private int age = 20;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }



        public string this[string columnName]
        {
            get
            {
                if ("ValidateInputText" == columnName)
                {
                    if (String.IsNullOrEmpty(ValidateInputText))
                    {
                        return "Please enter a Name";
                    }
                }
                else if ("Age" == columnName)
                {
                    if (Age < 0)
                    {
                        return "age should be greater than 0";
                    }
                }
                return "";
            }
        }
        

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

        }
    }
}
