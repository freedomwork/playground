namespace VipSoft
{
    partial class SetLevel
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
            this.groupBox1 = new YiJiaSoft.Controls.MyGroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_needpoint = new System.Windows.Forms.TextBox();
            this.label_Flag = new System.Windows.Forms.Label();
            this.button_Close = new AlSkin.AlControl.AlButton();
            this.button_Manage = new AlSkin.AlControl.AlButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Percent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Point = new System.Windows.Forms.TextBox();
            this.textBox_LevelName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Delete = new AlSkin.AlControl.AlButton();
            this.button_Edit = new AlSkin.AlControl.AlButton();
            this.button_Add = new AlSkin.AlControl.AlButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_needpoint);
            this.groupBox1.Controls.Add(this.label_Flag);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_Manage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_Percent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Point);
            this.groupBox1.Controls.Add(this.textBox_LevelName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "增加/修改等级";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(185, 61);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "帮助";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(191, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 17;
            // 
            // textBox_needpoint
            // 
            this.textBox_needpoint.Location = new System.Drawing.Point(91, 57);
            this.textBox_needpoint.MaxLength = 8;
            this.textBox_needpoint.Name = "textBox_needpoint";
            this.textBox_needpoint.Size = new System.Drawing.Size(90, 21);
            this.textBox_needpoint.TabIndex = 16;
            // 
            // label_Flag
            // 
            this.label_Flag.AutoSize = true;
            this.label_Flag.Location = new System.Drawing.Point(197, 31);
            this.label_Flag.Name = "label_Flag";
            this.label_Flag.Size = new System.Drawing.Size(23, 12);
            this.label_Flag.TabIndex = 14;
            this.label_Flag.Text = "add";
            this.label_Flag.Visible = false;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Close.Location = new System.Drawing.Point(320, 152);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(77, 23);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "关闭(Esc)";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Manage
            // 
            this.button_Manage.BackColor = System.Drawing.Color.Transparent;
            this.button_Manage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Manage.Location = new System.Drawing.Point(160, 152);
            this.button_Manage.Name = "button_Manage";
            this.button_Manage.Size = new System.Drawing.Size(77, 23);
            this.button_Manage.TabIndex = 5;
            this.button_Manage.Text = "新增等级";
            this.button_Manage.UseVisualStyleBackColor = false;
            this.button_Manage.Click += new System.EventHandler(this.button_Manage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(183, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(413, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "（注：达到此等级时，所能享受的折扣率，如：0.8表示八折，1表示不打折）";
            // 
            // textBox_Percent
            // 
            this.textBox_Percent.Location = new System.Drawing.Point(91, 117);
            this.textBox_Percent.MaxLength = 8;
            this.textBox_Percent.Name = "textBox_Percent";
            this.textBox_Percent.Size = new System.Drawing.Size(90, 21);
            this.textBox_Percent.TabIndex = 4;
            this.textBox_Percent.Text = "1.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(184, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "（注：消费XX人民币自动兑换成1个积分，默认：10RMB=1积分）";
            // 
            // textBox_Point
            // 
            this.textBox_Point.Location = new System.Drawing.Point(91, 87);
            this.textBox_Point.MaxLength = 8;
            this.textBox_Point.Name = "textBox_Point";
            this.textBox_Point.Size = new System.Drawing.Size(90, 21);
            this.textBox_Point.TabIndex = 3;
            this.textBox_Point.Text = "10";
            // 
            // textBox_LevelName
            // 
            this.textBox_LevelName.Location = new System.Drawing.Point(91, 27);
            this.textBox_LevelName.Name = "textBox_LevelName";
            this.textBox_LevelName.Size = new System.Drawing.Size(90, 21);
            this.textBox_LevelName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "折扣比例：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "兑换比例：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大积分：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "等级名称：";
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.AllowUserToAddRows = false;
            this.dataGridView_List.AllowUserToDeleteRows = false;
            this.dataGridView_List.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LevelName,
            this.NeedPoint,
            this.Point,
            this.Percent});
            this.dataGridView_List.Location = new System.Drawing.Point(12, 240);
            this.dataGridView_List.MultiSelect = false;
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.ReadOnly = true;
            this.dataGridView_List.RowHeadersWidth = 20;
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_List.Size = new System.Drawing.Size(490, 174);
            this.dataGridView_List.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 10F;
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // LevelName
            // 
            this.LevelName.DataPropertyName = "LevelName";
            this.LevelName.HeaderText = "等级名称";
            this.LevelName.Name = "LevelName";
            this.LevelName.ReadOnly = true;
            this.LevelName.Width = 110;
            // 
            // NeedPoint
            // 
            this.NeedPoint.DataPropertyName = "NeedPoint";
            this.NeedPoint.HeaderText = "最大积分";
            this.NeedPoint.Name = "NeedPoint";
            this.NeedPoint.ReadOnly = true;
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "兑换比例";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "Percent";
            this.Percent.HeaderText = "折扣比例";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Transparent;
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Delete.Location = new System.Drawing.Point(524, 339);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "删除选中行";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.Transparent;
            this.button_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Edit.Location = new System.Drawing.Point(524, 297);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 11;
            this.button_Edit.Text = "编辑选中行";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Transparent;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(524, 255);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = "重置信息";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // SetLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 453);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_List);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetLevel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员等级";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetLevel_FormClosed);
            this.Load += new System.EventHandler(this.SetLevel_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView_List, 0);
            this.Controls.SetChildIndex(this.button_Add, 0);
            this.Controls.SetChildIndex(this.button_Edit, 0);
            this.Controls.SetChildIndex(this.button_Delete, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private YiJiaSoft.Controls.MyGroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_needpoint;
        private System.Windows.Forms.Label label_Flag;
        private AlSkin.AlControl.AlButton button_Close;
        private AlSkin.AlControl.AlButton button_Manage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Percent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Point;
        private System.Windows.Forms.TextBox textBox_LevelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private AlSkin.AlControl.AlButton button_Delete;
        private AlSkin.AlControl.AlButton button_Edit;
        private AlSkin.AlControl.AlButton button_Add;
    }
}