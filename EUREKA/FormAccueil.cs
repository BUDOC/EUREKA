﻿using System;
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
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labTitre.AutoSize = true;
            this.labTitre.Text = "A travers cette présentation nous allons apprendre comment aborder un problème." +"\r\n"+"Trouver les causes pricipales du problème et chercher des solutions";
        }

        private void RbFamile_CheckedChanged(object sender, EventArgs e)
        {
       
           // FormFamille.ShowDialog(); // modale
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

        
    }
}