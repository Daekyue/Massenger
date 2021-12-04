using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace test_server
{ 
    class ClientHandler
    {
        private Socket ClientSocket;
        private int ClientIndex;
        private String ClientName;

        public ClientHandler() { }

        public ClientHandler(Socket CS, int idx)
        {
            byte[] buf = new byte[1024];

            this.ClientSocket = CS;
            this.ClientIndex = idx;


            CS.Receive(buf);

            ClientName = Encoding.UTF8.GetString(buf);
            ClientName = ClientName.Trim('\0');

            new Thread(this.Receive).Start();

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

        public void Receive()
        {
            byte[] buf = new byte[1024];
            String data, Rdata;

            while (true)
            {
                ClientSocket.Receive(buf);
                Rdata = Encoding.UTF8.GetString(buf);
                Rdata = Rdata.Trim('\0');

                data = ClientName + " >> " + Rdata + "\r\n\r\n";

                Program.BroadCast(Encoding.UTF8.GetBytes(data));

                System.Array.Clear(buf, 0, 1024);
            }

        }
    }
}
