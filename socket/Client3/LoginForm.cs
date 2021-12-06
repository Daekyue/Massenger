using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client3
{
    public partial class LoginForm : Form
    {

        private static LoginForm _instance = new LoginForm();

        public static LoginForm GetInstance()
        {
            return _instance;
        }

        public LoginForm()
        {
            InitializeComponent();
           /* textBoxLoginId.Text = Properties.Settings.Default.ID;
            textBoxLoginPassword.Text = Properties.Settings.Default.Password;
            checkBoxAutoLogin.Checked = Properties.Settings.Default.autoLogIn;
*/

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
        private void buttonGoLogin_Click(object sender, EventArgs e)
        {
            login();

        }

        private void login()
        {
            int i = 0;
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select * from JoinMassenger where ID ='" + textBoxLoginId.Text + "' and cast(AES_DECRYPT(UNHEX(PW), '1') as char(100)) = '" + textBoxLoginPassword.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    //label8.Text = "ID 또는 PW를 잘못입력하셨습니다";
                    MessageBox.Show("잘못입력했습니다.");
                }
                else
                {
                   // Properties.Settings.Default.ID = textBoxLoginId.Text;
                    this.Visible = false;
                    //this.Hide();
                    ListForm.GetInstance().loadFriendList();
                    ListForm.GetInstance().loadBirthdayFriend();
                    ListForm.GetInstance().Show();
                 
                }
                conn.Close();
            }
            //MessageBox.Show(Properties.Settings.Default.ID);
        }
        // 자동 로그인 체크o -> 아이디, 패스워드, 체크o로 저장
        // 자동 로그인 체크 x -> 아이디, 패스워드, 체크x로 저장
        private void checkBoxAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoLogin.Checked == true)
            {
               /* Properties.Settings.Default.ID = textBoxLoginId.Text;
                Properties.Settings.Default.Password = textBoxLoginPassword.Text;
                Properties.Settings.Default.autoLogIn = true;
                Properties.Settings.Default.Save();*/
               // MessageBox.Show(Properties.Settings.Default.ID);
            }
            else
            {
               /* Properties.Settings.Default.ID = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.autoLogIn = false;
                Properties.Settings.Default.Save();*/
                // MessageBox.Show(Properties.Settings.Default.ID);
            }

        }

        private void labelGoJoin_Click(object sender, EventArgs e)
        {
            JoinForm jf = new JoinForm();
            jf.ShowDialog();
        }

     

        private void textBoxLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }

}
