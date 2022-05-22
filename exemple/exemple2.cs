using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exemple
{
    public partial class exemple2 : Form
    {
        public exemple2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcule_times_games a = new calcule_times_games();
            a.setprendre(2);
            int b = a.incrementer();
            MessageBox.Show("" + b + " sur 5" );
            this.Close();
        }
    }
}
