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

    }
}
