using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MasterLogin();
        }

        void MasterLogin()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                MessageBox.Show("请输入操作员账号");
                this.txtUserName.Focus();
                this.txtUserName.Select();
                return;
            }

            VipSoft.BLL.Master bllMaster = new BLL.Master();
            VipSoft.Model.Master modelMaster = bllMaster.GetModel(this.txtUserName.Text.Trim());
            if (modelMaster==null||modelMaster.Password!=this.password.Text.Trim())
            {
                MessageBox.Show("操作账号或操作密码错误，请核对后重试。");
                return;
            }

            this.Hide();
            Main mainForm = new Main();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUserName.Text = "admin";
            this.password.Focus();
            this.password.Select();
        }
    }
}
