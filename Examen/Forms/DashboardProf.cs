using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class DashboardProf : Form
    {
        public DashboardProf()
        {
            InitializeComponent();
        }

        private void btnCours_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCours.Height;
            pnlNav.Top = btnCours.Top;
            pnlNav.Left = btnCours.Left;
            btnCours.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSalle_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSalle.Height;
            pnlNav.Top = btnSalle.Top;
            pnlNav.Left = btnSalle.Left;
            btnSalle.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEtud_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEtud.Height;
            pnlNav.Top = btnEtud.Top;
            pnlNav.Left = btnEtud.Left;
            btnEtud.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCours_Leave(object sender, EventArgs e)
        {
            btnCours.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEtud_Leave(object sender, EventArgs e)
        {
            btnEtud.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSalle_Leave(object sender, EventArgs e)
        {
            btnSalle.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(41, 56, 73);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(184, 15, 10);
        }
    }
}
