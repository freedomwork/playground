using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace VipSoft
{
    public partial class BaseFormNoSkin : Form
    {
        // HashTable中保存所有的当前窗体所定义的全部快捷键
        private static Hashtable hashKeys = new Hashtable();

        public BaseFormNoSkin()
        {
            this.Load += new EventHandler(BaseForm_Load);
        }

        /// <summary>
        /// 检测权限
        /// </summary>
        private bool CheckMasterAuthority()
        {
            // 检测当前操作员是否有操作当前窗体的权限
            string className = this.GetType().ToString();
            className = className.Substring(className.LastIndexOf(".") + 1);
            if (PublicState.Master != null)
            {
                return PublicState.Master.Authority.IndexOf("," + className + ",") == -1;
            }
            return false;
        }

        // 窗体加载时，自动调整窗体的坐标位置
        void BaseForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
                Function.SetStartPosition(this);
        }


        #region 隐藏父类的相关方法，在此处重写
        public new void Show(IWin32Window owner)
        {
            if (CheckMasterAuthority())
                base.Show(owner);
            else
                MessageBox.Show("对不起，操作权限不足。");
        }
        public new void Show()
        {
            if (CheckMasterAuthority())
                base.Show();
            else
                MessageBox.Show("对不起，操作权限不足。");
        }
        public new void ShowDialog(IWin32Window owner)
        {
            if (CheckMasterAuthority())
                base.ShowDialog(owner);
            else
                MessageBox.Show("对不起，操作权限不足。");
        }
        public new void ShowDialog()
        {
            if (CheckMasterAuthority())
                base.ShowDialog();
            else
                MessageBox.Show("对不起，操作权限不足。");
        }
        #endregion


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseFormNoSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(309, 210);
            this.Name = "BaseFormNoSkin";
            this.ResumeLayout(false);

        }
    }
}
