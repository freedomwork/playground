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
    public partial class ExpHistory : BaseForm
    {
        public ExpHistory()
        {
            InitializeComponent();
            this.dataGridView_DetailList.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 绑定消费类型
        /// </summary>
        private void BindOrderType()
        {
            this.comboBox_OrderType.Items.Clear();
            this.comboBox_OrderType.Items.Add(new DictionaryEntry("消费类型", ""));

            this.comboBox_OrderType.Items.Add(new DictionaryEntry("普通消费", "0"));
            this.comboBox_OrderType.Items.Add(new DictionaryEntry("快速消费", "3"));

            this.comboBox_OrderType.DisplayMember = "Key";
            this.comboBox_OrderType.ValueMember = "Value";

            this.comboBox_OrderType.SelectedIndex = 0;
        }

        private void BindPayType()
        {
            this.comboBox_PayType.Items.Clear();
            this.comboBox_PayType.Items.Add(new DictionaryEntry("请选择状态", 0));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("余额", 1));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("现金", 2));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("银行卡", 3));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("代金券", 4));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("联合", 5));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("挂账", 10));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("挂单", 11));
            this.comboBox_PayType.Items.Add(new DictionaryEntry("记次", 100));
            this.comboBox_PayType.DisplayMember = "Key";
            this.comboBox_PayType.ValueMember = "Value";

            this.comboBox_PayType.SelectedIndex = 0;
        }

        string QueryCondition()
        {
            string strWhere = " 1=1 ";
            if (!string.IsNullOrEmpty(this.textBox_CardID.Text.Trim()))
            {
                strWhere += " and CardID like '%" + this.textBox_CardID.Text.Trim() + "%'";
            }
            if (this.dateTimePicker_Start.Checked)
            {
                strWhere += " and CreateDateTime>='" + this.dateTimePicker_Start.Value.ToString() + "'";
            }
            if (this.dateTimePicker_End.Checked)
            {
                strWhere += " and CreateDateTime<='" + this.dateTimePicker_End.Value.ToString() + "'";
            }
            if (((DictionaryEntry)(this.comboBox_OrderType.SelectedItem)).Value.ToString()!="")
            {
                strWhere += " and OrderType=" + ((DictionaryEntry)(this.comboBox_OrderType.SelectedItem)).Value.ToString();
            }
            if (((DictionaryEntry)(this.comboBox_PayType.SelectedItem)).Value.ToString()!="0")
            {
                strWhere += " and PayType=" + ((DictionaryEntry)(this.comboBox_PayType.SelectedItem)).Value.ToString();
            }
            strWhere += " and ShopID=" + PublicState.Master.ShopID;
            return strWhere;
        }

        string GetOrderType(string OrderType)
        {
            string OrderTypeName="";
            switch (OrderType)
            {
                case "0":
                    OrderTypeName = "普通消费";
                    break;
                case "3":
                    OrderTypeName = "快速消费";
                    break;
            }
            return OrderTypeName;
        }

        string GetPayTypeName(string PayType)
        {
            string PayTypeName = "";
            switch (PayType)
            {
                case "1":
                    PayTypeName = "余额";
                    break;
                case "2":
                    PayTypeName = "现金";
                    break;
                case "3":
                    PayTypeName = "银行卡";
                    break;
                case "4":
                    PayTypeName = "代金券";
                    break;
                case "5":
                    PayTypeName = "联合";
                    break;
            }
            return PayTypeName;
        }

        private void ExpHistory_Load(object sender, EventArgs e)
        {
            BindOrderType();
            BindPayType();
            this.dateTimePicker_Start.Value = DateTime.Now.AddDays(-1);
            this.dateTimePicker_End.Value = DateTime.Now;
            BindOrderLogList();
        }

        void BindOrderLogList()
        {
            this.dataGridView_OrderList.Rows.Clear();
            string str = QueryCondition();
            DataSet ds = new VipSoft.BLL.OrderLog().GetList(QueryCondition());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.dataGridView_OrderList.Rows.Add(dr["ID"].ToString(),dr["OrderCode"].ToString(),dr["CardID"].ToString(),dr["MemName"].ToString(),dr["TotalMoney"].ToString(),dr["DisCountMoney"].ToString(),dr["DisCountMoney"].ToString(),dr["TotalNumber"].ToString(),dr["Point"].ToString(),GetOrderType(dr["PayType"].ToString()),dr["CreateDateTime"].ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindOrderLogList();
        }

        private void dataGridView_OrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                this.dataGridView_OrderList.Rows[e.RowIndex].Selected = true;
            BindOrderDetail();
        }

        /// <summary>
        /// 选择订单时，右边显示订单详细
        /// </summary>
        private void BindOrderDetail()
        {
            if (this.dataGridView_OrderList.SelectedRows.Count != 1)
                return;
            string orderCode = this.dataGridView_OrderList.SelectedRows[0].Cells["Column_OrderCode"].Value.ToString();
            VipSoft.BLL.OrderDetail detail = new VipSoft.BLL.OrderDetail();
            DataTable dt = detail.GetList("OrderCode='" + orderCode + "'").Tables[0];
            this.dataGridView_DetailList.DataSource = dt;
        }
    }
}
