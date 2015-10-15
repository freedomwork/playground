using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;
using System;
using System.Runtime.InteropServices;

namespace YiJiaSoft.Controls
{
    /// <summary>
    /// Description of CustomTabControl.
    /// </summary>
    [ToolboxBitmap(typeof(TabControl))]
    public class MyTabControl : TabControl
    {

        public MyTabControl()
            : base()
        {
            if (this._DisplayManager.Equals(TabControlDisplayManager.Custom))
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                this.Padding = new Point(9, 0);
            }

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, false);
            this.SetStyle(ControlStyles.Selectable, true);      


            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.Selectable, true);
            //this.SetStyle(ControlStyles.StandardClick, true);
            //this.SetStyle(ControlStyles.StandardDoubleClick, true);
            //this.SetStyle(ControlStyles.DoubleBuffer, true);
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
            //this.SetStyle(ControlStyles.Opaque, true);
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.UpdateStyles();



            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
            //this.UpdateStyles();
            this.ResizeRedraw = true;
        }

        TabControlDisplayManager _DisplayManager = TabControlDisplayManager.Custom;

        [System.ComponentModel.DefaultValue(typeof(TabControlDisplayManager), "Custom")]
        public TabControlDisplayManager DisplayManager
        {
            get
            {
                return this._DisplayManager;
            }
            set
            {
                if (this._DisplayManager != value)
                {
                    if (this._DisplayManager.Equals(TabControlDisplayManager.Custom))
                    {
                        this.SetStyle(ControlStyles.UserPaint, true);
                        this.Padding = new Point(9, 0);
                    }
                    else
                    {
                        this.ItemSize = new Size(0, 0);
                        this.Padding = new Point(6, 3);
                        this.SetStyle(ControlStyles.UserPaint, false);
                    }
                }
            }
        }

        private Color _pageBorderColor = ThemedColors.ToolBorder;

        [DefaultValue(typeof(Color), "ToolBorder"), Description("控件TabPage边框颜色")]
        public Color PageBorderColor
        {
            get { return _pageBorderColor; }
            set
            {
                if (!_pageBorderColor.Equals(value))
                {
                    _pageBorderColor = value;
                }
            }
        }

        // 重写属性
        public new Size ItemSize
        {
            get { return base.ItemSize; }
            set {
                    base.ItemSize = new Size(0, 20);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (this.DesignMode == true)
            {
                LinearGradientBrush backBrush = new LinearGradientBrush(
                            this.Bounds,
                            SystemColors.ControlLightLight,
                            SystemColors.ControlLight,
                            LinearGradientMode.Vertical);
                pevent.Graphics.FillRectangle(backBrush, this.Bounds);
                backBrush.Dispose();
            }
            else
            {
                this.PaintTransparentBackground(pevent.Graphics, this.ClientRectangle);
            }
        }

        protected void PaintTransparentBackground(Graphics g, Rectangle clipRect)
        {
            if ((this.Parent != null))
            {
                clipRect.Offset(this.Location);
                PaintEventArgs e = new PaintEventArgs(g, clipRect);
                GraphicsState state = g.Save();
                g.SmoothingMode = SmoothingMode.HighSpeed;
                try
                {
                    g.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);
                }

                finally
                {
                    g.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }
            else
            {
                System.Drawing.Drawing2D.LinearGradientBrush backBrush = new System.Drawing.Drawing2D.LinearGradientBrush(this.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                g.FillRectangle(backBrush, this.Bounds);
                backBrush.Dispose();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.SuspendLayout();
            //   Paint the Background
            this.PaintTransparentBackground(e.Graphics, this.ClientRectangle);

            this.PaintAllTheTabs(e);
            this.PaintTheTabPageBorder(e);
            this.PaintTheTabPageBackGround(e);
            this.PaintTheSelectedTab(e);
            this.ResumeLayout();
        }

        private void PaintAllTheTabs(System.Windows.Forms.PaintEventArgs e)
        {
            if (this.TabCount > 0)
            {
                for (int index = 0; index < this.TabCount; index++)
                {
                    this.PaintTab(e, index);
                }
            }
        }

        private void PaintTab(System.Windows.Forms.PaintEventArgs e, int index)
        {
            GraphicsPath path = this.GetPath(index);
            this.PaintTabBackground(e.Graphics, index, path);
            this.PaintTabBorder(e.Graphics, index, path);
            this.PaintTabText(e.Graphics, index);
            this.PaintTabImage(e.Graphics, index);
        }

        // tab背景颜色
        private void PaintTabBackground(System.Drawing.Graphics graph, int index, System.Drawing.Drawing2D.GraphicsPath path)
        {
            Rectangle rect = this.GetTabRect(index);
            // 未选中状态为系统默认的渐变颜色
            System.Drawing.Brush buttonBrush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    rect,
                    SystemColors.ControlLightLight,
                    SystemColors.ControlLight,
                    LinearGradientMode.Vertical);

            if (index == this.SelectedIndex)
            {
                // 设置选中状态的tab背景颜色和tabpage背景颜色相同
                buttonBrush = new System.Drawing.SolidBrush(this.TabPages[index].BackColor);
            }

            graph.FillPath(buttonBrush, path);
            buttonBrush.Dispose();
        }

        // 绘制tab的边框
        private void PaintTabBorder(System.Drawing.Graphics graph, int index, System.Drawing.Drawing2D.GraphicsPath path)
        {
            Pen borderPen = new Pen(SystemColors.ControlDark);

            if (index == this.SelectedIndex)
            {
                borderPen = new Pen(ThemedColors.ToolBorder);
            }
            graph.DrawPath(borderPen, path);
            borderPen.Dispose();
        }

        // 绘制tab上的图片
        private void PaintTabImage(System.Drawing.Graphics graph, int index)
        {
            Image tabImage = null;
            if (this.TabPages[index].ImageIndex > -1 && this.ImageList != null)
            {
                tabImage = this.ImageList.Images[this.TabPages[index].ImageIndex];
            }
            else if (this.TabPages[index].ImageKey.Trim().Length > 0 && this.ImageList != null)
            {
                tabImage = this.ImageList.Images[this.TabPages[index].ImageKey];
            }
            if (tabImage != null)
            {
                Rectangle rect = this.GetTabRect(index);
                graph.DrawImage(tabImage, rect.Right - rect.Height - 4, 4, rect.Height - 2, rect.Height - 2);
            }
        }

        // 绘制tab上显示的文字
        private void PaintTabText(System.Drawing.Graphics graph, int index)
        {
            Rectangle rect = this.GetTabRect(index);
            Rectangle rect2 = new Rectangle(rect.Left + 8, rect.Top + 3, rect.Width - 6, rect.Height);

            string tabtext = this.TabPages[index].Text;

            System.Drawing.StringFormat format = new System.Drawing.StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;
            format.Trimming = StringTrimming.EllipsisCharacter;

            Brush forebrush = null;

            if (this.TabPages[index].Enabled == false)
            {
                forebrush = SystemBrushes.ControlDark;
            }
            else
            {
                forebrush = SystemBrushes.ControlText;
            }

            // 选中的tab加粗显示
            Font tabFont = this.Font;
            if (index == this.SelectedIndex)
            {
                tabFont = new Font(this.Font, FontStyle.Bold);
                rect2 = new Rectangle(rect.Left + 5, rect.Top + 3, rect.Width-6, rect.Height);
            }

            graph.DrawString(tabtext, tabFont, forebrush, rect2, format);
        }

        // 绘制TabPage的边框
        private void PaintTheTabPageBorder(System.Windows.Forms.PaintEventArgs e)
        {
            if (this.TabCount > 0)
            {
                Rectangle borderRect = this.TabPages[0].Bounds;
                borderRect.Inflate(1, 1);
                Rectangle rect = this.GetTabRect(this.SelectedIndex);
                Pen borderPen = new Pen(_pageBorderColor);
                // 如此拼凑主要是为了解决背景透明的问题
                Point[] lines = { 
                                 new Point(rect.Right-2,borderRect.Top),                 // 起点
                                 new Point(borderRect.Right,borderRect.Top),         // 水平右
                                 new Point(borderRect.Right,borderRect.Bottom),   // 右
                                 new Point(borderRect.Left,borderRect.Bottom),     // 下
                                 new Point(borderRect.Left,borderRect.Top),          // 左
                                 new Point(rect.Left+1,borderRect.Top)                  // 水平左
                                };
                e.Graphics.DrawLines(borderPen, lines);
                //ControlPaint.DrawBorder(e.Graphics, borderRect, ThemedColors.ToolBorder, ButtonBorderStyle.Solid);
            }
        }

        // 绘制TabPage背景
        private void PaintTheTabPageBackGround(System.Windows.Forms.PaintEventArgs e)
        {
            Rectangle backRect = this.TabPages[0].Bounds;
            Brush backBrush = new System.Drawing.SolidBrush(this.TabPages[this.SelectedIndex].BackColor);
            e.Graphics.FillRectangle(backBrush, backRect);
        }

        // 设置选中的tab颜色和选中tabpage的颜色一致，通过一条细线遮挡住不一致的边框线条
        // 同时在tab顶部显示一条细线
        private void PaintTheSelectedTab(System.Windows.Forms.PaintEventArgs e)
        {
            if(this.SelectedIndex == -1)
                return;

            Rectangle selrect;
            int selrectRight = 0;

            // 2像素细线在底部遮挡其他线条
            selrect = this.GetTabRect(this.SelectedIndex);
            selrectRight = selrect.Right;
            Pen selectedPen = new Pen(this.TabPages[this.SelectedIndex].BackColor,2F);
            e.Graphics.DrawLine(selectedPen, new Point(selrect.Left+2, selrect.Bottom+1), new Point(selrect.Right-2, selrect.Bottom+1));

            // 顶部美观的线条
            Brush lineBrush = new System.Drawing.SolidBrush(Color.FromArgb(67, 117, 170));
            System.Drawing.Drawing2D.GraphicsPath linePath = new System.Drawing.Drawing2D.GraphicsPath();
            linePath.Reset();
            linePath.AddLine(selrect.Left + 4, selrect.Top, selrect.Right - 2, selrect.Top);
            linePath.AddLine(selrect.Right-1, selrect.Top + 3, selrect.Left+1, selrect.Top + 3);
            e.Graphics.FillPath(lineBrush, linePath);

            // 释放
            linePath.Dispose();
            lineBrush.Dispose();
        }

        // 取得各个tab的绘制路径
        private System.Drawing.Drawing2D.GraphicsPath GetPath(int index)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.Reset();

            Rectangle rect = this.GetTabRect(index);
            int left = rect.Left + 1;
            int right = rect.Right - 2;
            int round = 3;   // 稍微实现一点儿圆角效果
            path.AddLine(left, rect.Bottom, left, rect.Top+round);
            path.AddLine(left + round, rect.Top, right - round, rect.Top);
            path.AddLine(right, rect.Top + round, right, rect.Bottom);
            return path;
        }

        public enum TabControlDisplayManager
        {
            Default,
            Custom
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_SETFONT = 0x30;
        private const int WM_FONTCHANGE = 0x1d;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.OnFontChanged(EventArgs.Empty);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            IntPtr hFont = this.Font.ToHfont();
            SendMessage(this.Handle, WM_SETFONT, hFont, (IntPtr)(-1));
            SendMessage(this.Handle, WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero);
            this.UpdateStyles();
            this.ItemSize = new Size(0, this.Font.Height + 2);
        }

    }
    public class ThemedColors
    {
        #region "    Variables and Constants "
        private const string NormalColor = "NormalColor";
        private const string HomeStead = "HomeStead";
        private const string Metallic = "Metallic";
        private const string NoTheme = "NoTheme";
        private static Color[] _toolBorder;
        #endregion
        #region "    Properties "
        public static int CurrentThemeIndex
        {
            get
            {
                return ThemedColors.GetCurrentThemeIndex();
            }
        }
        public static string CurrentThemeName
        {
            get
            {
                return ThemedColors.GetCurrentThemeName();
            }
        }
        public static Color ToolBorder
        {
            get
            {
                return ThemedColors._toolBorder[ThemedColors.CurrentThemeIndex];
            }
        }
        #endregion
        #region "    Constructors "
        private ThemedColors()
        {
        }
        static ThemedColors()
        {
            Color[] colorArray1;
            colorArray1 = new Color[] { Color.FromArgb(127, 157, 185), Color.FromArgb(164, 185, 127), Color.FromArgb(165, 172, 178), Color.FromArgb(132, 130, 132) };
            ThemedColors._toolBorder = colorArray1;
        }
        #endregion
        private static int GetCurrentThemeIndex()
        {
            int theme = (int)ColorScheme.NoTheme;
            if (VisualStyleInformation.IsSupportedByOS && VisualStyleInformation.IsEnabledByUser && Application.RenderWithVisualStyles)
            {
                switch (VisualStyleInformation.ColorScheme)
                {
                    case NormalColor:
                        theme = (int)ColorScheme.NormalColor;
                        break;
                    case HomeStead:
                        theme = (int)ColorScheme.HomeStead;
                        break;
                    case Metallic:
                        theme = (int)ColorScheme.Metallic;
                        break;
                    default:
                        theme = (int)ColorScheme.NoTheme;
                        break;
                }
            }
            return theme;
        }
        private static string GetCurrentThemeName()
        {
            string theme = NoTheme;
            if (VisualStyleInformation.IsSupportedByOS && VisualStyleInformation.IsEnabledByUser && Application.RenderWithVisualStyles)
            {
                theme = VisualStyleInformation.ColorScheme;
            }
            return theme;
        }
        public enum ColorScheme
        {
            NormalColor = 0,
            HomeStead = 1,
            Metallic = 2,
            NoTheme = 3
        }
    }
}