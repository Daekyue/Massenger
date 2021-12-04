
namespace Client3
{
    partial class SetupForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_LoinClose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNowUserId_Setup = new System.Windows.Forms.Label();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearchFriendId = new System.Windows.Forms.TextBox();
            this.buttonGoSearchFriend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBackgroundColor = new System.Windows.Forms.ComboBox();
            this.buttonBackgroundColor = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(322, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 39);
            this.panel4.TabIndex = 14;
            // 
            // label_LoinClose
            // 
            this.label_LoinClose.AutoSize = true;
            this.label_LoinClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_LoinClose.Location = new System.Drawing.Point(21, 10);
            this.label_LoinClose.Name = "label_LoinClose";
            this.label_LoinClose.Size = new System.Drawing.Size(15, 14);
            this.label_LoinClose.TabIndex = 0;
            this.label_LoinClose.Text = "X";
            this.label_LoinClose.Click += new System.EventHandler(this.labelLoinClose_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 39);
            this.panel3.TabIndex = 13;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNowUserId_Setup);
            this.groupBox2.Controls.Add(this.buttonChangeInfo);
            this.groupBox2.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(31, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(318, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원정보";
            // 
            // labelNowUserId_Setup
            // 
            this.labelNowUserId_Setup.AutoSize = true;
            this.labelNowUserId_Setup.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNowUserId_Setup.Location = new System.Drawing.Point(38, 52);
            this.labelNowUserId_Setup.Name = "labelNowUserId_Setup";
            this.labelNowUserId_Setup.Size = new System.Drawing.Size(90, 13);
            this.labelNowUserId_Setup.TabIndex = 11;
            this.labelNowUserId_Setup.Text = "로그인 된 아이디";
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonChangeInfo.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeInfo.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonChangeInfo.Location = new System.Drawing.Point(204, 46);
            this.buttonChangeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.Size = new System.Drawing.Size(80, 29);
            this.buttonChangeInfo.TabIndex = 9;
            this.buttonChangeInfo.Text = "정보수정";
            this.buttonChangeInfo.UseVisualStyleBackColor = false;
            this.buttonChangeInfo.Click += new System.EventHandler(this.buttonChangeInfo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.textBoxSearchFriendId);
            this.groupBox3.Controls.Add(this.buttonGoSearchFriend);
            this.groupBox3.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(31, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(316, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "친구추가";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(31, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 2);
            this.panel1.TabIndex = 13;
            // 
            // textBoxSearchFriendId
            // 
            this.textBoxSearchFriendId.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxSearchFriendId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchFriendId.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxSearchFriendId.Location = new System.Drawing.Point(33, 42);
            this.textBoxSearchFriendId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchFriendId.Name = "textBoxSearchFriendId";
            this.textBoxSearchFriendId.Size = new System.Drawing.Size(119, 14);
            this.textBoxSearchFriendId.TabIndex = 11;
            // 
            // buttonGoSearchFriend
            // 
            this.buttonGoSearchFriend.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonGoSearchFriend.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonGoSearchFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoSearchFriend.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGoSearchFriend.Location = new System.Drawing.Point(204, 42);
            this.buttonGoSearchFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGoSearchFriend.Name = "buttonGoSearchFriend";
            this.buttonGoSearchFriend.Size = new System.Drawing.Size(80, 25);
            this.buttonGoSearchFriend.TabIndex = 12;
            this.buttonGoSearchFriend.Text = "검색";
            this.buttonGoSearchFriend.UseVisualStyleBackColor = false;
            this.buttonGoSearchFriend.Click += new System.EventHandler(this.buttonGoSearchFriend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBackgroundColor);
            this.groupBox1.Controls.Add(this.buttonBackgroundColor);
            this.groupBox1.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(31, 327);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(318, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "배경색";
            // 
            // comboBoxBackgroundColor
            // 
            this.comboBoxBackgroundColor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.comboBoxBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBackgroundColor.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxBackgroundColor.FormattingEnabled = true;
            this.comboBoxBackgroundColor.Items.AddRange(new object[] {
            "white",
            "red",
            "blue"});
            this.comboBoxBackgroundColor.Location = new System.Drawing.Point(31, 44);
            this.comboBoxBackgroundColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBackgroundColor.Name = "comboBoxBackgroundColor";
            this.comboBoxBackgroundColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBackgroundColor.TabIndex = 0;
            // 
            // buttonBackgroundColor
            // 
            this.buttonBackgroundColor.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonBackgroundColor.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackgroundColor.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonBackgroundColor.Location = new System.Drawing.Point(204, 44);
            this.buttonBackgroundColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackgroundColor.Name = "buttonBackgroundColor";
            this.buttonBackgroundColor.Size = new System.Drawing.Size(80, 25);
            this.buttonBackgroundColor.TabIndex = 1;
            this.buttonBackgroundColor.Text = "변경";
            this.buttonBackgroundColor.UseVisualStyleBackColor = false;
            this.buttonBackgroundColor.Click += new System.EventHandler(this.buttonBackgroundColor_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLogout.Location = new System.Drawing.Point(144, 438);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 28);
            this.buttonLogout.TabIndex = 17;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(158, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "설정";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(382, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetupForm";
            this.Text = "SetuoForm_";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNowUserId_Setup;
        private System.Windows.Forms.Button buttonChangeInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSearchFriendId;
        private System.Windows.Forms.Button buttonGoSearchFriend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBackgroundColor;
        private System.Windows.Forms.Button buttonBackgroundColor;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}