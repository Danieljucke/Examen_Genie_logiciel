using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen.Classes
{
    class Module
    {
        protected string requette;
        protected int compte;
        Toolkit t = new Toolkit();
        public void AjouterModule(string nom,int moyen,int duree, string classe)
        {
            t.connexionBaseDD();
            requette = "insert into Module values ('" + nom + "','" + moyen + "','" + duree + "', '"+classe+"')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un Module ayant " + nom + " comme nom");
                else
                    MessageBox.Show("Enregistrment Reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void ModifierModule(string nom, string moyen, string dure, string classe)
        {
            t.connexionBaseDD();
            requette = "update Module set Moyenne_general='"+moyen+"', chargec_horaire='"+dure+"', nom_classe='"+classe+"'  where nomModule= '" + nom + "'";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                {
                    DialogResult re = MessageBox.Show("Modification échoué voulez-vous reprendre", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (re == DialogResult.Yes)
                        MessageBox.Show("");
                }
                else
                    MessageBox.Show("Modification Reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void SupprimerModule(string nom)
        {
            t.connexionBaseDD();
            requette = "delete from Module where Nom_module='" + nom + "'";
            t.commandeBDD(requette);
            DialogResult re = MessageBox.Show("Vouslez vous vraiment supprimer ce parcous", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (re == DialogResult.Yes)
            {
                try
                {
                    compte = t.get_cmd().ExecuteNonQuery();
                    if (compte > 0)
                        MessageBox.Show("Suppression Effectuée");
                    else
                        MessageBox.Show("Echec de suppression");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            t.deconnexionBDD();
        }
    }
}
