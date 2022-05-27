using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Examen.Classes;

namespace Examen.Forms
{
    
    public partial class ForgottenPwd : Form
    {
        Connexion con = new Connexion();
        Toolkit t = new Toolkit();
        public ForgottenPwd()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(184, 15, 10);
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(41, 56, 73);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
                MessageBox.Show("Aucun champ ne doit être vide !");
            else
                    con.motDePasseOublie(richTextBox1.Text.ToString(), t.ConvertirMotdepasse(textBox1.Text), t.ConvertirMotdepasse(textBox2.Text));
        }

        private void SaveBtn_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                MessageBox.Show("Aucun champ ne doit être vide !");
            else
            {
                if (e.KeyChar == (char)13)
                    con.motDePasseOublie(richTextBox1.Text, t.ConvertirMotdepasse(textBox1.Text), t.ConvertirMotdepasse(textBox2.Text));
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
