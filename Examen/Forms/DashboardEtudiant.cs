
﻿using System;
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

        private Form activePanel = null;
        private void openPanel(Form panelform)
        {
            if (activePanel != null)
                activePanel.Close();
            activePanel = panelform;
            panelform.TopLevel = false;
            panelform.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(panelform);
            ContainerPanel.Tag = panelform;
            panelform.Show();
        }

        private void btnCours_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCours.Height;
            pnlNav.Top = btnCours.Top;
            pnlNav.Left = btnCours.Left;
            btnCours.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new CoursPanel());
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProf.Height;
            pnlNav.Top = btnProf.Top;
            pnlNav.Left = btnProf.Left;
            btnProf.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new ProfPanel());
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
            openPanel(new SallePanel());
        }

        private void btnProf_Leave(object sender, EventArgs e)
        {
            btnProf.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSalle_Leave(object sender, EventArgs e)
        {
            btnSalle.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(184, 15, 10);
        }

        private void CloseBtn_Leave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(41, 56, 73);
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}

