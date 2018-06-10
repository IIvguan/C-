using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcpip
{
    public partial class FormMean : Form
    {
        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public FormMean()
        {
            InitializeComponent();
        }
        private void Setcomment_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(textip.Text.Replace(" ",""));//连接到的目标IP
            IPEndPoint point = new IPEndPoint(ip, int.Parse(textport.Text)); //连接到目标IP的哪个应用(端口号！)
            try
            {
                //连接到服务器
                client.Connect(point);
                setcomment.Text = "断开连接";
                ShowMsg("连接成功");
                ShowMsg("服务器" + client.RemoteEndPoint.ToString());
                ShowMsg("客户端:" + client.LocalEndPoint.ToString());
                //连接成功后，就可以接收服务器发送的信息了
                Thread th = new Thread(ReceiveMsg);
                th.IsBackground = true;
                th.Start();
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }                
        }
        //接收服务器的消息
        void ReceiveMsg()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int n = client.Receive(buffer);
                    string s = Encoding.UTF8.GetString(buffer, 0, n);
                    ShowMsg(client.RemoteEndPoint.ToString() + ":" + s);
                }
                catch (Exception ex)
                {
                    ShowMsg(ex.Message);
                    break;
                }
            }
        }
        void ShowMsg(string msg)
        {
            receiveTextBox.AppendText(msg + "\r\n");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //客户端给服务器发消息
            if (client != null)
            {
                try
                {
                    ShowMsg(sendTextBox.Text);
                    byte[] buffer = Encoding.UTF8.GetBytes(sendTextBox.Text);
                    client.Send(buffer);
                    sendTextBox.Text = "";
                }
                catch (Exception ex)
                {
                    ShowMsg(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void receiveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}
