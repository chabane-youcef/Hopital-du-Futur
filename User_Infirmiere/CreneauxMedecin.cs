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
    public partial class CreneauxMedecin : Form
    {
        int idMedecin { get; set; }
        I_Infirmiere obj;
        public CreneauxMedecin()
        {
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        public CreneauxMedecin(int idMedecin)
        {
            this.idMedecin = idMedecin;
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        Creneaux CurrentCreneaux = null;
        private void lvCreneaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCreneaux.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCreneaux.SelectedItems[0];
                CurrentCreneaux = (Creneaux)item.Tag;
                if(CurrentCreneaux.etat == true){
                    MessageBox.Show("svp selectionner un rendez vous disponible!");
                    
                    
                }
            }
        }

        private void btnReserverCreneaux_Click(object sender, EventArgs e)
        {
            selectionnerPatient selectionner = new selectionnerPatient(CurrentCreneaux.id, idMedecin);
            List<Patient> listPatients = obj.listPatientDisponibles();

            selectionner.textBoxJourCreneaux.Text = CurrentCreneaux.jour;
            selectionner.textBoxHeureCreneaux.Text = CurrentCreneaux.debut;
            selectionner.textBoxDateCreneaux.Text = CurrentCreneaux.date;

            selectionner.lvPatients.Items.Clear();

            foreach (Patient p in listPatients)
            {
                ListViewItem item = new ListViewItem(new string[] { p.id.ToString(), p.nom, p.prenom, p.age.ToString()});
                item.Tag = p;
                selectionner.lvPatients.Items.Add(item);
            }

            this.Hide();
            selectionner.ShowDialog();

        }
    }
}
