using RemoteMedecin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace User_Medecin
{
    public partial class ConsultationPatient : Form
    {
        int currentIdMedecin = 0;
        int idPatientConsulte = 0;
        RendezVous rendez = null;
        I_Medecin objMedecin;
        public ConsultationPatient(int currentIdMedecin,RendezVous rendez)
        {
            this.currentIdMedecin = currentIdMedecin;
            this.rendez = rendez;
            idPatientConsulte = rendez.idPatient;
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<RendezVous> rendezVous = objMedecin.ListRendezvous(currentIdMedecin);
                ConsulterRendezVous consulterRendez = new ConsulterRendezVous(currentIdMedecin);

                consulterRendez.listRendezvous.Items.Clear();

                foreach (RendezVous r in rendezVous)
                {
                    ListViewItem item = new ListViewItem(new string[] { r.id.ToString(), r.idPatient.ToString(), r.NomPatient, r.PrenomPatient, r.JourRendezvous, r.dateConsultation, r.debutConsultation });
                    item.Tag = r;
                    consulterRendez.listRendezvous.Items.Add(item);
                }

                this.Hide();
                consulterRendez.ShowDialog();
            }
        }

        private void btnEnregistrementEtat_Click(object sender, EventArgs e)
        {
            string note = textBoxNote.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            int traitement = int.Parse(comboBoxTraitement.SelectedValue.ToString());
            EtatPatient ep = new EtatPatient(idPatientConsulte,rendez.id, traitement, note, date);

            if (objMedecin.EnregistrerEtat(ep))
            {
                MessageBox.Show("patient a ete consulter!");

                List<RendezVous> rendezVous = objMedecin.ListRendezvous(currentIdMedecin);
                ConsulterRendezVous consulterRendez = new ConsulterRendezVous(currentIdMedecin);

                consulterRendez.listRendezvous.Items.Clear();

                foreach (RendezVous r in rendezVous)
                {
                    ListViewItem item = new ListViewItem(new string[] { r.id.ToString(), r.idPatient.ToString(), r.NomPatient, r.PrenomPatient, r.JourRendezvous, r.dateConsultation, r.debutConsultation });
                    item.Tag = r;
                    consulterRendez.listRendezvous.Items.Add(item);
                }

                this.Hide();
                consulterRendez.ShowDialog();
            }
        }
    }
}
