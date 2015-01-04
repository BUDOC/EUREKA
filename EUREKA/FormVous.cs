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
    public partial class FormVous : Form
    {
        public Form Origine = null;
        public FormVous()
        {
            InitializeComponent();
        }
        private void bienvenue()
        {
            this.label4.Text = this.textBoxPrenom.Text + " la famille Dupond est heureuse\n de faire votre connaissance ";
        }
        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxNom.Text != "") { this.BtValider.Enabled = true; this.bienvenue(); }

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxPrenom.Text != "") { this.BtValider.Enabled = true; this.bienvenue(); }
        }

        private void FormVous_Load(object sender, EventArgs e)
        {
            this.label4.Text = "";
        }

        private void BtValider_Click(object sender, EventArgs e)
        {
            Origine.Close();
            this.Close();
        }
    }
}
