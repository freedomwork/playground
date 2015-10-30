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
    /// 用于处理卡片等级窗体关闭的委托
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public delegate void LevelFormClosedHandler(string s);

    public partial class SetLevel : BaseForm
    {
        /// <summary>
        /// 卡片等级窗体关闭事件
        /// </summary>
        public event LevelFormClosedHandler LevelFormClosed;
        DataSet listLevel = null;
        public SetLevel()
        {
            InitializeComponent();
            this.dataGridView_List.AutoGenerateColumns = false;
        }

        // 验证输入
        private bool CheckInput()
        {
            if (this.textBox_LevelName.Text.Trim() == "")
            {
                this.textBox_LevelName.Focus();
                this.textBox_LevelName.SelectAll();
                MessageBox.Show("请输入等级名称");
                return false;
            }
            if (!Maticsoft.Common.FormValidate.IsNumber(this.textBox_needpoint.Text))
            {
                this.textBox_needpoint.Focus();
                this.textBox_needpoint.SelectAll();
                MessageBox.Show("请输入正确的积分（整数格式）");
                return false;
            }

            if (!Maticsoft.Common.FormValidate.IsDecimal(this.textBox_Point.Text))
            {
                this.textBox_Point.Focus();
                this.textBox_Point.SelectAll();
                MessageBox.Show("请输入正确的积分兑换比例。");
                return false;
            }
            if (!Maticsoft.Common.FormValidate.IsDecimal(this.textBox_Percent.Text) || decimal.Parse(this.textBox_Percent.Text) > 1M)
            {
                this.textBox_Percent.Focus();
                this.textBox_Percent.SelectAll();
                MessageBox.Show("请输入正确的折扣比例（小于等于1的2位小数）");
                return false;
            }
            return true;
        }

        private void BindList()
        {
            listLevel = new VipSoft.BLL.CardLevel().GetAllList();
            this.dataGridView_List.DataSource = listLevel.Tables[0];
        }

        private void button_Manage_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            VipSoft.BLL.CardLevel cardL = new VipSoft.BLL.CardLevel();

            string needP = this.textBox_needpoint.Text;
            VipSoft.Model.CardLevel level = new VipSoft.Model.CardLevel();
            level.LevelName=this.textBox_LevelName.Text;
            level.NeedPoint=int.Parse(needP);
            level.Point=int.Parse(this.textBox_Point.Text);
            level.Percent=decimal.Parse(this.textBox_Percent.Text);
            if (this.label_Flag.Text == "add")
            {
                if (cardL.Exists(this.textBox_LevelName.Text))
                {
                    MessageBox.Show("等级名称重复，请重新输入！");
                    this.textBox_LevelName.Text = "";
                    this.textBox_LevelName.Focus();
                    return;
                }
                cardL.Add(level);
                // 记录日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master,"会员等级管理", 
                    string.Format("新增会员等级（名称{0}：所需积分{1}：兑换比例{2}：折扣比例{3}：）", this.textBox_LevelName.Text, needP, this.textBox_Point.Text, this.textBox_Percent.Text), DateTime.Now));
                // 提示
                MessageBox.Show("新等级录入成功。");
                // 文本框数据清空

                this.textBox_LevelName.Text = "";
                this.textBox_Percent.Text = "";
                this.textBox_Point.Text = "";

                this.textBox_needpoint.Text = "";
            }
            // 编辑
            else
            {
                level.ID = int.Parse(this.label_Flag.Text);
                cardL.Update(level);
                // 记录日志
                VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                log.Add(new VipSoft.Model.SysLog(PublicState.Master,"会员等级管理", 
                    string.Format("编辑会员等级（ID：{0}名称：{1}所需积分：{2}兑换比例：{3}折扣比例：{4}）", this.label_Flag.Text, this.textBox_LevelName.Text, needP, this.textBox_Point.Text, this.textBox_Percent.Text),
                    DateTime.Now));
                // 提示
                MessageBox.Show("等级修改成功。");
            }
            // 绑定数据
            BindList();
        }

        private void SetLevel_Load(object sender, EventArgs e)
        {
            BindList();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            this.textBox_LevelName.Text = "";

            this.textBox_Percent.Text = "";
            this.textBox_Point.Text = "";
            this.label_Flag.Text = "add";
            this.textBox_needpoint.Text = "";
            this.textBox_LevelName.Focus();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_List.SelectedRows.Count != 1)
            {
                MessageBox.Show("编辑等级，请先选择需要编辑的行。");
                return;
            }
            DataGridViewRow row = this.dataGridView_List.SelectedRows[0];
            string selectID = row.Cells["ID"].Value.ToString();
            this.label_Flag.Text = selectID;

            // 数据绑定
            this.textBox_LevelName.Text = row.Cells["LevelName"].Value.ToString();
            string needP = row.Cells["NeedPoint"].Value.ToString();

            this.textBox_Percent.Text = row.Cells["Percent"].Value.ToString();
            this.textBox_Point.Text = row.Cells["Point"].Value.ToString();
            this.textBox_needpoint.Text = needP;
            this.button_Manage.Text = "保存修改";
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_List.SelectedRows.Count != 1)
            {
                MessageBox.Show("删除记录，请先选择需要删除的行。");
                return;
            }
            VipSoft.BLL.CardLevel level = new VipSoft.BLL.CardLevel();
            DataGridViewRow row = this.dataGridView_List.SelectedRows[0];
            string ID = row.Cells["ID"].Value.ToString();
            DataTable lst = level.GetListC(int.Parse(ID));
            if (lst.Rows.Count > 0)
            {
                MessageBox.Show("对不起，当前等级已有会员信息，不能删除此等级！");
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("确定要删除当前等级么？删除可能会影响到该等级会员卡的使用。", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res.ToString() == "OK")
                {
                    level.Delete(int.Parse(row.Cells["ID"].Value.ToString()));
                    // 记录日志
                    VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                    log.Add(new VipSoft.Model.SysLog(PublicState.Master,"会员等级管理", 
                        string.Format("删除会员等级（ID：{0}名称：{1}所需积分：{2}兑换比例：{3}折扣比例：{4}）", row.Cells["ID"].Value.ToString(), row.Cells["LevelName"].Value.ToString(),
                        row.Cells["NeedPoint"].Value.ToString(), row.Cells["Point"].Value.ToString(), row.Cells["Percent"].Value.ToString()),DateTime.Now));
                    // 提示
                    MessageBox.Show("数据已成功删除。");
                    // 重新绑定
                    BindList();
                }
            }
        }

        private void SetLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LevelFormClosed != null)
                LevelFormClosed("");
        }
    }
}
