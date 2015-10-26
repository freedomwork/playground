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
    /// <summary>
    /// 产品列表刷新
    /// </summary>
    public delegate void GoodsListRefreshHandler();

    public partial class GoodsList : BaseForm
    {

        int pageSize = 500;
        int currentPage = 0;
        int resCount = 0;
        int pageCount = 0;


        // 产品分类
        DataTable listClass;
        string[] condition;

        public GoodsList()
        {
            InitializeComponent();
            this.dataGridView_List.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 绑定产品分类树形菜单
        /// </summary>
        private void BindTree()
        {
            VipSoft.BLL.GoodsClass gc = new VipSoft.BLL.GoodsClass();
            listClass = gc.GetList("ShopID="+PublicState.Master.ShopID).Tables[0];
            Function.BindGoodsClass(this.treeView_Class, listClass);
        }

        private void BindList()
        {
            VipSoft.BLL.Goods bllGoods = new BLL.Goods();
            DataSet ds = bllGoods.GetList(pageSize, currentPage, out resCount, condition);
            this.dataGridView_List.DataSource = ds.Tables[0];

            for (int i = 0; i < dataGridView_List.Rows.Count; i++)
            {
                dataGridView_List.Rows[i].Cells[0].Value = false;
            }

            DataTable dts = ds.Tables[0];
            int T = 0;       //库存数量
            int X = 0;       //销售数量
            decimal J = 0;   //进货金额
            decimal P = 0;   //销售金额
            for (int i = 0; i < dts.Rows.Count; i++)
            {
                int Tnum = int.Parse(dts.Rows[i]["Number"].ToString());
                int Xnum = int.Parse(dts.Rows[i]["SaleNumber"].ToString() == "" ? "0" : dts.Rows[i]["SaleNumber"].ToString());
                decimal JinhuoPrice = Math.Round(decimal.Parse(dts.Rows[i]["BuyPrice"].ToString()), 2);
                decimal XiaoshouPrice = Math.Round(decimal.Parse(dts.Rows[i]["Price"].ToString()), 2);
                T += Tnum;
                X += Xnum;
                J += Tnum * JinhuoPrice;
                P += Xnum * XiaoshouPrice;

            }

            this.lbl_TotalNum.Text = T.ToString();
            this.lbl_XiaoNum.Text = X.ToString();
            this.lbl_jinhuo.Text = J.ToString("￥0.00");
            this.lbl_xiaoshou.Text = P.ToString("￥0.00");

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

        private void GoodsList_Load(object sender, EventArgs e)
        {
            BindTree();
            BindList();
        }

        private void pager1_EventPaging(Vipsoft.Controls.EventPagingArg e)
        {
            currentPage = e.PageIndex;
            BindList();
        }

        /// <summary>
        /// 显示编辑会员信息窗口
        /// </summary>
        private void ShowEditForm(int goodsID)
        {
            GoodsPutIn goodsP = new GoodsPutIn();
            goodsP.GoodsListRefresh += new GoodsListRefreshHandler(BindList);
            goodsP.CurrentGoodsID = goodsID;
            goodsP.StartPosition = FormStartPosition.CenterParent;
            goodsP.ShowDialog(this);
        }

        // 删除记录
        private void DeleteItem()
        {
            if (this.dataGridView_List.SelectedRows.Count != 1)
                return;
            int goodsID = int.Parse(this.dataGridView_List.SelectedRows[0].Cells[1].Value.ToString());
            string goodsCode = this.dataGridView_List.SelectedRows[0].Cells[2].Value.ToString();
            string goodsName = this.dataGridView_List.SelectedRows[0].Cells[3].Value.ToString();
            DialogResult dRes = MessageBox.Show("您确定要删除此产品么？此操作不可恢复。注意：删除后此产品相关的消费数据统计会出现错乱", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dRes == DialogResult.No)
                return;
            VipSoft.BLL.Goods goods = new VipSoft.BLL.Goods();
            VipSoft.Model.Goods ginfo = goods.GetModel(goodsID);
            if (goods.Delete(goodsID))
            {
                    // 记录日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master, "产品管理",
                    string.Format("删除产品，ID：{0}编号：{1}名称：{2}库存：{3}销售量：{4}售价：{5}积分：{6}最低折扣：{7}", goodsID.ToString(), goodsCode, goodsName, ginfo.Number, ginfo.SaleNumber, ginfo.Price, ginfo.Point, ginfo.MinPercent),
                       DateTime.Now));
                    // 提示
                    MessageBox.Show("产品已被删除。");
                    // 重新绑定
                    BindList();
                }

        }

        private void toolStripButton_Item_Click(object sender, EventArgs e)
        {
            ToolStripButton item = (ToolStripButton)sender;
            switch (item.Name)
            {
                case "toolStripButton_Add":
                    GoodsPutIn goodsP = new GoodsPutIn();
                    goodsP.GoodsListRefresh += new GoodsListRefreshHandler(BindList);
                    goodsP.Show(this.Owner);
                    break;
                case "toolStripButton_Edit":
                    if (this.dataGridView_List.SelectedRows.Count == 1)
                    {
                        ShowEditForm(int.Parse(this.dataGridView_List.SelectedRows[0].Cells[1].Value.ToString()));
                    }
                    break;
                case "toolStripButton_Delete":
                    DeleteItem();
                    break;
                case "toolStripButton_DataInput":
                    DataInput dataInput = new DataInput();
                    dataInput.ShowDialog();
                    break;
                case "toolStripButton_Close":
                    this.Close();
                    break;
            }
        }

        private void dataGridView_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = dataGridView_List.Rows[e.RowIndex];
            ShowEditForm(int.Parse(row.Cells[1].Value.ToString()));
        }

        private void dataGridView_List_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex == -1)
                    return;

                DataGridViewRow row = dataGridView_List.Rows[e.RowIndex];
                row.Selected = true;
                Point point = dataGridView_List.PointToClient(Cursor.Position);
                this.contextMenuStrip_CellRight.Show(dataGridView_List, point);
            }
        }

        private void dataGridView_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                this.dataGridView_List.Rows[e.RowIndex].Selected = true;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Name)
            {
                // 编辑
                case "ToolStripMenuItem_Edit":
                    DataGridViewRow row = dataGridView_List.SelectedRows[0];
                    ShowEditForm(int.Parse(row.Cells[1].Value.ToString()));
                    break;
                // 删除
                case "toolStripMenuItem_Delete":
                    DeleteItem();
                    break;
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            string ConditionStr = " ShopID=" + PublicState.Master.ShopID.ToString();
            if (!string.IsNullOrEmpty(this.textBox_Key.Text.Trim()))
            {
                ConditionStr += " and GoodsCode = '" + this.textBox_Key.Text.Trim() + "' or NameCode like '%" + this.textBox_Key.Text.Trim() + "%' or [Name] like '%" + this.textBox_Key.Text.Trim() + "%'";
            }
            currentPage = 0;
            resCount = 0;
            BindList();
        }

        private void treeView_Class_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string name = e.Node.Name;
            if (name == "class_0")
                condition = null;
            else if (name.IndexOf("class_") != -1)
            {
                string classID = name.Substring(6, name.Length - 6);
                if (!Function.CheckIsLowestClass(listClass, classID))
                {
                    string[] newCondition = { "ClassID in(" + Function.GetChildClassListStr(listClass, classID) + ")" };
                    condition = newCondition;
                }
                else
                {
                    string[] newCondition = { "ClassID=" + classID };
                    condition = newCondition;
                }
            }

            currentPage = 0;
            resCount = 0;
            BindList();
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (query_Name.Text.Trim() != "")
                sb.Append("[Name] like '%" + query_Name.Text.Trim() + "%'");
            if (query_Class.SelectedIndex != 0)
            {
                string cla = query_Class.SelectedValue.ToString();
                if (sb.ToString() != "") sb.Append(" and ");
                if (Function.CheckIsLowestClass(listClass, cla))
                    sb.Append(" ClassID=" + cla);
                else
                    sb.Append(" ClassID in (" + Function.GetChildClassListStr(listClass, cla) + ")");
            }
            if (query_Point.Text != "")
            {
                if (!Maticsoft.Common.FormValidate.IsNumber(query_Point.Text))
                {
                    MessageBox.Show("按产品积分查询，请在文本框中输入表示积分数量的整数。");
                    this.query_Point.Focus();
                    this.query_Point.SelectAll();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" Point" + query_sign_Point.Text + query_Point.Text);
                }
            }
            if (query_Money.Text != "")
            {
                if (!Maticsoft.Common.FormValidate.IsDecimal(query_Money.Text))
                {
                    MessageBox.Show("按产品售价查询，请在文本框中输入表示售价的2位小数。");
                    this.query_Money.Focus();
                    this.query_Money.SelectAll();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" Price" + query_sign_Money.Text + query_Money.Text);
                }
            }
            if (query_Number.Text != "")
            {
                if (!Maticsoft.Common.FormValidate.IsNumber(query_Number.Text))
                {
                    MessageBox.Show("按产品库存查询，请在文本框中输入表示库存的整数。");
                    this.query_Number.Focus();
                    this.query_Number.SelectAll();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" Number" + query_sign_Number.Text + query_Number.Text);
                }
            }
            if (query_SaleNumber.Text != "")
            {
                if (!Maticsoft.Common.FormValidate.IsNumber(query_SaleNumber.Text))
                {
                    MessageBox.Show("按产品销售数量查询，请在文本框中输入表示数量的整数。");
                    this.query_SaleNumber.Focus();
                    this.query_SaleNumber.SelectAll();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(" SaleNumber" + query_sign_SaleNumber.Text + query_SaleNumber.Text);
                }
            }
            if (query_type1_Key.Text != "")
            {
                string field = ((DictionaryEntry)query_type1.SelectedItem).Value.ToString();
                if (field == "")
                {
                    MessageBox.Show("要按自定义字段查询，必须选择需要查询的字段。");
                    this.query_type1.Focus();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(field + " like '%" + query_type1_Key.Text + "%'");
                }
            }
            if (query_type2_Key.Text != "")
            {
                string field = ((DictionaryEntry)query_type2.SelectedItem).Value.ToString();
                if (field == "")
                {
                    MessageBox.Show("要按自定义字段查询，必须选择需要查询的字段。");
                    this.query_type2.Focus();
                }
                else
                {
                    if (sb.ToString() != "") sb.Append(" and ");
                    sb.Append(field + " like '%" + query_type2_Key.Text + "%'");
                }
            }

            string[] newCondition = { sb.ToString() };
            condition = newCondition;
            currentPage = 0;
            resCount = 0;
            BindList();
        }
    }
}
