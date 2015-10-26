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
                    break;
                case "alButton_CaiSearch":
                    ReportStock rStock = new ReportStock();
                    rStock.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
