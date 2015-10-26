using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class ReportStock : BaseForm
    {
        public ReportStock()
        {
            InitializeComponent();
        }

        //加载
        private void ReportStock_Load(object sender, EventArgs e)
        {

            this.lblStartTime.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            this.lblEndTime.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
        }
        /// <summary>
        /// 导出打印
        /// </summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
           
        }
        private void txtContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // 全角自动转换半角
            if ((int)e.KeyChar >= 65296 && (int)e.KeyChar <= 65305)
            {
                e.KeyChar = (char)((int)e.KeyChar - 65248);
            }
        }
    }
}
