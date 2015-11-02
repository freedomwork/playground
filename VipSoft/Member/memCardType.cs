using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace VipSoft
{
    public partial class memCardType : BaseForm
    {
        public memCardType()
        {
            InitializeComponent();
        }

        private void memCardType_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("type");
            dt.Columns.Add("name");

             DataRow dr = dt.NewRow();
            dr["type"] = 1;
            dr["name"] = "计次卡";
            dt.Rows.Add(dr);

            DataRow dr2 = dt.NewRow();
            dr2["type"] = 2;
            dr2["name"] = "计时卡";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["type"] = 3;
            dr3["name"] = "月卡";
            dt.Rows.Add(dr3);

           cardType.DataSource = dt;
           cardType.DisplayMember = "name";
           cardType.ValueMember = "type";

           cardType.SelectedValue = 1;

           // String str = ((System.Collections.DictionaryEntry)cardType.SelectedItem).Value.ToString();
           // int val = int.Parse(str);
            queryCardType(int.Parse(cardType.SelectedValue.ToString()));
        }

        public void queryCardType(int cardType) {

            VipSoft.BLL.CardType ctBll = new VipSoft.BLL.CardType();
            VipSoft.Model.CardType ctModel = ctBll.GetModel(cardType);

            this.IsExpenseGoods.Checked = ctModel.IsExpenseGoods;
            this.IsExpensePoint.Checked = ctModel.IsExpensePoint;
            this.IsPointAuto.Checked = ctModel.IsPointAuto;
            this.id.Text = ctModel.ID.ToString();

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (this.id.Text != null && this.id.Text != "")
            {
                VipSoft.BLL.CardType ctBll = new VipSoft.BLL.CardType();
                VipSoft.Model.CardType ctModel = ctBll.GetModel(int.Parse(this.id.Text));
                ctModel.IsPointAuto = this.IsPointAuto.Checked == true ? true : false;
                ctModel.IsExpensePoint = this.IsExpensePoint.Checked == true ? true : false;
                ctModel.IsExpenseGoods = this.IsExpenseGoods.Checked == true ? true : false;

                if (ctBll.Update(ctModel))
                {
                    MessageBox.Show("保存成功!");
                }
            }
            else
            {
                MessageBox.Show("请先选择卡类型!");
            }
        }

        private void cardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                queryCardType(int.Parse(cardType.SelectedValue.ToString()));
            }catch{}
          
        }
    }
}
