using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VipSoft.Common;

namespace VipSoft
{
    public partial class Expense_Point : BaseForm
    {
        /// <summary>
        /// 当前会员卡号
        /// </summary>
        public string CurrentCardID = "";
        /// <summary>
        /// 当前会员
        /// </summary>
        private VipSoft.Model.MemCard memInfo;

        /// <summary>
        /// 当前订单
        /// </summary>
        private VipSoft.Model.OrderLog order;

        /// <summary>
        /// 散客消费
        /// </summary>
        public bool isTravelerMember = false;

        public Expense_Point()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 清除label的初始数据
        /// </summary>
        private void ClearFormText()
        {
            memInfo = null;
            this.label_MemLevel.Text = "";
            this.label_MemMoney.Text = "";
            this.label_MemName.Text = "";
            this.label_MemPoint.Text = "";
            this.label_MemTotalMoney.Text = "￥0.00";
            this.TextBox_PointMoney1.Text = "￥0.00";
            this.TextBox_PointMoney2.Text = "￥0.00";
            this.TextBox_PointPoint.Text = "0";
            this.txt_Beizhu.Text = "";
            this.radioButton_Point1.Checked = true;
            this.searchMember1.CardID = "";
            this.searchMember1.Focus();
            this.searchMember1.Select();
        }

        /// <summary>
        /// 绑定会员基本信息
        /// 在绑定会员基本信息时，自动读取出当前会员级别所能享受到的打折折扣率，并记录下来。
        /// </summary>
        private void BindMemberMsg()
        {
            this.searchMember1.CardID = memInfo.CardID;
            this.label_MemName.Text = memInfo.Name;
            this.label_MemMoney.Text = memInfo.Money.ToString("￥0.00");
            this.label_MemPoint.Text = memInfo.Point.ToString();
            this.label_MemTotalMoney.Text = memInfo.TotalMoney.ToString("￥0.00");

            this.label_MemLevel.Text = Function.LevelIDToName((int)memInfo.LevelID) + "(" + (Function.LevelIDToPercent((int)memInfo.LevelID) == 1M ? "不打" : (Function.LevelIDToPercent((int)memInfo.LevelID) * 10).ToString()) + "折)";
        }

        /// <summary>
        /// 生成订单号
        /// </summary>
        /// <returns></returns>
        private string CreateOrderCode()
        {
            return DateTime.Now.ToString("yyMMddhhssmmff");
        }

        private void Expense_Point_Load(object sender, EventArgs e)
        {
            ClearFormText();
            if (CurrentCardID != "")
            {
                VipSoft.BLL.MemCard card = new VipSoft.BLL.MemCard();
                memInfo = card.GetModel(CurrentCardID);
                if (memInfo != null)
                    BindMemberMsg();
                this.TextBox_PointMoney1.Select();
            }
            else
                this.searchMember1.Select();
        }

        private void searchMember1_EventMemberSelected(Model.MemCard selectedMemInfo)
        {
            ClearFormText();
            memInfo = selectedMemInfo;
            if (memInfo.IsPast && memInfo.PastTime <= DateTime.Now)
            {
                memInfo = null;
                ClearFormText();
                MessageBox.Show("对不起，此会员卡有效期限已过，无法进行消费。");
                this.searchMember1.CardID = "";
            }
            else
            {
                BindMemberMsg();
                TextBox_PointMoney1.Focus();
                TextBox_PointMoney1.SelectAll();
            }
        }

        private void searchMember1_ShanKeSelected()
        {
            this.checkBox_NoMember.Checked = true;
        }

        private void checkBox_NoMember_CheckedChanged(object sender, EventArgs e)
        {
            this.searchMember1.Enabled = !(this.checkBox_NoMember.Checked);
            isTravelerMember = this.checkBox_NoMember.Checked;
            ClearFormText();

            if (this.checkBox_NoMember.Checked)
            {
                this.radioButton_Point1.Enabled = false;
                this.radioButton_Point2.Checked = true;
                this.searchMember1.CardID = "";
                this.TextBox_PointMoney1.Focus();
                this.TextBox_PointMoney1.Select();
            }
            else
            {
                this.radioButton_Point1.Enabled = true;
                this.radioButton_Point1.Checked = true;
                this.radioButton_Point2.Checked = false;
            }
        }

