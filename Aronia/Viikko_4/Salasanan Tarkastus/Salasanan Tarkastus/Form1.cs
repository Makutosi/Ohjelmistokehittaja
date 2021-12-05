//Graafinen käyttöliittymä/ Tehtävä 6_Salasana/ 27.11.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salasanan_Tarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }
  
        // Turhat
        private void panel1_Paint(object sender, PaintEventArgs e) 
        {                                                          
                                                                   
        } 
        // tähän asti

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Ku1ta") // = sijoituslause
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true; // toinen piiloon ja toinen näkyviin
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
