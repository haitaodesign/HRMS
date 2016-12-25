using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class frmEmployInfo : Form
    {
        public frmEmployInfo()
        {
            InitializeComponent();
        }
        #region 定义公共变量
        DBAccess dbacces = new DBAccess();
        DataSet datasetgrid;
        public static int curID = 0;
        public static string queryType;
        public static string queryValue;
        public static string queryType2;
        public static string queryValue2;
        public static string sqlStr;

        public static byte[] imgtobinary;
        //设定添加或者删除
        public static int OperationType;
        public static bool imageModified = false;

        #endregion

        #region 员工信息初始化加载
        private void MainWindow_Load(object sender, EventArgs e)
        {

            String sqlStr = "select  * from tb_StuffBasic";
            try
            {
                datasetgrid = dbacces.GetDataset(sqlStr, "tb_StuffBasic");
                dgvEmplyInfo.DataSource = datasetgrid.Tables[0];
                //是否自动创建列
                dgvEmplyInfo.AutoGenerateColumns = true;
                dgvEmplyInfo.Columns[0].Width = 60;
                dgvEmplyInfo.Columns[1].Width = 60;
                dgvEmplyInfo.Columns[2].Width = 60;
                dgvEmplyInfo.Columns[3].Width = 60;
                dgvEmplyInfo.Columns[4].Width = 100;
                dgvEmplyInfo.Columns[5].Width = 100;
                dgvEmplyInfo.Columns[6].Width = 100;
                dgvEmplyInfo.Columns[7].Width = 100;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            //向文本输入框中加载首记录
            tbCurrentName.Text = GridInfo(dgvEmplyInfo);
            tbID.Enabled = false;
            DBAccess.strSQLSelectAll = "select  * from tb_StuffBasic";
            dgvEmplyInfo.AllowUserToAddRows = false;
            dgvEmplyInfo.AllowUserToDeleteRows = false;
            dgvEmplyInfo.ReadOnly = true;
        }
        #endregion

        #region 窗体控件的事件

        /// <summary>
        /// 根据输入条件查询结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlStr = "select * from tb_StuffBasic where ";
            queryValue = tbQueryValue.Text.Trim();
            queryValue2 = tbQueryValue2.Text.Trim();
            queryType = cbQueryType.SelectedItem.ToString();
            queryType2 = cbQueryType2.SelectedItem.ToString();
            if (queryValue == "" && queryValue2 == "")
            {
                MessageBox.Show("查询条件不能为空！");
            }
            else
            {
                if (queryValue != "")
                {
                    sqlStr += queryType + "='" + queryValue + "'";
                }else if (queryValue2 != "" && queryValue!="")
                {
                    sqlStr += " and " + queryType2 + "='" + queryValue2 + "'";
                }else if (queryValue == ""&& queryValue2!="")
                {
                    sqlStr += queryType2 + "='" + queryValue2 + "'";
                }

                datasetgrid = dbacces.GetDataset(sqlStr, "tb_StuffBasic");
                if (datasetgrid.Tables.Count == 1 && datasetgrid.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("没有符合查询条件的数据！");
                }
                else
                {
                    dgvEmplyInfo.DataSource = datasetgrid.Tables[0];
                    tbCurrentName.Text = GridInfo(dgvEmplyInfo);
                }

            }

        }

        /// <summary>
        /// 点击添加时，设置按钮的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            OperationType = 1;
            btnEnabled(btnAdd, btnUpdate, btnCancel, btnSave, 0, 0, 1, 1);
            btnChosePic.Enabled = true;
            btnDeletePic.Enabled = true;
        }

        /// <summary>
        /// 点击 修改按钮时，设置按钮的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OperationType = 2;
            btnEnabled(btnAdd, btnUpdate, btnCancel, btnSave, 0, 0, 1, 1);
            btnChosePic.Enabled = true;
            btnDeletePic.Enabled = true;
        }

        /// <summary>
        /// 点击删除按钮，删除一条记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmplyInfo.RowCount < 2)
            {
                MessageBox.Show("数据表为空，不可以删除！");
                return;
            }
            dbacces.GetSQLCommand("delete tb_StuffBasic where ID='" + tbID.Text.Trim() + "'");

            //调用取消的单击事件
            btnCancel_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string allFields = "Name,Sex,Phone,Position,Address,Email,Memo";
            string sqlStr = null;
            try
            {
                if (OperationType == 1 || OperationType == 2)
                {
                    sqlStr = SaveEmployInfor(allFields);
                    dbacces.GetSQLCommand(sqlStr);
                }
                if (imageModified)
                {
                    Modules modules = new Modules();
                    modules.SaveImage(tbID.Text.Trim(), imgtobinary);
                }
                btnCancel_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("请输入正确的职工信息！");
            }
        }

        /// <summary>
        /// 点击取消按钮的设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            OperationType = 0;
            btnEnabled(btnAdd, btnUpdate, btnCancel, btnSave, 1, 1, 0, 0);
            imageModified = false;
            datasetgrid = dbacces.GetDataset(DBAccess.strSQLSelectAll, "tb_StuffBasic");
            dgvEmplyInfo.DataSource = datasetgrid.Tables[0];
            tbCurrentName.Text = GridInfo(dgvEmplyInfo);
            btnChosePic.Enabled = false;
            btnDeletePic.Enabled = false;
        }

        /// <summary>
        /// 点击按钮选择图片，将图片转换为二进制数组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChosePic_Click(object sender, EventArgs e)
        {
            ImageToByteArray(openFileDialog1, pbPhoto);
            imageModified = true;
        }

        /// <summary>
        /// 点击删除图片按钮，删除图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletePic_Click(object sender, EventArgs e)
        {
            pbPhoto.Image = null;
            imgtobinary = new byte[65536];
            imageModified = true;
        }

        /// <summary>
        /// 单击行头部获得该行的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmplyInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbID.Text = dgvEmplyInfo.SelectedCells[0].Value.ToString();
            tbName.Text = dgvEmplyInfo.SelectedCells[1].Value.ToString();
            tbSex.Text = dgvEmplyInfo.SelectedCells[2].Value.ToString();
            tbJob.Text = dgvEmplyInfo.SelectedCells[3].Value.ToString();
            tbPhone.Text = dgvEmplyInfo.SelectedCells[4].Value.ToString();
            tbAddress.Text = dgvEmplyInfo.SelectedCells[5].Value.ToString();
            tbEmail.Text = dgvEmplyInfo.SelectedCells[6].Value.ToString();
            tbMemo.Text = dgvEmplyInfo.SelectedCells[7].Value.ToString();
            tbCurrentName.Text = tbName.Text;
            MemoryStream ms = new MemoryStream((byte[])dgvEmplyInfo.SelectedCells[8].Value);
            pbPhoto.Image = Image.FromStream(ms);

        }
        #endregion


        #region 窗体事件使用的公共方法
        /// <summary>
        /// 动态读取指定的行，并进行显示
        /// </summary>
        /// <param name="datagridview"></param>
        /// <returns></returns>
        public string GridInfo(DataGridView datagridview)
        {
            byte[] picture;
            tbCurrentName.Text = datagridview.RowCount.ToString();
            if (datagridview.RowCount > 1)
            {
                tbID.Text = datagridview[0, datagridview.CurrentCell.RowIndex].Value.ToString();
                tbName.Text = datagridview[1, datagridview.CurrentCell.RowIndex].Value.ToString();
                tbSex.Text = datagridview[2, datagridview.CurrentCell.RowIndex].Value.ToString();
                tbPhone.Text = datagridview[3, datagridview.CurrentCell.RowIndex].Value.ToString();
                tbJob.Text = datagridview[4, datagridview.CurrentCell.RowIndex].Value.ToString();
                tbAddress.Text = datagridview[5, datagridview.CurrentCell.RowIndex].Value.ToString();
                tbEmail.Text = datagridview[6, datagridview.CurrentCell.RowIndex].Value.ToString();
                tbMemo.Text = datagridview[7, datagridview.CurrentCell.RowIndex].Value.ToString();
                try
                {
                    picture = (byte[])(datasetgrid.Tables[0].Rows[datagridview.CurrentCell.RowIndex][8]);
                    MemoryStream ms = new MemoryStream(picture);
                    pbPhoto.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    pbPhoto.Image = null;
                }
                curID = Convert.ToInt32(tbID.Text);
                return datagridview[1, datagridview.CurrentCell.RowIndex].Value.ToString();
            }
            else
            {
                //清空输入框中的所有内容
                ClearTextBoxes();
                curID = 0;
                return "";
            }
        }

        /// <summary>
        /// 清空输入框中的值
        /// </summary>
        private void ClearTextBoxes()
        {
            tbCurrentName.Clear();
            foreach (Control inputControl in panel1.Controls)
            {
                if (inputControl is TextBox)
                {
                    ((TextBox)inputControl).Clear();
                }
            }
        }

        /// <summary>
        /// 设置增删改保存按钮的状态；
        /// </summary>
        /// <param name="btn1"></param>
        /// <param name="btn2"></param>
        /// <param name="btn3"></param>
        /// <param name="btn4"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <param name="b3"></param>
        /// <param name="b4"></param>
        public void btnEnabled(Button btn1, Button btn2, Button btn3, Button btn4, int b1, int b2, int b3, int b4)
        {
            btn1.Enabled = Convert.ToBoolean(b1);
            btn2.Enabled = Convert.ToBoolean(b2);
            btn3.Enabled = Convert.ToBoolean(b3);
            btn4.Enabled = Convert.ToBoolean(b4);
        }

        /// <summary>
        /// 返回一条添加或修改的SQL语句
        /// </summary>
        /// <param name="Str"></param>
        /// <returns></returns>
        public string SaveEmployInfor(string Str)
        {
            string result = null;
            //默认值为0；1表示添加；2表示修改
            if (OperationType == 1)
            {
                result = "insert into tb_StuffBasic";
                result += Str;
                result += ") values('";
                result += tbName.Text.Trim() + "','";
                result += tbSex.Text.Trim() + "','";
                result += tbJob.Text.Trim() + "','";
                result += tbPhone.Text.Trim() + "','";
                result += tbAddress.Text.Trim() + "','";
                result += tbEmail.Text.Trim() + "','";
                result += tbMemo.Text.Trim() + "','";
            }
            else if (OperationType == 2)
            {
                result = "update  tb_StuffBasic set Name='";
                result += tbName.Text.Trim() + "', Sex='";
                result += tbSex.Text.Trim() + "', Position='";
                result += tbJob.Text.Trim() + "', Phone='";
                result += tbPhone.Text.Trim() + "',Address='";
                result += tbAddress.Text.Trim() + "',Email='";
                result += tbEmail.Text.Trim() + "',Memo='";
                result += tbMemo.Text.Trim() + "'where ID='";
                result += tbID.Text.Trim() + "'";
            }
            return result;
        }

        /// <summary>
        /// 将图片转换成二进制数组
        /// </summary>
        /// <param name="openfile"></param>
        /// <param name="picturebox"></param>
        public void ImageToByteArray(OpenFileDialog openfile, PictureBox picturebox)
        {
            openfile.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            if (openfile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    picturebox.Image = Image.FromFile(openfile.FileName);
                    string str = openfile.FileName.ToString();
                    FileStream fs = new FileStream(str, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imgtobinary = br.ReadBytes((int)fs.Length);
                }
                catch
                {
                    MessageBox.Show("您选择的图片类型不正确或图片不能正确读取！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pbPhoto.Image = null;
                }
            }
        }


        #endregion

    }
}