        private void Button_PointExpense_Click(object sender, EventArgs e)
        {
            if (!isTravelerMember)
            {
                if (memInfo == null)
                {
                    MessageBox.Show("请先刷卡选择会员，再进行此操作。（散客不能进行消费获得积分的操作）");
                    return;
                }
                if (memInfo.State != 0)
                {
                    string s = memInfo.State == 1 ? "锁定" : "挂失";
                    MessageBox.Show("当前会员状态为：" + s + "，此状态会员将无法进行消费。");
                    return;
                }
            }
            else
            {
                if (decimal.Parse(this.TextBox_PointMoney2.Text.Replace("￥", "")) < 0)
                {
                    MessageBox.Show("请输入消费金额！");
                    return;
                }
            }

            if (this.TextBox_PointPoint.Text == "")
            {
                MessageBox.Show("请输入相关金额或者积分数量！");
                return;
            }

            VipSoft.BLL.OrderLog bllOrderLog=new BLL.OrderLog();
            VipSoft.BLL.MemCard bllMemCard = new BLL.MemCard();
            VipSoft.BLL.PointLog bllPointLog = new BLL.PointLog();
            string orderCode = CreateOrderCode();
            decimal money = decimal.Parse(this.TextBox_PointMoney2.Text.Replace("￥", ""));
            decimal totlemoney = decimal.Parse(this.TextBox_PointMoney1.Text.Replace("￥", ""));
            if (radioButton_Point1.Checked && money > memInfo.Money)
            {
                MessageBox.Show("您选择的余额支付，但是此会员账户余额不足。");
                return;
            }

            string payInfo = radioButton_Point1.Checked ? (money + "|0|0|0") : ("0|" + money + "|0|0");
            int point = int.Parse(TextBox_PointPoint.Text);
            string remark = this.txt_Beizhu.Text;

            if (isTravelerMember)  //散客消费
            {
                OrderPayType payType = radioButton_Point1.Checked ? OrderPayType.CardPay : OrderPayType.CashPay;
                order = new Model.OrderLog();
                order.OrderCode = orderCode;
                order.OrderType = 3;
                order.MemID = 59;
                order.CardID = "0";
                order.MemName = "散客消费";
                order.TotalNumber = 0;
                order.TotalMoney = totlemoney;
                order.DisCountMoney = money;
                order.PayType=(int)payType;
                order.PayInfo = payInfo;
                order.Point = 0;
                order.CreateDateTime = DateTime.Now;
                order.MasterID = PublicState.Master.ID;
                order.MasterName = PublicState.Master.Name;
                order.ShopID = PublicState.Master.ShopID;
                order.ShopName = PublicState.Master.ShopName;
                memInfo = new VipSoft.Model.MemCard();
            }
            else
            {
                OrderPayType payType = radioButton_Point1.Checked ? OrderPayType.CardPay : OrderPayType.CashPay;
                order = new Model.OrderLog();
                order.OrderCode = orderCode;
                order.OrderType = 3;
                order.MemID = memInfo.ID;
                order.CardID = memInfo.CardID;
                order.MemName = memInfo.Name;
                order.PayType=(int)payType;
                order.TotalNumber = 0;
                order.TotalMoney = totlemoney;
                order.DisCountMoney = money;
                order.PayInfo = payInfo;
                order.Point = point;
                order.CreateDateTime = DateTime.Now;
                order.MasterID = PublicState.Master.ID;
                order.MasterName = PublicState.Master.Name;
                order.ShopID = PublicState.Master.ShopID;
                order.ShopName = PublicState.Master.ShopName;
            }

            if (bllOrderLog.Add(order) > 0)
            {
                if (!isTravelerMember)
                {
                    memInfo.Point += point;
                    if (radioButton_Point1.Checked)
                    {
                        memInfo.Money -= money;
                    }
                    memInfo.TotalMoney += money;
                    memInfo.LastTime = DateTime.Now;
                    bllMemCard.Update(memInfo);


                    if (point >= 0)
                    {
                        VipSoft.Model.PointLog modelPointLog = new Model.PointLog();
                        modelPointLog.CardID = memInfo.CardID;
                        modelPointLog.MemName = memInfo.Name;
                        modelPointLog.Point = point;
                        modelPointLog.Type = (int)PointLogType.OrderPoint;
                        modelPointLog.CreateDateTime = DateTime.Now;
                        modelPointLog.ShopID = PublicState.Master.ID;
                        modelPointLog.ShopName = PublicState.Master.Name;
                        bllPointLog.Add(modelPointLog);
                    }
                }

                this.TextBox_PointMoney2.Text = "";
                this.TextBox_PointPoint.Text = "";
                this.TextBox_PointMoney1.Text = "";
                this.txt_Beizhu.Text = "";

                // 记录日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                if (!isTravelerMember)
                {
                    log.Add(new VipSoft.Model.SysLog(PublicState.Master, "消费累计积分", "会员编号：" + memInfo.CardID + "消费" + money + "元，累计" + point + "点积分", DateTime.Now));
                    memInfo = bllMemCard.GetModel(memInfo.ID);
                    Function.UpdateMemberLevel(1, memInfo);
                }

                MessageBox.Show("操作成功。");

                ClearFormText();
            }
            else
            {
                MessageBox.Show("系统错误导致消费失败，请重试。");
            }
        }

