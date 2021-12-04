
namespace Client2
{
    partial class Client2_chat_form
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
            this.Client2_button_send = new System.Windows.Forms.Button();
            this.Client2_textbox_chat = new System.Windows.Forms.TextBox();
            this.Client2_textbox_chatview = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Client2_button_send
            // 
            this.Client2_button_send.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Client2_button_send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Client2_button_send.Location = new System.Drawing.Point(476, 579);
            this.Client2_button_send.Name = "Client2_button_send";
            this.Client2_button_send.Size = new System.Drawing.Size(75, 38);
            this.Client2_button_send.TabIndex = 5;
            this.Client2_button_send.Text = "전송";
            this.Client2_button_send.UseVisualStyleBackColor = true;
            this.Client2_button_send.Click += new System.EventHandler(this.Client2_button_send_Click);
            // 
            // Client2_textbox_chat
            // 
            this.Client2_textbox_chat.Location = new System.Drawing.Point(53, 591);
            this.Client2_textbox_chat.Name = "Client2_textbox_chat";
            this.Client2_textbox_chat.Size = new System.Drawing.Size(417, 21);
            this.Client2_textbox_chat.TabIndex = 4;
            // 
            // Client2_textbox_chatview
            // 
            this.Client2_textbox_chatview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Client2_textbox_chatview.Location = new System.Drawing.Point(53, 53);
            this.Client2_textbox_chatview.Multiline = true;
            this.Client2_textbox_chatview.Name = "Client2_textbox_chatview";
            this.Client2_textbox_chatview.Size = new System.Drawing.Size(498, 515);
            this.Client2_textbox_chatview.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(584, 133);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 12);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "label1";
            // 
            // Client2_chat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 708);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.Client2_button_send);
            this.Controls.Add(this.Client2_textbox_chat);
            this.Controls.Add(this.Client2_textbox_chatview);
            this.Name = "Client2_chat_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Client2_button_send;
        private System.Windows.Forms.TextBox Client2_textbox_chat;
        private System.Windows.Forms.TextBox Client2_textbox_chatview;
        private System.Windows.Forms.Label label_name;
    }
}

