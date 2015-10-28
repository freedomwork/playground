using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class Stock_Detial : BaseForm
    {

        public event GoodsRefreshList goodsRefresh;   //增加进货商品

        public event GoodsModifyList goodsModify;     //修改已选商品

        public int GoodsID;

        public string OrderType;

        string sql = "";        //sql语句
        VipSoft.BLL.Goods goods = null;
        VipSoft.Model.Goods gs = null;
        int _goodsNumber = 0;
        string _buyPrice = "";
        string _sumMoney = "";

        public Stock_Detial()
        {
            InitializeComponent();
        }

        public Stock_Detial(int goodsID, int goodsNumber, string buyPrice, string sumMoney, string orderType)
        {
            InitializeComponent();
            GoodsID = goodsID;
            _goodsNumber = goodsNumber;
            _buyPrice = buyPrice;
            _sumMoney = sumMoney;
            OrderType = orderType;
        }

        private void Stock_Detial_Load(object sender, EventArgs e)
        {
            if (OrderType == "采购进货")
            {
                this.Text = "采购进货";
                this.tabPage1.Text = "该商品进货历史";
                sql = "select top 10 * from OrderGoods where GoodsID=" + GoodsID + " and Type=0 order by CreateTime desc";
            }
            else
            {
                this.Text = "采购退货";
                this.tabPage1.Text = "该商品退货历史";
                sql = "select top 10 * from OrderGoods where GoodsID=" + GoodsID + " and Type=1 order by CreateTime desc";
                this.lblPrice.Text = "退货价格：";
            }

            //进货
            if (goodsRefresh != null) //进货
            {
                BindGoodsTest();

            }
            if (goodsModify != null)//修改
            {
                BindGoodsTest();
            }
            BindHistory();
        }

        /// <summary>
        /// 绑定进货历史
        /// </summary>
        public void BindHistory()
        {
            DataSet ds = new VipSoft.BLL.OrderGoods().GetListCollect(sql);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.dgvAnnalList.Rows.Add(dr["CreateTime"], dr["Price"], dr["Number"], dr["TotalMoney"]);
            }
        }

        /// <summary>
        /// 绑定编辑商品的详细信息
        /// </summary>
        private void BindGoodsTest()
        {
            goods = new VipSoft.BLL.Goods();
            gs = new VipSoft.Model.Goods();
            gs = goods.GetModel(GoodsID);

            lblGoodsCode.Text = gs.GoodsCode;
            lblGoodsName.Text = gs.Name;
            lblUnitType.Text = gs.Unit;
            // lblRemark.Text = gs.Remark;
            lblNameCode.Text = gs.NameCode;
            // lblRemark.Text = gs.Remark;
            lblNameCode.Text = gs.NameCode;

            lblBuyPrice.Text = gs.BuyPrice.ToString(); //参考进价
            lblNumber.Text = gs.Number.ToString();     //当前库存
            //  txtReferencePrice.Text = gs.BuyPrice.ToString("￥0.00");
            if (goodsModify == null)  //不是修改商品
            {

                this.txtReferencePrice.Text = ((decimal)gs.BuyPrice).ToString("￥0.00");
            }
            else
            {
                this.txtCount.Text = _goodsNumber.ToString();
                this.txtReferencePrice.Text = _buyPrice;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (goodsModify != null)  //修改
            {
                goodsModify(gs, this.txtReferencePrice.Text.Replace("￥", ""), this.txtCount.Text, this.lblSumMoney.Text);
            }
            else                   //进货
            {
                goodsRefresh(gs, this.txtReferencePrice.Text.Replace("￥", ""), this.txtCount.Text, this.lblSumMoney.Text);
            }

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReferencePrice_TextChanged(object sender, EventArgs e)
        {
            MoneyChange();
        }

        //算总金额方法
        public void MoneyChange()
        {
            //进价
            decimal buyPrice = decimal.Parse(this.txtReferencePrice.Text.Trim().ToString().Replace("￥", ""));

            //数量
            decimal number = decimal.Parse(this.txtCount.Text.Trim().ToString());

            this.lblSumMoney.Text = (buyPrice * number).ToString();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (!Maticsoft.Common.FormValidate.IsNumber(this.txtCount.Text))
            {
                MessageBox.Show("请输入正整数！！");
                this.txtCount.Text = "1";
            }

            if (OrderType == "采购退货")
            {
                if (int.Parse(this.txtCount.Text.ToString()) > int.Parse(this.lblNumber.Text.ToString()))
                {
                    MessageBox.Show("输入退货数量大于当前库存！！");
                    this.txtCount.Text = "1";
                }
            }
            this.txtCount.Focus();
            MoneyChange();
        }
    }
}
