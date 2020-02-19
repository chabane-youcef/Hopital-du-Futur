using EventMedecinInfirmiere;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Impl_Infirmiere_Event: MarshalByRefObject, I_Infirmiere_Events
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "hopital";
        private const String UID = "root";
        private const String PASSWORD = "djo110863";
        private static MySqlConnection DBConn;


        public static void InitializeDATABASE()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            String connString = builder.ToString();

            builder = null;

            DBConn = new MySqlConnection(connString);
        }


        public event RendezvousArrivedEvent RendezVousArrived;


        public bool ReserverCreneaux(RendezVous rendezvous)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into rendezvous (idCreneaux,idMedecin,idPatient) values({0},{1},{2});", rendezvous.idCreneaux, rendezvous.idMedecin, rendezvous.idPatient);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();
                ReserverCreneaux(rendezvous.idCreneaux);
                verify = true;

                DBConn.Close();
                SafeInvokeRendezVousAdded(rendezvous);
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return verify;
        }

        public void SafeInvokeRendezVousAdded(RendezVous rv)
        {
            if(RendezVousArrived == null)
            {
                return;
            }

            RendezvousArrivedEvent listner = null;
            Delegate[] dels = RendezVousArrived.GetInvocationList();

            foreach(Delegate del in dels)
            {
                try
                {
                    listner = (RendezvousArrivedEvent)del;
                    listner.Invoke(rv);
                }catch(Exception e)
                {
                    Console.WriteLine("erreur:" + e.Message);
                    RendezVousArrived -= listner;
                }
            }

        }


        public void ReserverCreneaux(int idCreneaux)
        {
            try
            {
                InitializeDATABASE();
                string query = string.Format("update Creneaux set etat='1' where idCreneaux={0};", idCreneaux);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();


                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }
    }
}
