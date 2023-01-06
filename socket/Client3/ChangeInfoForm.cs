
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
    public partial class ChangeInfoForm : Form
    {
        string user_id = LoginForm.GetInstance().textBoxLoginId.Text;

        private static ChangeInfoForm _instance = new ChangeInfoForm();

        public static ChangeInfoForm GetInstance()
        {
            return _instance;
        }
        public ChangeInfoForm() //1210 수정
        {
            InitializeComponent(); 

        }

        public void LoadChangeInfo(string changed_user_id)
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = $@"select *
                                from(select cast(AES_DECRYPT(UNHEX(PW), '1') as char(100)) as decr from JoinMassenger where ID = '" + changed_user_id + "') as pp, JoinMassenger WHERE ID = '" + changed_user_id + "'";


                //string query = "select * from JoinMassenger where ID ='" + textBoxLoginId.Text + "' and PW = '" + textBoxLoginPassword.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var name = rdr["name"];
                    var Birthday = rdr["Birthday"];
                    var PW = rdr["decr"];
                    var Nickname = rdr["Nickname"];
                    var Address = rdr["Address"];
                    var Statemessage = rdr["Statemessage"];
                    var Addressnumber = rdr["Addressnumber"];

                    textBoxChangeName.Text = Convert.ToString(name);
                    textBoxChangeBirth.Text = Convert.ToString(Birthday);
                    textBoxChangePassword.Text = Convert.ToString(PW);
                    textBoxChangeNickname.Text = Convert.ToString(Nickname);
                    textBoxChangeAddress.Text = Convert.ToString(Address);
                    textBoxChangeStatemessage.Text = Convert.ToString(Statemessage);
                    textBoxChangeAddressnumber.Text = Convert.ToString(Addressnumber);
                }
            }
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
        private void buttonChangeInfoSave_Click(object sender, EventArgs e) // 1210 수정
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(strconn))// 
            {
                conn.Open(); // 새로운 커넥션을 오픈을 하고
                string query = "UPDATE JoinMassenger SET Name = '" + textBoxChangeName.Text + "', " +
                    "Birthday = '" + textBoxChangeBirth.Text + "' , " +
                    "PW= hex(aes_encrypt('"+ textBoxChangePassword.Text+"', '1')), " +
                    "Nickname='" + textBoxChangeNickname.Text + "'," +
                    "Address='" + textBoxChangeAddress.Text + "'," +
                    "Statemessage = '" + textBoxChangeStatemessage.Text + "'," +
                    "Addressnumber='" + textBoxChangeAddressnumber.Text + "' " +
                    "where ID like '" + user_id + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn); // 
                cmd.ExecuteNonQuery(); // 
               // hex(aes_encrypt('{textBoxChangeBirth.Text}', '1')
            }
            updatefriendtable();
            MessageBox.Show("변경하였습니다");
            this.Hide();
            /*SetupForm fm = new SetupForm();
            fm.Show();*/
        }
        private void updatefriendtable() ////////수정함 12/5!!!!!!!!!!!!!
        {
            string strconn = "server=27.96.130.41;Database=s5532761;Uid=s5532761;Pwd=s5532761;Charset=utf8";
            
            using (MySqlConnection conn = new MySqlConnection(strconn))// 
            {
                conn.Open(); // 새로운 커넥션을 오픈을 하고
                string query = "UPDATE Friend SET friendNickname='" + textBoxChangeNickname.Text + "', friendStatemessage = '" + textBoxChangeStatemessage.Text + "' where friendId like '" + user_id + "' "; //query문을 입력하여 명령 실행 가능
                MySqlCommand cmd = new MySqlCommand(query, conn); // 
                cmd.ExecuteNonQuery(); // 

            }
        }

        private void buttonSearchAddress_Click(object sender, EventArgs e)
        {
            SearchAddress frm = new SearchAddress();
            frm.ShowDialog();
            if (frm.Tag == null) { return; }
            DataRow dr = (DataRow)frm.Tag;

            textBoxChangeAddressnumber.Text = dr["zonecode"].ToString();
            textBoxChangeAddress.Text = dr["ADDR1"].ToString();
        }

      
    }
}
  