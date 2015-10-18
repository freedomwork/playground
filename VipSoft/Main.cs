using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_MemberManage_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "会员管理";
            this.myTabControl.SelectedIndex = 1;
        }

        private void Button_GoodsManage_Click(object sender, EventArgs e)
        {
            this.label_Title.Text = "产品管理";
            this.myTabControl.SelectedIndex = 2;
        }

        private void panelButton_Item_Click(string senderName)
        {
            switch (senderName)
            {
                case "panelButton_Member_Add":
                    MemRegister reg = new MemRegister();
                    reg.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
