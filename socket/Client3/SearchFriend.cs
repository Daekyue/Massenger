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
    public partial class SearchFriend : Form
    {
        string friendNickname = "";
        
        private static SearchFriend _instance = new SearchFriend();

        public static SearchFriend GetInstance()
        {
            return _instance;
        }
        public SearchFriend()
        {
            InitializeComponent();
            
        }
        private void labelLoinClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public void searchFriendList(string search_id)
        {
            //string search_id = SetupForm.GetInstance().textBoxSearchFriendId.Text;

            //MessageBox.Show(search_id);
            listBoxResultSearchFriend.Items.Clear();
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select*from s5532761.JoinMassenger WHERE ID ='" + search_id + "'";  //string query = "select * from JoinMassenger where ID ='" + textBoxLoginId.Text + "' and PW = '" + textBoxLoginPassword.Text + "'";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    listBoxResultSearchFriend.Items.Add(rdr["ID"] + "  " + rdr["Name"] + " " + rdr["Nickname"]);
                    string loadFriendNickname = rdr["Nickname"].ToString();
                    friendNickname = loadFriendNickname;
                   // Properties.Settings.Default.Save();
                    //search_id = loadFriendNickname;
                }

                conn.Close();
            }
        }
        
        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            string selected_string = listBoxResultSearchFriend.SelectedItem.ToString();
            string[] temp_string= selected_string.Split(' ');


            string search_id = temp_string[0];
            insert_Friend(search_id);
            ListForm.GetInstance().listBoxFriendList.Items.Clear();
            ListForm.GetInstance().loadFriendList();
        }
        private void insert_Friend(string search_id)//listBoxResultSearchFriend_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxResultSearchFriend.SelectedIndex == -1) // 선택이 없을 경우
            {
                MessageBox.Show("친구 추가할 회원을 선택해주세요");
            }
            else
            {
                string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                    //string search_id = SetupForm.GetInstance().textBoxSearchFriendId.Text;
                    conn.Open();
                    string query = "INSERT INTO Friend(userId, friendId, friendNickname) values('" + user_id + "', '" + search_id + "','" + friendNickname + "') ";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();                 
                }
                MessageBox.Show("친구 추가를 완료했습니다");     
                
            }
            
        }

        private void buttonSearchFriend_friend_Click(object sender, EventArgs e)
        {
            string selected_string = listBoxResultSearchFriend.SelectedItem.ToString();
            string[] temp_string = selected_string.Split(' ');

            Friend_friend.GetInstance().loadFriend_FriendList(temp_string[0]);

            //
            //Friend_friend.GetInstance().loadFriend_FriendList()
            Friend_friend.GetInstance().ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxResultSearchFriend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
