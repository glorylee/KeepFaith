/************************************************************************************
 * Copyright (c) 2015Microsoft All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 *机器名称：CARFUN-PC
 *公司名称：Microsoft
 *命名空间：Database.Infrastructure
 *文件名：  DBConnectPool
 *版本号：  V1.0.0.0
 *唯一标识：57bab0dd-13f2-4c38-8916-d686e59542e1
 *当前的用户域：carfun-PC
 *创建人：  swustlzx
 *电子邮箱：swustlzx@126.com
 *创建时间：2015/11/12 14:04:55
 *描述：
 *
 *=====================================================================
 *修改标记
 *修改时间：2015/11/12 14:04:55
 *修改人： carfun
 *版本号： V1.0.0.0
 *描述：
 *
/************************************************************************************/
using System.Data.SqlClient;

namespace Database.Infrastructure
{
    /// <summary>
    ///     create database connect pool
    /// </summary>
    public class DBConnectPool : DBConnectBase
    {
        public DBConnectPool() //构造函数  
        {
            ConnString = GetConnString();
            SqlDrConn = new SqlConnection(ConnString);
        }

        public int MaxPool
        {
            get { return MaxPool; }
            set
            {
                if (value <= 0)
                {
                    MaxPool = 1;
                }
                MaxPool = value;
            }

        } // = 10; //最大连接数  
        public int MinPool { get; set; } //=5;//最小连接数  
        public bool Asyn_Process { get; set; } //=true;//设置异步访问数据库  
        public bool Mars { get; set; } //=true;//在单个连接上得到和管理多个、仅向前引用和只读的结果集(ADO.NET2.0)  
        public int Conn_Timeout { get; set; } //=15;//设置连接等待时间  
        public int Conn_Lifetime { get; set; } //=15;//设置连接的生命周期  
        public string ConnString { get; set; } //="";//连接字符串  
        public string DataBaseName { get; set; } 
        public SqlConnection SqlDrConn { get; set; } // = null;//连接对象

        public override string ToEntity()
        {
            return ToEntity();
        }

        private string GetConnString()
        {
            return "server=localhost;"
                   + "integratedsecurity=sspi;"
                   + "database="+DataBaseName+";"
                   + "MaxPoolSize=" + MaxPool + ";"
                   + "MinPoolSize=" + MinPool + ";"
                   + "ConnectTimeout=" + Conn_Timeout + ";"
                   + "ConnectionLifetime=" + Conn_Lifetime + ";"
                   + "AsynchronousProcessing=" + Asyn_Process + ";";
            //+"MultipleActiveResultSets="+Mars+";";  
        }
    }
}