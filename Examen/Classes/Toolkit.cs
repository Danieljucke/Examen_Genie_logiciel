using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examen.Classes
{
    class Toolkit
    {
//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: parti variables ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private string chaine { get; set; }
        protected string req;
        protected SqlConnection connexion;
        protected SqlCommand _cmd;
        protected DataSet MonDataSet;
        protected SqlDataAdapter _da;
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: parti base de données :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public SqlCommand get_cmd()
        {
            return _cmd;
        }
        // a la place de créer des connexion dans toutes les classe il suffira de faire appel a cette methode pour créer une connexion avec la base de données 
        public void connexionBaseDD()
        {
            if (connexion.State==ConnectionState.Closed)
            {
                connexion = new SqlConnection(chaine);
                connexion.Open();
            }
            
        }
        // ferme la connexion a la base de données
        public void deconnexionBDD()
        {
            if (connexion.State == ConnectionState.Open)
                connexion.Close();
        }
        public void commandeBDD(string requete)
        {
            _cmd = new SqlCommand(requete, connexion);
        }

        public void AfficherDataGrid (string table, DataGridView da)
        {
            req = "select * from " + table;
            connexionBaseDD();
            commandeBDD(req);
            _da.SelectCommand = _cmd;
            _da.Fill(MonDataSet, "DT" + table);
            da.DataSource = MonDataSet.Tables["DT"+table];
            deconnexionBDD();
        }

        public int nombreLignes(string champ, string table, string valeur)
        {
            req = "select count (*) from "+table+"where"+champ+"="+valeur;
            connexionBaseDD();
            int compte = int.Parse(_cmd.ExecuteScalar().ToString());
            return compte;
        }
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: parti mot de passe ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        // cette methode c'est pour convertir le mot de passe que l'utilisateur va saisir lors de son inregistremment
        public string ConvertirMotdepasse(string password)
        {
            // j'ai utilisé un encodage de 256 bit 
            try
            {
                byte[] a = new byte[password.Length];
                a = System.Text.Encoding.UTF8.GetBytes(password);
                string coder = Convert.ToBase64String(a);
                return coder;
            }
            catch (Exception ex)
            {
                throw new Exception("error in base64Encoder" + ex.Message);
            }
        }
        // la méthode deconvertir va permettre de comparer le code qui vient de la base et celle que l'utilisateur va saisir 
        // cette methode va retourner un string donc faudra la stocker dans une variable string
        public string DeconvertirMotdepasse(string password)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder deconvert = encoder.GetDecoder();
            byte[] adecoder = Convert.FromBase64String(password);
            int cont = deconvert.GetCharCount(adecoder, 0, adecoder.Length);
            char[] decoder = new char[cont];
            deconvert.GetChars(adecoder, 0, adecoder.Length, decoder, 0);
            string resultat = new string(decoder);
            return resultat;
        }
        public void afficher ()
        {

        }
    }
}
