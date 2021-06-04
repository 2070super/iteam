using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace demo01
{
    public class Dao
    {
        MySqlConnection sc;
        public MySqlConnection connect()
        {
            String str = "server=47.105.142.65;port=3306;user=root;password=Live2018; database=book;";
            //String str = "server=47.105.142.65;port=3306;user=root;password=Live2018; database=book;";
            //数据库连接字符串
            sc = new MySqlConnection(str);
            //创建数据库连接对象
            sc.Open();
            //打开数据库
            return sc;
            //返回数据库连接对象

        }
        public MySqlCommand command(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connect());
            //
            return cmd;
        }
        public int Execute(String sql)//更新操作
        {
            try
            {
                return command(sql).ExecuteNonQuery();
            }
            catch
            {
                //MessageBox.Show("更新失败");
                return 0;
            }
        }

        public MySqlDataReader read(String sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }

        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
