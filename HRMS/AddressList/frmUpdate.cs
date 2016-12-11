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
    public partial class frmUpdate : Form
    {
        public int Id;
        public string uName;
        public string Sex;
        public string Phone;
        public string WorkPhone;
        public string HomePhone;
        public string QQ;
        public string WeChat;
        public string Email;

        public frmUpdate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            tbName.Text = uName;
            tbSex.Text = Sex;
            tbPhone.Text = Phone;
            tbWorkPhone.Text = WorkPhone;
            tbHomePhone.Text = HomePhone;
            tbQQ.Text = QQ;
            tbWeChat.Text = WeChat;
            tbEmail.Text = Email;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            try
            {
                string strSql = UpdateAddress();
                DBAccess dbaccess = new DBAccess();
                dbaccess.GetSQLCommand(strSql);
                isSuccess = true;
                if (isSuccess)
                {
                    MessageBox.Show("添加成功！");
                    ClearBoxes();
                }
            }
            catch
            {
                MessageBox.Show("请检出输入的信息是否正确！");
            }

        }

        /// <summary>
        /// 更新一条通讯录信息
        /// </summary>
        /// <returns>返回一条sql语句</returns>
        public string UpdateAddress()
        {
            string result = null;
            result = "update tb_AddressList set Name='";
            result += tbName.Text.Trim() + "',Sex='";
            result += tbSex.Text.Trim() + "',Phone='";
            result += tbPhone.Text.Trim() + "',WorkPhone='";
            result += tbWorkPhone.Text.Trim() + "',HomePhone='";
            result += tbHomePhone.Text.Trim() + "',QQ='";
            result += tbQQ.Text.Trim() + "',Email='";
            result += tbEmail.Text.Trim() + "',WeChat='";
            result += tbWeChat.Text.Trim() + "'where Id='";
            result += Id+"'";
            return result;
        }
        /// <summary>
        /// 清空输入框
        /// </summary>
        private void ClearBoxes()
        {
            foreach (Control inputControl in groupBox1.Controls)
            {
                if (inputControl is TextBox)
                {
                    ((TextBox)inputControl).Clear();
                }
            }
        }
    }
}
