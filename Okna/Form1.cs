using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klice_zamestnanci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void přidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoPridatZamestnance oknoPridatZamestnance = new OknoPridatZamestnance();
            oknoPridatZamestnance.ShowDialog();
        }

        private void upravitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoUpravitZamestnance oknoUpravitZamestnance = new OknoUpravitZamestnance();
            oknoUpravitZamestnance.ShowDialog();
        }

        private void odstranitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoOdstranitZamestnance oknoOdstranitZamestnance = new OknoOdstranitZamestnance();
            oknoOdstranitZamestnance.ShowDialog();
        }
    }
}
