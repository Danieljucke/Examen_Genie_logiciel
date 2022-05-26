using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class DashboardEtudiant : Form
    {
        public DashboardEtudiant()
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

        private void btnProf_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProf.Height;
            pnlNav.Top = btnProf.Top;
            pnlNav.Left = btnProf.Left;
            btnProf.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCours_Leave(object sender, EventArgs e)
        {
            btnCours.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSalle_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSalle.Height;
            pnlNav.Top = btnSalle.Top;
            pnlNav.Left = btnSalle.Left;
            btnSalle.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnProf_Leave(object sender, EventArgs e)
        {
            btnProf.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSalle_Leave(object sender, EventArgs e)
        {
            btnSalle.BackColor = Color.FromArgb(24, 30, 54);
        }

    }
}
