// Viikko 4/ 20.11.2021/ 20.Harjoitus-CRUD
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_projekt
{
    public partial class YllapitoForm : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();  // <--
        public YllapitoForm()
        {
            InitializeComponent();
        }

        private void emailLB_Click(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        // --> Tästä
        private void TyhjennaBT_Click(object senser, EventArgs e)
        {
            
        }
       
        private void TallennaBT_Click(object sender, EventArgs e)
        {
            
        }

        
        private void paivitaBT_Click(object sender, EventArgs e)
        {
            
        }

        
        private void TietotauluDG_CellClick(object sender, DataGridViewCellCancelEventArgs e) // Tietotaulu ilman DG?
        {
            idTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();  
            enimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            oNroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            
        }
        // <--tähän asti EI

        // Päivitä-painike
        private void paivitaBT_Click_1(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puhelin = puhTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(oNroTB.Text);
            int oid = Int32.Parse(idTB.Text);
            // tarkistetaan, onko kaikki täytetty
            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)  //
                {
                    MessageBox.Show("Opikelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
        
        // Tallenna-painike
        private void tallennaBT_Click_1(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puhelin = puhTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(oNroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähkoposti ja Opiskelijanumero",
                    "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaOpiskelija = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        // Tyhjennä-painike
        private void tyhjennaBT_Click_1(object sender, EventArgs e)
        {
            idTB.Text = "";
            enimiTB.Text = "";
            snimiTB.Text = "";
            puhTB.Text = "";
            emailTB.Text = "";
            oNroTB.Text = "";
        }

        // Poista-painike
        private void poistaBT_Click_1(object sender, EventArgs e)
        {
            String ktunnus = idTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelija ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

        private void TietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 20.Harjoitus_Dia 28
            TietotauluDG.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            enimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            oNroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
            
        }
    }
}
 