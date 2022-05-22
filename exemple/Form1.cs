using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int n;
        private void button1_Click(object sender, EventArgs e)
        {
            // j'appele alors la classe que je viens de créer
            calcule_times_games a = new calcule_times_games();
            a.setprendre(0); // puis j'appelle le setter qui va modifier la variable qui est privé dans la classe
            a.incrementer(); // et reste plus qu'à incrementer dans toutes les autre formes et tout est bon
            exemple ab = new exemple();
            ab.Show();
            this.Hide();
        }
    }
}
