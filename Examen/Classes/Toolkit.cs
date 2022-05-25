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
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: parti variables :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        protected string nom_server;
        private string user_id;
        private string password;
        private string database;
        private string chaine;
        public string Nom_server  { get => nom_server ; private set => nom_server = value; }
        public string User_id { get => user_id; private set => user_id = value; }
        public string Password { get => password; private set => password = value; }
        public string Database { get => database; private set => database = value; }
        public string Chaine { get => Chaine; private set => Chaine = value; }
        protected string req;
        protected SqlConnection connexion;
        protected SqlCommand _cmd;
        public DataSet MonDataSet;
        public SqlDataAdapter _da;
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: parti base de données :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public void prendreDonneNewOrdinateur(string nomServer, string UserId, string _password, string _database)
        {
            this.Nom_server = nomServer;
            this.User_id = UserId;
            this.Password = _password;
            this.Database=_database;
            this.Chaine= "server='"+this.Nom_server+"', User Id='"+this.User_id+"', pwd='"+this.Password+"'; database='"+this.Database+"'";
        }
        
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
        /* cette methode aura comme parametre le mot que l'utilisateur va taper 
          le nom de la table viendra du combobox 
            le nom du champs c'est vous qui aller le mettre, c'est sera soit une recherche par nom ou par matricule p'etre 
            et ainsi que le nom du datagridview 
        cette methode doit etre placé dans une le textebox(bare de recherhce) avec comme evenement textchanged c'est lui qui va faire en sorte qu'a chaque fois que l'utilisateur 
        saisir un mot il va permettre de faire une recherche
        */
        public void search (string Motrechercher,string table, string champtable ,DataGridView da)
        {
            req = "select * from '"+table+"' where '"+champtable+"'='"+Motrechercher+"'";
            connexionBaseDD();
            commandeBDD(req);
            _da.SelectCommand = _cmd;
            _da.Fill(MonDataSet, "DT" + table);
            da.DataSource = MonDataSet.Tables["DT" + table];
            deconnexionBDD();
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

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: partie outils :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        
        // cette fonction va incrementer de 1  chaque id lors d'un ajout dans une table quelconque 
        //elle se prensentera comme suit ex: cne = nextcode(etduiant,cne);
        public int nextcode(string table, string key)
        {
            string requete= "select SELECT MAX('"+key+"') + 1 FROM '"+table+"'";
            int lastcode=0;
            int next_code=0;
            connexionBaseDD();
            commandeBDD(requete);
            try
            {
                SqlDataReader r = _cmd.ExecuteReader();
                while (r.Read())
                    lastcode = int.Parse(r.GetValue(0).ToString());
            if (lastcode == 0)
                next_code = 0;
            else
                next_code = lastcode + 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            return next_code;
        }
    }
}
