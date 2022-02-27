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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (YGXM.Text == "")
            {
                MessageBox.Show("请输入要修改的员工姓名！");
                YGGH.Clear();
                YGXM.Clear();
                YGBM.Clear();
                YGZW.Clear();

            }
            else if (YGXM.Text != "")
            {
                DBClass.conn.Open();
                DataSet dsMydataBase = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBClass.conn;
                cmd.CommandText = "select [YGXM] from [YGB] where [YGXM] ='" + YGXM.Text + "'";
                cmd.ExecuteNonQuery();
                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("该员工不存在！");
                    YGGH.Clear();
                    YGXM.Clear();
                    YGBM.Clear();
                    YGZW.Clear();
                    DBClass.conn.Close();
                    return;
                }
                if (true)
                {
                    if (!string.IsNullOrEmpty(YGGH.Text))
                    {
                        cmd.CommandText = "update YGB set YGXM='" + YGXM.Text + "'," + "YGGH='" + YGGH.Text + "where'YGGH='" + YGXM.Text + "'";
                        cmd.ExecuteNonQuery();
                    }
                }
                if (true)
                {
                    if (!string.IsNullOrEmpty(YGBM.Text))
                    {
                        cmd.CommandText = "update YGB set YGXM='" + YGXM.Text + "'," + "YGBM='" + YGBM.Text + "'where YGXM='" + YGXM.Text + "'";
                        cmd.ExecuteNonQuery();
                    }
                }
                if (true)
                {
                    if (!string.IsNullOrEmpty(YGZW.Text))
                    {
                        cmd.CommandText = "update YGB set YGXM='" + YGXM.Text + "'," + "YGZW='" + YGZW.Text + "'where YGXM='" + YGXM.Text + "'";
                        cmd.ExecuteNonQuery();
                    }
                }



                cmd.ExecuteNonQuery();
                DBClass.conn.Close();
                MessageBox.Show("修改成功！");
                YGGH.Clear();
                YGXM.Clear();
                YGBM.Clear();
                YGZW.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }

        private void YGBM_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
