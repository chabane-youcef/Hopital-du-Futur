using RemoteAdministrateur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrateur
{
    public partial class GestionMedecin : Form
    {
        I_Administrateur obj;
        public GestionMedecin()
        {
            InitializeComponent();
            /*TcpChannel channelManager = new TcpChannel();
            ChannelServices.RegisterChannel(channelManager, false);*/

            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        /*private void GestionMedecin_Load(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }*/

        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainAdmin mainAdmin = new MainAdmin();
                this.Hide();
                mainAdmin.ShowDialog();
            }
            
        }

        

        private void btnAddMedecin_Click(object sender, EventArgs e)
        {
            AjouterMedecin ajouterMed = new AjouterMedecin();
            List<Specialite> specialites = obj.ListSpecialite();

            ajouterMed.comboBoxSpecialite.DataSource = specialites;
            ajouterMed.comboBoxSpecialite.DisplayMember = "NomSpecialite";
            ajouterMed.comboBoxSpecialite.ValueMember = "IdSpecialite";
            this.Hide();
            ajouterMed.ShowDialog();
        }

        private void btnUpdateMedecin_Click(object sender, EventArgs e)
        {
            if(LvMedecins.SelectedItems.Count > 0)
            {
                int id = int.Parse(LvMedecins.SelectedItems[0].SubItems[0].Text);
                string nom = LvMedecins.SelectedItems[0].SubItems[1].Text;
                string prenom = LvMedecins.SelectedItems[0].SubItems[2].Text;
                string email = LvMedecins.SelectedItems[0].SubItems[3].Text;
                string specialite = LvMedecins.SelectedItems[0].SubItems[4].Text;

                UpdateMedecin updateMedecin = new UpdateMedecin();

                updateMedecin.textBoxId.Text = id.ToString();
                updateMedecin.textBoxNom.Text = nom;
                updateMedecin.textBoxPrenom.Text = prenom;
                updateMedecin.textBoxEmail.Text = email;

                List<Specialite> specialites = obj.ListSpecialite();
                updateMedecin.comboBoxSpecialite.Items.Add(specialite);
                updateMedecin.comboBoxSpecialite.DataSource = specialites;
                updateMedecin.comboBoxSpecialite.DisplayMember = "NomSpecialite";
                updateMedecin.comboBoxSpecialite.ValueMember = "IdSpecialite";

                this.Hide();
                updateMedecin.ShowDialog();

            }
        }

        private void LvMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LvMedecins.SelectedItems.Count > 0)
            {
                ListViewItem item = LvMedecins.SelectedItems[0];
                
            }
        }

        private void btnDeleteMedecin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdmin = new MainAdmin();
            this.Hide();
            mainAdmin.ShowDialog();
        }
    }
}
