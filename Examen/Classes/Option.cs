using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen.Classes
{
    class Option
    {
        protected string requette;
        protected int compte;
        Toolkit t = new Toolkit();
        public void AjouterOption(string nom_option)
        {
            t.connexionBaseDD();
            requette = "insert into Options values ('" + nom_option + "')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un Option ayant " + nom_option + " comme nom");
                else
                    MessageBox.Show("Enregistrment Reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        // etant donner que nous avons qu'un seul champs dans options la methode modifier n'a plus lieu d'etre
        /*public void ModifierOption(string valeur, string nom)
        {
            t.connexionBaseDD();
            requette = "update Options set nom_option ='" + valeur + "' where nomOption= '" + nom + "'";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                {
                    DialogResult re = MessageBox.Show("Modification échoué! voulez-vous reprendre?", "Question", MessageBoxButtons.YesNoCancel);
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
        }*/
        public void SupprimerOption(string nom_option)
        {
            t.connexionBaseDD();
            requette = "delete from Options where Nom_option='" + nom_option + "'";
            t.commandeBDD(requette);
            DialogResult re = MessageBox.Show("Vouslez vous vraiment supprimer cette Option", "Question", MessageBoxButtons.YesNoCancel);
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
