using MySql.Data.MySqlClient;
using RemoteInfirmiere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Impl_Infirmiere : MarshalByRefObject, I_Infirmiere
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

        

        //====================================================================================================

        // login infirmiere

        public bool Login(Infirmiere inf)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from Personne inner join Infirmiere on Personne.idPersonne=Infirmiere.idInfirmiere where Personne.email='{0}' and Personne.password='{1}';", inf.email, inf.password);
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


        //====================================================================================================

        // list medecins disponibles
        public List<Medecin> MedecinsDiponibles()
        {
            List<Medecin> medecins = new List<Medecin>();

            try
            {
                InitializeDATABASE();
                string query = "select * from Personne	inner join Medecin on Personne.idPersonne = Medecin.idMedecin inner join Creneaux on Personne.idPersonne = Creneaux.idMedecin inner join Specialite on Medecin.Spec = Specialite.idSpecialite group by Personne.idPersonne;";
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["idMedecin"].ToString());
                    string nom = reader["Nom"].ToString();
                    string prenom = reader["Prenom"].ToString();
                    string specialite = reader["NomSpec"].ToString();

                    medecins.Add(new Medecin(id, nom, prenom, specialite));
                }

                reader.Close();
                DBConn.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return medecins;
        }

        

        public List<Specialite> SearchSpecialites()
        {
            List<Specialite> search = new List<Specialite>();
            search.Add(new Specialite(0, "tout"));
            try
            {
                InitializeDATABASE();
                string query = "select * from specialite;";
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["idSpecialite"].ToString());
                    string specialite = reader["NomSpec"].ToString();


                    search.Add(new Specialite(id, specialite));
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return search;
        }

        //====================================================================================================

        // list Medecin diponibles gategorise par leur specialites
        public List<Medecin> ListMedecinsParSepcialite(string s)
        {
            List<Medecin> medecins = new List<Medecin>();

            try
            {
                InitializeDATABASE();
                string query = string.Format("select * from Personne	inner join Medecin on Personne.idPersonne = Medecin.idMedecin inner join Creneaux on Personne.idPersonne = Creneaux.idMedecin inner join Specialite on Medecin.Spec = Specialite.idSpecialite  where Specialite.NomSpec='{0}' group by Personne.idPersonne;", s);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["idMedecin"].ToString());
                    string nom = reader["Nom"].ToString();
                    string prenom = reader["Prenom"].ToString();
                    string specialite = reader["NomSpec"].ToString();

                    medecins.Add(new Medecin(id, nom, prenom, specialite));
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            return medecins;
        }


        //====================================================================================================

        // list des creneaux de medecin selectionner
        public List<Creneaux> ListCreneauxMedecin(int idMedecin)
        {
            List<Creneaux> creneaux = new List<Creneaux>();
            Console.WriteLine("id Medecin :" + idMedecin);
            try
            {
                InitializeDATABASE();
                string query = string.Format("SELECT * FROM Creneaux WHERE idMedecin={0};", idMedecin);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["idCreneaux"].ToString());
                    string jour = reader["jourdeSem"].ToString();
                    string debut = reader["debutCons"].ToString();
                    DateTime datetime = DateTime.Parse(reader["date"].ToString());
                    string date = datetime.ToString("MM/dd/yyyy");
                    bool etat = bool.Parse(reader["etat"].ToString());
                    Console.WriteLine("id: " + id + ", jour: +" + jour + ", debut:" + debut + ",date : " + date+", etat:"+etat);
                    creneaux.Add(new Creneaux(id, jour, date.ToString(), debut, etat));
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return creneaux;
        }

        //====================================================================================================

        // list des patients diponibles dans la base de donnée
        public List<Patient> listPatientDisponibles()
        {
            List<Patient> ListPatients = new List<Patient>();

            try
            {
                InitializeDATABASE();
                string query = "select * from Personne inner join Patient on Personne.idPersonne = Patient.idPatient;";
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["idPersonne"].ToString());
                    string nom = reader["Nom"].ToString();
                    string prenom = reader["Prenom"].ToString();
                    
                    int age = int.Parse(reader["Age"].ToString());

                    ListPatients.Add(new Patient(id, nom, prenom, age));
                }

                reader.Close();
                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return ListPatients;
        }

        public int InsertionUrgence(Patient p)
        {
            bool verify = false;
            int id = 0;

            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into Personne(nom,prenom,email,password) values('{0}','{1}',' ',' ');",p.nom,p.prenom);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    id = (int)cmd.LastInsertedId;
                    
                }

                DBConn.Close();
                bool verifyinsertion = InsertPatientUrgence(id, p);

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return id;
        }

        public bool InsertPatientUrgence(int id, Patient p)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into Patient(idPatient,categorie,Age) values ({0},{1},{2});",id, p.idMaladie, p.age);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();
                

                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return verify;
        }

        public bool EnregistrerUrgence(int idPatient, Patient p)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into urgence(idMedecin, idPatient,etat) values({0},{1},{2});", p.idMedecin, idPatient, 0);
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

        //====================================================================================================

        // reserver rendez vous pour un patient selectionner
        //public bool ReserverCreneaux(RendezVous rendezvous)
        //{
        //    bool verify = false;

        //    try
        //    {
        //        InitializeDATABASE();
        //        string query = string.Format("insert into rendezvous (idCreneaux,idMedecin,idPatient) values({0},{1},{2});", rendezvous.idCreneaux, rendezvous.idMedecin, rendezvous.idPatient);
        //        MySqlCommand cmd = new MySqlCommand(query, DBConn);

        //        DBConn.Open();
        //        cmd.ExecuteNonQuery();
        //        ReserverCreneaux(rendezvous.idCreneaux);
        //        verify = true;

        //        DBConn.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("error: " + e.Message);
        //    }

        //    return verify;
        //}

        //public void ReserverCreneaux(int idCreneaux)
        //{
        //    try
        //    {
        //        InitializeDATABASE();
        //        string query = string.Format("update Creneaux set etat='1' where idCreneaux={0};", idCreneaux);
        //        MySqlCommand cmd = new MySqlCommand(query, DBConn);

        //        DBConn.Open();
        //        cmd.ExecuteNonQuery();


        //        DBConn.Close();

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("error: " + e.Message);
        //    }
        //}
    }
}
