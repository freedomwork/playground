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
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            mrModel.OneHourMoney = decimal.Parse(this.f_1hour.Text);
            mrModel.SecondHourMoney = decimal.Parse(this.f_2hour.Text);
            mrModel.ThirdHourMoney = decimal.Parse(this.f_3hour.Text);
            mrModel.ThanTime = int.Parse(this.f_thantime.Text);

            if (this.currentId == 0)
            {
                mrBll.Add(mrModel);
                MessageBox.Show("新增消费规则成功!");
                BindList();
            }
            else
            {
                mrModel.ID = this.currentId;
                mrBll.Update(mrModel);
                MessageBox.Show("修改消费规则成功!");
                BindList();
            }
        }

 
        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.currentId = 0;
            this.f_thantime.Text = null;
            this.f_name.Text = null;
            this.f_1hour.Text = null;
            this.f_2hour.Text = null;
            this.f_3hour.Text = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String id = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["id"].Value.ToString();
            if (id != null && id != "")
            {
                int cid = int.Parse(id);
                VipSoft.BLL.MoneyRule mrBll = new BLL.MoneyRule();
                MoneyRule mrModel = mrBll.GetModel(cid);
                this.f_2hour.Text = mrModel.SecondHourMoney.ToString();
                this.f_1hour.Text = mrModel.OneHourMoney.ToString();
                this.f_3hour.Text = mrModel.ThirdHourMoney.ToString();
                this.f_name.Text = mrModel.Name.ToString();
                this.f_thantime.Text = mrModel.ThanTime.ToString();
                this.currentId = cid;
            }
        }


        private void delBtn_Click(object sender, EventArgs e)
        {
            if (this.currentId > 0)
            {
                VipSoft.BLL.MoneyRule mrBll = new BLL.MoneyRule();
                bool flag = mrBll.Delete(this.currentId);
                if (flag)
                {
                    MessageBox.Show("删除记录成功!");
                    BindList();
                }
                else
                {
                    MessageBox.Show("删除记录失败!");
                }
            }
            else
            {
                MessageBox.Show("请选择一条记录!");
            }
        }
    }
}
