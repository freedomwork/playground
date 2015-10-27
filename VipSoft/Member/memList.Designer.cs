namespace VipSoft
{
    partial class memList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alButton_excle = new AlSkin.AlControl.AlButton();
            this.button_Select = new AlSkin.AlControl.AlButton();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myTabControl1 = new YiJiaSoft.Controls.MyTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pager1 = new Vipsoft.Controls.Pager();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DelBtn = new System.Windows.Forms.ToolStripButton();
            this.alpanel21 = new AlSkin.AlControl.Alpanel2();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardmianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.myTabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.alButton_excle);
            this.groupBox1.Controls.Add(this.button_Select);
            this.groupBox1.Controls.Add(this.textBox_Key);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会员查询";
            // 
            // alButton_excle
            // 
            this.alButton_excle.Location = new System.Drawing.Point(405, 18);
            this.alButton_excle.Name = "alButton_excle";
            this.alButton_excle.Size = new System.Drawing.Size(104, 30);
            this.alButton_excle.TabIndex = 6;
            this.alButton_excle.Text = "会员导出Excel";
            this.alButton_excle.UseVisualStyleBackColor = true;
            // 
            // button_Select
            // 
            this.button_Select.BackColor = System.Drawing.Color.Transparent;
            this.button_Select.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Select.Location = new System.Drawing.Point(302, 16);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(80, 35);
            this.button_Select.TabIndex = 5;
            this.button_Select.Text = " 查询";
            this.button_Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Select.UseVisualStyleBackColor = false;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("宋体", 18F);
            this.textBox_Key.Location = new System.Drawing.Point(109, 16);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(187, 35);
            this.textBox_Key.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "会员卡号/手机号：";
            // 
            // myTabControl1
            // 
            this.myTabControl1.Controls.Add(this.tabPage1);
            this.myTabControl1.Controls.Add(this.tabPage2);
            this.myTabControl1.ItemSize = new System.Drawing.Size(0, 20);
            this.myTabControl1.Location = new System.Drawing.Point(12, 130);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.Padding = new System.Drawing.Point(9, 0);
            this.myTabControl1.PageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(169, 426);
            this.myTabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(161, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "按分类查看";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(161, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "高级查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pager1
            // 
            this.pager1.BackColor = System.Drawing.Color.Transparent;
            this.pager1.BackGroundImage = null;
            this.pager1.CurrentPage = 0;
            this.pager1.Location = new System.Drawing.Point(12, 564);
            this.pager1.Name = "pager1";
            this.pager1.PageCount = 0;
            this.pager1.PagerWidth = 500;
            this.pager1.PageSize = 10;
            this.pager1.RecordCount = 0;
            this.pager1.Size = new System.Drawing.Size(861, 30);
            this.pager1.TabIndex = 7;
            this.pager1.EventPaging += new Vipsoft.Controls.EventPagingHandler(this.pager1_EventPaging);
            // 
            // AddBtn
            // 
            this.AddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddBtn.Image = global::VipSoft.Properties.Resources.新增;
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(64, 29);
            this.AddBtn.Text = "toolStripButton1";
            this.AddBtn.Click += new System.EventHandler(this.menu_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // UpdBtn
            // 
            this.UpdBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdBtn.Image = global::VipSoft.Properties.Resources.修改;
            this.UpdBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(64, 29);
            this.UpdBtn.Text = "toolStripButton2";
            this.UpdBtn.Click += new System.EventHandler(this.menu_click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImage = global::VipSoft.Properties.Resources.ToolStrip_BG;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(33, 16);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.toolStripSeparator1,
            this.UpdBtn,
            this.toolStripSeparator2,
            this.DelBtn});
            this.toolStrip1.Location = new System.Drawing.Point(11, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 32);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DelBtn
            // 
            this.DelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelBtn.Image = global::VipSoft.Properties.Resources.删除;
            this.DelBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(64, 29);
            this.DelBtn.Text = "toolStripButton3";
            this.DelBtn.Click += new System.EventHandler(this.menu_click);
            // 
            // alpanel21
            // 
            this.alpanel21.Location = new System.Drawing.Point(180, 538);
            this.alpanel21.Name = "alpanel21";
            this.alpanel21.Size = new System.Drawing.Size(695, 100);
            this.alpanel21.TabIndex = 24;
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.AllowUserToAddRows = false;
            this.dataGridView_List.AllowUserToDeleteRows = false;
            this.dataGridView_List.AllowUserToResizeRows = false;
            this.dataGridView_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_List.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.ID,
            this.CardID,
            this.CardmianID,
            this.MemName,
            this.Mobile,
            this.Email});
            this.dataGridView_List.Location = new System.Drawing.Point(182, 136);
            this.dataGridView_List.MultiSelect = false;
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.RowHeadersVisible = false;
            this.dataGridView_List.RowHeadersWidth = 20;
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_List.Size = new System.Drawing.Size(690, 402);
            this.dataGridView_List.TabIndex = 25;
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 20;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CardID
            // 
            this.CardID.DataPropertyName = "CardID";
            this.CardID.HeaderText = "会员卡号";
            this.CardID.Name = "CardID";
            this.CardID.ReadOnly = true;
            // 
            // CardmianID
            // 
            this.CardmianID.DataPropertyName = "CardmianID";
            this.CardmianID.HeaderText = "卡面号";
            this.CardmianID.Name = "CardmianID";
            this.CardmianID.ReadOnly = true;
            // 
            // MemName
            // 
            this.MemName.DataPropertyName = "Name";
            this.MemName.HeaderText = "会员姓名";
            this.MemName.Name = "MemName";
            this.MemName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "手机号码";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮件";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // memList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 600);
            this.Controls.Add(this.dataGridView_List);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.myTabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.alpanel21);
            this.Name = "memList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员列表";
            this.Load += new System.EventHandler(this.memList_Load);
            this.Controls.SetChildIndex(this.alpanel21, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.myTabControl1, 0);
            this.Controls.SetChildIndex(this.pager1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.dataGridView_List, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.myTabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private YiJiaSoft.Controls.MyTabControl myTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Vipsoft.Controls.Pager pager1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton UpdBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DelBtn;
        private AlSkin.AlControl.Alpanel2 alpanel21;
        private AlSkin.AlControl.AlButton alButton_excle;
        private AlSkin.AlControl.AlButton button_Select;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardmianID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;

    }
}