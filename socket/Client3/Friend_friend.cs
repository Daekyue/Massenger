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
    public partial class Friend_friend : Form
    {
        
        private static Friend_friend _instance = new Friend_friend();

        public static Friend_friend GetInstance()
        {
            return _instance;
        }
        public Friend_friend()
        {
            InitializeComponent();
            //loadFriend_FriendList();
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

        private void label_LoinClose_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
        public void loadFriend_FriendList(string friend_name)
        {
            //string search_id = SetupForm.GetInstance().textBoxSearchFriendId.Text;
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select*from Friend where userId like '" + friend_name + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxFriend_friend.Items.Add(rdr["friendId"] + "\t\t" + rdr["friendNickname"]);
                }
                conn.Close();
            }
        }
    }
}
