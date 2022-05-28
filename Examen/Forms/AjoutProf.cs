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
    public partial class AjoutProf : Form
    {
        Professeur prof = new Professeur();

        public AjoutProf()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void AjoutProf_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CIN.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(Nom.Text))
                MessageBox.Show("Aucun champs ne doit rester vide!");
            else
                prof.AjouterProf(CIN.Text, Nom.Text, postnom.Text, prenom.Text, char.Parse(comboBox1.Text), Birthday.Text, adresse.Text, tel.Text, mail.Text, titre.Text);
            ClearTextBoxes();
            CIN.Focus();
        }
    }
}
