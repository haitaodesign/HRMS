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
            AutoID = modules.GetAutocoding("tb_Login", "ID");
            dbaccess.GetReaderofCommand("insert into tb_Login (ID,Name,Password) values('" + AutoID + "','" + tbName.Text + "','" + tbPassword.Text + "')");
            MessageBox.Show("添加成功");
        }
    }
}
