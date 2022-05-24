using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Classes
{
    class Etudiant

    {
        protected string requette;
        protected int compte;
        Toolkit t = new Toolkit();


        string Cne;
        string Nom;
        string Postnom;
        string Prenom;
        char Sex;
        string Adress;
        string Faculte;
        string Option;
        string Phone;
        string Birthdate;
        string Level;
        public Etudiant()
        {

            Cne = "00000";
            Nom = "default";
            Postnom = "default";
            Prenom = "default";
            Sex = 'f';
            Adress = "None";
            Faculte = "None";
            Option = "default";
            Phone = "None";
            Birthdate = "None";
            Level = "bac1";
        }

        public void AddStudent(string cne, string nom, string postnom, string prenom, char sex, string adress, string faculte, string option, string phone, string birthdate, string level)
        {

            Cne = cne;
            Nom = nom;
            Postnom = postnom;
            Prenom = prenom;
            Sex = sex;
            Adress = adress;
            Faculte = faculte;
            Option = option;
            Phone = phone;
            Birthdate = birthdate;
            Level = level;


            t.connexionBaseDD();
            requette = "insert into etudiant values ('" + cne + "','" + nom + "')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe déjà un étudiant ayant " + cne + " comme identifiant");
                else
                    MessageBox.Show("Enregistrment Reussi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            t.deconnexionBDD();
        }
        public void ModifierEtudiant(string valeur, string nom)
        {
            t.connexionBaseDD();
            requette = "update etudiant set nom ='" + valeur + "' where nom= '" + nom + "'";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                {
                    DialogResult re = MessageBox.Show("Modification échoué voulez-vous reprendre?", "Confirmation", MessageBoxButtons.YesNoCancel);
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

        public void SupprimerEtudiant(int cne)
        {
            t.connexionBaseDD();
            requette = "delete from etudiant where id='" + cne + "'";
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
