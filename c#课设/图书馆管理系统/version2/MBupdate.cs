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
    public partial class MBupdate : Form
    {
        public MBupdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Dao dao = new Dao();
                int num = int.Parse(textBox5.Text);
                String sql = $"update  book set bname = N'{textBox2.Text}',bauthor = N'{textBox3.Text}',bpublish" +
                    $"= N'{textBox4.Text}',bnum = '{num}' where bid = N'{textBox1.Text}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("更改成功");
                }
                else
                {
                    MessageBox.Show("更改失败");
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
