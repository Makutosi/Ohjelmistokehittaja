// Graafinen käyttöliittymä/ ekaGraafinen/ Tehtävä 1_Heippa maailma/ 15.11.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekaGraafinen
{
    public partial class LomakeFM : Form
    {
        public LomakeFM()
        {
            InitializeComponent();
        }

        private void PainikeBT_Click(object sender, EventArgs e)
        {
            OtsikkoLB.Text = "Heippa maailma";
        }
    }
}
