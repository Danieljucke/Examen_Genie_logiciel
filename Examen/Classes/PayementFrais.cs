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
        public void payer(string type, int montatapayer,int cne)
        {
            int nbfacture=t.nextcode("PayementFrais", "numero_facture"); 
            requete = "insert into PayementFrais values ('"+nbfacture+"','"+type+"','"+montatapayer+"', '"+cne+"')";
            t.connexionBaseDD();
            t.commandeBDD(requete);
            int compte = t.get_cmd().ExecuteNonQuery();
            if (compte < 0)
                MessageBox.Show("Payement Non Effectué");
            else
                MessageBox.Show("Payement Effectué");
        }
        public void calculMontant (string cne )
        {
            int solde = 0;
            requete = "select frais from etudiant where CNE='"+cne+"'";
            t.connexionBaseDD();
            t.commandeBDD(requete);
            try
            {
                SqlDataReader r = t.get_cmd().ExecuteReader();
                while (r.Read())
                    solde = int.Parse(r.GetValue(0).ToString());
                if (solde == 0)
                    MessageBox.Show("Vous devez payer 2000$ pour solder les frais");
                else
                {
                    int aPayer = 2000 - solde;
                    MessageBox.Show("il vous reste à payer " + aPayer + " pour solder les frais!");
                } 
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

    }
}
