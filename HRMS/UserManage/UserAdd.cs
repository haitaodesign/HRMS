using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS.UserManage
{
    public partial class UserAdd : Form
    {
        #region 定义全局变量
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
            if (this.Text == "添加用户")
            {
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
    }
}
