using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMedecin
{
    [Serializable]
    public class Pourcentage
    {
        public string afficahge { get; set; }
        public int value { get; set; }

        public Pourcentage(string affichage, int value)
        {
            this.afficahge = afficahge;
            this.value = value;
        }
    }
}
