using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace YiJiaSoft.Controls
{
    public partial class MyMoneyTextBox : TextBox
    {
        public new string Text
        {
            get {
                if (base.Text == "")
                    return "￥0.00";
                else
                    return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        public MyMoneyTextBox() : base()
        {
            this.KeyPress += new KeyPressEventHandler(MyMoneyTextBox_KeyPress);
            this.Enter += new EventHandler(MyMoneyTextBox_Enter);
            this.Leave += new EventHandler(MyMoneyTextBox_Leave);
        }

        void MyMoneyTextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "￥0.00")
            {
                tb.Text = "";
            }
        }

        void MyMoneyTextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string money = tb.Text.Replace("￥", "");
            decimal dec;
            if (decimal.TryParse(money, out dec))
                tb.Text = "￥" + dec.ToString("0.00");
            else
                tb.Text = "￥0.00";
        }

        void MyMoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //检测是否已经输入了小数点
            TextBox tb = (TextBox)sender;
            // 全角自动转换半角
            if ((int)e.KeyChar >= 65296 && (int)e.KeyChar <= 65305)
            {
                e.KeyChar = (char)((int)e.KeyChar - 65248);
            }
            string str = tb.SelectionLength > 0 ? tb.Text.Replace(tb.SelectedText, "") : tb.Text;
            bool IsContainsDot = str.Contains(".");
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
            if (tb.Text.Trim().Length == 0 && (e.KeyChar == 46))//如果第一个数输入是小数点
            {
                e.Handled = true;
            }
            if (IsContainsDot && (e.KeyChar == 46)) //如果输入了小数点，并且再次输入
            {
                e.Handled = true;
            }
            try
            {
                if ((e.KeyChar != 8) && (e.KeyChar != 46))
                {
                    if (tb.Text.Trim().Substring(0, 1) == "0" && tb.Text.Trim().Length == 1)
                    {   //检测第一个如果为0,接下来必须跟小数点
                        if (e.KeyChar != 46)
                        {
                            e.Handled = true;
                        }
                    }
                    //if (tb.Text.Trim().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries).GetValue(1).ToString().Length >= 2)
                    //{//如果小数后为三位时用户输入失效
                    //    e.Handled = true;
                    //}
                }
            }
            catch
            { }
        }
    }
}
