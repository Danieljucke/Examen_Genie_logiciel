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
    public partial class AjoutSalle : Form
    {
        Salle s = new Salle();
        public AjoutSalle()
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_salle.Text) || string.IsNullOrEmpty(Nom.Text) || string.IsNullOrEmpty(capacite.Text) || string.IsNullOrEmpty(comboBox1.Text))
                MessageBox.Show("aucun champ ne doit rester vide !");
            else
                s.AjouterSalle(Nom.Text, comboBox1.Text,int.Parse(capacite.Text));
            ClearTextBoxes();
            id_salle.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
