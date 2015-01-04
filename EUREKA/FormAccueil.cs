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
    public partial class FormAccueil : Form
    {
        public List<bool> TabChoix = new List<bool>();
        public FormAccueil()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++) 
            { 
                this.TabChoix.Add( false); 
            }// initialisation du tableau des choix
        }
        private bool VerifChoix(int j)
        {
            bool ok = false;
            int s = 0;

            for (int i = 1; i < j; i++)
            {
                ok = this.TabChoix[i];
                if (!ok) { s = s + 1; };
            }
            if (s == 0)
            {
                MessageBox.Show("Choix OK");
                return true;
            }
            else
            {
                MessageBox.Show("Veuillez progresser dans l'ordre SVP");
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labTitre.AutoSize = true;
            this.labTitre.Text = "A travers cette présentation nous allons apprendre comment aborder un problème." + "\r\n" + "Trouver les causes pricipales du problème et chercher des solutions";
        }

        private void RbFamile_CheckedChanged(object sender, EventArgs e)
        {
            FormFamille frm = new FormFamille();
            frm.ShowDialog();         // modale

        }

        private void BtValide_Click(object sender, EventArgs e)
        {
            FormFamille frm = new FormFamille();
            frm.ShowDialog();         // modale
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCopie frm = new FormCopie();
            frm.ShowDialog();
            //   FormVous frm = new FormVous();               
            // frm.ShowDialog();  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this.groupBox1.Controls.Count.ToString());
        }


    }
}
