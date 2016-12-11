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
    public partial class frmAdd : Form
    {

        public frmAdd()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            try
            {
                string strFields = "Name,Sex,Phone,WorkPhone,HomePhone,QQ,Email,WeChat";
                string strSql = SaveAddressList(strFields);
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
        /// 返回一条插入的sql语句
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string SaveAddressList(string str)
        {
            string result = null;
            result = "insert into tb_AddressList(";
            result += str;
            result += ") values('";
            result += tbName.Text.Trim() + "','";
            result += tbSex.Text.Trim() + "','";
            result += tbPhone.Text.Trim() + "','";
            result += tbWorkPhone.Text.Trim() + "','";
            result += tbHomePhone.Text.Trim() + "','";
            result += tbQQ.Text.Trim() + "','";
            result += tbEmail.Text.Trim() + "','";
            result += tbWeChat.Text.Trim() + "')";
            return result;
        }

        /// <summary>
        /// 清空输入框
        /// </summary>
        private void ClearBoxes()
        {
            foreach (Control inputControl in groupBox1.Controls)
            {
                if(inputControl is TextBox)
                {
                    ((TextBox)inputControl).Clear();
                }
            }
        }

   
    }
}
