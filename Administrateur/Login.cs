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
using RemoteAdministrateur;

namespace Administrateur
{
    public partial class Login : Form
    {
        I_Administrateur obj;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (obj.Login(email, password))
            {
                MainAdmin nextForum = new MainAdmin();
                this.Hide();
                nextForum.ShowDialog();
            }else
            {
                this.Close();
            }



        }

        private void Login_Load(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }
    }
}
