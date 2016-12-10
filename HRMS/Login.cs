using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HRMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string UserInfo;

        //构建数据库连接字符串
        String sqlConnStr = "server=121.42.31.90;uid=sa;pwd=LIhaitao177581+;database=HRMS";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                //建立数据库连接
                conn.ConnectionString = sqlConnStr;
                using (SqlCommand comd = new SqlCommand())
                {
                    conn.Open();
                    //发送SQL语句
                    comd.CommandText = "select  *  from tb_Login where Name='"+tbAccount.Text+"'and Password='"+tbPassword.Text+"'";
                    comd.CommandType = CommandType.Text;
                    comd.Connection = conn;
                    SqlDataReader dr = comd.ExecuteReader();
                    bool read = dr.Read();
                    if (read)
                    {
                        this.Close();
                        UserInfo = tbAccount.Text;
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                }
            }
        }

        //取消退出程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
