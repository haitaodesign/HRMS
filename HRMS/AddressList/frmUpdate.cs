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
    }
}
