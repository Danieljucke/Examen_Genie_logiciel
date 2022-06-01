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
    public partial class SuppSalle : Form
    {
        Toolkit t = new Toolkit();
        Salle s = new Salle();
        public SuppSalle()
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
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Saisir d'abod l'id de la salle avant de chercher!");
            else
            {
                t.search(textBox1.Text, "Salle", "id_salle", dataGridView1);
                ClearTextBoxes();
                textBox1.Focus();
            } 
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("saisir l'id de salle avant de supprimer !");
            else
            {
                s.SupprimerSalle(int.Parse(textBox1.Text));
                ClearTextBoxes();
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
