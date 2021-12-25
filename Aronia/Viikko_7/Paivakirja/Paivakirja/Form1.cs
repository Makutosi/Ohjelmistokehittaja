//Graafinen käyttöliittymä/ Tehtävä 14_Päiväkirja/ 22.12.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // <- lisätty

namespace Paivakirja
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            // Git Bash/ Ctrl + ^O Write Out / Ctrl + ^X Exit
            // Luetaan teksti
            // tehdään tiedosto/ Git Bash-> nano paivakirja.txt 
            string teksti = File.ReadAllText("C:\\Users\\eriko\\source\\repot\\Ohjelmistokehittaja\\Aronia\\Viikko_7\\Paivakirja\\paivakirja.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            // teksti, välilyönti, päivämäärä, Enterin painallus
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy H:mm") + "\n"; 
            TextWriter text = new StreamWriter("C:\\Users\\eriko\\source\\repot\\Ohjelmistokehittaja\\Aronia\\Viikko_7\\Paivakirja\\paivakirja.txt");
            text.Write(teksti);
            text.Close(); // teksti suljetaan
            Application.Exit(); // ohjelma suljetaan
        }
    }
}
