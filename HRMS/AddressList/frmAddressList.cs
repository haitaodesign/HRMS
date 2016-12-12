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

namespace HRMS.AddressList
{
    public partial class frmAddressList : Form
    {

        #region 定义公共变量
        DBAccess dbaccess = new DBAccess();
        DataSet dgvAddress;
        frmUpdate frmupdate = new frmUpdate();
        string sqlStr = "select * from tb_AddressList";
        #endregion
        public frmAddressList()
        {
            InitializeComponent();
        }

        private void frmAddressList_Load(object sender, EventArgs e)
        {
            dgvAddress = dbaccess.GetDataset(sqlStr, "tb_AddressList");
            dgvAddressList.DataSource = dgvAddress.Tables[0];
            dgvAddressList.AllowUserToAddRows = false;
            dgvAddressList.AllowUserToDeleteRows = false;
            dgvAddressList.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd frmadd = new frmAdd();
            frmadd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmupdate.ShowDialog();
        }



        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddressList.RowCount < 2)
            {
                MessageBox.Show("数据表为空，不可以删除！");
                return;
            }
            dbaccess.GetSQLCommand("delete tb_AddressList where Id='" + frmupdate.Id+ "'");

            dgvAddress = dbaccess.GetDataset(sqlStr, "tb_AddressList");
            dgvAddressList.DataSource = dgvAddress.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from tb_AddressList where " + cbAddressType.Text.ToString() + "='" + tbAddressValue.Text.ToString() + "'";
            dgvAddress = dbaccess.GetDataset(sqlstr, "tb_AddressList");
            dgvAddressList.DataSource = dgvAddress.Tables[0];

        }

        private void dgvAddressList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmupdate.Id = Convert.ToInt32(dgvAddressList.SelectedCells[0].Value);
            frmupdate.uName = dgvAddressList.SelectedCells[1].Value.ToString();
            frmupdate.Sex = dgvAddressList.SelectedCells[2].Value.ToString();
            frmupdate.Phone = dgvAddressList.SelectedCells[3].Value.ToString();
            frmupdate.WorkPhone = dgvAddressList.SelectedCells[4].Value.ToString();
            frmupdate.HomePhone = dgvAddressList.SelectedCells[5].Value.ToString();
            frmupdate.QQ = dgvAddressList.SelectedCells[6].Value.ToString();
            frmupdate.Email = dgvAddressList.SelectedCells[7].Value.ToString();
            frmupdate.WeChat = dgvAddressList.SelectedCells[8].Value.ToString();
        }
    }
}
