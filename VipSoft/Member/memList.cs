using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VipSoft.Common;

namespace VipSoft
{

    //声明一个委托
    public delegate void memListRefreshHandler();




    public partial class memList : BaseForm
    {

        int pageSize = 500;
        int currentPage = 0;
        int resCount = 0;
        int pageCount = 0;

        // 卡片等级
        DataSet listLevel;

        // 查询条件
        string condition = "CardID <> '0'";

        public memList()
        {
            InitializeComponent();
        }

        private void memList_Load(object sender, EventArgs e)
        {

            loadDic();
            BindTree();
            BindList();
        }

        /// <summary>
        /// 绑定树形菜单
        /// </summary>
        private void BindTree()
        {
            VipSoft.BLL.CardLevel level = new VipSoft.BLL.CardLevel();
            listLevel = level.GetList("");
            TreeNode rootNode = new TreeNode("所有会员");
            rootNode.Name = "all_Level";
            foreach (DataRow dr in listLevel.Tables[0].Rows)
            {
                TreeNode node = new TreeNode(dr["LevelName"].ToString());
                node.Name = "level_" + dr["ID"].ToString();
                rootNode.Nodes.Add(node);
            }
            this.treeView_Class.Nodes.Add(rootNode);
            TreeNode rootNode_State = new TreeNode("所有会员");
            rootNode_State.Name = "all_state";

            TreeNode node1 = new TreeNode("正常");
            node1.Name = "state_" + ((int)CardState.Normal);
            rootNode_State.Nodes.Add(node1);

            TreeNode node2 = new TreeNode("锁定");
            node2.Name = "state_" + ((int)CardState.Locked);
            rootNode_State.Nodes.Add(node2);

            TreeNode node3 = new TreeNode("挂失");
            node3.Name = "state_" + ((int)CardState.Lossed);
            rootNode_State.Nodes.Add(node3);

            this.treeView_Class.Nodes.Add(rootNode_State);
            this.treeView_Class.ExpandAll();
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

        private void loadDic()
        {
            //this.cond_state.Items.Add(new System.Collections.DictionaryEntry("", -1));
            this.cond_state.Items.Add(new System.Collections.DictionaryEntry("正常", 0));
            this.cond_state.Items.Add(new System.Collections.DictionaryEntry("锁定", 1));
            this.cond_state.Items.Add(new System.Collections.DictionaryEntry("挂失", 2));
            this.cond_state.DisplayMember = "key";
            this.cond_state.ValueMember = "value";
            //this.cond_state.SelectedIndex = -1;
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

        private void updMem()
        {
            //选择的条数不是1条时返回
            if (this.dataGridView_List.SelectedRows.Count != 1)
                return;
            memRegister memReg = new memRegister();
            memReg.memListRefresh += new memListRefreshHandler(BindList);

            //得到所选记录的主键
            int memId = int.Parse(this.dataGridView_List.SelectedRows[0].Cells["ID"].Value.ToString());
            memReg.memId = memId;
            memReg.StartPosition = FormStartPosition.CenterParent;
            memReg.ShowDialog(this);

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

                case "UpdBtn":
                    updMem();
                    break;
            }
        }

        private void pager1_EventPaging(Vipsoft.Controls.EventPagingArg e)
        {
            currentPage = e.PageIndex;
            BindList();
            this.dataGridView_List.Focus();
        }

        private void treeView_Class_AfterSelect(object sender, TreeViewEventArgs e)
        {
            condition = "CardID <> '0'";
            string name = e.Node.Name;
            if (name.IndexOf("level_") != -1)
            {
                string level = name.Substring(6, name.Length - 6);
                condition += " and LevelID=" + level;
            }
            else if (name.IndexOf("state_") != -1)
            {
                string state = name.Substring(6, name.Length - 6);
                condition += " and State=" + state;
            }
            currentPage = 0;
            resCount = 0;
            BindList();
        }

        private void button_Select_Click(object sender, EventArgs e) {

            if (!string.IsNullOrEmpty(this.search_box.Text.Trim()))
            {
                condition += " and Mobile = '" + this.search_box.Text.Trim() + "' or cardid like '%" + this.search_box.Text.Trim() + "%' ";
            }
            else
            {
                condition = "CardID <> '0'";
            }
            currentPage = 0;
            resCount = 0;
            BindList();
        }

        private void gsearch_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (cond_name.Text.Trim() != "")
                sb.Append("[Name] like '%" + cond_name.Text.Trim() + "%'");
            if (cond_level.SelectedIndex >= 0)
            {
                if (sb.ToString() != "") sb.Append(" and ");
                sb.Append(" levelid ='" + cond_level.SelectedIndex + "' ");
            }
            if (cond_state.SelectedIndex >=0)
            {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" state ="  + cond_state.SelectedIndex);
            }

            if (cond_point.Text != "" && sign_point.Text != "")
            {
                if (!Maticsoft.Common.FormValidate.IsNumber(cond_point.Text))
                {
                    MessageBox.Show("按会员积分查询，请在文本框中输入表示积分的整数。");
                    this.cond_point.Focus();
                    this.cond_point.SelectAll();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" point" + sign_point.Text + int.Parse(cond_point.Text));
                }
            }

            if (cond_money.Text != "" && tab.Text != "")
            {
                if (!Maticsoft.Common.FormValidate.IsNumber(cond_money.Text))
                {
                    MessageBox.Show("按会员余额查询，请在文本框中输入表示余额的整数。");
                    this.cond_money.Focus();
                    this.cond_money.SelectAll();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" money" + tab.Text + int.Parse(cond_money.Text));
                }
            }

            if (cond_totalMoney.Text != "" && sign_totalMoney.Text != "")
            {
                if (!Maticsoft.Common.FormValidate.IsNumber(cond_totalMoney.Text))
                {
                    MessageBox.Show("按会员余额查询，请在文本框中输入表示余额的整数。");
                    this.cond_totalMoney.Focus();
                    this.cond_totalMoney.SelectAll();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" money" + sign_totalMoney.Text + int.Parse(cond_totalMoney.Text));
                }
            }

            condition = sb.ToString();
            currentPage = 0;
            resCount = 0;
            BindList();
        }

        private void gresret_Click(object sender, EventArgs e)
        {
            this.cond_state.SelectedIndex = -1;
            this.cond_level.SelectedIndex = -1;
            this.cond_name.Text = "";
            this.cond_money.Text = "";
            this.tab.Text = "";
            this.cond_point.Text = "";
            this.sign_point.Text = "";
            this.cond_totalMoney.Text = "";
            this.sign_totalMoney.Text = "";
        }

        private void dataGridView_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        
    }
}
