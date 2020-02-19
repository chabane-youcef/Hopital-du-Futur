using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMedecin
{
    [Serializable]
    public class RendezVous
    {
        public int id { get; set; }
        public int idCreneaux { get; set; }
        public int idMedecin { get; set; }
        public int idPatient { get; set; }

        public string NomPatient { get; set; }
        public string PrenomPatient { get; set; }
        public string JourRendezvous { get; set; }
        public string debutConsultation { get; set; }
        public string dateConsultation { get; set; }


       public RendezVous(int id,int idPatient, string NomPatient, string PrenomPatient, string JourRendezvous, string dateConsultation, string debutConsultation)
        {
            this.id = id;
            this.idPatient = idPatient;
            this.NomPatient = NomPatient;
            this.PrenomPatient = PrenomPatient;
            this.JourRendezvous = JourRendezvous;
            this.debutConsultation = debutConsultation;
            this.dateConsultation = dateConsultation;
        }

        public RendezVous(int idCreneaux, int idMedecin, int idPatient)
        {
            this.idCreneaux = idCreneaux;
            this.idMedecin = idMedecin;
            this.idPatient = idPatient;
        }
    }
}
