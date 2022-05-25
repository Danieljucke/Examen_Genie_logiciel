using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Examen.Classes
{
    class Professeur
    {
        protected string requette;
        protected int compte;
        Toolkit t = new Toolkit();

        // Attributs

        string Cin;
        string Nom;
        string Postnom;
        string Prenom;
        char Sex;
        string Adress;
        string Faculte;
        string mail;
        string Phone;
        string Birthdate;
        string title;
        //rajouter l'attribut Cv
        //rajouter l'attribut Cours
        public Professeur()
        {

            Cin = "00000";
            Nom = "default";
            Postnom = "default";
            Prenom = "default";
            Sex = 'f';
            Adress = "None";
            Faculte = "None";
            mail = "default";
            Phone = "None";
            Birthdate = "None";
            title = "None";
        }


        // Méthodes
        public void AjouterProf()
        {

        }
        public void ModifierProf()
        {

        }
        public void SupprimerProf()
        {

        }
        public void AssignerSalleProf(string id_salle, string cin)
        {
            t.connexionBaseDD();
            requette = "insert into assigner values ('"+id_salle+"', '"+cin+"')";
            t.commandeBDD(requette);
            try
            {
                compte = t.get_cmd().ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Assigation Echoué");
                else
                    MessageBox.Show("Assignation de la salle "+id_salle+" au professeur "+cin+" reussi!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            t.deconnexionBDD();
        }
    }
}
