using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _21521081_TranNhutLinh_Exercise3
{
    public partial class ServerSide : Form
    {
        private Socket server, client;
        byte[] buff = new byte[1024];
        byte[] buff2 = new byte[1024];

        public ServerSide()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void startServer()
        {
            EndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ep);
            server.Listen(10);
            server.BeginAccept(new AsyncCallback(beginAccept), server);
            lstMess.Items.Add("Listening for connections....");
        }
        private void beginAccept(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            client = s.EndAccept(ar);
            lstMess.Items.Add("Connection received from client " + client.RemoteEndPoint.ToString());
            string wc = "Hello client!!!";
            buff2 = Encoding.ASCII.GetBytes(wc);
            client.BeginSend(buff2, 0, buff2.Length, SocketFlags.None, new AsyncCallback(sendData), client);
            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
        }
        private void beginReceive(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            int recv = 0;
            recv = s.EndReceive(ia);
            string recvei = Encoding.ASCII.GetString(buff, 0, recv);
            lstMess.Items.Add("Client: " + recvei);
            if (recvei.ToUpper() == "")
            {
                lstMess.Items.Add("Disconnect to client");
                server.Close();
                client.Close();
                this.Close();
            }
            buff = new byte[1024];
            client.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
        }
        private void sendData(IAsyncResult ia)
        {
            client.EndSend(ia);
        }

        private void Send()
        {
            string hl = txtSend.Text;
            byte[] gui = new byte[1024];
            gui = Encoding.ASCII.GetBytes(hl);
            txtSend.Clear();
            lstMess.Items.Add("Server: " + hl);
            client.BeginSend(gui, 0, gui.Length, SocketFlags.None, new AsyncCallback(sendData), client);
        }

        private void txtSend_KeyDown(object Sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send();
            }
        }

        private void btnStop_Click(object Sender, EventArgs e)
        {
            lstMess.Items.Add("Disconnect to client");
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            server.Close();
        }

        private void btnSend_Click(object Sender, EventArgs e)
        {
            Send();
            txtSend.Focus();
        }

        private void btnStart_Click(object Sender, EventArgs e)
        {
            startServer();
            txtSend.Focus();
        }
    }
    
}
