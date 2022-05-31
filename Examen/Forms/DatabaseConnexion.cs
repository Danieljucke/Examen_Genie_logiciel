using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class DatabaseConnexion : Form
    {
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
    }
}
