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
    public partial class CreaneauxMedecin : Form
    {
        I_Administrateur obj;
        int id { get; set; }
        public CreaneauxMedecin()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        public CreaneauxMedecin(int id)
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
            this.id = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("if faut choisir les creneaux de Medecin !");
        }


        private int NumAllowedOptions = 3;
        private List<CheckBox> Selections = new List<CheckBox>();

        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                // Add this selection.
                Selections.Add(chk);

                // Make sure we don't have too many.
                if (Selections.Count > NumAllowedOptions)
                {
                    // Remove the oldest selection.
                    Selections[0].Checked = false;
                }
            }
            else
            {
                // Remove this selection.
                Selections.Remove(chk);
            }
        }

        
        

        private void btnEnregistrerCreneaux_Click(object sender, EventArgs e)
        {
            List<Creneaux> heures = new List<Creneaux>();
            heures.Add(new Creneaux("09:00:00", "10:00:00"));
            heures.Add(new Creneaux("10:00:00", "11:00:00"));
            heures.Add(new Creneaux("11:00:00", "12:00:00"));
            heures.Add(new Creneaux("13:00:00", "14:00:00"));
            heures.Add(new Creneaux("14:00:00", "15:00:00"));
            heures.Add(new Creneaux("15:00:00", "16:00:00"));
            
            foreach (CheckBox check in Selections)
            {
                string r = check.Name;
                string aujoudhui = DateTime.Now.ToString("dddd");
                DateTime time = DateTime.Now;

                switch (aujoudhui)
                {
                    // gestion de aujourd'hui = dimanche
                    case "dimanche":

                        if (r.Equals("dimanche"))
                        {
                            time = DateTime.Today;
                        }
                        else if (r.Equals("lundi"))
                        {
                            time = DateTime.Today.AddDays(1);
                        }
                        else if (r.Equals("mardi"))
                        {
                            time = DateTime.Today.AddDays(2);
                        }
                        else if (r.Equals("mercredi"))
                        {
                            time = DateTime.Today.AddDays(3);
                        }
                        else if (r.Equals("jeudi"))
                        {
                            time = DateTime.Today.AddDays(4);
                        }
                        else if (r.Equals("vendredi"))
                        {
                            time = DateTime.Today.AddDays(5);
                        }
                        else if (r.Equals("samedi"))
                        {
                            time = DateTime.Today.AddDays(6);
                        }

                        break;
                    // gestion de aujourd'hui = lundi
                    case "lundi":

                        if (r.Equals("lundi"))
                        {
                            time = DateTime.Today;
                        }
                        else if (r.Equals("mardi"))
                        {
                            time = DateTime.Today.AddDays(1);
                        }
                        else if (r.Equals("merdcredi"))
                        {
                            time = DateTime.Today.AddDays(2);
                        }
                        else if (r.Equals("jeudi"))
                        {
                            time = DateTime.Today.AddDays(3);
                        }
                        else if (r.Equals("vendredi"))
                        {
                            time = DateTime.Today.AddDays(4);
                        }
                        else if (r.Equals("samedi"))
                        {
                            time = DateTime.Today.AddDays(5);
                        }
                        else if (r.Equals("dimanche"))
                        {
                            time = DateTime.Today.AddDays(6);
                        }

                        break;
                    // gestion de aujourd'hui = mardi
                    case "mardi":

                        if (r.Equals("mardi"))
                        {
                            time = DateTime.Today;
                        }
                        else if (r.Equals("mercredi"))
                        {
                            time = DateTime.Today.AddDays(1);
                        }
                        else if (r.Equals("jeudi"))
                        {
                            time = DateTime.Today.AddDays(2);
                        }
                        else if (r.Equals("vendredi"))
                        {
                            time = DateTime.Today.AddDays(3);
                        }
                        else if (r.Equals("samedi"))
                        {
                            time = DateTime.Today.AddDays(4);
                        }
                        else if (r.Equals("dimanche"))
                        {
                            time = DateTime.Today.AddDays(5);
                        }
                        else if (r.Equals("lundi"))
                        {
                            time = DateTime.Today.AddDays(6);
                        }

                        break;
                    // gestion de aujourd'hui = mercredi
                    case "mercredi":

                        if (r.Equals("mercredi"))
                        {
                            time = DateTime.Today;
                        }
                        else if (r.Equals("jeudi"))
                        {
                            time = DateTime.Today.AddDays(1);
                        }
                        else if (r.Equals("vendredi"))
                        {
                            time = DateTime.Today.AddDays(2);
                        }
                        else if (r.Equals("samedi"))
                        {
                            time = DateTime.Today.AddDays(3);
                        }
                        else if (r.Equals("dimanche"))
                        {
                            time = DateTime.Today.AddDays(4);
                        }
                        else if (r.Equals("lundi"))
                        {
                            time = DateTime.Today.AddDays(5);
                        }
                        else if (r.Equals("mardi"))
                        {
                            time = DateTime.Today.AddDays(6);
                        }

                        break;
                    // gestion de aujourd'hui = jeudi
                    case "jeudi":

                        if (r.Equals("jeudi"))
                        {
                            time = DateTime.Today;
                        }
                        else if (r.Equals("vendredi"))
                        {
                            time = DateTime.Today.AddDays(1);
                        }
                        else if (r.Equals("samedi"))
                        {
                            time = DateTime.Today.AddDays(2);
                        }
                        else if (r.Equals("dimanche"))
                        {
                            time = DateTime.Today.AddDays(3);
                        }
                        else if (r.Equals("lundi"))
                        {
                            time = DateTime.Today.AddDays(4);
                        }
                        else if (r.Equals("mardi"))
                        {
                            time = DateTime.Today.AddDays(5);
                        }
                        else if (r.Equals("mercredi"))
                        {
                            time = DateTime.Today.AddDays(6);
                        }

                        break;
                    // gestion de aujourd'hui = vendredi
                    case "vendredi":

                        if (r.Equals("vendredi"))
                        {
                            time = DateTime.Today;
                        }
                        else if (r.Equals("samedi"))
                        {
                            time = DateTime.Today.AddDays(1);
                        }
                        else if (r.Equals("dimanche"))
                        {
                            time = DateTime.Today.AddDays(2);
                        }
                        else if (r.Equals("lundi"))
                        {
                            time = DateTime.Today.AddDays(3);
                        }
                        else if (r.Equals("mardi"))
                        {
                            time = DateTime.Today.AddDays(4);
                        }
                        else if (r.Equals("mercredi"))
                        {
                            time = DateTime.Today.AddDays(5);
                        }
                        else if (r.Equals("jeudi"))
                        {
                            time = DateTime.Today.AddDays(6);
                        }

                        break;
                    // gestion de aujourd'hui = samedi
                    case "samedi":

                        if (r.Equals("samedi"))
                        {
                            time = DateTime.Today;
                        }
                        else if (r.Equals("dimanche"))
                        {
                            time = DateTime.Today.AddDays(1);
                        }
                        else if (r.Equals("lundi"))
                        {
                            time = DateTime.Today.AddDays(2);
                        }
                        else if (r.Equals("mardi"))
                        {
                            time = DateTime.Today.AddDays(3);
                        }
                        else if (r.Equals("mercredi"))
                        {
                            time = DateTime.Today.AddDays(4);
                        }
                        else if (r.Equals("jeudi"))
                        {
                            time = DateTime.Today.AddDays(5);
                        }
                        else if (r.Equals("vendredi"))
                        {
                            time = DateTime.Today.AddDays(6);
                        }

                        break;
                }

                foreach (Creneaux heur in heures)
                {
                    string date = time.ToString("yyyy-MM-dd");
                    Creneaux creneau = new Creneaux(id, check.Name, heur.debut, heur.fin,date);
                    
                    obj.AjouterCreneaux(creneau);
                }
            }

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
    }
}
