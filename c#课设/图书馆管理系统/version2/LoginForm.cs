using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo01;
using MySql.Data.MySqlClient;

namespace demo01
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        

        private void clear_Click(object sender, EventArgs e)
        {
            zhanghao.Text = "";
            mima.Text = "";
        }

        
        //登陆方法，判断是否可以登录，true为可以登录，false为拒绝登录
         

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        

        private void login_Click(object sender, EventArgs e)
        {
            if (zhanghao.Text != "" && mima.Text != "")
            {
                logincheck();
            }
            else
            {
                MessageBox.Show("输入有空项");
            }
        }
        public void logincheck()
        {
            //用户
            if (radiouser.Checked == true)
            {
                Dao dao = new Dao();
                /*String sql = "select * from user where uid = '" + zhanghao.Text + "' and upassword = '" + mima.Text + "'";
                MessageBox.Show(sql);
                String sql1 = String.Format("select * from user where uid = '{1}' and upassword = '{2}'",zhanghao.Text,mima.Text);9*/
                String sql = $"select * from yonghu where yid = '{zhanghao.Text}' and ypassword = '{mima.Text}';";
                //MessageBox.Show(sql);
                MySqlDataReader dc = dao.read(sql);

                if (dc.Read())
                {
                    Loginerinfor.id = dc["yid"].ToString();
                    Loginerinfor.name = dc["yname"].ToString();
                    Loginerinfor.password = dc["ypassword"].ToString();
                    Loginerinfor.typeid = 2;
                    MessageBox.Show("登陆成功");
                    YonghuForm yonghuform = new YonghuForm();
                    this.Hide();
                    yonghuform.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("登录失败");
                }
                dao.DaoClose();

            }
            //管理员
            else if (radiomanager.Checked == true)
            {
                Dao dao = new Dao();
                /*String sql = "select * from user where uid = '" + zhanghao.Text + "' and upassword = '" + mima.Text + "'";
                MessageBox.Show(sql);
                String sql1 = String.Format("select * from user where uid = '{1}' and upassword = '{2}'",zhanghao.Text,mima.Text);9*/
                String sql = $"select * from manager where mid = '{zhanghao.Text}' and mpassword = '{mima.Text}'";
                MySqlDataReader dc = dao.read(sql);

                if (dc.Read())
                {
                    Loginerinfor.id = dc["mid"].ToString();
                    Loginerinfor.name = dc["mname"].ToString();
                    Loginerinfor.password = dc["mpassword"].ToString();
                    Loginerinfor.typeid = 2;
                    MessageBox.Show("登陆成功");
                    Managerbook managerbook = new Managerbook();
                    this.Hide();
                    managerbook.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("单选框请先选中");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertyonghu insert = new Insertyonghu();
            insert.ShowDialog();
        }
    }
}
