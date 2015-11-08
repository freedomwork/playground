using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using VipSoft.Common;

namespace VipSoft
{
    public delegate void ExpenseGoodsTreeShowHandler(DataTable dtClass, DataTable dtGoods);

    public partial class Expense : BaseForm
    {
        /// <summary>
        /// 当前会员卡号
        /// </summary>
        public string CurrentCardID = "";

        VipSoft.Model.MemCard memInfo;

        /// <summary>
        /// 是否是散客消费 
        /// </summary>
        private bool IsTravelerMember = false;

        /// <summary>
        /// 当前订单
        /// </summary>
        private VipSoft.Model.OrderLog order;

        /// <summary>
        /// 保存订单数据列表
        /// </summary>6
        public List<TempOrderInfo> listOrder = new List<TempOrderInfo>();

        /// <summary>
        /// 当前选择的产品
        /// </summary>
        private VipSoft.Model.Goods goodsInfo;

        string payInfo;                   // 支付信息（每种支付方式分别多少钱“|”分隔）

        // 临时变量
        decimal totalPrice = 0M;          // 实际总价
        decimal discountPrice = 0M;       // 折后总价
        int totalPoint = 0;          // 总共获得的积分（优先产品积分）
        int totalNumber = 0;          // 总数量

        public Expense()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 检查当前是否为可用订单
        /// </summary>
        /// <returns></returns>
        private bool CheckOrder()
        {
            if ((memInfo == null && !IsTravelerMember) || listOrder == null || listOrder.Count == 0)
            {
                MessageBox.Show("当前没有可用订单。");
                return false;
            }
            if (!IsTravelerMember && memInfo.State != 0)
            {
                string s = memInfo.State == 1? "锁定" : "挂失";
                MessageBox.Show("当前会员状态为：" + s + "，此状态会员将无法进行消费。");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 生成订单号
        /// </summary>
        /// <returns></returns>
        private string CreateOrderCode()
        {
            return DateTime.Now.ToString("yyMMddhhssmmff");
        }


                // 确认结算时
        // 订单表中插入记录、订单详细表、账户金额积分处理
        // 系统日志
        void exp_ExpenseResultSelected(OrderPayType expType, decimal payMoney, decimal payCard, decimal payCash, decimal payCredit, decimal payVoucher, decimal moneyZero)
        {
            string orderCode = CreateOrderCode();
            payInfo = payCard + "|" + payCash + "|" + payCredit + "|" + payVoucher;
            // 如果修改了金额，积分需要重新计算一下的
            int point = totalPoint;

            List<VipSoft.Model.OrderDetail> ListDetail = new List<VipSoft.Model.OrderDetail>();
            VipSoft.Model.OrderDetail detail;

            foreach (TempOrderInfo temp in listOrder)
            {
                detail = new VipSoft.Model.OrderDetail();
                detail.OrderCode=orderCode;
                detail.GoodsID=temp.GInfo.ID;
                detail.GoodsCode=temp.GInfo.GoodsCode;
                detail.GoodsName=temp.GInfo.Name;
                detail.OrderCode=orderCode;
                detail.Number=temp.Number;
                detail.Percent=temp.Discount;
                detail.IsService=temp.GInfo.GoodsType==(byte)0?true:false;
                detail.Price=temp.GInfo.Price;
                detail.DiscountPrice=temp.DiscountPrice;
                ListDetail.Add(detail);
            }
            VipSoft.BLL.OrderLog oLog = new VipSoft.BLL.OrderLog();
            bool ok;
            string logStrType, logStrOk, logStrErr;
            if (IsTravelerMember)
            {
                order = new Model.OrderLog();
                order.OrderCode = orderCode;
                order.OrderType = 0;
                order.MemID = 59;
                order.MemName = "散客消费";
                order.CardID = "0";
                order.CreateDateTime = DateTime.Now;
                order.DisCountMoney = discountPrice;
                order.MasterID = PublicState.Master.ID;
                order.MasterName = PublicState.Master.Name;
                order.PayInfo = payInfo;
                order.PayType = (int)expType;
                order.Point = totalPoint;
                order.ShopID = PublicState.Master.ShopID;
                order.ShopName = PublicState.Master.ShopName;
                order.TotalMoney = totalPrice;
                order.TotalNumber = totalNumber;

                ok = oLog.Add(order, ListDetail);

                logStrType = "散客消费";
                logStrOk = string.Format("消费成功，订单号：{0}消费金额：{1}", order.OrderCode, order.DisCountMoney);
                logStrErr = string.Format("消费失败，消费金额：{0}", order.DisCountMoney);
            }
            else
            {
                order = new Model.OrderLog();
                order.OrderCode = orderCode;
                order.OrderType = 0;
                order.MemID = memInfo.ID;
                order.MemName = memInfo.Name;
                order.CardID = memInfo.CardID;
                order.CreateDateTime = DateTime.Now;
                order.DisCountMoney = discountPrice;
                order.MasterID = PublicState.Master.ID;
                order.MasterName = PublicState.Master.Name;
                order.PayInfo = payInfo;
                order.PayType = (int)expType;
                order.Point = totalPoint;
                order.TotalMoney = totalPrice;
                order.TotalNumber = totalNumber;
                order.ShopID = PublicState.Master.ShopID;
                order.ShopName = PublicState.Master.ShopName;

                ok = oLog.Add(order, ListDetail);
                if (ok)
                {
                    VipSoft.BLL.MemCard bllMemCard = new BLL.MemCard();
                    VipSoft.BLL.PointLog bllPointLog = new BLL.PointLog();
                    memInfo.Point += totalPoint;
                    memInfo.TotalMoney += discountPrice;
                    memInfo.LastTime = DateTime.Now;
                    memInfo.Money -= payCard;
                    bllMemCard.Update(memInfo);
                    memInfo = bllMemCard.GetModel(memInfo.ID);

                    VipSoft.Model.PointLog modelPointLog = new Model.PointLog();
                    modelPointLog.CardID = memInfo.CardID;
                    modelPointLog.CreateDateTime = DateTime.Now;
                    modelPointLog.MemName = memInfo.Name;
                    modelPointLog.Point = totalPoint;
                    modelPointLog.ShopID = PublicState.Master.ShopID;
                    modelPointLog.ShopName = PublicState.Master.ShopName;
                    modelPointLog.Type = (int)PointLogType.OrderPoint;
                    bllPointLog.Add(modelPointLog);
                }

                logStrType = "会员消费";
                logStrOk = string.Format("消费成功，订单号：{0}会员卡号：{1}姓名：{2}消费金额：{3}所得积分：{4}付费方式：{5}",
                    order.OrderCode, order.CardID, order.MemName, order.DisCountMoney, order.Point, order.PayType.ToString());
                logStrErr = string.Format("消费失败，会员卡号：{0}姓名：{1}消费金额：{2}所得积分：{3}付费方式：{4}",
                    order.CardID, order.MemName, order.DisCountMoney, order.Point, order.PayType.ToString());
            }

            if (ok)
            {
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master, logStrType, logStrOk, DateTime.Now));

                // 更新当前会员的财务信息，因为打印的时候和更新等级的时候都需要显示出来
                if (!IsTravelerMember)
                {
                    memInfo = new VipSoft.BLL.MemCard().GetModel(memInfo.ID);
                    Function.UpdateMemberLevel(1, memInfo);
                }
                MessageBox.Show("消费成功。");

                // 清除数据
                this.label_OTMoney.Text = "";
                this.label_OTMoney2.Text = "";
                this.label_OTNumber.Text = "";
                this.label_OTPoint.Text = "";
                this.label_OTActivity.Text = "";
                listOrder = new List<TempOrderInfo>();
                order = null;
                this.dataGridView_List.Rows.Clear();
                ClearFormText();
                memInfo = null;
            }
            else
            {
                MessageBox.Show("系统错误导致消费失败，请重试。");
                // 记录日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master, logStrType,  logStrErr, DateTime.Now));
            }
        }

