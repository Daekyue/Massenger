using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Client3
{
    public partial class ChattingForm : Form
    {
        private System.Timers.Timer aTimer;
        //싱글톤
        #region
        private static ChattingForm _instance = new ChattingForm();

        public static ChattingForm GetInstance()
        {
            return _instance;
        }
        #endregion

        public ChattingForm()
        {
            InitializeComponent();
            SetTimer();
            loadChat();
        }
        // 타이머
        #region
        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Invoke(new Action(delegate ()
            {
                loadChat();
                notifyMessage();
            }));
        }
        #endregion

        //상단바 컨트롤
        #region
        private void labelLoinClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
        #endregion

        public string old_msg = "";
        public string new_msg = "";

        public void notifyMessage()
        {

            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select chat from chat where sender like '" + user_id + "' AND receiver like '" + labelChattingTarget.Text + "' AND chat like '%" + labelChattingTarget.Text + "%' ";
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
                if (ListForm.GetInstance().alarm == 1)
                {
                    if (this.Visible == false)
                    {
                        MessageBox.Show(new_msg);
                    }
                }
            }
        }

   


    //채팅 텍스트 박스 색상 변경
    public void changeBackcolor(Color backColor)
        {
            textBoxChatting.BackColor = backColor;
        }

        //채팅방 내용 검색
        private void buttonSearchChatting_Click(object sender, EventArgs e)
        {
            SearchChattingForm.GetInstance().Show();
        }

        //전송 누르면 전송
        private void buttonSend_Click(object sender, EventArgs e)
        {
            chatSave();
            textBoxSendMsg.Clear();
            loadChat();
        }
        private void chatSave()
        {
            string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
            string friend_id = labelChattingTarget.Text;
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = $@" INSERT INTO chat(sender, receiver, chat) values ('{user_id}','{friend_id}','{user_id}  >>> {textBoxSendMsg.Text}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Open();

                query = $@" INSERT INTO chat(sender,receiver, chat) values ('{friend_id}','{user_id}','{user_id}  >>> {textBoxSendMsg.Text}')";

                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void loadChat()
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select chat from chat where sender like '" + user_id + "' AND receiver like '" + labelChattingTarget.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                textBoxChatting.Text = "";

                while (rdr.Read())
                {
                    string chat = rdr["chat"].ToString();
                    textBoxChatting.Text = textBoxChatting.Text + chat + "\r\n";
                }

               /*textBoxChatting.SelectionStart = textBoxChatting.Text.Length;
                textBoxChatting.ScrollToCaret();*/

                conn.Close();
            }
        }

        //엔터 눌러도 전송
        private void textBoxSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend_Click(sender, e);
            }
        }

        private void ChattingForm_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

    }
}