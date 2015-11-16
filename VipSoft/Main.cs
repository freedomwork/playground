using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class Main : BaseForm
    {
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
                    break;
                case "panelButton_Export_Gift":
                    PointExchangeReport pointExchangeReport = new PointExchangeReport();
                    pointExchangeReport.ShowDialog();
                    break;
                case "panelButton_Export_Cai":
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

        }

    }
}
