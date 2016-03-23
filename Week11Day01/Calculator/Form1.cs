using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public CalculatorState state { get; set; }
        public Form1()
        {
            InitializeComponent();
            state = new CalculatorState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            state.Operation = "-";
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {

            }
            else if((state.Operation == null))
            {
                state.FirstNumber = float.Parse(textBox3.Text);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            state.Operation = "+";
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            state.Operation = "*";
            textBox3.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            state.Operation = "/";
            textBox3.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (state.Operation == null)
            {
                textBox4.Text = textBox3.Text;
            }
            else if (state.Operation.Equals("+"))
            {
                textBox4.Text = (state.FirstNumber + float.Parse(textBox3.Text)).ToString();
            }
            else if (state.Operation.Equals("-"))
            {
                textBox4.Text = (state.FirstNumber - float.Parse(textBox3.Text)).ToString();
            }
            else if (state.Operation.Equals("*"))
            {
                textBox4.Text = (state.FirstNumber * float.Parse(textBox3.Text)).ToString();
            }
            else if(state.Operation.Equals("/"))
            {
                textBox4.Text = (state.FirstNumber / float.Parse(textBox3.Text)).ToString();
            }
            else
            {
                textBox4.Text = textBox3.Text;
            }

            textBox3.Text = "0";
            state = new CalculatorState();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(!textBox3.Text.Equals(""))
            {
                textBox4.Text = (Math.Sqrt(double.Parse(textBox3.Text))).ToString();
                textBox3.Text = "0";
                state = new CalculatorState();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(!textBox3.Text.Equals(""))
            {
                textBox4.Text = (Math.Log(double.Parse(textBox3.Text), 2)).ToString();
                textBox3.Text = "0";
                state = new CalculatorState();
            }
        }
    }
}
