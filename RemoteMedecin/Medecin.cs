using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMedecin
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

        public Medecin(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }
}
