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
    public partial class find : Form
    {
        public find()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (YGGH.Text == "")
                {
                    MessageBox.Show("查找的员工工号不能为空！");
                }
                else if (YGGH.Text != "")

                {
                    DBClass.conn.Open();
                    DataSet dsMydataBase = new DataSet();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DBClass.conn;
                    cmd.CommandText = "select [YGGH] from [YGB] where [YGGH] ='" + YGGH.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = DBClass.conn;
                    cmd1.CommandText = "select [YGXM] from [YGB] where [YGGH] LIKE '" + YGGH.Text + "%'";
                    cmd1.ExecuteNonQuery();

                    if (cmd.ExecuteScalar() == null&&cmd1.ExecuteScalar() == null)
                    {
                        MessageBox.Show("该员工不存在！");
                        YGGH.Clear();
                        DBClass.conn.Close();
                        return;
                    }
                    else
                    {
                        string searchString = "";
                        if (cmd.ExecuteScalar() == null)
                        {
                            searchString = "select * from YGB where YGGH='" + YGGH.Text + "'";
                            searchString = "select * from YGB where YGGH LIKE '" + YGGH.Text + "%'";
                        }
                        else
                        {
                            searchString = "select * from YGB where YGGH='" + YGGH.Text + "'";
                        }
                        SqlDataAdapter dataSelect = new SqlDataAdapter(searchString, DBClass.conn);
                        DataTable dt = new DataTable();
                        dataSelect.Fill(dt);
                        dataGridView1.DataSource = dt.DefaultView;
                        this.dataGridView1.RowHeadersVisible = true;
                        DBClass.conn.Close();
                        YGGH.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败！");
                DBClass.conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




            
        
    

