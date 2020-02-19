using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RemoteAdministrateur;

namespace Server
{
    public class Impl_Administrateur : MarshalByRefObject, I_Administrateur
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

        // envoie la liste des specialites disponibles
        public List<Specialite> ListSpecialite()
        {
            List<Specialite> specialites = new List<Specialite>();
            specialites.Add(new Specialite(1, "#"));
            

            try { 
                InitializeDATABASE();
            
                string query = "select * from specialite; ";
                MySqlCommand cmd = new MySqlCommand(query, DBConn);
                
                DBConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idSpecialite = int.Parse(reader["idSpecialite"].ToString());
                    string nomSpecialite = reader["NomSpec"].ToString();

                    specialites.Add(new Specialite(idSpecialite, nomSpecialite));
                }
            }catch(Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return specialites;
        }
        //====================================================================================================

        // ajouter les infos dans tables Personne
        public int InsertIntoPersonne(Medecin med)
        {
            int id = 0;

            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into Personne(Nom,Prenom,email,password) VALUES ('{0}','{1}','{2}','{3}')",med.Nom,med.Prenom,med.Email,med.Password);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();
                id = (int)cmd.LastInsertedId;

                DBConn.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine("error: "+e.Message);
            }

            return id;
        }
        //====================================================================================================

        // ajouter medecin dans table Medecin
        public bool AjouterMedecin(Medecin m)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("INSERT INTO Medecin(idMedecin, Spec) VALUES ({0},{1})", m.IdMedecin,m.IdSpecialite);
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

        // envoie la liste des medecins 
        public List<Medecin> ListMedecins()
        {
            List<Medecin> medecins = new List<Medecin>();

            try
            {
                InitializeDATABASE();

                string query = "select * from Personne inner join Medecin on Personne.idPersonne = Medecin.idMedecin inner join Specialite on Medecin.Spec = Specialite.idSpecialite;";
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int IdMedecin = int.Parse(reader["idMedecin"].ToString());
                    string Nom = reader["Nom"].ToString();
                    string Prenom = reader["Prenom"].ToString();
                    
                    string email = reader["email"].ToString();
                    string specialite = reader["NomSpec"].ToString();

                    
                    medecins.Add(new Medecin(IdMedecin, Nom, Prenom, email, specialite));
                    
                    
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

        // login Admin
        public bool Login(string email, string password)
        {
            if(email.Equals("chabaneyoucef98@gmail.com") && password.Equals("123456"))
            {
                return true;
            }else
            {
                return false;
            }
        }
        //====================================================================================================

        //Modifier Personne


        public bool ModifierPersonne(Medecin med)
        {
            bool verify = false;
            try
            {


                InitializeDATABASE();

                string query = string.Format("UPDATE Personne SET Nom='{0}', Prenom='{1}', email='{2}' WHERE idPersonne={3};", med.Nom, med.Prenom, med.Email, med.IdMedecin);

                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    verify = true;
                }

                DBConn.Close();
            }catch(Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }

            return verify;
        }
        //====================================================================================================

        //Modifier Medecin
        public bool ModifierMedecin(Medecin m)
        {
            bool verify = false;
            try
            {


                InitializeDATABASE();

                string query = string.Format("UPDATE Medecin SET Spec={0} WHERE idMedecin={1};", m.IdSpecialite, m.IdMedecin);

                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    verify = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }

            return verify;
        }
        //====================================================================================================

        // supprimer Medecin
        public bool SupprimerMedecin(Medecin m)
        {
            throw new NotImplementedException();
        }


        //========================================================================================================================================================================================================
        //                                      Gestions Infirmiers
        //========================================================================================================================================================================================================



        //====================================================================================================
        //Ajouter Infirmiere dans la base de données
        public bool AjouterInfirmiere(Infirmiere inf)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("INSERT INTO infirmiere(idInfirmiere) VALUES ({0});", inf.IdInfirmiere);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int i =cmd.ExecuteNonQuery();
                if(i != 0)
                {
                    verify = true;
                }

                DBConn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return verify;
        }


        //====================================================================================================
        //recuperer la liste des infimieres qui existe dans la base de données
        public List<Infirmiere> ListInfirmiere()
        {
            List<Infirmiere> infirmieres = new List<Infirmiere>();
            try
            {
                InitializeDATABASE();

                string query = "select * from Personne inner join Infirmiere ON Personne.idPersonne = Infirmiere.idInfirmiere;";
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idInfirmiere = int.Parse(reader["idInfirmiere"].ToString());
                    string Nom = reader["Nom"].ToString();
                    string Prenom = reader["Prenom"].ToString();

                    string email = reader["email"].ToString();
                   


                    infirmieres.Add(new Infirmiere(idInfirmiere, Nom, Prenom, email));
                }

                reader.Close();
                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return infirmieres;
        }


        //====================================================================================================
        //inserer les donnees principales de l'infirmiere dans la table de personne
        public int InserInfirmiereIntoPersonne(Infirmiere inf)
        {
            int id = 0;
            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into Personne(Nom,Prenom,email,password) VALUES ('{0}','{1}','{2}','{3}')", inf.Nom, inf.Prenom, inf.Email, inf.Password);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();
                id = (int)cmd.LastInsertedId;

                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return id;
        }

        //====================================================================================================
        //Modifier les données d'infirmiere
        public bool ModifierInfirmiere(Infirmiere inf)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();

                string query = string.Format("UPDATE Personne SET Nom='{0}', Prenom='{1}', email='{2}' WHERE idPersonne={3};", inf.Nom, inf.Prenom, inf.Email, inf.IdInfirmiere);

                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    verify = true;
                }

                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }

            return verify;
        }

        //====================================================================================================
        //supprimer les données d'infirmiere
        public bool SupprimerInfirmiere(Infirmiere inf)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();

                string query = string.Format("DELETE FROM Personne WHERE idPersonne={0};", inf.IdInfirmiere);

                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    verify = true;
                }

                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }

            return verify;
        }



        //========================================================================================================================================================================================================
        //implimentation des methodes de gestion des patients


        //inserer dans la table Personne
        public int AjouterPatientIntoPersonne(Patient p)
        {
            int id = 0;
            try
            {
                InitializeDATABASE();
                string query = string.Format("insert into Personne(Nom,Prenom,email,password) VALUES ('{0}','{1}','{2}','{3}')", p.nomPatient, p.prenomPatient, p.emailPatient, p.passwordPatient);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();
                id = (int)cmd.LastInsertedId;

                DBConn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            return id;
        }


        //====================================================================================================
        //inserer dans la table Patient
        public bool AjouterPatient(Patient p)
        {
            bool verify = false;
            try
            {
                InitializeDATABASE();
                string query = string.Format("INSERT INTO Patient(idPatient,Categorie,Age) VALUES ({0},{1},{2});", p.idPatient,p.idMaladiePatient,p.agePatient);
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
        //recuperer la list des patients

        public List<Patient> ListPatients()
        {
            List<Patient> patients = new List<Patient>();

            try
            {
                InitializeDATABASE();

                string query = "select * from personne	inner join patient on Personne.idPersonne = Patient.idPatient inner join Specialite on Patient.Categorie = Specialite.idSpecialite;";
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idPatient = int.Parse(reader["idPatient"].ToString());
                    string Nom = reader["Nom"].ToString();
                    string Prenom = reader["Prenom"].ToString();
                    int age = int.Parse(reader["Age"].ToString());
                    string maladie = reader["NomSpec"].ToString();
                    

                    patients.Add(new Patient(idPatient, Nom, Prenom, age, maladie));
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

        public void AjouterCreneaux(Creneaux c)
        {

            string jour = c.jour;
            try
            {
                InitializeDATABASE();
                string query = string.Format("INSERT INTO Creneaux(idMedecin, jourdeSem,debutCons,finCons,date,etat) values({0},'{1}','{2}','{3}','{4}',0);",c.idMedecin,c.jour,c.debut,c.fin, c.date);
                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                cmd.ExecuteNonQuery();

                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            
        }

        public bool supprimerPatient(Patient p)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();

                string query = string.Format("DELETE FROM Personne WHERE idPersonne={0};", p.idPatient);

                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    verify = true;
                }

                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }

            return verify;
        }

        public bool updatePersonne(Patient p)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();

                string query = string.Format("UPDATE Personne SET Nom='{0}' , Prenom='{1}' WHERE idPersonne={2}",p.nomPatient, p.prenomPatient, p.idPatient);

                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    verify = true;
                }

                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }

            return verify;
        }

        public bool updatePatient(Patient p)
        {
            bool verify = false;

            try
            {
                InitializeDATABASE();

                string query = string.Format("UPDATE Patient SET Categorie={0}, Age={1} WHERE idPatient={2};", p.idMaladiePatient, p.agePatient, p.idPatient);

                MySqlCommand cmd = new MySqlCommand(query, DBConn);

                DBConn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    verify = true;
                }

                DBConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
            }

            return verify;
        }
    }
}
