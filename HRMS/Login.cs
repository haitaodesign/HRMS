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
            this.ControlBox = false;
        }
        DBAccess dbaccess = new DBAccess();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(tbAccount.Text!="" && tbPassword.Text != "")
            {
                SqlDataReader sdr = dbaccess.GetReaderofCommand("select * from tb_Login where Name='" + tbAccount.Text.Trim() + "' and Password='" + tbPassword.Text.Trim() + "'");
                bool isTrue = sdr.Read();
                if (isTrue)
                {
                    DBAccess.strLoginName = tbAccount.Text.Trim();
                    DBAccess.nLoginID = sdr.GetString(0);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("请将登录信息添写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //取消退出程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.Text == "重新登录")
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 测试数据库连接是否可用。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                dbaccess.OpenConnection();
                dbaccess.CloseConnection();
                tbAccount.Text = "";
                tbPassword.Text = "";
            }
            catch
            {
                MessageBox.Show("数据库连接失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
