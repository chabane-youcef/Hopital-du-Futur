using MySql.Data.MySqlClient;
using RemoteMedecin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Impl_Medecin:MarshalByRefObject, I_Medecin
    {
        // info de base de donnees
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "hopital";
        private const String UID = "root";
        private const String PASSWORD = "djo110863";
        private static MySqlConnection DBConn;

        //====================================================================================================

        // initialisation de base de données
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

        

        public List<RendezVous> ListRendezvous(int idMedecin)
        {
            List<RendezVous> listRendezvous = new List<RendezVous>();
            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from rendezvous	inner join Personne on rendezvous.idPatient = Personne.idPersonne inner join creneaux on rendezvous.idCreneaux = creneaux.idCreneaux where rendezvous.idMedecin={0};",idMedecin);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["idRendezvous"].ToString());
                    int idPatient = int.Parse(reader["idPatient"].ToString());
                    string nomPatient = reader["Nom"].ToString();
                    string prenomPatient = reader["Prenom"].ToString();
                    string jourConsultation = reader["jourdeSem"].ToString();
                    string dateConsultation = reader["date"].ToString();
                    string debutConsultation = reader["debutCons"].ToString();

                    listRendezvous.Add(new RendezVous(id,idPatient, nomPatient, prenomPatient, jourConsultation, dateConsultation, debutConsultation));
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return listRendezvous;
        }

        public int  Login(Medecin m)
        {
            //bool verify = false;
            //try
            //{
            //    InitializeDATABASE();
            //    string query = string.Format("select * from Personne inner join Medecin on Personne.idPersonne=Medecin.idMedecin where Personne.email='{0}' and Personne.password='{1}';", m.Email, m.Password);
            //    MySqlCommand cmd = new MySqlCommand(query, DBConn);

            //    DBConn.Open();

            //    int i = cmd.ExecuteNonQuery();
            //    if (i != 0)
            //    {
            //        verify = true;

            //    }

            //    DBConn.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}
            //return verify;

            int idMedecin = 0;
            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from Personne inner join Medecin on Personne.idPersonne = Medecin.idMedecin where Personne.email='{0}' and password='{1}'", m.Email, m.Password);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idMedecin = int.Parse(reader["idPersonne"].ToString());
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return idMedecin;
        }

        public bool SupprimerRendezVous(RendezVous r)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("delete from rendezvous where idRendezvous ={0};",r.id);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    verify = true;

                }

                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return verify;
        }

        public bool EnregistrerEtat(EtatPatient ep)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into etatPatient(idPatient,PourcTraitement,Note,Date) values({0},{1},'{2}','{3}');", ep.idPatient, ep.traitement,ep.note,ep.date);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();
                verify = true;
                DBConn.Close();
                if (verify)
                {
                    RendezVous rv = retrieveRendezvous(ep.idRendezvous);
                    if (EnregistrerConsultation(rv))
                    {
                        resetCreneau(rv.idCreneaux);
                        deleteRendezvous(ep.idRendezvous);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return verify;
        }

        public bool EnregistrerConsultation(RendezVous rv)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into Consultation( idCreneaux,idMedecin,idPatient) values({0},{1},{2});",rv.idCreneaux,rv.idMedecin,rv.idPatient);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();
                verify = true;

                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return verify;
        }

        public RendezVous retrieveRendezvous(int idRendezvous)
        {
            RendezVous rv = null;
            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from rendezvous where idRendezvous={0};", idRendezvous);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idCreneaux = int.Parse(reader["idCreneaux"].ToString());
                    int idMedecin = int.Parse(reader["idMedecin"].ToString());
                    int idPatient = int.Parse(reader["idPatient"].ToString());
                    rv = new RendezVous(idCreneaux, idMedecin, idPatient);
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return rv;
        }
        
        public void deleteRendezvous(int idRendezvous)
        {
            try
            {
                InitializeDATABASE();
                string query = string.Format("delete from Rendezvous where idRendezvous={0};",idRendezvous);
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

        public void resetCreneau(int idCreneaux)
        {
            try
            {
                InitializeDATABASE();
                string query = string.Format("update creneaux set etat=0 where idCreneaux={0};",idCreneaux);
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

        public List<Patient> listPatients(int idMedecin)
        {
            List<Patient> patients = new List<Patient>();

            try
            {
                InitializeDATABASE();
                string query = string.Format("select *, Count(*) as nbrConsultations from consultation 	inner join Personne on consultation.idPatient= personne.idPersonne inner join Patient on Consultation.idPatient = Patient.idPatient  where consultation.idMedecin = {0} group by consultation.idPatient;", idMedecin);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idConsultation = int.Parse(reader["idConsultation"].ToString());
                    int idPatient = int.Parse(reader["idPatient"].ToString());
                    string nom = reader["Nom"].ToString();
                    string prenom = reader["Prenom"].ToString();
                    int age = int.Parse(reader["Age"].ToString());
                    int countConsultations = int.Parse(reader["nbrConsultations"].ToString());

                    patients.Add(new Patient(idConsultation, idPatient, nom, prenom, age,countConsultations));
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return patients;
        }

        public List<EtatPatient> listEtat(int idPatient)
        {
            List<EtatPatient> etats = new List<EtatPatient>();

            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from etatPatient where idPatient={0};",idPatient);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idEtatPatient = int.Parse(reader["idEtatPatient"].ToString());
                    int pourcentage = int.Parse(reader["PourcTraitement"].ToString());
                    string date = reader["Date"].ToString();
                    string note = reader["Note"].ToString();


                    etats.Add(new EtatPatient(idEtatPatient, pourcentage, date, note));
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return etats;
        }

        public bool verifyUrgence(int idMedecin)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from urgence where idMedecin={0} and etat=0;", idMedecin);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    verify = true;
                }

               
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return verify;
        }

        public List<Patient> ListUrgence(int idMedecin)
        {
            List<Patient> urgences = new List<Patient>();

            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from urgence inner join Personne on urgence.idPatient = Personne.idPersonne inner join Patient on urgence.idPatient = Patient.idPatient inner join Specialite on specialite.idSpecialite = Patient.categorie where idMedecin={0} and urgence.etat=0;", idMedecin);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idUrgence = int.Parse(reader["idUrgence"].ToString());
                    string nom = reader["Nom"].ToString();
                    string prenom = reader["Prenom"].ToString();
                    int age = int.Parse(reader["Age"].ToString());
                    string maladie = reader["NomSpec"].ToString();

                    urgences.Add(new Patient(idUrgence, nom, prenom, age, maladie));
                    
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return urgences;
        }

        public bool ConsultedUrgence(int idUrgence)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("update Urgence set etat=1 where idUrgence={0};",idUrgence);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    verify = true;
                }


                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return verify;
        }
    }
}
