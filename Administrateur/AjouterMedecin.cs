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
    public partial class AjouterMedecin : Form
    {
        I_Administrateur obj;
        public static int id;
        public AjouterMedecin()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestionMedecin gestion = new GestionMedecin();
            List<Medecin> medecins = obj.ListMedecins();
            gestion.LvMedecins.Items.Clear();

            foreach (Medecin m in medecins)
            {
                ListViewItem item = new ListViewItem(new string[] { m.IdMedecin.ToString(), m.Nom, m.Prenom, m.Email, m.SpecialiteNom });
                item.Tag = m;

                gestion.LvMedecins.Items.Add(item);
            }

            this.Hide();
            gestion.ShowDialog();
        }

        //====================================================================================================

        // button pour ajouter Medecin dans la BD

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {
            string nomMedecin = textBoxNom.Text;
            string prenomMedecin = textBoxPrenom.Text;
            string emailMedecin = textBoxEmail.Text;
            int idSpecialite = int.Parse(comboBoxSpecialite.SelectedValue.ToString());
            string password = textBoxPassword.Text;

            Medecin InfoPersonne = new Medecin(nomMedecin, prenomMedecin, emailMedecin, password);
            int idMedecin = obj.InsertIntoPersonne(InfoPersonne);

            if(idMedecin == 0)
            {
                MessageBox.Show("impossible d'ajouter Medecin");
                return;
            }else
            {
                Medecin med = new Medecin(idMedecin, idSpecialite);
                bool verify = obj.AjouterMedecin(med);

                if (verify)
                {
                    
                    id = idMedecin;
                    CreaneauxMedecin creneaux = new CreaneauxMedecin(id);
                    creneaux.lblNomMedecin.Text = "Les creneaux pour M." + nomMedecin;
                    

                    this.Hide();
                    creneaux.ShowDialog();
                }
                else
                {
                    MessageBox.Show("impossible d'ajouter Medecin, idMedecin:"+med.IdMedecin+", idSpecialite: "+med.IdSpecialite);
                    return;
                }
            }
            
        }
    }
}
