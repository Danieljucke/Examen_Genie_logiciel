using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Examen.Classes
{
    class Connexion
    {
        protected string req;
        Toolkit u = new Toolkit();
        public string connexion (string utilisateur)
        {
            string recup="";
            req = "select mot_de_passe from table connexion where utilisateur='" + utilisateur + "'";
            u.connexionBaseDD();
            u.commandeBDD(req);
            try
            {
                SqlDataReader retourner = u._cmd.ExecuteReader();
                while (retourner.Read())
                {
                    recup = retourner.GetString(0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
           
            return recup; 
        }
        public void inscription(string username, string motDePasse, string confirmMotDePasse)
        {
            req= "insert into _ values ('" + username + "','" + motDePasse + "')";
            u.connexionBaseDD();
            u.commandeBDD(req);
            try
            {
                int chekRespondBDD = u._cmd.ExecuteNonQuery();
                if (chekRespondBDD > 1)
                    MessageBox.Show("Inscription Reussi");
                else
                    MessageBox.Show("Il existe déjà un utilsateur à ce nom ");
            }
            catch(Exception ex )
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
