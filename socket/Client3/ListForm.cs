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
        public ListForm()
        {
            InitializeComponent();
            loadFriendList();
            loadBirthdayFriend();        
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
        private void loadBirthdayFriend()
        {
            String today = DateTime.Now.ToString("MMdd");
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select friendID, friendNickname  From Friend inner join JoinMassenger on Birthday like '%"+ today + "' and friendId = ID where userID = '" + Properties.Settings.Default.ID + "'"; //string query = "select friendid from Friend where friendid is not null  order by num asc"+ Properties.Settings.Default.ID + " "
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
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select*from Friend where userId like '" + Properties.Settings.Default.ID + "' "; //string query = "select friendid from Friend where friendid is not null  order by num asc"+ Properties.Settings.Default.ID + " "
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxFriendList.Items.Add(rdr["friendId"] + "\t\t" + rdr["friendNickname"]);
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

        }
    }
}
