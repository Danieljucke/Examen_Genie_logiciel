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
    public partial class SuppCours : Form
    {
        Toolkit t = new Toolkit();
        Cours c = new Cours();
        public SuppCours()
        {
            InitializeComponent();
            t.AfficherDataGrid("Cours",dataGridView1);
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
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("saisir l'id du cours avant de chercher!");
            else
            {
                t.search(textBox1.Text, "Cours", "id_cours", dataGridView1);
                ClearTextBoxes();
                textBox1.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Veuillez Saisir l'iD du cours que vous voulez supprimer ");
            else
            {
                c.Supprimercours(int.Parse(textBox1.Text));
                ClearTextBoxes();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
