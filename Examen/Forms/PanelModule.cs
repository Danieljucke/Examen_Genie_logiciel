using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class PanelModule : Form
    {
        public PanelModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AjoutModule().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModModule().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SuppModule().ShowDialog();
        }
    }
}
