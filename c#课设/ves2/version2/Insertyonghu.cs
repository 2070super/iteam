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
    public partial class Insertyonghu : Form
    {
        public Insertyonghu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String newyid = textBox1.Text;
            String newyname = textBox2.Text;
            String newypassword = textBox3.Text;
            String sql = $"insert into yonghu values('{newyid}','{newyname}','{newypassword}')";
            Dao dao = new Dao();
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("注册成功");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
