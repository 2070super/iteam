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
    public partial class YonghuForm : Form
    {
        int bcid;
        String bid;
        //String
        int num;
        public YonghuForm()
        {
            InitializeComponent();
            Table_b();
            Table_bc();
            label4.Text = Loginerinfor.id + "  " + Loginerinfor.name;
        }

        public void Table_b()
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

        public void Table_bc()
        {
            dataGridView2.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            String sql = $"select borrow.bcid,book.bid,bname,time from book,borrow where book.bid = borrow.bid and borrow.sid = '{Loginerinfor.id}';";
            MySqlDataReader db = dao.read(sql);
            while (db.Read())
            {
                dataGridView2.Rows.Add(db[0].ToString(), db[1].ToString(), db[2].ToString(),db[3].ToString());
            }
            db.Close();
            dao.DaoClose();
        }

       /* private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bcid = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            label7.Text = bcid.ToString();
            label6.Text = null;
            //用户已借阅的书籍编号
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中的借阅编号
            label6.Text = bid;
            label7.Text = null;
            try
            {
                num = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch
            {
                MessageBox.Show("该书籍未开放借阅，请联系管理员");
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (label7.Text == "" && label6.Text != "")
            {
                if (num > 0)
                {
                    num--;
                    Dao dao = new Dao();
                    String sql1 = $"insert into borrow(sid,bid,time) values('{Loginerinfor.id}','{bid}','{DateTime.Now}')";
                    int n = dao.Execute(sql1);
                    if (n > 0)
                    {
                        String sql2 = $"update book set bnum = '{num}' where bid = '{bid}'";
                        int m = dao.Execute(sql2);
                        if (m > 0)
                        {
                            MessageBox.Show("借阅成功");
                            Table_bc();
                            Table_b();
                            return;
                        }
                    }



                }
                else
                {
                    MessageBox.Show("该书已经被借完了");
                }
            }
            else
            {
                MessageBox.Show("请先选中左表中的书籍记录");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label7.Text != "" && label6.Text == "")
            {
                Dao dao = new Dao();
                if (num >= 0)
                {
                    num++;
                    String sql1 = $"delete from borrow where bcid = '{bcid}'";
                    int n = dao.Execute(sql1);
                    if (n > 0)
                    {
                        String sql2 = $"update book set bnum = '{num}' where bid = '{bid}'";
                        int m = dao.Execute(sql2);
                        if (m > 0)
                        {
                            MessageBox.Show("归还成功");
                            Table_bc();
                            Table_b();
                            return;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("请先选中右表中的借阅记录");
            }
        }

        private void YonghuForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Updatemima update = new Updatemima();
            update.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table_bc();
            Table_b();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中的借阅编号
            label6.Text = bid;
            label7.Text = null;
            try
            {
                num = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch
            {
                MessageBox.Show("该书籍未开放借阅，请联系管理员");
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bcid = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());//用户已借阅的书籍编号
            label7.Text = bcid.ToString();
            label6.Text = null;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
