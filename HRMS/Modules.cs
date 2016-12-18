using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
    class Modules
    {
        #region  公共变量
        DBAccess dbAccess = new DBAccess();   //声明DBAccess类的一个对象，以调用其方法
        public static string strSQLCommand = "";  //用来存储添加或修改的SQL语句
        public static string strFilter = "";  //存储查询条件
        public static int nAddressID = 0;  //存储通讯录添加修改时的ID编号
        public static int nUserID = 0;  //存储用户的ID编号
        public static string strUserName = "";    //存储用户名
        #endregion

        #region  向comboBox控件传递数据表中的数据
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加数据.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="TableName">数据表名称</param>
        public void CoPassData(ComboBox cobox, string TableName)
        {
            cobox.Items.Clear();
            DBAccess tempDBAccess = new DBAccess();
            SqlDataReader sqlDataReader = tempDBAccess.GetReaderofCommand("select * from " + TableName);
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader[1].ToString() != "" && sqlDataReader[1].ToString() != null)
                        cobox.Items.Add(sqlDataReader[1].ToString());
                }
            }
        }
        #endregion

        #region  将图片存储到数据库中
        /// <summary>
        /// 以二进制的形式将图片存储到数据库中.
        /// </summary>
        /// <param name="MID">职工编号</param>
        /// <param name="p">图片的二进制形式</param>
        public void SaveImage(string MID, byte[] p)
        {
            if (MID == string.Empty)
            {
                MessageBox.Show("ID不能为空！");
                return;
            }
            dbAccess.OpenConnection();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Stuffbasic Set Photo=@Photo where ID=" + MID);
            SqlCommand strCmd = new SqlCommand(strSql.ToString(),  DBAccess.sqlConnection);
            strCmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = p;
            strCmd.ExecuteNonQuery();
            DBAccess.sqlConnection.Close();
        }
        #endregion

        #region  将图片存储到数据库中_带参数
        public void GetSQLCommandWithParams(string strSql, string param, byte[] p)
        {
            if (strSql == string.Empty)
            {
                MessageBox.Show("命令不能为空！");
                return;
            }
            dbAccess.OpenConnection();
            SqlCommand strCmd = new SqlCommand(strSql.ToString(),  DBAccess.sqlConnection);
            strCmd.Parameters.Add(param, SqlDbType.Binary).Value = p;
            strCmd.ExecuteNonQuery();
            DBAccess.sqlConnection.Close();
        }
        #endregion

        #region  自动编号
        /// <summary>
        /// 在添加信息时自动计算编号.
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="ID">字段名</param>
        /// <returns>返回String对象</returns>
        public String GetAutocoding(string TableName, string ID)
        {
            //查找指定表中ID号为最大的记录
            SqlDataReader MyDR = dbAccess.GetReaderofCommand("select max(" + ID + ") NID from " + TableName);
            int Num = 0;
            if (MyDR.HasRows)   //当查找到记录时
            {
                MyDR.Read();    //读取当前记录
                if (MyDR[0].ToString() == "")
                    return "0001";
                Num = Convert.ToInt32(MyDR[0].ToString());  //将当前找到的最大编号转换成整数
                ++Num;  //最大编号加1
                string s = string.Format("{0:0000}", Num);  //将整数值转换成指定格式的字符串
                return s;   //返回自动生成的编号
            }
            else
            {
                return "0001";  //当数据表没有记录时，返回0001
            }
        }
        #endregion

        #region MyRegion

        #endregion

    }
}
