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

            this.dgvSellWater.Rows.Clear();
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

        private void btn_P_Query_Click(object sender, EventArgs e)
        {
            this.dgvPointList.Rows.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.dateTimePicker_P_Start.Checked)
            {
                DateTime time1;
                string t1 = this.dateTimePicker_P_Start.Value.ToShortDateString() + " " + this.maskedTextBox_P_Start.Text;
                if (!DateTime.TryParse(t1, out time1))
                {
                    MessageBox.Show("开始时间输入错误！");
                    return;
                }
                sb.Append(" and OrderLog.CreateDateTime >= '" + time1.ToString() + "'");
            }

            if (this.dateTimePicker_P_End.Checked)
            {
                DateTime time2;
                string t2 = this.dateTimePicker_P_End.Value.ToShortDateString() + " " + this.maskedTextBox_P_End.Text;
                if (!DateTime.TryParse(t2, out time2))
                {
                    MessageBox.Show("结束时间输入错误！");
                    return;
                }
                sb.Append(" and OrderLog.CreateDateTime <= '" + time2.ToString() + "'");
            }

            sb.Append(" and OrderLog.OrderType=3");

            if (this.comboBox_P_CardLevel.SelectedIndex != -1 && this.comboBox_P_CardLevel.SelectedIndex != 0)
            {
                int level = int.Parse(((DictionaryEntry)this.comboBox_P_CardLevel.SelectedItem).Value.ToString());
                string ids = new VipSoft.BLL.MemCard().GetMemIDs(level);

                if (ids != "")
                    sb.Append("OrderLog.MemID in (" + ids + ")");
                else
                {
                    sb.Append(" and OrderLog.MemID in (-1)");
                }
            }

            if (this.searchMember2.CardID != "")
            {
                searchMember2.GetSearchMember();
                sb.Append(" OrderLog.MemID=" + this.searchMember2.MemID);
            }

            if (this.textBox_P_Money.Text != "￥0.00" && this.textBox_P_Money.Text != "")
                sb.Append(" OrderLog.DiscountMoney" + this.comboBox_P_Sign.Text + this.textBox_P_Money.Text.Replace("￥", ""));
            if (this.TextBox_P_OrderCode.Text != "")
                sb.Append(" OrderLog.OrderCode='" + this.TextBox_P_OrderCode.Text + "'");
            if (this.txtRemark.Text != "")
                sb.Append(" OrderLog.Remark like '%" + this.txtRemark.Text + "%'");

            decimal pmoney = 0;
            int point = 0;
            DataSet ds = new VipSoft.BLL.OrderLog().GetOrderPointList(sb.ToString());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                pmoney += Math.Round(decimal.Parse(dr["DiscountMoney"].ToString()), 2);
                point += int.Parse(dr["Point"].ToString());
                this.dgvPointList.Rows.Add(dr["OrderCode"], dr["CardID"], dr["MemName"], dr["DiscountMoney"], dr["Point"], dr["CreateDateTime"], Function.GetPayTypeName(int.Parse(dr["PayType"].ToString())), dr["Remark"]);
            }
            this.lbl_pnum.Text = point.ToString();
            this.lbl_p.Text = pmoney.ToString("#0.00");
        }

        private void Button_G_Query_Click(object sender, EventArgs e)
        {
            this.dgvGCollect.Rows.Clear();
            this.dgvGWater.Rows.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.dateTimePicker_G_Start.Checked)
            {
                DateTime time1;
                string t1 = this.dateTimePicker_G_Start.Value.ToShortDateString() + " " + this.maskedTextBox_G_Start.Text;
                if (!DateTime.TryParse(t1, out time1))
                {
                    MessageBox.Show("开始时间输入错误！");
                    this.maskedTextBox_G_Start.Text = "00:00:00";
                    t1 = this.dateTimePicker_G_Start.Value.ToShortDateString() + " " + "00:00:00";
                    DateTime.TryParse(t1, out time1);
                }
                sb.Append(" a.CreateDateTime >= '" + time1.ToString() + "'");
            }

            if (this.dateTimePicker_G_End.Checked)
            {
                DateTime time2;
                string t2 = this.dateTimePicker_G_End.Value.ToShortDateString() + " " + this.maskedTextBox_G_End.Text;
                if (!DateTime.TryParse(t2, out time2))
                {
                    MessageBox.Show("结束时间输入错误！");
                    this.maskedTextBox_G_End.Text = "23:59:59";
                    t2 = this.dateTimePicker_G_End.Value.ToShortDateString() + " " + "23:59:59";
                    DateTime.TryParse(t2, out time2);
                }
                sb.Append(" a.CreateDateTime <= '" + time2.ToString() + "'");
            }

            string type;
            if (this.comboBox_G_OrderType.SelectedIndex == 1)
            {
                sb.Append(" and a.OrderType=0");// 余额消费
                if (this.comboBox_G_PayType.SelectedIndex != -1 && this.comboBox_G_PayType.SelectedIndex != 0)
                {
                    type = ((DictionaryEntry)this.comboBox_G_PayType.SelectedItem).Value.ToString();
                    sb.Append(" and a.PayType=" + type);
                }
            }
            else if (this.comboBox_G_OrderType.SelectedIndex == 2)
                sb.Append(" and a.OrderType=1");// 记次

            if (this.comboBox_G_Class.SelectedIndex != 0)
            {
                string classID = ((DataRowView)this.comboBox_G_Class.SelectedItem)["Value"].ToString();
                DataTable dtClass = new VipSoft.BLL.GoodsClass().GetList("ShopID=" + PublicState.Master.ShopID).Tables[0];
                string ids = Function.GetChildClassListStr(dtClass, classID);
                if (ids != "")
                    sb.Append(" b.ID in (select ID from Goods where ClassID in (" + ids + "))");
                else
                    sb.Append(" b.ID in (select ID from Goods where ClassID = " + classID + ")");
            }
            if (this.TextBox_G_Key.Text != "")
                sb.Append(" a.GoodsCode='" + this.TextBox_G_Key.Text + "' or a.GoodsName like '%" + this.TextBox_G_Key.Text + "%'");
            if (this.textBox_G_Price.Text != "￥0.00" && this.textBox_G_Price.Text != "")
                sb.Append(" a.Price" + this.comboBox_G_Sign.Text + this.textBox_G_Price.Text.Replace("￥", ""));

            if (this.searchMember3.CardID != "")
            {
                searchMember3.GetSearchMember();
                sb.Append("MemID=" + this.searchMember3.MemID);
            }

            decimal gmoney = 0M;
            decimal danprice = 0M;
            decimal jinhuoprice = 0M;
            int xinums = 0;
            decimal lirun = 0M;
            decimal Zprice = 0M;
            decimal Cprice = 0M;
            int SumN = 0;
            //汇总表
            DataSet ds = new VipSoft.BLL.OrderDetail().GetListCollect("SELECT a.GoodsCode,a.GoodsName,a.price,sum(a.Number) as numbers,sum(DiscountPrice) as sumMoneys,b.buyprice,(sum(b.price*a.Number)-sum(b.buyprice*a.Number)) as buyprices from (select orderDetail.GoodsCode,orderDetail.GoodsName,orderDetail.price,orderDetail.Number,OrderLog.PayType,OrderLog.MemID,OrderLog.CreateDateTime,OrderLog.OrderType,orderDetail.DiscountPrice from orderLog  left join orderDetail on orderLog.orderCode=orderDetail.orderCode ) as a  left join goods as b on b.goodscode=a.goodscode where  " + sb.ToString() + " and a.OrderType not in (2,3,8) group by  a.goodsCode,a.goodsName,a.price,b.buyprice");
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.lbl_G_Loading.Visible = false;
            }
            else
            {
                this.lbl_G_Loading.Visible = true;
            }

            foreach (DataRow drt in ds.Tables[0].Rows)
            {
                gmoney += Math.Round(decimal.Parse(drt["sumMoneys"].ToString()), 2);
                danprice = Math.Round(decimal.Parse(drt["price"].ToString()), 2);
                jinhuoprice = Math.Round(decimal.Parse(drt["buyprice"].ToString()), 2);
                xinums = int.Parse(drt["Numbers"].ToString());
                SumN += int.Parse(drt["Numbers"].ToString());
                Zprice += xinums * danprice;
                Cprice += xinums * jinhuoprice;
                lirun += Math.Round(decimal.Parse(drt["buyprices"].ToString()), 2);
                try
                {
                    decimal sumMoney = Convert.ToDecimal(drt["price"].ToString()) * int.Parse(drt["numbers"].ToString());
                    if (sumMoney != 0)
                        this.dgvGCollect.Rows.Add(drt["GoodsCode"], drt["GoodsName"], drt["price"], drt["buyprice"], drt["numbers"], drt["sumMoneys"], Convert.ToDecimal(drt["buyprices"].ToString()), (Convert.ToDecimal(drt["buyprices"].ToString()) / sumMoney * 100).ToString("0.00") + "%");
                    else
                        this.dgvGCollect.Rows.Add(drt["GoodsCode"], drt["GoodsName"], drt["price"], drt["buyprice"], drt["numbers"], drt["sumMoneys"], Convert.ToDecimal(drt["buyprices"].ToString()), "0");
                }
                catch
                {

                }
            }

            lirun = (Zprice - Cprice);
            this.lbl_g.Text = gmoney.ToString("￥0.00");
            this.lbl_danprice.Text = Zprice.ToString("￥0.00");
            this.lbl_jinprice.Text = Cprice.ToString("￥0.00");
            this.lbl_lirun.Text = lirun.ToString("￥0.00");
            this.lbl_xnum.Text = SumN.ToString();
        }

        private void dgvGCollect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvGWater.Rows.Clear();
            if (this.dgvGCollect.SelectedRows.Count == 0)
                return;
            string goodsCode = this.dgvGCollect.SelectedRows[0].Cells[0].Value.ToString();
            DataSet dt = null;
            StringBuilder sb = new StringBuilder();
            if (this.dateTimePicker_G_Start.Checked)
            {
                DateTime time1;
                string t1 = this.dateTimePicker_G_Start.Value.ToShortDateString() + " " + this.maskedTextBox_G_Start.Text;
                if (!DateTime.TryParse(t1, out time1))
                {
                    MessageBox.Show("开始时间输入错误！");
                    return;
                }
                sb.Append(" a.CreateDateTime >= '" + time1.ToString() + "'");
            }

            if (this.dateTimePicker_G_End.Checked)
            {
                DateTime time2;
                string t2 = this.dateTimePicker_G_End.Value.ToShortDateString() + " " + this.maskedTextBox_G_End.Text;
                if (!DateTime.TryParse(t2, out time2))
                {
                    MessageBox.Show("结束时间输入错误！");
                    return;
                }
                sb.Append(" a.CreateDateTime <= '" + time2.ToString() + "'");
            }

            string type;
            if (this.comboBox_G_OrderType.SelectedIndex == 1)
            {
                sb.Append(" and a.OrderType=0");// 余额消费
                if (this.comboBox_G_PayType.SelectedIndex != -1 && this.comboBox_G_PayType.SelectedIndex != 0)
                {
                    type = ((DictionaryEntry)this.comboBox_G_PayType.SelectedItem).Value.ToString();
                    sb.Append(" and a.PayType=" + type);
                }
            }
            else if (this.comboBox_G_OrderType.SelectedIndex == 2)
                sb.Append(" and a.OrderType=1");// 记次
            else if (this.comboBox_G_OrderType.SelectedIndex == 3)
                sb.Append(" and a.OrderType=2");// 退货


            DataTable dtClass = new VipSoft.BLL.GoodsClass().GetList("ShopID=" + PublicState.Master.ShopID).Tables[0];
            if (this.comboBox_G_Class.SelectedIndex != 0)
            {
                string classID = ((DataRowView)this.comboBox_G_Class.SelectedItem)["Value"].ToString();
                string ids = Function.GetChildClassListStr(dtClass, classID);
                if (ids != "")
                    sb.Append(" b.GoodsID in (select ID from Goods where ClassID in (" + ids + "))");
                else
                    sb.Append(" b.GoodsID in (select ID from Goods where ClassID = " + classID + ")");
            }

            if (this.TextBox_G_Key.Text != "")
                sb.Append(" b.GoodsCode='" + this.TextBox_G_Key.Text + "' or b.GoodsName like '%" + this.TextBox_G_Key.Text + "%'");
            if (this.textBox_G_Price.Text != "￥0.00" && this.textBox_G_Price.Text != "")
                sb.Append(" b.Price" + this.comboBox_G_Sign.Text + this.textBox_G_Price.Text.Replace("￥", ""));
            if (this.searchMember4.CardID != "")
            {
                searchMember4.GetSearchMember();
                sb.Append("MemID=" + this.searchMember4.MemID);
            }

            if (sb.ToString() != "")
            {
                dt = new VipSoft.BLL.OrderLog().GetListCollect("SELECT a.OrderCode,a.CardID,a.MemName,b.Number,b.DiscountPrice,a.DiscountMoney,a.OrderType,a.CreateTime,b.GoodsCode ,b.GoodsName,b.GoodsID,b.OrderCode from OrderLog as a  left join OrderDetail as b on a.OrderCode=b.OrderCode  where  " + sb.ToString() + " and b.GoodsCode='" + goodsCode + "' and a.OrderType not in (2,3,8)");
            }
            else
            {
                dt = new VipSoft.BLL.OrderLog().GetListCollect("SELECT a.OrderCode,a.CardID,a.MemName,b.Number,b.DiscountPrice,a.DiscountMoney,a.OrderType,a.CreateTime ,a.GoodsCode,a.GoodsName,b.GoodsCode,b.OrderCode from OrderLog as a  left join OrderDetail as b on a.GoodsCode=b.GoodsCode  where  " + sb.ToString() + "  b.GoodsCode='" + goodsCode + "' and a.OrderType not in (2,3,8)");
            }
            // todo   ddddddsssssss
            foreach (DataRow dr in dt.Tables[0].Rows)
            {
                this.dgvGWater.Rows.Add(dr["a.OrderCode"], dr["CardID"], dr["MemName"], dr["Number"], dr["DiscountPrice"], dr["DiscountMoney"], dr["OrderType"].ToString() == "0" ? "储值消费" : (dr["OrderType"].ToString() == "1" ? "记次消费" : (dr["OrderType"].ToString() == "2" ? "退货" : "累计积分")), dr["CreateTime"]);
            }

        }

        private void btnBlackQuery_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.dateTimePicker_B_Start.Checked)
            {
                DateTime time1;
                string t1 = this.dateTimePicker_B_Start.Value.ToShortDateString() + " " + this.maskedTextBox_B_Start.Text;
                if (!DateTime.TryParse(t1, out time1))
                {
                    MessageBox.Show("开始时间输入错误！");
                    return;
                }
                sb.Append(" and OrderLog.CreateDateTime >= '" + time1.ToString() + "'");
            }

            if (this.dateTimePicker_B_End.Checked)
            {
                DateTime time2;
                string t2 = this.dateTimePicker_B_End.Value.ToShortDateString() + " " + this.maskedTextBox_B_End.Text;
                if (!DateTime.TryParse(t2, out time2))
                {
                    MessageBox.Show("结束时间输入错误！");
                    return;
                }
                sb.Append(" and OrderLog.CreateDateTime <= '" + time2.ToString() + "'");
            }

            sb.Append(" and OrderLog.OrderType=2") ;//
            if (this.comboBox_B_CardLevel.SelectedIndex != -1 && this.comboBox_B_CardLevel.SelectedIndex != 0)
            {
                int level = int.Parse(((DictionaryEntry)this.comboBox_B_CardLevel.SelectedItem).Value.ToString());
                string ids = new VipSoft.BLL.MemCard().GetMemIDs(level);
                if (ids != "")
                    sb.Append(" and OrderLog.MemID in (" + ids + ")");
                else
                {
                    sb.Append( " and MemID in (-1)");
                }
            }
            if (this.searchMember5.CardID != "")
            {
                searchMember5.GetSearchMember();
                sb.Append(" and OrderLog.MemID=" + this.searchMember5.MemID);
            }

            if (this.textBox_B_Money.Text != "￥0.00" && this.textBox_B_Money.Text != "")
                sb.Append(" and  abs(OrderLog.DiscountMoney)" + this.comboBox_B_Sign.Text + this.textBox_B_Money.Text.Replace("￥", ""));
            if (this.TextBox_B_OrderCode.Text != "")
                sb.Append(" and OrderLog.OrderCode='" + this.TextBox_B_OrderCode.Text + "'");

            this.dgvBlackWater.Rows.Clear();
            this.dgvBlackCollect.Rows.Clear();


            decimal balckMoney = 0;    //退货总金额
            decimal balckNumber = 0;   //退货总数量
            ////流水表
            DataTable dt = new VipSoft.BLL.OrderLog().GetOrderGoodsList(sb.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                this.load_B_ing.Visible = false;
            }
            else
            {
                this.load_B_ing.Visible = true;
            }

            foreach (DataRow dr in dt.Rows)
            {
                balckMoney += Math.Round(decimal.Parse(dr["DiscountMoney"].ToString()), 2);
                balckNumber += decimal.Parse(dr["TotalNumber"].ToString());

                this.dgvBlackWater.Rows.Add(dr["OrderCode"], dr["CardID"], dr["MemName"], dr["DiscountMoney"], dr["CreateDateTime"]);
            }

            this.label70.Text = balckNumber.ToString();
            this.label68.Text = balckMoney.ToString("￥0.00");
        }

        private void dgvBlackWater_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvBlackCollect.Rows.Clear();
            if (this.dgvBlackWater.SelectedRows.Count == 0)
                return;
            string orderCode = this.dgvBlackWater.SelectedRows[0].Cells[0].Value.ToString();
            //汇总表
            DataSet ds = new VipSoft.BLL.OrderDetail().GetListCollect("SELECT GoodsCode,GoodsName,price,Number as numbers,DiscountPrice as TotalMoney  from orderLog  left join orderDetail on orderLog.orderCode=orderDetail.orderCode where orderDetail.orderCode= '" + orderCode + "'  ");
            foreach (DataRow drt in ds.Tables[0].Rows)
            {
                this.dgvBlackCollect.Rows.Add(drt["GoodsCode"], drt["GoodsName"], drt["price"], drt["numbers"], drt["TotalMoney"]);
            }
        }

        private void Button_M_Query_Click(object sender, EventArgs e)
        {
            this.dgvMWater.Rows.Clear();
            this.dgvMCollect.Rows.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.dateTimePicker_M_Start.Checked)
            {
                DateTime time1;
                string t1 = this.dateTimePicker_M_Start.Value.ToShortDateString() + " " + this.maskedTextBox_M_Start.Text;
                if (!DateTime.TryParse(t1, out time1))
                {
                    MessageBox.Show("开始时间输入错误！");
                    return;
                }
                sb.Append(" and CreateDateTime >= '" + time1.ToString() + "'");
            }

            if (this.dateTimePicker_M_End.Checked)
            {
                DateTime time2;
                string t2 = this.dateTimePicker_M_End.Value.ToShortDateString() + " " + this.maskedTextBox_M_End.Text;
                if (!DateTime.TryParse(t2, out time2))
                {
                    MessageBox.Show("结束时间输入错误！");
                    return;
                }
                sb.Append("CreateDateTime <= '" + time2.ToString() + "'");
            }

            if (this.comboBox_M_OrderType.SelectedIndex == 1)
                sb.Append(" and OrderType=0");// 余额消费
            else if (this.comboBox_M_OrderType.SelectedIndex == 2)
                sb.Append(" and OrderType=1");// 记次

            if (this.comboBox_M_Class.SelectedIndex != 0)
            {
                string classID = ((DataRowView)this.comboBox_M_Class.SelectedItem)["Value"].ToString();
                DataTable dtClass = new VipSoft.BLL.GoodsClass().GetList("ShopID=" + PublicState.Master.ShopID).Tables[0];
                string ids = Function.GetChildClassListStr(dtClass, classID);
                if (ids != "")
                    sb.Append(" and GoodsID in (select ID from Goods where ClassID in (" + ids + "))");
                else
                    sb.Append(" and GoodsID in (select ID from Goods where ClassID = " + classID + ")");
            }
            if (this.textBox_M_Price.Text != "￥0.00" && this.textBox_M_Price.Text != "")
                sb.Append(" and Price" + this.comboBox_M_Sign.Text + this.textBox_M_Price.Text.Replace("￥", ""));

            if (this.searchMember4.CardID != "")
            {
                searchMember4.GetSearchMember();
                sb.Append(" and MemID=" + this.searchMember4.MemID);
            }

            //汇总表
            int Mnum = 0;
            decimal Money = 0;
            DataSet ds = null;
            if (sb.ToString() == "")
            {
                ds = new VipSoft.BLL.OrderLog().GetListCollect("SELECT  MemID,CardID,MemName,sum(Number) as TotalNumbers,sum(DiscountPrice) as DiscountMoneys from OrderLog left join OrderDetail on OrderLog.OrderCode=OrderDetail.OrderCode   where " + sb.ToString() + " OrderType not int (2,3,8) group by MemID,CardID,MemName");
            }
            else
            {
                ds = new VipSoft.BLL.OrderLog().GetListCollect("SELECT  MemID,CardID,MemName,sum(Number) as TotalNumbers,sum(DiscountPrice) as DiscountMoneys from OrderLog left join OrderDetail on OrderLog.OrderCode=OrderDetail.OrderCode   where " + sb.ToString() + " and OrderType not in (2,3,8) group by MemID,CardID,MemName");
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.lblM_Ing.Visible = false;
            }
            else
            {
                this.lblM_Ing.Visible = true;
            }

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Mnum += int.Parse(dr["TotalNumbers"].ToString());
                Money += Math.Round(decimal.Parse(dr["DiscountMoneys"].ToString()), 2);
                this.dgvMCollect.Rows.Add(dr["CardID"], dr["MemName"], dr["TotalNumbers"], dr["DiscountMoneys"]);
            }

            this.lbl_num.Text = Mnum.ToString();
            this.lmoney.Text = Money.ToString("#0.00");

        }

        private void dgvMCollect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvMWater.Rows.Clear();
            if (this.dgvMCollect.SelectedRows.Count == 0)
                return;
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.dateTimePicker_M_Start.Checked)
            {
                DateTime time1;
                string t1 = this.dateTimePicker_M_Start.Value.ToShortDateString() + " " + this.maskedTextBox_M_Start.Text;
                if (!DateTime.TryParse(t1, out time1))
                {
                    MessageBox.Show("开始时间输入错误！");
                    return;
                }
                sb.Append(" and CreateDateTime >= '" + time1.ToString() + "'");
            }

            if (this.dateTimePicker_M_End.Checked)
            {
                DateTime time2;
                string t2 = this.dateTimePicker_M_End.Value.ToShortDateString() + " " + this.maskedTextBox_M_End.Text;
                if (!DateTime.TryParse(t2, out time2))
                {
                    MessageBox.Show("结束时间输入错误！");
                    return;
                }
                sb.Append("CreateDateTime <= '" + time2.ToString() + "'");
            }

            if (this.comboBox_M_OrderType.SelectedIndex == 1)
                sb.Append(" and OrderType=0");// 余额消费
            else if (this.comboBox_M_OrderType.SelectedIndex == 2)
                sb.Append(" and OrderType=1");// 记次

            if (this.comboBox_M_Class.SelectedIndex != 0)
            {
                string classID = ((DataRowView)this.comboBox_M_Class.SelectedItem)["Value"].ToString();
                DataTable dtClass = new VipSoft.BLL.GoodsClass().GetList("ShopID=" + PublicState.Master.ShopID).Tables[0];
                string ids = Function.GetChildClassListStr(dtClass, classID);
                if (ids != "")
                    sb.Append(" and GoodsID in (select ID from Goods where ClassID in (" + ids + "))");
                else
                    sb.Append(" and GoodsID in (select ID from Goods where ClassID = " + classID + ")");
            }
            if (this.textBox_M_Price.Text != "￥0.00" && this.textBox_M_Price.Text != "")
                sb.Append(" and Price" + this.comboBox_M_Sign.Text + this.textBox_M_Price.Text.Replace("￥", ""));

            if (this.searchMember4.CardID != "")
            {
                searchMember4.GetSearchMember();
                sb.Append(" and MemID=" + this.searchMember4.MemID);
            }

            string cardID = this.dgvMCollect.SelectedRows[0].Cells[0].Value.ToString();

            DataSet dst = null;
            //单据表
            if (sb.ToString() != "")
            {
                dst = new VipSoft.BLL.OrderLog().GetListCollect("SELECT  CardID,GoodsCode,GoodsName,sum(Number) as Numbers,Price, sum(DiscountPrice) as sumMoneys  from orderLog  left join orderDetail on orderLog.orderCode=orderDetail.orderCode  where " + sb.ToString() + " and CardID='" + cardID + "' and  orderType not in (2,3,8)  group by GoodsCode,GoodsName,Price,DiscountPrice,cardID");
            }
            else
            {
                dst = new VipSoft.BLL.OrderLog().GetListCollect("SELECT  CardID,GoodsCode,GoodsName,sum(Number) as Numbers,Price, sum(DiscountPrice) as sumMoneys  from orderLog  left join orderDetail on orderLog.orderCode=orderDetail.orderCode  where " + sb.ToString() + "  CardID='" + cardID + "' and  orderType not in (2,3,8)  group by GoodsCode,GoodsName,Price,DiscountPrice,cardID");
            }

            foreach (DataRow drst in dst.Tables[0].Rows)
            {
                this.dgvMWater.Rows.Add(drst["GoodsCode"], drst["GoodsName"], drst["Price"], drst["sumMoneys"], drst["Numbers"], drst["sumMoneys"]);
            }
        }
    }
}
