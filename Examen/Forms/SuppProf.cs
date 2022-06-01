﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Examen.Classes; 


namespace Examen.Forms
{
    public partial class SuppProf : Form
    {
        Toolkit t = new Toolkit();
        Professeur prof = new Professeur();
        public SuppProf()
        {
            InitializeComponent();
            t.AfficherDataGrid("Professeur", dataGridView1);
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
                MessageBox.Show("Saisir le CIN du professeur que vous voulez modifier!");
            else
            {
                t.search(textBox1.Text, "Professeur", "CIN", dataGridView1);
                ClearTextBoxes();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("saisir d'abord le CIN du prof avant de le supprimer !");
            else
            {
                prof.SupprimerProf(textBox1.Text);
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
