using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
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
            MainPanel.Controls.Add(panelform);
            MainPanel.Tag = panelform;
            panelform.Show();
        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = CourseBtn.Height;
            pnlNav.Top = CourseBtn.Top;
            pnlNav.Left = CourseBtn.Left;
            CourseBtn.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new CoursPanel());
        }

        private void EtudBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = EtudBtn.Height;
            pnlNav.Top = EtudBtn.Top;
            pnlNav.Left = EtudBtn.Left;
            EtudBtn.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new EtudiantPanel());
        }

        private void SalleBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = SalleBtn.Height;
            pnlNav.Top = SalleBtn.Top;
            pnlNav.Left = SalleBtn.Left;
            SalleBtn.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new SallePanel());
        }

        private void CourseBtn_Leave(object sender, EventArgs e)
        {
            CourseBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void EtudBtn_Leave(object sender, EventArgs e)
        {
            EtudBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SalleBtn_Leave(object sender, EventArgs e)
        {
            SalleBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Do you really want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Do you really want to log out ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                new ConnexionPage().Show();
                Hide();
            }
            
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
