using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAdministrateur
{
    [Serializable]
    public class Infirmiere
    {
        
        public int IdInfirmiere { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Infirmiere(int IdInfirmiere)
        {
            this.IdInfirmiere = IdInfirmiere;
        }

        public Infirmiere(int IdInfirmiere, string Nom, string Prenom, string Email)
        {
            this.IdInfirmiere = IdInfirmiere;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
        }
        public Infirmiere(string Nom, string Prenom, string Email, string Password)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
