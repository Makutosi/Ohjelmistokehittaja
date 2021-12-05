// Graafinen käyttöliittymä/ Tehtävä 3_Yksinkertainen laskuri/ 16.112021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin1
{
    public partial class Laskin : Form
    {
        public Laskin()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float lasku = 0;
            float luku1 = float.Parse(lukuYksiTB.Text);
            float luku2 = float.Parse(lukuKaksiTB.Text);
            string merkki = LaskutoimitusCB.Text;
            switch(merkki)
            {
                case "+":
                    lasku = luku1 + luku2;
                    break;

                case "-":
                    lasku = luku1 - luku2;
                    break;

                case "*":
                    lasku = luku1 * luku2;
                    break;

                case "/":
                    if(luku2 == 0)
                    {
                        VastausLB.Text = "Nollalla ei voi jakaa.";
                        goto HYPPY;
                    }
                    else 
                    { 
                    lasku = luku1 / luku2;
                    }
                     break;
            }
            VastausLB.Text = lasku + "";
            HYPPY:
            VastausLB.Visible = true;
            
        }
    }
}
