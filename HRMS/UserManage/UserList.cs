using System;
using System.Data;
using System.Windows.Forms;

namespace HRMS.UserManage
{
    public partial class UserList : Form
    {
        public static DataSet userlist;
        DBAccess dbaccess = new DBAccess();
        public UserList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击添加弹出用户添加窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserAdd add = new UserAdd();
            add.Text = "添加用户";
            add.ShowDialog();
        }

        /// <summary>
        /// 初始化加载用户列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserList_Load(object sender, EventArgs e)
        {
            userlist=dbaccess.GetDataset("select ID as 编号, Name as 用户名 from tb_Login", "tb_Login");
            dgvUserInfo.DataSource = userlist.Tables[0];
            dgvUserInfo.AllowUserToAddRows = false;
            dgvUserInfo.AllowUserToDeleteRows = false;
            dgvUserInfo.ReadOnly = true;
        }
        /// <summary>
        /// 点击弹出修改对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Modules.nUserID.Trim() == "0001")
            {
                MessageBox.Show("不能修改系统管理员账号!");
                return;
            }
            UserAdd update = new UserAdd();
            update.Text = "修改用户";
            update.ShowDialog();
        }

        /// <summary>
        /// 点击单元格给公共ID和用户名赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserInfo.RowCount > 1)
            {
                Modules.nUserID = dgvUserInfo[0, dgvUserInfo.CurrentCell.RowIndex].Value.ToString();
                Modules.strUserName = dgvUserInfo[1, dgvUserInfo.CurrentCell.RowIndex].Value.ToString();
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Modules.nUserID.Trim() == "0001")
            {
                MessageBox.Show("不能删除系统管理员账号！");
                return;
            }
            dbaccess.GetSQLCommand("delete tb_Login where ID='" + Modules.nUserID.Trim() + "'");
            userlist = dbaccess.GetDataset("select ID as 编号,Name as 用户名 from tb_Login", "tb_Login");
            dgvUserInfo.DataSource = userlist.Tables[0];
        }
    }
}
