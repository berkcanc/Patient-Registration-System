using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekle e1 = new Ekle();
            e1.Show();
            this.Hide();
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sil s1 = new Sil();
            s1.Show();
            this.Hide();
        }

        private void GüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guncelle g1 = new Guncelle();
            g1.Show();
            this.Hide();
        }

        private void GörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goruntule g2 = new Goruntule();
            g2.Show();
            this.Hide();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void ProgramHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda h1 = new Hakkinda();
            h1.Show();
            this.Hide();
        }
    }
}
