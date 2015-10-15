using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace YiJiaSoft.Controls
{
    public class MyNumberTextBox : TextBox
    {
        public new string Text
        {
            get {
                if (base.Text == "")
                    return "0";
                else
                    return base.Text;
            }
            set {
                base.Text = value;
            }
        }

        public MyNumberTextBox() : base()
        {
            this.KeyPress += new KeyPressEventHandler(MyNumberTextBox_KeyPress);
            this.Enter += new EventHandler(MyNumberTextBox_Enter);
            this.Leave += new EventHandler(MyNumberTextBox_Leave);
        }

        void MyNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (base.Text == "")
                base.Text = "0";
        }

        void MyNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (base.Text == "0")
            {
                base.Text = "";
            }
        }

        void MyNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // 全角自动转换半角
            if ((int)e.KeyChar >= 65296 && (int)e.KeyChar <= 65305)
            {
                e.KeyChar = (char)((int)e.KeyChar - 65248);
            }

            //if (e.KeyChar < 48 || e.KeyChar > 57)
            //{
            //    e.Handled = true;
            //}
            //if ((int)e.KeyChar >= 65296 && (int)e.KeyChar <= 65305)
            //{
            //    e.KeyChar = (char)((int)e.KeyChar - 65248);
            //}

            //if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != (int)Keys.Delete && e.KeyChar != (int)Keys.Back)
            //{
            //    e.Handled = true;
            //}
        }

    }
}
