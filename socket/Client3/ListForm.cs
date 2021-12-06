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

namespace Client3
{
    public partial class ListForm : Form
    {

        private static ListForm _instance = new ListForm();

        public static ListForm GetInstance()
        {
            return _instance;
        }
        

        public ListForm()
        {
            InitializeComponent();
            //loadFriendList();
            //loadBirthdayFriend();        
        }
        private void labelLoinClose_Click(object sender, EventArgs e)
        {
            SetupForm.GetInstance().buttonLogout_Click(sender, e);
            //this.Hide();

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
        public void loadBirthdayFriend()
        {
            listBoxBirthdayList.Items.Clear();
            String today = DateTime.Now.ToString("MMdd");
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select friendID, friendNickname  From Friend inner join JoinMassenger on Birthday like '%"+ today + "' and friendId = ID where userID = '" + user_id + "'"; //string query = "select friendid from Friend where friendid is not null  order by num asc"+ Properties.Settings.Default.ID + " "
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxBirthdayList.Items.Add(rdr["friendId"] + "\t\t" + rdr["friendNickname"]);
                }
                conn.Close();
            }
        }
        public void loadFriendList()
        {
            /*listViewChattingList.Items.Clear();
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select*from Friend where userId like '" + user_id + "' order by Field(friendBookmark,'★')desc "; ; //string query = "select friendid from Friend where friendid is not null  order by num asc"+ Properties.Settings.Default.ID + " "
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int index = 0;
                    int index_sub = 0;

                 
                    String[] temp = { rdr["friendId"].ToString(), rdr["friendNickname"].ToString(), rdr["friendStatemessage"].ToString(), rdr["friendBookmark"].ToString() };
                    
                    listViewChattingList.Items[index].SubItems[index_sub].;
                }

                conn.Close();
            }*/

            listBoxFriendList.Items.Clear();        //리스트뷰로 변환하려고 잠깐 바꿔놓음
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select*from Friend where userId like '" + user_id + "' order by Field(friendBookmark,'★')desc "; ; //string query = "select friendid from Friend where friendid is not null  order by num asc"+ Properties.Settings.Default.ID + " "
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxFriendList.Items.Add(rdr["friendId"] + "\t\t" + rdr["friendNickname"] + "\t\t" + rdr["friendStatemessage"] + "\t" + rdr["friendBookmark"]);
                }

                conn.Close();
            }
        }

        private void buttonGoSetup_Click(object sender, EventArgs e)
        {          
            SetupForm fm = new SetupForm();
            fm.ShowDialog();           
        }

        int alarm = 1; // 알람 사진 변경용
        private void buttonAlarm_Click(object sender, EventArgs e)
        {

            alarm *= -1;
            if(alarm ==  -1)
            {
                Bitmap alarmOff = new Bitmap(@"C:\Users\dksgywjd\OneDrive\바탕 화면\소켓\socket\Client3\off.png");
                buttonAlarm.Image = alarmOff;
            }
            else
            {
                Bitmap alarmOn = new Bitmap(@"C:\Users\dksgywjd\OneDrive\바탕 화면\소켓\socket\Client3\on.png");
                buttonAlarm.Image = alarmOn;
            }
        }
        private void buttonBookmark_Click(object sender, EventArgs e)
        {
            if (listBoxFriendList.SelectedIndex == -1)
            {
                MessageBox.Show("즐겨찾기할 친구를 선택해주세요");
            }
            {
                string fdel = listBoxFriendList.SelectedItem.ToString();
                string[] words = fdel.Split('\t');
                string friendid = words[0];

                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "Update Friend set friendBookmark = '★' where friendId = '" + friendid + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                listBoxFriendList.Items.Clear();
                loadFriendList();
            }
        }
        private void buttonDeleteFriend_Click(object sender, EventArgs e)
        {
            if (listBoxFriendList.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 친구를 먼저 선택해주세요.");
            }

            {
                string fdel = listBoxFriendList.SelectedItem.ToString();
                string[] words = fdel.Split('\t');
                string friendid = words[0];

                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "delete from Friend where friendId = '" + friendid + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                listBoxFriendList.Items.Clear();
                loadFriendList();
            }
            
        }
       
        private void buttonGoChatting_Click(object sender, EventArgs e)
        {
            makeChatroom();
            receiverMake();
        }
        private void receiverMake() // 채팅방 만드는걸 당하는 친구
        {
            string fdel = listBoxFriendList.SelectedItem.ToString();
            string[] words = fdel.Split('\t');
            string friendid = words[0];
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                var query = $@" INSERT INTO s5532761.Chatroom(receiver, loginId) values ('{user_id}', '{friendid}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
        private void makeChatroom()// 로그인한 사람이 친구 눌러서 채팅방 만들기
        {
            string fdel = listBoxFriendList.SelectedItem.ToString();
            string[] words = fdel.Split('\t');
            string friendid = words[0];
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                var query = $@" INSERT INTO s5532761.Chatroom(loginId, receiver) values ('{user_id}', '{friendid}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void buttonFirstChatting_Click(object sender, EventArgs e)
        {
            string fdel = listBoxFriendList.SelectedItem.ToString();
            string[] words = fdel.Split('\t');
            string friendid = words[0];

            if(listBoxFriendList.SelectedIndex == -1)
            {
                MessageBox.Show("채팅을 시작 할 친구를 선택해주세요.");
            }
            else
            {
                listViewChattingList.Items.Add(friendid);
            }

        }
    }
}
