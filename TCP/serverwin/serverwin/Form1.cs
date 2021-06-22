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

namespace serverwin
{
    public partial class Form1 : Form
    {
        Socket socketsend;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                IPAddress ip = IPAddress.Any;//设置服务器为任意IP可接入
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//设定连接方式为tcp
                IPAddress t = IPAddress.Parse("192.168.3.45");//ip地址，这里为服务器内网地址
                IPEndPoint point = new IPEndPoint(t, 8000);//端口设置
                s.Bind(point);//监听端口
                show(DateTime.Now.ToString()+" "+"开始监听");
                s.Listen(10);//最大允许连接为10.
                Thread.Sleep(1000);
                Thread th = new Thread(hear);//创造线程不停的等待新连接
                th.IsBackground = true;//后台运行
                th.Start(s);//启动线程 
                show(DateTime.Now.ToString()+" "+"服务器已启动");
            }
            catch
            { }
        }
        void show(string str)//输出到屏幕上
        {
            Frist.AppendText(str + "\r\n");
        }
        Dictionary<string, Socket> dicsocket = new Dictionary<string, Socket>();//将连接进来的ip和端口号存入集合
        void hear(object o)
        {
            Socket s = o as Socket;//由于多线程只能用object，为了调参数，所以强制转
            while (true)
            {
                try {
                    socketsend = s.Accept();//等待接入
                    dicsocket.Add(socketsend.RemoteEndPoint.ToString(), socketsend);//将连接的IP和端口存入集合
                    userbox.Items.Add(socketsend.RemoteEndPoint.ToString());//将该集合存入下拉菜单里
                    show(DateTime.Now.ToString()+socketsend.RemoteEndPoint.ToString() + "连接成功");//显示接入ip端口
                    Thread th = new Thread(recive);
                    th.IsBackground = true;
                    th.Start(socketsend);//建立线程接受消息
                }
                catch
                { }
                }
           

            void recive(object a)
            {
                Socket socketsend = a as Socket;//由于多线程只能用object，为了调参数，所以强制转

                while (true)
                {
                    try
                    {
                        byte[] text = new byte[1024 * 1024 * 2];//创造一个2MB的空间
                        int i = socketsend.Receive(text);//将接受来的放入text并且记录i字节数
                        if (i == 0)//检查接受的是否为空
                        {
                            break;
                        }
                        string str = Encoding.UTF8.GetString(text, 0, i);//将发来的数据用UTF8解码
                        show(DateTime.Now.ToString()+" "+socketsend.RemoteEndPoint + ":" + str);//显示消息
                    }
                    catch
                    { }
                    }

            }
         
        }
     

        private void Form1_Load_1(object sender, EventArgs e)
        {
          Control.CheckForIllegalCrossThreadCalls = false;//禁用跨线程调用检查
        }

        private void sent_Click(object sender, EventArgs e)
        {
            string str = send.Text;//读取文本框的内容
            byte[] a = System.Text.Encoding.UTF8.GetBytes(str);//利用UTF8形式进行打包
            string ip = userbox.SelectedItem.ToString();//检查下拉框所选中的地址
            dicsocket[ip].Send(a);//发送选中地址的数据
            show(DateTime.Now.ToString()+"服务器：" +" "+ str);
            send.Text = "";

        }
    }
}
