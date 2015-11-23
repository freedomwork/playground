using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace VipSoft.SystemSet
{
    public partial class Master : BaseForm
    {

        int pageSize = 500;
        int currentPage = 0;
        int resCount = 0;
        int pageCount = 0;

        int currentId = 0;

        String condition = "";

        public Master()
        {
              
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void Master_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadDic();
            BindList();
        }

        private void BindList()
        {
            VipSoft.BLL.Master mrBll = new BLL.Master();
            DataSet ds = mrBll.GetList(pageSize, currentPage, out resCount, condition);
            this.dataGridView1.DataSource = ds.Tables[0];

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }

            BindPage();
        }

        private void BindPage()
        {
            this.pager1.PageSize = pageSize;
            this.pager1.CurrentPage = currentPage;
            this.pager1.RecordCount = resCount;
            this.pager1.PagerBind();
        }

        private void f_shopname_Click(object sender, EventArgs e)
        {
            SearchShop search = new SearchShop(this.f_shopid, this.f_shopname);
            search.ShowDialog();
        }

        private void f_shopname_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadDic()
        {

            this.f_sex.Items.Add(new System.Collections.DictionaryEntry("未知", 0));
            this.f_sex.Items.Add(new System.Collections.DictionaryEntry("男", 1));
            this.f_sex.Items.Add(new System.Collections.DictionaryEntry("女", 2));
            this.f_sex.DisplayMember = "key";
            this.f_sex.ValueMember = "value";
            this.f_sex.SelectedIndex = 0;
        }

        private void alButton1_Click(object sender, EventArgs e)
        {
            VipSoft.BLL.Master mBll = new BLL.Master();
            VipSoft.Model.Master mModel = new Model.Master();

            String account = this.f_account.Text.ToString();
            String password = this.f_password.Text.ToString();
            String name = this.f_name.Text.ToString();
            String shopid = this.f_shopid.Text.ToString();

            if (account == null || account == "")
            {
                MessageBox.Show("管理员代码不能为空!");
                return;
            }

            if (password == null || password == "")
            {
                MessageBox.Show("管理员密码不能为空!");
                return;
            }

            if (name == null || name == "")
            {
                MessageBox.Show("管理员名称不能为空!");
                return;
            }

            if (shopid == null || shopid == "")
            {
                MessageBox.Show("所属机构不能为空!");
                return;
            }

            mModel.Account = account;
            mModel.Password = password;
            mModel.Name = name;
            mModel.TelPhone = this.f_telphone.Text.ToString();
            mModel.Sex = int.Parse(((System.Collections.DictionaryEntry)f_sex.Items[0]).Value.ToString());
            mModel.IsSuper = f_issuper.Checked;
            mModel.ShopID = int.Parse(f_shopid.Text.ToString());
            mModel.ShopName = f_shopname.Text.ToString();

            if (this.currentId == 0)
            {
                if (mBll.Add(mModel) > 0)
                {
                    MessageBox.Show("新增记录成功!");
                    BindList();
                    reset();
                }
                else
                {
                    MessageBox.Show("新增记录失败!");
                }
            }
            else
            {
                mModel.ID = currentId;
                if (mBll.Update(mModel))
                {
                    MessageBox.Show("修改记录成功!");
                    BindList();
                    reset();


                }
                else
                {
                    MessageBox.Show("修改记录失败!");
                }

            }
        }

        private void delBtn_Click()
        {
            if (currentId > 0)
             {
                 VipSoft.BLL.Master mBll = new BLL.Master();
                 if (mBll.Delete(currentId))
                 {
                     MessageBox.Show("删除管理员成功!");
                     BindList();
                     reset();
                 }
             }
             else
             {
                 MessageBox.Show("请先选择一条数据!");
             }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex == -1)
                    return;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                row.Selected = true;
                Point point = this.dataGridView1.PointToClient(Cursor.Position);
                this.contextMenuStrip_CellRight.Show(this.dataGridView1, point);
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            currentId = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["id"].Value.ToString());
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Name)
            {
                // 编辑
                case "modifyItem":
                    this.tabControl1.SelectedIndex = 1;
                    BindMasterInfo();
                    break;
                // 删除
                case "deleteItem":
                    delBtn_Click();
                    break;
            }
        }
      

        private void BindMasterInfo() {
            VipSoft.BLL.Master mBll = new BLL.Master();
            VipSoft.Model.Master model = mBll.GetModel(currentId);
            if (model != null)
            {
                this.f_account.Text = model.Account;
                this.f_name.Text = model.Name;
                this.f_password.Text = model.Password;
                this.f_sex.SelectedIndex = (int)model.Sex;
                this.f_issuper.Checked = model.IsSuper;
                this.f_telphone.Text = model.TelPhone;
                this.f_shopid.Text = model.ShopID.ToString();
                this.f_shopname.Text = model.ShopName;
            }
        }

        private void reset()
        {
            this.f_account.Text = "";
            this.f_name.Text = "";
            this.f_password.Text ="";
            this.f_sex.SelectedIndex = 0;
            this.f_issuper.Checked = false;
            this.f_telphone.Text = "";
            this.f_shopid.Text = "";
            this.f_shopname.Text = "";
            this.currentId = 0;

        }




    }
}
