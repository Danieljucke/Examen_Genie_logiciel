using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value==100)
            {
                timer1.Enabled = false;
                new ConnexionPage().Show();
                this.Hide();
            }
        }
    }
}
