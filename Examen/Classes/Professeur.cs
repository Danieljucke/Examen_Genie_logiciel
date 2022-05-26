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
        public void AjouterProf(string cin, string nom, string postnom, string prenom, char sex, string birthday, string adresse, string telephone, string email,string titre )
        {
            requette = "insert into Professeur values ()";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("l'enregistrement n'a pas abouti car il existe un professeur ayant " + cin + " comme CIN");
                else
                    MessageBox.Show("Enregistrement Reussi!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void ModifierProf(string cin, string nom, string postnom, string prenom, char sex, string birthday, string adresse, string telephone, string email, string titre)
        {
            requette = "Update Professeur set Nom='"+nom+"', Postnom='"+postnom+"', Prenom= '"+prenom+"', Sexe='"+sex+"', DateNaissance='"+birthday+"', Adresse='"+adresse+"', telephone ='"+telephone+"', email='"+email+"', titre='"+titre+"' where CIN='"+cin+"'";
            try
            {
                compte = t.commandeBDD(requette).ExecuteNonQuery();
                if (compte < 0)
                    MessageBox.Show("Il existe pas de Professeur ayant  " + cin + " comme CIN");
                else
                    MessageBox.Show("Modification Reussi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void SupprimerProf(string cin)
        {
            requette = "delete from Professeur where CIN='"+cin+"'";
            DialogResult r= MessageBox.Show("voulez vous supprimer cet professeur","CONFIRMATION",MessageBoxButtons.YesNo);
            if (r==DialogResult.Yes)
            {
                try
                {
                    compte = t.commandeBDD(requette).ExecuteNonQuery();
                    if (compte < 0)
                        MessageBox.Show("Il n'y pas de professeur ayant " + cin + " comme CIN ");
                    else
                        MessageBox.Show("suppression Reussi !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
        
    }
}
