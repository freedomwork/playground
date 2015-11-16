using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VipSoft
{
    /// <summary>
    /// 用于处理搜索窗体选择会员事件的委托
    /// </summary>
    public delegate void SearchMemSelectedHandler(VipSoft.Model.MemCard memInfo);
    public delegate void SearchCardSelectedHandler(string cardID);

    public partial class SearchMem : BaseFormNoSkin
    {
        /// <summary>
        /// 选择会员事件
        /// </summary>
        public event SearchMemSelectedHandler SearchMemSelected;
        public event SearchCardSelectedHandler SearchMemSelectedCard;

        // 搜索条件
        private string condition = "CardID<>'0'";

        public SearchMem()
        {
            InitializeComponent();

            this.dataGridView_List.AutoGenerateColumns = false;
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_List.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.dataGridView_List.SelectedRows[0];
                MemSelected(row);
            }
        }

        /// <summary>
        /// 当选择用户时，调用委托，关闭窗口
        /// </summary>
        /// <param name="row"></param>
        private void MemSelected(DataGridViewRow row)
        {
            int id = int.Parse(row.Cells["Column_ID"].Value.ToString());
            string cardID = row.Cells["Column_CardID"].Value.ToString();
            this.Close();
            if (SearchMemSelected != null)
            {
                VipSoft.Model.MemCard info = new VipSoft.BLL.MemCard().GetModel(id);
                SearchMemSelected(info);
            }
            else if (SearchMemSelectedCard != null)
            {
                SearchMemSelectedCard(cardID);
            }
        }

        private void SearchMem_Load(object sender, EventArgs e)
        {
            BindList();
            this.panel1.BackColor = Color.FromArgb(51, 161, 224);
            this.textBox_Key.Select();
            this.textBox_Key.Focus();
        }

        private void BindList()
        {
            VipSoft.BLL.MemCard card = new VipSoft.BLL.MemCard();
            DataSet ds = card.GetList(20, "ID", false, condition);
            this.dataGridView_List.Rows.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.dataGridView_List.Rows.Add(dr["ID"].ToString(),dr["CardID"].ToString(),dr["Name"].ToString(),
                    decimal.Parse(dr["TotalMoney"].ToString() == "" ? "0" : dr["TotalMoney"].ToString()).ToString("￥0.00"),
                    Function.LevelIDToName(int.Parse(dr["LevelID"].ToString())));
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 双击选择用户关闭窗口
        private void dataGridView_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_List.Rows[e.RowIndex];
                MemSelected(row);
            }
        }

        private void dataGridView_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.dataGridView_List.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = this.dataGridView_List.SelectedRows[0];
                    MemSelected(row);
                }
            }
        }

        private void SearchMem_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        // 按下回车键，搜索
        private void textBox_Key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBox_Key.Text != "")
                {
                    condition = string.Format("CardID like '%{0}%' or [Name] like '%{0}%' or CardmianID like '%{0}%'", this.textBox_Key.Text.Trim());
                    if (Maticsoft.Common.StringPlus.IsRightfulMobile(this.textBox_Key.Text))
                        condition += " or Mobile='" + this.textBox_Key.Text + "'";
                }
                else
                    condition = "";
                BindList();                
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                this.dataGridView_List.Focus();
            }
        }

        private void dataGridView_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
