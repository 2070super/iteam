using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 员工信息管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            if (YGZH.Text == "" || YGMM.Text == "")
            {
                MessageBox.Show("管理员ID和密码不能为空");
            }
            else
            {
                DBClass.conn.Open();
                DataSet dsMydataBase = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBClass.conn;
                cmd.CommandText = "select [YGZH] from [YGB] where [YGZH] ='" + YGZH.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                
                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("ID不存在！");
                    YGZH.Clear();
                    YGMM.Clear();
                    DBClass.conn.Close();
                    return;
                }
                else
                {
                    cmd.CommandText = "select [YGMM] from [YGB] where [YGZH] ='" + YGZH.Text + "'";
                    cmd.ExecuteNonQuery();
                    if (YGMM.Text == "222")
                    {
                        DBClass.conn.Close();
                        MessageBox.Show(" 登录成功！");
                        Home ho = new Home();
                        ho.Show();
                        this.Hide();
                    }
                    else if (YGMM.Text != cmd.ExecuteScalar().ToString())
                    {
                        MessageBox.Show("密码错误");
                        YGZH.Clear();
                        YGMM.Clear();
                        DBClass.conn.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void YGMM_TextChanged(object sender, EventArgs e)
        {
            YGMM.PasswordChar = '*';
        }
        public static class DBClass
        {
            public static string strConn =  @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YGXXGLB;Integrated Security=True";
            public static SqlConnection conn = new SqlConnection(strConn);
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
