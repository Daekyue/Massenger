
namespace Client3
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonGoSetup = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_LoinClose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteFriend = new System.Windows.Forms.Button();
            this.buttonGoChatting = new System.Windows.Forms.Button();
            this.buttonFirstChatting = new System.Windows.Forms.Button();
            this.buttonBookmark = new System.Windows.Forms.Button();
            this.listViewFriend = new System.Windows.Forms.ListView();
            this.fri_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fri_nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fir_statemsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fri_bookmark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteChattingRoom = new System.Windows.Forms.Button();
            this.listViewBirthday = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewChattingList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_refresh = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAlarm.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlarm.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlarm.Image")));
            this.buttonAlarm.Location = new System.Drawing.Point(838, 46);
            this.buttonAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(63, 54);
            this.buttonAlarm.TabIndex = 6;
            this.buttonAlarm.UseVisualStyleBackColor = false;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // buttonGoSetup
            // 
            this.buttonGoSetup.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonGoSetup.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonGoSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoSetup.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoSetup.Image")));
            this.buttonGoSetup.Location = new System.Drawing.Point(895, 46);
            this.buttonGoSetup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGoSetup.Name = "buttonGoSetup";
            this.buttonGoSetup.Size = new System.Drawing.Size(63, 54);
            this.buttonGoSetup.TabIndex = 7;
            this.buttonGoSetup.UseVisualStyleBackColor = false;
            this.buttonGoSetup.Click += new System.EventHandler(this.buttonGoSetup_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(902, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(55, 39);
            this.panel4.TabIndex = 34;
            // 
            // label_LoinClose
            // 
            this.label_LoinClose.AutoSize = true;
            this.label_LoinClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_LoinClose.Location = new System.Drawing.Point(21, 9);
            this.label_LoinClose.Name = "label_LoinClose";
            this.label_LoinClose.Size = new System.Drawing.Size(18, 17);
            this.label_LoinClose.TabIndex = 0;
            this.label_LoinClose.Text = "X";
            this.label_LoinClose.Click += new System.EventHandler(this.labelLoinClose_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(5, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 39);
            this.panel3.TabIndex = 33;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "친구";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(552, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "채팅";
            // 
            // buttonDeleteFriend
            // 
            this.buttonDeleteFriend.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonDeleteFriend.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonDeleteFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDeleteFriend.Location = new System.Drawing.Point(11, 598);
            this.buttonDeleteFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteFriend.Name = "buttonDeleteFriend";
            this.buttonDeleteFriend.Size = new System.Drawing.Size(86, 50);
            this.buttonDeleteFriend.TabIndex = 38;
            this.buttonDeleteFriend.Text = "친구삭제";
            this.buttonDeleteFriend.UseVisualStyleBackColor = false;
            this.buttonDeleteFriend.Click += new System.EventHandler(this.buttonDeleteFriend_Click);
            // 
            // buttonGoChatting
            // 
            this.buttonGoChatting.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonGoChatting.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonGoChatting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoChatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGoChatting.Location = new System.Drawing.Point(557, 598);
            this.buttonGoChatting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGoChatting.Name = "buttonGoChatting";
            this.buttonGoChatting.Size = new System.Drawing.Size(192, 50);
            this.buttonGoChatting.TabIndex = 39;
            this.buttonGoChatting.Text = "채팅하기";
            this.buttonGoChatting.UseVisualStyleBackColor = false;
            this.buttonGoChatting.Click += new System.EventHandler(this.buttonFirstChatting_Click);
            // 
            // buttonFirstChatting
            // 
            this.buttonFirstChatting.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonFirstChatting.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonFirstChatting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirstChatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonFirstChatting.Location = new System.Drawing.Point(195, 598);
            this.buttonFirstChatting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirstChatting.Name = "buttonFirstChatting";
            this.buttonFirstChatting.Size = new System.Drawing.Size(131, 50);
            this.buttonFirstChatting.TabIndex = 40;
            this.buttonFirstChatting.Text = "채팅방 생성";
            this.buttonFirstChatting.UseVisualStyleBackColor = false;
            this.buttonFirstChatting.Click += new System.EventHandler(this.buttonGoChatting_Click);
            // 
            // buttonBookmark
            // 
            this.buttonBookmark.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonBookmark.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonBookmark.Location = new System.Drawing.Point(103, 598);
            this.buttonBookmark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBookmark.Name = "buttonBookmark";
            this.buttonBookmark.Size = new System.Drawing.Size(86, 50);
            this.buttonBookmark.TabIndex = 41;
            this.buttonBookmark.Text = "즐겨찾기";
            this.buttonBookmark.UseVisualStyleBackColor = false;
            this.buttonBookmark.Click += new System.EventHandler(this.buttonBookmark_Click);
            // 
            // listViewFriend
            // 
            this.listViewFriend.BackColor = System.Drawing.SystemColors.Window;
            this.listViewFriend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFriend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fri_id,
            this.fri_nickname,
            this.fir_statemsg,
            this.fri_bookmark});
            this.listViewFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listViewFriend.FullRowSelect = true;
            this.listViewFriend.GridLines = true;
            this.listViewFriend.HideSelection = false;
            this.listViewFriend.Location = new System.Drawing.Point(16, 281);
            this.listViewFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewFriend.Name = "listViewFriend";
            this.listViewFriend.Size = new System.Drawing.Size(528, 300);
            this.listViewFriend.TabIndex = 42;
            this.listViewFriend.UseCompatibleStateImageBehavior = false;
            this.listViewFriend.View = System.Windows.Forms.View.Details;
            // 
            // fri_id
            // 
            this.fri_id.Text = "아이디";
            this.fri_id.Width = 110;
            // 
            // fri_nickname
            // 
            this.fri_nickname.Text = "별명";
            this.fri_nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fri_nickname.Width = 110;
            // 
            // fir_statemsg
            // 
            this.fir_statemsg.Text = "상태메세지";
            this.fir_statemsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fir_statemsg.Width = 192;
            // 
            // fri_bookmark
            // 
            this.fri_bookmark.Text = "";
            this.fri_bookmark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fri_bookmark.Width = 48;
            // 
            // buttonDeleteChattingRoom
            // 
            this.buttonDeleteChattingRoom.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonDeleteChattingRoom.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonDeleteChattingRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteChattingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDeleteChattingRoom.Location = new System.Drawing.Point(766, 596);
            this.buttonDeleteChattingRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteChattingRoom.Name = "buttonDeleteChattingRoom";
            this.buttonDeleteChattingRoom.Size = new System.Drawing.Size(192, 50);
            this.buttonDeleteChattingRoom.TabIndex = 43;
            this.buttonDeleteChattingRoom.Text = "나가기";
            this.buttonDeleteChattingRoom.UseVisualStyleBackColor = false;
            this.buttonDeleteChattingRoom.Click += new System.EventHandler(this.buttonDeleteChattingRoom_Click);
            // 
            // listViewBirthday
            // 
            this.listViewBirthday.BackColor = System.Drawing.SystemColors.Window;
            this.listViewBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewBirthday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8});
            this.listViewBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listViewBirthday.FullRowSelect = true;
            this.listViewBirthday.GridLines = true;
            this.listViewBirthday.HideSelection = false;
            this.listViewBirthday.Location = new System.Drawing.Point(16, 122);
            this.listViewBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewBirthday.Name = "listViewBirthday";
            this.listViewBirthday.Scrollable = false;
            this.listViewBirthday.Size = new System.Drawing.Size(528, 135);
            this.listViewBirthday.TabIndex = 44;
            this.listViewBirthday.UseCompatibleStateImageBehavior = false;
            this.listViewBirthday.View = System.Windows.Forms.View.Details;
            this.listViewBirthday.SelectedIndexChanged += new System.EventHandler(this.listViewBirthday_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "아이디";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "별명";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 449;
            // 
            // listViewChattingList
            // 
            this.listViewChattingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewChattingList.FullRowSelect = true;
            this.listViewChattingList.GridLines = true;
            this.listViewChattingList.HideSelection = false;
            this.listViewChattingList.Location = new System.Drawing.Point(560, 122);
            this.listViewChattingList.Name = "listViewChattingList";
            this.listViewChattingList.Size = new System.Drawing.Size(381, 459);
            this.listViewChattingList.TabIndex = 45;
            this.listViewChattingList.UseCompatibleStateImageBehavior = false;
            this.listViewChattingList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "채팅방";
            this.columnHeader1.Width = 310;
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.BurlyWood;
            this.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_refresh.Location = new System.Drawing.Point(778, 53);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(54, 47);
            this.button_refresh.TabIndex = 46;
            this.button_refresh.Text = "re";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(971, 660);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.listViewChattingList);
            this.Controls.Add(this.listViewBirthday);
            this.Controls.Add(this.buttonDeleteChattingRoom);
            this.Controls.Add(this.listViewFriend);
            this.Controls.Add(this.buttonBookmark);
            this.Controls.Add(this.buttonFirstChatting);
            this.Controls.Add(this.buttonGoChatting);
            this.Controls.Add(this.buttonDeleteFriend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonGoSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonGoSetup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteFriend;
        private System.Windows.Forms.Button buttonGoChatting;
        private System.Windows.Forms.Button buttonFirstChatting;
        private System.Windows.Forms.Button buttonBookmark;
        public System.Windows.Forms.ListView listViewFriend;
        private System.Windows.Forms.ColumnHeader fri_id;
        private System.Windows.Forms.ColumnHeader fri_nickname;
        private System.Windows.Forms.ColumnHeader fir_statemsg;
        private System.Windows.Forms.ColumnHeader fri_bookmark;
        private System.Windows.Forms.Button buttonDeleteChattingRoom;
        public System.Windows.Forms.ListView listViewBirthday;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listViewChattingList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button_refresh;
    }
}