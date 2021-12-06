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
using System.Threading;


namespace Client3
{
    public partial class Client3_login : Form
    {
        public Client3_login()
        {
            InitializeComponent(); 

           // Program.ChatRoom = new Client3_chatroom_list();
           // Program.ChatWindow = new Client3_chat_form();

            Program.ChatRoom.Visible = false;
            Program.ChatWindow.Visible = false;
        }

        private void client3_button_login_Click(object sender, EventArgs e)
        {
            try
            {

                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("61.97.186.202"), 1024);  //61.97.186.202 //49.236.134.219
                Program.client = new Socket(AddressFamily.InterNetwork,
                                SocketType.Stream, ProtocolType.Tcp);

                Program.client.Connect(localEndPoint);

                Program.client.Send(Encoding.UTF8.GetBytes(client3_textbox_name.Text));

                Program.ClientName = client3_textbox_name.Text;
                Program.ChatRoom.Visible = true;

                this.Visible = false;

                new Thread(Program.Receive).Start();


            }

            catch (SocketException)
            {
                MessageBox.Show("서버와 연결이 되지 않습니다.");

            }
        }

        private void client3_textbox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                client3_button_login_Click(sender, e);
            }
        }
    }
}
