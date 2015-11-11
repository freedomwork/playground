using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class Shop : BaseForm
    {
        VipSoft.BLL.Shop bllShop = new BLL.Shop();

        private int CurrentShopID = -1;

        public Shop()
        {
            InitializeComponent();
        }

        void BindShopList()
        {
            this.dataGridView_List.Rows.Clear();
            DataTable dt = bllShop.GetAllList().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                this.dataGridView_List.Rows.Add(dr["ID"].ToString(), dr["Name"].ToString(), dr["TelPhone"].ToString(), dr["ShopLink"].ToString(), dr["Remark"].ToString());   
            }
        }

        void BindShopInfo()
        {
            VipSoft.Model.Shop model = bllShop.GetModel(CurrentShopID);
            this.txt_ShopName.Text = model.Name;
            this.txt_Tel.Text = model.TelPhone;
            this.txt_Link.Text = model.ShopLink;
            this.txt_Remark.Text = model.Remark;
        }

        void ClearFormText()
        {
            this.txt_ShopName.Text = "";
            this.txt_Tel.Text = "";
            this.txt_Link.Text = "";
            this.txt_Remark.Text = "";
            this.txt_ShopName.Focus();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            BindShopList();
            ClearFormText();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            VipSoft.Model.Shop shopModel = new Model.Shop();
            shopModel.Name = this.txt_ShopName.Text.Trim();
            shopModel.TelPhone = this.txt_Tel.Text.Trim();
            shopModel.ShopLink = this.txt_Link.Text.Trim();
            shopModel.Remark = this.txt_Remark.Text.Trim();
            if (CurrentShopID != -1)
            {
                shopModel.ID = CurrentShopID;
                if (bllShop.Update(shopModel))
                {
                    this.myTabControl1.SelectedIndex = 0;
                    BindShopList();
                    MessageBox.Show("修改店铺成功！");
                }
                else
                {
                    MessageBox.Show("修改店铺失败！");
                }
            }
            else
            {
                if (bllShop.Add(shopModel) > 0)
                {
                    this.myTabControl1.SelectedIndex = 0;
                    BindShopList();
                    MessageBox.Show("新增店铺成功！");
                }
                else
                {
                    MessageBox.Show("新增店铺失败！");
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ClearFormText();
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

        void DeleteItem()
        {
            if (bllShop.Delete(CurrentShopID))
            {
                MessageBox.Show("删除店铺成功！");
                BindShopList();
            }
            else
            {
                MessageBox.Show("删除店铺失败！");
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView_List.SelectedRows[0];
            CurrentShopID = int.Parse(row.Cells[0].Value.ToString());
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Name)
            {
                // 编辑
                case "ToolStripMenuItem_Edit":
                    this.myTabControl1.SelectedIndex = 1;
                    BindShopInfo();
                    break;
                // 删除
                case "toolStripMenuItem_Delete":
                    DeleteItem();
                    break;
            }
        }
    }
}
