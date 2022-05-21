using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examen_Génie_Logicielle.Class
{
    class Connexion
    {
        string linkToBdd = Toolkit.test;

        public void Registre(string mail, string nom, string mot_passe)
        {
            SqlConnection link = new SqlConnection(linkToBdd);
            SqlCommand _commande = new SqlCommand();
            _commande.Connection = link;
            _commande.CommandText = "insert into Personne values ('" + mail + "','" + nom + "' , '" + mot_passe + "')";
            try
            {
                link.Open();
                int verfi = _commande.ExecuteNonQuery();
                if (verfi == 1)
                    link.Close();
                else
                    MessageBox.Show("il existe déjà un compte avec ce nom");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public string login(string nom)
        {
            SqlConnection login = new SqlConnection(linkToBdd);
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = login;
            _cmd.CommandText = "select pass_word from Personne where Username='" + nom + "'";
            login.Open();
            SqlDataReader verification = _cmd.ExecuteReader();
            while (verification.Read())
            {
                recuperer = verification.GetValue(0).ToString();
            }
            verification.Close();
            login.Close();
            return recuperer;
        }
        public string recuperer;
        public int forgetPassword(string compte)
        {
            int checking = 0;
            SqlConnection forget = new SqlConnection(linkToBdd);
            SqlCommand _voir = new SqlCommand();
            _voir.Connection = forget;
            _voir.CommandText = "select Username from Personne where Email= '" + compte + "'";
            try
            {

                forget.Open();
                SqlDataReader check = _voir.ExecuteReader();
                while (check.Read())
                    checking = +1;
                check.Close();
                forget.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            return checking;
        }
        public void changingPassword(string mail, string newpassword)
        {
            SqlConnection connection = new SqlConnection(linkToBdd);
            SqlCommand changer = new SqlCommand();
            changer.Connection = connection;
            changer.CommandText = "update Personne set pass_word ='" + newpassword + "' where Email ='" + mail + "' ";
            try
            {
                connection.Open();
                int voir = changer.ExecuteNonQuery();
                if (voir >= 1)
                    MessageBox.Show("Le mot de passe à été changer avec succès !");
                else
                    MessageBox.Show("ne pas prendre l'ancien Mot de passe !");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
    }
}
