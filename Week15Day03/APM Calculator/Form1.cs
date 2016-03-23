using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_Calculator
{
    public partial class Form1 : Form
    {
        private int counter;
        private DateTime now;
        private double apm;
        private object clickLockObject = new object();
        private static int highscore;

        public Form1()
        {
            InitializeComponent();
            this.now = DateTime.Now;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var thread = new Thread(BeginCalculate);
            thread.IsBackground = true;
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lock(clickLockObject)
            {
                counter++;
            }
        }

        private void BeginCalculate()
        {
            while(true)
            {
                lock(clickLockObject)
                {
                    TimeSpan ts = DateTime.Now - now;
                    double mins = (double)ts.TotalMinutes;
                    apm = counter / mins;
                }

                BeginInvoke((Action)delegate ()
                {
                    lock (clickLockObject)
                    {
                        label1.Text = apm.ToString();
                    }
                });

                Thread.Sleep(1000);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
