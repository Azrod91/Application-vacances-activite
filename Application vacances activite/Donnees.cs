using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_vacances_activite
{
    static class Donnees
    {
        private static string utilisateur;
        private static int idAct;
        private static string NomAct;
        private static string DateActivite;

        public static string getUtilistauer()
        {
            return utilisateur;
        }

        public static void setUtilisateur(string user)
        {
            utilisateur = user;
        }

        public static int getIdAct()
        {
            return idAct;
        }

        public static void setIdAct(int idActi)
        {
            idAct = idActi;
        }

        public static string getNomAct()
        {
            return NomAct;
        }

        public static void SetNomAct(string NomActivite)
        {
            NomAct = NomActivite;
        }

        public static string getDateActivite()
        {
            return DateActivite;
        }

        public static void setDateActivite(string dateAct)
        {
            DateActivite = dateAct;
        }
       


         

    }
}
