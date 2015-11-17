using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace VipSoft
{
    public partial class OrderReport : BaseForm
    {
        public OrderReport()
        {
            InitializeComponent();
        }

        private void OrderReport_Load(object sender, EventArgs e)
        {
            this.comboBox_PayType.Items.Add(new DictionaryEntry("所有类型", ""));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("储值卡余额消费", "1"));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("现金消费", "2"));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("信用卡支付", "3"));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("代金券支付", "4"));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("联合支付", "5"));
            this.comboBox_PayType.DisplayMember = "Key";
            this.comboBox_PayType.ValueMember = "Value";
            this.comboBox_G_PayType.Items.Add(new DictionaryEntry("所有类型", ""));
            this.comboBox_G_PayType.Items.Add(new DictionaryEntry("储值卡余额消费", "1"));
            this.comboBox_G_PayType.Items.Add(new DictionaryEntry("现金消费", "2"));
            this.comboBox_G_PayType.Items.Add(new DictionaryEntry("联合消费", "3"));
            this.comboBox_G_PayType.DisplayMember = "Key";
            this.comboBox_G_PayType.ValueMember = "Value";

            // 会员等级
            DataTable dtLevel = new VipSoft.BLL.CardLevel().GetAllList().Tables[0];
            this.comboBox_CardLevel.Items.Add(new DictionaryEntry("所有等级", "0"));
            foreach (DataRow dr in dtLevel.Rows)
                this.comboBox_CardLevel.Items.Add(new DictionaryEntry(dr["LevelName"].ToString(), dr["ID"].ToString()));
            this.comboBox_CardLevel.DisplayMember = "Key";
            this.comboBox_CardLevel.ValueMember = "Value";

            this.comboBox_B_CardLevel.Items.Add(new DictionaryEntry("所有等级", "0"));
            foreach (DataRow dr in dtLevel.Rows)
                this.comboBox_B_CardLevel.Items.Add(new DictionaryEntry(dr["LevelName"].ToString(), dr["ID"].ToString()));
            this.comboBox_B_CardLevel.DisplayMember = "Key";
            this.comboBox_B_CardLevel.ValueMember = "Value";

            this.comboBox_P_CardLevel.Items.Add(new DictionaryEntry("所有等级", "0"));
            foreach (DataRow dr in dtLevel.Rows)
                this.comboBox_P_CardLevel.Items.Add(new DictionaryEntry(dr["LevelName"].ToString(), dr["ID"].ToString()));
            this.comboBox_P_CardLevel.DisplayMember = "Key";

            this.comboBox_P_CardLevel.ValueMember = "Value";

            DataTable dtClass;
            // 产品分类
            dtClass = new VipSoft.BLL.GoodsClass().GetList("ShopID="+PublicState.Master.ShopID).Tables[0];
            Function.BindGoodsClass(this.comboBox_G_Class, dtClass);
            Function.BindGoodsClass(this.comboBox_M_Class, dtClass);
            DataTable dt = (DataTable)this.comboBox_G_Class.DataSource;
            this.comboBox_G_Class.DataSource = dt;
            this.comboBox_M_Class.DataSource = dt;

            this.comboBox_Sign.SelectedIndex = 0;
            this.comboBox_B_Sign.SelectedIndex = 0;
            this.comboBox_OrderType.SelectedIndex = 0;
            this.comboBox_PayType.SelectedIndex = 0;
            this.comboBox_G_Sign.SelectedIndex = 0;
            this.comboBox_G_OrderType.SelectedIndex = 0;
            this.comboBox_G_PayType.SelectedIndex = 0;
            this.comboBox_G_Class.SelectedIndex = 0;
            this.comboBox_M_Sign.SelectedIndex = 0;
            this.comboBox_M_OrderType.SelectedIndex = 0;
            this.comboBox_M_Class.SelectedIndex = 0;
            this.comboBox_P_Sign.SelectedIndex = 0;

            this.dateTimePicker_Start.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_End.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_G_Start.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_G_End.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_M_Start.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_M_End.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_B_Start.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_P_Start.Text = DateTime.Now.ToShortDateString();
            this.dateTimePicker_P_End.Text = DateTime.Now.ToShortDateString();

            this.maskedTextBox_B_Start.Text = "00:00:00";
            this.maskedTextBox_P_Start.Text = "00:00:00";
            this.maskedTextBox_P_End.Text = "00:00:00";
            this.maskedTextBox_B_End.Text = "23:59:59";
            this.maskedTextBox_End.Text = "23:59:59";
            this.maskedTextBox_G_Start.Text = "00:00:00";
            this.maskedTextBox_G_End.Text = "23:59:59";
            this.maskedTextBox_M_Start.Text = "00:00:00";
            this.maskedTextBox_M_End.Text = "23:59:59";
            this.maskedTextBox5.Text = "00:00:00";
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.dateTimePicker_Start.Checked)
            {
                DateTime time1;
                string t1 = this.dateTimePicker_Start.Value.ToShortDateString() + " " + this.maskedTextBox5.Text;
                if (!DateTime.TryParse(t1, out time1))
                {       
                    MessageBox.Show("开始时间输入错误！");
                    return;
                }

                sb.Append(" and OrderLog.CreateDateTime>='" + t1 + "'");
            }
            if (this.dateTimePicker_End.Checked)
            {
                DateTime time2;
                string t2 = this.dateTimePicker_End.Value.ToShortDateString() + " " + this.maskedTextBox_End.Text;
                if (!DateTime.TryParse(t2, out time2))
                {
                    MessageBox.Show("结束时间输入错误！");
                    return;
                }
                sb.Append(" and OrderLog.CreateDateTime<='" + t2 + "'");
            }

            sb.Append(" and OrderLog.OrderType=0");

            if (this.comboBox_CardLevel.SelectedIndex != -1 && this.comboBox_CardLevel.SelectedIndex != 0)
            {
                int level = int.Parse(((DictionaryEntry)this.comboBox_CardLevel.SelectedItem).Value.ToString());
                string ids = new VipSoft.BLL.MemCard().GetMemIDs(level);
            }

            if (this.searchMember1.CardID != "")
            {
                searchMember1.GetSearchMember();
                sb.Append(" and OrderLog.MemID=" + this.searchMember1.MemID);
            }

            if (this.textBox_Money.Text != "￥0.00" && this.textBox_Money.Text != "")
                sb.Append(" and OrderLog.DiscountMoney" + this.comboBox_Sign.Text + this.textBox_Money.Text.Replace("￥", ""));

            if (this.TextBox_OrderCode.Text != "")
                sb.Append(" and orderLog.OrderCode='" + this.TextBox_OrderCode.Text + "'");

            decimal totalmoney = 0;
            decimal totalNumber = 0;
            DataTable dt = new VipSoft.BLL.OrderLog().GetOrderGoodsList(sb.ToString()).Tables[0];

            if (dt.Rows.Count > 0)
            {
                this.loading.Visible = false;
            }
            else
            {
                this.loading.Visible = true;
            }

            foreach (DataRow dr in dt.Rows)
            {
                totalmoney += Math.Round(decimal.Parse(dr["DiscountMoney"].ToString()), 2);
                totalNumber += decimal.Parse(dr["TotalNumber"].ToString());

                this.dgvSellWater.Rows.Add(dr["OrderCode"], dr["CardID"], dr["MemName"], dr["DiscountMoney"], dr["CreateDateTime"], Function.GetPayTypeName(int.Parse(dr["PayType"].ToString())), dr["OrderType"].ToString() == "0" ? "储值消费" : (dr["OrderType"].ToString() == "1" ? "记次消费" : (dr["OrderType"].ToString() == "2" ? "退货" : "累计积分")), dr["Remark"]);
            }

            this.lbl_summoney.Text = totalmoney.ToString("#0.00");
            this.label66.Text = totalNumber.ToString();
        }

        private void dgvSellWater_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvCollect.Rows.Clear();
            if (this.dgvSellWater.SelectedRows.Count == 0)
                return;
            string orderCode = this.dgvSellWater.SelectedRows[0].Cells[0].Value.ToString();
            //汇总表
            DataSet ds = new VipSoft.BLL.OrderDetail().GetListCollect("SELECT GoodsCode,GoodsName,price,Number as numbers,DiscountPrice as sumMoneys from orderLog  left join orderDetail on orderLog.orderCode=orderDetail.orderCode where  orderDetail.orderCode='" + orderCode + "'  ");
            foreach (DataRow drt in ds.Tables[0].Rows)
            {
                this.dgvCollect.Rows.Add(drt["GoodsCode"], drt["GoodsName"], drt["price"], drt["numbers"], drt["sumMoneys"]);
            }
        }
    }
}
