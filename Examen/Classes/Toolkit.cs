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
        private string chaine= ;
        public string Nom_server { get => nom_server; private set => nom_server = value; }
        public string User_id { get => user_id; private set => user_id = value; }
        public string Password { get => password; private set => password = value; }
        public string Database { get => database; private set => database = value; }
        public string Chaine { get => chaine; private set => chaine = value; }

        protected string req;
        protected SqlConnection connexion;
        protected SqlCommand _cmd;
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: parti base de données :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public void prendreDataNewServeur(string nomServer, string UserId, string _password, string _database)
        {
            int prendre_index;
            char symbol = Convert.ToChar(92);
            prendre_index = nomServer.IndexOf(symbol);
            string newname = nomServer.Insert(prendre_index, symbol.ToString());// varajouter '/' dans la chaine pour eviter de générer une erreur
            this.Nom_server = newname;
            this.User_id = UserId;
            this.Password = _password;
            this.Database = _database;
            this.Chaine = "server='" + this.Nom_server + "', User Id='" + this.User_id + "', pwd='" + this.Password + "'; database='" + this.Database + "'";
        }

        private void attribuer_chaine()
        {
            connexion = new SqlConnection(chaine);
        }
        // a la place de créer des connexion dans toutes les classe il suffira de faire appel a cette methode pour créer une connexion avec la base de données 
       
        public SqlConnection connexionBaseDD()
        {
            attribuer_chaine();
            if (connexion.State == ConnectionState.Closed)
                connexion.Open();
            return connexion;
        }
        // ferme la connexion a la base de données
        public SqlConnection deconnexionBDD()
        {
            attribuer_chaine();
            if (connexion.State == ConnectionState.Open)
                connexion.Close();
            return connexion;
        }
        public SqlCommand commandeBDD(string requette)
        {
            _cmd = new SqlCommand(requette, connexionBaseDD());
            return _cmd;
        }


        public void AfficherDataGrid(string table, DataGridView da)
        {
            req = "select * from " + table;
            SqlDataAdapter adapt;
            DataTable dt;
            //connexionBaseDD();
            adapt = new SqlDataAdapter(req, connexionBaseDD());
            dt = new DataTable();
            adapt.Fill(dt);
            da.DataSource = dt;
            deconnexionBDD();
        }
        public void Selectionner (Control p, DataGridView d)
        {
            foreach (Control c in p.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = d.SelectedRows[0].Cells[c.Name].Value.ToString();
                }

            }
        }
        public int nombreLignes(string champ, string table, string valeur)
        {
            req = "select count (*) from "+table+"where"+champ+"="+valeur;
            connexionBaseDD();
            int compte = int.Parse(commandeBDD(req).ExecuteScalar().ToString());
            return compte;
        }
        /* cette methode aura comme parametre le mot que l'utilisateur va taper 
          le nom de la table viendra du combobox 
            le nom du champs c'est vous qui aller le mettre, c'est sera soit une recherche par nom ou par matricule p'etre 
            et ainsi que le nom du datagridview 
        cette methode doit etre placé dans une le textebox(bare de recherhce) avec comme evenement textchanged c'est lui qui va faire en sorte qu'a chaque fois que l'utilisateur 
        saisir un mot il va permettre de faire une recherche
        */
        public void search(string Motrechercher, string table, string champtable, DataGridView da)
        {
            req = "select * from " + table + " where  " + champtable + " like '%" + Motrechercher + "%'";
            SqlDataAdapter adapt;
            DataTable dt;
            connexionBaseDD();
            adapt = new SqlDataAdapter(req, connexionBaseDD());
            dt = new DataTable();
            adapt.Fill(dt);
            da.DataSource = dt;
            deconnexionBDD();
        }
        // cette fonction va creer le mot de passe par defaut de l'adminstrateur dès la première ouverture de l'appliction et va lui retourner le password et le username pour qu'il se connecte 
        public void CreerAdmiAcess ()
        {
            string cont = ConvertirMotdepasse("Admin1234");
            req = "insert into Connexion values('Admin','"+ cont +"','@admin.com')";
            try
            {
                int compte = commandeBDD(req).ExecuteNonQuery();
                if (compte > 0)
                    MessageBox.Show("bonjour Mr/Me l'administrateur votre Mot de passe par defaut est "+ DeconvertirMotdepasse(cont) +" et le nom d'utilisateur est Admin");
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
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
        // va chercher s'il y a deja un username avec ce nom 
        public string checkuser (string username)
        {
            req = "select Username from Connexion where Username='" + username + "'";
            string recuperer="";
            try
            {
                SqlDataReader r = commandeBDD(req).ExecuteReader();
                while (r.Read())
                {
                    recuperer = r.GetString(0);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return recuperer;
        }

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: partie outils :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        
        // cette fonction va incrementer de 1  chaque id lors d'un ajout dans une table quelconque 
        //elle se prensentera comme suit ex: cne = nextcode(etduiant,cne);
        public int nextcode(string table, string key)
        {
            string requete= "SELECT MAX("+key+") + 1 FROM "+table;
            int lastcode=0;
            int next_code=0;
            try
            {
                SqlDataReader r = commandeBDD(requete).ExecuteReader();
                while (r.Read())
                    lastcode = int.Parse(r.GetValue(0).ToString());
            if (lastcode == 0)
                next_code = 0;
            else
                next_code = lastcode + 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return next_code;
        }
        // cette fonction va faire en sorte de charger les forms sur panel 
        public void chargerForm (Form f, Panel p)
        {
            if (p.Controls.Count > 0)
                p.Controls.RemoveAt(0);
            
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);
            p.Tag = f;
            f.Show();
        }
        // cette fonction va effacer tous les text box qui se trouvent dans un panel 
        
        public void rechercher(string id, Form f)
        {
            string requete = "select * from  where id_";
            SqlDataReader lire = commandeBDD(requete).ExecuteReader();
            while (lire.Read())
            {
                f.Text = "";
            }
        }
    }
}
