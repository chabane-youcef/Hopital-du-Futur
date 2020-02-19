using RemoteInfirmiere;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Infirmiere
{
    public partial class MainInfirmiere : Form
    {
        I_Infirmiere obj;
        public MainInfirmiere()
        {
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCreneauxMedecins_Click(object sender, EventArgs e)
        {
            MedecinsDiponibles Dispo = new MedecinsDiponibles();
            List<Medecin> listMedecinDispo = obj.MedecinsDiponibles();
            List<Specialite> search = obj.SearchSpecialites();

            Dispo.listViewMedecins.Items.Clear();
            
            foreach (Medecin m in listMedecinDispo)
            {
                ListViewItem item = new ListViewItem(new string[] { m.id.ToString(), m.nom, m.prenom, m.specialite });
                item.Tag = m;
                Dispo.listViewMedecins.Items.Add(item);
            }

            Dispo.comboBoxSearch.DataSource = search;
            Dispo.comboBoxSearch.DisplayMember = "specialite";
            Dispo.comboBoxSearch.ValueMember = "id";

            this.Hide();
            Dispo.ShowDialog();

        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
            List<Patient> listPatients = obj.listPatientDisponibles();
            AffichagePatients patients = new AffichagePatients();

            patients.listViewPatients.Items.Clear();

            foreach(Patient p in listPatients)
            {
                ListViewItem item = new ListViewItem(new String[] { p.id.ToString(), p.nom, p.prenom, p.age.ToString() });
                item.Tag = p;
                patients.listViewPatients.Items.Add(item);
            }

            this.Hide();
            patients.ShowDialog();
        }

        private void btnUrgence_Click(object sender, EventArgs e)
        {
            Urgence urgence = new Urgence();
            List<Specialite> specialites = obj.SearchSpecialites();

            urgence.comboBoxMaladies.DataSource = specialites;
            urgence.comboBoxMaladies.DisplayMember = "specialite";
            urgence.comboBoxMaladies.ValueMember = "id";

            List<Medecin> medecins = obj.MedecinsDiponibles();
            urgence.listViewMedecins.Items.Clear();

            foreach(Medecin m in medecins)
            {
                ListViewItem item = new ListViewItem(new string[] { m.id.ToString(), m.nom, m.prenom, m.specialite });
                item.Tag = m;
                urgence.listViewMedecins.Items.Add(item);
            }

            this.Hide();
            urgence.ShowDialog();
        }
    }
}
