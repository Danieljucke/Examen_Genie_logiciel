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
    public partial class ModCours : Form
    {
        Toolkit t = new Toolkit();
        Cours c = new Cours();
        public ModCours()
        {
            InitializeComponent();
            t.AfficherDataGrid("Cours", dataGridView1);
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
            if (string.IsNullOrEmpty(id_cours.Text))
                MessageBox.Show("saisir l'id du cours avant de chercher!");
            else
            {
                t.search(id_cours.Text, "Cours", "id_cours", dataGridView1);
                ClearTextBoxes();
                id_cours.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.Selectionner(panel3, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Modifiercours(int.Parse(id_cours.Text), Nom_Cours.Text, int.Parse(id_salle.Text),int.Parse(CIN.Text), int.Parse(id_module.Text));
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
