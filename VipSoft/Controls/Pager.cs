using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Vipsoft.Controls
{
    /// <summary>
    /// 申明委托
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public delegate void EventPagingHandler(EventPagingArg e);

    /// <summary>
    /// 自定义分页控件
    /// </summary>
    public partial class Pager : UserControl
    {
        /// <summary>
        /// 自定义按钮分页事件
        /// </summary>
        public event EventPagingHandler EventPaging;

        #region 分页属性
        private int pageSize = 10;
        private int currentPage = 0;
        private int recordCount = 0;
        private int pageCount = 0;
        [Browsable(true),Description("每页包含多少条记录"), Category("分页属性")]
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
        [Browsable(true), Description("当前第几页（从0开始）"), Category("分页属性")]
        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }
        [Browsable(true), Description("总记录数量"), Category("分页属性")]
        public int RecordCount
        {
            get { return recordCount; }
            set { recordCount = value; }
        }
        [Browsable(true), Description("总页数"), Category("分页属性")]
        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
        #endregion

        #region 外观
        private int pagerWidth = 500;
        private Image backgroundImage;

        [Browsable(true), Description("控件宽度"), Category("分页外观")]
        public int PagerWidth
        {
            get { return pagerWidth; }
            set 
            {
                if (value < 400)
                    value = 400;
                pagerWidth = value;
                this.Width = pagerWidth;

                int x_info = (pagerWidth - 400) / 2;
                int x_button = x_info + 220;
                this.panel_Info.Location = new Point(x_info, this.panel_Info.Location.Y);
                this.panel_Button.Location = new Point(x_button, this.panel_Info.Location.Y);
            }
        }
        [Browsable(true), Description("控件背景图片"), Category("分页外观")]
        public Image BackGroundImage
        {
            get { return backgroundImage; }
            set { backgroundImage = value; }
        }
        
        #endregion

        public Pager()
        {
            InitializeComponent();
            this.Load += new EventHandler(Pager_Load);
        }

        /// <summary>
        /// 绑定控件数据
        /// </summary>
        public void PagerBind()
        {
            pageCount = Convert.ToInt32(Math.Ceiling(((decimal)recordCount) / pageSize));

            string str = "共{0}条记录 每页{1}条 当前{2}/{3}页";
            int cpage = pageCount != 0 ? (currentPage + 1) : 0;
            this.label_PageInfo.Text = string.Format(str, recordCount.ToString(), pageSize.ToString(), cpage.ToString(), pageCount.ToString());
            this.linkLabel_Jump.Enabled = true;

            if (pageCount <= 1)
            {
                this.button_First.Enabled = false;
                this.button_Prev.Enabled = false;
                this.button_Next.Enabled = false;
                this.button_Last.Enabled = false;
                this.button_First.Image = global::VipSoft.Properties.Resources.Page_FirstBlack;
                this.button_Prev.Image = global::VipSoft.Properties.Resources.Page_PrevBlack;
                this.button_Next.Image = global::VipSoft.Properties.Resources.Page_NextBlack;
                this.button_Last.Image = global::VipSoft.Properties.Resources.Page_LastBlack;
            }
            // 首页、上一页            
            if (currentPage == 0 || pageCount <= 1)
            {
                this.button_First.Enabled = false;
                this.button_Prev.Enabled = false;
                this.button_First.Image = global::VipSoft.Properties.Resources.Page_FirstBlack;
                this.button_Prev.Image = global::VipSoft.Properties.Resources.Page_PrevBlack;
            }
            else
            {
                this.button_First.Enabled = true;
                this.button_Prev.Enabled = true;
                this.button_First.Image = global::VipSoft.Properties.Resources.Page_First;
                this.button_Prev.Image = global::VipSoft.Properties.Resources.Page_Prev;
            }
            // 下一页、尾页
            if (currentPage == pageCount - 1 || pageCount <= 1)
            {
                this.button_Next.Enabled = false;
                this.button_Last.Enabled = false;
                this.button_Next.Image = global::VipSoft.Properties.Resources.Page_NextBlack;
                this.button_Last.Image = global::VipSoft.Properties.Resources.Page_LastBlack;
            }
            else
            {
                this.button_Next.Enabled = true;
                this.button_Last.Enabled = true;
                this.button_Next.Image = global::VipSoft.Properties.Resources.Page_Next;
                this.button_Last.Image = global::VipSoft.Properties.Resources.Page_Last;
            }
        }

        // 分页事件
        private void PageButton_Click(object sender, EventArgs e)
        {
            Button linkBT = (Button)sender;
            switch (linkBT.Name)
            {
                case "button_First":
                    currentPage = 0;
                    break;
                case "button_Prev":
                    currentPage--;
                    break;
                case "button_Next":
                    currentPage++;
                    break;
                case "button_Last":
                    currentPage = pageCount - 1;
                    break;
            }
            PagerBind();
            if (EventPaging != null)
            {
                EventPaging(new EventPagingArg(currentPage));
                this.textBox_Jump.Text = (currentPage + 1).ToString();
            }
        }
        // 分页跳转
        private void linkLabel_Jump_Click(object sender, EventArgs e)
        {
            string p = this.textBox_Jump.Text;
            int page;
            if (int.TryParse(p, out page))
            {
                if (page > pageCount || page <= 0)
                {
                    MessageBox.Show("页数超出范围。");
                    this.textBox_Jump.Focus();
                    this.textBox_Jump.SelectAll();
                    return;
                }
                else
                { 
                    EventPaging(new EventPagingArg(page-1));
                    this.textBox_Jump.Text = page.ToString();
                }
            }
            else
            {
                MessageBox.Show("页码输入错误。");
                this.textBox_Jump.Focus();
                this.textBox_Jump.SelectAll();
                return;
            }
        }

        // 回车
        private void textBox_Jump_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                linkLabel_Jump_Click(null, null);
        }

        // 加载时
        private void Pager_Load(object sender, EventArgs e)
        {
            this.button_First.Image = global::VipSoft.Properties.Resources.Page_FirstBlack;
            this.button_Prev.Image = global::VipSoft.Properties.Resources.Page_PrevBlack;
            this.button_Next.Image = global::VipSoft.Properties.Resources.Page_NextBlack;
            this.button_Last.Image = global::VipSoft.Properties.Resources.Page_LastBlack;
            this.button_First.Enabled = false;
            this.button_Last.Enabled = false;
            this.button_Next.Enabled = false;
            this.button_Prev.Enabled = false;
            this.linkLabel_Jump.Enabled = false;
            this.label_PageInfo.Text = "暂无数据绑定";
        }
    }

    /// <summary>
    /// 自定义事件数据基类
    /// </summary>
    public class EventPagingArg : EventArgs
    {
        private int _intPageIndex = 0;
        public int PageIndex
        {
            get { return _intPageIndex; }
        }
        public EventPagingArg(int PageIndex)
        {
            _intPageIndex = PageIndex;
        }
    }

}