        private void button_Expense_Click(object sender, EventArgs e)
        {
            if (!CheckOrder())
                return;
            ExpResult exp = new ExpResult(listOrder, discountPrice, IsTravelerMember, memInfo);
            exp.ExpenseResultSelecteds += new ExpenseResultSelectedHandlers(exp_ExpenseResultSelected);
            exp.ShowDialog();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 清除label的初始数据
        /// </summary>
        private void ClearFormText()
        {
            this.label_GName.Text = "";
            this.label_GNumber.Text = "";
            this.label_GPoint.Text = "";
            this.label_GPrice.Text = "";
            this.label_Guid.Text = "";
            this.label_MemLevel.Text = "";
            this.label_MemMoney.Text = "";
            this.label_MemName.Text = "";
            this.label_MemPoint.Text = "";
            this.label_MemTotalMoney.Text = "";
            this.label_OTMoney.Text = "￥0.00";
            this.label_OTMoney2.Text = "￥0.00";
            this.label_OTNumber.Text = "0";
            this.label_OTPoint.Text = "0";
            this.label_OTActivity.Text = "";
            this.txt_remark.Text = "";
        }

        /// <summary>
        /// 绑定会员基本信息
        /// 在绑定会员基本信息时，自动读取出当前会员级别所能享受到的打折折扣率，并记录下来。
        /// </summary>
        private void BindMemberMsg()
        {
            this.searchMember1.CardID = memInfo.CardID;
            this.label_MemName.Text = memInfo.Name;
            this.label_MemMoney.Text = memInfo.Money.ToString("￥0.00");
            this.label_MemPoint.Text = memInfo.Point.ToString();
            this.label_MemTotalMoney.Text = memInfo.TotalMoney.ToString("￥0.00");

            this.label_MemLevel.Text = Function.LevelIDToName((int)memInfo.LevelID) + "(" + (Function.LevelIDToPercent((int)memInfo.LevelID) == 1M ? "不打" : (Function.LevelIDToPercent((int)memInfo.LevelID) * 10).ToString()) + "折)";
            // 绑定之后将焦点转移到选择产品的文本框
            this.textBox_GoodsCode.Focus();
        }

        // 使用多线程读取产品列表，以防止读取产品列表的速度影响窗口显示的速度
        private void BindGoodsTree()
        {
            Thread thread = new Thread(new ThreadStart(BindGoodsTreeThread));
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// 绑定商品树
        /// </summary>
        private void BindGoodsTreeThread()
        {
            Thread.Sleep(50);    //延时100毫秒
            VipSoft.BLL.GoodsClass goodsC = new VipSoft.BLL.GoodsClass();
            VipSoft.BLL.Goods goods = new VipSoft.BLL.Goods();
            string where = "ShopID="+PublicState.Master.ID;
            DataTable dtClass = goodsC.GetList(where).Tables[0];
            DataTable dtGoods = goods.GetList(where).Tables[0];

            ExpenseGoodsTreeShowHandler goodsTreeHandler = new ExpenseGoodsTreeShowHandler(BindGoodsTreeInvoke);
            this.BeginInvoke(goodsTreeHandler, dtClass, dtGoods);
        }

        /// <summary>
        /// 递归，将产品分类绑定到树上
        /// </summary>
        private void CreateTreeClassItem(ref TreeNode node, DataTable dtClass, ref DataTable dtGoods, string parentID)
        {
            DataRow[] drs = dtClass.Select("parentID=" + parentID);
            foreach (DataRow dr in drs)
            {
                TreeNode n = new TreeNode();
                n.Name = "class_" + dr["ID"].ToString();
                n.Text = dr["ClassName"].ToString();
                n.ForeColor = Color.FromArgb(64, 0, 0);
                CreateTreeClassItem(ref n, dtClass, ref dtGoods, dr["ID"].ToString());
                node.Nodes.Add(n);

                CreateTreeGoodsItem(ref n, ref dtGoods, dr["ID"].ToString());
            }
        }

        /// <summary>
        /// 绑定每个分类下面的产品
        /// </summary>
        private void CreateTreeGoodsItem(ref TreeNode node, ref DataTable dtGoods, string classID)
        {
            DataRow[] drs = dtGoods.Select("classID=" + classID);
            foreach (DataRow dr in drs)
            {
                TreeNode n = new TreeNode();
                n.Text = dr["Name"].ToString() + "(" + decimal.Parse(dr["Price"].ToString()).ToString("0.00") + ")";
                n.Name = "goods_" + dr["ID"].ToString();
                node.Nodes.Add(n);
            }
        }

        /// <summary>
        /// 将多线程读取的结果显示在窗体上
        /// </summary>
        private void BindGoodsTreeInvoke(DataTable dtClass, DataTable dtGoods)
        {
            DataRow[] drs = dtClass.Select("parentID=0");
            foreach (DataRow dr in drs)
            {
                TreeNode node = new TreeNode();
                node.Text = dr["ClassName"].ToString();
                node.Name = "class_" + dr["ID"].ToString();
                node.ForeColor = Color.FromArgb(64, 0, 0);

                CreateTreeClassItem(ref node, dtClass, ref dtGoods, dr["ID"].ToString());
                CreateTreeGoodsItem(ref node, ref dtGoods, dr["ID"].ToString());
                this.treeView_goods.Nodes.Add(node);
            }
            this.treeView_goods.ExpandAll();
            this.label_Tree_load.Visible = false;
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            ClearFormText();
            if (CurrentCardID != "")
            {
                VipSoft.BLL.MemCard card = new VipSoft.BLL.MemCard();
                memInfo = card.GetModel(CurrentCardID);
                if (memInfo != null)
                    BindMemberMsg();
                this.textBox_GoodsCode.Select();
            }
            else
                this.searchMember1.Select();

            BindGoodsTree();
        }

        private void searchMember1_EventMemberSelected(Model.MemCard selectedMemInfo)
        {
            memInfo = selectedMemInfo;
            if (memInfo.IsPast && memInfo.PastTime <= DateTime.Now)
            {
                memInfo = null;
                ClearFormText();
                MessageBox.Show("对不起，此会员卡有效期限已过，无法进行消费。");
                this.searchMember1.CardID = "";
            }
            else
            {
                BindMemberMsg();

                if (this.dataGridView_List.Rows.Count > 0)
                {
                    this.dataGridView_List.Rows[this.dataGridView_List.Rows.Count - 1].Selected = true;
                }
                textBox_GoodsCode.Focus();
                textBox_GoodsCode.SelectAll();
            }
        }

        /// <summary>
        /// 从临时订单列表中根据产品ID取得一项
        /// </summary>
        private TempOrderInfo GetTempOrderItem(int goodsID)
        {
            if (listOrder == null)
                return null;
            foreach (TempOrderInfo temp in listOrder)
            {
                if (temp.GInfo.ID == goodsID)
                    return temp;
            }
            return null;
        }

        /// <summary>
        /// 从临时列表中根据产品编号取得一项
        /// </summary>
        private TempOrderInfo GetTempOrderItemByCode(string goodsCode)
        {
            if (listOrder == null)
                return null;
            foreach (TempOrderInfo temp in listOrder)
            {
                if (temp.GInfo.GoodsCode == goodsCode)
                    return temp;
            }
            return null;
        }


        /// <summary>
        /// 将列表中的重复项，并高亮显示
        /// </summary>
        /// <param name="order"></param>
        private void SelectOrderItem(TempOrderInfo order)
        {
            foreach (DataGridViewRow row in this.dataGridView_List.Rows)
            {
                if (row.Cells[0].Value.ToString() == order.Guid)
                {
                    row.Selected = true;
                    int selectRows = this.dataGridView_List.SelectedRows[0].Cells[0].RowIndex;
                    dataGridView_List.CurrentCell = dataGridView_List[2, selectRows];
                    dataGridView_List.BeginEdit(true);
                }
            }
        }

        /// <summary>
        /// 将找到或者选择的产品绑定，同时查询此产品是否为优惠活动产品
        /// </summary>
        private void BindSelectedGoods()
        {
            if (goodsInfo != null)
            {
                this.label_GName.Text = goodsInfo.Name;
                this.label_GNumber.Text = goodsInfo.GoodsType.ToString() == "1" ? "不限" : goodsInfo.Number.ToString();
                this.label_GPoint.Text = goodsInfo.Point.ToString();
                this.label_GPrice.Text = decimal.Parse(goodsInfo.Price.ToString()).ToString("￥0.00");

                this.textBox_Number.Text = "1";
                this.textBox_Number.Focus();
                this.textBox_Number.SelectAll();

            }

        }

        private void BindOrderList(string goodsCode)
        {
            this.dataGridView_List.Rows.Clear();

            decimal minPercent;                 // 当前产品最低折扣率，由当前等级和产品的最低折扣比较得出
            totalPrice = 0M;                    // 实际总价
            discountPrice = 0M;                 // 折后总价
            totalPoint = 0;                    // 总共获得的积分（优先产品积分）
            totalNumber = 0;                    // 总数量

            foreach (TempOrderInfo order in listOrder)
            {
                // 如果是会员消费则计算打折数据
                if (!IsTravelerMember && memInfo != null)  //memInfo.LevelPoint != 0
                {
                    if (order.GInfo.GoodsCode == goodsCode)
                    {
                        minPercent = order.GInfo.MinPercent < Function.LevelIDToPercent((int)memInfo.LevelID) ? Function.LevelIDToPercent((int)memInfo.LevelID) : (decimal)order.GInfo.MinPercent;
                    }
                    else
                    {
                        minPercent = order.Discount;
                    }
                    if (order.GInfo.PointType == 0)
                        totalPoint += order.GInfo.Point == 0 ? 0 : (int)order.GInfo.Point * order.Number;
                    else
                    {
                        if (Function.LevelIDToPoint((int)memInfo.LevelID) == 0)
                            totalPoint += 0;
                        else
                            totalPoint += (int)(order.GInfo.Price * order.Number * minPercent / Function.LevelIDToPoint((int)memInfo.LevelID));
                    }
                }
                else
                    minPercent = 1;

                totalPrice += (decimal)order.GInfo.Price * order.Number;
                totalNumber += order.Number;
                discountPrice += (decimal)order.GInfo.Price * order.Number * minPercent;
                order.DiscountPrice = (decimal)order.GInfo.Price * order.Number * minPercent;
                order.Discount = minPercent;
                this.dataGridView_List.Rows.Add(order.Guid, order.CountID.ToString(), order.GInfo.Name, ((decimal)order.GInfo.Price).ToString("￥0.00"), order.GInfo.GoodsType == 0 ? order.GInfo.Number - order.Number : 0, order.Number.ToString(), order.GInfo.Point,
                    ((decimal)(order.GInfo.Price) * order.Number).ToString("￥0.00"), minPercent, order.DiscountPrice.ToString("￥0.00"));
            }

            //// 处理结算小数部分
            //if (PublicState.Order_DecimalType == 1)
            //    discountPrice = (decimal)(Math.Floor(discountPrice));
            //else if (PublicState.Order_DecimalType == 2)
            discountPrice = Math.Round(discountPrice, 0, MidpointRounding.AwayFromZero);

            this.label_OTMoney.Text = totalPrice.ToString("￥0.00");
            this.label_OTNumber.Text = totalNumber.ToString();
            this.label_OTPoint.Text = totalPoint.ToString();
            this.label_OTMoney2.Text = discountPrice.ToString("￥0.00");

          
            this.dataGridView_List.Rows[this.dataGridView_List.Rows.Count - 1].Selected = true;

        }


        // 将商品加入到订单 
        private void AddOrder(string goodsCode)
        {
            if (goodsInfo == null)
                return;

            TempOrderInfo tempInfo = GetTempOrderItem(goodsInfo.ID);
            bool isAdd = true;
            if (tempInfo != null)
            {
                GetTempOrderItem(goodsInfo.ID).Number = int.Parse(this.textBox_Number.Text);
                tempInfo = GetTempOrderItem(goodsInfo.ID);
                isAdd = false;
            }
            else
            {
                if (listOrder == null)
                    listOrder = new List<TempOrderInfo>();
                tempInfo = new TempOrderInfo(int.Parse(this.textBox_Number.Text), goodsInfo);
                this.listOrder.Add(tempInfo);
            }
            BindOrderList(goodsCode);
        }


        private void SelectGoods(string goodsCode)
        {
            TempOrderInfo order = GetTempOrderItemByCode(goodsCode);
            goodsInfo = new VipSoft.BLL.Goods().GetModel(goodsCode);
            if (goodsInfo != null)
            {
                if (goodsInfo.Number <= 0 && goodsInfo.GoodsType == (byte)0)
                {
                    MessageBox.Show("库存不足！");
                    return;
                }
            }
            if (order != null)
            {
                SelectOrderItem(order);
                int selectRows = this.dataGridView_List.SelectedRows[0].Cells[0].RowIndex;
                dataGridView_List.CurrentCell = dataGridView_List[5, selectRows];
                dataGridView_List.BeginEdit(true);
                int num = int.Parse(this.dataGridView_List.Rows[selectRows].Cells["Column_Number"].Value.ToString());
                int newnum = num + 1;
                this.dataGridView_List.Rows[selectRows].Cells["Column_Number"].Value = newnum;
                dataGridView_List.EndEdit();
            }
            else
            {
                if (goodsInfo != null)
                {
                    BindSelectedGoods();
                    AddOrder(goodsCode);
                }

                else
                {
                    MessageBox.Show("未找到此产品。");
                    this.textBox_GoodsCode.Focus();
                    this.textBox_GoodsCode.SelectAll();
                }
            }

        }

        /// <summary>
        /// 将选择的产品绑定，用户重新编辑
        /// </summary>
        private void BindSelectedGoods(decimal number)
        {
            BindSelectedGoods();
            this.textBox_Number.Text = number.ToString();
            this.textBox_Number.Focus();
            this.textBox_Number.SelectAll();
        }

        private void treeView_goods_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = this.treeView_goods.SelectedNode;
            if (node == null)
                return;
            if (node.Name.IndexOf("goods_") == -1)
            {
                string msg = "双击产品名称即可选择该产品，双击类别将无效。";
                this.toolTip_Tree.Show(msg, this.treeView_goods);
            }
            else
            {
                if (memInfo==null && !IsTravelerMember)
                {
                    MessageBox.Show("请先选择要消费的会员。");
                    this.searchMember1.Focus();
                    return;
                }

                int id = int.Parse(node.Name.Replace("goods_", ""));
                goodsInfo = new VipSoft.BLL.Goods().GetModel(id);
                if (goodsInfo.Number <= 0 && goodsInfo.GoodsType == (byte)0)
                {
                    MessageBox.Show("此产品暂时缺货！");
                    return;
                }

                TempOrderInfo order = GetTempOrderItem(id);
                if (order != null)
                {
                    SelectGoods(order.GInfo.GoodsCode);
                }

                order = GetTempOrderItem(id);
                if (order == null)
                {
                    goodsInfo = new VipSoft.BLL.Goods().GetModel(id);
                    if (goodsInfo == null)
                    {
                        MessageBox.Show("未找到产品，请刷新列表，然后重新选择。");
                        return;
                    }
                    this.label_Guid.Text = "";
                    BindSelectedGoods();
                    AddOrder(goodsInfo.GoodsCode);
                }
                else
                {
                    goodsInfo = order.GInfo;
                    this.label_Guid.Text = order.Guid;
                    BindSelectedGoods(order.Number);
                }

            }
        }
    }
}
