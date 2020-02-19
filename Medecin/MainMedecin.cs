using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventMedecinInfirmiere;

namespace Medecin
{
    public partial class MainMedecin : Form
    {
        public I_Infirmiere_Events objEvent;
        public EventProxy eventProxy;
        public BinaryClientFormatterSinkProvider clientProvider;
        public BinaryServerFormatterSinkProvider serverProvider;
        private delegate void setBoxText(string m);



        public MainMedecin()
        {
            InitializeComponent();
                clientProvider = new BinaryClientFormatterSinkProvider();
                serverProvider = new BinaryServerFormatterSinkProvider();
                serverProvider.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
                objEvent = (I_Infirmiere_Events)Activator.GetObject(typeof(I_Infirmiere_Events), "tcp://localhost:7744/ObjEventInfirmiereMedecin");
                eventProxy = new EventProxy();
            try
            {
                objEvent.RendezVousArrived += new RendezvousArrivedEvent(eventProxy.LocallyHandelRendezVousArrived);
                eventProxy.RendezVousArrived += new RendezvousArrivedEvent(eventProxy_ArrivedRendezVous);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            
            
         void eventProxy_ArrivedRendezVous(RendezVous rv)
        {
            setTextBox("mchat");
        }
            
            
        }


        private void setTextBox(string m)
        {
            if (label4.InvokeRequired)
            {
                this.BeginInvoke(new setBoxText(setTextBox), new object[] { m });
                return;
            }
            else
                label4.Text = m;
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
