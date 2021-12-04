using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace test_server
{
    class Program
    {

        public static int Index = 0;

        public static ClientHandler[] ClientH = new ClientHandler[5];

        public static void BroadCast(byte[] data)
        {
            for (int k = 0; k < Index; k++) ClientH[k].Send(data);
        }

        static void Main(string[] args)
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 9999);

            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);


                while (true)
                {
                    ClientH[Index] = new ClientHandler(listener.Accept(), Index);
                    Console.WriteLine("connected\n");
                    Index++;
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
