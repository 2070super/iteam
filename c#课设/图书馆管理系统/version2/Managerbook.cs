using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace demo01
{
    public partial class Managerbook : Form
    {
        String id = null;
        public Managerbook()
        {
            InitializeComponent();
            Table();
            label4.Text = Loginerinfor.id +"  "+ Loginerinfor.name;

        }

        private void Managerbook_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            String sql = "select bid,bname,bauthor,bpublish,bnum from book;";
            MySqlDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(),dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                DialogResult dr = MessageBox.Show("确认删除吗？","信息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(dr == DialogResult.OK)
                {
                    String sql = $"delete from book where bid = '{id}'";
                    Dao dao = new Dao();
                    int n = dao.Execute(sql);
                    if(n > 0)
                    {
                        MessageBox.Show("删除成功");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }

            }
            catch
            {
                MessageBox.Show("未选中");
            }
            Table();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MBupdate mbu = new MBupdate();
            mbu.ShowDialog();
            Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MBinsert mbi = new MBinsert();
            mbi.ShowDialog();
            Table();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Updatemima update = new Updatemima();
            update.ShowDialog();
        }

        
    }
}
