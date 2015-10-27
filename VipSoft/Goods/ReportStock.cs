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

        private void btnCondition_Click(object sender, EventArgs e)
        {
            this.dgvDetail.Rows.Clear();
            this.dgvCollect.Rows.Clear();

            int index = this.tabStock.SelectedIndex;
            string contion = "ShopID="+PublicState.Master.ShopID;
            if (this.txtContent.Text.Trim().ToString() == "")
            {
                contion += " and CreateTime  between  '" + this.lblStartTime.Value.ToString() + "' and  '" + this.lblEndTime.Value.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second).ToString("yyyy-MM-dd HH:mm:ss") + "'   ";
            }
            else if (this.txtContent.Text.Trim().ToString() != "")
            {
                contion += "and (GoodsCode like '%" + this.txtContent.Text.Trim().ToString() + "%' or GoodsName like '%" + this.txtContent.Text.Trim().ToString() + "%') and CreateTime  between  '" + this.lblStartTime.Value.ToString() + "' and  '" + this.lblEndTime.Value.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second).ToString("yyyy-MM-dd HH:mm:ss") + "'  ";
            }

            if (index == 0) //采购详细
            {
                DataSet ds = new VipSoft.BLL.OrderGoods().GetList(contion + " order by CreateTime desc");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    this.dgvDetail.Rows.Add(dr["CreateTime"], dr["GoodsCode"], dr["GoodsName"], dr["GoodsUnit"], dr["Price"], dr["Number"], dr["TotalMoney"], dr["MasterName"]);
                }
            }
            else if (index == 1) //采购汇总
            {
                DataSet ds = new VipSoft.BLL.OrderGoods().GetListCollect("SELECT  GoodsCode,GoodsName,GoodsUnit,sum(Number) as sumNumber from OrderGoods  where " + contion + " group by GoodsCode,goodsName,goodsUnit");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    this.dgvCollect.Rows.Add(dr["GoodsCode"], dr["GoodsName"], dr["GoodsUnit"], dr["sumNumber"]);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
