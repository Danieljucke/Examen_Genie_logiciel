using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Examen.Classes
{
    class Salle
    {
         protected string requette;
        protected int compte;
        Toolkit t = new Toolkit();
        //rajouter l'attribut Cours
        // Méthodes
        public void AjouterSalle(string nom, string type, int capacite)
        {
            int id=t.nextcode("Salle","id_salle");
            requette = "insert into salle values (" + id + ",'"+nom+"','" + type + "'," + capacite + ")";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un étudiant ayant " + id + " comme identifiant");
                else
                    MessageBox.Show("Enregistrment Reussi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void ModifierSalle(int id, string nom, string type, int capacite)
        {
            requette = "update salle set Nom_salle='" + nom + "', Type_salle='" + type + "', capacite=" + capacite + " where id_salle=" + id ;
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe pas de salle ayant " + id + " comme identifiant");
                else
                    MessageBox.Show("Modification Reussi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();

        }
        public void SupprimerSalle(int id)
        {
            requette = "delete from salle where id_salle=" + id ;

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
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
        public void AssignerSalleProf(string id_salle, string cin)
        {
            requette = "insert into assigner values ('" + id_salle + "', '" + cin + "')";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Assigation Echoué");
                else
                    MessageBox.Show("Assignation de la salle " + id_salle + " au professeur " + cin + " reussi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
    }
}
