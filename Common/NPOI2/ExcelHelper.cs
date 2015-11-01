using System;
using System.Data;
using System.IO;
using System.Web;
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.POIFS;
using NPOI.Util;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Maticsoft.Common.NPOI2
{
    public class ExcalHelper
    {

        HSSFWorkbook workbook = null;

        HSSFSheet sheet = null;

        int dataRowNum = 1;

        public ExcalHelper(String sheetName, String[] rowTitle, int[] rowWidth, int dataRowNum)
        {
            //创建标题行
            workbook = new HSSFWorkbook();
            sheet = (HSSFSheet)workbook.CreateSheet(sheetName);
            this.dataRowNum = dataRowNum;

            HSSFRow rowtitle = (HSSFRow)sheet.CreateRow(0);

            for (int i = 0; i < rowTitle.Length; i++)
            {
                //设置列宽
                sheet.SetColumnWidth(i, rowWidth[i] * 255);
                rowtitle.CreateCell(i).SetCellValue(rowTitle[i]);
            }

        }


        public ExcalHelper(int dataRowNum)
        {
            this.dataRowNum = dataRowNum;
        }

        public bool ExportExcel(DataSet ds, string path)
        {
            //DataSet是一个DataTale的集合，如果只是填充了1张表，则此表的ID为0
            DataTable dt = ds.Tables[0];
            int i = 1;
            foreach (DataRow row in dt.Rows)
            {
                HSSFRow newrow = (HSSFRow)sheet.CreateRow(i);
                int col = 0;
                for (; col < dt.Columns.Count; col++)
                    newrow.CreateCell(col).SetCellValue(Convert.ToString(row[col]));
                i++;
            }
            try
            {
                using (Stream stream = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    workbook.Write(stream);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }

        }


        public DataTable ImportExcelFile(string filePath)
        {
            HSSFWorkbook hssfworkbook;
            #region//初始化信息
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    hssfworkbook = new HSSFWorkbook(file);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            #endregion

            NPOI.SS.UserModel.ISheet sheet = hssfworkbook.GetSheetAt(0);
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

            DataTable dt = new DataTable();
            rows.MoveNext();
            HSSFRow row = (HSSFRow)rows.Current;

            while (rows.MoveNext())
            {
                row = (HSSFRow)rows.Current;
                DataRow dr = dt.NewRow();
                for (int i = 0; i < row.LastCellNum; i++)
                {
                    NPOI.SS.UserModel.ICell cell = row.GetCell(i);
                    if (cell == null)
                    {
                        dr[i] = null;
                    }
                    else
                    {
                        dr[i] = cell.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }


        static void testExport()
        {
            DataSet ds = new DataSet();

            DataTable db = new DataTable("tb0");

            DataColumn dc = null;
            dc = db.Columns.Add("id", Type.GetType("System.String"));
            dc = db.Columns.Add("name", Type.GetType("System.String"));
            dc = db.Columns.Add("sex", Type.GetType("System.String"));
            ds.Tables.Add(db);

            DataRow row = ds.Tables[0].NewRow();
            row["id"] = "1";
            row["name"] = "张三";
            row["sex"] = "男";
            ds.Tables[0].Rows.Add(row);

            DataRow row2 = ds.Tables[0].NewRow();
            row["id"] = "2";
            row["name"] = "李四";
            row["sex"] = "男";
            ds.Tables[0].Rows.Add(row2);


            String[] title = new String[] { "编号", "姓名", "性别" };
            int[] width = new int[] { 20, 20, 20 };

            ExcalHelper e = new ExcalHelper("测试", title, width, 1);
            e.ExportExcel(ds, "c:/b.xls");

        }

        static void testExport(DataSet ds, String path)
        {

            String[] title = new String[] { "编号", "姓名", "性别" };
            int[] width = new int[] { 20, 20, 20 };
            ExcalHelper e = new ExcalHelper("测试", title, width, 1);
            e.ExportExcel(ds, path);

        }

        static DataSet ExecuteQuery(String sqltext)
        {

            DataSet dt = new DataSet();
            SqlCommand com = null;
            SqlDataAdapter sda = null;

            string coonString = "server=sql.w3249.vhostgo.com;database=vipsoft;uid=vipsoft;pwd=vip123456";
            SqlConnection conn = new SqlConnection(coonString);
            if (conn.State != ConnectionState.Open)
                conn.Open();

            com = new SqlCommand(sqltext, conn);
            sda = new SqlDataAdapter(com);

            sda.Fill(dt);

            conn.Close();
            return dt;

        }

        static void Main()
        {
            //String sqltext = "select id, sex name from memcard";
            //  DataSet ds = ExecuteQuery(sqltext);
            //testExport(ds, "c:/mem.xls");

            ExcalHelper obj = new ExcalHelper(4);
            DataTable _data = obj.ImportExcelFile("c:/mem.xls");
            _data.TableName = "memcard";



            if (_data != null && _data.Rows.Count > 0)
            {
                SqlBulkCopy bcp = new SqlBulkCopy("server=sql.w3249.vhostgo.com;database=vipsoft;uid=vipsoft;pwd=vip123456");
                bcp.DestinationTableName = "memcard";
                bcp.WriteToServer(_data);
                bcp.Close();
            }


        }
    }
}