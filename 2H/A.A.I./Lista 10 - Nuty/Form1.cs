using System.Collections;
using System;

namespace Lista_10___Nuty
{
    public partial class Form1 : Form
    {
        Hashtable dlugosciNut;
        List<Nuta> wysokosciNut;
        ZnakMuzyczny znakDoWstawienia;
        List<ZnakMuzyczny> utwor;
        TypEdycji typEdycji;
        int pozycjaKursora;
        bool isEditing = false;
        bool isNuta = true;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetActive(false);
        }

        public void InitializeData()
        {
            dlugosciNut = new Hashtable();
            dlugosciNut.Add(DlugoscZnaku.calaNuta, 480);
            dlugosciNut.Add(DlugoscZnaku.polNuta, 240);
            dlugosciNut.Add(DlugoscZnaku.cwiartka, 120);
            dlugosciNut.Add(DlugoscZnaku.osemka, 60);

            wysokosciNut = new List<Nuta> { };
            wysokosciNut.Add(new Nuta(1, KodNuty.C4, 262, "rl%{"));
            wysokosciNut.Add(new Nuta(2, KodNuty.D5, 294, "t;^}"));
            wysokosciNut.Add(new Nuta(3, KodNuty.E5, 330, "y'&|"));
            wysokosciNut.Add(new Nuta(4, KodNuty.F5, 349, "uz*A"));
            wysokosciNut.Add(new Nuta(5, KodNuty.G5, 392, "ix(S"));
            wysokosciNut.Add(new Nuta(6, KodNuty.A5, 440, "oc)D"));
            wysokosciNut.Add(new Nuta(7, KodNuty.B5, 494, "pv_F"));
            wysokosciNut.Add(new Nuta(8, KodNuty.C5, 523, "[b+G"));
            wysokosciNut.Add(new Nuta(9, KodNuty.Pauza, 1, "7890"));

            znakDoWstawienia = new ZnakMuzyczny(TypZnaku.nuta, DlugoscZnaku.calaNuta, KodNuty.A5);

            utwor = new List<ZnakMuzyczny> { };

            typEdycji = TypEdycji.Lista;

            pozycjaKursora = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Beep(wysokosciNut[i].Czestotliwosc, (int)dlugosciNut[DlugoscZnaku.calaNuta]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            SetActive(isEditing);
            btnStart.Enabled = !isEditing;
            btnRead.Enabled = !isEditing;
            btnSave.Enabled = !isEditing;
            if (isEditing)
            {
                btnEdit.Text = "Stop Edit";
            }
            else
            {
                btnEdit.Text = "Edit";
            }
        }

        private void SetActive(bool value)
        {
            btnAdd.Enabled = value;
            btnRemoveNote.Enabled = value;
            btnDlugoscMax.Enabled = value;
            btnDlugoscMin.Enabled = value;
            btnKontekstLewo.Enabled = value;
            btnKontekstPrawo.Enabled = value;
            btnNutaPauza.Enabled = value;
            btnToneDown.Enabled = value;
            btnToneUp.Enabled = value;
            groupBox1.Enabled = value;
        }

        private void btnNutaPauza_Click(object sender, EventArgs e)
        {
            if (isNuta)
            {
                btnNutaPauza.Text = "Pause";
            }
            else
            {
                btnNutaPauza.Text = "Note";
            }
            isNuta = !isNuta;
        }
    }
}