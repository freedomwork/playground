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
    public partial class RechargeMoneyReport : BaseForm
    {
        public RechargeMoneyReport()
        {
            InitializeComponent();
        }

        string QueryCondition()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.textBox_Key.Text.Trim()!="")
            {
                sb.Append(" and (RechargeLog.CardID like '%"+this.textBox_Key.Text.Trim()+"%' or RechargeLog.MemName like '%"+this.textBox_Key.Text.Trim()+"%' or MemCard.CardmianID like '%"+this.textBox_Key.Text.Trim()+"%')");
            }
            if (this.comboBox_Level.SelectedIndex != -1 && this.comboBox_Level.SelectedIndex != 0)
            {
                sb.Append(" and MemCard.LevelID=" + ((DictionaryEntry)this.comboBox_Level.SelectedItem).Value.ToString());
            }
            if (this.comboBox_Type.SelectedIndex != -1)
            {
                if (((DictionaryEntry)this.comboBox_Type.SelectedItem).Value.ToString() != "-1")
                {
                    sb.Append(" and RechargeLog.[Type]=" + ((DictionaryEntry)this.comboBox_Type.SelectedItem).Value.ToString());
                }
            }
            if (this.textBox_Money.Text != "" && this.textBox_Money.Text != "￥0.00")
                sb.Append(" and RechargeLog.[Money]" + this.comboBox_Sign_Money.Text + this.textBox_Money.Text.Replace("￥", ""));
            if (this.dateTimePicker_Start.Checked)
                sb.Append(" and RechargeLog.CreateTime>='" + this.dateTimePicker_Start.Value.ToShortDateString() + " 00:00:00'");
            if (this.dateTimePicker_End.Checked)
                sb.Append(" and RechargeLog.CreateTime<='" + this.dateTimePicker_End.Value.ToShortDateString() + " 00:00:00'");
            return sb.ToString();
        }

        void BindList()
        {
            this.dgvRechargeList.Rows.Clear();
            DataTable dt = new VipSoft.BLL.RechargeLog().GetReportList(QueryCondition()).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                VipSoft.Model.CardLevel LevelModel=new VipSoft.BLL.CardLevel().GetModel(int.Parse(dr["LevelID"].ToString()));
                this.dgvRechargeList.Rows.Add(dr["CardID"].ToString(), dr["MemName"].ToString(), LevelModel.LevelName, dr["Type"].ToString() == "0" ? "卡片付费初始化" : dr["Type"].ToString() == "1" ? "储值卡现金充值" : dr["Type"].ToString() == "2" ? "记次卡现金充次" : dr["Type"].ToString() == "3" ? "储值卡扣款" : dr["Type"].ToString() == "5" ? "卡片余额初始化" : dr["Type"].ToString() == "6" ? "储值卡银联充值" : dr["Type"].ToString() == "7" ? "计次卡银联充次" : "积分返余额", dr["Money"].ToString(), dr["CreateTime"].ToString(), dr["GiveMoney"].ToString(), dr["Remark"].ToString());
            }
        }

        private void RechargeMoneyReport_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_Start.Text = DateTime.Now.ToShortDateString();
            this.comboBox_Sign_Money.SelectedIndex = 0;

            // 会员等级
            DataTable dtLevel = new VipSoft.BLL.CardLevel().GetAllList().Tables[0];

            this.comboBox_Level.Items.Add(new DictionaryEntry("所有等级", "0"));
            foreach (DataRow dr in dtLevel.Rows)
                this.comboBox_Level.Items.Add(new DictionaryEntry(dr["LevelName"].ToString(), dr["ID"].ToString()));

            this.comboBox_Level.DisplayMember = "Key";
            this.comboBox_Level.ValueMember = "Value";
            this.comboBox_Type.Items.Add(new DictionaryEntry("所有类型", "-1"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("卡片付费初始化", "0"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("储值卡现金充值", "1"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("储值卡银联充值", "6"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("记次卡现金充次", "2"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("记次卡银联充次", "7"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("储值卡扣款", "3"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("积分返余额", "4"));
            this.comboBox_Type.Items.Add(new DictionaryEntry("卡片余额初始化", "5"));
            this.comboBox_Type.DisplayMember = "Key";
            this.comboBox_Type.ValueMember = "Value";

            this.comboBox_Sign_Money.SelectedIndex = 0;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            BindList();
        }
    }
}
