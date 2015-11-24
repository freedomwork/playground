using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;   

namespace VipSoft
{
    public partial class Coupon : BaseForm
    {
        int pageSize = 20;
        int currentPage = 0;
        int resCount = 0;
        int pageCount = 0;

        string[] condition;

        public Coupon()
        {
            InitializeComponent();
        }

        private void toolStripButton_Item_Click(object sender, EventArgs e)
        {
            ToolStripButton item = (ToolStripButton)sender;
            switch (item.Name)
            {
                case "AddBtn":
                    AddCoupon addCoupon = new AddCoupon();
                    addCoupon.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void BindList()
        {
            this.dataGridView_CouponList.Rows.Clear();
            DataSet ds = new VipSoft.BLL.Coupon().GetList(pageSize, currentPage, out resCount, condition);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.dataGridView_CouponList.Rows.Add(dr["ID"].ToString(), dr["Title"].ToString(), dr["Prefix"].ToString(),dr["Money"].ToString(), dr["Type"].ToString() == "0" ? "永久有效" : dr["StartTime"].ToString() + "-" + dr["EndTime"].ToString() + "内有效", dr["Remark"].ToString());
            }

            BindPage();
        }

        /// <summary>
        /// 绑定分页
        /// </summary>
        private void BindPage()
        {
            this.pager1.PageSize = pageSize;
            this.pager1.CurrentPage = currentPage;
            this.pager1.RecordCount = resCount;
            this.pager1.PagerBind();
        }

        private void Coupon_Load(object sender, EventArgs e)
        {
            BindList();
        }

        private void pager1_EventPaging(Vipsoft.Controls.EventPagingArg e)
        {
            currentPage = e.PageIndex;
            BindList();
        }
    }
}
