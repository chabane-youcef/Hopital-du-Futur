using RemoteMedecin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace User_Medecin
{
    public partial class MainMedecin : Form
    {
        I_Medecin objMedecin;
        private int currentIdMedecin = 0;
        public MainMedecin(int idMedecin)
        {
            this.currentIdMedecin = idMedecin;
            InitializeComponent();
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void BtnConsulterRendezVous_Click(object sender, EventArgs e)
        {
            List<RendezVous> rendezVous = objMedecin.ListRendezvous(currentIdMedecin);
            ConsulterRendezVous consulterRendez = new ConsulterRendezVous(currentIdMedecin);

            consulterRendez.listRendezvous.Items.Clear();

            foreach(RendezVous r in rendezVous)
            {
                ListViewItem item = new ListViewItem(new string[] { r.id.ToString(), r.idPatient.ToString(), r.NomPatient, r.PrenomPatient, r.JourRendezvous, r.dateConsultation, r.debutConsultation });
                item.Tag = r;
                consulterRendez.listRendezvous.Items.Add(item);
            }

            this.Hide();
            consulterRendez.ShowDialog();

        }

        private void BtnConsulterPatietns_Click(object sender, EventArgs e)
        {
            historiqueConsultations historique = new historiqueConsultations(currentIdMedecin);
            List<Patient> patients = objMedecin.listPatients(currentIdMedecin);

            historique.listPatients.Items.Clear();

            foreach(Patient p in patients)
            {
                ListViewItem item = new ListViewItem(new string[] { p.id.ToString(),p.idPatient.ToString(), p.nom, p.prenom, p.age.ToString(), p.countConsutlations.ToString() });
                item.Tag = p;
                historique.listPatients.Items.Add(item);
            }
            this.Hide();
            historique.ShowDialog();

        }

        private void btnUrgence_Click(object sender, EventArgs e)
        {
            List<Patient> urgences = objMedecin.ListUrgence(currentIdMedecin);
            Urgences FormUrgences = new Urgences(currentIdMedecin);

            FormUrgences.listViewUrgences.Items.Clear();

            foreach(Patient p in urgences)
            {
                ListViewItem item = new ListViewItem(new string[] { p.idUrgence.ToString(), p.nom, p.prenom, p.age.ToString(), p.maladie });
                item.Tag = p;
                FormUrgences.listViewUrgences.Items.Add(item);
            }

            this.Hide();
            FormUrgences.ShowDialog();
        }
    }
}
