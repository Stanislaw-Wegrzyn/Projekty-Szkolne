using System.Windows.Forms;

namespace Lista09
{
    public partial class Form1 : Form
    {
        bool readed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Samochod sam1 = new Samochod();
            sam1.Id = 0;
            sam1.Marka = "Fiat";
            sam1.Model = "Punto";
            sam1.Pojemnosc = 1368f;
            sam1.Przyspieszenie = 8.5f;
            sam1.Spalanie = 5.6f;

            Samochod sam2 = new Samochod();
            sam2.Id = 1;
            sam2.Marka = "BMW";
            sam2.Model = "E36";
            sam2.Pojemnosc = 2990f;
            sam2.Przyspieszenie = 6f;
            sam2.Spalanie = 9.3f;

            Samochod sam3 = new Samochod();
            sam3.Id = 2;
            sam3.Marka = "Ford";
            sam3.Model = "Mustang GT 2015";
            sam3.Pojemnosc = 4951f;
            sam3.Przyspieszenie = 4.8f;
            sam3.Spalanie = 12f;

            Samochod sam4 = new Samochod();
            sam4.Id = 3;
            sam4.Marka = "Chevrolet";
            sam4.Model = "Camaro V";
            sam4.Pojemnosc = 6162f;
            sam4.Przyspieszenie = 6.6f;
            sam4.Spalanie = 13.1f;

            Samochod sam5 = new Samochod();
            sam5.Id = 4;
            sam5.Marka = "BMW";
            sam5.Model = "M5 F90";
            sam5.Pojemnosc = 4395f;
            sam5.Przyspieszenie = 3.3f;
            sam5.Spalanie = 12f;

            List<Samochod> samochody = new List<Samochod>();
            samochody.Add(sam1);
            samochody.Add(sam2);
            samochody.Add(sam3);
            samochody.Add(sam4);
            samochody.Add(sam5);

            dataGridViewDefault.DataSource = samochody;
            readed = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!readed)
            {
                MessageBox.Show("Najpierw kliknij przycisk \"Odczytaj\"!", "Nie wczytano!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string input = textBoxSearch.Text;
                string opcja = comboBoxSearch.Text;
                List<Samochod> samochody = (List<Samochod>)dataGridViewDefault.DataSource;

                if (opcja == "")
                {
                    MessageBox.Show("Wybierz parametr wyszukiwania z listy!", "Nie wprowadzono parametru wyszukiwania!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (input == "")
                    {
                        MessageBox.Show("WprowadŸ wartoœæ jak¹ chcesz wyszukaæ!", "Nie wprowadzono wartoœci do wyszukania!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        float finput;
                        switch (opcja)
                        {
                            case "nazwa marki":
                                dataGridViewSearch.DataSource = samochody.FindAll(x => x.Marka.Equals(input));
                                break;

                            case "nazwa modelu":
                                dataGridViewSearch.DataSource = samochody.FindAll(x => x.Model.Equals(input));
                                break;

                            case "pojemnoœæ silnika":
                                float.TryParse(input, out finput);
                                dataGridViewSearch.DataSource = samochody.FindAll(x => x.Pojemnosc.Equals(finput));
                                break;

                            case "przyspieszenie 0-100":
                                float.TryParse(input, out finput);
                                dataGridViewSearch.DataSource = samochody.FindAll(x => x.Przyspieszenie.Equals(finput));
                                break;

                            case "spalanie na 100 km":
                                float.TryParse(input, out finput);
                                dataGridViewSearch.DataSource = samochody.FindAll(x => x.Spalanie.Equals(finput));
                                break;
                        }
                    }
            }
            
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (!readed)
            {
                MessageBox.Show("Najpierw kliknij przycisk \"Odczytaj\"!", "Nie wczytano!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                List<Samochod> samochody = (List<Samochod>)dataGridViewDefault.DataSource;
                if (dataGridViewDefault.SelectedCells.Count > 0)
                {
                    int wiersz = (int)dataGridViewDefault.SelectedCells[0].RowIndex;
                    int id = (int)dataGridViewDefault.Rows[wiersz].Cells[0].Value;
                    var kasowana = samochody.Find(e => e.Id == id);
                    samochody.Remove(kasowana);
                    dataGridViewDefault.DataSource = null;
                    dataGridViewDefault.DataSource = samochody;
                }
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!readed)
            {
                MessageBox.Show("Najpierw kliknij przycisk \"Odczytaj\"!", "Nie wczytano!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string mar = textBoxMarka.Text;
                string mod = textBoxModel.Text;
                string poj = textBoxPojemnosc.Text;
                string przy = textBoxPrzyspieszenie.Text;
                string spal = textBoxSpalanie.Text;

                if (mar == "" || mod == "" || poj == "" || przy == "" || spal == "")
                {
                    MessageBox.Show("Nie wprowadzono wszystkich danych!", "B³¹d dodawania!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    float fpoj, fprzy, fspal;
                    if (!float.TryParse(poj, out fpoj) || !float.TryParse(przy, out fprzy) || !float.TryParse(spal, out fspal))
                    {
                        MessageBox.Show("Któraœ z wartoœci, która powinna byæ numeryczna nie jest numeryczna!", "B³¹d dodawania!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        float.TryParse(poj, out fpoj);
                        float.TryParse(przy, out fprzy);
                        float.TryParse(spal, out fspal);
                        List<Samochod> samochody = (List<Samochod>)dataGridViewDefault.DataSource;
                        Samochod s = new Samochod();
                        s.Id = samochody.Last<Samochod>().Id+1;
                        s.Marka = mar;
                        s.Model = mod;
                        s.Pojemnosc = fpoj;
                        s.Przyspieszenie = fprzy;
                        s.Spalanie = fspal;

                        samochody.Add(s);
                        dataGridViewDefault.DataSource = null;
                        dataGridViewDefault.DataSource = samochody;
                    }
                }
            }
            
        }
    }
}