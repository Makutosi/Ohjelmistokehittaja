// 5.Harjoitus-järjestys/ 27.11.2021
// Enterin painallus lisää jonoon, -999 järjestää jonon ja tulostaa sen vastaus-labeliin
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukujenLisaysLajittelu
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    vastausLB.Text = ""; // tyhjä
                    int[] taulukko = jono.ToArray();  // List-muuttuja taulukko-muutujaksi
                    Array.Sort(taulukko);             // Array.Sort:lla taulukko pystyy järjestämään

                    // taulukon tulostaminen, yksi jäsen kerrallaan taulukosta käydään läpi -> foreach
                    foreach (var jasen in taulukko)
                    {
                        vastausLB.Text += jasen + " "; // lisätään uusu jäsen seuraavan perään
                    }
                    vastausLB.Visible = true; // nyt näytetään
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text)); // muutetaan integereksi
                    uusiLukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    }
}
