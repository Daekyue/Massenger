using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client3
{
    public partial class Client3_chatroom_list : Form
    { 
        public Client3_chatroom_list()
        {
            InitializeComponent();
        }

        public void SetChatRoomView(String input)
        {
            String[] token = input.Split(' ');
            ListViewItem item = new ListViewItem(token);

            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate () { ChatRoomView.Items.Add(item); }));
            else ChatRoomView.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnterChatRoomButton_Click(object sender, EventArgs e)
        {
            String buf = "";
            int index;

            try
            {
                index = ChatRoomView.FocusedItem.Index;
                buf = ChatRoomView.Items[index].SubItems[0].Text;

                //Program.ChatWindow.SetRoomName(ChatRoomView.Items[index].SubItems[1].Text);
                Program.client.Send(Encoding.UTF8.GetBytes("ENT" + buf));
                Program.ChatWindow.Show();

            }
            catch
            { MessageBox.Show("방을 선택하십시오"); }

        }
    }
}
