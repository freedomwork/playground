using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace VipSoft
{
    public delegate void MainFormHistoryHandler(DataTable dtHis);
    public partial class Main : BaseForm
    {

        VipSoft.Model.MemCard memInfo = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Button_MemberManage_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "会员管理";
            this.myTabControl.SelectedIndex = 1;
        }

        private void Button_GoodsManage_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "产品管理";
            this.myTabControl.SelectedIndex = 2;
        }

        private void Button_MemberOrder_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "会员消费";
            this.myTabControl.SelectedIndex = 3;
        }

        private void Button_PointExchage_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "积分兑换";
            this.myTabControl.SelectedIndex = 4;
        }

        private void Button_Report_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "统计报表";
            this.myTabControl.SelectedIndex = 5;
        }

        private void Button_Setup_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "系统设置";
            this.myTabControl.SelectedIndex = 6;
        }

        private void panelButton_Item_Click(string senderName)
        {
            switch (senderName)
            {
                    //会员登记
                case "panelButton_Member_Add":
                    memRegister mRegister = new memRegister();
                    mRegister.ShowDialog();
                    break;
                case "panelButton_Member_List":
                    memList mList = new memList();
                    mList.ShowDialog();
                    break;
                case "panelButton_Member_Recharge":
                    prepaidCardRecharge pRecharge = new prepaidCardRecharge();
                    pRecharge.ShowDialog();
                    break;
                case "panelButton_Member_DataInput":
                    DataInput dmInput = new DataInput();
                    dmInput.ShowDialog();
                    break;
                case "panelButton_Goods_Add":
                    GoodsPutIn goodsPutIn = new GoodsPutIn();
                    goodsPutIn.ShowDialog();
                    break;
                case "panelButton_Goods_List":
                    GoodsList gList = new GoodsList();
                    gList.ShowDialog();
                    break;
                case "panelButton_Goods_DataInput":
                    DataInput dgInput = new DataInput();
                    dgInput.ShowDialog();
                    break;
                case "panelButton_stockAdd":
                    Stock_AddGoods stock_AddGoods = new Stock_AddGoods();
                    stock_AddGoods.orderType = "采购进货";
                    stock_AddGoods.ShowDialog();
                    break;
                case "panelButton_Gift_Exchang":
                    Exchang exchange = new Exchang();
                    exchange.ShowDialog();
                    break;
                case "panelButton_Gift_Setup":
                    GiftList giftList = new GiftList();
                    giftList.ShowDialog();
                    break;
                case "panelButton_Gift_His":
                    GiftHistory giftHis = new GiftHistory();
                    giftHis.ShowDialog();
                    break;
                case "panelButton_Order_Expense":
                    Expense exp = new Expense();
                    exp.ShowDialog();
                    break;
                case "panelButton_Order_Point":
                    Expense_Point exp_Pointe = new Expense_Point();
                    exp_Pointe.ShowDialog();
                    break;
                case "panelButton_Order_Expense_Time":
                    break;
                case "panelButton_Order_Cancel":
                    break;
                case "panelButton_Order_History":
                    ExpHistory expHis = new ExpHistory();
                    expHis.ShowDialog();
                    break;
                case "panelButton_Setup_Level":
                    SetLevel setLevel = new SetLevel();
                    setLevel.ShowDialog();
                    break;
                case "panelButton_Setup_GoodsClass":
                    SetClass setClass = new SetClass();
                    setClass.ShowDialog();
                    break;
                case "panelButton_Setup_Custom":
                    break;
                case "panelButton_Setup_Remind":
                    break;
                case "panelButton_Setup_Master":
                    VipSoft.SystemSet.Master master = new VipSoft.SystemSet.Master();
                    master.ShowDialog();
                    break;
                case "panelButton_Step_Shop":
                    Shop shop = new Shop();
                    shop.ShowDialog();
                    break;
                case "panelButton_SystemSet":
                    break;
                case "panelButton_Export_Order":
                    OrderReport orderReport = new OrderReport();
                    orderReport.ShowDialog();
                    break;
                case "panelButton_Export_Gift":
                    PointExchangeReport pointExchangeReport = new PointExchangeReport();
                    pointExchangeReport.ShowDialog();
                    break;
                case "panelButton_Export_Cai":
                    ReportStock rStock = new ReportStock();
                    rStock.ShowDialog();
                    break;
                case "panelButton_Export_Recharge":
                    RechargeMoneyReport rechrgeMoneyReport = new RechargeMoneyReport();
                    rechrgeMoneyReport.ShowDialog();
                    break;
                case "panelButton_Export_PointChange":
                    PointChangeReport pointChangeReport = new PointChangeReport();
                    pointChangeReport.ShowDialog();
                    break;
                case "panelButton_Export_Total":
                    break;
                case "panelButton_CouponSet":
                    Coupon coupon = new Coupon();
                    coupon.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void alButton_Shortcut_Click(object sender, EventArgs e)
        {
            AlSkin.AlControl.AlButton btn = (AlSkin.AlControl.AlButton)sender;
            switch (btn.Name)
            {
                case "alButton_Shortcut_SetClass":
                    SetClass setClass = new SetClass();
                    setClass.ShowDialog();
                    break;
                case "alButton_Shortcut_GoodsReport":
                    GoodsList gList = new GoodsList();
                    gList.ShowDialog();
                    break;
                case "alButton_cancle":
                    Stock_AddGoods cancel = new Stock_AddGoods();
                    cancel.orderType = "采购退货";
                    cancel.ShowDialog();
                    break;
                case "alButton_CaiSearch":
                    ReportStock rStock = new ReportStock();
                    rStock.ShowDialog();
                    break;
                case "alButton_Shortcut_SetLevel":
                    SetLevel setLevel = new SetLevel();
                    setLevel.ShowDialog();
                    break;
                case "alButton_Shortcut_SetCardType":
                    memCardType cardTypeWin = new memCardType();
                    cardTypeWin.ShowDialog();
                    break;
                case "alButton_Shortcut_moneyrule":
                    MoneyRuleList ruleList = new MoneyRuleList();
                    ruleList.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void toolStripButton_Item_Click(object sender, EventArgs e)
        {
            ToolStripButton item = (ToolStripButton)sender;
            switch (item.Name)
            {
                case "toolStripButton_SwipingCard":
                    this.label_Title.Text = "会员刷卡";
                    this.myTabControl.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ClearFormText();
        }

        protected void BindMemInfo(VipSoft.Model.MemCard memInfo)
        {
            string sex = memInfo.Sex == 0 ? "" : (memInfo.Sex == 1 ? "(男)" : "(女)");
            this.label_CardID.Text = memInfo.CardID + sex;
            this.label_Name.Text = memInfo.Name;
            this.label_Money.Text = memInfo.Money.ToString("￥0.00");
            this.label_Point.Text = memInfo.Point.ToString();
            this.label_Mobile.Text = memInfo.Mobile.ToString();

            this.label_State.Text = memInfo.State == (int)VipSoft.Common.CardState.Normal ? "正常" : (memInfo.State == (int)VipSoft.Common.CardState.Locked ? "锁定" : "挂失");
            this.label_TotalMoney.Text = memInfo.TotalMoney.ToString("￥0.00");

            if (!memInfo.IsPast)
                this.label_PassTime.Text = "不限";
            else
                this.label_PassTime.Text = ((DateTime)(memInfo.PastTime)).ToShortDateString();
            this.myMemberPhoto.PhotoPath = memInfo.Photo;

            this.label_Level.Text = Function.LevelIDToName((int)memInfo.LevelID);
        }

        private void ClearFormText()
        {
            this.label_CardID.Text = "";
            this.label_Name.Text = "";
            this.label_Birth.Text = "";
            this.label_Level.Text = "";
            this.label_Mobile.Text = "";
            this.label_Money.Text = "";
            this.label_OverCount.Text = "";
            this.label_PassTime.Text = "";
            this.label_Pay.Text = "";
            this.label_Point.Text = "";
            this.label_State.Text = "";
            this.label_TotalMoney.Text = "";
        }

        #region   会员充值记录
        /// <summary>
        /// 重新绑定会员充值记录。
        /// </summary>
        private void BindRechageHistory()
        {
            dataGridView_Recharge.Rows.Clear();
            BindRechageHistoryThread();
        }
        private void BindRechageHistoryThread()
        {
            Thread.Sleep(50);
            VipSoft.BLL.RechargeLog re = new VipSoft.BLL.RechargeLog();
            DataTable dt = re.GetList(" memid=" + memInfo.ID + "").Tables[0];
            if (dt.Rows.Count == 0)
            {
                this.label_Loading_History1.Text = "暂无充值记录！";
                this.label_Loading_History1.Visible = true;
                this.dataGridView_Recharge.Visible = false;
                return;
            }
            this.label_Loading_History1.Visible = false;
            this.dataGridView_Recharge.Visible = true;
            foreach (DataRow dr in dt.Rows)
            {
                this.dataGridView_Recharge.Rows.Add(dr["CardID"], dr["MemName"], dr["Type"].ToString() == "0" ? "初始化" : dr["Type"].ToString() == "1" ? "充值" : "充次", dr["Money"], dr["CreateTime"], dr["moneyinfo"], dr["remark"]);
            }
        }


        #endregion
        #region   会员兑换记录
        /// <summary>
        /// 重新绑定会员兑换记录
        /// </summary>
        private void BindLiPingHistory()
        {
            dataGridView_List.Rows.Clear();
            BindLiPingHistoryThread();
        }
        private void BindLiPingHistoryThread()
        {
            Thread.Sleep(50);
            VipSoft.BLL.ExchangeLog ex = new VipSoft.BLL.ExchangeLog();
            DataTable dt = ex.GetList(" MemCardID='" + memInfo.CardID + "'").Tables[0];
            if (dt.Rows.Count == 0)
            {
                this.label_Loading_History2.Text = "暂无兑换记录！";
                this.label_Loading_History2.Visible = true;
                this.dataGridView_List.Visible = false;
                return;
            }
            this.label_Loading_History2.Visible = false;
            this.dataGridView_List.Visible = true;
            foreach (DataRow dr in dt.Rows)
            {
                this.dataGridView_List.Rows.Add(dr["GoodsName"].ToString(), dr["Point"].ToString(),
                       dr["Number"].ToString(), dr["CreateTime"].ToString());
            }
        }
        #endregion

        private void BindMemExpHistory()
        {
            dataGridView_OrderList.Rows.Clear();
            dataGridView_DetailList.DataSource = null;
            this.label_Loading_History.Text = "正在提取数据，请稍候……";
            this.label_Loading_History.Visible = true;
            Thread thread = new Thread(new ThreadStart(BindMemExpHistoryThread));
            thread.IsBackground = true;
            thread.Start();
        }

        private void BindMemExpHistoryThread()
        {
            Thread.Sleep(100);
            string[] condition = { "MemID=" + memInfo.ID };
            VipSoft.BLL.OrderLog ol = new VipSoft.BLL.OrderLog();
            int rescount = 0;
            DataTable dt = ol.GetList(20, 0, out rescount, condition).Tables[0];
            MainFormHistoryHandler handler = new MainFormHistoryHandler(BindMemExpHistoryInvoke);
            if (this.IsHandleCreated)
                this.BeginInvoke(handler, dt);
        }

        private void BindMemExpHistoryInvoke(DataTable dtHis)
        {
            if (dtHis.Rows.Count == 0)
            {
                this.label_Loading_History.Text = "暂无消费记录！";
                return;
            }
            foreach (DataRow dr in dtHis.Rows)
            {
                this.dataGridView_OrderList.Rows.Add(dr["ID"].ToString(), dr["OrderCode"].ToString(),
                    decimal.Parse(dr["TotalMoney"].ToString()).ToString("￥0.00"), decimal.Parse(dr["DiscountMoney"].ToString()).ToString("￥0.00"),
                    dr["TotalNumber"].ToString(), dr["GavePoint"].ToString(), Function.GetPayTypeName(int.Parse(dr["PayType"].ToString())),
                    dr["OrderType"].ToString() == "0" ? "储值消费" : (dr["OrderType"].ToString() == "1" ? "记次消费" : (dr["OrderType"].ToString() == "2" ? "退货" : "快速消费")),
                    dr["CreateTime"].ToString(), dr["Remark"].ToString());
            }
            this.label_Loading_History.Visible = false;
        }

        private void TextBox_CardID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (this.TextBox_CardID.Text.Trim() == "")
                {
                    MessageBox.Show("请输入正确的卡号，或者手机号码！");
                    this.TextBox_CardID.Focus();
                    this.TextBox_CardID.SelectAll();
                    return;
                }

                memInfo = new VipSoft.BLL.MemCard().GetModel(this.TextBox_CardID.Text.Trim());

                if (memInfo != null)
                {
                    BindMemInfo(memInfo);
                    this.myTabControl1.SelectedIndex = 0;
                    BindMemExpHistory();
                }
                else
                {
                    memInfo = null;
                    ClearFormText();
                    MessageBox.Show("未找到此会员！");
                    this.TextBox_CardID.Focus();
                    this.TextBox_CardID.SelectAll();
                }
            }
        }

    }
}
