using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class PanelEtudiant : Form
    {
        public PanelEtudiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AjoutEtudiant().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModEtudiant().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SuppEtudiant().ShowDialog();
        }
    }
}
