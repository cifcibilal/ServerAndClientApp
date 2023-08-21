using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Globalization;

namespace ServerAndClientApp
{
    public partial class Form1 : Form
    {
        public Thread thread;
        public IPAddress _IPaddress;
        public TcpListener dinle;
        public Socket socket;
        public NetworkStream ag;
        public StreamReader oku;
        public StreamWriter yaz;
        public delegate void ricdegis(string text);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void okumayaBasla()
        {
            socket = dinle.AcceptSocket();
            ag = new NetworkStream(socket);
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch
                {
                    return;
                }
            }
        }
        public void ekranabas(string yazi)
        {
            if(this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, yazi);
            }
            else
            {
                yazi = "Client: " + yazi + " ";
                txtGelenMesaj.AppendText(yazi + "\n");
            }
        }
        private void dinlemeyeBasla()
        {
            try
            {
                _IPaddress = IPAddress.Parse(txtIP.Text);
                dinle = new TcpListener(_IPaddress,Convert.ToInt32(txtPort.Text));
                dinle.Start();
                thread = new Thread(new ThreadStart(okumayaBasla));
                thread.Start();
                txtGelenMesaj.AppendText(DateTime.Now.ToString() + " \nDinleme baslatildi...\n");
            }
            catch (Exception)
            {
                MessageBox.Show(" \nDinleme baslatilamadi");
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            dinlemeyeBasla();
        }

        private void btnAyril_Click(object sender, EventArgs e)
        {
            ag.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if(txtGonderilenMesaj.Text == "")
            {
                return;
            }
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(txtGonderilenMesaj.Text);
                yaz.Flush();
                //txtGelenMesaj.AppendText(txtGonderilenMesaj.Text + "\n");
                txtGonderilenMesaj.Text = "";
            }
        }
    }
}
