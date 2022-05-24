using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen.Classes
{
    class Cours
    {
        protected string requette;
        protected int compte;
        Toolkit t = new Toolkit();
        public void Ajoutercours(string cours )
        {
            t.connexionBaseDD();
            requette = "insert into cours values ('" + cours + "')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un cours ayant " + cours + " comme nom");
                else
                    MessageBox.Show("Enregistrment Reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
    
        public void Modifiercours(string cours, int id_salle, int cin, string module)
        {
            t.connexionBaseDD();
            requette = "update cours set id_salle ='" + id_salle + "', CIN='"+cin+"', Nom_Module='"+module+"' where nomcours= '" + cours + "'";
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
        public void Supprimercours(string cours)
        {
            t.connexionBaseDD();
            requette = "delete from cours where id='" +cours+ "'";
            t.commandeBDD(requette);
            DialogResult re = MessageBox.Show("Voulez-vous vraiment supprimer ce parcous", "Confirmation", MessageBoxButtons.YesNoCancel);
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
