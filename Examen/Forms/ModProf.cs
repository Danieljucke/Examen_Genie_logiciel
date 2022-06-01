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
    public partial class ModProf : Form
    {
        Toolkit t = new Toolkit();
        Professeur prof = new Professeur();
        public ModProf()
        {
            InitializeComponent();
            t.AfficherDataGrid("Professeur",dataGridView1);
            
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CIN.Text))
                MessageBox.Show("saisir le CIN avant de chercher!");
            else
            {
                t.search(CIN.Text, "Professeur", "CIN", dataGridView1);
                ClearTextBoxes();
                CIN.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.Selectionner(panel3, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prof.ModifierProf(CIN.Text, Nom.Text, Postnom.Text, Prenom.Text, Convert.ToChar(Sexe.Text), DateNaissance.Text, Adresse.Text, telephone.Text, Email.Text, Titre.Text);
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
