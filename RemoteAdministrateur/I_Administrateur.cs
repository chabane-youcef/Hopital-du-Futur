using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAdministrateur
{
    public interface I_Administrateur
    {
        bool Login(string email,string password);
        int InsertIntoPersonne(Medecin med);
        bool AjouterMedecin(Medecin m);
        void AjouterCreneaux(Creneaux c);
        List<Medecin> ListMedecins();
        bool ModifierPersonne(Medecin med); 
        bool ModifierMedecin(Medecin m);
        bool SupprimerMedecin(Medecin m);
        List<Specialite> ListSpecialite();

        // Methodes pour manipuler les infirmieres

        int InserInfirmiereIntoPersonne(Infirmiere inf);
        bool AjouterInfirmiere(Infirmiere inf);
        List<Infirmiere> ListInfirmiere();
        bool SupprimerInfirmiere(Infirmiere inf);
        bool ModifierInfirmiere(Infirmiere inf);



        // Methodes pour gerer Patients

        int AjouterPatientIntoPersonne(Patient p);
        bool AjouterPatient(Patient p);
        bool supprimerPatient(Patient p);

        bool updatePersonne(Patient p);
        bool updatePatient(Patient p);
        List<Patient> ListPatients();
    }
}
