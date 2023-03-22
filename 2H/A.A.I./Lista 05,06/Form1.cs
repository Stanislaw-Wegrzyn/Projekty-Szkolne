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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista_05_06
{
    public partial class Form1 : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        public void buttonFileReader_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Txt files (*.txt)|*.txt|Xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;


                }
            }

            textBoxFileName.Text = filePath;
        }

        private void AddTreeNodes(ref XmlNode node, ref TreeNode treeNode)
        {
            XmlNode childNode;
            TreeNode treeChildNode;
            XmlNodeList nodes;

            if (node.HasChildNodes)
            {
                nodes = node.ChildNodes;
                for (int i = 0; i < nodes.Count; i++)
                {
                    childNode = node.ChildNodes[i];
                    treeNode.Nodes.Add(new TreeNode(childNode.Name));
                    treeChildNode = treeNode.Nodes[i];
                    AddTreeNodes(ref childNode, ref treeChildNode);
                }
            }
            else
            {
                treeNode.Text = node.InnerText;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab == tabPage1)
            {
                if (textBoxFileName.Text != "")
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(textBoxFileName.Text))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        textBoxFileStream.Text = fileContent;
                    }
                    //No localization
                    catch (ArgumentException arg)
                    {
                        MessageBox.Show("Nie podano lokalizacji pliku", "Brak lokalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //No File
                    catch (FileNotFoundException file)
                    {
                        MessageBox.Show("Taki plik nie istnieje: \n" + file.FileName, "Plik nie istnieje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (UnauthorizedAccessException acc)
                    {
                        MessageBox.Show("Nie podano nazwy lub rozszerzenia pliku", "Brak nazwy pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Odczytywanie nie powiodło się, nie wprowadzono lokalizacji pliku!", "Nie wprowadzono lokalizacji pliku!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



            }
            else if (this.tabControl.SelectedTab == tabPage2)
            {
                if (textBoxFileName.Text != "")
                {
                    if (textBoxFileName.Text.Substring(textBoxFileName.Text.Length - 3) == "xml")
                    {
                        //textBoxFileName.Text = "";
                        XmlDocument doc = new XmlDocument();
                        doc.Load(textBoxFileName.Text);
                        string firstRow = doc.FirstChild.InnerText;
                        int start = 0;

                        if (firstRow.Length > 6)
                        {
                            firstRow = firstRow.Substring(0, 7);
                            if (firstRow == "version")
                            {
                                start = 1;
                            }
                        }

                        XmlNode node = doc.ChildNodes[start];

                        treeView.Nodes.Clear();
                        treeView.Nodes.Add(new TreeNode(doc.DocumentElement.Name));
                        TreeNode treeNode = treeView.Nodes[0];

                        AddTreeNodes(ref node, ref treeNode);

                        treeView.ExpandAll();
                        treeView.Nodes[0].BeginEdit();

                    } else
                    {
                        MessageBox.Show("Nie możesz wcztać tego pliku. To nie jest plik XML.", "BłędnyPlik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        using (StreamReader reader = new StreamReader(textBoxFileName.Text))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        textBoxFileStream.Text = fileContent;
                    }
                    //No localization
                    catch (ArgumentException arg)
                    {
                        MessageBox.Show("Nie podano lokalizacji pliku", "Brak lokalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //No File
                    catch (FileNotFoundException file)
                    {
                        MessageBox.Show("Taki plik nie istnieje: \n" + file.FileName, "Plik nie istnieje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (UnauthorizedAccessException acc)
                    {
                        MessageBox.Show("Nie podano nazwy lub rozszerzenia pliku", "Brak nazwy pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Odczytywanie nie powiodło się, nie wprowadzono lokalizacji pliku!", "Nie wprowadzono lokalizacji pliku!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab == tabPage1)
            {
                var fileContent = textBoxFileStream.Text;
                var filePath = textBoxFileName.Text;

                /*if (filePath.Substring(filePath.Length - 4) != ".txt")
                {
                    MessageBox.Show("Zapisywanie nie powiodło się, plik nie ma rozszerzenia!", "Nie wprowadzono rozszerzenia pliku!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else { */
                try
                {
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.Write(fileContent);
                        writer.Close();
                    }

                    MessageBox.Show("Zapisano poprawnie!", "Zapisano zawartosc pliku: " + filePath, MessageBoxButtons.OK);
                }
                catch (ArgumentException arg)
                {
                    MessageBox.Show("Zapisywanie nie powiodło się, nie wybrako siezki pliku!", "Nie wybrano sciezki pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException acc)
                {
                    MessageBox.Show("Nie podano nazwy lub rozszerzenia pliku, albo program nie ma dostepu do tej lokalizacji!", "Brak nazwy lub rozszerzenia pliku, albo program nie ma dostepu do tej lokalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
            else if (this.tabControl.SelectedTab == tabPage2)
            {
                exportToXml();
               
            }
            }

        StreamWriter sr = null;

        public void exportToXml()
        {
            
                try
                {
                    sr = new StreamWriter(textBoxFileName.Text, false, System.Text.Encoding.UTF8);
                    sr.WriteLine("<" + treeView.Nodes[0].Text + ">");
                    foreach (TreeNode node in treeView.Nodes)
                    {
                        saveNode(node.Nodes);
                    }
                    //Close the root node
                    sr.WriteLine("</" + treeView.Nodes[0].Text + ">");
                    sr.Close();
                    MessageBox.Show("Zapisano pilk", "Zpisano plik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException arg)
                {
                    MessageBox.Show("Nie podano lokalizacji do zapisu", "Brak lokalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          


        }

        private void saveNode(TreeNodeCollection treeNodeCollection)
        {
            foreach (TreeNode node in treeNodeCollection)
            {

                if (node.Nodes.Count > 0)
                {
                    sr.Write("<" + node.Text + ">");
                    saveNode(node.Nodes);
                    sr.WriteLine("</" + node.Text + ">");
                }
                else
                {
                    sr.Write(node.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
