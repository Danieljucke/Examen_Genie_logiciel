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
        public void AjouterModule(int id, string nom,int moyen,int duree )
        {
            t.connexionBaseDD();
            requette = "insert into Module values ('" + id + "','" + nom + "','" + moyen + "','" + duree + "')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un Module ayant " + id + " comme identifiant");
                else
                    MessageBox.Show("Enregistrment Reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void ModifierModule(string valeur, string nom)
        {
            t.connexionBaseDD();
            requette = "update Module set nomModule ='" + valeur + "' where nomModule= '" + nom + "'";
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
        public void SupprimerModule(int id)
        {
            t.connexionBaseDD();
            requette = "delete from Module where id='" + id + "'";
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
        }
    }
}
