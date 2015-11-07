using System;
using System.Collections.Generic;
using System.Text;

namespace VipSoft.Common.NPOI2
{
    public  class ExcelInfo
    {
        //excel的文件路径
        public String filePath;

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        //数据在excel的sheet页
        public int dataSheetIdx;

        public int DataSheetIdx
        {
            get { return dataSheetIdx; }
            set { dataSheetIdx = value; }
        }

        //数据是sheet的第几行开始
        public int dataRowIdx;

        public int DataRowIdx
        {
            get { return dataRowIdx; }
            set { dataRowIdx = value; }
        }

        public String sheetName;

        public String SheetName
        {
            get { return sheetName; }
            set { sheetName = value; }
        }

    }
}
