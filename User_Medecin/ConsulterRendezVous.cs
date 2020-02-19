using RemoteMedecin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Medecin
{
    public partial class ConsulterRendezVous : Form
    {
        RendezVous CurrentPatient = null;
        private int currentIdMedecin = 0;
        I_Medecin objMedecin;
        public ConsulterRendezVous(int idMedecin)
        {
            this.currentIdMedecin = idMedecin;
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainMedecin mainMed = new MainMedecin(currentIdMedecin);
                this.Hide();
                mainMed.ShowDialog();
            }
        }

        private void supprimerRendezvousBtn_Click(object sender, EventArgs e)
        {
            if(CurrentPatient == null)
            {
                MessageBox.Show("svp selectionner un patient!");
                return;
            }else
            {
                if (MessageBox.Show("voulez vous supprimer cette rendez vous ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (objMedecin.SupprimerRendezVous(CurrentPatient))
                    {
                        MessageBox.Show("rendez vous a ete supprimer!");

                        List<RendezVous> rendezVous = objMedecin.ListRendezvous(currentIdMedecin);
                        ConsulterRendezVous consulterRendez = new ConsulterRendezVous(currentIdMedecin);

                        consulterRendez.listRendezvous.Items.Clear();

                        foreach (RendezVous r in rendezVous)
                        {
                            ListViewItem item = new ListViewItem(new string[] { r.id.ToString(), r.NomPatient, r.PrenomPatient, r.JourRendezvous, r.dateConsultation, r.debutConsultation });
                            item.Tag = r;
                            consulterRendez.listRendezvous.Items.Add(item);
                        }

                        this.Hide();
                        consulterRendez.ShowDialog();
                    }
                }
            }
        }

        private void listRendezvous_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listRendezvous.SelectedItems.Count > 0)
            {
                ListViewItem item = listRendezvous.SelectedItems[0];
                CurrentPatient = (RendezVous)item.Tag;
            }
        }

        private void consulterPatientBtn_Click(object sender, EventArgs e)
        {
            if(CurrentPatient != null)
            {
                ConsultationPatient consultation = new ConsultationPatient(currentIdMedecin,CurrentPatient);

                consultation.textBoxNom.Text = CurrentPatient.NomPatient;
                consultation.textBoxPrenom.Text = CurrentPatient.PrenomPatient;

                string[] maladies = { "Kératoses", "Alopécie", "Couperose", "Leishmaniose", "Mastocytose", "Verrue", "Tungose", "Érythrodermie", "Scléroses", "Macules", "Vésicules", "Photodermatose" };
                Random random = new Random();
                int index = random.Next(maladies.Length);
                string maladie = maladies[index];
                consultation.comboBoxTraitement.Items.Clear();
                consultation.textBoxMaladie.Text = maladie;

                List<Pourcentage> pourcentages = new List<Pourcentage>();
                pourcentages.Add(new Pourcentage("10", 10));
                pourcentages.Add(new Pourcentage("20", 20));
                pourcentages.Add(new Pourcentage("30", 30));
                pourcentages.Add(new Pourcentage("40", 40));
                pourcentages.Add(new Pourcentage("50", 50));
                pourcentages.Add(new Pourcentage("60", 60));
                pourcentages.Add(new Pourcentage("70", 70));
                pourcentages.Add(new Pourcentage("80", 80));
                pourcentages.Add(new Pourcentage("90", 90));
                pourcentages.Add(new Pourcentage("100", 100));

                
                consultation.comboBoxTraitement.Items.Add(pourcentages);
                consultation.comboBoxTraitement.DataSource = pourcentages;
                consultation.comboBoxTraitement.DisplayMember = "afficahge";
                consultation.comboBoxTraitement.ValueMember = "value";

                this.Hide();
                consultation.ShowDialog();

            }
            else
            {
                MessageBox.Show("svp selectionner un rendez vous");
                return;
            }
        }
    }
}
