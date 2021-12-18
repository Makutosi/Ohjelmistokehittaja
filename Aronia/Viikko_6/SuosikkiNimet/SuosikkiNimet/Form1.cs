// Graafinen käyttöliittymä/ Tehtävä 13_Suosikki nimet/ 17.12.2021
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

namespace SuosikkiNimet
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = ""; // Vastaus teksti tyhjennetään joka kerta
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\eriko\\source\\repot\\Ohjelmistokehittaja\\Aronia\\Viikko_6\\SuosikkiNimet\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\eriko\\source\\repot\\Ohjelmistokehittaja\\Aronia\\Viikko_6\\SuosikkiNimet\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1, laskurit = 1;
            foreach(string poju in pojat)
            {
                if(nimi == poju)
                { 
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string friidu in tytot)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if(VastausLB.Visible == false)
            {
                VastausLB.Text = "Valitettavasti nimesi ei löytynyt suosituimpien nimien joukossa! :-(";
                VastausLB.Visible = true;
            }


        }
    }
}
