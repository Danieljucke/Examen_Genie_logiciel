using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class PanelSalle : Form
    {
        public PanelSalle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AjoutSalle().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModSalle().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SuppSalle().ShowDialog();
        }
    }
}
