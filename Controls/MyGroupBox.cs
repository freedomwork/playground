using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using PushButtonState = System.Windows.Forms.VisualStyles.PushButtonState;
using System.ComponentModel;

namespace YiJiaSoft.Controls
{
    [ToolboxBitmap(typeof(GroupBox)), ToolboxItem(true), ToolboxItemFilter("System.Windows.Forms")]
    public partial class MyGroupBox : GroupBox
    {
        public MyGroupBox()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }

        private Color _borderColor = ThemedColors.ToolBorder;
        [DefaultValue(typeof(Color), "ToolBorder"), Description("边框颜色")]
        public virtual new Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                if (!_borderColor.Equals(value))
                {
                    _borderColor = value;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.SuspendLayout();

            System.Drawing.Rectangle rec = base.ClientRectangle;
            rec.Inflate(-1, -1);
            Size TextSize = e.Graphics.MeasureString(base.Text,base.Font).ToSize();
            Brush textBrush = new System.Drawing.SolidBrush(base.ForeColor);
            e.Graphics.DrawString(base.Text, base.Font, textBrush, new Point(10,0));

            Pen borderPen = new Pen(_borderColor);
            Point[] lines = {
                            new Point(10+TextSize.Width,rec.Top+5),
                            new Point(rec.Right,rec.Top+5),
                            new Point(rec.Right,rec.Bottom),
                            new Point(rec.Left,rec.Bottom),
                            new Point(rec.Left,rec.Top+5),
                            new Point(10,rec.Top+5)
                            };
            e.Graphics.DrawLines(borderPen, lines);

            this.ResumeLayout();
        }

    }
}
