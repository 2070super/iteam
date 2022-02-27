using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 员工信息管理系统.Form1;

namespace 员工信息管理系统
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void YGGH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (YGGH.Text == "")
            {
                MessageBox.Show("请输入要删除的员工工号！");
            }
            else if (YGGH.Text != "")
            {
                DBClass.conn.Open();
                DataSet dsMydataBase = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBClass.conn;
                cmd.CommandText = "select [YGGH] from [YGB] where [YGGH] ='" + YGGH.Text + "'";
                cmd.ExecuteNonQuery();
                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("工号不存在！");
                    YGGH.Clear();
                    DBClass.conn.Close();
                    return;
                }
                else
                {
                    cmd.CommandText = "delete from YGB where[YGGH]= '" + YGGH.Text + "'";
                    cmd.ExecuteNonQuery();
                    DBClass.conn.Close();
                    MessageBox.Show("删除成功");
                    YGGH.Clear();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }
    }
}
