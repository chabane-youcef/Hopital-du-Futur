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
    public partial class MedecinsDiponibles : Form
    {
        I_Infirmiere obj;
        Medecin currentMedecin = null;
        public MedecinsDiponibles()
        {
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainInfirmiere mainInf = new MainInfirmiere();
            this.Hide();
            mainInf.ShowDialog();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spec = comboBoxSearch.Text;
            if (spec.Equals("tout"))
            {
                List<Medecin> MedecinsParSpecialite = obj.MedecinsDiponibles();
                listViewMedecins.Items.Clear();

                foreach (Medecin m in MedecinsParSpecialite)
                {
                    ListViewItem item = new ListViewItem(new string[] { m.id.ToString(), m.nom, m.prenom, m.specialite });
                    item.Tag = m;
                    listViewMedecins.Items.Add(item);
                }
            }
            else{
                List<Medecin> MedecinsParSpecialite = obj.ListMedecinsParSepcialite(spec);

                listViewMedecins.Items.Clear();

                foreach (Medecin m in MedecinsParSpecialite)
                {
                    ListViewItem item = new ListViewItem(new string[] { m.id.ToString(), m.nom, m.prenom, m.specialite });
                    item.Tag = m;
                    listViewMedecins.Items.Add(item);
                }
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

        private void btnConsulterCreneaux_Click(object sender, EventArgs e)
        {
            if(currentMedecin == null)
            {
                MessageBox.Show("svp selectionne un medecin !");
                return;
            }else
            {
                int idMedecin = currentMedecin.id;

                CreneauxMedecin creneaux = new CreneauxMedecin(idMedecin);
                List<Creneaux> creneauxMedecin = obj.ListCreneauxMedecin(idMedecin);
                
                creneaux.lvCreneaux.Items.Clear();
                foreach(Creneaux c in creneauxMedecin)
                {
                    if(c.etat == true)
                    {
                        ListViewItem item = new ListViewItem(new string[] { c.id.ToString(), c.jour, c.date, c.debut, "reserve" });
                        item.SubItems[4].BackColor = Color.Red;
                        
                        item.Tag = c;
                        creneaux.lvCreneaux.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new string[] { c.id.ToString(), c.jour, c.date, c.debut, "libre" });
                        item.SubItems[4].BackColor= Color.Green;
                        
                        item.Tag = c;
                        creneaux.lvCreneaux.Items.Add(item);
                    }

                }

                this.Hide();
                creneaux.ShowDialog();
            }
        }
    }
}
