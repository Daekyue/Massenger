using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2
{
    public partial class Client2_chat_form : Form
    {

        //IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
        //Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private Socket ClientSocket;
        private String ClientName;


        public Client2_chat_form()
        {
            InitializeComponent();
        }

        public Client2_chat_form(Socket Client, String Name)
        {
            this.ClientSocket = Client;
            this.ClientName = Name;

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //client.Connect(localEndPoint);
            new Thread(Receiver).Start();

            label_name.Text = ClientName;
        }

        private void Receiver()
        {
            byte[] buf = new byte[1024];
            String data;

            while (true)
            {
                ClientSocket.Receive(buf);

                data = Encoding.UTF8.GetString(buf);
                data = data.Trim('\0');

                /*if (a != 0)
                {
                    System.Array.Clear(buf, 0, 1024);
                    a++;
                    ClientSocket.Receive(buf);
                }

                Console.WriteLine(Encoding.UTF8.GetString(buf));*/

                this.Invoke(new Action(delegate ()
                {
                    Client2_textbox_chatview.AppendText(data);
                }));

                System.Array.Clear(buf, 0, 1024);
            }
        }

        private void Client2_button_send_Click(object sender, EventArgs e)
        {
            Byte[] buf = new byte[1024];

            buf = Encoding.UTF8.GetBytes(Client2_textbox_chat.Text);

            ClientSocket.Send(buf);

            Client2_textbox_chat.Clear();
        }
    }
}
