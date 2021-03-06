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
    public partial class ModSalle : Form
    {
        Salle s = new Salle();
        Toolkit t = new Toolkit();
        public ModSalle()
        {
            InitializeComponent();
            t.AfficherDataGrid("Salle", dataGridView1);
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
            if (string.IsNullOrEmpty(id_salle.Text))
                MessageBox.Show("saisir l'id de la salle avant de chercher!");
            else
            {
                t.search(id_salle.Text, "Salle", "id_salle", dataGridView1);
                ClearTextBoxes();
                id_salle.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.Selectionner(panel3, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.ModifierSalle(int.Parse(id_salle.Text), Nom_Salle.Text, Type_Salle.Text, int.Parse(Capacite.Text));
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
