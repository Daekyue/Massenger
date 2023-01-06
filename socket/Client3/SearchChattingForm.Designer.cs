
namespace Client3
{
    partial class SearchChattingForm
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
            this.textBoxResultSearchWord = new System.Windows.Forms.TextBox();
            this.buttonGoSearchWord = new System.Windows.Forms.Button();
            this.textBoxSearchWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_LoinClose);
            this.panel4.Location = new System.Drawing.Point(353, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 39);
            this.panel4.TabIndex = 12;
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
            this.panel3.Location = new System.Drawing.Point(1, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 39);
            this.panel3.TabIndex = 11;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            // 
            // textBoxResultSearchWord
            // 
            this.textBoxResultSearchWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxResultSearchWord.Location = new System.Drawing.Point(26, 115);
            this.textBoxResultSearchWord.Multiline = true;
            this.textBoxResultSearchWord.Name = "textBoxResultSearchWord";
            this.textBoxResultSearchWord.Size = new System.Drawing.Size(358, 286);
            this.textBoxResultSearchWord.TabIndex = 15;
            // 
            // buttonGoSearchWord
            // 
            this.buttonGoSearchWord.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonGoSearchWord.FlatAppearance.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonGoSearchWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGoSearchWord.Location = new System.Drawing.Point(309, 62);
            this.buttonGoSearchWord.Name = "buttonGoSearchWord";
            this.buttonGoSearchWord.Size = new System.Drawing.Size(75, 31);
            this.buttonGoSearchWord.TabIndex = 14;
            this.buttonGoSearchWord.Text = "검색";
            this.buttonGoSearchWord.UseVisualStyleBackColor = false;
            this.buttonGoSearchWord.Click += new System.EventHandler(this.buttonGoSearchWord_Click);
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxSearchWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxSearchWord.Location = new System.Drawing.Point(26, 67);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(277, 17);
            this.textBoxSearchWord.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(26, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 2);
            this.panel1.TabIndex = 16;
            // 
            // SearchChattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxResultSearchWord);
            this.Controls.Add(this.buttonGoSearchWord);
            this.Controls.Add(this.textBoxSearchWord);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchChattingForm";
            this.Text = "SearchChattingForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_LoinClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxResultSearchWord;
        private System.Windows.Forms.Button buttonGoSearchWord;
        private System.Windows.Forms.TextBox textBoxSearchWord;
        private System.Windows.Forms.Panel panel1;
    }
}