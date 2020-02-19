using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMedecinInfirmiere
{
    [Serializable]
    public class RendezVous
    {
        public int id { get; set; }
        public int idCreneaux { get; set; }
        public int idMedecin { get; set; }
        public int idPatient { get; set; }

        public RendezVous(int idCreneaux, int idMedecin, int idPatient)
        {
            this.idCreneaux = idCreneaux;
            this.idMedecin = idMedecin;
            this.idPatient = idPatient;
        }
    }
}
