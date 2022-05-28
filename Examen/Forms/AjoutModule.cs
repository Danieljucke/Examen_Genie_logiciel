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
    public partial class AjoutModule : Form
    {
        Module mod = new Module();
        public AjoutModule()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nom.Text) || string.IsNullOrEmpty(Moyenne.Text) || string.IsNullOrEmpty(Id_salle.Text) || string.IsNullOrEmpty(Id_module.Text) || string.IsNullOrEmpty(Charge.Text))
                MessageBox.Show("Aucun champs ne doit rester vide");
            else 
                mod.AjouterModule(Nom.Text, int.Parse(Moyenne.Text), int.Parse(Charge.Text), int.Parse(Id_salle.Text));
            ClearTextBoxes();
            Id_module.Focus();
        }
    }
}
