// Graafinen käyttöliittymä/ Tehtävä 1/2_Tekstin tulostaminen/ 15.11.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokaGraafinen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void painikeBT_Click(object sender, EventArgs e)
        {
            
            //OtsikkoLB:in sijoitan sen, mitä tästä tekstiTB:stä tulee
            //teksti muuttuu täällä, haen tekstin tekstiTB:sta 
            OtsikkoLB.Text = tekstiTB.Text;
            //ja samalla toisen näkyväksi
            OtsikkoLB.Visible = true;
        }
    }
}
