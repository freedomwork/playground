using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace VipSoft
{
    public partial class GoodsPutIn : BaseForm
    {
        /// <summary>
        /// 编辑会员时记录会员自动编号
        /// </summary>
        public int CurrentGoodsID = 0;

        public GoodsPutIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自动产生卡片编号
        /// </summary>
        /// <returns></returns>
        private string RandomGoodsCode()
        {
            Random ran = new Random();
            int res = ran.Next(99999999);
            if (new VipSoft.BLL.Goods().Exists(res.ToString()))
                return RandomGoodsCode();
            else
                return res.ToString();
        }

        /// <summary>
        /// 绑定商品分类
        /// </summary>
        private void LoadGoodsClass()
        {
            DataSet ds = new VipSoft.BLL.GoodsClass().GetList("[ShopID]="+PublicState.Master.ShopID);
            Function.BindGoodsClass(this.comboBox_Class, ds.Tables[0]);
        }

        private void checkBox_AutoCode_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_GoodsCode.Enabled = !this.checkBox_AutoCode.Checked;
            if (checkBox_AutoCode.Checked)
                this.textBox_GoodsCode.Text = RandomGoodsCode();
            else
                this.textBox_GoodsCode.Text = "";
        }

        private void textBox_GoodsName_TextChanged(object sender, EventArgs e)
        {
            this.textBox_NameCode.Text = Maticsoft.Common.StringPlus.IndexCode(this.textBox_GoodsName.Text);
        }

        private void linkLabel_Class_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetClass sc = new SetClass();
            sc.ClassFormClosed += new ClassFormClosedHandler(sc_ClassFormClosed);
            sc.ShowDialog(this);
        }

        // 分类窗体关闭事件，重新绑定产品分类
        void sc_ClassFormClosed(string s)
        {
            LoadGoodsClass();
        }

        private void GoodsPutIn_Load(object sender, EventArgs e)
        {
            LoadGoodsClass();
            LoadGoodsUnit();
            if (CurrentGoodsID != 0)
            {
                BindGoodsData();
            }
        }

                /// <summary>
        /// 编辑时，绑定数据
        /// </summary>
        private void BindGoodsData()
        {

        }

        /// <summary>
        /// 绑定产品单位数据字典
        /// </summary>
        private void LoadGoodsUnit()
        {
            string[] units = new Maticsoft.Common.INIFile().IniReadValue("config", "GoodsUnit").Split("|".ToCharArray());
            this.comboBox_Unit.Items.Clear();
            foreach (string unit in units)
            {
                if (unit.Trim() != "")
                    comboBox_Unit.Items.Add(unit.Trim());
            }
        }

        private void linkLabel_GoodsUnitSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dictionary dic = new Dictionary();
            dic.DictionaryChanged += new DictionaryChangedHandler(dic_DictionaryChanged);
            dic.ShowDialog();
        }

        void dic_DictionaryChanged(string units)
        {
            this.comboBox_Unit.Items.Clear();
            foreach (string s in units.Split("|".ToCharArray()))
            {
                comboBox_Unit.Items.Add(s);
            }
        }

        private void linkLabel_Help_Click(object sender, EventArgs e)
        {
            LinkLabel lhelp = (LinkLabel)sender;
            ToolTip tt = null;
            string text = "";
            switch (lhelp.Name)
            {
                case "linkLabel_Number":
                    text = "库存数量，如果是服务类产品则库存数量留空。";
                    tt = this.toolTip_Number;
                    break;
                case "linkLabel_Point":
                    text = "消费一件此产品可获得多少积分？此处用于设置一些特殊产品的积分。\n例如：消费XX洗发水特惠装，可获赠100积分，如果此处设置了积分，\n则对此产品对应的消费金额不再自动兑换积分。不设置，请默认为零。";
                    tt = this.toolTip_Point;
                    break;
                case "linkLabel_Percent":
                    text = "最低折扣，表示某产品最低可享受的折扣额度。\n例如：设置啤酒的最低折扣值为0.8，即八折，但是某会员是可享受5折优惠的超级VIP会员，\n如果按照会员等级打折，那啤酒享受五折之后必然亏损，所以设置了啤酒最低折扣八折之后，\n此啤酒就只能最低打八折。如果某会员为享受九折优惠的普通会员，则他在消费啤酒时的折扣为九折。\n以此类推。";
                    tt = this.toolTip_Percent;
                    break;
                case "linkLabel_IsPoint":
                    text = "产品是否按照消费金额自动累计积分，对某些特殊产品，购买了没有积分的，就不要勾选此项目。";
                    tt = this.toolTip_IsPoint;
                    break;
                case "linkLabel_GoodsType":
                    text = "产品类型，是普通产品（有库存限制，库存为0时，则无法继续售出）还是服务类产品（无库存限制）";
                    tt = this.toolTip_GoodsType;
                    break;
            }

            if (tt != null)
                tt.Show(text, lhelp);
        }

        /// <summary>
        /// 输入内容验证
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            // 产品编号
            if (!this.checkBox_AutoCode.Checked)
            {
                string reg_gcode = @"^\w{3,50}$";
                if (!Regex.IsMatch(this.textBox_GoodsCode.Text, reg_gcode))
                {
                    MessageBox.Show("商品编号输入错误，编号只能由数字和字母组成，3-50位。");
                    this.textBox_GoodsCode.Focus();
                    this.textBox_GoodsCode.Select();
                    return false;
                }
            }
            // 产品名称
            if (this.textBox_GoodsName.Text.Trim() == "")
            {
                MessageBox.Show("商品名称不能为空。");
                this.textBox_GoodsName.Focus();
                this.textBox_GoodsName.Select();
                return false;
            }
            // 产品单位
            if (this.comboBox_Unit.Text.Trim() == "")
            {
                MessageBox.Show("商品单位不能为空。");
                this.comboBox_Unit.Focus();
                this.comboBox_Unit.Select();
                return false;
            }
            // 最低折扣
            if (this.textBox_MinPercent.Text.Trim() == "")
            {
                MessageBox.Show("请输入最低折扣额度。");
                this.textBox_MinPercent.Focus();
                this.textBox_MinPercent.Select();
                return false;
            }
            // 最低折扣
            if (decimal.Parse(this.textBox_MinPercent.Text) > 1M)
            {
                MessageBox.Show("最低折扣值应该是0-1之间的小数，0表示无最低折扣限制，1表示此商品不参与打折。");
                this.textBox_MinPercent.Focus();
                this.textBox_MinPercent.SelectAll();
                return false;
            }
            if (decimal.Parse(this.textBox_MinPercent.Text) < 0)
            {
                MessageBox.Show("最低折扣不能是负数!");
                this.textBox_MinPercent.Focus();
                this.textBox_MinPercent.SelectAll();
                return false;
            }

            // 产品分类
            if (this.comboBox_Class.Items.Count == 0)
            {
                MessageBox.Show("对不起，您还没有设置产品分类\n您可以点击产品分类旁边的“分类管理”按钮，对此进行设置。");
                return false;
            }
            if (this.comboBox_Class.SelectedValue == null ||
                !Function.CheckIsLowestClass(new VipSoft.BLL.GoodsClass().GetList("ShopID="+PublicState.Master.ShopID).Tables[0], this.comboBox_Class.SelectedValue.ToString()))
            {
                MessageBox.Show("请选择正确的产品分类。\n此分类必须是最底层的类别（即：最小分类）。");
                return false;
            }
            return true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VipSoft.BLL.Goods bllGoods = new BLL.Goods();
            VipSoft.Model.Goods model = new Model.Goods();
            model.GoodsCode=this.textBox_GoodsCode.Text.Trim();
            model.Name = this.textBox_GoodsName.Text.Trim();
            model.NameCode = this.textBox_NameCode.Text.Trim();
            model.ClassID = int.Parse(this.comboBox_Class.SelectedValue.ToString());
            model.Unit = this.comboBox_Unit.Text == null ? this.comboBox_Unit.SelectedItem.ToString() : this.comboBox_Unit.Text;
            model.Number = int.Parse(this.textBox_Number.Text);
            model.Point = int.Parse(this.textBox_Point.Text);
            model.Price = decimal.Parse(this.textBox_Price.Text.Replace("￥", ""));
            model.BuyPrice = decimal.Parse(this.myMoneyTextBox1.Text.Replace("￥", ""));
            model.MinPercent = decimal.Parse(this.textBox_MinPercent.Text);
            model.PointType = int.Parse(this.rdoIsPoint.Checked ? "1" : "0");
            model.GoodsType = this.checkBox_GoodsType.Checked;
            model.ShopID = PublicState.Master.ShopID;
            model.ShopName = PublicState.Master.ShopName;
            if (CurrentGoodsID == 0)
            {
                if (bllGoods.Exists(this.textBox_GoodsCode.Text.Trim()))
                {
                    MessageBox.Show("编号为" + this.textBox_GoodsCode.Text + "的产品或服务已经存在，请重新输入编号或增加其他的产品。");
                    this.textBox_GoodsCode.Focus();
                    this.textBox_GoodsCode.SelectAll();
                }
                if (bllGoods.Add(model) > 0)
                {
                    // 加入日志
                    VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                    log.Add(new VipSoft.Model.SysLog(PublicState.Master, "产品入库",
                        string.Format("产品添加，编号：{0}名称：{1}数量：{2}", model.GoodsCode, this.textBox_GoodsName.Text, this.textBox_Number.Text),
                        DateTime.Now));
                    // 提示
                    MessageBox.Show("产品添加成功。");
                }
                else
                {
                    MessageBox.Show("产品添加失败，请重试。");
                    return;
                }
            }
            else
            {
                model.ID = CurrentGoodsID;
                if (bllGoods.Update(model))
                {
                    // 日志记录
                    VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                    log.Add(new VipSoft.Model.SysLog(PublicState.Master, "产品信息修改", "修改产品信息（编号：" + this.textBox_GoodsCode.Text + " 名称：" + this.textBox_GoodsName.Text + "）", DateTime.Now));
                    // 提示
                    MessageBox.Show("产品信息修改成功。");
                }
                else
                {
                    MessageBox.Show("产品信息修改失败，请重试。");
                    return;
                }
            }

            // 窗口处理
            if (this.checkBox_save.Checked)
            {
                this.checkBox_AutoCode.Checked = false;
                this.textBox_GoodsCode.Text = "";
                this.textBox_GoodsName.Text = "";
                this.textBox_Number.Text = "0";
                this.textBox_Point.Text = "0";
                this.textBox_MinPercent.Text = "0";
                this.textBox_Price.Text = "￥0.00";
                this.myMoneyTextBox1.Text = "￥0.00";
                this.textBox_MinPercent.Text = "0";
            }
            else
                this.Close();
        }

        private void checkBox_GoodsType_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentGoodsID == 0)
            {
                if (this.checkBox_GoodsType.Checked)
                {
                    this.textBox_Number.Enabled = false;
                }
                else
                {
                    this.textBox_Number.Enabled = true;
                }
            }
        }

        private void rdoIsPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoIsPoint.Checked)
            {
                this.textBox_Point.ReadOnly = true;
                this.textBox_Point.Text = "0";
            }
            else
                this.textBox_Point.ReadOnly = false;
        }
    }
}
