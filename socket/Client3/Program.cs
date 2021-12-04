using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Client3
{
    static class Program
    {

        public static Socket client;
        public static Client3_chat_form ChatWindow;
        public static Client3_chatroom_list ChatRoom;

        public static string ClientName;

        public static void Receive()
        {
            byte[] buf = new byte[1024];
            String Sbuf, mode, data;

            while (true)
            {
                // 데이터 수신
                client.Receive(buf);
                Sbuf = Encoding.UTF8.GetString(buf);
                Sbuf = Sbuf.Trim('\0');
                System.Array.Clear(buf, 0, 1024);

                // 데이터 분리 ( 모드, 메시지 )
                mode = Sbuf.Substring(0, 3);
                data = Sbuf.Substring(3);

                // 데이터 타입에 따른 메시지 출력 분기
                if (mode == "MSG") ChatWindow.SetCharView(data);
                else if (mode == "LIS") ChatWindow.SetCharList(data);
                else if (mode == "CRL") ChatRoom.SetChatRoomView(data);

            }
        }



        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Client3_login());
            (new LoginForm()).Show();
            Application.Run();
        }
    }
}
