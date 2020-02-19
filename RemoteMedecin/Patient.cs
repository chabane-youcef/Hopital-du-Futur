using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMedecin
{
    [Serializable]
    public class Patient
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string maladie { get; set; }
        public int age { get; set; }
        public int countConsutlations { get; set; }
        public int idPatient { get; set; }
        public int idUrgence { get; set; }

        public Patient(int id, string nom, string prenom, int age)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public Patient(int id,int idPatient, string nom, string prenom, int age, int countConsutlations)
        {
            this.id = id;
            this.idPatient = idPatient;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.countConsutlations = countConsutlations;
        }

        public Patient(int idUrgence,string nom,string prenom, int age,string maladie)
        {
            this.idUrgence = idUrgence;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.maladie = maladie;
        }
    }
}
