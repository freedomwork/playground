namespace VipSoft
{
    partial class PointChangeReport
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
            this.groupBox1 = new YiJiaSoft.Controls.MyGroupBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.btnPointPrint = new AlSkin.AlControl.AlButton();
            this.button_Query = new AlSkin.AlControl.AlButton();
            this.button_Close = new AlSkin.AlControl.AlButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MemKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myGroupBox5 = new YiJiaSoft.Controls.MyGroupBox();
            this.loading = new System.Windows.Forms.Label();
            this.dgvPoinList = new System.Windows.Forms.DataGridView();
            this.dgvCollect = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.myGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoinList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollect)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.groupBox1.Controls.Add(this.comboBox_Type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker_End);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker_Start);
            this.groupBox1.Controls.Add(this.btnPointPrint);
            this.groupBox1.Controls.Add(this.button_Query);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_MemKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 82);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据查询";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(316, 48);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(219, 20);
            this.comboBox_Type.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(238, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "按类型查看：";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_End.Location = new System.Drawing.Point(434, 18);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.ShowCheckBox = true;
            this.dateTimePicker_End.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_End.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "至";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(316, 18);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.ShowCheckBox = true;
            this.dateTimePicker_Start.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_Start.TabIndex = 33;
            this.dateTimePicker_Start.Value = new System.DateTime(2010, 1, 1, 15, 7, 0, 0);
            // 
            // btnPointPrint
            // 
            this.btnPointPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPointPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPointPrint.Location = new System.Drawing.Point(656, 36);
            this.btnPointPrint.Name = "btnPointPrint";
            this.btnPointPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPointPrint.TabIndex = 30;
            this.btnPointPrint.Text = "导出打印";
            this.btnPointPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPointPrint.UseVisualStyleBackColor = false;
            // 
            // button_Query
            // 
            this.button_Query.BackColor = System.Drawing.Color.Transparent;
            this.button_Query.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Query.Location = new System.Drawing.Point(566, 36);
            this.button_Query.Name = "button_Query";
            this.button_Query.Size = new System.Drawing.Size(80, 30);
            this.button_Query.TabIndex = 30;
            this.button_Query.Text = "数据查询";
            this.button_Query.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Query.UseVisualStyleBackColor = false;
            this.button_Query.Click += new System.EventHandler(this.button_Query_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Close.Location = new System.Drawing.Point(745, 36);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(80, 30);
            this.button_Close.TabIndex = 29;
            this.button_Close.Text = "退出(Esc)";
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "变动日期：";
            // 
            // textBox_MemKey
            // 
            this.textBox_MemKey.Location = new System.Drawing.Point(126, 18);
            this.textBox_MemKey.Name = "textBox_MemKey";
            this.textBox_MemKey.Size = new System.Drawing.Size(100, 21);
            this.textBox_MemKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员编号或姓名：";
            // 
            // myGroupBox5
            // 
            this.myGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.myGroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.myGroupBox5.Controls.Add(this.loading);
            this.myGroupBox5.Controls.Add(this.dgvPoinList);
            this.myGroupBox5.Controls.Add(this.dgvCollect);
            this.myGroupBox5.Location = new System.Drawing.Point(12, 134);
            this.myGroupBox5.Name = "myGroupBox5";
            this.myGroupBox5.Size = new System.Drawing.Size(856, 475);
            this.myGroupBox5.TabIndex = 16;
            this.myGroupBox5.TabStop = false;
            this.myGroupBox5.Text = "积分变动内容";
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.BackColor = System.Drawing.Color.White;
            this.loading.Location = new System.Drawing.Point(371, 200);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(89, 12);
            this.loading.TabIndex = 2;
            this.loading.Text = "暂无信息......";
            // 
            // dgvPoinList
            // 
            this.dgvPoinList.AllowUserToAddRows = false;
            this.dgvPoinList.AllowUserToDeleteRows = false;
            this.dgvPoinList.AllowUserToResizeRows = false;
            this.dgvPoinList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoinList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPoinList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPoinList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoinList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4});
            this.dgvPoinList.Location = new System.Drawing.Point(3, 17);
            this.dgvPoinList.Name = "dgvPoinList";
            this.dgvPoinList.ReadOnly = true;
            this.dgvPoinList.RowHeadersVisible = false;
            this.dgvPoinList.RowTemplate.Height = 23;
            this.dgvPoinList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoinList.Size = new System.Drawing.Size(850, 481);
            this.dgvPoinList.TabIndex = 0;
            // 
            // dgvCollect
            // 
            this.dgvCollect.AllowUserToAddRows = false;
            this.dgvCollect.AllowUserToDeleteRows = false;
            this.dgvCollect.AllowUserToResizeRows = false;
            this.dgvCollect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCollect.BackgroundColor = System.Drawing.Color.White;
            this.dgvCollect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCollect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCollect.Location = new System.Drawing.Point(3, 17);
            this.dgvCollect.Name = "dgvCollect";
            this.dgvCollect.ReadOnly = true;
            this.dgvCollect.RowHeadersVisible = false;
            this.dgvCollect.RowTemplate.Height = 23;
            this.dgvCollect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollect.Size = new System.Drawing.Size(850, 455);
            this.dgvCollect.TabIndex = 1;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "产品编号";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "产品名称";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "￥0.00";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Column10.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column10.HeaderText = "单价";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.HeaderText = "消费数量";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "￥0.00";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Column12.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column12.HeaderText = "折后总价";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "会员卡号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "会员姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "变动积分";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "操作类型";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "店铺";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "日期";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // PointChangeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 623);
            this.Controls.Add(this.myGroupBox5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PointChangeReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "积分变动统计表";
            this.Load += new System.EventHandler(this.PointChangeReport_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.myGroupBox5, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.myGroupBox5.ResumeLayout(false);
            this.myGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoinList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private YiJiaSoft.Controls.MyGroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private AlSkin.AlControl.AlButton btnPointPrint;
        private AlSkin.AlControl.AlButton button_Query;
        private AlSkin.AlControl.AlButton button_Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MemKey;
        private System.Windows.Forms.Label label1;
        private YiJiaSoft.Controls.MyGroupBox myGroupBox5;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.DataGridView dgvPoinList;
        private System.Windows.Forms.DataGridView dgvCollect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}