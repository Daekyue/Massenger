
using System.Drawing;

namespace Client3
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginId = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGoLogin = new System.Windows.Forms.Button();
            this.labelGoJoin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_LoinClose = new System.Windows.Forms.Label();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(81, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 ";
            // 
            // textBoxLoginId
            // 
            this.textBoxLoginId.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxLoginId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginId.Location = new System.Drawing.Point(154, 173);
            this.textBoxLoginId.Name = "textBoxLoginId";
            this.textBoxLoginId.Size = new System.Drawing.Size(143, 18);
            this.textBoxLoginId.TabIndex = 1;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginPassword.Location = new System.Drawing.Point(154, 229);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(143, 18);
            this.textBoxLoginPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(71, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Font = new System.Drawing.Font("굴림", 3F);
            this.panel1.Location = new System.Drawing.Point(154, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 2);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Font = new System.Drawing.Font("굴림", 3F);
            this.panel2.Location = new System.Drawing.Point(154, 245);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 2);
            this.panel2.TabIndex = 6;
            // 
            // buttonGoLogin
            // 
            this.buttonGoLogin.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonGoLogin.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonGoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoLogin.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGoLogin.Location = new System.Drawing.Point(133, 288);
            this.buttonGoLogin.Name = "buttonGoLogin";
            this.buttonGoLogin.Size = new System.Drawing.Size(131, 41);
            this.buttonGoLogin.TabIndex = 7;
            this.buttonGoLogin.Text = "로그인";
            this.buttonGoLogin.UseVisualStyleBackColor = false;
            this.buttonGoLogin.Click += new System.EventHandler(this.buttonGoLogin_Click);
            // 
            // labelGoJoin
            // 
            this.labelGoJoin.AutoSize = true;
            this.labelGoJoin.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGoJoin.Location = new System.Drawing.Point(223, 374);
            this.labelGoJoin.Name = "labelGoJoin";
            this.labelGoJoin.Size = new System.Drawing.Size(51, 13);
            this.labelGoJoin.TabIndex = 8;
            this.labelGoJoin.Text = "회원가입";
            this.labelGoJoin.Click += new System.EventHandler(this.labelGoJoin_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 39);
            this.panel3.TabIndex = 9;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(358, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(46, 39);
            this.panel4.TabIndex = 10;
            // 
            // label_LoinClose
            // 
            this.label_LoinClose.AutoSize = true;
            this.label_LoinClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_LoinClose.Location = new System.Drawing.Point(15, 10);
            this.label_LoinClose.Name = "label_LoinClose";
            this.label_LoinClose.Size = new System.Drawing.Size(15, 14);
            this.label_LoinClose.TabIndex = 0;
            this.label_LoinClose.Text = "X";
            this.label_LoinClose.Click += new System.EventHandler(this.labelLoinClose_Click);
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.checkBoxAutoLogin.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.checkBoxAutoLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.BurlyWood;
            this.checkBoxAutoLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.checkBoxAutoLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.checkBoxAutoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAutoLogin.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(84, 372);
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAutoLogin.TabIndex = 11;
            this.checkBoxAutoLogin.Text = "자동로그인";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = false;
            this.checkBoxAutoLogin.Click += new System.EventHandler(this.checkBoxAutoLogin_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelGoJoin);
            this.Controls.Add(this.buttonGoLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLoginId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
 
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginId;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonGoLogin;
        private System.Windows.Forms.Label labelGoJoin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.CheckBox checkBoxAutoLogin;
    }
}