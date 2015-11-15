namespace VipSoft.SystemSet
{
    partial class MoneyRuleList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pager1 = new Vipsoft.Controls.Pager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delBtn = new AlSkin.AlControl.AlButton();
            this.resetBtn = new AlSkin.AlControl.AlButton();
            this.saveBtn = new AlSkin.AlControl.AlButton();
            this.f_thantime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.f_3hour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f_2hour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.f_1hour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneHourMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondHourMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdHourMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.id,
            this.name,
            this.oneHourMoney,
            this.secondHourMoney,
            this.thirdHourMoney,
            this.thanTime});
            this.dataGridView1.Location = new System.Drawing.Point(229, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(521, 235);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pager1
            // 
            this.pager1.BackColor = System.Drawing.Color.Transparent;
            this.pager1.BackGroundImage = null;
            this.pager1.CurrentPage = 0;
            this.pager1.Location = new System.Drawing.Point(199, 293);
            this.pager1.Name = "pager1";
            this.pager1.PageCount = 0;
            this.pager1.PagerWidth = 500;
            this.pager1.PageSize = 10;
            this.pager1.RecordCount = 0;
            this.pager1.Size = new System.Drawing.Size(551, 30);
            this.pager1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.delBtn);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.f_thantime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.f_3hour);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.f_2hour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.f_1hour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.f_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 244);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(146, 202);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(51, 23);
            this.delBtn.TabIndex = 20;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(81, 202);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(50, 23);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(16, 202);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(51, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // f_thantime
            // 
            this.f_thantime.Location = new System.Drawing.Point(92, 156);
            this.f_thantime.Name = "f_thantime";
            this.f_thantime.Size = new System.Drawing.Size(113, 21);
            this.f_thantime.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "展        期:";
            // 
            // f_3hour
            // 
            this.f_3hour.Location = new System.Drawing.Point(92, 123);
            this.f_3hour.Name = "f_3hour";
            this.f_3hour.Size = new System.Drawing.Size(113, 21);
            this.f_3hour.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "三个小时收费:";
            // 
            // f_2hour
            // 
            this.f_2hour.Location = new System.Drawing.Point(92, 90);
            this.f_2hour.Name = "f_2hour";
            this.f_2hour.Size = new System.Drawing.Size(113, 21);
            this.f_2hour.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "二个小时收费:";
            // 
            // f_1hour
            // 
            this.f_1hour.Location = new System.Drawing.Point(92, 57);
            this.f_1hour.Name = "f_1hour";
            this.f_1hour.Size = new System.Drawing.Size(113, 21);
            this.f_1hour.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "一个小时收费:";
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(92, 25);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(113, 21);
            this.f_name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "收费规则名称:";
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = " ";
            this.checkbox.Name = "checkbox";
            this.checkbox.Visible = false;
            this.checkbox.Width = 20;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "收费规则名称";
            this.name.Name = "name";
            // 
            // oneHourMoney
            // 
            this.oneHourMoney.DataPropertyName = "oneHourMoney";
            this.oneHourMoney.HeaderText = "一个小时收费";
            this.oneHourMoney.Name = "oneHourMoney";
            // 
            // secondHourMoney
            // 
            this.secondHourMoney.DataPropertyName = "secondHourMoney";
            this.secondHourMoney.HeaderText = "二个小时收费";
            this.secondHourMoney.Name = "secondHourMoney";
            // 
            // thirdHourMoney
            // 
            this.thirdHourMoney.DataPropertyName = "thirdHourMoney";
            this.thirdHourMoney.HeaderText = "三个小时收费";
            this.thirdHourMoney.Name = "thirdHourMoney";
            // 
            // thanTime
            // 
            this.thanTime.DataPropertyName = "thanTime";
            this.thanTime.HeaderText = "展期";
            this.thanTime.Name = "thanTime";
            // 
            // MoneyRuleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(762, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MoneyRuleList";
            this.Text = "收费规则设置";
            this.Load += new System.EventHandler(this.MoneyRuleList_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pager1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Vipsoft.Controls.Pager pager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox f_thantime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox f_3hour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f_2hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f_1hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label label1;
        private AlSkin.AlControl.AlButton resetBtn;
        private AlSkin.AlControl.AlButton saveBtn;
        private AlSkin.AlControl.AlButton delBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneHourMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondHourMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdHourMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanTime;
    }
}