        private void Button_PointClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_PointMoney1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "TextBox_PointMoney1":
                    if (memInfo != null)
                    {
                        string textM1 = this.TextBox_PointMoney1.Text.Replace("￥", "");
                        decimal money1 = decimal.Parse(textM1 != "" ? textM1 : "0");

                        if (isTravelerMember)
                        {
                            this.TextBox_PointMoney2.Text = decimal.Parse((money1).ToString()).ToString("￥0.00");
                        }
                        else
                        {
                            this.TextBox_PointMoney2.Text = decimal.Parse((money1 * Function.LevelIDToPercent((int)memInfo.LevelID)).ToString()).ToString("￥0.00");
                        }

                    }
                    else
                        this.TextBox_PointMoney2.Text = this.TextBox_PointMoney1.Text;
                    break;
                case "TextBox_PointMoney2":
                    if (memInfo != null)
                    {
                        string textM2 = this.TextBox_PointMoney2.Text.Replace("￥", "");
                        decimal money2 = decimal.Parse(textM2 != "" ? textM2 : "0");



                        if (isTravelerMember)   //散客消费
                        {
                            this.TextBox_PointPoint.Text = "0";
                        }
                        else
                        {
                            if (Function.LevelIDToPoint((int)memInfo.LevelID) == 0)  //不需要积分的
                            {
                                this.TextBox_PointPoint.Text = "0";
                            }
                            else
                            {
                                decimal point2 = Function.LevelIDToPoint((int)memInfo.LevelID) != 0 ? Math.Floor(money2 / Function.LevelIDToPoint((int)memInfo.LevelID)) : 0;
                                this.TextBox_PointPoint.Text = point2.ToString();
                            }

                        }
                    }
                    else
                        this.TextBox_PointPoint.Text = "0";
                    break;
            }
        }

        private void TextBox_PointMoney2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "TextBox_PointMoney1":
                    if (memInfo != null)
                    {
                        string textM1 = this.TextBox_PointMoney1.Text.Replace("￥", "");
                        decimal money1 = decimal.Parse(textM1 != "" ? textM1 : "0");

                        if (isTravelerMember)
                        {
                            this.TextBox_PointMoney2.Text = decimal.Parse((money1).ToString()).ToString("￥0.00");
                        }
                        else
                        {
                            this.TextBox_PointMoney2.Text = decimal.Parse((money1 * Function.LevelIDToPercent((int)memInfo.LevelID)).ToString()).ToString("￥0.00");
                        }

                    }
                    else
                        this.TextBox_PointMoney2.Text = this.TextBox_PointMoney1.Text;
                    break;
                case "TextBox_PointMoney2":
                    if (memInfo != null)
                    {
                        string textM2 = this.TextBox_PointMoney2.Text.Replace("￥", "");
                        decimal money2 = decimal.Parse(textM2 != "" ? textM2 : "0");



                        if (isTravelerMember)   //散客消费
                        {
                            this.TextBox_PointPoint.Text = "0";
                        }
                        else
                        {
                            if (Function.LevelIDToPoint((int)memInfo.LevelID) == 0)  //不需要积分的
                            {
                                this.TextBox_PointPoint.Text = "0";
                            }
                            else
                            {
                                decimal point2 = Function.LevelIDToPoint((int)memInfo.LevelID) != 0 ? Math.Floor(money2 / Function.LevelIDToPoint((int)memInfo.LevelID)) : 0;
                                this.TextBox_PointPoint.Text = point2.ToString();
                            }

                        }
                    }
                    else
                        this.TextBox_PointPoint.Text = "0";
                    break;
            }
        }
    }
}
