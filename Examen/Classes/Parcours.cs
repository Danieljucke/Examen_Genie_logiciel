using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen.Classes
{
    class Parcours
    {
        protected string requette;
        protected int compte; 
        Toolkit t = new Toolkit();
        public void AjouterParcours(int id, string nom)
        {
            t.connexionBaseDD();
            requette = "insert into Parcours values ('"+id+"','"+nom+"')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un parcours ayant "+id+" comme identifiant");
                else
                    MessageBox.Show("Enregistrment Reussi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void ModifierParcours (string valeur, string nom)
        {
            t.connexionBaseDD();
            requette = "update Parcours set nomParcours ='"+valeur+"' where nomParcours= '"+nom+"'";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                {
                   DialogResult re= MessageBox.Show("Modification échoué voulez-vous reprendre", "Confirmation", MessageBoxButtons.YesNoCancel);
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
        public void SupprimerParcours(int id)
        {
            t.connexionBaseDD();
            requette = "delete from Parcours where id='"+id+"'";
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
                catch( Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
