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
    }
}
