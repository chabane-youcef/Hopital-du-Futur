
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            try
            {


                TcpChannel channelMedecin = new TcpChannel(4747);
                ChannelServices.RegisterChannel(channelMedecin, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Impl_Medecin), "ObjMedecin", WellKnownObjectMode.Singleton);
                Console.WriteLine("Medecin's channel has started...");
                Console.WriteLine("-----------------------------------");

                //----------------------------------------------------

                TcpChannel channelInfirmiere = new TcpChannel(7474);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Impl_Infirmiere), "ObjInfirmiere", WellKnownObjectMode.Singleton);
                Console.WriteLine("Infirmiere's channel has started...");
                Console.WriteLine("-----------------------------------");

                //----------------------------------------------------

                TcpChannel channelAdmin = new TcpChannel(1099);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Impl_Administrateur), "ObjAdministrateur", WellKnownObjectMode.Singleton);
                Console.WriteLine("Admin's channel has started...");
                Console.WriteLine("-----------------------------------");

                //----------------------------------------------------

                TcpChannel channelEventInfirmiereMedecin = new TcpChannel(7744);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Impl_Infirmiere_Event), "ObjEventInfirmiereMedecin", WellKnownObjectMode.Singleton);
                Console.WriteLine("event's channel has started...");
                Console.WriteLine("-----------------------------------");







                Console.WriteLine("serveur started ...");
                
            }
            catch(Exception e)
            {
                Console.WriteLine("server error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
