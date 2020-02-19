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
    public partial class GestionPatient : Form
    {
        I_Administrateur obj;
        private Patient currentPatient;
        public GestionPatient()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainAdmin mainAdmin = new MainAdmin();
                this.Hide();
                mainAdmin.ShowDialog();
            }
        }

        private void BtnAjouterPatient_Click(object sender, EventArgs e)
        {
            AjouterPatient ajouterPatient = new AjouterPatient();
            List<Specialite> specialites = obj.ListSpecialite();
            ajouterPatient.comboBoxTypeMaladie.DataSource = specialites;
            ajouterPatient.comboBoxTypeMaladie.DisplayMember = "NomSpecialite";
            ajouterPatient.comboBoxTypeMaladie.ValueMember = "IdSpecialite";

            this.Hide();
            ajouterPatient.ShowDialog();

        }

        private void lvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPatients.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPatients.SelectedItems[0];
                currentPatient = (Patient)item.Tag;
            }
        }

        private void BtnSupprimerPatient_Click(object sender, EventArgs e)
        {
            if(currentPatient == null)
            {
                MessageBox.Show("vous n'avez selectionner un patient !");
                return;
            }else
            {
                if(MessageBox.Show("voulez vous supprimer ce patient ?", "supprimer Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obj.supprimerPatient(currentPatient))
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
                    }else
                    {
                        MessageBox.Show("Patient n'a pas été supprimer", "Remove row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnModifierPatient_Click(object sender, EventArgs e)
        {
            if(currentPatient == null)
            {
                MessageBox.Show("SVP selectionne un patient !");
                return;
            }
            else
            {
                UpdatePatient updatePatient = new UpdatePatient();

                int id = int.Parse(lvPatients.SelectedItems[0].SubItems[0].Text);
                string nom = lvPatients.SelectedItems[0].SubItems[1].Text;
                string prenom = lvPatients.SelectedItems[0].SubItems[2].Text;
                int age = int.Parse(lvPatients.SelectedItems[0].SubItems[3].Text);
                string maladie = lvPatients.SelectedItems[0].SubItems[4].Text;

                updatePatient.textBoxId.Text = id.ToString();
                updatePatient.textBoxNom.Text = nom;
                updatePatient.textBoxPrenom.Text = prenom;
                updatePatient.textBoxAge.Text = age.ToString();


                List<Specialite> specialites = obj.ListSpecialite();
                updatePatient.comboBoxSpecialite.DataSource = specialites;
                updatePatient.comboBoxSpecialite.DisplayMember = "NomSpecialite";
                updatePatient.comboBoxSpecialite.ValueMember = "IdSpecialite";

                this.Hide();
                updatePatient.ShowDialog();
            }
            


            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdmin = new MainAdmin();
            this.Hide();
            mainAdmin.ShowDialog();
        }
    }
}
