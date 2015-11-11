namespace VipSoft
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myTabControl1 = new YiJiaSoft.Controls.MyTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Reset = new AlSkin.AlControl.AlButton();
            this.btn_Save = new AlSkin.AlControl.AlButton();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Link = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ShopName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip_CellRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.myTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip_CellRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabControl1
            // 
            this.myTabControl1.Controls.Add(this.tabPage1);
            this.myTabControl1.Controls.Add(this.tabPage2);
            this.myTabControl1.ItemSize = new System.Drawing.Size(0, 20);
            this.myTabControl1.Location = new System.Drawing.Point(12, 41);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.Padding = new System.Drawing.Point(9, 0);
            this.myTabControl1.PageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(430, 317);
            this.myTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_List);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(422, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "店铺列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.AllowUserToAddRows = false;
            this.dataGridView_List.AllowUserToDeleteRows = false;
            this.dataGridView_List.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Account,
            this.Column_Name,
            this.Column_Telephone,
            this.Column_Sex});
            this.dataGridView_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_List.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_List.MultiSelect = false;
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.ReadOnly = true;
            this.dataGridView_List.RowHeadersWidth = 20;
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_List.Size = new System.Drawing.Size(416, 283);
            this.dataGridView_List.TabIndex = 1;
            this.dataGridView_List.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_List_CellMouseClick);
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "编号";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Visible = false;
            // 
            // Column_Account
            // 
            this.Column_Account.HeaderText = "店铺名称";
            this.Column_Account.Name = "Column_Account";
            this.Column_Account.ReadOnly = true;
            this.Column_Account.Width = 110;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "联系电话";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Width = 110;
            // 
            // Column_Telephone
            // 
            this.Column_Telephone.HeaderText = "地址";
            this.Column_Telephone.Name = "Column_Telephone";
            this.Column_Telephone.ReadOnly = true;
            this.Column_Telephone.Width = 110;
            // 
            // Column_Sex
            // 
            this.Column_Sex.HeaderText = "备注";
            this.Column_Sex.Name = "Column_Sex";
            this.Column_Sex.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Reset);
            this.tabPage2.Controls.Add(this.btn_Save);
            this.tabPage2.Controls.Add(this.txt_Remark);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_Link);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_Tel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_ShopName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新增店铺";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(195, 221);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "取消";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(90, 221);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(124, 141);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(255, 66);
            this.txt_Remark.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "    备注：";
            // 
            // txt_Link
            // 
            this.txt_Link.Location = new System.Drawing.Point(124, 105);
            this.txt_Link.Name = "txt_Link";
            this.txt_Link.Size = new System.Drawing.Size(255, 21);
            this.txt_Link.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "联系地址：";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(124, 74);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(183, 21);
            this.txt_Tel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系方式：";
            // 
            // txt_ShopName
            // 
            this.txt_ShopName.Location = new System.Drawing.Point(124, 43);
            this.txt_ShopName.Name = "txt_ShopName";
            this.txt_ShopName.Size = new System.Drawing.Size(183, 21);
            this.txt_ShopName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "店铺名称：";
            // 
            // contextMenuStrip_CellRight
            // 
            this.contextMenuStrip_CellRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Edit,
            this.toolStripMenuItem_Delete});
            this.contextMenuStrip_CellRight.Name = "contextMenuStrip_Header";
            this.contextMenuStrip_CellRight.ShowImageMargin = false;
            this.contextMenuStrip_CellRight.Size = new System.Drawing.Size(128, 70);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(127, 22);
            this.ToolStripMenuItem_Edit.Text = "修改店铺";
            this.ToolStripMenuItem_Edit.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_Delete
            // 
            this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItem_Delete.Text = "删除店铺";
            this.toolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 370);
            this.Controls.Add(this.myTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "店铺管理";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.Controls.SetChildIndex(this.myTabControl1, 0);
            this.myTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip_CellRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private YiJiaSoft.Controls.MyTabControl myTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Sex;
        private AlSkin.AlControl.AlButton btn_Reset;
        private AlSkin.AlControl.AlButton btn_Save;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ShopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_CellRight;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Delete;
    }
}