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
using static 员工信息管理系统.Form1;

namespace 员工信息管理系统
{
    public partial class Add : Form
    {
        private readonly object dataGridView1;

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void YGXM_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }

        private void 完成_Click(object sender, EventArgs e)
        {
            if (YGXM.Text == "")
            {
                MessageBox.Show("请输入要添加的员工姓名！");
                YGGH.Clear();
                YGBM.Clear();
                YGXM.Clear();
                YGZW.Clear();
               
            }
            else if (YGXM.Text != "")
            {
                DBClass.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBClass.conn;
                cmd.CommandText = "Insert into YGB(YGXM,YGGH,YGBM,YGZW) Values('" + YGXM.Text + "','" + YGGH.Text + "','" + YGBM.Text + "','" + YGZW.Text + "')";
                cmd.ExecuteNonQuery();
                DBClass.conn.Close();
                MessageBox.Show("添加成功");
                YGXM.Clear();
                YGGH.Clear();
                YGBM.Clear();
                YGZW.Clear();
               
                
               
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
