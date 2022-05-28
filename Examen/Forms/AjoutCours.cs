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
    public partial class AjoutCours : Form
    {
        Toolkit t = new Toolkit();
        Cours c = new Cours();
        public AjoutCours()
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_cours.Text) || string.IsNullOrEmpty(NomCours.Text) || string.IsNullOrEmpty(CIN.Text)|| string.IsNullOrEmpty(Id_Salle.Text) || string.IsNullOrEmpty(Id_Module.Text))
                MessageBox.Show("Aucun Champs ne doit rester vide");
            else
                c.Ajoutercours(NomCours.Text, int.Parse(Id_Salle.Text), int.Parse(CIN.Text), int.Parse(Id_Module.Text));
            ClearTextBoxes();
            Id_cours.Focus();
            
        }

        private void AjoutCours_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
