
namespace Client3
{
    partial class SearchFriend
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddFriend = new System.Windows.Forms.Button();
            this.listBoxResultSearchFriend = new System.Windows.Forms.ListBox();
            this.buttonSearchFriend_friend = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(370, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 39);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label_LoinClose
            // 
            this.label_LoinClose.AutoSize = true;
            this.label_LoinClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_LoinClose.Location = new System.Drawing.Point(18, 10);
            this.label_LoinClose.Name = "label_LoinClose";
            this.label_LoinClose.Size = new System.Drawing.Size(18, 17);
            this.label_LoinClose.TabIndex = 0;
            this.label_LoinClose.Text = "X";
            this.label_LoinClose.Click += new System.EventHandler(this.labelLoinClose_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-1, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 39);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 12F);
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "친구 검색 결과";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAddFriend
            // 
            this.buttonAddFriend.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonAddFriend.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFriend.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAddFriend.Location = new System.Drawing.Point(80, 290);
            this.buttonAddFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddFriend.Name = "buttonAddFriend";
            this.buttonAddFriend.Size = new System.Drawing.Size(75, 31);
            this.buttonAddFriend.TabIndex = 16;
            this.buttonAddFriend.Text = "추가";
            this.buttonAddFriend.UseVisualStyleBackColor = false;
            this.buttonAddFriend.Click += new System.EventHandler(this.buttonAddFriend_Click);
            // 
            // listBoxResultSearchFriend
            // 
            this.listBoxResultSearchFriend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResultSearchFriend.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxResultSearchFriend.FormattingEnabled = true;
            this.listBoxResultSearchFriend.ItemHeight = 17;
            this.listBoxResultSearchFriend.Location = new System.Drawing.Point(16, 119);
            this.listBoxResultSearchFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxResultSearchFriend.Name = "listBoxResultSearchFriend";
            this.listBoxResultSearchFriend.Size = new System.Drawing.Size(390, 153);
            this.listBoxResultSearchFriend.TabIndex = 15;
            this.listBoxResultSearchFriend.SelectedIndexChanged += new System.EventHandler(this.listBoxResultSearchFriend_SelectedIndexChanged);
            // 
            // buttonSearchFriend_friend
            // 
            this.buttonSearchFriend_friend.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSearchFriend_friend.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSearchFriend_friend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchFriend_friend.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearchFriend_friend.Location = new System.Drawing.Point(200, 290);
            this.buttonSearchFriend_friend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchFriend_friend.Name = "buttonSearchFriend_friend";
            this.buttonSearchFriend_friend.Size = new System.Drawing.Size(172, 31);
            this.buttonSearchFriend_friend.TabIndex = 18;
            this.buttonSearchFriend_friend.Text = "친구의 친구 찾기";
            this.buttonSearchFriend_friend.UseVisualStyleBackColor = false;
            this.buttonSearchFriend_friend.Click += new System.EventHandler(this.buttonSearchFriend_friend_Click);
            // 
            // SearchFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(427, 345);
            this.Controls.Add(this.buttonSearchFriend_friend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddFriend);
            this.Controls.Add(this.listBoxResultSearchFriend);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchFriend";
            this.Text = "SearchFriend";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddFriend;
        private System.Windows.Forms.ListBox listBoxResultSearchFriend;
        private System.Windows.Forms.Button buttonSearchFriend_friend;
    }
}