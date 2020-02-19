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
    public partial class Urgence : Form
    {
        I_Infirmiere obj;
        Medecin currentMedecin;
        public Urgence()
        {
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainInfirmiere mainInfirmiere = new MainInfirmiere();
            this.Hide();
            mainInfirmiere.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            int age = int.Parse(textBoxAge.Text);
            int idMaladie = int.Parse(comboBoxMaladies.SelectedValue.ToString());
            MessageBox.Show("nom:" + nom + ",prenom: " + prenom + ",age: " + age + ",idmaladie: " + idMaladie+",idMedecin: "+currentMedecin.id);
            Patient patient = new Patient(nom, prenom, idMaladie,age, currentMedecin.id);

            int idPatient = obj.InsertionUrgence(patient);
            if (idPatient != 0)
            {
                if (obj.EnregistrerUrgence(idPatient, patient))
                {
                    MainInfirmiere mainInfirmiere = new MainInfirmiere();
                    this.Hide();
                    mainInfirmiere.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("svp enter les données un autre fois");
                return;
            }

        }

        private void listViewMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMedecins.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewMedecins.SelectedItems[0];
                currentMedecin = (Medecin)item.Tag;
            }
        }
    }
}
