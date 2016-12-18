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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserAdd add = new UserAdd();
            add.Text = "添加用户";
            add.ShowDialog();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            userlist=dbaccess.GetDataset("select ID as 编号, Name as 用户名 from tb_Login", "tb_Login");
            dgvUserInfo.DataSource = userlist.Tables[0];
            dgvUserInfo.AllowUserToAddRows = false;
            dgvUserInfo.AllowUserToDeleteRows = false;
            dgvUserInfo.ReadOnly = true;
        }

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

        private void dgvUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserInfo.RowCount > 1)
            {
                Modules.nUserID = dgvUserInfo[0, dgvUserInfo.CurrentCell.RowIndex].Value.ToString();
                Modules.strUserName = dgvUserInfo[1, dgvUserInfo.CurrentCell.RowIndex].Value.ToString();
            }
        }
    }
}
