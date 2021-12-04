using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;

namespace Server_Socket
{
    class Program
    {
        public static int ClientN = 0;
        public static int RoomN = 0;

        public static String T_MemeberList;
        public static ChatRoom[] T_ChatRoom = new ChatRoom[10];
        public static ClientHandler[] T_ClientH = new ClientHandler[10];

        static void Main(string[] args)
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 1024);

            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                T_ChatRoom[0] = new ChatRoom(0, "테스트방", "관리자", "일반");

                while (true)
                {
                    T_ClientH[ClientN] = new ClientHandler(listener.Accept(), ClientN);

                    new Thread(T_ClientH[ClientN].Receive).Start();
                    ClientN++;
                    //Index++;

                    T_ClientH[ClientN - 1].Send(Encoding.UTF8.GetBytes("CRL" + "0 테스트방 - 관리자 일반"));

                    //Addmember(ClientH[Index-1].GetClientName());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }
    }
}


//public static String T_MemberList;
//public static int Index = 0;

/*public static void BroadCast(byte[] mode , byte[] data)
        {
            byte[] temp = new byte[mode.Length + data.Length];
            Array.Copy(mode, 0, temp, 0, mode.Length);
            Array.Copy(data, 0, temp, mode.Length, data.Length);

            lock (typeof(Program))
            {
                for (int k = 0; k < Index; k++)
                    ClientH[k].Send(temp);
            }


            for (int k = 0; k < Index; k++) ClientH[k].Send(data);
        }

        public static void Addmember(String NewMember)
        {
            MemberList += NewMember + "\r\n";
            Program.BroadCast(Encoding.UTF8.GetBytes("LIS"),
                       Encoding.UTF8.GetBytes(MemberList));
        }*/