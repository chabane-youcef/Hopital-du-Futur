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
    public partial class MainAdmin : Form
    {
        I_Administrateur obj;
        public MainAdmin()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        

        private void BtnGestionInfirmieres_Click(object sender, EventArgs e)
        {
            GestionInfirmiere gestionInfirmiere = new GestionInfirmiere();
            List<Infirmiere> infirmiers = obj.ListInfirmiere();
            gestionInfirmiere.LvInfirmiere.Items.Clear();

            foreach (Infirmiere n in infirmiers)
            {
                ListViewItem item = new ListViewItem(new string[] { n.IdInfirmiere.ToString(), n.Nom, n.Prenom, n.Email });
                item.Tag = n;

                gestionInfirmiere.LvInfirmiere.Items.Add(item);
            }
            this.Hide();
            gestionInfirmiere.ShowDialog();
        }

        private void btnGestionMedecins_Click_1(object sender, EventArgs e)
        {
            GestionMedecin gestionMedecin = new GestionMedecin();

            List<Medecin> medecins = obj.ListMedecins();
            gestionMedecin.LvMedecins.Items.Clear();

            foreach (Medecin m in medecins)
            {
                ListViewItem item = new ListViewItem(new string[] { m.IdMedecin.ToString(), m.Nom, m.Prenom, m.Email, m.SpecialiteNom, m.Password });
                item.Tag = m;

                gestionMedecin.LvMedecins.Items.Add(item);
            }
            this.Hide();
            gestionMedecin.ShowDialog();
        }

        private void BtnGestionPatients_Click(object sender, EventArgs e)
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
