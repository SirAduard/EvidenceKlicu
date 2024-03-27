using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klice_zamestnanci
{
    public partial class OknoPridatZamestnance : OknoVychoziZamestnanec
    {
        public OknoPridatZamestnance()
        {
            InitializeComponent();
        }

        private void textBoxJmeno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrijmeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJmeno.Text) &&
                textBoxJmeno.Text.Length <= 64 &&
                string.IsNullOrEmpty(textBoxPrijmeni.Text) &&
                textBoxPrijmeni.Text.Length <= 64 &&
                string.IsNullOrEmpty(textBoxZkratka.Text) && 
                Regex.IsMatch(textBoxZkratka.Text, "^[A-Z]{2}$"))
            {

            }
            else
            {
                MessageBox.Show("Máte nevyplněné údaje nebo nevyhovující zkratku, která neobsahuje 2 velká písmena. Prosím napravte.");
            }



        }

        private void buttonZavrit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
