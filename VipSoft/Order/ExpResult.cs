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
    public delegate void ExpenseResultSelectedHandlers(OrderPayType ExpType, decimal PayMoney, decimal PayCard, decimal PayCash, decimal PayCredit, decimal PayVoucher, decimal moneyZero);
    public partial class ExpResult : BaseForm
    {
        public event ExpenseResultSelectedHandlers ExpenseResultSelecteds;
        /// <summary>
        /// 支付方式
        /// </summary>
        private OrderPayType payType;
        /// <summary>
        /// 应付金额
        /// </summary>
        private decimal totalMoney;
        /// <summary>
        /// 是否散客
        /// </summary>
        private bool isTravelerMember;
        decimal _moneyZero = 0;         //找零
        /// <summary>
        /// 当前会员
        /// </summary>
        private VipSoft.Model.MemCard memInfo;
        public List<TempOrderInfo> listOrders = new List<TempOrderInfo>();
        public ExpResult()
        {
            InitializeComponent();
        }

        public ExpResult(decimal _totalMoney, bool _isTravelerMember, VipSoft.Model.MemCard _memInfo)
        {
            totalMoney = _totalMoney;
            isTravelerMember = _isTravelerMember;
            memInfo = _memInfo;

            InitializeComponent();
        }

        public ExpResult(List<TempOrderInfo> list, decimal _totalMoney, bool _isTravelerMember, VipSoft.Model.MemCard _memInfo)
        {
            totalMoney = 0;
            listOrders = list;

            foreach (TempOrderInfo order in listOrders)
            {
                totalMoney += order.DiscountPrice;
            }
            totalMoney = Math.Round(totalMoney, 0, MidpointRounding.AwayFromZero);

            isTravelerMember = _isTravelerMember;
            memInfo = _memInfo;
            InitializeComponent();
        }

        private decimal ToDecimal(string input)
        {
            input = input.Replace("￥", "");
            if (input == "")
                return 0.00M;
            else
            {
                decimal dec;
                if (decimal.TryParse(input, out dec))
                    return dec;
                else
                    return 0.00M;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            decimal tempM = ToDecimal(TB_TotalMoney.Text);
            if (this.radioButton_Card.Checked)
            {
                payType = OrderPayType.CardPay;
                this.panel_Card.Visible = true;
                this.panel_Cash.Visible = false;
                this.panel_Union.Visible = false;

                label_CardMoney_Exp.Text = (memInfo.Money - tempM).ToString("￥0.00");
            }
            else if (this.radioButton_Cash.Checked)
            {
                payType = OrderPayType.CashPay;
                this.panel_Card.Visible = false;
                this.panel_Cash.Visible = true;
                this.panel_Union.Visible = false;
                this.panel_Cash.Location = this.panel_Card.Location;

                label_Change.Text = (ToDecimal(this.textBox_Money.Text) - tempM).ToString("￥0.00");
                this.textBox_Money.Focus();
            }
            else if (this.radioButton_Credit.Checked)
            {
                payType = OrderPayType.CreditPay;
                this.panel_Card.Visible = false;
                this.panel_Cash.Visible = true;
                this.panel_Union.Visible = false;
                this.panel_Cash.Location = this.panel_Card.Location;

                label_Change.Text = (ToDecimal(this.textBox_Money.Text) - tempM).ToString("￥0.00");
            }
            else if (this.radioButton_Voucher.Checked)
            {
                payType = OrderPayType.VoucherPay;
                this.panel_Card.Visible = false;
                this.panel_Cash.Visible = true;
                this.panel_Union.Visible = false;
                this.panel_Cash.Location = this.panel_Card.Location;

                label_Change.Text = (ToDecimal(this.textBox_Money.Text) - tempM).ToString("￥0.00");
            }
            else
            {
                payType = OrderPayType.UnionPay;
                this.panel_Card.Visible = false;
                this.panel_Cash.Visible = false;
                this.panel_Union.Visible = true;
                this.panel_Union.Location = this.panel_Card.Location;

                // 计算找零
                textBox_Money_Union_TextChanged(this.textBox_Money_Card, null);
            }
        }

        // 联合支付金额改变时，计算联合支付找零金额
        private void textBox_Money_Union_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal dec;
            if (decimal.TryParse(tb.Text.Replace("￥", ""), out dec))
            {
                decimal payTotal = ToDecimal(this.textBox_Money_Card.Text.Replace("￥", "")) +
                    ToDecimal(this.textBox_Money_Cash.Text.Replace("￥", "")) + ToDecimal(this.textBox_Money_Credit.Text.Replace("￥", "")) +
                    ToDecimal(this.textBox_Money_Voucher.Text.Replace("￥", ""));
                this.label_ChangeUnion.Text = "￥" + (payTotal - ToDecimal(this.TB_TotalMoney.Text)).ToString("0.00");
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_TotalMoney_TextChanged(object sender, EventArgs e)
        {
            decimal dec;
            if (decimal.TryParse(this.textBox_Money.Text.Replace("￥", ""), out dec))
            {
                this.label_Change.Text = "￥" + (dec - ToDecimal(this.TB_TotalMoney.Text.Replace("￥", ""))).ToString("0.00");
            }
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            // 商户修改过后的应付金额
            decimal payMoney = ToDecimal(this.TB_TotalMoney.Text);
            if (payMoney.ToString("0.00") != totalMoney.ToString("0.00"))
            {
                if (MessageBox.Show("你确定要将支付金额改为：" + payMoney.ToString("￥0.00") + " 并完成支付么？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    this.TB_TotalMoney.Focus();
                    this.TB_TotalMoney.SelectAll();
                    return;
                }
            }

            // 检测支付是否完成
            if (payType == OrderPayType.CardPay && payMoney > memInfo.Money)
            {
                MessageBox.Show("当前卡内余额不足，请选择其他的支付结算方式。");
                return;
            }
            if ((payType == OrderPayType.CashPay || payType == OrderPayType.CreditPay || payType == OrderPayType.VoucherPay)
                && ToDecimal(this.textBox_Money.Text) < payMoney)
            {
                MessageBox.Show("支付金额未达到所需付款金额。");
                this.textBox_Money.Focus();
                this.textBox_Money.SelectAll();
                return;
            }
            if (payType == OrderPayType.UnionPay)
            {
                decimal payTotal = ToDecimal(this.textBox_Money_Card.Text) +
                        ToDecimal(this.textBox_Money_Cash.Text) + ToDecimal(this.textBox_Money_Credit.Text) +
                        ToDecimal(this.textBox_Money_Voucher.Text);
                if (payTotal < payMoney)
                {
                    MessageBox.Show("联合支付金额总量不足。");
                    this.textBox_Money_Cash.Focus();
                    this.textBox_Money_Cash.SelectAll();
                    return;
                }
                else if (ToDecimal(this.textBox_Money_Card.Text) > ToDecimal(this.label1_CardMoney2.Text))
                {
                    MessageBox.Show("储值卡余额不足以完成支付。");
                    this.textBox_Money_Card.Focus();
                    this.textBox_Money_Card.SelectAll();
                    return;
                }
            }

            // 计算各类支付方式的付款金额
            // 当现金支付金额为负数时表示：实际支付需50元，使用代金券支付了80元，此时找零30，计算出来的现金支付金额则为-30元。
            decimal paycard = 0M, paycash = 0M, paycredit = 0M, payvoucher = 0M;
            if (payType == OrderPayType.CardPay)
                paycard = payMoney;
            else if (payType == OrderPayType.CashPay)
                paycash = ToDecimal(this.textBox_Money.Text) - ToDecimal(this.label_Change.Text);
            else if (payType == OrderPayType.CreditPay)
            {
                paycredit = ToDecimal(this.textBox_Money.Text);
                paycash = ToDecimal(this.label_Change.Text) * -1;
            }
            else if (payType == OrderPayType.VoucherPay)
            {
                payvoucher = ToDecimal(this.textBox_Money.Text);
                paycash = ToDecimal(this.label_Change.Text) * -1;
            }
            else if (payType == OrderPayType.UnionPay)
            {
                paycard = ToDecimal(this.textBox_Money_Card.Text);
                paycash = ToDecimal(this.textBox_Money_Cash.Text) - ToDecimal(this.label_ChangeUnion.Text);
                paycredit = ToDecimal(this.textBox_Money_Credit.Text);
                payvoucher = ToDecimal(this.textBox_Money_Voucher.Text);
            }

            //找零金额 （顾显需要显示这个找零金额）
            if (this.radioButton_Card.Checked)               //余额
            {
                _moneyZero = 0;
            }
            else if (this.radioButton_Cash.Checked || this.radioButton_Credit.Checked || this.radioButton_Voucher.Checked)          //现金
            {
                _moneyZero = decimal.Parse(this.label_Change.Text.Replace("￥", ""));
            }
            else if (this.radioButton_Union.Checked)        //联合
            {
                _moneyZero = decimal.Parse(this.label_ChangeUnion.Text.Replace("￥", ""));
            }

            if (ExpenseResultSelecteds != null)
            {
                ExpenseResultSelecteds(payType, payMoney, paycard, paycash, paycredit, payvoucher, _moneyZero);
            }

            this.Close();
        }

        private void ExpResult_Load(object sender, EventArgs e)
        {
            this.TB_TotalMoney.Text = totalMoney.ToString("￥0.00");
            if (!isTravelerMember)
            {
                this.label_CardMoney.Text = memInfo.Money.ToString("￥0.00");
                this.label_CardMoney_Exp.Text = "￥" + (memInfo.Money - totalMoney).ToString("0.00");
                this.label1_CardMoney2.Text = memInfo.Money.ToString("￥0.00");
                this.radioButton_Card.Checked = true;
                this.textBox_Money.Text = totalMoney.ToString("￥0.00");
                this.label_Change.Text = "￥0.00";
                this.label_ChangeUnion.Text = "￥0.00";
                this.button_Result.Focus();
                this.button_Result.Select();
            }
            else
            {
                this.radioButton_Cash.Checked = true;
                this.radioButton_Card.Enabled = false;
                this.textBox_Money_Card.Enabled = false;
                this.label1_CardMoney2.Text = "￥0.00";
                this.textBox_Money.Text = totalMoney.ToString("￥0.00");
                this.label_Change.Text = "￥0.00";
                this.label_ChangeUnion.Text = "￥0.00";
                this.textBox_Money.Focus();
                this.textBox_Money.Select();
            }
        }
    }
}
