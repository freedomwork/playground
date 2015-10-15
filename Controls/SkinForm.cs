using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace YiJiaSoft.Controls
{
    public partial class SkinForm : Form
    {
        public SkinForm()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.StandardClick, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    this.SuspendLayout();

        //    base.OnPaint(e);

        //    System.Drawing.Drawing2D.GraphicsPath graPath = new System.Drawing.Drawing2D.GraphicsPath();
        //    RectangleF recBody = new RectangleF(0F, 0F, (float)this.Width, (float)this.Height);
        //    if (this.BackgroundImage == null)
        //    {
        //        LinearGradientBrush lgBrush = new LinearGradientBrush(recBody, Color.White, Color.FromArgb(67, 117, 170), 90F);
        //        e.Graphics.FillRectangle(lgBrush, recBody);
        //        lgBrush.Dispose();
        //    }
        //    else
        //    {
        //        e.Graphics.DrawImage(this.BackgroundImage, recBody);
        //    }
        //    graPath.Dispose();

        //    this.ResumeLayout();
        //}

        // 强制设置窗体背景颜色为透明，这样可以防止按钮出现白色边边
        Color _backColor = Color.Transparent;
        public override Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = Color.Transparent;
            }
        }

        // 强制设置窗体背景图像
        Image _backgroundImg = global::YiJiaSoft.Controls.Resource1.formBG;
        [DefaultValue(typeof(Image), "YiJiaSoft.Controls.Resource1.formBG")]
        public override Image BackgroundImage
        {
            get
            {
                return _backgroundImg;
            }
            set
            {
                _backgroundImg = value;
            }
        }

        // 强制设置背景显示方式
        ImageLayout _backgroundLayout = ImageLayout.Stretch;
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return _backgroundLayout;
            }
            set
            {
                _backgroundLayout = value;
            }
        }

    }
}
