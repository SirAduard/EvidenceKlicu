using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klice_zamestnanci
{
    public class Zamestnanec
    {
        string jmeno;
        string prijmeni;
        string zkratka;

        Zamestnanec(string jmeno, string prijmeni, string zkratka)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.zkratka = zkratka;
        }

        public Zamestnanec VytvoritNovehoZamestnance(string jmeno, string prijmeni, string zkratka)
        {
            bool jdevytvoritZamestnanec = JdevytvoritZamestnanec(jmeno, prijmeni, zkratka);
            if (jdevytvoritZamestnanec)
            {
                Zamestnanec novyZamestnanec = new Zamestnanec(jmeno, prijmeni, zkratka);
                return novyZamestnanec;
            }
            else
            {
                MessageBox.Show("Máte nevyplněné údaje nebo nevyhovující zkratku, která neobsahuje 2 velká písmena. Prosím napravte.");
            }

            
        }

        private bool JdevytvoritZamestnanec(string jmeno, string prijmeni, string zkratka)
        {
            if (string.IsNullOrEmpty(jmeno) &&
                jmeno.Length <= 64 &&
                string.IsNullOrEmpty(prijmeni) &&
                prijmeni.Length <= 64 &&
                string.IsNullOrEmpty(zkratka) &&
                Regex.IsMatch(zkratka, "^[A-Z]{2}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
