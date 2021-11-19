// Ohjelmointi 14/ 9.Harjoitus/ 19.11.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteMuunnin
{
    public partial class AsteMuunninForm : Form
    {
        public AsteMuunninForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if(CelsiusRB.Checked)
                //if > else if > else
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celsius astetta.";
                // "väli *****"
                VastausLB.Visible = true;
            }
            else if(FahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " Celsiusta on " + vastaus + " Fahrenheit astetta.";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = " Et valinnut muunnettava astetta tai antanut oikea lukua.";
                VastausLB.Visible = true;
            }
        }
    }
}
