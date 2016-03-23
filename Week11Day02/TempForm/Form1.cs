using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempForm
{
    public partial class Form1 : Form
    {
        Employee emp = new Employee()
        {
            FirstName = "Peter",
            LastName = "Petrov",
            Address = "default"
        };


        BindingList<Employee> employees = new BindingList<Employee>()
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
        public Form1()
        {
            InitializeComponent();

            this.textBox1.DataBindings.Add(new Binding("Text", emp, "FirstName"));
            this.textBox2.DataBindings.Add(new Binding("Text", emp, "LastName"));
            this.textBox3.DataBindings.Add(new Binding("Text", emp, "Address"));

            listBox2.DataSource = employees;
            listBox2.DisplayMember = "FirstName";

            dataGridView1.DataSource = employees;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            emp.Address = this.textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee temp = new Employee
            {
                FirstName = textBox3.Text,
                LastName = textBox2.Text,
                Address = textBox1.Text
            };

            if(!employees.Contains(temp))
            {
                employees.Add(temp);
            }
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        public override bool Equals(object obj)
        {
            if((obj as Employee).FirstName.Equals(this.FirstName)
                && (obj as Employee).LastName.Equals(this.LastName)
                && (obj as Employee).Address.Equals(this.Address))
            {
                return true;
            }

            return false;
        }
    }
}
