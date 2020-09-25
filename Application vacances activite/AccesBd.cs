using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Data;

//librairie Mysql ajouté
using System.Text;
using MySql.Data.MySqlClient;

namespace Application_vacances_activite
{
    static class AccesBd
    {
        private static MySqlConnection conn;
        private static List<Activite> contenuAct = new List<Activite>();
        private static List<TypeActivite> listeTypeAct = new List<TypeActivite>();
        

        public static bool connexion()
        {
            String cs = @"server=localhost;userid=root;password=;database=ava";
            conn = new MySqlConnection(cs); // connection BD
            conn.Open();
            return conn.State == ConnectionState.Open; // true or false
        }

        public static void deconnexion()
        {
            conn.Close();
        }

        public static bool verifCo(string user, string mdp)
        {
            MySqlCommand cmd = null;
            MySqlDataReader data = null;
            string req = "SELECT* FROM utilisateur WHERE CD_UTI='" + user + "'AND MDP='" + mdp + "'";
            cmd = conn.CreateCommand(); // creation commande lié à la connection
            cmd.CommandText = req; // mettre la commande sous forme text
            data = cmd.ExecuteReader(); // execute la requete
            if (data.Read())
            {
                return true;
            }
            data.Close();
            return false;
        }

        public static List<Activite> GetToutesActivites() // liste toutes les activités de la BD
        {
            MySqlCommand cmd = null;
            MySqlDataReader data = null;
            string req = "SELECT* FROM activité";
            cmd = conn.CreateCommand();
            cmd.CommandText = req;
            data = cmd.ExecuteReader();
            int i = 0;
            while (data.Read())
            {
                i++;
                Activite activite = new Activite((int)(data["ID_ACT"]),(string)(data["ID_TC"]), (string)(data["CD_UTI"]), (string)(data["NOM_ACT"]), (string)(data["DATE_ACT"]), (string)(data["DATE_FIN_ACT"]),(int)(data["TARIF"]), (int)(data["nbrPerso"]));
                contenuAct.Add(activite);
                
            }
            data.Close();
            return contenuAct;

        }

        public static List<TypeActivite> GetListeTypeAct() // comboBox des type d'activités 
        {
            MySqlCommand cmd = null;
            MySqlDataReader data = null;
            string req = "SELECT* FROM type_activité";
            cmd = conn.CreateCommand();
            cmd.CommandText = req;
            data = cmd.ExecuteReader();
            
            while (data.Read())
            {
               
                TypeActivite typeAct = new TypeActivite((string)(data["ID_TC"]), (string)(data["NOM_TC"]));
                listeTypeAct.Add(typeAct);

            }
            data.Close();
            return listeTypeAct;
        }



        public static List<Activite> GetRechercheAct(string typeAct)
        {
            List<Activite> listeActivite = new List<Activite>();
            MySqlCommand cmd = null;
            MySqlDataReader data = null;
            string req = "SELECT* FROM activité A, type_activité TA WHERE A.ID_TC = TA.ID_TC AND NOM_TC = '" + typeAct + "'";
         
            cmd = conn.CreateCommand();
            cmd.CommandText = req;
            data = cmd.ExecuteReader();

            while (data.Read())
            {

                Activite activite = new Activite((int)(data["ID_ACT"]), (string)(data["ID_TC"]), (string)(data["CD_UTI"]), (string)(data["NOM_ACT"]), (string)(data["DATE_ACT"]), (string)(data["DATE_FIN_ACT"]),(int)(data["TARIF"]), (int)(data["nbrPerso"]));
                listeActivite.Add(activite);

            }
            data.Close();
            return listeActivite;
        }


        public static bool inscription(string user, string mdp, string nom, string prenom, string sexe, string typeUtilisateur, string naissance)
        {
            Utilisateur u1 = new Utilisateur(user, mdp, nom, prenom, sexe, "V", naissance);
           
            MySqlCommand cmd = conn.CreateCommand();
            string req = "INSERT INTO " +
                "utilisateur(CD_UTI,MDP,NOM,PRENOM,SEXE,TYPEUTI,DATE_NAISSANCE) " +
                "VALUES('" + u1.getCD_util() + "','" + u1.getMdp() + "','" + u1.getNom() + "','" + u1.getPrenom() + "','" + u1.getSexe() + "','" + u1.gettypeUtil() + "','" + u1.getDatenaissance() + "')";
            
            cmd.CommandText = req;
            int nbAjout = cmd.ExecuteNonQuery();
            return nbAjout == 1;

        }

        public static List<Activite> GetcontenuAct()
        {
            return contenuAct;
        }

        public static bool resa(int IDact, string Utilisateur,int nbrParticiapnts)
        {
            String uneDate = System.DateTime.Now.ToShortDateString(); // date aujourd'hui
            Reservation r = new Reservation(IDact, Utilisateur, uneDate, nbrParticiapnts);
            MySqlCommand cmd = conn.CreateCommand();
            
            string req = "INSERT INTO reservation(ID_ACT,CD_UTI,DATE_RESA,nbrParticipants) VALUES('" + r.GetID_ACT() + "','" + r.GetCD_UTI() + "','" + r.GetDATE_RESA() + "','"+ r.nbrParticipants() + "')";
            cmd.CommandText = req;
            int nbAjout = cmd.ExecuteNonQuery();
            return nbAjout == 1;
        }


        public static List<Reservation> VoirMesResa()
        {
            List<Reservation> MesResa = new List<Reservation>();
            MySqlCommand cmd = null;
            MySqlDataReader data = null;
            
            string req = "SELECT* FROM reservation WHERE CD_UTI = '" + Donnees.getUtilistauer()+"'";

            cmd = conn.CreateCommand();
            cmd.CommandText = req;
            data = cmd.ExecuteReader();

            while (data.Read())
            {
                               
                Reservation r = new Reservation((int)(data["ID_RESA"]), (int)(data["ID_ACT"]),(string)(data["CD_UTI"]),(string)(data["DATE_RESA"]),(int)(data["nbrParticipants"]));
                
                MesResa.Add(r);
            }
            data.Close();
            return MesResa;

        }

        public static void SuprimmerResa(int idResa)
        {
            MySqlCommand cmd = conn.CreateCommand();
            string req = "DELETE FROM reservation WHERE ID_RESA = '" + idResa + "'";
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
        }

        
    }
}
