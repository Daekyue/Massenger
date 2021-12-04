
namespace Client3
{
    partial class Client3_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client3_login));
            this.client3_button_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.client3_textbox_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // client3_button_login
            // 
            this.client3_button_login.Location = new System.Drawing.Point(414, 433);
            this.client3_button_login.Name = "client3_button_login";
            this.client3_button_login.Size = new System.Drawing.Size(100, 55);
            this.client3_button_login.TabIndex = 7;
            this.client3_button_login.Text = "Log-In";
            this.client3_button_login.UseVisualStyleBackColor = true;
            this.client3_button_login.Click += new System.EventHandler(this.client3_button_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "< 로그인 >";
            // 
            // client3_textbox_name
            // 
            this.client3_textbox_name.Location = new System.Drawing.Point(212, 451);
            this.client3_textbox_name.Name = "client3_textbox_name";
            this.client3_textbox_name.Size = new System.Drawing.Size(165, 21);
            this.client3_textbox_name.TabIndex = 4;
            this.client3_textbox_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.client3_textbox_name_KeyDown);
            // 
            // Client3_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 615);
            this.Controls.Add(this.client3_button_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client3_textbox_name);
            this.Name = "Client3_login";
            this.Text = "Client3_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button client3_button_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox client3_textbox_name;
    }
}