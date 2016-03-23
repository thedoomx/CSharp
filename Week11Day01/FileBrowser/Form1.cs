using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser
{
    public partial class Form1 : Form
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(dirInfo.Exists)
            {
                try
                {
                    DirectoryInfo[] directories = dirInfo.GetDirectories();
                    if(directories.Length > 0)
                    {
                        foreach (DirectoryInfo directory in directories)
                        {
                            TreeNode node = treeView1.Nodes[0].Nodes.Add(directory.Name);
                            foreach (FileInfo file in directory.GetFiles())
                            {
                                if(file.Exists)
                                {
                                    TreeNode nodes = treeView1.Nodes[0].Nodes[node.Index].Nodes.Add(file.Name);

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
