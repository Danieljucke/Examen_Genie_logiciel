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
    public partial class ConnexionPage : Form
    {
        Toolkit t = new Toolkit();
        Connexion con = new Connexion();
        Form _from = new MainDashboard();
        //Form _Form = new Admindashboard();
        public ConnexionPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(richTextBox2.Text))
                 MessageBox.Show("Aucun champ ne doit être vide !");
             else
             {
                 string check = con.connexion(richTextBox1.Text);
                 if (string.IsNullOrEmpty(check))
                     MessageBox.Show("ce username n'existe pas ou est incorrect!");
                 string check_admi = t.DeconvertirMotdepasse(check);
                 if (richTextBox1.Text == "Admin" && check_admi == "Admin1234")
                 {
                     new AdminDash().Show();
                     this.Hide();
                 }
                 else
                 {
                     if (check.Equals(t.ConvertirMotdepasse(richTextBox2.Text)))
                     {
                         _from.Show();
                         this.Hide();
                     }
                 }
             }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Do you really want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
                Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(richTextBox2.Text))
                MessageBox.Show("Aucun champ ne doit être vide !");
            else
            {
                string check = con.connexion(richTextBox1.Text);
                if (string.IsNullOrEmpty(check))
                    MessageBox.Show("ce username n'existe pas ou est incorrect!");
                string check_admi = t.DeconvertirMotdepasse(check);
                if (richTextBox1.Text == "Admin" && check_admi == "Admin1234")
                {
                    new AdminDash().Show();
                    this.Hide();
                }
                else
                {
                    if (check.Equals(t.ConvertirMotdepasse(richTextBox2.Text)))
                    {
                        _from.Show();
                        this.Hide();
                    }
                }
            }
        }

    }
}
