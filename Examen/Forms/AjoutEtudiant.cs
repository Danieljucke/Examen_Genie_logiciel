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
    public partial class AjoutEtudiant : Form
    {
        Etudiant st = new Etudiant();
        Toolkit t = new Toolkit();
        public AjoutEtudiant()
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
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(CNE.Text) || string.IsNullOrEmpty(Nom.Text))
                MessageBox.Show("Aucun Champs ne doit etre vide!");
            else
            {
                st.AddStudent(CNE.Text, Nom.Text, Postno.Text, Prenom.Text, char.Parse(comboBox1.Text), Birthday.Text, Adresse.Text, Tel.Text, Email.Text, 0, Bac.Text, int.Parse(Id_Option.Text), int.Parse(Id_parcours.Text));
                ClearTextBoxes();
                CNE.Focus();
            }
        }
    }
}
