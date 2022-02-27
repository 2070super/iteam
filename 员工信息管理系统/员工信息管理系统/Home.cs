using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 员工信息管理系统
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add ad = new Add();
            ad.Show();
            this.Hide();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            find a = new find();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete de = new Delete();
            de.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modify mo = new Modify();
            mo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display di = new Display();
            di.Show();
            this.Hide();
        }
    }
}
