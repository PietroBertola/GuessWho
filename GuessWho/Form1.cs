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
using System.Text.RegularExpressions;

namespace GuessWho
{
    public delegate void aggiornaGraficaEventHandler(clsMessaggio Msg);
    public partial class Form1 : Form
    {
        private clsSocket serverSocket;
        Regex rgx = new Regex("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsAddress.cercaIP();
            lblIp.Text= clsAddress.ipVett[0].ToString()+":8080";
            IPAddress ip;

            if (serverSocket == null)
            {
                ip = clsAddress.ipVett[0];

                // Istanzio il Server Socket
                serverSocket = new clsSocket(true,8080, ip);

                serverSocket.datiRicevutiEvent += new datiRicevutiEventHandler(datiRicevuti);
            }

            // Richiamo la Procedura di Avvio del Server
            serverSocket.avviaServer();
            lblStatoServer.Text = "RUNNING";
        }
        private void datiRicevuti(clsMessaggio inMsg)
        {
            DialogResult dr = MessageBox.Show("Vuoi giocare con "+inMsg.ToString()+"?",
                      "Richiesta", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    aggiornaGraficaEventHandler pt = new aggiornaGraficaEventHandler(aggiornaGrafica);
                    this.Invoke(pt, inMsg);
                    break;
                case DialogResult.No:
                    break;
            }

            
        }

        private void aggiornaGrafica(clsMessaggio inMsg)
        {
            // Riporto il Messaggio ricevuto dal Client nella
            //    Lista dei Messaggi ricevuti sul Server
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            if (rgx.IsMatch(txtIp.Text) == true)
            {
                IPAddress ip;
                clsSocket clientSocket;
                clsMessaggio MsgFromServer;


                ip = clsAddress.cercaIP(txtIp.Text);
                clientSocket = new clsSocket(false, Convert.ToInt16("8080"), ip);
                // Invio il Messaggio al SERVER
                clientSocket.inviaMsg(lblIp.Text);

                // Aspetto la Risposta del SERVER
                MsgFromServer = clientSocket.clientRicevi();

                // Facoltativo !!
                MessageBox.Show("CONNESSO");

            }
            else
                MessageBox.Show("nope");
        }
    }

}
