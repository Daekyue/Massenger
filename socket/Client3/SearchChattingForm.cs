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
    public partial class SearchChattingForm : Form
    {
        private static SearchChattingForm _instance = new SearchChattingForm();

        public static SearchChattingForm GetInstance()
        {
            return _instance;
        }
        public SearchChattingForm()
        {
            InitializeComponent();
        }

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

        private void buttonGoSearchWord_Click(object sender, EventArgs e)
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string user_id = LoginForm.GetInstance().textBoxLoginId.Text;
                string query = "select chat from chat where sender like '" + user_id + "' AND receiver like '" + ChattingForm.GetInstance().labelChattingTarget.Text + "' AND chat like '%" + textBoxSearchWord.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                textBoxResultSearchWord.Text = "";

                while (rdr.Read())
                {
                    string chat = rdr["chat"].ToString();
                    textBoxResultSearchWord.Text += chat + "\r\n";

                }

                conn.Close();
            }
        }

    }
}