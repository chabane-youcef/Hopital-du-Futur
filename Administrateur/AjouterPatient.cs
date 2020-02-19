using RemoteAdministrateur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrateur
{
    public partial class AjouterPatient : Form
    {
        I_Administrateur obj;
        public AjouterPatient()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestionPatient gestionPatient = new GestionPatient();
            List<Patient> patients = obj.ListPatients();
            gestionPatient.lvPatients.Items.Clear();

            foreach(Patient p in patients)
            {
                ListViewItem item = new ListViewItem(new string[] { p.idPatient.ToString(), p.nomPatient, p.prenomPatient, p.agePatient.ToString(), p.maladiePatient });
                item.Tag = p;

                gestionPatient.lvPatients.Items.Add(item);
            }

            this.Hide();
            gestionPatient.ShowDialog();
        }

        private void BtnAjouterPatient_Click(object sender, EventArgs e)
        {
            string nom = textBoxNomPatient.Text;
            string prenom = textBoxPrenomPatient.Text;
            string email = textBoxEmailPatient.Text;
            int age = int.Parse(textBoxAgePatient.Text);
            int idMaladie = int.Parse(comboBoxTypeMaladie.SelectedValue.ToString());
            string password = textBoxPasswordPatient.Text;

            Patient personne = new Patient(nom, prenom, email, idMaladie, password);

            int idPatient = obj.AjouterPatientIntoPersonne(personne);

            Patient patient = new Patient(idPatient, idMaladie, age);
            if (obj.AjouterPatient(patient))
            {
                GestionPatient gestionPatient = new GestionPatient();
                List<Patient> patients = obj.ListPatients();
                gestionPatient.lvPatients.Items.Clear();

                foreach (Patient p in patients)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.idPatient.ToString(), p.nomPatient, p.prenomPatient, p.agePatient.ToString(), p.maladiePatient });
                    item.Tag = p;

                    gestionPatient.lvPatients.Items.Add(item);
                }

                this.Hide();
                gestionPatient.ShowDialog();

            }
        }

        
    }
}
