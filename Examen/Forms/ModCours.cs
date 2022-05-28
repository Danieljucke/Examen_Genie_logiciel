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
            if (string.IsNullOrEmpty(Id_cours.Text))
                MessageBox.Show("saisir l'id du cours avant de chercher!");
            else
            {
                t.search(Id_cours.Text, "Cours", "id_cours", dataGridView1);
                ClearTextBoxes();
                Id_cours.Focus();
            }
        }
    }
}
