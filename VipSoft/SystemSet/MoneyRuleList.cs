using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VipSoft.Model;

namespace VipSoft.SystemSet
{
    public partial class MoneyRuleList : BaseForm
    {

        int pageSize = 500;
        int currentPage = 0;
        int resCount = 0;
        int pageCount = 0;

        int currentId = 0;

        String condition = "";

        public MoneyRuleList()
        {
            InitializeComponent();
        }

        private void MoneyRuleList_Load(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            VipSoft.BLL.MoneyRule mrBll = new BLL.MoneyRule();
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


        private void saveBtn_Click(object sender, EventArgs e)
        {
            VipSoft.BLL.MoneyRule mrBll = new BLL.MoneyRule();

            MoneyRule mrModel = new MoneyRule();
            mrModel.Name = this.f_name.Text.ToString();
            mrModel.OneHour = decimal.Parse(this.f_1hour.Text);
            mrModel.SecondHour = decimal.Parse(this.f_2hour.Text);
            mrModel.ThirdHour = decimal.Parse(this.f_3hour.Text);
            mrModel.ThanTime = int.Parse(this.f_thantime.Text);

            if (this.currentId == 0)
            {
                mrBll.Add(mrModel);
                MessageBox.Show("新增消费规则成功!");
            }
            else
            {
                mrBll.Update(mrModel);
                MessageBox.Show("修改消费规则成功!");
            }
        }
    }
}
