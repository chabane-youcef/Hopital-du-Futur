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
    public partial class SelectionnerCreneaux : Form
    {
        I_Infirmiere obj;
        I_Infirmiere_Events objEvent;
        private Patient selectedPatient = null;
        private Medecin selectedMedecin = null;
        private Creneaux CurrentCreneaux = null;

        public SelectionnerCreneaux()
        {
            InitializeComponent();
        }

        public SelectionnerCreneaux(Patient p, Medecin m)
        {
            InitializeComponent();
            this.selectedPatient = p;
            this.selectedMedecin = m;
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
            objEvent = (I_Infirmiere_Events)Activator.GetObject(typeof(I_Infirmiere_Events), "tcp://localhost:7744/ObjEventInfirmiereMedecin");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainInfirmiere mainInf = new MainInfirmiere();
            if (MessageBox.Show("voulez vous retourner vers acceul ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();
                mainInf.ShowDialog();
            }
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            if(CurrentCreneaux != null)
            {
                if (MessageBox.Show(string.Format("voulez vous reservez cette Creneaux pour M.{0} ?", selectedPatient.nom), "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EventMedecinInfirmiere.RendezVous rendezvous = new EventMedecinInfirmiere.RendezVous(CurrentCreneaux.id, selectedMedecin.id, selectedPatient.id);
                    if (objEvent.ReserverCreneaux(rendezvous))
                    {
                        List<Patient> listPatients = obj.listPatientDisponibles();
                        AffichagePatients patients = new AffichagePatients();

                        patients.listViewPatients.Items.Clear();

                        foreach (Patient p in listPatients)
                        {
                            ListViewItem item = new ListViewItem(new String[] { p.id.ToString(), p.nom, p.prenom, p.age.ToString() });
                            item.Tag = p;
                            patients.listViewPatients.Items.Add(item);
                        }

                        this.Hide();
                        patients.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("svp selectionner creneau!");
                return;
            }

        }

        private void listCreneauxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listCreneauxMedecin.SelectedItems.Count > 0)
            {
                ListViewItem item = listCreneauxMedecin.SelectedItems[0];
                CurrentCreneaux = (Creneaux)item.Tag;
            }
        }
    }
}
