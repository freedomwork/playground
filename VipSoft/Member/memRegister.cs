using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class memRegister : BaseForm
    {
        public memRegister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void alButton1_Click(object sender, EventArgs e)
        {

            VipSoft.BLL.MemCard mBll = new BLL.MemCard();

            //新建会员卡实体对象，保存界面录入的值
            VipSoft.Model.MemCard mCard = new Model.MemCard();
            mCard.Name = this.Name.Text.Trim();
            mCard.CardID = this.cardid.Text.Trim();
            mCard.CardMianID = this.cardmianid.Text.Trim();
            mCard.CardTypeID = Int32.Parse(this.CardTypeID.Text.Trim());
            mCard.CreateTime = DateTime.Parse(this.createtime.Text.Trim());
            mCard.Email = this.Email.Text.Trim();
           // mCard.IsPast = Convert.ToBoolean(Int32.Parse(this.IsPast.Text.Trim()));
           // mCard.IsPointAuto = Convert.ToBoolean(Int32.Parse(this.IsPointAuto.Text.Trim()));
            mCard.PastTime = DateTime.Parse(this.PastTime.Text.Trim());
            mCard.Sex = this.Sex.SelectedIndex;
            mCard.Mobile = this.Mobile.Text.Trim();
            mCard.LevelID = Int32.Parse(this.LevelID.Text.Trim());
            mCard.Money = Decimal.Parse(this.Money.Text.Trim());
            mCard.Password = this.Password.Text.Trim();
            mCard.PayMoney = Decimal.Parse(this.PayMoney.Text.Trim());
            mCard.Point = Int32.Parse(this.Point.Text.Trim());
            mCard.Remark = this.Remark.Text.Trim();
            mCard.State = this.State.SelectedIndex;
            //...

            mBll.Add(mCard);

        }

        private void memRegister_Load(object sender, EventArgs e)
        {

            //加载卡片状态
            this.State.Items.Add(new System.Collections.DictionaryEntry("正常", 0));
            this.State.Items.Add(new System.Collections.DictionaryEntry("锁定", 1));
            this.State.Items.Add(new System.Collections.DictionaryEntry("挂失", 2));
            this.State.DisplayMember = "key";
            this.State.ValueMember = "value";
            this.State.SelectedIndex = 0;

            this.Sex.Items.Add(new System.Collections.DictionaryEntry("男", 0));
            this.Sex.Items.Add(new System.Collections.DictionaryEntry("女", 1));
            this.Sex.DisplayMember = "key";
            this.Sex.ValueMember = "value";
            this.Sex.SelectedIndex = 0;


        }
    }
}
