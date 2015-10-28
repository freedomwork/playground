using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    //商品进货增加刷新
    public delegate void GoodsRefreshList(VipSoft.Model.Goods goods, string buyPrice, string number, string sumMoney);

    //修改(进货)已选商品数量
    public delegate void GoodsModifyList(VipSoft.Model.Goods goods, string buyPrice, string number, string sumMoney);

    public partial class Stock_AddGoods : BaseForm
    {
        //商品类别
        DataTable dtClass = null;
        // 查询条件
        //string[] condition;
        string selectGoodsCode = "";  //所选中的行
        public string orderType = ""; //是进货还是退货

        VipSoft.BLL.GoodsClass gsClass = null;

        string condtion = "";

        public Stock_AddGoods()
        {
            InitializeComponent();
        }

        private void Stock_AddGoods_Load(object sender, EventArgs e)
        {
            if (orderType == "采购进货")
            {
                this.Text = "采购进货 ";
                BindLater();
            }
            else
            {
                this.Text = "采购退货";
                this.tabControl1.TabPages.RemoveAt(2);
            }
            //进货时
            BindGoodsList();
            //绑定商品类别
            BindClass();
        }

        #region 最近进货的商品

        public void BindLater()
        {
            this.dgvEarlyTimeList.Rows.Clear();
            DataSet ds = new VipSoft.BLL.OrderGoods().GetListCollect(" select top 10 * from  OrderGoods where Type=0 and ShopID="+PublicState.Master.ShopID+"  order by CreateTime desc");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.dgvEarlyTimeList.Rows.Add(dr["GoodsID"], dr["GoodsCode"], dr["GoodsName"], dr["Number"], dr["Price"], dr["GoodsUnit"], dr["CreateTime"]);
            }
        }

        #endregion

        /// <summary>
        /// 将分类绑定到树上
        /// </summary>
        private void BindClass()
        {

            gsClass = new VipSoft.BLL.GoodsClass();
            dtClass = gsClass.GetList("ShopID="+PublicState.Master.ShopID).Tables[0];

            this.treeView_Class.Nodes.Clear();
            Function.BindGoodsClass(this.treeView_Class, dtClass);
        }

        // 使用多线程读取产品列表，以防止读取产品列表的速度影响窗口显示的速度
        private void BindGoodsList()
        {
            this.dgvGoodsList.Rows.Clear();
            VipSoft.BLL.Goods goods = new VipSoft.BLL.Goods();
            DataSet dtGoods = goods.GetList("  GoodsType=0 and ShopID="+PublicState.Master.ShopID + condtion);
            foreach (DataRow dr in dtGoods.Tables[0].Rows)
            {
                this.dgvGoodsList.Rows.Add(dr["ID"], dr["GoodsCode"], dr["Name"], dr["Unit"], dr["BuyPrice"], dr["Number"]);
            }
            this.label_Tree_load.Visible = false;
            condtion = "";
        }

        private void treeView_Class_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.dgvGoods.Rows.Clear();
            string name = e.Node.Name;

            string condition = " ShopID=" + PublicState.Master.ShopID;
            if (name == "class_0")
            {
                condition += " and  GoodsType=0";
            }
            else if (name.IndexOf("class_") != -1)
            {
                string classID = name.Substring(6, name.Length - 6);
                if (!Function.CheckIsLowestClass(dtClass, classID))
                {
                    condition += (" and ClassId in (" + Function.GetChildClassListStr(dtClass, classID) + "," + classID + ") and GoodsType=0");
                }
                else
                {
                    condition += " and ClassId in (" + classID + ") and GoodsType=0";
                }
            }

            DataSet ds = new VipSoft.BLL.Goods().GetList(condition);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.dgvGoods.Rows.Add(dr["ID"], dr["GoodsCode"], dr["Name"], dr["Unit"], dr["BuyPrice"], dr["Number"]);
            }
        }

        private void dgvGoodsList_DoubleClick(object sender, EventArgs e)
        {
            //商品的ID号
            int goodsID = int.Parse(this.dgvGoodsList.SelectedRows[0].Cells[0].Value.ToString());

            if (orderType == "采购进货")
            {
                Stock_Detial detail = new Stock_Detial();
                detail.GoodsID = goodsID;
                detail.OrderType = "采购进货";
                detail.goodsRefresh += new GoodsRefreshList(detail_goodsRefresh);
                detail.ShowDialog();
            }
            else
            {
                Stock_Detial detail = new Stock_Detial();
                detail.GoodsID = goodsID;
                detail.OrderType = "采购退货";
                detail.goodsRefresh += new GoodsRefreshList(detail_goodsRefresh);
                detail.ShowDialog();
            }
        }

        void detail_goodsRefresh(VipSoft.Model.Goods goods, string buyPrice, string number, string sumMoney)
        {
            this.dgvSelectedList.Rows.Add(goods.ID, goods.GoodsCode, goods.Name, goods.Unit, "￥" + buyPrice, number, "￥" + sumMoney);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (orderType == "采购进货")
            {
                type = 0;
            }
            else                //退货
            {
                type = 1;
            }

            List<VipSoft.Model.OrderGoods> list = new List<VipSoft.Model.OrderGoods>();
            VipSoft.Model.OrderGoods orderInfo = null;
            for (int i = 0; i < this.dgvSelectedList.Rows.Count; i++)
            {
                orderInfo = new Model.OrderGoods();
                orderInfo.GoodsID = int.Parse(this.dgvSelectedList.Rows[i].Cells[0].Value.ToString());
                orderInfo.GoodsCode = this.dgvSelectedList.Rows[i].Cells[1].Value.ToString();
                orderInfo.GoodsName = this.dgvSelectedList.Rows[i].Cells[2].Value.ToString();
                orderInfo.type = type;
                orderInfo.GoodsUnit = this.dgvSelectedList.Rows[i].Cells[3].Value.ToString();
                orderInfo.Price = decimal.Parse(this.dgvSelectedList.Rows[i].Cells[4].Value.ToString().Replace("￥", ""));
                orderInfo.Number = int.Parse(this.dgvSelectedList.Rows[i].Cells[5].Value.ToString());
                orderInfo.TotalMoney = decimal.Parse(this.dgvSelectedList.Rows[i].Cells[6].Value.ToString().Replace("￥", ""));
                orderInfo.CreateTime = DateTime.Now;
                orderInfo.MasterID = PublicState.Master.ID;
                orderInfo.MasterName = PublicState.Master.Name;
                orderInfo.ShopID = PublicState.Master.ShopID;
                orderInfo.ShopName = PublicState.Master.ShopName;
                list.Add(orderInfo);
            }
            bool isTrue = new VipSoft.BLL.OrderGoods().Add(list);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSelectedList.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("是否要删除该商品信息?", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                int row = this.dgvSelectedList.SelectedRows[0].Cells[0].RowIndex;
                this.dgvSelectedList.Rows.RemoveAt(row);
            }
            else
            {
                MessageBox.Show("没有删除数据！", "系统提示");
                return;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int goodsID = 0;
            if (this.dgvSelectedList.SelectedRows.Count == 0)
                return;

            goodsID = int.Parse(this.dgvSelectedList.SelectedRows[0].Cells[0].Value.ToString());
            int goodsNumber = int.Parse(this.dgvSelectedList.SelectedRows[0].Cells[5].Value.ToString());    //数量
            string buyPrice = this.dgvSelectedList.SelectedRows[0].Cells[4].Value.ToString();             //单价
            string sumMoney = this.dgvSelectedList.SelectedRows[0].Cells[6].Value.ToString();             //总金额

            if (orderType == "采购进货")
            {
                Stock_Detial stockDetail = new Stock_Detial(goodsID, goodsNumber, buyPrice, sumMoney, orderType);
                stockDetail.goodsModify += new GoodsModifyList(stockDetail_goodsModify);
                stockDetail.ShowDialog();
            }
            else
            {
                Stock_Detial stockDetail = new Stock_Detial(goodsID, goodsNumber, buyPrice, sumMoney, orderType);

                stockDetail.goodsModify += new GoodsModifyList(stockDetail_goodsModify);
                stockDetail.ShowDialog();
            }
        }

        void stockDetail_goodsModify(VipSoft.Model.Goods goods, string buyPrice, string number, string sumMoney)
        {
            int row = this.dgvSelectedList.SelectedRows[0].Cells[0].RowIndex;
            this.dgvSelectedList.Rows.RemoveAt(row);
            this.dgvSelectedList.Rows.Insert(row, goods.ID, goods.GoodsCode, goods.Name, goods.Unit, decimal.Parse(buyPrice.Replace("￥", "")), number, "￥" + sumMoney);
            this.dgvSelectedList.Rows[row].Selected = true;
        }

        private void btnSelectIn_Click(object sender, EventArgs e)
        {
            int goodsID = 0;
            //商品的ID号
            try
            {
                goodsID = int.Parse(this.dgvGoodsList.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("查找不到产品信息！");
                return;
            }
            if (orderType == "采购进货")
            {
                Stock_Detial detail = new Stock_Detial();
                detail.GoodsID = goodsID;
                detail.OrderType = orderType;
                detail.goodsRefresh += new GoodsRefreshList(detail_goodsRefresh);
                detail.ShowDialog();
            }
            else
            {
                Stock_Detial detail = new Stock_Detial();
                detail.GoodsID = goodsID;
                detail.OrderType = orderType;
                detail.goodsRefresh += new GoodsRefreshList(detail_goodsRefresh);
                detail.ShowDialog();
            }
        }

        private void dgvGoods_DoubleClick(object sender, EventArgs e)
        {
            //商品的ID号
            int goodsID = int.Parse(this.dgvGoods.SelectedRows[0].Cells[0].Value.ToString());

            if (orderType == "采购进货")
            {
                Stock_Detial detail = new Stock_Detial();
                detail.GoodsID = goodsID;
                detail.OrderType = orderType;
                detail.goodsRefresh += new GoodsRefreshList(detail_goodsRefresh);
                detail.ShowDialog();
            }
            else
            {
                Stock_Detial detail = new Stock_Detial();
                detail.GoodsID = goodsID;
                detail.OrderType = orderType;
                detail.goodsRefresh += new GoodsRefreshList(detail_goodsRefresh);
                detail.ShowDialog();
            }
        }

        private void dgvEarlyTimeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string goodsCode = this.dgvEarlyTimeList.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < dgvGoodsList.Rows.Count; i++)
            {
                if (this.dgvGoodsList.Rows[i].Cells[0].Value.ToString() == goodsCode)
                {
                    this.dgvGoodsList.Rows[i].Selected = true;
                    return;
                }
            }
        }

    }
}
