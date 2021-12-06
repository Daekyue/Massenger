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

namespace Client3
{
    public partial class ChattingForm : Form
    {
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
        }

        //상단바 컨트롤
        #region
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
        #endregion

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
        }
        private void chatSave()
        {
            string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                var query = $@" INSERT INTO chat(sneder, receiver, chat) values ('{user_id}','{labelChattingTarget.Text}','{textBoxChatting.Text}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
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
