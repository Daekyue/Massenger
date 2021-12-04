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

namespace Client2
{
    public partial class Client2_login : Form
    {
        public Client2_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("61.97.186.202"), 1024);
                Socket client = new Socket(AddressFamily.InterNetwork,
                                SocketType.Stream, ProtocolType.Tcp);

                client.Connect(localEndPoint);

                client.Send(Encoding.UTF8.GetBytes(textBox1.Text));

                Client2_chat_form ChatRoom = new Client2_chat_form(client, textBox1.Text);

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
