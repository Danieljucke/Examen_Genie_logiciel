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
    public partial class SuppEtudiant : Form
    {
        Toolkit t = new Toolkit();
        Etudiant st = new Etudiant();
        public SuppEtudiant()
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
            t.search(textBox1.Text, "etudiant", "CNE", dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Veuillez saisir le CNE de l'étduaint que vous voulez supprimer!");
            else
            {
                st.SupprimerEtudiant(int.Parse(textBox1.Text));
                ClearTextBoxes();
                textBox1.Focus();
            }
            

        }
    }
}
