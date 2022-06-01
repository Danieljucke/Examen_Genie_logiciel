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
    public partial class ModModule : Form
    {
        Toolkit t = new Toolkit();
        Module mod = new Module();
        public ModModule()
        {
            InitializeComponent();
            t.AfficherDataGrid("Module",dataGridView1);
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
            if (string.IsNullOrEmpty(id_module.Text))
                MessageBox.Show("saisir l'id du cours avant de chercher!");
            else
            {
                t.search(id_module.Text, "Module", "id_module", dataGridView1);
                ClearTextBoxes();
                id_module.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.Selectionner(panel1, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mod.AjouterModule(Nom_Module.Text, int.Parse(Moyenne_generale.Text), int.Parse(charge_horaire.Text), int.Parse(id_classe.Text));
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
