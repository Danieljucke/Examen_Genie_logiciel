using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class PanelProf : Form
    {
        public PanelProf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AjoutProf().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModProf().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SuppProf().ShowDialog();
        }
    }
}
