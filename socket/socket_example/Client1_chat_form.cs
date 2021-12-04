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



namespace socket_example
{
    public partial class Client1_chat_form : Form
    {

        IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


        private Socket ClientSocket;
        private String ClientName;


        public Client1_chat_form()
        {
            InitializeComponent();
        }

        public Client1_chat_form(Socket Client, String Name)
        {
            this.ClientSocket = Client;
            this.ClientName = Name;

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            client.Connect(localEndPoint);

            label_name.Text = ClientName;

            new Thread(Receiver).Start();
        }

        private void Receiver()
        {
            byte[] buf = new byte[1024];
            String data;

            while(true)
            {
                client.Receive(buf);

                data = Encoding.Default.GetString(buf);

                this.Invoke(new Action(delegate ()
                {
                    Client1_textbox_chatview.AppendText("\r\n" + data);
                }));

                System.Array.Clear(buf, 0, 1024);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Client1_button_send_Click(object sender, EventArgs e)
        {
            Byte[] buf = new byte[1024];
            String data;

            buf = Encoding.Default.GetBytes(Client1_textbox_chat.Text);
            data = Encoding.Default.GetString(buf);

            client.Send(buf);

            //ClientSocket.Send(buf);
            Client1_textbox_chat.Clear();


            Client1_textbox_chat.AppendText("\r\n" + " I Say >> " + data);

            Client1_textbox_chat.Clear();
        }
    }
}
