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
        public void AjouterParcours(string nom)
        {
            int id = t.nextcode("Parcours", "id_parcours");
            requette = "insert into Parcours values ('"+id+"','"+nom+"')";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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
        public void ModifierParcours (int id, string nom)
        {
            requette = "update Parcours set nom_parcours ='"+nom+"' where id_parcours= '"+id+"'";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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
            requette = "delete from Parcours where id_parcours='"+id+"'";
            DialogResult re = MessageBox.Show("Vouslez vous vraiment supprimer ce parcous", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (re == DialogResult.Yes)
            {
                try
                {
                    compte = t.commandeBDD(requette).ExecuteNonQuery();
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
