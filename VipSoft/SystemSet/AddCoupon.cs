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
    public partial class AddCoupon : BaseForm
    {
        public AddCoupon()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitFormList()
        {
            this.ListBox_Shop.Items.Clear();
            DataSet ds = new VipSoft.BLL.Shop().GetAllList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.ListBox_Shop.Items.Add(new DictionaryEntry(dr["ID"].ToString(), dr["Name"].ToString()), false);
            }
            this.ListBox_Shop.ValueMember = "Key";
            this.ListBox_Shop.DisplayMember = "Value";
        }

        private void AddCoupon_Load(object sender, EventArgs e)
        {
            this.textBox_Title.Select();
            this.textBox_Title.Focus();
            InitFormList();
            ClearFormText();
        }

        bool CheckInput()
        {
            if (this.textBox_Title.Text.Trim()=="")
            {
                MessageBox.Show("请输入优惠券标题！");
                return false;
            }

            if (this.textBox_Num.Text.Trim()=="")
            {
                MessageBox.Show("请输入预发的电子券数量！");
                return false;
            }

            if (this.textBox_Money.Text.Trim()=="")
            {
                MessageBox.Show("请输入电子券的额度！");
                return false;
            }

            return true;
        }

        string GetShopIDs()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.ListBox_Shop.Items.Count; i++)
            {
                if (this.ListBox_Shop.CheckedItems.Contains(this.ListBox_Shop.Items[i]))
                    sb.Append(((DictionaryEntry)this.ListBox_Shop.Items[i]).Key.ToString() + ",");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 自动产生卡片编号
        /// </summary>
        /// <returns></returns>
        private string RandomCouponCode(string Prefix)
        {
            Random ran = new Random();
            int res = ran.Next(99999999);
            if (new VipSoft.BLL.CouponDetail().Exists(Prefix+res.ToString()))
                return RandomCouponCode(Prefix);
            else
                return Prefix+res.ToString();
        }

        void ClearFormText()
        {
            this.textBox_Title.Text = "";
            this.textBox_Prefix.Text = "";
            this.textBox_Num.Text = "";
            this.textBox_Money.Text = "";
            this.radioButton_TypeOne.Checked = true;
            this.textBox_Remark.Text = "";
            this.textBox_Title.Focus();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            VipSoft.Model.Coupon coupon = new Model.Coupon();
            VipSoft.BLL.Coupon bllCoupon = new BLL.Coupon();
            coupon.Title = this.textBox_Title.Text.Trim();
            coupon.Prefix = this.textBox_Prefix.Text.Trim();
            coupon.Money = decimal.Parse(this.textBox_Money.Text.Trim());
            coupon.Num = int.Parse(this.textBox_Num.Text.Trim());
            coupon.Type = this.radioButton_TypeOne.Checked ? 0 : 1;
            coupon.StartTime = this.dateTimePicker1.Value;
            coupon.EndTime = this.dateTimePicker2.Value;
            coupon.ShopIDInfo=GetShopIDs();
            coupon.Remark = this.textBox_Remark.Text;
            int CouponID=bllCoupon.Add(coupon);
            if (CouponID>0)
            {
                VipSoft.BLL.CouponDetail bllCouponDetail = new BLL.CouponDetail();
                for (int i = 0; i < coupon.Num; i++)
                {
                    VipSoft.Model.CouponDetail modelCouponDetail = new Model.CouponDetail();
                    modelCouponDetail.CouponID = CouponID;
                    modelCouponDetail.CouponNumber = RandomCouponCode(this.textBox_Prefix.Text.Trim());
                    modelCouponDetail.State = 0;
                    bllCouponDetail.Add(modelCouponDetail);
                }
            }

            MessageBox.Show("增加电子券成功！");

            ClearFormText();
        }
    }
}
