using System;
using System.Configuration;
using Maticsoft.Common;
using System.Windows.Forms;
namespace Maticsoft.DBUtility
{
    
    public class PubConstant
    {
        static INIFile ini = new INIFile();
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ini.IniReadLongValue("connect", "CString");
                
                string ConStringEncrypt = ini.IniReadValue("connect", "CStringE");
                if (ConStringEncrypt == "true")
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                return _connectionString;
            }
        }
    }
}
