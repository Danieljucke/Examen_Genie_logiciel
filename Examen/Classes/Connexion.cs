using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Examen.Classes
{
    class Connexion
    {
        // je crée une variable requette qui aura une porté protected et aisni eviter de tout le temps créer la même variable dans chaque méthode 
        // elle changera de valeur en fonction de chaque méthode.
        protected string req;
        //j'initialise un objet de la classe toolkit pour eviter de le refaire a chaque fois
        Toolkit u = new Toolkit();
        // pour la méthode connexion suffira de passer en parametre le username et il va récuperer le mot de passe et dans le bouton il suffira de faire la comparaison
        // comme il retourne une valeur string faudra la mettre dans une variable string pour effectuer la comparaison ente celui que l'utilisateur aura sausi et celui de la bDD
        // pour faire la comparason vous pourrez soit convertir soit deconvertir 
        public string connexion (string utilisateur)
        {
            string recup="";
            req = "select mot_de_passe from table connexion where utilisateur='" + utilisateur + "'";
            u.connexionBaseDD();
            u.commandeBDD(req);
            try
            {
                SqlDataReader retourner = u.get_cmd().ExecuteReader();
                while (retourner.Read())
                {
                    recup = retourner.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            u.deconnexionBDD();
            return recup; 
        }
        // pour inscription il suffira de mettre en parametre le nom et le mot de passe et il va l'enregistrer dans la basse de données
        // ps il faudra convertir le mot de passe avant de le passer en paramettre dans la méthode inscription
        // la méthode convertir mot de passe se trouve dans la classe toolkit
        public void inscription(string username, string motDePasse, string email, string Confirmpassword)
        {
            if (!motDePasse.Equals(Confirmpassword))//compare si le mot de passe correspont au champs confirmer mot de passe
                MessageBox.Show("le Mot de passe n'est pas le même");
            else
            {
                req = "insert into connexion ('" + username + "','" + motDePasse + "','" + email + "')";
                u.connexionBaseDD();
                u.commandeBDD(req);
                try
                {
                    int chekRespondBDD = u.get_cmd().ExecuteNonQuery();
                    if (chekRespondBDD == 1)
                        MessageBox.Show("Inscription Reussi");
                    else
                        MessageBox.Show("Il existe déjà un utilsateur à ce nom ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                u.deconnexionBDD();
            }
        }
        // motde passe oublié va se charger de changer le mot de passe et de checker si le username est bien present dans la base de données avant d'effectuer le changement
        public void motDePasseOublie(string Utilisateur,string motDePasse)
        {
            string prendreUtilisateur="";
            req = "";
            u.connexionBaseDD();
            u.commandeBDD(req);
            
            try
            {
                SqlDataReader voirUsername = u.get_cmd().ExecuteReader();
                while (voirUsername.Read())
                    prendreUtilisateur = voirUsername.GetString(0);
                if (prendreUtilisateur == Utilisateur)
                {
                    req = "update connexion set mot_de_passe ='"+motDePasse+"' where username='"+Utilisateur+"'";
                    u.commandeBDD(req);
                    int checkoperation = u.nombreLignes(Utilisateur, "connexion",motDePasse);
                    if (checkoperation < 0)
                        MessageBox.Show("le mot de passe a été chnagé avec succès");
                    else
                        MessageBox.Show("l'opération n'a pas abouti");
                }
                else
                {
                    MessageBox.Show("ce compte n'existe pas");
                }
                u.deconnexionBDD();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
