using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_vacances_activite
{
    class Activite
    {
        private int ID_ACT;
        private string ID_TC;
        private string CD_UTI;
        private string NOM_ACT;
        private string DATE_ACT;
        private string DATE_FIN_ACT;
        private int TARIF;
        private int nbrPersonnnesMax;
       

        public Activite(int ID_ACT, string ID_TC,string CD_UTI,string NOM_ACT,string DATE_ACT,string DATE_FIN_ACT,int TARIF,int nbrPersonnnesMax)
        {
            this.ID_ACT = ID_ACT;
            this.ID_TC = ID_TC;
            this.CD_UTI = CD_UTI;
            this.NOM_ACT = NOM_ACT;
            this.DATE_ACT = DATE_ACT;
            this.DATE_FIN_ACT = DATE_FIN_ACT;
            this.TARIF = TARIF;
            this.nbrPersonnnesMax = nbrPersonnnesMax;
        }

        public override string ToString()
        {
            return this.ID_ACT + " " + this.NOM_ACT+" "+this.TARIF + " €/h" + "Date actvité:"+this.DATE_ACT+ " au "+this.DATE_FIN_ACT;
        }

        

        public int GetID_ACT()
        {
            return this.ID_ACT;
        }

        public string GetNomAct()
        {
            return this.NOM_ACT;
        }

        public int GetnbrPersoMax()
        {
            return this.nbrPersonnnesMax;
        }

    }
}
