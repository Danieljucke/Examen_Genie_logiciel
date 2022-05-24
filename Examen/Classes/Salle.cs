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

        // Attributs
        int id;
        string Nom;
        string Type;
        int Capacite;
        //rajouter l'attribut Cours


        // Méthodes
        public void AjouterSalle(int id, string nom)
        {
            t.connexionBaseDD();
            requette = "insert into salle values ('" + id + "','" + nom + "')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
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
        public void ModifierSalle()
        {

        }
        public void SupprimerSalle(int id)
        {
            t.connexionBaseDD();
            requette = "delete from salle where id='" + id + "'";
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
