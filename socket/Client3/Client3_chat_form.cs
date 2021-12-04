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

namespace Client3
{
    public partial class Client3_chat_form : Form
    {
        //IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
        //Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


        private Socket ClientSocket = Program.client;
        private String ClientName;
        public static int a = 0;

        public Client3_chat_form()
        {
            InitializeComponent();
        }

        /*public Client3_chat_form(String RoomName)
        {
            InitializeComponent();
        }*/

        /*public Client3_chat_form(Socket Client, String Name)
        {
            this.ClientSocket = Client;
            this.ClientName = Name;

            InitializeComponent();
        }*/


        private void Form3_Load(object sender, EventArgs e)
        {
            //client.Connect(localEndPoint);
            //new Thread(Program.Receive).Start();

            Client3_label_name.Text = Program.ClientName;
        }

        public void SetCharView(String input)
        {
            //Client3_textbox_chatview.Invoke(new Action(() => Client3_textbox_chatview.AppendText(data)));
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate () { Client3_textbox_chatview.AppendText(input); }));
            else Client3_textbox_chatview.AppendText(input);
        }

        public void SetCharList(String input)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate () { Client3_chatlist.Text = input; }));
            else Client3_chatlist.Text = input;
        }

        public void SetRoomName(String input)
        {
            ChatRoomNameLabel.Text = input;
        }

        private void Client3_button_send_Click(object sender, EventArgs e)
        {
            Byte[] buf = new byte[1024];

            buf = Encoding.UTF8.GetBytes("MSG" + Client3_textbox_chat.Text);
            
            Program.client.Send(buf);

            Client3_textbox_chat.Clear();

        }

        private void Client3_textbox_chat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Client3_button_send_Click(sender,e);
            }
        }

        private void Client3_chat_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            /*Client3_textbox_chat.Clear();
            Client3_chatlist.Clear();
            Client3_textbox_chatview.Clear();*/

            this.Visible = false;

            Program.client.Send(Encoding.UTF8.GetBytes("CRE "));

        }


    }
}


/*private void Receiver()
        {
            byte[] buf = new byte[1024];
            System.Array.Clear(buf, 0, 1024);

            String Sbuf, mode, data;

            while (true)
            {
                ClientSocket.Receive(buf);
                string temp = Encoding.UTF8.GetString(buf);
                Console.WriteLine(temp);


                //Console.WriteLine(Encoding.UTF8.GetString(buf));

                *//*
                 if (a != 0)
                {
                    System.Array.Clear(buf, 0, 1024);
                    a++;
                    ClientSocket.Receive(buf);
                    Console.WriteLine(Encoding.UTF8.GetString(buf));

                }
                *//*

                Sbuf = Encoding.UTF8.GetString(buf);
                
                Sbuf = Sbuf.Trim('\0');
                System.Array.Clear(buf, 0, 1024);

                mode = Sbuf.Substring(0, 3);
                data = Sbuf.Substring(3);

                Console.WriteLine(mode);

                if (mode == "MSG")
                    Client3_textbox_chatview.Invoke(new Action(() => Client3_textbox_chatview.AppendText(data)));
                else if (mode == "LIS")
                    Client3_chatlist.Invoke(new Action(() => Client3_chatlist.Text = data));

                *//*
                 * if (a != 0)
                {
                    System.Array.Clear(buf, 0, 1024);
                    a++;
                    ClientSocket.Receive(buf);
                }

                Console.WriteLine(Encoding.UTF8.GetString(buf));*/



/*data = Encoding.UTF8.GetString(buf);
data = data.Trim('\0');

this.Invoke(new Action(delegate ()
{
    Client3_textbox_chatview.AppendText(data); 
}));


System.Array.Clear(buf, 0, 1024);
*//*
}
}*/