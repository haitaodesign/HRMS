using HRMS.AddressList;
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
    public partial class frmAddressList : Form
    {

        #region 定义公共变量
        DBAccess dbaccess = new DBAccess();
        DataSet dgvAddress;
        #endregion
        public frmAddressList()
        {
            InitializeComponent();
        }

        private void frmAddressList_Load(object sender, EventArgs e)
        {
            string sqlStr = "select * from tb_AddressList";
            dgvAddress = dbaccess.GetDataset(sqlStr, "tb_AddressList");
            dgvAddressList.DataSource = dgvAddress.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd frmadd = new frmAdd();
            frmadd.ShowDialog();
        }
    }
}
