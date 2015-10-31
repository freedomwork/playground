using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class prepaidCardRecharge : BaseForm
    {
        public prepaidCardRecharge()
        {
            InitializeComponent();
        }

        private void prepaidCardRecharge_Load(object sender, EventArgs e)
        {
            this.comboBox1.Text = "----无优惠----";
        }

        public void search_Click(object sender, EventArgs e)
        {
            String conditionStr = "";
            if (this.search_box.Text == null)
            {
                MessageBox.Show("请先录入会员卡号或者手机号。");
                search_box.Focus();
                return;
            }

            conditionStr += " cardid like '%"+search_box.Text+"%' or mobile like '%"+search_box.Text+"%'";

            VipSoft.BLL.MemCard memCard = new BLL.MemCard();
            DataSet ds = memCard.GetList(conditionStr);
            DataTable dt = ds.Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];
                this.cardid.Text = dr["cardid"].ToString();
                this.name.Text = dr["name"].ToString();
                this.money.Text = dr["money"].ToString();
                this.totalMoney.Text = dr["totalMoney"].ToString();
                this.point.Text = dr["point"].ToString();
                this.mobile.Text = dr["mobile"].ToString();
                this.pasttime.Text = dr["pasttime"].ToString();
                this.levelid.Text = dr["levelid"].ToString();
                this.id.Text = dr["id"].ToString();
                
            }

            //SearchMem searchDlg = new SearchMem();
            
           // this.dataGridView_List.DataSource = ds.Tables[0];

        }

        private void calculateAmount(object sender, EventArgs e)
        {

            decimal rechargeAmount = this.rechargeAmount.Text != null ? decimal.Parse(this.rechargeAmount.Text) : 0;
            decimal giftAmount = this.giftAmount.Text != null ? decimal.Parse(this.giftAmount.Text) : 0;
            this.total.Text = (rechargeAmount + giftAmount).ToString();
        }

        private void recharge_Click(object sender, EventArgs e)
        {
            if (this.cardid.Text == null || this.cardid.Text == "")
            {
                MessageBox.Show("请先选择需要充值的会员!");
                this.search_box.Focus();
                return;
            }

            if (this.total.Text == "" || this.total.Text == null || decimal.Parse(this.total.Text) <= 0)
            {
                MessageBox.Show("请输入充值金额!");
                return;
            }

            int id = int.Parse(this.id.Text);
            decimal rechargeMoney = decimal.Parse(this.total.Text);
            VipSoft.BLL.MemCard mCard = new VipSoft.BLL.MemCard();
            VipSoft.Model.MemCard memModel = mCard.GetModel(id);

            //更新会员表的卡余额
            memModel.Money += rechargeMoney;
            mCard.Update(memModel);

            //往充值记录表插入充值记录
            VipSoft.BLL.RechargeLog chargeBll = new VipSoft.BLL.RechargeLog();
            VipSoft.Model.RechargeLog charge = new Model.RechargeLog();
            charge.MemID = id;
            charge.MemName = memModel.Name;
            charge.Money = decimal.Parse(this.rechargeAmount.Text);
            charge.CardID = memModel.CardID;
            charge.GiveMoney = decimal.Parse(this.giftAmount.Text);
            charge.MasterID = PublicState.Master.ID;
            charge.MasterName = PublicState.Master.Name;
            charge.ShopID = PublicState.Master.ShopID;
            charge.ShopName = PublicState.Master.ShopName;
            charge.Type = 0;
            if (chargeBll.Add(charge) > 0)
            {
                MessageBox.Show("充值成功!");
                this.Close();
            }
            else
            {
                MessageBox.Show("充值失败!");
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }










    }
}
