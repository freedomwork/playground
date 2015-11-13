using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class PointChangeReport : BaseForm
    {
        public PointChangeReport()
        {
            InitializeComponent();
        }

        string QueryCondition()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1=1");
            if (this.textBox_MemKey.Text.Trim()!="")
            {
                sb.Append(" and (CardID='" + this.textBox_MemKey.Text + "' or MemName like '%" + this.textBox_MemKey.Text + "%' )");
            }
            if(this.dateTimePicker_Start.Checked)
            {
                sb.Append(" and CreateDateTime >= '" + this.dateTimePicker_Start.Text + " 00:00:00'");
            }
            if(this.dateTimePicker_End.Checked)
            {
                sb.Append(" and CreateDateTime<='" + this.dateTimePicker_End.Text + " 00:00:00'");
            }
            if (((System.Collections.DictionaryEntry)this.comboBox_Type.SelectedItem).Value.ToString() != "0")
            {
                sb.Append(" and Type="+((System.Collections.DictionaryEntry)this.comboBox_Type.SelectedItem).Value.ToString());
            }
            sb.Append(" order by CreateDateTime desc ");
            return sb.ToString();
        }

        void BindList()
        {
            this.dgvPoinList.Rows.Clear();
            DataTable dt = new VipSoft.BLL.PointLog().GetList(QueryCondition()).Tables[0];
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
                this.dgvPoinList.Rows.Add(dr["CardID"], dr["MemName"], dr["Point"], decimal.Parse(dr["Point"].ToString()) >= 0 ? "增加" : "扣除", dr["ShopName"], dr["CreateDateTime"]);
            }
        }

        private void PointChangeReport_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_Start.Text = DateTime.Now.ToShortDateString();

            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("所有类别", 0));
            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("消费获得积分", 1));
            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("兑换获得积分", 2));
            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("退货扣除积分", 3));
            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("注册初始积分", 4));
            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("操作员修改积分", 5));
            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("推荐会员注册获得积分", 10));
            this.comboBox_Type.Items.Add(new System.Collections.DictionaryEntry("下线会员消费获得积分", 11));
            this.comboBox_Type.ValueMember = "Value";
            this.comboBox_Type.DisplayMember = "Key";
            this.comboBox_Type.SelectedIndex = 0;
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
