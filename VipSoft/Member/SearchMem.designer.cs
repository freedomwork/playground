namespace VipSoft
{
    partial class SearchMem
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
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close = new AlSkin.AlControl.AlButton();
            this.button_Select = new AlSkin.AlControl.AlButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Column_CardID,
            this.Column_Name,
            this.Column_TotalMoney,
            this.Column_Level});
            this.dataGridView_List.Location = new System.Drawing.Point(5, 5);
            this.dataGridView_List.MultiSelect = false;
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.ReadOnly = true;
            this.dataGridView_List.RowHeadersWidth = 20;
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_List.Size = new System.Drawing.Size(410, 300);
            this.dataGridView_List.TabIndex = 2;
            this.dataGridView_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_List_CellDoubleClick);
            this.dataGridView_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_List_KeyDown);
            // 
            // Column_ID
            // 
            this.Column_ID.DataPropertyName = "ID";
            this.Column_ID.HeaderText = "自动编号";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Visible = false;
            // 
            // Column_CardID
            // 
            this.Column_CardID.DataPropertyName = "CardID";
            this.Column_CardID.HeaderText = "会员卡号";
            this.Column_CardID.Name = "Column_CardID";
            this.Column_CardID.ReadOnly = true;
            // 
            // Column_Name
            // 
            this.Column_Name.DataPropertyName = "Name";
            this.Column_Name.HeaderText = "会员姓名";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Width = 80;
            // 
            // Column_TotalMoney
            // 
            this.Column_TotalMoney.DataPropertyName = "TotalMoney";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "￥0.00";
            this.Column_TotalMoney.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_TotalMoney.HeaderText = "累计消费";
            this.Column_TotalMoney.Name = "Column_TotalMoney";
            this.Column_TotalMoney.ReadOnly = true;
            this.Column_TotalMoney.Width = 90;
            // 
            // Column_Level
            // 
            this.Column_Level.DataPropertyName = "LevelID";
            this.Column_Level.HeaderText = "会员等级";
            this.Column_Level.Name = "Column_Level";
            this.Column_Level.ReadOnly = true;
            this.Column_Level.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(161)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.textBox_Key);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Controls.Add(this.button_Select);
            this.panel1.Controls.Add(this.dataGridView_List);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 345);
            this.panel1.TabIndex = 0;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(115, 315);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(120, 21);
            this.textBox_Key.TabIndex = 4;
            this.textBox_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Key_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "卡号/姓名/手机：";
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Close.Location = new System.Drawing.Point(328, 314);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "关闭(Esc)";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Select
            // 
            this.button_Select.BackColor = System.Drawing.Color.Transparent;
            this.button_Select.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Select.Location = new System.Drawing.Point(244, 314);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(75, 23);
            this.button_Select.TabIndex = 5;
            this.button_Select.Text = "选择(F5)";
            this.button_Select.UseVisualStyleBackColor = false;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // SearchMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 345);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchMem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "简单会员搜索";
            this.Deactivate += new System.EventHandler(this.SearchMem_Deactivate);
            this.Load += new System.EventHandler(this.SearchMem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Level;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label1;
        private AlSkin.AlControl.AlButton button_Close;
        private AlSkin.AlControl.AlButton button_Select;



    }
}