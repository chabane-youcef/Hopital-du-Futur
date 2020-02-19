using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMedecinInfirmiere
{
    public class EventProxy : MarshalByRefObject
    {
        public event RendezvousArrivedEvent RendezVousArrived;

        public override object InitializeLifetimeService()
        {
            return null; 
        }

        public void LocallyHandelRendezVousArrived(RendezVous rv)
        {
            if(RendezVousArrived != null)
            {
                RendezVousArrived(rv);
            }
        }
    }
}
