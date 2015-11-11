namespace VipSoft
{
    partial class ExpHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_OrderList = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_List_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_DetailList = new System.Windows.Forms.DataGridView();
            this.Column_GoodsCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DiscountPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExport = new AlSkin.AlControl.AlButton();
            this.btnClose = new AlSkin.AlControl.AlButton();
            this.btnQuery = new AlSkin.AlControl.AlButton();
            this.textBox_Remark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_PayType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_OrderType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CardID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetailList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView_OrderList);
            this.groupBox1.Location = new System.Drawing.Point(16, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单列表";
            // 
            // dataGridView_OrderList
            // 
            this.dataGridView_OrderList.AllowUserToAddRows = false;
            this.dataGridView_OrderList.AllowUserToDeleteRows = false;
            this.dataGridView_OrderList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_OrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_OrderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_OrderCode,
            this.Column_CardID,
            this.Column_MemName,
            this.Column_Money,
            this.Column1,
            this.Column_Discount,
            this.Column_List_Number,
            this.Column_Point,
            this.Column_OrderType,
            this.Column_CreateTime});
            this.dataGridView_OrderList.Location = new System.Drawing.Point(4, 21);
            this.dataGridView_OrderList.MultiSelect = false;
            this.dataGridView_OrderList.Name = "dataGridView_OrderList";
            this.dataGridView_OrderList.ReadOnly = true;
            this.dataGridView_OrderList.RowHeadersWidth = 20;
            this.dataGridView_OrderList.RowTemplate.Height = 23;
            this.dataGridView_OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_OrderList.Size = new System.Drawing.Size(844, 251);
            this.dataGridView_OrderList.TabIndex = 8;
            this.dataGridView_OrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrderList_CellDoubleClick);
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "编号";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Visible = false;
            // 
            // Column_OrderCode
            // 
            this.Column_OrderCode.HeaderText = "订单号";
            this.Column_OrderCode.Name = "Column_OrderCode";
            this.Column_OrderCode.ReadOnly = true;
            this.Column_OrderCode.Width = 80;
            // 
            // Column_CardID
            // 
            this.Column_CardID.HeaderText = "会员卡号";
            this.Column_CardID.Name = "Column_CardID";
            this.Column_CardID.ReadOnly = true;
            // 
            // Column_MemName
            // 
            this.Column_MemName.HeaderText = "会员姓名";
            this.Column_MemName.Name = "Column_MemName";
            this.Column_MemName.ReadOnly = true;
            this.Column_MemName.Width = 80;
            // 
            // Column_Money
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "￥0.00";
            this.Column_Money.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_Money.HeaderText = "金额";
            this.Column_Money.Name = "Column_Money";
            this.Column_Money.ReadOnly = true;
            this.Column_Money.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "折后金额";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column_Discount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "￥0.00";
            this.Column_Discount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_Discount.HeaderText = "实际支付";
            this.Column_Discount.Name = "Column_Discount";
            this.Column_Discount.ReadOnly = true;
            this.Column_Discount.Width = 80;
            // 
            // Column_List_Number
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column_List_Number.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_List_Number.HeaderText = "数量";
            this.Column_List_Number.Name = "Column_List_Number";
            this.Column_List_Number.ReadOnly = true;
            this.Column_List_Number.Width = 60;
            // 
            // Column_Point
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column_Point.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_Point.HeaderText = "积分";
            this.Column_Point.Name = "Column_Point";
            this.Column_Point.ReadOnly = true;
            this.Column_Point.Width = 60;
            // 
            // Column_OrderType
            // 
            this.Column_OrderType.HeaderText = "类型";
            this.Column_OrderType.Name = "Column_OrderType";
            this.Column_OrderType.ReadOnly = true;
            this.Column_OrderType.Width = 60;
            // 
            // Column_CreateTime
            // 
            this.Column_CreateTime.HeaderText = "时间";
            this.Column_CreateTime.Name = "Column_CreateTime";
            this.Column_CreateTime.ReadOnly = true;
            this.Column_CreateTime.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView_DetailList);
            this.groupBox2.Location = new System.Drawing.Point(16, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 225);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单内容";
            // 
            // dataGridView_DetailList
            // 
            this.dataGridView_DetailList.AllowUserToAddRows = false;
            this.dataGridView_DetailList.AllowUserToDeleteRows = false;
            this.dataGridView_DetailList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DetailList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_DetailList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_DetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_GoodsCode,
            this.Column_GoodsName,
            this.Column_Price,
            this.Column_Number,
            this.Column_DiscountPrice});
            this.dataGridView_DetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DetailList.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_DetailList.MultiSelect = false;
            this.dataGridView_DetailList.Name = "dataGridView_DetailList";
            this.dataGridView_DetailList.ReadOnly = true;
            this.dataGridView_DetailList.RowHeadersWidth = 20;
            this.dataGridView_DetailList.RowTemplate.Height = 23;
            this.dataGridView_DetailList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_DetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DetailList.Size = new System.Drawing.Size(847, 205);
            this.dataGridView_DetailList.TabIndex = 3;
            // 
            // Column_GoodsCode
            // 
            this.Column_GoodsCode.DataPropertyName = "GoodsCode";
            this.Column_GoodsCode.HeaderText = "产品编号";
            this.Column_GoodsCode.Name = "Column_GoodsCode";
            this.Column_GoodsCode.ReadOnly = true;
            // 
            // Column_GoodsName
            // 
            this.Column_GoodsName.DataPropertyName = "GoodsName";
            this.Column_GoodsName.HeaderText = "产品名称";
            this.Column_GoodsName.Name = "Column_GoodsName";
            this.Column_GoodsName.ReadOnly = true;
            this.Column_GoodsName.Width = 300;
            // 
            // Column_Price
            // 
            this.Column_Price.DataPropertyName = "Price";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "￥0.00";
            this.Column_Price.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_Price.HeaderText = "单价";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ReadOnly = true;
            // 
            // Column_Number
            // 
            this.Column_Number.DataPropertyName = "Number";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column_Number.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_Number.HeaderText = "数量";
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.ReadOnly = true;
            // 
            // Column_DiscountPrice
            // 
            this.Column_DiscountPrice.DataPropertyName = "DiscountPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "￥0.00";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.Column_DiscountPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column_DiscountPrice.HeaderText = "合计";
            this.Column_DiscountPrice.Name = "Column_DiscountPrice";
            this.Column_DiscountPrice.ReadOnly = true;
            this.Column_DiscountPrice.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Controls.Add(this.textBox_Remark);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox_PayType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox_OrderType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePicker_End);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePicker_Start);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_CardID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 77);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(771, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(692, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(613, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textBox_Remark
            // 
            this.textBox_Remark.Location = new System.Drawing.Point(526, 44);
            this.textBox_Remark.Name = "textBox_Remark";
            this.textBox_Remark.Size = new System.Drawing.Size(105, 21);
            this.textBox_Remark.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "备注：";
            // 
            // comboBox_PayType
            // 
            this.comboBox_PayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PayType.FormattingEnabled = true;
            this.comboBox_PayType.Location = new System.Drawing.Point(323, 44);
            this.comboBox_PayType.Name = "comboBox_PayType";
            this.comboBox_PayType.Size = new System.Drawing.Size(150, 20);
            this.comboBox_PayType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "支付方式：";
            // 
            // comboBox_OrderType
            // 
            this.comboBox_OrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OrderType.FormattingEnabled = true;
            this.comboBox_OrderType.Location = new System.Drawing.Point(86, 44);
            this.comboBox_OrderType.Name = "comboBox_OrderType";
            this.comboBox_OrderType.Size = new System.Drawing.Size(150, 20);
            this.comboBox_OrderType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "消费类型：";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(476, 14);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.ShowCheckBox = true;
            this.dateTimePicker_End.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker_End.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "至：";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(323, 14);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.ShowCheckBox = true;
            this.dateTimePicker_Start.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "消费日期：";
            // 
            // textBox_CardID
            // 
            this.textBox_CardID.Location = new System.Drawing.Point(86, 14);
            this.textBox_CardID.Name = "textBox_CardID";
            this.textBox_CardID.Size = new System.Drawing.Size(150, 21);
            this.textBox_CardID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员卡号：";
            // 
            // ExpHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 678);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消费记录";
            this.Load += new System.EventHandler(this.ExpHistory_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetailList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_OrderList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_DetailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GoodsCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DiscountPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private AlSkin.AlControl.AlButton btnExport;
        private AlSkin.AlControl.AlButton btnClose;
        private AlSkin.AlControl.AlButton btnQuery;
        private System.Windows.Forms.TextBox textBox_Remark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_PayType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_OrderType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CardID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_List_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CreateTime;
    }
}