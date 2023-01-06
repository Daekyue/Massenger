using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace Client3
{
    public partial class ListForm : Form
    {
        public static int chatroom_idx = 0;

        private System.Timers.Timer aTimer;

        private static ListForm _instance = new ListForm();

        public int alarm = 1; // 알람 사진 변경용

        string old_msg = "";

        string new_msg = "";

        public static ListForm GetInstance()
        {
            return _instance;
            
        }
        

        public ListForm()
        {
            InitializeComponent();
           // listViewFriend.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SetHeight(listViewChattingList, 80);
            ///SetTimer();

            //loadFriendList();
            //loadBirthdayFriend();        
        }
        private void labelLoinClose_Click(object sender, EventArgs e)
        {
            SetupForm.GetInstance().buttonLogout_Click(sender, e);
            //listViewFriend.Clear();
            //listViewChattingList.Clear();
            //this.Hide();

        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Invoke(new Action(delegate ()
            {
                notifyMessage();
            }));
        }
        

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public void notifyMessage()
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select chat from chat where sender like '" + user_id + "' AND receiver like '" + ChattingForm.GetInstance().labelChattingTarget.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    new_msg = rdr["chat"].ToString();
                }

                conn.Close();
            }
            if (old_msg != new_msg)
            {
                if (old_msg == "")
                {

                }
                old_msg = new_msg;
                MessageBox.Show(new_msg);
            }
        }

        private Point mousePoint;

        // 마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어갑니다.
        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        // 클릭상태로 마우스를 이동시 이동한 만큼에서 윈도우 위치값을 빼게됩니다.
        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        

        public void loadChattingList()
        {
            listViewChattingList.Items.Clear();

            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select receiver from Chatroom where loginId = '" + user_id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                MySqlDataReader rdr = cmd.ExecuteReader();
                string friend_id = "";

                while (rdr.Read())
                {
                    //int index = 0;

                    friend_id = rdr["receiver"].ToString();
                    makeChatroom(friend_id);
                }

            }

        }

        public void loadBirthdayFriend()
        {
            String today = DateTime.Now.ToString("MMdd");
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select friendID, friendNickname  From Friend inner join JoinMassenger on Birthday like '%" + today + "' and friendId = ID where userID = '" + user_id + "'"; //string query = "select friendid from Friend where friendid is not null  order by num asc"+ Properties.Settings.Default.ID + " "

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //int index = 0;

                    string[] temp = { rdr["friendId"].ToString(), rdr["friendNickname"].ToString() };

                    ListViewItem item = new ListViewItem(temp);

                    listViewBirthday.Items.Add(item);
                }
            }
        }
        public void loadFriendList()
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select*from Friend inner join JoinMassenger on ID = friendID where userId like '" + user_id + "' order by Field(friendBookmark,'★')desc "; //string query = "select friendid from Friend where friendid is not null  order by num asc"+ Properties.Settings.Default.ID + " "

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                MySqlDataReader rdr = cmd.ExecuteReader();

                 while (rdr.Read())
                 {
                    //int index = 0;
                    
                     string[] temp = { rdr["friendId"].ToString(), rdr["friendNickname"].ToString(), rdr["Statemessage"].ToString(), rdr["friendBookmark"].ToString() };

                    ListViewItem item = new ListViewItem(temp);

                     listViewFriend.Items.Add(item);
                 }

                
            }

        }

        private void buttonGoSetup_Click(object sender, EventArgs e)
        {          
            SetupForm fm = new SetupForm();
            fm.ShowDialog();           
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {

            alarm *= -1;
            if(alarm ==  -1)
            {

                string png1_path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/off.png";

                Bitmap alarmOff = new Bitmap(png1_path);
                buttonAlarm.Image = alarmOff;

                //C:\Users\timbe\Desktop\제발_last\socket\Client3\on.png
            }
            else
            {
                string png2_path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/on.png";
                Bitmap alarmOn = new Bitmap(png2_path);
                buttonAlarm.Image = alarmOn;
            }
        }
       
       
        private void buttonGoChatting_Click(object sender, EventArgs e)
        {
            makeChatroom();
        }
        

        private void makeChatroom()// 로그인한 사람이 친구 눌러서 채팅방 만들기
        {
            if (listViewFriend.SelectedIndices.Count == 0)
            {
                MessageBox.Show("방 만들 친구를 선택해주세요");
            }
            else
            {
                int SelectRow = listViewFriend.SelectedItems[0].Index;

                string friendid = listViewFriend.Items[SelectRow].SubItems[0].Text;

                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";


                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                    var query = " SELECT EXISTS ( SELECT * FROM Chatroom WHERE loginId = '" + user_id + "' and receiver = '" + friendid + "' LIMIT 1) AS SUCCESS;";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();
                    if (rdr["SUCCESS"].ToString() == "1")
                    {
                        conn.Close();
                        MessageBox.Show("중복입니다.");
                    }
                    else
                    {
                        conn.Close();
                        listViewChattingList.Items.Add(friendid);
                        conn.Open();
                        //string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                        query = $@" INSERT INTO s5532761.Chatroom(loginId, receiver) values ('{user_id}', '{friendid}')";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        conn.Open();
                        query = $@" INSERT INTO s5532761.Chatroom(receiver,loginId) values ('{user_id}', '{friendid}')";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        chatroom_idx++;


                        conn.Open();
                        string str = " ";
                        query = $@" INSERT INTO s5532761.chat(sender,receiver,chat) values ('{user_id}', '{friendid}','{str}')";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }

                }
            }
        }
        public static void Init_scroll()
        {
            
        }
        

        private void makeChatroom(string friendid)// 매개변수로 방만들기
        {

            //if(listViewChattingList.SelectedItems.Count > 0)


            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {

                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;

                listViewChattingList.Items.Add(friendid);

            }
        }


        private void buttonFirstChatting_Click(object sender, EventArgs e)
        {

            if (listViewChattingList.SelectedIndices.Count == 0)
            {
                MessageBox.Show("채팅을 시작 할 친구를 선택해주세요.");
                return;
            }
            else
            {
                string friendID = listViewChattingList.FocusedItem.SubItems[0].Text;

                ChattingForm.GetInstance().labelChattingTarget.Text = friendID;
                ChattingForm.GetInstance().Visible = true;
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;

                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {

                    var query = " select backGround from JoinMassenger where ID = '" + user_id + "'";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();
                    string color = rdr["backGround"].ToString();
                    conn.Close();
                    Color mycolor = ColorTranslator.FromHtml(color);
                    ChattingForm.GetInstance().changeBackcolor(mycolor);


                }

                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    var query = "select chat from chat where sender like '" + user_id + "' AND receiver like '" + friendID + "' ";
                    //AND chat like '%" + friendID + "%' 

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();
                    ChattingForm.GetInstance().old_msg = rdr["chat"].ToString();
                    ChattingForm.GetInstance().new_msg = ChattingForm.GetInstance().old_msg;
                    conn.Close();
                }



            }

        }

        /*private void buttonFirstChatting_Click(object sender, EventArgs e)
        {

        }*/

        private void SetHeight(ListView LV, int height)
        {
            // listView 높이 지정
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            LV.SmallImageList = imgList;

        }

        private void listViewBirthday_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteChattingRoom_Click(object sender, EventArgs e)
        {
            if (listViewChattingList.SelectedIndices.Count == 0)
            {
                MessageBox.Show("선택하세요");
            }
            else
            {
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string friendid = listViewChattingList.FocusedItem.SubItems[0].Text;
                int index = listViewChattingList.FocusedItem.Index;


                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    var query = "DELETE FROM Chatroom WHERE loginId = '" + user_id + "' or receiver = '" + friendid + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    query = "DELETE FROM Chatroom WHERE loginId = '" + friendid + "' or receiver = '" + user_id + "'";
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                listViewChattingList.Items.RemoveAt(index);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatroom_idx = 0;
            loadChattingList();
        }

        private void buttonBookmark_Click(object sender, EventArgs e)
        {
            if (listViewFriend.SelectedIndices.Count == 0)
            {
                MessageBox.Show("즐겨찾기할 친구를 선택해주세요");
            }
            else{
                int SelectRow = listViewFriend.SelectedItems[0].Index;
                string friendid = listViewFriend.Items[SelectRow].SubItems[0].Text;
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;

                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";

                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "SELECT friendBookmark FROM Friend WHERE friendid = '" + friendid + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();


                    if (rdr["friendBookmark"].ToString().Equals("★").ToString() == "True")
                    {
                        conn.Close();
                        conn.Open();
                        query = "Update Friend set friendBookmark = ' ' where friendId = '" + friendid + "'";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                    }

                    else
                    {
                        conn.Close();
                        conn.Open();
                        query = "Update Friend set friendBookmark = '★' where friendId = '" + friendid + "'";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();

                }
                listViewFriend.Items.Clear();
                loadFriendList();
            }
        }

        private void buttonDeleteFriend_Click(object sender, EventArgs e)
        {
            if (listViewFriend.SelectedIndices.Count == 0)
            {
                MessageBox.Show("삭제할 친구를 먼저 선택해주세요.");
            }

            else
            {
                int SelectRow = 0;
                int selected_idx = listViewFriend.SelectedIndices.Count;
                string friend_id = listViewFriend.FocusedItem.Text;
                
                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "delete from Friend where friendId = '" + friend_id + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }

                listViewFriend.Items.Clear();
                loadFriendList();
                listViewBirthday.Items.Clear();
                loadBirthdayFriend();
            }

        }
    }
}
