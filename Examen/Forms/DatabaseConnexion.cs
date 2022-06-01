using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Classes;
using Examen.Forms;
namespace Examen
{
    public partial class DatabaseConnexion : Form
    {
        Toolkit t = new Toolkit();
        public DatabaseConnexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Do you really want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
                Close();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            t.prendreDataNewServeur(Server.Text, Userid.Text, pwd.Text, Nom.Text);
            t.CreerAdmiAcess();
            new ConnexionPage().Show();
            this.Hide();
        }
    }
}
