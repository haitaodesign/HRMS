using System;
using System.Data;
using System.Windows.Forms;

namespace HRMS.UserManage
{
    public partial class UserAdd : Form
    {
        #region 定义公共变量
        DBAccess dbaccess = new DBAccess();
        Modules modules = new Modules();
        public DataSet DbSet;
        public static string AutoID = "";
        #endregion
        public UserAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbName.Text=="" && tbPassword.Text == "")
            {
                MessageBox.Show("用户名和密码不能为空！");
                return;
            }
            DbSet = dbaccess.GetDataset("select Name from tb_Login where Name='" + tbName.Text + "'", "tb_Login");
            if (this.Text == "添加用户")
            {
                //判断用户名是否重复
                if (DbSet.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("当前用户名已存在，请重新输入！");
                    tbName.Text = "";
                    tbPassword.Text = "";
                    return;
                }
                AutoID = modules.GetAutocoding("tb_Login", "ID");
                dbaccess.GetReaderofCommand("insert into tb_Login (ID,Name,Password) values('" + AutoID + "','" + tbName.Text + "','" + tbPassword.Text + "')");
                MessageBox.Show("添加成功");
            }
            if (this.Text == "修改用户")
            {
                dbaccess.GetSQLCommand("update tb_Login set Name='" + tbName.Text + "',Password=' " + tbPassword.Text+"' where ID='" + Modules.nUserID + "'");
                MessageBox.Show("修改成功！");
            }
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            if (this.Text == "修改用户")
            {
                string ID = Modules.nUserID;
                DbSet = dbaccess.GetDataset("select Name,Password from tb_Login where ID='" + ID + "'", "tb_Login");
                tbName.Text = DbSet.Tables[0].Rows[0][0].ToString();
                tbPassword.Text = DbSet.Tables[0].Rows[0][1].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
