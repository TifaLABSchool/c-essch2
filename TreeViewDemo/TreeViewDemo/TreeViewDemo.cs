using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewDemo
{
    public partial class TreeViewDemo : Form
    {
        public TreeViewDemo()
        {
            InitializeComponent();
        }

        private void TreeViewDemo_Load(object sender, EventArgs e)
        {
            TreeNode DepTreenode = new TreeNode("Department");
            DepTreenode.Nodes.Add("HR");
            DepTreenode.Nodes.Add("IT");
            DepTreenode.Nodes.Add("SERVICES");
            TreeNode empTreenode = new TreeNode("Employee");
            empTreenode.Nodes.Add("Mostafa");
            empTreenode.Nodes.Add("Ahmed");
            empTreenode.Nodes.Add("mohammed");
            treeView1.Nodes.Add(DepTreenode);
            treeView1.Nodes.Add(empTreenode);
        }
        /*Remove node From Tree View */
        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
        /**Add New Node To TreeView */
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[comboBox1.SelectedIndex].Nodes.Add(textBox1.Text);
        }
    }
}
