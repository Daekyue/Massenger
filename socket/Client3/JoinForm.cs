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
    public partial class JoinForm : Form
    {
        public JoinForm()
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

        private void buttonJoinInfoComplete_Click(object sender, EventArgs e)
        {
            saveMemberInform();
            insertFriendTable();
            goLogInForm();      // 수정한 부분!!!!!!!!!!!
        }
        private void goLogInForm()      // 수정한부분!!!!!!!!!!
        {
            this.Close();
            LoginForm fm = new LoginForm();
            fm.Show();
        }

        private void saveMemberInform()
        {
            var id = textBoxJoinId.Text;
            var pw = textBoxJoinPassword.Text;
            var name = textBoxJoinName.Text;
            var address = textBoxJoinAdderss.Text;
            var nick = textBoxJoinNickname.Text;
            var birthday = textBoxJoinBirth.Text;
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                var query = $@" INSERT INTO s5532761.JoinMassenger(ID, PW, name, Address, Nickname, BIrthday)values ('{id}', hex(aes_encrypt('{pw}','1')),'{name}','{address}','{nick}','{birthday}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

        }
        private void insertFriendTable()
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "Insert Into Friend(userId) values('" + textBoxJoinId.Text + "')"; // 수정한 부분 Create 테이블 삭제
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void buttonCheckDuplicate_Click(object sender, EventArgs e)
        {

            int i = 0;
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select * from JoinMassenger where ID ='" + textBoxJoinId.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    // label9.Text = "사용가능한 ID 입니다";
                    MessageBox.Show("가능");
                }
                else
                {
                    //label9.Text = "존재하는 ID 입니다";
                    MessageBox.Show("불가능");
                }
                conn.Close();
            }
        }
    }
}
