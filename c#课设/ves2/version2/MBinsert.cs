using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01
{
    public partial class MBinsert : Form
    {
        public MBinsert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Dao dao = new Dao();
                int num = int.Parse(textBox5.Text);
                String sql = $"insert into book(bid,bname,bauthor,bpublish,bnum) values(N'{textBox1.Text}'" +
                    $",N'{textBox2.Text}',N'{textBox3.Text}',N'{textBox4.Text}','{num}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";



            }
            else
            {
                MessageBox.Show("输入不允许有空");
            }
        }
    }
}
