using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VipSoft
{

    public delegate void GiftListRefreshHandler();

    public partial class GiftList : BaseForm
    {
        public event GiftListRefreshHandler GiftListRefresh;

        VipSoft.BLL.Gift eg = new BLL.Gift();

        public GiftList()
        {
            InitializeComponent();
            this.dataGridView_List.AutoGenerateColumns = true;
        }

        private void BindList()
        {
            DataSet ds = eg.GetList("");
            this.dataGridView_List.DataSource = ds.Tables[0];
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (this.textBox_GiftCode.Text == "" || this.textBox_GiftName.Text == "" || this.TextBox_Number.Text == "" || this.TextBox_Point.Text == "")
            {
                MessageBox.Show("请输入完整信息！");
                return;
            }

            VipSoft.Model.Gift model = new Model.Gift();
            model.GiftCode = this.textBox_GiftCode.Text;
            model.Name = this.textBox_GiftName.Text;
            model.Photo = this.textBox_Photo.Text;
            model.Point = int.Parse(this.TextBox_Point.Text.Trim());
            model.Number = int.Parse(this.TextBox_Number.Text.Trim());
            model.ExchangeNumber = 0;
            if (this.label_GiftID.Text == "")
            {
                if (eg.Exists(this.textBox_GiftCode.Text.Trim()))
                {
                    MessageBox.Show("礼品编号重复，请重新输入！");
                    return;
                }

                if (eg.Add(model)>0)
                {
                    // 记录日志
                    new VipSoft.BLL.SysLog().Add(new VipSoft.Model.SysLog(PublicState.Master, "礼品兑换",  "新增礼品成功，礼品名称：" + this.textBox_GiftName.Text, DateTime.Now));
                    // 提醒
                    MessageBox.Show("礼品增加成功！");
                    this.textBox_GiftCode.Text = "";
                    this.textBox_GiftName.Text = "";
                    this.TextBox_Number.Text = "";
                    this.textBox_Photo.Text = "";
                    this.TextBox_Point.Text = "";
                    BindList();
                    this.myTabControl1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("新增失败，请重试！");
                }
            }
            else
            {
                model.ID = int.Parse(this.label_GiftID.Text);
                if (eg.Update(model))
                {
                    // 记录日志
                    new VipSoft.BLL.SysLog().Add(new VipSoft.Model.SysLog(PublicState.Master, "礼品兑换",  "修改礼品成功，礼品名称：" + this.textBox_GiftName.Text, DateTime.Now));
                    // 提醒
                    MessageBox.Show("礼品修改成功！");
                    this.textBox_GiftCode.Text = "";
                    this.textBox_GiftName.Text = "";
                    this.TextBox_Number.Text = "";
                    this.textBox_Photo.Text = "";
                    this.TextBox_Point.Text = "";
                    this.label_GiftID.Text = "";
                    BindList();
                    this.myTabControl1.SelectedIndex = 0;
                }
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GiftList_Load(object sender, EventArgs e)
        {
            BindList();
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
                this.contextMenuStrip_Right.Show(dataGridView_List, point);
            }
        }

        private void ToolStripMenuItem_Right_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int id = int.Parse(this.dataGridView_List.SelectedRows[0].Cells["ID"].Value.ToString());
            switch (item.Name)
            {
                case "ToolStripMenuItem_Add":
                    this.myTabControl1.SelectedIndex = 1;
                    this.tabPage2.Text = "新增礼品";
                    this.textBox_GiftCode.Text = "";
                    this.textBox_GiftCode.Enabled = true;
                    this.textBox_GiftName.Text = "";
                    this.TextBox_Number.Text = "";
                    this.textBox_Photo.Text = "";
                    this.TextBox_Point.Text = "";
                    this.label_GiftID.Text = "";
                    break;
                case "ToolStripMenuItem_Edit":
                    if (id != 0)
                    {
                        this.textBox_GiftCode.Text = this.dataGridView_List.SelectedRows[0].Cells["GiftCode"].Value.ToString();
                        this.textBox_GiftCode.Enabled = false;
                        this.textBox_GiftName.Text = this.dataGridView_List.SelectedRows[0].Cells["Name"].Value.ToString();
                        this.TextBox_Point.Text = this.dataGridView_List.SelectedRows[0].Cells["Point"].Value.ToString();
                        this.TextBox_Number.Text = this.dataGridView_List.SelectedRows[0].Cells["Number"].Value.ToString();
                        this.textBox_Photo.Text = this.dataGridView_List.SelectedRows[0].Cells["Photo"].Value.ToString();
                        this.pictureBox1.ImageLocation = Application.StartupPath + this.dataGridView_List.SelectedRows[0].Cells["Photo"].Value.ToString();
                        this.label_GiftID.Text = id.ToString();
                        this.myTabControl1.SelectedIndex = 1;
                        this.tabPage2.Text = "修改礼品信息";
                    }
                    break;
                case "ToolStripMenuItem_Delete":
                    if (id != 0)
                    {
                        if (MessageBox.Show("确定要删除此礼品信息么？", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (eg.Delete(id))
                            {
                                // 记录日志
                                new VipSoft.BLL.SysLog().Add(new VipSoft.Model.SysLog(PublicState.Master, "礼品兑换", "删除礼品成功，礼品名称：" + this.dataGridView_List.SelectedRows[0].Cells[2].Value.ToString(), DateTime.Now));
                                // 提醒
                                BindList();
                                MessageBox.Show("删除成功！");
                            }
                        }
                    }
                    break;
            }
        }

        private void GiftList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GiftListRefresh != null)
                GiftListRefresh();
        }

        private void alButton1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }
    }
}
