using EventMedecinInfirmiere;
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
    public partial class selectionnerPatient : Form
    {
        int idCreneaux { get; set; }
        int idMedecin { get; set; }

        I_Infirmiere obj;
        I_Infirmiere_Events objEvent;
        public selectionnerPatient()
        {
            InitializeComponent();
        }

        public selectionnerPatient(int idCreneaux, int idMedecin)
        {
            this.idCreneaux = idCreneaux;
            this.idMedecin = idMedecin;
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
            objEvent = (I_Infirmiere_Events)Activator.GetObject(typeof(I_Infirmiere_Events), "tcp://localhost:7744/ObjEventInfirmiereMedecin");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainInfirmiere mainInf = new MainInfirmiere();
            if (MessageBox.Show("voulez vous retourner dans l'accuil ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                mainInf.ShowDialog();
            }
        }

        Patient CurrentPatient = null;

        private void lvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPatients.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPatients.SelectedItems[0];
                CurrentPatient = (Patient)item.Tag;
            }
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            EventMedecinInfirmiere.RendezVous rendezvous = new EventMedecinInfirmiere.RendezVous(idCreneaux, idMedecin, CurrentPatient.id);
            if (objEvent.ReserverCreneaux(rendezvous))
            {
                MessageBox.Show("Rendez-vous a été reserver pour M." + CurrentPatient.nom);
                MainInfirmiere mainInf = new MainInfirmiere();
                this.Hide();
                mainInf.ShowDialog();
            }
            else
            {
                MessageBox.Show("erreur!! voulez vous ressayer?");
                MedecinsDiponibles Dispo = new MedecinsDiponibles();

                List<Medecin> listMedecinDispo = obj.MedecinsDiponibles();
                List<Specialite> search = obj.SearchSpecialites();

                Dispo.listViewMedecins.Items.Clear();

                foreach (Medecin m in listMedecinDispo)
                {
                    ListViewItem item = new ListViewItem(new string[] { m.id.ToString(), m.nom, m.prenom, m.specialite });
                    Dispo.listViewMedecins.Items.Add(item);
                }

                Dispo.comboBoxSearch.DataSource = search;
                Dispo.comboBoxSearch.DisplayMember = "specialite";
                Dispo.comboBoxSearch.ValueMember = "id";

                this.Hide();
                Dispo.ShowDialog();
            }
        }
    }
}
