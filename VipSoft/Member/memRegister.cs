using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VipSoft.Common;

namespace VipSoft
{
    public partial class memRegister : BaseForm
    {
        public event memListRefreshHandler memListRefresh;

        public int memId = 0;

        public memRegister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 加载卡片等级
        /// </summary>
        private void LoadCardLevel()
        {
            VipSoft.BLL.CardLevel level = new VipSoft.BLL.CardLevel();
            DataSet ds = level.GetAllList();
            this.LevelID.DataSource = ds.Tables[0];
            this.LevelID.DisplayMember = "LevelName";
            this.LevelID.ValueMember = "ID";
        }

        private void alButton1_Click(object sender, EventArgs e)
        {
            VipSoft.BLL.MemCard mBll = new BLL.MemCard();

            //新建会员卡实体对象，保存界面录入的值
            VipSoft.Model.MemCard mCard = new Model.MemCard();
            mCard.Name = this.Name.Text.Trim();
            mCard.CardID = this.cardid.Text.Trim();
            mCard.CardMianID = this.cardmianid.Text.Trim();
            mCard.CardTypeID = this.CardTypeID.SelectedIndex;
            mCard.CreateTime = DateTime.Parse(this.createtime.Text.Trim());
            mCard.Email = this.Email.Text.Trim();
            mCard.IsPast = this.IsPast.Checked ;
            mCard.IsPointAuto = this.IsPointAuto.Checked ;
            mCard.PastTime = DateTime.Parse(this.PastTime.Text.Trim());
            mCard.Sex = this.Sex.SelectedIndex;
            mCard.Mobile = this.Mobile.Text.Trim();
            mCard.LevelID = int.Parse(this.LevelID.SelectedValue.ToString());
            mCard.Money = Decimal.Parse(this.Money.Text.Trim());
            mCard.Password = this.Password.Text.Trim();
            mCard.PayMoney = Decimal.Parse(this.PayMoney.Text.Trim());
            mCard.Point = Int32.Parse(this.Point.Text.Trim());
            mCard.Remark = this.Remark.Text.Trim();
            mCard.State = int.Parse(((System.Collections.DictionaryEntry)State.SelectedItem).Value.ToString());
            //...

            if (this.memId == 0)
            {
                mBll.Add(mCard);
                MessageBox.Show("会员新增成功。");

                if (this.continue_add.Checked)
                {
                    this.cardid.Text = "";
                    this.cardmianid.Text = "";
                    this.CardTypeID.Text = "";
                    this.Name.Text = "";
                    //...
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                mCard.ID = memId;
                mBll.Update(mCard);
                MessageBox.Show("会员修改成功。");
                this.Close();
            }

        }

        private void memRegister_Load(object sender, EventArgs e)
        {
            LoadCardLevel();
            loadDicData();
            if (memId != 0)
            {
                VipSoft.BLL.MemCard mCard = new VipSoft.BLL.MemCard();
                VipSoft.Model.MemCard memModel = mCard.GetModel(memId);

                if (memModel != null)
                {
                    this.continue_add.Visible = false;
                    this.cardid.Text = memModel.CardID;
                    this.cardmianid.Text = memModel.CardMianID;
                    this.CardTypeID.SelectedIndex = int.Parse(memModel.CardTypeID.ToString());
                    this.Name.Text = memModel.Name;
                    this.LevelID.Text = memModel.LevelID.ToString();
                    this.id.Text = memModel.ID.ToString();
                    this.Sex.SelectedIndex = int.Parse(memModel.Sex.ToString());
                    this.State.SelectedIndex = int.Parse(memModel.State.ToString());
                    //this.IsPast.Text = memModel.IsPast.ToString();
                    //this.IsPointAuto.Text = memModel.IsPointAuto.ToString();
                    this.Email.Text = memModel.Email;
                    this.createtime.Text = memModel.CreateTime.ToString();
                    this.Mobile.Text = memModel.Mobile;
                    this.Money.Text = memModel.Money.ToString();
                    this.PayMoney.Text = memModel.PayMoney.ToString();
                    this.Remark.Text = memModel.Remark.ToString();
                    this.Point.Text = memModel.Point.ToString();
                }
              
            }

        }


        //加载页面的字典项
        private void loadDicData()
        {
            //加载卡片状态
            this.State.Items.Add(new System.Collections.DictionaryEntry("正常", 0));
            this.State.Items.Add(new System.Collections.DictionaryEntry("锁定", 1));
            this.State.Items.Add(new System.Collections.DictionaryEntry("挂失", 2));
            this.State.DisplayMember = "key";
            this.State.ValueMember = "value";
            this.State.SelectedIndex = 0;

            this.Sex.Items.Add(new System.Collections.DictionaryEntry("未知", 0));
            this.Sex.Items.Add(new System.Collections.DictionaryEntry("男", 1));
            this.Sex.Items.Add(new System.Collections.DictionaryEntry("女", 2));
            this.Sex.DisplayMember = "key";
            this.Sex.ValueMember = "value";
            this.Sex.SelectedIndex = 0;

            //加载卡片类型
            this.CardTypeID.Items.Add(new System.Collections.DictionaryEntry("计次卡", 1));
            this.CardTypeID.Items.Add(new System.Collections.DictionaryEntry("计时卡", 2));
            this.CardTypeID.Items.Add(new System.Collections.DictionaryEntry("月卡", 3));
            this.CardTypeID.DisplayMember = "key";
            this.CardTypeID.ValueMember = "value";
            this.CardTypeID.SelectedIndex = 0;

        }

        private void alButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetLevel sl = new SetLevel();
            sl.StartPosition = FormStartPosition.CenterParent;
            sl.LevelFormClosed += new LevelFormClosedHandler(sl_LevelFormClosed);
            sl.ShowDialog();
        }

        // 卡片等级窗体关闭时，需要重新加载注册窗体的卡片级别下拉菜单
        void sl_LevelFormClosed(string s)
        {
            LoadCardLevel();
        }
    }
}
