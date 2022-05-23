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
        public void AjouterOption(int id, string nom)
        {
            t.connexionBaseDD();
            requette = "insert into Option values ('" + id + "','" + nom + "')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un Option ayant " + id + " comme identifiant");
                else
                    MessageBox.Show("Enregistrment Reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void ModifierOption(string valeur, string nom)
        {
            t.connexionBaseDD();
            requette = "update Option set nomOption ='" + valeur + "' where nomOption= '" + nom + "'";
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
        }
        public void SupprimerOption(int id)
        {
            t.connexionBaseDD();
            requette = "delete from Option where id='" + id + "'";
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
