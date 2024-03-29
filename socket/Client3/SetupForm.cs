﻿using MySql.Data.MySqlClient;
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
    public partial class SetupForm : Form
    {
        //싱글톤
        # region
        private static SetupForm _instance = new SetupForm();

        public static SetupForm GetInstance()
        {
            return _instance;
        }

        public SetupForm()
        {
            InitializeComponent();

            labelNowUserId_Setup.Text = LoginForm.GetInstance().textBoxLoginId.Text;
        }
        #endregion

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

        //채팅방에 채팅텍스트박스 변경하기
        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                var query = " update JoinMassenger SET background = '" + comboBoxBackgroundColor.SelectedItem.ToString() + "' where ID='" + user_id + "'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteReader();
                conn.Close();
            }
        }

        //로그아웃
        public void buttonLogout_Click(object sender, EventArgs e)
        {
            ListForm.GetInstance().listViewFriend.Items.Clear();
            ListForm.GetInstance().listViewBirthday.Items.Clear();


            LoginForm.GetInstance().Visible = true;
            ListForm.GetInstance().Visible = false;

            if (LoginForm.GetInstance().checkBoxAutoLogin.Checked == false)
            {
                LoginForm.GetInstance().textBoxLoginId.Clear();
                LoginForm.GetInstance().textBoxLoginPassword.Clear();
            }

            /*foreach (System.Windows.Forms.Form TheForm in this.MdiChildren)
            {
                TheForm.Dispose();
            }*/

            this.Visible = false;

            SetupForm.GetInstance().comboBoxBackgroundColor.Text = "White";
            //Properties.Settings.Default.Save();
            ChangeInfoForm.GetInstance().textBoxChangeAddress.Clear();
            ChangeInfoForm.GetInstance().textBoxChangeName.Clear();
            ChangeInfoForm.GetInstance().textBoxChangeBirth.Clear();
            ChangeInfoForm.GetInstance().textBoxChangePassword.Clear();
            ChangeInfoForm.GetInstance().textBoxChangeNickname.Clear();
            ChangeInfoForm.GetInstance().textBoxChangeStatemessage.Clear();
            ChangeInfoForm.GetInstance().textBoxChangeAddressnumber.Clear();




        }

        //친구찾기
        private void buttonGoSearchFriend_Click(object sender, EventArgs e)
        {
            SearchFriend.GetInstance().searchFriendList(textBoxSearchFriendId.Text);
            SearchFriend.GetInstance().ShowDialog();
        }

        //회원정보 수정
        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            ChangeInfoForm.GetInstance().LoadChangeInfo(LoginForm.GetInstance().textBoxLoginId.Text);
            ChangeInfoForm.GetInstance().ShowDialog();
        }

       
    }
}
