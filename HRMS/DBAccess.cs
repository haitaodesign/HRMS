using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace HRMS
{
    class DBAccess
    {
        #region  全局变量
        public static int nLoginID = 0;             //定义全局变量，记录当前登录的用户编号
        public static string strLoginName = "";     //定义全局变量，记录当前登录的用户名
        //定义全局变量，记录“基础信息”各窗体中的表名及SQL语句
        public static string strSQLCmdString = "", strTable = "", strField = "";
        //定义一个SqlConnection类型的公共变量My_con，用于判断数据库是否连接成功
        public static SqlConnection sqlConnection;
        //public static string strSQLConnection = "Data Source=B313-14\\SQLEXPRESS;Database=HRMS;User id=bao;PWD=123";
        public static string strSQLConnection = "server=121.42.31.90;uid=sa;pwd=LIhaitao177581+;database=HRMS";

        public static int nLoginType = 0;            //用户登录与重新登录的标识
        public static string strSQLSelectAll = "Select * from tb_StuffBasic"; //存储职工基本信息表中的SQL语句
        //public static int res = 0;
        
        #endregion

        #region  读取配置文件
        public static bool LoadConfiguration()
        {
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileStream("Configuration.txt", FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(fileStream);
                strSQLConnection = streamReader.ReadLine();
                return true;
            }
            catch (Exception)
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                MessageBox.Show("配置文件读取错误！");
                return false;
            }
        }
        
        #endregion

        #region  建立数据库连接
        public static SqlConnection GetConnection()
        {
            sqlConnection = new SqlConnection(strSQLConnection);    //用SqlConnection对象与指定的数据库相连接
            sqlConnection.Open();                                   //打开数据库连接
            return sqlConnection;                                   //返回SqlConnection对象的信息
        }
        #endregion

        #region  测试数据库是否赋加
        public void OpenConnection()
        {
            GetConnection();
            //CloseConnection();
        }
        #endregion

        #region  关闭数据库连接
        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)   //判断是否打开与数据库的连接
            {
                sqlConnection.Close();   //关闭数据库的连接
                sqlConnection.Dispose();   //释放My_con变量的所有空间
            }
        }
        #endregion

        #region  读取指定表中的信息
        public SqlDataReader GetReaderofCommand(string SQLstr)
        {
            GetConnection();   //打开与数据库的连接
            SqlCommand sqlCommand = sqlConnection.CreateCommand(); //创建一个SqlCommand对象，用于执行SQL语句
            sqlCommand.CommandText = SQLstr;    //获取指定的SQL语句
            SqlDataReader dataReader = sqlCommand.ExecuteReader(); //执行SQL语名句，生成一个SqlDataReader对象
            return dataReader;
        }
        #endregion

        #region 执行SqlCommand命令
        public void GetSQLCommand(string SQLstr)
        {
            GetConnection();   //打开与数据库的连接
            SqlCommand sqlCommand = new SqlCommand(SQLstr, sqlConnection); //创建一个SqlCommand对象，用于执行SQL语句
            sqlCommand.ExecuteNonQuery();   //执行SQL语句
            sqlCommand.Dispose();   //释放所有空间
            CloseConnection();    //调用con_close()方法，关闭与数据库的连接
        }
        #endregion

        #region  创建DataSet对象
        public DataSet GetDataset(string SQLstr, string tableName)
        {
            GetConnection();   //打开与数据库的连接
            SqlDataAdapter sqlDataset = new SqlDataAdapter(SQLstr, sqlConnection);  //创建一个SqlDataAdapter对象，并获取指定数据表的信息
            DataSet dataset = new DataSet(); //创建DataSet对象
            sqlDataset.Fill(dataset, tableName);  //通过SqlDataAdapter对象的Fill()方法，将数据表信息添加到DataSet对象中
            CloseConnection();    //关闭数据库的连接
            return dataset;  //返回DataSet对象的信息
            //WritePrivateProfileString(string section, string key, string val, string filePath);
        }
        #endregion
    }
}
