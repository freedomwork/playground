using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Maticsoft.Common;

namespace VipSoft
{
    public delegate void DictionaryChangedHandler(string units);

    public partial class Dictionary : BaseForm
    {
        public event DictionaryChangedHandler DictionaryChanged;

        INIFile ini = new INIFile();
        string dicStr = "";

        public Dictionary()
        {
            InitializeComponent();
        }

        // 加载
        private void Dictionary_Load(object sender, EventArgs e)
        {
            dicStr = ini.IniReadValue("config", "GoodsUnit");
            this.textBox_Dictionary.Text = dicStr.Replace("|", "\r\n");
        }

        // 保存数据
        private void myButton1_Click(object sender, EventArgs e)
        {
            string[] str = Regex.Split(this.textBox_Dictionary.Text,"\\r\\n");
            dicStr = "";
            foreach (string s in str)
            {
                if (s.Trim() == "")
                    continue;

                dicStr += s + "|";
            }
            dicStr = dicStr.Trim("|".ToCharArray());
            ini.IniWriteValue("config", "GoodsUnit", dicStr);
            if (DictionaryChanged != null)
                DictionaryChanged(dicStr);
            this.Close();
        }

        // 关闭
        private void myButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
