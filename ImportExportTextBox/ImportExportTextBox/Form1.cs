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

namespace ImportExportTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Svae Btn to External File */
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT (.txt)|*.txt";
          
            DialogResult dialogResult = sfd.ShowDialog();
            

            if (dialogResult == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }
        /* Impoert From External File */
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           DialogResult result = ofd.ShowDialog();
         
           
            if (result == DialogResult.OK)
            {
             richTextBox1.Text =   File.ReadAllText(ofd.FileName);

            }
        }
    }
}
