using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{
    public partial class Exchang : BaseForm
    {

        /// <summary>
        /// 当前会员卡号
        /// </summary>
        public string CurrentCardID = "";

        private VipSoft.Model.MemCard memInfo;
        private VipSoft.BLL.Gift eg = new VipSoft.BLL.Gift();
        private List<VipSoft.Model.ExchangeLog> exchangList = new List<VipSoft.Model.ExchangeLog>();
        int totalPoint = 0;

        public Exchang()
        {
            InitializeComponent();
        }

        private void BindList()
        {
            DataSet ds = eg.GetList("");
            this.dataGridView_List.DataSource = ds.Tables[0];
            foreach (DataGridViewRow row in this.dataGridView_List.Rows)
            {
                row.Cells["Column_ENum"].Value = "1";
            }

        }

        private void Exchang_Load(object sender, EventArgs e)
        {
            BindList();
            if (CurrentCardID != "")
                memInfo = new VipSoft.BLL.MemCard().GetModel(CurrentCardID);
            if (memInfo == null)
            {
                this.label_M_Money.Text = "";
                this.label_M_Name.Text = "";
                this.label_M_Point.Text = "";
                this.label_M_TotalMoney.Text = "";
            }
            else
            {
                this.label_M_Name.Text = memInfo.Name;
                this.label_M_Point.Text = memInfo.Point.ToString();
                this.label_M_TotalMoney.Text = memInfo.TotalMoney.ToString("￥0.00");
                this.label_M_Money.Text = memInfo.Money.ToString("￥0.00");
            }
        }

        private void searchMember1_EventMemberSelected(Model.MemCard selectedMemInfo)
        {
            memInfo = selectedMemInfo;
            if (memInfo.IsPast && memInfo.PastTime <= DateTime.Now)
            {
                memInfo = null;
                MessageBox.Show("对不起，此会员卡有效期限已过，无法兑换礼品。");
                this.searchMember1.CardID = "";
                return;
            }
            this.label_M_Name.Text = memInfo.Name;
            this.label_M_Point.Text = memInfo.Point.ToString();
            this.label_M_TotalMoney.Text = memInfo.TotalMoney.ToString("￥0.00");
            this.label_M_Money.Text = memInfo.Money.ToString("￥0.00");
        }

        void gl_GiftListRefresh()
        {
            BindList();
        }

        private void linkLabel_GiftSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GiftList gl = new GiftList();
            gl.GiftListRefresh += new GiftListRefreshHandler(gl_GiftListRefresh);
            gl.ShowDialog();
        }

        private void ToolStripMenuItem_ModifyNumber_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            DataGridViewRow row = dataGridView_List.SelectedRows[0];
            int selectRow = this.dataGridView_List.SelectedRows[0].Cells[0].RowIndex;
            switch (item.Name)
            {
                //修改兑换数量
                case "ToolStripMenuItem_ModifyNumber":
                    this.dataGridView_List.SelectedRows[0].Cells[0].Value = true;

                    dataGridView_List.CurrentCell = dataGridView_List[7, selectRow];
                    dataGridView_List.BeginEdit(false);
                    this.dataGridView_List.CurrentRow.Cells[0].Value = true;
                    break;
                // 礼品设置
                case "ToolStripMenuItem_Steup":
                    GiftList gl = new GiftList();
                    gl.GiftListRefresh += new GiftListRefreshHandler(gl_GiftListRefresh);
                    gl.ShowDialog();
                    break;
            }
        }

        private void dataGridView_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string photo = this.dataGridView_List.SelectedRows[0].Cells[6].Value.ToString();
            this.pictureBox_Gift.ImageLocation = photo;
        }

        private void dataGridView_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_List.Rows[e.RowIndex];
            if (row.Cells["Column_ENum"].Value.ToString() == "" || !Maticsoft.Common.FormValidate.IsNumber(row.Cells["Column_ENum"].Value.ToString()))
            {
                MessageBox.Show("请输入正确的数值！！");
                row.Cells["Column_ENum"].Value = "1";
            }
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
                this.alContextMenuStrip1.Show(dataGridView_List, point);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            totalPoint = 0;
            if (memInfo == null)
            {
                MessageBox.Show("您必须先选择会员！");
                return;
            }

             exchangList = new List<VipSoft.Model.ExchangeLog>();
             foreach (DataGridViewRow row in this.dataGridView_List.Rows)
             {
                 Model.ExchangeLog info;
                 Model.Gift gift;

                 if (row.Cells[0].Value != null && bool.Parse(row.Cells[0].Value.ToString()))
                 {
                     int id = int.Parse(row.Cells["Column_ID"].Value.ToString());
                     string code = row.Cells["Column_Code"].Value.ToString();
                     string name = row.Cells["Column_Name"].Value.ToString();
                     int point = int.Parse(row.Cells["Column_Point"].Value.ToString());

                     int number = 1;
                     try
                     {
                         number = int.Parse(row.Cells["Column_ENum"].Value.ToString());
                     }
                     catch
                     {
                         MessageBox.Show("请输入正确的兑换数量！");
                         return;
                     }

                     if (number > int.Parse(row.Cells["Column_Number"].Value.ToString()))
                     {
                         MessageBox.Show("兑换数量超出礼品剩余数量！");
                         return;
                     }
                     gift = new Model.Gift();
                     gift.GiftCode=code;
                     gift.Name=name;
                     gift.Photo="";
                     gift.Point=point;
                     gift.Number=number;
                     gift.ID = id;

                     info = new Model.ExchangeLog();
                     info.MemID=memInfo.ID;
                     info.CardID=memInfo.CardID;
                     info.Name=memInfo.Name;
                     info.Number=number;
                     info.Point = point * number;
                     info.GiftID=id;
                     info.GiftName=name;
                     info.GiftCode=code;
                     info.MasterID=PublicState.Master.ID;
                     info.MasterName=PublicState.Master.Name;
                     info.ShopID=PublicState.Master.ShopID;
                     info.ShopName=PublicState.Master.ShopName;
                     exchangList.Add(info);
                 }
             }

             if (exchangList.Count == 0)
             {
                 MessageBox.Show("请先选择需要兑换的礼品！");
                 return;
             }
             if (totalPoint > memInfo.Point)
             {
                 MessageBox.Show("对不起，此会员账户积分不足！");
                 return;
             }

             if (new VipSoft.BLL.ExchangeLog().Add(exchangList))
             {
                 // 日志记录
                 VipSoft.BLL.SysLog log = new VipSoft.BLL.SysLog();
                 log.Add(new Model.SysLog(PublicState.Master, "积分兑换", "积分兑换产品成功，会员卡号：" + memInfo.CardID + "姓名：" + memInfo.Name, DateTime.Now));
                 // 发送系统短信
                 memInfo = new BLL.MemCard().GetModel(memInfo.ID);
                     Function.UpdateMemberLevel(2, memInfo);//兑换登记时候自动重新计算

                 // 提示
                 MessageBox.Show("兑换成功。");
                 // 界面
                 memInfo = null;
                 this.label_M_Money.Text = "";
                 this.label_M_Name.Text = "";
                 this.label_M_Point.Text = "";
                 this.label_M_TotalMoney.Text = "";
                 this.searchMember1.CardID = "";
                 BindList();
             }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
