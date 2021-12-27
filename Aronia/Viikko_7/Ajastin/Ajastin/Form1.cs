// Graafinen käyttöliittymä/ Tehtävä 16_Ajastin/ 27.12.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajastin
{
    public partial class CountDownForm : Form
    {
        private int kokonaisaika; // yleinen muuttuja
        public CountDownForm()
        {
            InitializeComponent();
        }

        private void CountDownForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; // StopBT ei ole käytössä
            for(int i = 0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString()); // Lisätään 0-59 minuutteihin
                SekunnitCB.Items.Add(i.ToString()); //               sekunteihin
            }
            MinuutitCB.SelectedIndex = 0; // Oletusarvo  
            SekunnitCB.SelectedIndex = 10;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // silloin kun painetaan, Start.BT menee pois käytöstä.
            StopBT.Enabled = true;   //  ja StopBT tulee käyttöön
            // lasketaan kokonaisaika sekunteina
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString()); // Haetaan valitut minuutit
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString()); // Haetaan valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            // Ajastin on päällä
            if(kokonaisaika > 0)
            {
                kokonaisaika--; // vähenee yhdellä
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit + ":" + sekunnit;
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Time over!");
            }
        }
    }
}
