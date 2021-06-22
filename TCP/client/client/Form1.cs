using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
namespace client
{
    public partial class Form1 : Form
    {
        Socket socketsend;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//发送
        {
            try
            {
                string str = meg.Text.Trim();
                byte[] a = System.Text.Encoding.UTF8.GetBytes(str);
                socketsend.Send(a);
                show(DateTime.Now.ToString() + " " + "用户：" + str);
                meg.Text = "";
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)//连接
        {
            try
            {
                socketsend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(address.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(port.Text));
                socketsend.Connect(point);
                show(DateTime.Now.ToString()+" " + "连接成功");
                Thread th = new Thread(recive);//建立线程进行接收数据
                th.IsBackground = true;
                th.Start();
            }
            catch
            { }
        }
        void show(string str)
        {
         top.AppendText(str+"\r\n"); 
        }
        void recive()
        {

            try
            {
                while (true)
                {
                    byte[] a = new byte[1024 * 1024 * 2];
                    int r = socketsend.Receive(a);
                    if (r == 0)
                    {
                        break;
                    }
                    string s = Encoding.UTF8.GetString(a, 0, r);
                    show(DateTime.Now.ToString()+" " + socketsend.RemoteEndPoint + "：" + s);
                }
            }
            catch { }
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
