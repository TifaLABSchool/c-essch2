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

namespace TreeViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Load Location path*/
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
           if(result == DialogResult.OK)
            {
           textBox1.Text = fbd.SelectedPath;
            }
        }
        /*Show Files And Folders In treeView */
        private void button2_Click(object sender, EventArgs e)
        {
            ListFoldersInTreeView(textBox1.Text);
        }

        private void ListFoldersInTreeView(string Path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            treeView1.Nodes.Add(CreateFoldersNode(directoryInfo));
        }

        private TreeNode CreateFoldersNode(DirectoryInfo directoryInfo)
        {
            TreeNode tn = new TreeNode(directoryInfo.Name);
            foreach(var subfolder in directoryInfo.GetDirectories())
            {
                tn.Nodes.Add(CreateFoldersNode(subfolder));

            }
            foreach (var subfolderfiles in directoryInfo.GetFiles())
            {
                tn.Nodes.Add(new TreeNode(subfolderfiles.Name));

            }
            return tn;
        }
    }
}
