using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_tuan4
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

        private Thread ListenThread;
        private TcpListener tcpListener;
        private bool StopChatServer = true;
        private readonly int ServerPort = 8080;
        private Dictionary<string, TcpClient> dict = new Dictionary<string, TcpClient>();

        public void Listen()
        {
            try
            {
              while (!StopChatServer)
                {
                    }
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(sockEx.Message);
            }
        }

        private delegate void SafeCallDelegate(string text);

        public void UpdateChatHistory(string text)
        {
            if (message.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistory);
                message.Invoke(d, new object[] { text });
            }
            else
            {
                if (text[text.Length - 1] == '\n')
                {
                    message.Text += text;
                }
                else
                {
                    message.Text += text + "\n";
                }
            }
        }
        
        public void ClientRecv(string username, TcpClient tcpClient)
        {


            while (!StopChatServer)
            {
                foreach (TcpClient otherClient in dict.Values)
                {
                    }

               

            }
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            if (StopChatServer)
            {
                StopChatServer = false;
                button1.Text = @"Stop";
            }
            else
            {
                StopChatServer = true;

                tcpListener.Stop();
                ListenThread = null;
                button1.Text = @"Listen";
            }
        }
        private void server_Load(object sender, EventArgs e)
        {

        }
    }
}
