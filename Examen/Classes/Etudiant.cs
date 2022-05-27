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
            dateNaissance = dateNaissance;
            Parcours = parcours;
            AnneeBac = AnneeBac;
            
            requette = "insert into etudiant values ('" + cne + "','" + nom + "','" + postnom + "','" + prenom + "','" + sexe + "','" + dateNaissance + "','" + Adresse + "','" + telephone + "','" + Email + "','" + Option + "','" + Parcours +  "','" + "','" + AnneeBac   "')";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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
            requette = "update etudiant set nom ='" + valeur + "' where nom= '" + nom + "'";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
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
            requette = "delete from etudiant where id='" + cne + "'";
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
