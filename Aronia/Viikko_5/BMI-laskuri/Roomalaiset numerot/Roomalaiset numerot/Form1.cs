// Graafinen käyttöliittymä/ Tehtävä 8_Roomalaiset numerot/ 15.12.2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roomalaiset_numerot
{
    public partial class RoomalaisiksiForm : Form
    {
        public RoomalaisiksiForm()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4; // 1000,100,10,1
            string vastaus = ""; // vastaus on tyhjä
            if(TekstiTB.Text.Length > 3) // tuhatluku
            {
                luku1 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Tuhannet
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Sadat
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1)); // Kympit
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(3, 1)); // Ykköset
                if (luku1 % 3 == 0) // jos on jaollinen kolmella
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
             else if(TekstiTB.Text.Length > 2) // kyseessä on sataluku
            {
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Sadat
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Kympit
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1)); // Ykköset
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if (TekstiTB.Text.Length > 1) // kyseessä on kymmenluku
            {
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Kympit
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Ykköset
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if (TekstiTB.Text.Length > 0) // kyseessä on ykkösluku
            {
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Ykköset
                vastaus += ykkoset(luku4, vastaus);
            }
            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }
        private string sataset(int luku2, string vastaus) // palauttaa arvon
        {
            if(luku2 % 9 == 0 && luku2 != 0) // ei ole 0
            {
                return "CM"; // CM tarkoittaa 900
            }
            else if(luku2 % 8 == 0 && luku2 != 0)
            {
                return "DCCC";// D (500) + ccc (300) = 800 
            }
            else if (luku2 % 7 == 0 && luku2 != 0)
            {
                return "DCC";// = 700
            }
            else if (luku2 % 6 == 0 && luku2 != 0)
            {
                return "DC";// = 600
            }
            else if (luku2 % 5 == 0 && luku2 != 0)
            {
                return "D";// = 500
            }
            else if (luku2 % 4 == 0 && luku2 != 0)
            {
                return "CD";//  = 400
            }
            else if (luku2 % 3 == 0 && luku2 != 0)
            {
                return "CCC";//  =300
            }
            else if (luku2 % 2 == 0 && luku2 != 0)
            {
                return "CC";//= 200
            }
            else if (luku2 % 1 == 0 && luku2 != 0)
            {
                return "C";// 100
            }
            else
            {
                return "";// 
            }
        }

        private string kympit(int luku3, string vastaus)
        {
            if(luku3 % 9 == 0 && luku3 != 0)
            {
                return "XC"; // 90
            }
            else if (luku3 % 8 == 0 && luku3 != 0)
            {
                return "LCCC"; // 80
            }
            else if (luku3 % 7 == 0 && luku3 != 0)
            {
                return "LCC"; // 70
            }
            else if (luku3 % 6 == 0 && luku3 != 0)
            {
                return "LC"; // 60
            }
            else if (luku3 % 5 == 0 && luku3 != 0)
            {
                return "L"; // 50
            }
            else if (luku3 % 4 == 0 && luku3 != 0)
            {
                return "XL"; // 40
            }
            else if (luku3 % 3 == 0 && luku3 != 0)
            {
                return "XXX"; // 30
            }
            else if (luku3 % 2 == 0 && luku3 != 0)
            {
                return "XX"; // 20
            }
            else if (luku3 % 1 == 0 && luku3 != 0)
            {
                return "X"; // 10
            }
            else 
            {
                return ""; // 0
            }
        }

        private string ykkoset(int luku4, string vastaus)
        {
            if(luku4 % 9 == 0 && luku4 != 0)
            {
                return "IX";
            }
            else if (luku4 % 8 == 0 && luku4 != 0)
            {
                return "VIII";
            }
            else if (luku4 % 7 == 0 && luku4 != 0)
            {
                return "VII";
            }
            else if (luku4 % 6 == 0 && luku4 != 0)
            {
                return "VI";
            }
            else if (luku4 % 5 == 0 && luku4 != 0)
            {
                return "V";
            }
            else if (luku4 % 4 == 0 && luku4 != 0)
            {
                return "IV";
            }
            else if (luku4 % 3 == 0 && luku4 != 0)
            {
                return "III";
            }
            else if (luku4 % 2 == 0 && luku4 != 0)
            {
                return "II";
            }
            else if (luku4 % 1 == 0 && luku4 != 0)
            {
                return "I";
            }
            else 
            {
                return "";
            }
        }
    }
    
}
