namespace tcpip
{
    partial class FormMean
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMean));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.start = new System.Windows.Forms.ToolStripMenuItem();
            this.你好ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setcomment = new System.Windows.Forms.Button();
            this.textip = new System.Windows.Forms.MaskedTextBox();
            this.textport = new System.Windows.Forms.MaskedTextBox();
            this.sendTextBox = new System.Windows.Forms.RichTextBox();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start,
            this.help,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Window;
            this.start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.你好ToolStripMenuItem});
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(51, 24);
            this.start.Text = "开始";
            // 
            // 你好ToolStripMenuItem
            // 
            this.你好ToolStripMenuItem.Name = "你好ToolStripMenuItem";
            this.你好ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.你好ToolStripMenuItem.Text = "你好";
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(51, 24);
            this.help.Text = "帮助";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(51, 24);
            this.exit.Text = "退出";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // setcomment
            // 
            this.setcomment.Location = new System.Drawing.Point(592, 64);
            this.setcomment.Name = "setcomment";
            this.setcomment.Size = new System.Drawing.Size(107, 28);
            this.setcomment.TabIndex = 3;
            this.setcomment.Text = "连接";
            this.setcomment.UseVisualStyleBackColor = true;
            this.setcomment.Click += new System.EventHandler(this.Setcomment_Click);
            // 
            // textip
            // 
            this.textip.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textip.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textip.Location = new System.Drawing.Point(132, 64);
            this.textip.Mask = "000.000.000.000";
            this.textip.Name = "textip";
            this.textip.PromptChar = ' ';
            this.textip.Size = new System.Drawing.Size(198, 28);
            this.textip.TabIndex = 5;
            this.textip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textport
            // 
            this.textport.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textport.Location = new System.Drawing.Point(430, 66);
            this.textport.Mask = "9999";
            this.textport.Name = "textport";
            this.textport.PromptChar = ' ';
            this.textport.Size = new System.Drawing.Size(121, 25);
            this.textport.TabIndex = 6;
            this.textport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textport.ValidatingType = typeof(int);
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(154, 281);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(423, 140);
            this.sendTextBox.TabIndex = 8;
            this.sendTextBox.Text = "";
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(154, 113);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.Size = new System.Drawing.Size(423, 143);
            this.receiveTextBox.TabIndex = 9;
            this.receiveTextBox.Text = "";
            this.receiveTextBox.TextChanged += new System.EventHandler(this.receiveTextBox_TextChanged);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(607, 362);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(107, 39);
            this.SendMessage.TabIndex = 10;
            this.SendMessage.Text = "发送消息";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "端口号";
            // 
            // FormMean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.receiveTextBox);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.textip);
            this.Controls.Add(this.textport);
            this.Controls.Add(this.setcomment);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMean";
            this.Text = "TCP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem start;
        private System.Windows.Forms.ToolStripMenuItem 你好ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button setcomment;
        private System.Windows.Forms.MaskedTextBox textip;
        private System.Windows.Forms.MaskedTextBox textport;
        private System.Windows.Forms.RichTextBox sendTextBox;
        private System.Windows.Forms.RichTextBox receiveTextBox;
        private System.Windows.Forms.Button SendMessage;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

