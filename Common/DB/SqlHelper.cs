using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace VipSoft.Common.DB
{
   public  class SqlHelper
    {

        private static String  connString = "server=sql.w3249.vhostgo.com;database=vipsoft;uid=vipsoft;pwd=vip123456";


        public static DataTable getTblModel(String sqltext)
        {

            DataSet ds= new DataSet();
            SqlCommand com = null;
            SqlDataAdapter sda = null;

             SqlConnection conn = new SqlConnection(connString);
            if (conn.State != ConnectionState.Open)
                conn.Open();

            com = new SqlCommand(sqltext, conn);
            sda = new SqlDataAdapter(com);

            sda.Fill(ds);

            conn.Close();
            return ds.Tables[0];

        }

        /// <summary>批量导入DataTable  
        /// 批量导入DataTable  
        /// </summary>  
        /// <param name="dt">DataTable数据表</param>  
        /// <param name="tblName">表名</param>  
        /// <param name="dtColumn">数据列集合</param>  
        /// <return>Boolean值:true成功，false失败</return>  
        public static Boolean insertTbl(DataTable dt, String tblName, DataColumnCollection dtColumn)
        {
            try
            {
                using (SqlBulkCopy sqlBC = new SqlBulkCopy(connString))
                {
                    //一次批量的插入的数据量  
                    sqlBC.BatchSize = 1000;
                    //超时之前操作完成所允许的秒数，如果超时则事务不会提交 ，数据将回滚，所有已复制的行都会从目标表中移除  
                    sqlBC.BulkCopyTimeout = 60;

                    //设置要批量写入的表  
                    sqlBC.DestinationTableName = tblName;

                    //自定义的datatable和数据库的字段进行对应  
                    //sqlBC.ColumnMappings.Add("id", "tel");  
                    //sqlBC.ColumnMappings.Add("name", "neirong");  
                    for (int i = 0; i < dtColumn.Count; i++)
                    {
                        sqlBC.ColumnMappings.Add(dtColumn[i].ColumnName.ToString(), dtColumn[i].ColumnName.ToString());
                    }
                    //批量写入  
                   VipSoft.Common.NPOI2.ExcelUtils.printDT(dt);
                    sqlBC.WriteToServer(dt);  
                }
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
            return true;
        }
    }
}
