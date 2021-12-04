
namespace Client3
{
    partial class Client3_chatroom_list
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
            this.groupbox_chatlist = new System.Windows.Forms.GroupBox();
            this.ChatRoomView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupbox_chatlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_chatlist
            // 
            this.groupbox_chatlist.Controls.Add(this.ChatRoomView);
            this.groupbox_chatlist.Location = new System.Drawing.Point(30, 26);
            this.groupbox_chatlist.Name = "groupbox_chatlist";
            this.groupbox_chatlist.Size = new System.Drawing.Size(485, 555);
            this.groupbox_chatlist.TabIndex = 0;
            this.groupbox_chatlist.TabStop = false;
            this.groupbox_chatlist.Text = "채팅방 목록";
            // 
            // ChatRoomView
            // 
            this.ChatRoomView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ChatRoomView.GridLines = true;
            this.ChatRoomView.HideSelection = false;
            this.ChatRoomView.Location = new System.Drawing.Point(7, 32);
            this.ChatRoomView.Name = "ChatRoomView";
            this.ChatRoomView.Size = new System.Drawing.Size(472, 517);
            this.ChatRoomView.TabIndex = 0;
            this.ChatRoomView.UseCompatibleStateImageBehavior = false;
            this.ChatRoomView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "방번호";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "방제목";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "인원";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "방장";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "속성";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "입장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EnterChatRoomButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 587);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Client3_chatroom_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 660);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupbox_chatlist);
            this.Name = "Client3_chatroom_list";
            this.Text = "Client3_chatroom_list";
            this.groupbox_chatlist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_chatlist;
        private System.Windows.Forms.ListView ChatRoomView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}