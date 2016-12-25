﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.AddressList;

namespace HRMS
{
    public partial class frmMain : Form
    {
        string appPath = Application.StartupPath + "\\";
        string fileName = string.Empty;
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
            fileName = appPath + "Configuration.txt";
            if (DBAccess.LoadConfiguration(fileName))
            {
                Login login = new Login();
                login.ShowDialog();
                tslLoginUser.Text = DBAccess.strLoginName;
            }
            else
            {
                Application.Exit();
            }
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Login reLogin = new Login();
            reLogin.Text = "重新登录";
            reLogin.ShowDialog();
            tslLoginUser.Text = DBAccess.strLoginName;
        }

        private void 通讯录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddressList frmaddresslist = new frmAddressList();
            frmaddresslist.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManage.UserList userlist = new UserManage.UserList();
            userlist.ShowDialog();
        }
    }
}
