using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VipSoft.Model;

namespace VipSoft.SystemSet
{

    

    public partial class SearchShop : BaseFormNoSkin
    {
        private List<VipSoft.Model.Shop> _dataList = new List<VipSoft.Model.Shop>();

        private TextBox _shopIdTxt;

        private TextBox _shopnameTxt;

        String condition = "1=1";

        public SearchShop(TextBox sid, TextBox sname)
        {
                       InitializeComponent();
            _dataList = GetDataList();
            _shopIdTxt = sid;
            _shopnameTxt = sname;
        }

        private List<VipSoft.Model.Shop> GetDataList()
        {
            VipSoft.BLL.Shop sBll = new BLL.Shop();
            List<VipSoft.Model.Shop> stList = new List<VipSoft.Model.Shop>();
            stList = sBll.GetModelList(condition);
            return stList;
        }

        private void SearchShop_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource = _dataList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                _dataList = GetDataList();
            }
            else
            {
                _dataList = _dataList.FindAll(std => std.Name.Contains(this.textBox1.Text));
            }
            this.dataGridView1.DataSource = _dataList;
        }


        private void select_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count ==1)
            {
                _shopIdTxt.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["id"].Value.ToString();
                _shopnameTxt.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["name"].Value.ToString();
                this.Close();
            }
        }



   

    }
}
