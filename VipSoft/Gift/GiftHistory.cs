using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class GiftHistory : BaseForm
    {

        public string CurrentCardID = "";
        public GiftHistory()
        {
            InitializeComponent();
            this.dataGridView_List.AutoGenerateColumns = false;
        }

        private void searchMember1_EventMemberSelected(Model.MemCard selectedMemInfo)
        {
            this.dataGridView_List.Rows.Clear();
            VipSoft.BLL.ExchangeLog log = new VipSoft.BLL.ExchangeLog();
            DataTable dt = log.GetReportList("ExchangeLog.CardID='" + this.searchMember1.CardID + "' or MemCard.CardmianID='" + this.searchMember1.CardID + "' or MemCard.Mobile='" + this.searchMember1.CardID + "'").Tables[0];
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    this.dataGridView_List.Rows.Add(dr["ID"].ToString(), dr["GiftName"].ToString(), dr["Point"].ToString(),
                        dr["Number"].ToString(), dr["CreateTime"].ToString());
                }
                this.label_Result.Visible = false;
            }
            else
            {
                this.label_Result.Text = "暂无兑换记录！";
                this.label_Result.Visible = true;
            }
        }

        private void GiftHistory_Load(object sender, EventArgs e)
        {
            this.label_Result.Text = "";
            this.searchMember1.CardID = CurrentCardID;
            searchMember1_EventMemberSelected(null);
        }
    }
}
