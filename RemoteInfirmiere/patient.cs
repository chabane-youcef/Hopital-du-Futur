using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteInfirmiere
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
        public int idMaladie { get; set; }
        public int age { get; set; }
        public int idMedecin { get; set; }

        public Patient(int id, string nom, string prenom, int age)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public Patient ( string nom, string prenom,int idMaladie, int age,int idMedecin)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.idMaladie = idMaladie;
            this.age = age;
            this.idMedecin = idMedecin;
        }
    }
}
