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
            //...

            mBll.Add(mCard);

        }
    }
}
