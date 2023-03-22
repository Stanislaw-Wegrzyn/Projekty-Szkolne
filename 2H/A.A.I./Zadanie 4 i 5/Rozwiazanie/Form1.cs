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

namespace OperacjNaPlikachTekstowych
{
    public partial class Form1 : Form
    {
        bool readedTXT = false;
        bool readedXML = false;
        int filterIndex = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_txt_CheckedChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = txtFiles;
            tabControl.SelectedTab.Show();
            filterIndex = 1;
        }

        private void rb_xml_CheckedChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = XMLfiles;
            tabControl.SelectedTab.Show();
            filterIndex = 2;
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == txtFiles)
            {
                filterIndex = 1;
                rb_txt.Checked = true;
            }
            else
            {
                filterIndex = 2;
                rb_xml.Checked = true;
            }
        }

        private void btn_localization_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = filterIndex;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_lokalizacja.Text = openFileDialog.FileName;
            }
        }

        //TXT

        private void btn_wczytaj_txt_Click(object sender, EventArgs e)
        {
            try
            {
                treeView.Nodes.Clear();
                txt_fileContent_txt.Text = "";
                string localization = txt_lokalizacja.Text;
                StreamReader sr = new StreamReader(localization);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    txt_fileContent_txt.AppendText(line);
                    txt_fileContent_txt.AppendText(Environment.NewLine);
                }
                sr.Close();
                readedTXT = true;
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

        private void btn_zapisz_txt_Click(object sender, EventArgs e)
        {
            try
            {
                string localization = txt_lokalizacja.Text;

                StreamWriter writer = File.CreateText(localization);

                writer.Write(txt_fileContent_txt.Text);

                writer.Close();

                MessageBox.Show("Zapisano pilk", "Zpisano plik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException arg)
            {
                MessageBox.Show("Nie podano lokalizacji do zapisu", "Brak lokalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException acc)
            {
                MessageBox.Show("Nie podano nazwy lub rozszerzenia pliku", "Brak rozszerzenia pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //XML

        private void btn_wczytaj_xml_Click(object sender, EventArgs e)
        {
            if (true)
            {
                try
                {
                    if (txt_lokalizacja.Text.Substring(txt_lokalizacja.Text.Length - 3) != "xml")
                    {
                        MessageBox.Show("Nie możesz wcztać tego pliku. To nie jest plik XML.", "BłędnyPlik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    txt_fileContent_txt.Text = "";
                    XmlDocument doc = new XmlDocument();
                    doc.Load(txt_lokalizacja.Text);
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
                    readedXML = true;
                }
                catch (ArgumentException arg)
                {
                    MessageBox.Show("Nie podano lokalizacji pliku", "Brak lokalizacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException file)
                {
                    MessageBox.Show("Taki plik nie istnieje: \n" + file.FileName, "Plik nie istnieje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddTreeNodes(ref XmlNode node, ref TreeNode treeNode)
        {
            XmlNode childNode;
            TreeNode treeChildNode;
            XmlNodeList nodes;

            if (node.HasChildNodes)
            {
                nodes = node.ChildNodes;
                for(int i = 0; i<nodes.Count; i++)
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

        private void btn_zapisz_xml_Click(object sender, EventArgs e)
        {
            exportToXml();
        }

        StreamWriter sr = null;

        public void exportToXml()
        {
            if (treeView.Nodes != null)
            {
                try
                {
                    sr = new StreamWriter(txt_lokalizacja.Text, false, System.Text.Encoding.UTF8);
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
            else{
                MessageBox.Show("Żaden plik nie jest wczytany więc nie można wykonać akcji zapisywania", "Plik nie zapisany", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }

        private void txt_fileContent_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
