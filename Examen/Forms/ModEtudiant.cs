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
    public partial class ModEtudiant : Form
    {
        Toolkit t = new Toolkit();
        Etudiant st = new Etudiant();
        public ModEtudiant()
        {
            InitializeComponent();
            t.AfficherDataGrid("etudiant", dataGridView1);
            
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
            if (string.IsNullOrEmpty(CNE.Text))
                MessageBox.Show("saisir le CNE avant de chercher!");
            else
            {
                t.search(CNE.Text, "etudiant", "CNE", dataGridView1);
                ClearTextBoxes();
                CNE.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.Selectionner(panel3, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.AddStudent(CNE.Text, Nom.Text, Postnom.Text, Prenom.Text, Convert.ToChar(Sexe.Text), DateNaissance.Text, Adresse.Text, telephone.Text, Email.Text, int.Parse(Frais.Text), AnneeObtentionBac.Text, int.Parse(id_option.Text), int.Parse(id_parcours.Text));
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
