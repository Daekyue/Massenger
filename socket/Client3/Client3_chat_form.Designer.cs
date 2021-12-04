
namespace Client3
{
    partial class Client3_chat_form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.Client3_button_send = new System.Windows.Forms.Button();
            this.Client3_textbox_chat = new System.Windows.Forms.TextBox();
            this.Client3_textbox_chatview = new System.Windows.Forms.TextBox();
            this.Client3_label_name = new System.Windows.Forms.Label();
            this.Client3_list_chat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Client3_chatlist = new System.Windows.Forms.TextBox();
            this.ChatRoomNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(753, 92);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 20);
            this.label_name.TabIndex = 7;
            // 
            // Client3_button_send
            // 
            this.Client3_button_send.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Client3_button_send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Client3_button_send.Location = new System.Drawing.Point(530, 699);
            this.Client3_button_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Client3_button_send.Name = "Client3_button_send";
            this.Client3_button_send.Size = new System.Drawing.Size(86, 48);
            this.Client3_button_send.TabIndex = 6;
            this.Client3_button_send.Text = "전송";
            this.Client3_button_send.UseVisualStyleBackColor = true;
            this.Client3_button_send.Click += new System.EventHandler(this.Client3_button_send_Click);
            // 
            // Client3_textbox_chat
            // 
            this.Client3_textbox_chat.Location = new System.Drawing.Point(34, 714);
            this.Client3_textbox_chat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Client3_textbox_chat.Name = "Client3_textbox_chat";
            this.Client3_textbox_chat.Size = new System.Drawing.Size(476, 25);
            this.Client3_textbox_chat.TabIndex = 5;
            this.Client3_textbox_chat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Client3_textbox_chat_KeyDown);
            // 
            // Client3_textbox_chatview
            // 
            this.Client3_textbox_chatview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Client3_textbox_chatview.Location = new System.Drawing.Point(34, 69);
            this.Client3_textbox_chatview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Client3_textbox_chatview.Multiline = true;
            this.Client3_textbox_chatview.Name = "Client3_textbox_chatview";
            this.Client3_textbox_chatview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Client3_textbox_chatview.Size = new System.Drawing.Size(581, 613);
            this.Client3_textbox_chatview.TabIndex = 4;
            // 
            // Client3_label_name
            // 
            this.Client3_label_name.AutoSize = true;
            this.Client3_label_name.Location = new System.Drawing.Point(757, 155);
            this.Client3_label_name.Name = "Client3_label_name";
            this.Client3_label_name.Size = new System.Drawing.Size(0, 15);
            this.Client3_label_name.TabIndex = 8;
            // 
            // Client3_list_chat
            // 
            this.Client3_list_chat.FormattingEnabled = true;
            this.Client3_list_chat.ItemHeight = 15;
            this.Client3_list_chat.Location = new System.Drawing.Point(637, 400);
            this.Client3_list_chat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Client3_list_chat.Name = "Client3_list_chat";
            this.Client3_list_chat.Size = new System.Drawing.Size(257, 184);
            this.Client3_list_chat.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "내 아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "대화 참여자";
            // 
            // Client3_chatlist
            // 
            this.Client3_chatlist.Location = new System.Drawing.Point(637, 181);
            this.Client3_chatlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Client3_chatlist.Multiline = true;
            this.Client3_chatlist.Name = "Client3_chatlist";
            this.Client3_chatlist.Size = new System.Drawing.Size(257, 200);
            this.Client3_chatlist.TabIndex = 12;
            // 
            // ChatRoomNameLabel
            // 
            this.ChatRoomNameLabel.AutoSize = true;
            this.ChatRoomNameLabel.Location = new System.Drawing.Point(251, 30);
            this.ChatRoomNameLabel.Name = "ChatRoomNameLabel";
            this.ChatRoomNameLabel.Size = new System.Drawing.Size(57, 15);
            this.ChatRoomNameLabel.TabIndex = 13;
            this.ChatRoomNameLabel.Text = "방 제목";
            // 
            // Client3_chat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(917, 794);
            this.Controls.Add(this.ChatRoomNameLabel);
            this.Controls.Add(this.Client3_chatlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Client3_list_chat);
            this.Controls.Add(this.Client3_label_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.Client3_button_send);
            this.Controls.Add(this.Client3_textbox_chat);
            this.Controls.Add(this.Client3_textbox_chatview);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Client3_chat_form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client3_chat_form_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button Client3_button_send;
        private System.Windows.Forms.TextBox Client3_textbox_chat;
        private System.Windows.Forms.TextBox Client3_textbox_chatview;
        private System.Windows.Forms.Label Client3_label_name;
        private System.Windows.Forms.ListBox Client3_list_chat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Client3_chatlist;
        private System.Windows.Forms.Label ChatRoomNameLabel;
    }
}

