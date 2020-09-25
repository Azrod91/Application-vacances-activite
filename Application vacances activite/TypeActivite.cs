using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_vacances_activite
{
    class TypeActivite
    {
        private string ID_TC;
        private string NOM_TC;

        public TypeActivite(string typeAct,string nomAct)
        {
            this.ID_TC = typeAct;
            this.NOM_TC = nomAct;
        }

        public override string ToString()
        {
            return NOM_TC;
        }

       
    }
}
