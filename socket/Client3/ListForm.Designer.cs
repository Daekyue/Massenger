
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonGoSetup = new System.Windows.Forms.Button();
            this.listBoxFriendList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_LoinClose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBirthdayList = new System.Windows.Forms.ListBox();
            this.buttonDeleteFriend = new System.Windows.Forms.Button();
            this.buttonGoChatting = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(421, 122);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 390);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "방번호";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "방제목";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "인원";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "방장";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "속성";
            this.columnHeader5.Width = 80;
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAlarm.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlarm.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlarm.Image")));
            this.buttonAlarm.Location = new System.Drawing.Point(713, 58);
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
            this.buttonGoSetup.Location = new System.Drawing.Point(770, 58);
            this.buttonGoSetup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGoSetup.Name = "buttonGoSetup";
            this.buttonGoSetup.Size = new System.Drawing.Size(63, 54);
            this.buttonGoSetup.TabIndex = 7;
            this.buttonGoSetup.UseVisualStyleBackColor = false;
            this.buttonGoSetup.Click += new System.EventHandler(this.buttonGoSetup_Click);
            // 
            // listBoxFriendList
            // 
            this.listBoxFriendList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxFriendList.FormattingEnabled = true;
            this.listBoxFriendList.ItemHeight = 15;
            this.listBoxFriendList.Location = new System.Drawing.Point(11, 208);
            this.listBoxFriendList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriendList.Name = "listBoxFriendList";
            this.listBoxFriendList.Size = new System.Drawing.Size(400, 300);
            this.listBoxFriendList.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(782, 2);
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
            this.label_LoinClose.Size = new System.Drawing.Size(15, 14);
            this.label_LoinClose.TabIndex = 0;
            this.label_LoinClose.Text = "X";
            this.label_LoinClose.Click += new System.EventHandler(this.labelLoinClose_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(5, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 39);
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
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "친구";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(417, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "채팅";
            // 
            // listBoxBirthdayList
            // 
            this.listBoxBirthdayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxBirthdayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxBirthdayList.FormattingEnabled = true;
            this.listBoxBirthdayList.ItemHeight = 15;
            this.listBoxBirthdayList.Location = new System.Drawing.Point(11, 122);
            this.listBoxBirthdayList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxBirthdayList.Name = "listBoxBirthdayList";
            this.listBoxBirthdayList.Size = new System.Drawing.Size(400, 60);
            this.listBoxBirthdayList.TabIndex = 37;
            // 
            // buttonDeleteFriend
            // 
            this.buttonDeleteFriend.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonDeleteFriend.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonDeleteFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteFriend.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDeleteFriend.Location = new System.Drawing.Point(11, 524);
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
            this.buttonGoChatting.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGoChatting.Location = new System.Drawing.Point(103, 524);
            this.buttonGoChatting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGoChatting.Name = "buttonGoChatting";
            this.buttonGoChatting.Size = new System.Drawing.Size(86, 50);
            this.buttonGoChatting.TabIndex = 39;
            this.buttonGoChatting.Text = "채팅하기";
            this.buttonGoChatting.UseVisualStyleBackColor = false;
            this.buttonGoChatting.Click += new System.EventHandler(this.buttonGoChatting_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(837, 587);
            this.Controls.Add(this.buttonGoChatting);
            this.Controls.Add(this.buttonDeleteFriend);
            this.Controls.Add(this.listBoxBirthdayList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonGoSetup);
            this.Controls.Add(this.listBoxFriendList);
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

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonGoSetup;
        public System.Windows.Forms.ListBox listBoxFriendList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBirthdayList;
        private System.Windows.Forms.Button buttonDeleteFriend;
        private System.Windows.Forms.Button buttonGoChatting;
    }
}