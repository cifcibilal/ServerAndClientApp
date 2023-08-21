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
        public TcpClient baglantiKur;
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
            ag = baglantiKur.GetStream();
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        public void ekranabas(string yazi)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, yazi);
            }
            else
            {
                yazi = "Server: " + yazi + " ";
                txtGelenMesaj.AppendText(yazi + "\n");
            }
        }
        public void baglanti_kur()
        {
            try
            {
                baglantiKur = new TcpClient(txtIP.Text, Convert.ToInt32(txtPort.Text));
                thread = new Thread(new ThreadStart(okumayaBasla));
                thread.Start();
                txtGelenMesaj.AppendText(DateTime.Now.ToString() + " Baglanti kuruldu... \n");
            }
            catch (Exception)
            {
                MessageBox.Show("Server ile baglanti kurulurken hata olustu... \n");
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            baglanti_kur();
        }

        private void btnAyril_Click(object sender, EventArgs e)
        {
            baglantiKur.Client.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtGonderilenMesaj.Text == "")
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
