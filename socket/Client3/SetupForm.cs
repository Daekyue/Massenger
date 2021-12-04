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
        public SetupForm()
        {
            InitializeComponent();
            comboBoxBackgroundColor.Text = Properties.Settings.Default.background;
            textBoxSearchFriendId.Text = Properties.Settings.Default.searchID;
            labelNowUserId_Setup.Text = Properties.Settings.Default.ID;
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
        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.background = comboBoxBackgroundColor.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.background = null;
            Properties.Settings.Default.Save();
            this.Close();
            foreach (System.Windows.Forms.Form TheForm in this.MdiChildren)
            {
                TheForm.Dispose();
            }
            LoginForm lf = new LoginForm();
            lf.Show();

        }

        private void buttonGoSearchFriend_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.searchID = textBoxSearchFriendId.Text;
            Properties.Settings.Default.Save();
            /*this.Hide();
            MessageBox.Show(Properties.Settings.Default.searchID);*/
            SearchFriend sff = new SearchFriend();
            sff.ShowDialog();
            
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
           
            ChangeInfoForm cif = new ChangeInfoForm();
            cif.ShowDialog();
        }


    }
}
