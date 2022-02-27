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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBClass.conn.Open();
                DataSet dsMyDataBase = new DataSet();
                SqlDataAdapter daBaseInform = new SqlDataAdapter("Select * from YGB", DBClass.conn);
                daBaseInform.Fill(dsMyDataBase, "BaseInform");
                dataGridView1.DataSource = dsMyDataBase.Tables["BaseInform"];
                DBClass.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败！");
                DBClass.conn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }
    }
}
