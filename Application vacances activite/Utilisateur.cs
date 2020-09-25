using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_vacances_activite
{
    class Utilisateur
    {
        private string CD_util;
        private string mdp;
        private string nom;
        private string prenom;
        private string sexe;
        private string typeUtil;
        private string date_naissance;

        public Utilisateur(string CD_util,string mdp,string nom,string prenom,string sexe,string typeUtil,string date_naissance)
        {
            this.CD_util = CD_util;
            this.mdp = mdp;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.typeUtil = typeUtil;
            this.date_naissance = date_naissance;
        }

        public string getCD_util()
        {
            return CD_util;
        }

        public string getMdp()
        {
            return mdp;
        }

        public string getNom()
        {
            return nom;
        }

        public string getPrenom()
        {
            return prenom;
        }

        public string getSexe()
        {
            return sexe;
        }

        public string gettypeUtil()
        {
            return typeUtil;
        }

        public string getDatenaissance()
        {
            return date_naissance;
        }
    }
}
