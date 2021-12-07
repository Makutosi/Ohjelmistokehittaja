// Graafinen käyttöliittymä/ Tehtävä 11_Nopan heitto/ 1.12.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopanheittopeli
{
    public partial class NopanHeitto : Form
    {
        public NopanHeitto()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa01PB);
            piirraNoppa(noppa02PB);
        }

        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random(); // olio satunnainen
            int noppa = satunnainen.Next(1, 7); // arpo 1-6 välillä
            switch(noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.noppa01;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.noppa02;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.noppa03;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.noppa04;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.noppa05;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.noppa06;
                    break;
            }
        }
    }
}
