using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server_Socket
{
    class ClientHandler
    {
        private Socket ClientSocket;
        private int ClientIndex;
        private String ClientName;

        private ChatRoom ChatRoomHandler;

        public ClientHandler() { }

        public ClientHandler(Socket CS, int idx)
        {
            byte[] buf = new byte[1024];

            this.ClientSocket = CS;
            this.ClientIndex = idx;

            CS.Receive(buf);

            ClientName = Encoding.UTF8.GetString(buf);
            ClientName = ClientName.Trim('\0');
        }

        public Socket GetClientSocket()
        {
            return ClientSocket;
        }

        public String GetClientName()
        {
            return ClientName;
        }
        public void Send(byte[] data)
        {
            ClientSocket.Send(data);
        }

        public void SetChatRoom(ChatRoom input)
        {
            ChatRoomHandler = input;
        }

        public void Receive()
        {
            byte[] buf = new byte[1024];
            String Sbuf, data, mode;

            while (true)
            {
                ClientSocket.Receive(buf);

                Sbuf = Encoding.UTF8.GetString(buf);
                Sbuf = Sbuf.Trim('\0');
                System.Array.Clear(buf, 0, 1024);

                mode = Sbuf.Substring(0, 3);
                data = Sbuf.Substring(3);

                if (mode == "MSG")
                {
                    data = ClientName + " >> " + data + "\r\n\r\n";
                    ChatRoomHandler.BroadCast(Encoding.UTF8.GetBytes(mode), Encoding.UTF8.GetBytes(data));
                }
                else if (mode == "LIS") ChatRoomHandler.BroadCast(Encoding.UTF8.GetBytes(mode), Encoding.UTF8.GetBytes(data));
                else if (mode == "ENT") Program.T_ChatRoom[Int32.Parse(data)].Addmember(this);

                //System.Array.Clear(buf, 0, 1024);
            }

        }
    }
}
