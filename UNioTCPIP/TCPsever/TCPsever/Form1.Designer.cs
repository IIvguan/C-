namespace TCPsever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textip = new System.Windows.Forms.MaskedTextBox();
            this.textpron = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.showtext = new System.Windows.Forms.RichTextBox();
            this.sendtext = new System.Windows.Forms.RichTextBox();
            this.sendmassage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textip
            // 
            this.textip.Font = new System.Drawing.Font("宋体", 12F);
            this.textip.Location = new System.Drawing.Point(57, 36);
            this.textip.Mask = "000.000.000.000";
            this.textip.Name = "textip";
            this.textip.Size = new System.Drawing.Size(194, 30);
            this.textip.TabIndex = 0;
            this.textip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textip.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textpron
            // 
            this.textpron.Font = new System.Drawing.Font("宋体", 12F);
            this.textpron.Location = new System.Drawing.Point(375, 36);
            this.textpron.Mask = "00000";
            this.textpron.Name = "textpron";
            this.textpron.Size = new System.Drawing.Size(107, 30);
            this.textpron.TabIndex = 1;
            this.textpron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textpron.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(310, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("宋体", 12F);
            this.connect.Location = new System.Drawing.Point(585, 26);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(124, 40);
            this.connect.TabIndex = 4;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // showtext
            // 
            this.showtext.Location = new System.Drawing.Point(57, 95);
            this.showtext.Name = "showtext";
            this.showtext.Size = new System.Drawing.Size(635, 212);
            this.showtext.TabIndex = 5;
            this.showtext.Text = "";
            this.showtext.TextChanged += new System.EventHandler(this.showtext_TextChanged);
            // 
            // sendtext
            // 
            this.sendtext.Location = new System.Drawing.Point(57, 327);
            this.sendtext.Name = "sendtext";
            this.sendtext.Size = new System.Drawing.Size(635, 106);
            this.sendtext.TabIndex = 6;
            this.sendtext.Text = "";
            // 
            // sendmassage
            // 
            this.sendmassage.AutoSize = true;
            this.sendmassage.Font = new System.Drawing.Font("宋体", 12F);
            this.sendmassage.Location = new System.Drawing.Point(585, 458);
            this.sendmassage.Name = "sendmassage";
            this.sendmassage.Size = new System.Drawing.Size(124, 37);
            this.sendmassage.TabIndex = 7;
            this.sendmassage.Text = "发送信息";
            this.sendmassage.UseVisualStyleBackColor = true;
            this.sendmassage.Click += new System.EventHandler(this.sendmassage_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.sendmassage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.sendmassage);
            this.Controls.Add(this.sendtext);
            this.Controls.Add(this.showtext);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpron);
            this.Controls.Add(this.textip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textip;
        private System.Windows.Forms.MaskedTextBox textpron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.RichTextBox showtext;
        private System.Windows.Forms.RichTextBox sendtext;
        private System.Windows.Forms.Button sendmassage;
    }
}

