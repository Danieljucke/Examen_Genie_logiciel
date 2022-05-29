using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class PanelCours : Form
    {
        public PanelCours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AjoutCours().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModCours().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SuppCours().ShowDialog();
        }
    }
}
