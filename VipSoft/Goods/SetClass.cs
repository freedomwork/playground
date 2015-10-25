using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    /// <summary>
    /// 用于处理分类窗体关闭的委托
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public delegate void ClassFormClosedHandler(string s);

    public partial class SetClass : BaseForm
    {
        /// <summary>
        /// 商品分类窗体关闭事件
        /// </summary>
        public event ClassFormClosedHandler ClassFormClosed;
        /// <summary>
        /// 全部分类列表
        /// </summary>
        private DataTable dtClass;

        public SetClass()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  将分类绑定到树上
        /// </summary>
        private void BindClass()
        {
            VipSoft.BLL.GoodsClass gclass = new VipSoft.BLL.GoodsClass();
            dtClass = gclass.GetList("[ShopID]=" + PublicState.Master.ShopID).Tables[0];

            this.treeView_Class.Nodes.Clear();

            Function.BindGoodsClass(this.treeView_Class, dtClass);
        }

        private void SetClass_Load(object sender, EventArgs e)
        {
            BindClass();
        }

        private void treeView_Class_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Node.Text == "全部产品")
                    return;
                this.label_ID.Text = e.Node.Name.Replace("class_", "");
                this.textBox_Parent.Text = e.Node.Parent != null ? e.Node.Parent.Text : "根类别";
                this.textBox_ClassName.Text = e.Node.Text;

                this.button_Add.Text = "修改类别";
                this.groupBox_manage.Text = "修改类别";
            }
            else if (e.Button == MouseButtons.Right)
            {
                treeView_Class.SelectedNode = e.Node;

                Point point = treeView_Class.PointToClient(Cursor.Position);
                this.contextMenuStrip_Right.Show(treeView_Class, point);

                if (e.Node.Name == "class_0")
                {
                    this.toolStripMenuItem_Edit.Enabled = false;
                    this.toolStripMenuItem_Delete.Enabled = false;
                }
                else
                {
                    this.toolStripMenuItem_Edit.Enabled = true;
                    this.toolStripMenuItem_Delete.Enabled = true;
                }
            }
        }

        private void toolStripMenuItem_Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            TreeNode node = this.treeView_Class.SelectedNode;
            int id = int.Parse(node.Name.Replace("class_", ""));
            switch (item.Name)
            {
                case "toolStripMenuItem_Edit":
                    this.label_ID.Text = node.Name.Replace("class_", "");
                    this.textBox_Parent.Text = node.Parent != null ? node.Parent.Text : "根类别";
                    this.textBox_ClassName.Text = node.Text;

                    this.button_Add.Text = "修改类别";
                    this.groupBox_manage.Text = "修改类别";

                    break;
                case "toolStripMenuItem_Delete":
                    if (this.treeView_Class.SelectedNode.Text == "根类别")
                        return;
                    DialogResult res = MessageBox.Show("您确定要删除这个分类么？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (res == DialogResult.Yes)
                    {
                        VipSoft.BLL.GoodsClass gc = new VipSoft.BLL.GoodsClass();
                        DataTable listClass = gc.GetList("[ShopID]="+PublicState.Master.ShopID).Tables[0];
                        CheckHasGoods hasGoods = new CheckHasGoods();
                        if (hasGoods.Exist(listClass, id.ToString()) != 0)
                        {
                            MessageBox.Show("当前分类下面还有商品，要删除分类，请首先删除该分类下面的全部商品。");
                            return;
                        }
                        if (gc.Delete(id))
                        {
                            MessageBox.Show("分类删除成功。");
                            // 移除节点
                            node.Remove();
                            // 写入日志
                            VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                            log.Add(new VipSoft.Model.SysLog(PublicState.Master, "商品分类管理", 
                                string.Format("删除分类成功，名称：{0}父类：{1}", this.textBox_ClassName.Text, this.textBox_Parent.Text),
                                DateTime.Now));
                        }
                        else
                            MessageBox.Show("删除失败，请重试。");
                    }
                    break;
                case "toolStripMenuItem_Add":
                    this.label_ParentID.Text = id.ToString();

                    //查询该类别下是否有产品，如果有则不能再增加子类别
                    DataSet ds = new VipSoft.BLL.Goods().GetList("ClassId=" + id + "");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("该类别下已有产品！不能再添加子类别");
                        return;
                    }

                    this.textBox_Parent.Text = node.Text;
                    this.textBox_ClassName.Text = "新类别";
                    this.button_Add.Text = "增加分类";
                    this.groupBox_manage.Text = "增加下级分类";
                    break;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            VipSoft.BLL.GoodsClass gc = new VipSoft.BLL.GoodsClass();
            if (this.textBox_ClassName.Text == "新类别" || this.textBox_ClassName.Text == "")
            {
                MessageBox.Show("请输入分类名称。");
                return;
            }
            if (this.label_ID.Text == "label_ID" && this.label_ParentID.Text == "label_ParentID")
            {
                MessageBox.Show("请先在左侧列表中选择对应操作！");
                return;
            }
            if (this.button_Add.Text == "增加分类")
            {
                if (this.label_ParentID.Text == "")
                {
                    MessageBox.Show("请先在左侧列表中选择对应操作！");
                    return;
                }
                VipSoft.Model.GoodsClass model = new Model.GoodsClass();
                model.ClassName = this.textBox_ClassName.Text;
                model.ParentID = int.Parse(this.label_ParentID.Text);
                model.ShopID = PublicState.Master.ShopID;
                model.ShopName = PublicState.Master.ShopName;
                gc.Add(model);
                // 写入日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master, "商品分类管理", 
                    string.Format("增加分类成功，名称：{0}父类：{1}", this.textBox_ClassName.Text, this.textBox_Parent.Text),
                    DateTime.Now));
                // 文本框清空
                this.label_ID.Text = "";
                this.label_ParentID.Text = "";
                this.textBox_Parent.Text = "";
                this.textBox_ClassName.Text = "";
            }
            else
            {
                VipSoft.Model.GoodsClass gci = new VipSoft.Model.GoodsClass();
                gci.ClassName = this.textBox_ClassName.Text.Trim();
                gci.ID = int.Parse(this.label_ID.Text);
                gc.Update(gci);
                // 写入日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master, "商品分类管理", 
                    string.Format("修改分类成功，名称：{0}父类：{1}", this.textBox_ClassName.Text, this.textBox_Parent.Text),
                    DateTime.Now));
            }
            // 重新绑定
            BindClass();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
