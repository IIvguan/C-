namespace tcpipsever
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Textip = new System.Windows.Forms.MaskedTextBox();
            this.Textporn = new System.Windows.Forms.MaskedTextBox();
            this.listenerbotn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewtext = new System.Windows.Forms.RichTextBox();
            this.sendtext = new System.Windows.Forms.RichTextBox();
            this.sendmessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Textip
            // 
            this.Textip.Location = new System.Drawing.Point(31, 39);
            this.Textip.Mask = "999.999.999.999";
            this.Textip.Name = "Textip";
            this.Textip.PromptChar = ' ';
            this.Textip.Size = new System.Drawing.Size(200, 25);
            this.Textip.TabIndex = 0;
            this.Textip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Textporn
            // 
            this.Textporn.Location = new System.Drawing.Point(277, 39);
            this.Textporn.Mask = "9999";
            this.Textporn.Name = "Textporn";
            this.Textporn.PromptChar = ' ';
            this.Textporn.Size = new System.Drawing.Size(92, 25);
            this.Textporn.TabIndex = 1;
            this.Textporn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listenerbotn
            // 
            this.listenerbotn.Location = new System.Drawing.Point(429, 39);
            this.listenerbotn.Name = "listenerbotn";
            this.listenerbotn.Size = new System.Drawing.Size(85, 25);
            this.listenerbotn.TabIndex = 2;
            this.listenerbotn.Text = "开始监听";
            this.listenerbotn.UseVisualStyleBackColor = true;
            this.listenerbotn.Click += new System.EventHandler(this.listenerbotn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(561, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // viewtext
            // 
            this.viewtext.Location = new System.Drawing.Point(129, 86);
            this.viewtext.Name = "viewtext";
            this.viewtext.Size = new System.Drawing.Size(506, 169);
            this.viewtext.TabIndex = 4;
            this.viewtext.Text = "";
            // 
            // sendtext
            // 
            this.sendtext.Location = new System.Drawing.Point(129, 279);
            this.sendtext.Name = "sendtext";
            this.sendtext.Size = new System.Drawing.Size(506, 171);
            this.sendtext.TabIndex = 5;
            this.sendtext.Text = "";
            // 
            // sendmessage
            // 
            this.sendmessage.Location = new System.Drawing.Point(720, 400);
            this.sendmessage.Name = "sendmessage";
            this.sendmessage.Size = new System.Drawing.Size(102, 50);
            this.sendmessage.TabIndex = 6;
            this.sendmessage.Text = "发送消息";
            this.sendmessage.UseVisualStyleBackColor = true;
            this.sendmessage.Click += new System.EventHandler(this.sendmessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 500);
            this.Controls.Add(this.sendmessage);
            this.Controls.Add(this.sendtext);
            this.Controls.Add(this.viewtext);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listenerbotn);
            this.Controls.Add(this.Textporn);
            this.Controls.Add(this.Textip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Textip;
        private System.Windows.Forms.MaskedTextBox Textporn;
        private System.Windows.Forms.Button listenerbotn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox viewtext;
        private System.Windows.Forms.RichTextBox sendtext;
        private System.Windows.Forms.Button sendmessage;
    }
}

