using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace _21521081_TranNhutLinh_Exercise3
{
    public partial class ClientSide : Form
    {
        private Socket client;
        byte[] buff = new byte[1024];
        byte[] buff2 = new byte[1024];

        
        public ClientSide()
        {
            InitializeComponent();
            
            CheckForIllegalCrossThreadCalls = false;

        }

        private void update(string m)
        {
            lstView.Items.Add(m);
        }

        private void beginConnect(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            s.EndConnect(ar);
            lstView.Items.Add("Connection received from server " + s.RemoteEndPoint.ToString());
            string wc = "Hello server!!!";
            buff2 = Encoding.ASCII.GetBytes(wc);
            client.BeginSend(buff2, 0, buff2.Length, SocketFlags.None, new AsyncCallback(sendata), client);

            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
        }

        private void sendata(IAsyncResult ia)
        {
            client.EndSend(ia);
        }
        private void beginReceive(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            int recv = 0;
            recv = s.EndReceive(ia);
            btnDisconnect.Enabled = true;
            string recvei = Encoding.ASCII.GetString(buff, 0, recv);
            lstView.Items.Add("Server: " + recvei);
            if (recvei.ToUpper() == "")
            {
                lstView.Items.Add("Disconnecct to Server");
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            buff = new byte[1024];
            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
        }

        private void startClient()
        {
            EndPoint ep = new IPEndPoint(IPAddress.Parse(txtIPClient.Text), Int32.Parse(txtPort.Text));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            lstView.Items.Add("Connecting to the server...");
            client.BeginConnect(ep, new AsyncCallback(beginConnect), client);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            startClient();
            txtSend.Focus();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            lstView.Items.Add("Disconnect to server");
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            this.Close();
        }

        private void txtPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startClient();
            }
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();
            }
        }

        private void send()
        {
            string wc = txtSend.Text;
            byte[] gui = new byte[1024];
            gui = Encoding.ASCII.GetBytes(wc);
            txtSend.Clear();
            lstView.Items.Add("Client: " + wc);
            client.BeginSend(gui, 0, gui.Length, SocketFlags.None, new AsyncCallback(sendata), client);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            send();
            txtSend.Focus();
        }

        private void txtIPClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
