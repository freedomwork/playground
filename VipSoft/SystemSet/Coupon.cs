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
                case "DelBtn":
                    if (this.dataGridView_CouponList.SelectedRows.Count != 1)
                        return;

                    int ID = int.Parse(this.dataGridView_CouponList.SelectedRows[0].Cells[0].Value.ToString());
                    DialogResult dRes = MessageBox.Show("您确定要删除此优惠券么？此操作不可恢复。", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dRes == DialogResult.No)
                        return;
                    VipSoft.BLL.Coupon bllCoupon = new BLL.Coupon();
                    VipSoft.BLL.CouponDetail bllCouponDetail = new BLL.CouponDetail();
                    if (bllCoupon.Delete(ID))
                    {
                        DataSet ds = bllCouponDetail.GetList("CouponID=" + ID.ToString());
                        string IDs = string.Empty;
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            IDs += dr["ID"].ToString() + ",";
                        }
                        if (!string.IsNullOrEmpty(IDs))
                        {
                            IDs = IDs.Substring(0, IDs.Length - 1);
                            bllCouponDetail.DeleteList(IDs);
                        }

                        MessageBox.Show("电子优惠券删除成功！");
                        BindList();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                    break;
                default:
                    break;
            }
        }

        private void BindList()
        {
            this.dataGridView_CouponList.Rows.Clear();
            this.dataGridView_CouponDetail.Rows.Clear();
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

        private void BindCouponDetail()
        {
            if (this.dataGridView_CouponList.SelectedRows.Count != 1)
                return;

            this.dataGridView_CouponDetail.Rows.Clear();
            string CouponID = this.dataGridView_CouponList.SelectedRows[0].Cells["Column_ID"].Value.ToString();
            VipSoft.BLL.CouponDetail detail = new VipSoft.BLL.CouponDetail();
            DataTable dt = detail.GetList("CouponID=" + CouponID ).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                this.dataGridView_CouponDetail.Rows.Add(dr["ID"].ToString(), dr["Title"].ToString(), dr["CouponNumber"].ToString(), dr["State"].ToString() == "0" ? "未使用" : "已使用", dr["UsedTime"].ToString());
            }
        }

        private void dataGridView_CouponList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                this.dataGridView_CouponList.Rows[e.RowIndex].Selected = true;
            BindCouponDetail();
        }

    }
}
