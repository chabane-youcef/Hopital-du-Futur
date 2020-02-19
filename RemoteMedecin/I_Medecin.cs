using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMedecin
{
    public interface I_Medecin
    {
        int Login(Medecin m);

        List<RendezVous> ListRendezvous(int idMedecin);
        bool SupprimerRendezVous(RendezVous r);

        bool EnregistrerEtat(EtatPatient e);

        List<Patient> listPatients(int idMedecin);

        List<EtatPatient> listEtat(int idPatient);

        bool verifyUrgence(int idMedecin);

        List<Patient> ListUrgence(int idMedecin);
        bool ConsultedUrgence(int idUrgence);
    }
}
