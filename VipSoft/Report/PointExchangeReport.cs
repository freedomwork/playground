using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class PointExchangeReport : BaseForm
    {
        public PointExchangeReport()
        {
            InitializeComponent();
        }

        string QueryCondition()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.textBox_MemKey.Text.Trim()!="")
            {
                sb.Append(" and (ExchangeLog.CardID='" + this.textBox_MemKey.Text + "' or ExchangeLog.Name like '%" + this.textBox_MemKey.Text + "%' or MemCard.CardmianID='" + this.textBox_MemKey.Text + "')");
            }
            if (this.textBox_GoodsKey.Text != "")
            {
                sb.Append(" and (ExchangeLog.GiftCode='" + this.textBox_GoodsKey.Text + "' or ExchangeLog.GiftName like '%" + this.textBox_GoodsKey.Text + "%')");
            }
            if (this.dateTimePicker_Start.Checked)
                sb.Append(" and ExchangeLog.CreateTime >= '" + this.dateTimePicker_Start.Value.ToShortDateString() + " 00:00:00'");
            if (this.dateTimePicker_End.Checked)
            {
                sb.Append(" and ExchangeLog.CreateTime <= '" + this.dateTimePicker_End.Value.ToShortDateString() + " 23:59:59'");
            }
            return sb.ToString();
        }

        void BindList()
        {
            this.dgvPoinList.Rows.Clear();
            DataTable dt = new VipSoft.BLL.ExchangeLog().GetReportList(QueryCondition()).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                this.dgvPoinList.Rows.Add(dr["CardID"], dr["Name"], dr["GiftCode"], dr["GiftName"], dr["Point"], dr["Number"], dr["CreateTime"]);
            }
        }

        private void PointExchangeReport_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_Start.Text = DateTime.Now.ToShortDateString();
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
