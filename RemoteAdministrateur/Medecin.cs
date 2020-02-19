using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAdministrateur
{
    [Serializable]
    public class Medecin
    {
        public int IdMedecin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdSpecialite { get; set; }
        public string SpecialiteNom { get; set; }

        public Medecin()
        {

        }

        public Medecin(int IdMedecin, string Nom, string Prenom, string Email, string SpecialiteNom)
        {
            this.IdMedecin = IdMedecin;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.SpecialiteNom = SpecialiteNom;
        }

        public Medecin(int IdMedecin, string Nom, string Prenom, string Email, int IdSpecialite)
        {
            this.IdMedecin = IdMedecin;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.IdSpecialite = IdSpecialite;
        }

        public Medecin(int IdMedecin, string Nom, string Prenom, string Email, string SpecialiteNom, string Password)
        {
            this.IdMedecin = IdMedecin;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.SpecialiteNom = SpecialiteNom;
            this.Password = Password;
        }

        public Medecin(string Nom, string Prenom, string Email, string Password)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.Password = Password;
        }

        public Medecin(int IdMedecin, int IdSpecialite)
        {
            this.IdMedecin = IdMedecin;
            this.IdSpecialite = IdSpecialite;
        }
    }
}
