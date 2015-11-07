using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Web;
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.POIFS;
using NPOI.Util;

namespace VipSoft.Common.NPOI2
{
    public class ExcelUtils
    {

        public static DataTable transExcelToDT(ExcelInfo ei, DataTable dt)
        {
            //读取excel，将数据封装到DT
            dt = readExcel(ei, dt);
            return dt;
        }

        //excel读取，没有考虑大数据量的情况，一次性将数据读取进内存，建议导入记录一次不多于1000条
        private static DataTable readExcel(ExcelInfo ei, DataTable dt)
        {
            HSSFWorkbook hssfworkbook;
            try
            {
                using (FileStream file = new FileStream(ei.filePath, FileMode.Open, FileAccess.Read))
                {
                    //初始化一个工作簿对象
                    hssfworkbook = new HSSFWorkbook(file);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            //获取数据页
            NPOI.SS.UserModel.ISheet sheet = hssfworkbook.GetSheetAt(ei.dataSheetIdx);
            //得到数据行
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator(); ;
            
            for (int k = 0; k < ei.dataRowIdx; k++)
                rows.MoveNext();

           HSSFRow row = null;

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


        public static void printDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.WriteLine(dt.Rows[i][j].ToString());
                }
            }

            Console.ReadKey();
        }


        //excel导出，最多只能导出65535条记录，没有考虑分sheet页，后续如果数据量较多再扩充
        public static void writeExcel(DataTable dt, ExcelInfo ei, String[] colTitle, int[] colWidth)
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(ei.sheetName);

            HSSFRow rowtitle = (HSSFRow)sheet.CreateRow(0);
            for (int j = 0; j < colTitle.Length;j++)
            {
                //设置列宽
                sheet.SetColumnWidth(j, colWidth[j] * 255);
                rowtitle.CreateCell(j).SetCellValue(colTitle[j]);
            }

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
                using (Stream stream = File.Open(ei.filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    workbook.Write(stream);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
