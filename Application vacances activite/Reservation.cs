using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_vacances_activite
{
    class Reservation
    {
        private int ID_RESA;
        private int ID_ACT;
        private string CD_UTI;
        private string DATE_RESA;
        private int NBRparticipants;

        public Reservation(int ID_RESA,int ID_ACT,string CD_UTI,string DATE_RESA,int NBRparticipants)
        {
            this.ID_RESA = ID_RESA;
            this.ID_ACT = ID_ACT;
            this.CD_UTI = CD_UTI;
            this.DATE_RESA = DATE_RESA;
            this.NBRparticipants = NBRparticipants;
        }


        public Reservation(int ID_ACT, string CD_UTI, string DATE_RESA, int NBRparticipants)
        {
            
            this.ID_ACT = ID_ACT;
            this.CD_UTI = CD_UTI;
            this.DATE_RESA = DATE_RESA;
            this.NBRparticipants = NBRparticipants;
        }

        public int GetID_ACT()
        {
            return this.ID_ACT;
        }

        public string GetCD_UTI()
        {
            return CD_UTI;
        }

        public string GetDATE_RESA()
        {
            return this.DATE_RESA;
        }

        public int nbrParticipants()
        {
            return this.NBRparticipants;
        }

        public override string ToString()
        {
            return this.ID_RESA+"  Date de votre réservation :  "+Donnees.getDateActivite()+" pour "+this.NBRparticipants+" personnes";
        }

        public int GetID_RESA()
        {
            return this.ID_RESA;
        }
    }
}
