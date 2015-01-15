using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormFamille : Form
    {
        private bool vous = false;
        public FormFamille()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.label1.Text = " Je m'appelle Nathalie j'ai 38 ans et je suis la mère de famille.";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.label1.Text = " Je m'appelle Paul j'ai 40 ans et je suis le père de famille.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.label1.Text = " Je m'appelle Noémie j'ai 17 ans et je suis en terminale au lycée Réaumur.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.label1.Text = " Je m'appelle Julien j'ai 14 ans et je suis en 3eme au Collège Jules Renard.";
        }

        private void BtSuite_Click(object sender, EventArgs e)
        {
            this.vous = true;
            FormVous frm = new FormVous();
            frm.Origine = this;
            frm.ShowDialog(); // modale
        }

        private void FormFamille_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!vous)
            {
                var result = MessageBox.Show("Veuillez vous présenter avant de quitter le fenêtre SVP!");
                e.Cancel = true;                
                return;
            }

        }


    }
}
