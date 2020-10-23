using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

            populateXmlTreeView("https://raw.githubusercontent.com/kizeevov/elcomplusfiles/main/config.xml");

        }

        private void xmlTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            Console.WriteLine(xmlTreeView.SelectedNode.Tag);
            propertiesTextBox.Clear();

            //propertiesTextBox.Text += xmlTreeView.SelectedNode.Tag;
        }

        private void xmlTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
        }

        private void propertiesLabel_Click(object sender, EventArgs e)
        {

        }

        private void populateXmlTreeView(string url)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);

            foreach (XmlNode xmlNode in doc.ChildNodes)
            {
                iterateThroughChildNodes(xmlNode, null);
            }          

        }

        private void iterateThroughChildNodes(XmlNode parentXmlNode, TreeNode parentTreeNode)
        {
            TreeNode newTreeNode = new TreeNode(parentXmlNode.Name);
            newTreeNode.Tag = parentXmlNode;
            
            if (parentTreeNode != null)
            {
                parentTreeNode.Nodes.Add(newTreeNode);
            } else
            {
                xmlTreeView.Nodes.Add(newTreeNode);
            }
            

            foreach (XmlNode childNode in parentXmlNode.ChildNodes)
            {
                iterateThroughChildNodes(childNode, newTreeNode);
            }
        }

    }
}
