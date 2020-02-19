using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMedecin
{
    [Serializable]
    public class EtatPatient
    {
        public int idEtatPatient { get; set; }
        public int idPatient { get; set; }
        public int idRendezvous { get; set; }
        public int traitement { get; set; }
        public string note { get; set; }
        public string date { get; set; }

        public EtatPatient(int idPatient,int idRendezvous, int traitement, string note, string date)
        {
            this.idPatient = idPatient;
            this.idRendezvous = idRendezvous;
            this.traitement = traitement;
            this.note = note;
            this.date = date;
        }

        public EtatPatient(int idEtatPatient, int traitement, string date, string note)
        {
            this.idEtatPatient = idEtatPatient;
            this.traitement = traitement;
            this.date = date;
            this.note = note;
        }
    }
}
