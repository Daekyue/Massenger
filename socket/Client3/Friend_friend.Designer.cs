
namespace Client3
{
    partial class Friend_friend
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_LoinClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFriend_friend = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 39);
            this.panel3.TabIndex = 19;
            // 
            // label_LoinClose
            // 
            this.label_LoinClose.AutoSize = true;
            this.label_LoinClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_LoinClose.Location = new System.Drawing.Point(18, 10);
            this.label_LoinClose.Name = "label_LoinClose";
            this.label_LoinClose.Size = new System.Drawing.Size(15, 14);
            this.label_LoinClose.TabIndex = 0;
            this.label_LoinClose.Text = "X";
            this.label_LoinClose.Click += new System.EventHandler(this.label_LoinClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 12F);
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "친구의 친구 검색 결과";
            // 
            // listBoxFriend_friend
            // 
            this.listBoxFriend_friend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFriend_friend.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxFriend_friend.FormattingEnabled = true;
            this.listBoxFriend_friend.Location = new System.Drawing.Point(18, 128);
            this.listBoxFriend_friend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriend_friend.Name = "listBoxFriend_friend";
            this.listBoxFriend_friend.Size = new System.Drawing.Size(390, 143);
            this.listBoxFriend_friend.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(372, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 39);
            this.panel4.TabIndex = 20;
            // 
            // Friend_friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(427, 311);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFriend_friend);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Friend_friend";
            this.Text = "Friend_friend";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFriend_friend;
        private System.Windows.Forms.Panel panel4;
    }
}