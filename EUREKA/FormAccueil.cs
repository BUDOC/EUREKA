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
     //   int mavaleur = 1000;
        Form Alancer = new FormFamille();
        Random r = new Random();

        //public List<bool> TabChoix = new List<bool>();
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // chart1
   
            this.chart1.ResetAutoValues();
            this.chart1.CreateGraphics();
            this.chart1.Series["Causes"].Points.Clear();
            this.chart1.Series["Causes"].Points.AddXY("c1",2);
            this.chart1.Series["Causes"].Points.AddXY("c2", 4);
            this.chart1.Series["Causes"].Points.AddXY("c3", 3);
            this.chart1.Series["Causes"].Points.AddXY("c4", 8);
           // this.chart1.Series["Causes"].Points[2].SetValueY(54);

            this.labTitre.AutoSize = true;
            this.labTitre.Text = "A travers cette présentation nous allons apprendre comment aborder un problème." + "\r\n" + "Trouver les causes pricipales du problème et chercher des solutions";
        }

        private void RbFamile_CheckedChanged(object sender, EventArgs e)
        {
            Alancer = new FormFamille();
           

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

        private void BtValider_Click(object sender, EventArgs e)
        {
            Alancer.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           this.chart1.Series["Causes"].Points.Clear();
           this.chart1.Series["Causes"].Points.AddXY("c1", r.Next(20));
           this.chart1.Series["Causes"].Points.AddXY("c2", r.Next(20));
           this.chart1.Series["Causes"].Points.AddXY("c3", r.Next(20));
           this.chart1.Series["Causes"].Points.AddXY("c4", r.Next(20));
        }


    }
}
