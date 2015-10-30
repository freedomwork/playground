using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace VipSoft.Controls
{
    public delegate void EventMemberSelectedHandler(VipSoft.Model.MemCard selectedMemInfo);
    //刷卡区回车,如不为空则调用此委托，散客消费
    public delegate void ShanKeXiaoFeiHandler();
    public partial class SearchMember : UserControl
    {

        public event ShanKeXiaoFeiHandler ShanKeSelected;

        /// <summary>
        /// 绑定文本框会员卡号
        /// </summary>
        [Browsable(true), Description("绑定文本框会员卡号"), Category("杂项")]
        public string CardID
        {
            get { return this.textBox_CardID.Text;}
            set { this.textBox_CardID.Text = value; }
        }

        public int MemID
        {
            get { return int.Parse(this.textBox_CardID.Tag.ToString()); }
            set { this.textBox_CardID.Tag = value; }
        }


        /// <summary>
        /// 设置是否是小类型控件
        /// </summary>
        [Browsable(true), Description("设置是否显示小控件"), Category("杂项")]
        public bool IsSmallControl
        {
         get { return this.Height != 35; }
            set {
                if (value)
                {
                    int height = 22;

                    Font font = new Font(new FontFamily("宋体"), 10F, GraphicsUnit.Point);
                    this.textBox_CardID.Font = font;
                    this.textBox_CardID.Width = 110;
                    this.textBox_CardID.Location = new Point(this.textBox_CardID.Location.X, 0);

                    this.button_Search.Size = new Size(50, height);
                    this.button_Search.Location = new Point(190, 0);

                    //this.label_IC.Location = new Point(240, (height - this.label1.Height) / 2);

                    this.label_Msg.Location = new Point(this.label_Msg.Location.X, (height - this.label_Msg.Height) / 2);
                    this.Height = height;
                }
            }
        }

        public SearchMember()
        {
            InitializeComponent();
        }

        public void ShowMemList()
        {
            button_Search_Click(null, null);
        }

        /// <summary>
        /// 当选择了用户时触发
        /// </summary>
        public event EventMemberSelectedHandler EventMemberSelected;

        // 按下回车键时
        private void textBox_CardID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CardIDKeyDown();
            }
        }

        /// <summary>
        /// 按下回车时的处理方法
        /// </summary>
        public void CardIDKeyDown()
        {
            // 卡号
            string reg_cardid = @"^[A-Za-z0-9]{0,30}$";
            if (this.textBox_CardID.Text == "")
            {
                if (ShanKeSelected != null)
                    ShanKeSelected();
                return;
            }
            else if (!Regex.IsMatch(this.textBox_CardID.Text, reg_cardid))
            {
                MessageBox.Show("卡号输入错误。");
                this.textBox_CardID.Focus();
                this.textBox_CardID.SelectAll();
                return;
            }
            VipSoft.BLL.MemCard card = new VipSoft.BLL.MemCard();
            VipSoft.Model.MemCard memInfo = card.GetModel(this.textBox_CardID.Text);
            if (memInfo == null)
            {
                MessageBox.Show("未找到此会员。");
                this.textBox_CardID.Focus();
                this.textBox_CardID.SelectAll();
                return;
            }
            if (EventMemberSelected != null)
                EventMemberSelected(memInfo);
         
        }

        // 查找
        private void button_Search_Click(object sender, EventArgs e)
        {
            VipSoft.SearchMem searchM = new VipSoft.SearchMem();
            searchM.SearchMemSelected += new VipSoft.SearchMemSelectedHandler(searchM_SearchMemSelected);
            searchM.StartPosition = FormStartPosition.Manual;
            
            Point  p = this.PointToScreen(this.button_Search.Location);
            int top = IsSmallControl ? 24 : 30;
            searchM.Location = new Point(p.X - 170,p.Y + top);

            searchM.Show();
        }

        // 会员查找快捷窗口选择某会员时
        void searchM_SearchMemSelected(VipSoft.Model.MemCard memInfo)
        {
            this.textBox_CardID.Text = memInfo.CardID;
            if (memInfo.ID != null)
            {
                this.textBox_CardID.Tag = memInfo.ID;
            }
            if (EventMemberSelected != null)
            {
                EventMemberSelected(memInfo);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox_CardID.Text.Length != 3)
            {//每隔特定时间检查文本框内容长度是否等于最大长度 
                timer1.Enabled = false;
                textBox_CardID.Text = "";

            }
        }

        private void textBox_CardID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void label_Msg_Click(object sender, EventArgs e)
        {

        }


        public void GetSearchMember()
        {
            if (this.textBox_CardID.Text.Trim() != "")
            {
                VipSoft.BLL.MemCard card = new VipSoft.BLL.MemCard();
                VipSoft.Model.MemCard memInfo = card.GetModel(this.textBox_CardID.Text);
                if (memInfo != null)
                {
                    MemID = memInfo.ID;
                }
                else
                {
                    MemID = -1;
                }
            }         
        }
    }
}
