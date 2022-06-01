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
    public partial class SignInPage : Form
    {
        Connexion con = new Connexion();
        Toolkit t = new Toolkit();
        public SignInPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Do you really want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Mail.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(CPassword.Text))
                MessageBox.Show("Aucun champs ne doit etre vide !");
            else
            {
                con.inscription(Username.Text, t.ConvertirMotdepasse(Password.Text), Mail.Text, t.ConvertirMotdepasse(CPassword.Text));
                new ConnexionPage().Show();
                this.Hide();
            }
        }
    }
}
