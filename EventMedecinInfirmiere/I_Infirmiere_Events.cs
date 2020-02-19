using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMedecinInfirmiere
{
    public interface I_Infirmiere_Events
    {
        event RendezvousArrivedEvent RendezVousArrived;

        bool ReserverCreneaux(RendezVous rv);
    }
}
