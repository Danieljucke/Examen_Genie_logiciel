using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class AdminDash : Form
    {
        public AdminDash()
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

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            pnlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new PanelEtudiant());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button2.Height;
            pnlNav.Top = button2.Top;
            pnlNav.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new PanelCours());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button3.Height;
            pnlNav.Top = button3.Top;
            pnlNav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new PanelProf());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button4.Height;
            pnlNav.Top = button4.Top;
            pnlNav.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new PanelModule());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button5.Height;
            pnlNav.Top = button5.Top;
            pnlNav.Left = button5.Left;
            button5.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new PanelSalle());
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Do you really want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
                Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button6.Height;
            pnlNav.Top = button6.Top;
            pnlNav.Left = button6.Left;
            button6.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new ShowPanel());
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button10.Height;
            pnlNav.Top = button10.Top;
            pnlNav.Left = button10.Left;
            button10.BackColor = Color.FromArgb(46, 51, 73);
            openPanel(new Payement());
        }
    }
}
