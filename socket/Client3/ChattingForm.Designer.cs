
namespace Client3
{
    partial class ChattingForm
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
            this.textBoxChatting = new System.Windows.Forms.TextBox();
            this.textBoxSendMsg = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonSearchChatting = new System.Windows.Forms.Button();
            this.labelChattingTarget = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(410, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 39);
            this.panel4.TabIndex = 22;
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
            this.panel3.Location = new System.Drawing.Point(3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 39);
            this.panel3.TabIndex = 21;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            // 
            // textBoxChatting
            // 
            this.textBoxChatting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxChatting.Location = new System.Drawing.Point(12, 115);
            this.textBoxChatting.Multiline = true;
            this.textBoxChatting.Name = "textBoxChatting";
            this.textBoxChatting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChatting.Size = new System.Drawing.Size(439, 456);
            this.textBoxChatting.TabIndex = 23;
            // 
            // textBoxSendMsg
            // 
            this.textBoxSendMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSendMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxSendMsg.Location = new System.Drawing.Point(12, 587);
            this.textBoxSendMsg.Name = "textBoxSendMsg";
            this.textBoxSendMsg.Size = new System.Drawing.Size(349, 17);
            this.textBoxSendMsg.TabIndex = 24;
            this.textBoxSendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSendMsg_KeyDown);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSend.Location = new System.Drawing.Point(367, 577);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(79, 38);
            this.buttonSend.TabIndex = 25;
            this.buttonSend.Text = "전송";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonSearchChatting
            // 
            this.buttonSearchChatting.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSearchChatting.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSearchChatting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchChatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearchChatting.Location = new System.Drawing.Point(367, 64);
            this.buttonSearchChatting.Name = "buttonSearchChatting";
            this.buttonSearchChatting.Size = new System.Drawing.Size(79, 38);
            this.buttonSearchChatting.TabIndex = 26;
            this.buttonSearchChatting.Text = "검색";
            this.buttonSearchChatting.UseVisualStyleBackColor = false;
            this.buttonSearchChatting.Click += new System.EventHandler(this.buttonSearchChatting_Click);
            // 
            // labelChattingTarget
            // 
            this.labelChattingTarget.AutoSize = true;
            this.labelChattingTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelChattingTarget.Location = new System.Drawing.Point(12, 69);
            this.labelChattingTarget.Name = "labelChattingTarget";
            this.labelChattingTarget.Size = new System.Drawing.Size(112, 25);
            this.labelChattingTarget.TabIndex = 28;
            this.labelChattingTarget.Text = "채팅 하는 사람";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(431, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 464);
            this.panel1.TabIndex = 29;
            // 
            // ChattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(463, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelChattingTarget);
            this.Controls.Add(this.buttonSearchChatting);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSendMsg);
            this.Controls.Add(this.textBoxChatting);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChattingForm";
            this.Text = "ChattingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChattingForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox textBoxChatting;
        private System.Windows.Forms.TextBox textBoxSendMsg;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonSearchChatting;
        public System.Windows.Forms.Label labelChattingTarget;
        private System.Windows.Forms.Panel panel1;
    }
}