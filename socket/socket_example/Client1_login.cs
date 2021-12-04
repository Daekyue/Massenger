using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socket_example
{
    public partial class Client1_login : Form
    {
        public Client1_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                Socket client = new Socket(AddressFamily.InterNetwork,
                                SocketType.Stream, ProtocolType.Tcp);

                client.Connect(localEndPoint);

                client.Send(Encoding.Unicode.GetBytes(client1_textbox_name.Text));

                Client1_chat_form ChatRoom = new Client1_chat_form(client, client1_textbox_name.Text);

                ChatRoom.Show();
                this.Visible = false;

            }

            catch (SocketException)
            {
                MessageBox.Show("서버와 연결이 되지 않습니다.");

            }


        }
    }
}
