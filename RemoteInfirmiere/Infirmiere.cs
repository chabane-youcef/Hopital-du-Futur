using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteInfirmiere
{
    [Serializable]
    public class Infirmiere
    {
        public int idInfirmiere { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Infirmiere(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

    
    }
}
