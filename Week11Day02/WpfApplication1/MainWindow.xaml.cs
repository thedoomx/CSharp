using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CalculatorState state { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            state = new CalculatorState();
        }

        private void insertText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (insertText.Text.Length == 0)
            {

            }
            else if ((state.Operation == null))
            {
                state.FirstNumber = float.Parse(insertText.Text);
            }
        }

        private void Button_plus(object sender, RoutedEventArgs e)
        {
            state.Operation = "+";
            insertText.Text = "";
        }

        private void Button_minus(object sender, RoutedEventArgs e)
        {
            state.Operation = "-";
            insertText.Text = "";
        }

        private void Button_multiply(object sender, RoutedEventArgs e)
        {
            state.Operation = "*";
            insertText.Text = "";
        }

        private void Button_divide(object sender, RoutedEventArgs e)
        {
            state.Operation = "/";
            insertText.Text = "";
        }

        private void Button_sqrt(object sender, RoutedEventArgs e)
        {
            if (!insertText.Text.Equals(""))
            {
                resultText.Text = (Math.Sqrt(double.Parse(insertText.Text))).ToString();
                insertText.Text = "0";
                state = new CalculatorState();
            }
        }

        private void Button_log2(object sender, RoutedEventArgs e)
        {
            if (!insertText.Text.Equals(""))
            {
                resultText.Text = (Math.Log(double.Parse(insertText.Text), 2)).ToString();
                insertText.Text = "0";
                state = new CalculatorState();
            }
        }
        private void Button_Result(object sender, RoutedEventArgs e)
        {
            if (state.Operation == null)
            {
                resultText.Text = insertText.Text;
            }
            else if (state.Operation.Equals("+"))
            {
                resultText.Text = (state.FirstNumber + float.Parse(insertText.Text)).ToString();
            }
            else if (state.Operation.Equals("-"))
            {
                resultText.Text = (state.FirstNumber - float.Parse(insertText.Text)).ToString();
            }
            else if (state.Operation.Equals("*"))
            {
                resultText.Text = (state.FirstNumber * float.Parse(insertText.Text)).ToString();
            }
            else if (state.Operation.Equals("/"))
            {
                resultText.Text = (state.FirstNumber / float.Parse(insertText.Text)).ToString();
            }
            else
            {
                resultText.Text = insertText.Text;
            }

            insertText.Text = "0";
            state = new CalculatorState();
        }

        private void insertText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$"); //regex that matches disallowed text
            return regex.IsMatch(text);
        }

        
    }
}
