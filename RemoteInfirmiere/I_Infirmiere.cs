using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteInfirmiere
{
    
    public interface I_Infirmiere
    {
        bool Login(Infirmiere i);

        // pour gerer les creneaux des medecins
        List<Medecin> MedecinsDiponibles();
        List<Specialite> SearchSpecialites();
        List<Medecin> ListMedecinsParSepcialite(string s);
        List<Creneaux> ListCreneauxMedecin(int idMedecin);
        List<Patient> listPatientDisponibles();

        int InsertionUrgence(Patient p);
        bool EnregistrerUrgence(int idPatient, Patient p);



    }
}
