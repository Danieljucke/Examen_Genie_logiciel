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
        public void AjouterModule(string nom, int moyen, int duree, int id_classe)
        {
            int id = t.nextcode("Module", "id_salle");
            requette = "insert into Module values ( " + id + ",'" + nom + "'," + moyen + "," + duree + "," + id_classe + ")";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un Module ayant " + nom + " comme nom");
                else
                    MessageBox.Show("Enregistrment Reussi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void ModifierModule(int id, string nom, int moyen, int dure, int id_classe)
        {
            requette = "update Module set Nom_Module= '" + nom + "' Moyenne_generale=" + moyen + ", charge_horaire=" + dure + ", id_classe=" + id_classe + "  where id_module " + id;
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
        public void SupprimerModule(int id)
        {
            requette = "delete from Module where id_module=" + id;
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
            t.deconnexionBDD();
        }
    }
}
