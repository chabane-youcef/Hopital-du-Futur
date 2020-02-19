using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAdministrateur
{
    [Serializable]
    public class Specialite
    {
        public int IdSpecialite { get; set; }
        public string NomSpecialite { get; set; }
        public Specialite(int IdSpecialite, string NomSpecialite)
        {
            this.IdSpecialite = IdSpecialite;
            this.NomSpecialite = NomSpecialite;
        }

       
    }
}
