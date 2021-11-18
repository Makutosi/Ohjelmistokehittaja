//15.11.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttarit = ikaDT.Value;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            paivinaLB.Text = erotus + "";
            paivinaLB.Visible = true;
        }
    }
}
