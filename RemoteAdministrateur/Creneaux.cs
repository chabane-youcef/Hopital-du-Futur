using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAdministrateur
{
    [Serializable]
    public class Creneaux
    {
        public int idCreneaux { get; set; }
        public int idMedecin { get; set; }
        public string jour { get; set; }
        public string debut { get; set; }
        public string fin { get; set; }
        public string date { get; set; }
        public int etat { get; set; }

        public Creneaux(int idMedecin, string jour, string debut, string fin, string date)
        {
            this.idMedecin = idMedecin;
            this.jour = jour;
            this.debut = debut;
            this.fin = fin;
            this.date = date;
        }

        public Creneaux(string debut, string fin)
        {
            
            this.debut = debut;
            this.fin = fin;
        }


    }
}
