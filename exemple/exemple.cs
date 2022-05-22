using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exemple
{
    public partial class exemple : Form
    {
        public exemple()
        {
            InitializeComponent();
        }

        private void exemple_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcule_times_games a = new calcule_times_games();
            a.setprendre(1);
            a.incrementer();
            exemple2 load = new exemple2();
            load.Show(); this.Hide();
        }
    }
}
