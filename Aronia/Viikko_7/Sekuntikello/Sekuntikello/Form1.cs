// Graafinen käyttöliittymä/ Tehtävä 15_Sekuntikello/ 26.12.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // <--

namespace Sekuntikello
{
    public partial class SekkariForm : Form
    {
        private Stopwatch sekkari; // uusi olio private, joka toimii vain tämän sisällä
        public SekkariForm()
        {
            InitializeComponent();
        }

        

        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset(); 
        }

        private void SekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }

        private void AjanottoTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
                          // f -> sekunnin sadas osa
                          //sekkari.Elasped.ToString();  liian paljon desimaaleja
        }
    }
}
//BT: Käynnistä, Lopeta, Tyhjennä <- yksi klikkaus, loput kaksi BT  +Ctrl klikkaus 
// -> Make horizontal Spacing Equal 
// Form/ Sekuntikello/ SekkariForm
// Label/ AikaLB
// Button/ KaynnistaBT/ LopetaBT/ TyhjennaBT
// Timer/ AjanottoTM/ Enabled(käytössä)True
