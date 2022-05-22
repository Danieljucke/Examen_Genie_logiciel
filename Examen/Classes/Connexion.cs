using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Examen.Classes
{
    class Connexion
    {
        public string connexion (string utilisateur)
        {
            string recup="";
            string req = "select mot_de_passe from table connexion where utilisateur='" + utilisateur + "'";
            Toolkit u = new Toolkit();
            u.connexionBaseDD();
            u.commandeBDD(req);
            SqlDataReader retourner = u._cmd.ExecuteReader(); 
            while (retourner.Read())
            {
                recup = retourner.GetString(0);
            }
            return recup; 
        }
        public void inscription()
        {
            
        }
    }
}
