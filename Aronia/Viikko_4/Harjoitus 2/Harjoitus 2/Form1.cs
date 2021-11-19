// Viikko 4/ Harjoitus 2/ Lisätään ominaisuuksia/ 19.11.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            // Määritellään teksti-muuttuja,string
            // Annetaan nimi, teksti
            // Haetaan ViestiTB:en sisällö, ViestiTB.Text
            string teksti = ViestiTB.Text;

            // Sijoitetaan teksti TulostusLB.Text:in
            TulostusLB.Text = teksti;

            //TulostusLB.Text = ViestiTB.Text; //
            // tässä vaiheessa ei tapahdu mitään vielä...

            TulostusLB.Visible = true;
        }
    }
}
