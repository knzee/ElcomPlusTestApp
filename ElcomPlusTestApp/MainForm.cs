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
            string xmlUrl = xmlAdressBox.Text;

            if (xmlUrl.Length == 0)
            {
                popUpMessage("Пустая адресная строка");
            } else
            {
                populateXmlTreeView(xmlUrl);
            }

        }

        private void popUpMessage(string message)
        {
            string caption = "Ошибка";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void xmlTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            Console.WriteLine(xmlTreeView.SelectedNode.Tag);
            attributesTextBox.Clear();

            XmlNode taggedNode = (XmlNode) xmlTreeView.SelectedNode.Tag;

            if (taggedNode.Attributes != null)
            {
                foreach (XmlAttribute attr in taggedNode.Attributes)
                {
                    attributesTextBox.AppendText($"{attr.Name} = {attr.Value}");
                    attributesTextBox.AppendText(Environment.NewLine);
                }
            }
            
        }

        private void populateXmlTreeView(string url)
        {
            xmlTreeView.Nodes.Clear();
            XmlDocument doc = new XmlDocument();
            
            try
            {
                doc.Load(url);

                foreach (XmlNode xmlNode in doc.ChildNodes)
                {
                    iterateThroughChildNodes(xmlNode, null);
                }
            }
            catch (Exception ex)
            {
                popUpMessage(String.Format("XmlException: {0}", ex.Message));
            }
                      

        }

        private void iterateThroughChildNodes(XmlNode parentXmlNode, TreeNode parentTreeNode)
        {
            TreeNode newTreeNode;
            switch (parentXmlNode.NodeType)
            {
                case (XmlNodeType.Text):
                    newTreeNode = new TreeNode("text: " + parentXmlNode.Value);
                    break;
                // Можно добавить обработку других типов узлов
                default:
                    newTreeNode = new TreeNode(parentXmlNode.Name);
                    break;
            }
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
