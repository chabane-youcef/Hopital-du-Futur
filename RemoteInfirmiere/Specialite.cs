using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteInfirmiere
{
    [Serializable]
    public class Specialite
    {
        public int id { get; set; }
        public string specialite { get; set; }

        public Specialite(int id, string specialite)
        {
            this.id = id;
            this.specialite = specialite;
        }
    }
}
