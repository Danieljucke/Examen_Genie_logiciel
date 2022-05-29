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
    public partial class ShowPanel : Form
    {
        Toolkit t = new Toolkit();
        public ShowPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                    MessageBox.Show("Veuillez chosir la table ainsi que le champs de recherche !");
                else
                {
                    if (comboBox1.Text=="Professeur")
                    {
                        if (comboBox2.Text == "By name")
                            t.search(textBox1.Text, comboBox1.Text, "Nom", dataGridView1);
                        if (comboBox2.Text == "By ID")
                            t.search(textBox1.Text, comboBox1.Text, "CIN", dataGridView1);
                    }
                    if (comboBox1.Text == "Etudiant")
                    {
                        if (comboBox2.Text == "By name")
                            t.search(textBox1.Text, comboBox1.Text.ToLower(), "Nom", dataGridView1);
                        if (comboBox2.Text == "By ID")
                            t.search(textBox1.Text, comboBox1.Text, "CNE", dataGridView1);
                    }
                    if (comboBox1.Text == "Cours")
                    {
                        if (comboBox2.Text == "By name")
                            t.search(textBox1.Text, comboBox1.Text, "Nom_cours", dataGridView1);
                        if (comboBox2.Text == "By ID")
                            t.search(textBox1.Text, comboBox1.Text, "id_cours", dataGridView1);
                    }
                    if (comboBox1.Text == "Salle")
                    {
                        if (comboBox2.Text == "By name")
                            t.search(textBox1.Text, comboBox1.Text, "Nom_salle", dataGridView1);
                        if (comboBox2.Text == "By ID")
                            t.search(textBox1.Text, comboBox1.Text, "id_salle", dataGridView1);
                    }
                    if (comboBox1.Text == "Module")
                    {
                        if (comboBox2.Text == "By name")
                            t.search(textBox1.Text, comboBox1.Text, "Nom_Module", dataGridView1);
                        if (comboBox2.Text == "By ID")
                            t.search(textBox1.Text, comboBox1.Text, "id_module", dataGridView1);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
                MessageBox.Show("veuillez choisir le table a afficher");
            else
            {
                t.AfficherDataGrid(comboBox1.Text, dataGridView1);
            }
        }
    }
}
