using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoAplikacija
{
    public partial class FrmLoto : Form
    {
            private Loto loto;
            public void Loto()
            {
                InitializeComponent();
                loto = new Loto();

            }

            private void btnUplati_Click(object sender, EventArgs e)
            {
                List<string> vrijednosti = new List<string>();
                vrijednosti.Add(textBoxUplaceniBroj1.Text);
                vrijednosti.Add(textBoxUplaceniBroj2.Text);
                vrijednosti.Add(textBoxUplaceniBroj3.Text);
                vrijednosti.Add(textBoxUplaceniBroj4.Text);
                vrijednosti.Add(textBoxUplaceniBroj5.Text);
                vrijednosti.Add(textBoxUplaceniBroj6.Text);
                vrijednosti.Add(textBoxUplaceniBroj7.Text);

                bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
                if (ispravnaKombinacija == true)
                {
                    btnOdigraj.Enabled = true;
                }
                else
                {
                    btnOdigraj.Enabled = false;
                    MessageBox.Show("Kombinacija uplaćenih brojeva nije ispravna!");
                }

            }

            private void buttonOdigraj_Click(object sender, EventArgs e)
            {
                loto.GenerirajDobitnuKombinaciju();

                txtDobitniBroj1.Text = loto.DobitniBrojevi[0].ToString();
                txtDobitniBroj2.Text = loto.DobitniBrojevi[1].ToString();
                txtDobitniBroj3.Text = loto.DobitniBrojevi[2].ToString();
                txtDobitniBroj4.Text = loto.DobitniBrojevi[3].ToString();
                txtDobitniBroj5.Text = loto.DobitniBrojevi[4].ToString();
                txtDobitniBroj6.Text = loto.DobitniBrojevi[5].ToString();
                txtDobitniBroj7.Text = loto.DobitniBrojevi[6].ToString();

                int brojPogodaka = loto.IzracunajBrojPogodaka();
                lblBrojPogodaka.Text = brojPogodaka.ToString();

            }

            private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDobitniBrojX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUplaceniBrojX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
