using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Examen_Génie_Logicielle.Class
{
    class Toolkit
    {
        private string chaine { get;set;}
        chaine="";
        public SqlConnection connexion{get;}; 
        // a la place de créer des connexion dans toutes les classe il suffira de faire appel a cette methode pour créer une connexion avec la base de données 
        public connexionBaseDD ()
        {
            connexion= new SqlConnection(chaine);
            connexion.Open();
        }
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
    }
}
