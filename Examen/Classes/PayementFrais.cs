using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Examen.Classes
{
    class PayementFrais
    {
        protected string requete;
        Toolkit t = new Toolkit();
        public void payer(string type, int montatapayer)
        {
            requete = "insert into PayementFrais values ('"+type+"','"+montatapayer+"')";
            t.connexionBaseDD();
            t.commandeBDD(requete);
            int compte = t.get_cmd().ExecuteNonQuery();
            if (compte < 0)
                MessageBox.Show("Payement Non Effectué");
            else
                MessageBox.Show("Payement Effectué");
        }

    }
}
