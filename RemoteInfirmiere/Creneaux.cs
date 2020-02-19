using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteInfirmiere
{
    [Serializable]
    public class Creneaux
    {
        public int id { get; set; }
        public string jour { get; set; }
        public string debut { get; set; }
        public string fin { get; set; }
        public string date { get; set; }
        public bool etat { get; set; }
        public string messageEtat { get; set; }

        public Creneaux(int id, string jour, string date, string debut, bool etat)
        {
            this.id = id;
            this.jour = jour;
            this.date = date;
            this.debut = debut;
            this.etat = etat;
        }

        public Creneaux(int id, string jour, string date, string debut, string messageEtat)
        {
            this.id = id;
            this.jour = jour;
            this.date = date;
            this.debut = debut;
            this.messageEtat = messageEtat;
        }
    }
}
