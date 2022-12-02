using Esercizio01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace GuessWho
{
    public delegate void aggiornaGraficaEventHandler(clsMessaggio Msg);
    public partial class Form1 : Form
    {
        private clsSocket serverSocket;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsAddress.cercaIP();
            txtIp.Text= clsAddress.ipVett[0].ToString()+":8888";
            IPAddress ip;

            if (serverSocket == null)
            {
                ip = clsAddress.ipVett[0];

                // Istanzio il Server Socket
                serverSocket = new clsSocket(true,8888, ip);

                serverSocket.datiRicevutiEvent += new datiRicevutiEventHandler(datiRicevuti);
            }

            // Richiamo la Procedura di Avvio del Server
            serverSocket.avviaServer();
            lblStatoServer.Text = "RUNNING";
        }
        private void datiRicevuti(clsMessaggio inMsg)
        {
            aggiornaGraficaEventHandler pt = new aggiornaGraficaEventHandler(aggiornaGrafica);
            this.Invoke(pt, inMsg);
        }

        private void aggiornaGrafica(clsMessaggio inMsg)
        {
            // Riporto il Messaggio ricevuto dal Client nella
            //    Lista dei Messaggi ricevuti sul Server
        }
    }

}
