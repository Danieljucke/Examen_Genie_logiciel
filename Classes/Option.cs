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

            requette = "insert into Options values ('" + nom_option + "')";

            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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
        public void ModifierOption(int id, string nom)
        {

            requette = "update Options set Nom_option ='" + nom + "' where id_option= '" + id + "'";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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
        public void SupprimerOption(int id )
        {
            requette = "delete from Options where id_option='" + id + "'";
            DialogResult re = MessageBox.Show("Vouslez vous vraiment supprimer cette Option", "Question", MessageBoxButtons.YesNoCancel);
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
    }
}
