using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft.SystemSet
{
    public partial class Master : BaseForm
    {

        int pageSize = 500;
        int currentPage = 0;
        int resCount = 0;
        int pageCount = 0;

        int currentId = 0;

        String condition = "";

        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            loadDic();
            BindList();
        }

        private void BindList()
        {
            VipSoft.BLL.Master mrBll = new BLL.Master();
            DataSet ds = mrBll.GetList(pageSize, currentPage, out resCount, condition);
            this.dataGridView1.DataSource = ds.Tables[0];

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }

            BindPage();
        }

        private void BindPage()
        {
            this.pager1.PageSize = pageSize;
            this.pager1.CurrentPage = currentPage;
            this.pager1.RecordCount = resCount;
            this.pager1.PagerBind();
        }

        private void f_shopname_Click(object sender, EventArgs e)
        {
            SearchShop search = new SearchShop(this.f_shopid, this.f_shopname);
            search.ShowDialog();
        }

        private void f_shopname_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadDic()
        {
            this.f_issuper.Items.Add(new System.Collections.DictionaryEntry("是", 1));
            this.f_issuper.Items.Add(new System.Collections.DictionaryEntry("否", 2));
            this.f_issuper.DisplayMember = "key";
            this.f_issuper.ValueMember = "value";
            this.f_issuper.SelectedIndex = 0;
        }

        private void alButton1_Click(object sender, EventArgs e)
        {
            VipSoft.BLL.Master mBll = new BLL.Master();
            VipSoft.Model.Master mModel = new Model.Master();

            mModel.Account = this.f_account.Text.ToString();
            mModel.Password = this.f_password.Text.ToString();
            mModel.Name = this.f_name.Text.ToString();

            if (mBll.Add(mModel) > 0)
            {
                MessageBox.Show("新增记录成功!");

            }
        }



    }
}
