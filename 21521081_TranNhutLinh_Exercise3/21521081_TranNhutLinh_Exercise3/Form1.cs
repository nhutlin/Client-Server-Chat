using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21521081_TranNhutLinh_Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomChatH2_Click(object sender, EventArgs e)
        {

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            ServerSide server = new ServerSide();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientSide client = new ClientSide();
            client.Show();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
