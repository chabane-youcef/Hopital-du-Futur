using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAdministrateur
{
    [Serializable]
    public class Patient
    {
        public int idPatient { get; set; }
        public string nomPatient { get; set; }
        public string prenomPatient { get; set; }
        public string emailPatient { get; set; }
        public int agePatient { get; set; }
        public string passwordPatient { get; set; }
        public int idMaladiePatient { get; set; }
        public string maladiePatient { get; set; }
        public int PourcentageTraitement { get; set; }

        public Patient(string nomPatient, string prenomPatient, string emailPatient, int idMaladiePatient, string passwordPatient)
        {
            
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.emailPatient = emailPatient;
            this.idMaladiePatient = idMaladiePatient;
            this.passwordPatient = passwordPatient;

        }

        public Patient(int idPatient, int idMaladiePatient, int agePatient)
        {
            this.idPatient = idPatient;
            this.idMaladiePatient = idMaladiePatient;
            this.agePatient = idPatient;
        }

        public Patient(int idPatient, string nomPatient, string prenomPatient, int agePatient, string maladiePatient)
        {
            this.idPatient  = idPatient;
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.agePatient = agePatient;
            this.maladiePatient = maladiePatient;
            
        }

        public Patient(int idPatient, string nomPatient, string prenomPatient, int agePatient, int idMaladiePatient)
        {
            this.idPatient = idPatient;
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.agePatient = agePatient;
            this.idMaladiePatient = idMaladiePatient;

        }










    }
}
