using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Examen.Classes;

namespace Examen.Forms
{
    public partial class Payement : Form
    {
        PayementFrais p = new PayementFrais();
        public Payement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(CNE.Text) || string.IsNullOrEmpty(Montant.Text))
                MessageBox.Show("Aucun champ ne doit rester vide!");
            else
                p.payer(comboBox1.Text,int.Parse(Montant.Text),int.Parse(CNE.Text));
        }
    }
}
