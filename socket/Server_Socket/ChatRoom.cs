using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server_Socket
{
    class ChatRoom
    {
        private int ChatRoomId;
        private String ChatRoomName;
        private int ChatNumber;
        private String ChatRoomCheif;
        private String ChatRoomAttribute;

        private int Index = 0;
        private String MemberList;
        private ClientHandler[] ClientH = new ClientHandler[5];

        public ChatRoom(int id, String Name, String Cheif, String Attr)
        {
            ChatRoomId = id;
            ChatRoomName = Name;
            ChatRoomCheif = Cheif;
            ChatRoomAttribute = Attr;
            ChatNumber = 1;
        }

        public void BroadCast(byte[] mode, byte[] data)
        {
            lock (typeof(ChatRoom))
            {
                byte[] temp = new byte[mode.Length + data.Length];
                Array.Copy(mode, 0, temp, 0, mode.Length);
                Array.Copy(data, 0, temp, mode.Length, data.Length);

                for (int k = 0; k < Index; k++)
                    ClientH[k].Send(temp);
            }
        }
        public void Addmember(ClientHandler client)
        {
            ClientH[Index++] = client;
            client.SetChatRoom(this);
            ChatNumber++;

            MemberList += client.GetClientName() + "\r\n";
            BroadCast(Encoding.UTF8.GetBytes("LIS"),
                           Encoding.UTF8.GetBytes(MemberList));
        }
    }
}
