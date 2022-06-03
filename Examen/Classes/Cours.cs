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
        public void Ajoutercours(string cours, int id_salle, int cin, int id_module)
        {
            int id = t.nextcode("Cours", "id_cours");
            requette = "insert into cours values (" + id + ",'" + cours + "'," + id_salle + "," + cin + "," + id_module + ")";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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

        public void Modifiercours(int id, string cours, int id_salle, int cin, int id_module)
        {
            requette = "update cours set  Nom_cours= '" + cours + "' id_salle =" + id_salle + ", CIN=" + cin + ", Nom_Module=" + id_module + " where id_cours=" + id;

            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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
        public void Supprimercours(int id)
        {
            requette = "delete from cours where id_cours=" + id ;
            DialogResult re = MessageBox.Show("Voulez-vous vraiment supprimer ce parcous", "Confirmation", MessageBoxButtons.YesNoCancel);
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
