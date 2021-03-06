﻿using System;
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
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void prepaidCardRecharge_Load(object sender, EventArgs e)
        {
            this.comboBox1.Text = "---无优惠---";
           
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

            conditionStr += " cardid ='"+search_box.Text+"' or mobile ='"+search_box.Text+"' ";

            VipSoft.BLL.MemCard memCard = new BLL.MemCard();
            DataSet ds = memCard.GetList(conditionStr);
            DataTable dt = ds.Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];
                this.v_cardid.Text = dr["cardid"].ToString();
                this.name.Text = dr["name"].ToString();
                this.v_money.Text = dr["money"].ToString();
                this.totalMoney.Text = dr["totalMoney"].ToString();
                this.point.Text = dr["point"].ToString();
                this.mobile.Text = dr["mobile"].ToString();
                this.pasttime.Text = dr["pasttime"].ToString().Substring(0, 10);
                this.levelid.Text = dr["levelid"].ToString();
                this.id.Text = dr["id"].ToString();

            }
            else
            {

                this.v_cardid.Text = "";
                this.name.Text = "";
                this.v_money.Text ="";
                this.totalMoney.Text = "";
                this.point.Text = "";
                this.mobile.Text = "";
                this.pasttime.Text ="";
                this.levelid.Text = "";
                this.id.Text = "";
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
            if (this.v_cardid.Text == null || this.v_cardid.Text == "")
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

        private void myTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.id.Text != "" && this.id.Text != null)
            {
                //假如界面的会员ID不为空，查询该会员的历史充值记录
                String conditionStr = "memid = " + this.id.Text;
                VipSoft.BLL.RechargeLog chargeBll = new VipSoft.BLL.RechargeLog();
                DataSet ds = chargeBll.GetList(conditionStr);
                this.dataGridView1.DataSource = ds.Tables[0];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = false;
                }

            }
        }















    }
}
