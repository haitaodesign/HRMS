using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 员工基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployInfo Info = new frmEmployInfo();
            Info.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            tslLoginUser.Text = login.UserInfo;
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login reLogin = new Login();
            reLogin.ShowDialog();
            tslLoginUser.Text = reLogin.UserInfo;
        }
    }
}
