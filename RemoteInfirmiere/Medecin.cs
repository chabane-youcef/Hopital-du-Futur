using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteInfirmiere
{
    [Serializable]
    public class Medecin
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string specialite { get; set; }
        public int idSpecialite { get; set; }

        public Medecin(int id, string nom, string prenom, string specialite)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.specialite = specialite;
        }
    }
}
