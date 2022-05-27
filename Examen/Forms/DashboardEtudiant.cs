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

        private void ProfBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = ProfBtn.Height;
            pnlNav.Top = ProfBtn.Top;
            pnlNav.Left = ProfBtn.Left;
            ProfBtn.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new ProfPanel());
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
            CourseBtn.BackColor = Color.FromArgb(24,30,54);
        }

        private void ProfBtn_Leave(object sender, EventArgs e)
        {
            ProfBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SalleBtn_Leave(object sender, EventArgs e)
        {
            SalleBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(184, 15, 10);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
