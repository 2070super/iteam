using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace UDPclinet2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        void show(string str)
        {
            frist.AppendText(str + "\r\n");
        }
        void recive()
        {
            int listenPort = Convert.ToInt32(port.Text);
            UdpClient listener = new UdpClient(listenPort);
            IPAddress ip = IPAddress.Parse(address.Text);
            IPEndPoint groupEP = new IPEndPoint(ip, listenPort);
            while (true)
            {

                byte[] bytes = listener.Receive(ref groupEP);//记录接受的长度与内容

                show($"接收到来自 {groupEP} :");
                show($" {Encoding.UTF8.GetString(bytes, 0, bytes.Length)}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//以UDP形式进行传输
            string args = textBox2.Text.Trim();
            byte[] sendbuf = Encoding.UTF8.GetBytes(args);//以UTF8格式进行加密打包
            IPAddress ip = IPAddress.Parse(textBox1.Text);//记录IP地址
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textBox3.Text));//将IP与端口组合

            s.SendTo(sendbuf, point);//发送数据包

            show(DateTime.Now.ToString() + "消息已发送");
            textBox2.Text = "";//清空文本框
        }

        private void button2_Click(object sender, EventArgs e)//接收
        {
            Thread th = new Thread(recive);//开启线程不停的接收信息
            th.IsBackground = true;
            th.Start();
            show(DateTime.Now.ToString()+"已开始监听");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;//禁用线程之间调用检查
        }
    }
}
