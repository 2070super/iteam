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
    public partial class Updatemima : Form
    {
        public Updatemima()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String newmima = textBox2.Text;
            String sql = null;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == Loginerinfor.password)
                {
                    switch (Loginerinfor.typeid)
                    {
                        case 1:
                            sql = $"update yonghu set ypassword = '{textBox2.Text}' where yid = '{Loginerinfor.id}'";
                            break;
                        case 2:
                            sql = $"update manager set mpassword = '{textBox2.Text}' where mid = '{Loginerinfor.id}'";
                            break;
                    }
                    Dao dao = new Dao();
                    int n = dao.Execute(sql);
                    if (n > 0)
                    {
                        Loginerinfor.password = textBox2.Text;
                        MessageBox.Show("更改成功");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("更改失败");
                    }
                }
                else
                {
                    MessageBox.Show("旧密码错误");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("输入不能为空");
            }
        }
    }
}
