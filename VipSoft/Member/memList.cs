﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class memList : BaseForm
    {

        int pageSize = 500;
        int currentPage = 0;
        int resCount = 0;
        int pageCount = 0;

        string[] condition;

        public memList()
        {
            InitializeComponent();
        }

        private void memList_Load(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            VipSoft.BLL.MemCard memCard = new BLL.MemCard();
            DataSet ds = memCard.GetList(pageSize, currentPage, out resCount, condition);
            this.dataGridView_List.DataSource = ds.Tables[0];

            for (int i = 0; i < dataGridView_List.Rows.Count; i++)
            {
                dataGridView_List.Rows[i].Cells[0].Value = false;
            }

            BindPage();
        }

        /// <summary>
        /// 绑定分页
        /// </summary>
        private void BindPage()
        {
            this.pager1.PageSize = pageSize;
            this.pager1.CurrentPage = currentPage;
            this.pager1.RecordCount = resCount;
            this.pager1.PagerBind();
        }


        //删除会员操作
        private void delMem()
        {
            //那个选择的条数不是1条时返回
            if (this.dataGridView_List.SelectedRows.Count != 1)
                return;

            //得到所选记录的主键
            int memId = int.Parse(this.dataGridView_List.SelectedRows[0].Cells["ID"].Value.ToString());
            string memCardId = this.dataGridView_List.SelectedRows[0].Cells["cardId"].Value.ToString();
            string memName = this.dataGridView_List.SelectedRows[0].Cells["MemName"].Value.ToString();
            DialogResult dRes = MessageBox.Show("您确定要删除此会员么？此操作不可恢复。", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dRes == DialogResult.No)
                return;

            VipSoft.BLL.MemCard mCard = new VipSoft.BLL.MemCard();

            //查询该会员的记录，用于记录操作日志
            VipSoft.Model.MemCard memModel = mCard.GetModel(memId);
            if (mCard.Delete(memId))
            {
                // 记录日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master, "会员管理",
                    string.Format("删除会员，ID：{0}会员卡号：{1} 名称：{2}", memId.ToString(), memModel.CardID, memModel.Name),
                       DateTime.Now));
                // 提示
                MessageBox.Show("会员已被删除。");
                // 重新绑定
                BindList();
            }
        }

        //新增会员
        private void addMem()
        {
            memRegister memReg = new memRegister();
            memReg.ShowDialog();
            BindList();
        }


        private void menu_click(object sender, EventArgs e)
        {
            ToolStripButton item = (ToolStripButton)sender;
            switch (item.Name)
            {
                case "AddBtn":
                    addMem();
                    break;
                case "DelBtn":
                    delMem();
                    break;
            }
        }

        private void pager1_EventPaging(Vipsoft.Controls.EventPagingArg e)
        {
            currentPage = e.PageIndex;
            BindList();
            this.dataGridView_List.Focus();
        }
    }
}
