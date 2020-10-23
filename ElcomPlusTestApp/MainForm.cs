using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElcomPlusTestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            
        }

        private void buildTreeButton_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(xmlAdressBox.Text);

            TreeNode testNode = new TreeNode("Тест");
            testNode.Tag = "test";

            TreeNode test = new TreeNode("AAsdasd");
            xmlTreeView.Nodes.Add(testNode);
            xmlTreeView.Nodes.Add(test);
        }

        private void xmlTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            Console.WriteLine(xmlTreeView.SelectedNode.Tag);
            propertiesTextBox.Clear();

            propertiesTextBox.Text += xmlTreeView.SelectedNode.Tag;
        }

        private void xmlTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
        }

        private void propertiesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
