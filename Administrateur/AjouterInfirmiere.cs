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
    public partial class AjouterInfirmiere : Form
    {
        I_Administrateur obj;
        public AjouterInfirmiere()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestionInfirmiere gestionInf = new GestionInfirmiere();
            this.Hide();
            List<Infirmiere> infirmiers = obj.ListInfirmiere();
            gestionInf.LvInfirmiere.Items.Clear();

            foreach (Infirmiere n in infirmiers)
            {
                ListViewItem item = new ListViewItem(new string[] { n.IdInfirmiere.ToString(), n.Nom, n.Prenom, n.Email });
                item.Tag = n;

                gestionInf.LvInfirmiere.Items.Add(item);
            }
            gestionInf.ShowDialog();
        }

        private void BtnAjouterInfirmiere_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            Infirmiere infirmiere = new Infirmiere(nom, prenom, email, password);
            int idInfirmiere = obj.InserInfirmiereIntoPersonne(infirmiere);
            if(idInfirmiere != 0)
            {
                infirmiere = new Infirmiere(idInfirmiere);
                if (obj.AjouterInfirmiere(infirmiere))
                {
                    GestionInfirmiere gestionInfirmiere = new GestionInfirmiere();
                    List<Infirmiere> infirmiers = obj.ListInfirmiere();
                    gestionInfirmiere.LvInfirmiere.Items.Clear();

                    foreach (Infirmiere n in infirmiers)
                    {
                        ListViewItem item = new ListViewItem(new string[] { n.IdInfirmiere.ToString(), n.Nom,n.Prenom, n.Email});
                        item.Tag = n;

                        gestionInfirmiere.LvInfirmiere.Items.Add(item);
                    }
                    this.Hide();
                    gestionInfirmiere.ShowDialog();
                }
            }
        }
    }
}
