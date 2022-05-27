using Examen.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class SallePanel : Form
    {
        Toolkit t = new Toolkit();
        public SallePanel()
        {
            InitializeComponent();
            t.AfficherDataGrid("Salle",SalleView);
        }
    }
}
