namespace VipSoft
{
    partial class GiftHistory
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
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchMember1 = new VipSoft.Controls.SearchMember();
            this.label_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.Column_GoodsName,
            this.Column_Point,
            this.Column_Num,
            this.Column_Time});
            this.dataGridView_List.Location = new System.Drawing.Point(16, 102);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.ReadOnly = true;
            this.dataGridView_List.RowHeadersWidth = 20;
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.Size = new System.Drawing.Size(593, 343);
            this.dataGridView_List.TabIndex = 6;
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "编号";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Visible = false;
            // 
            // Column_GoodsName
            // 
            this.Column_GoodsName.HeaderText = "礼品名称";
            this.Column_GoodsName.Name = "Column_GoodsName";
            this.Column_GoodsName.ReadOnly = true;
            this.Column_GoodsName.Width = 250;
            // 
            // Column_Point
            // 
            this.Column_Point.HeaderText = "所需积分";
            this.Column_Point.Name = "Column_Point";
            this.Column_Point.ReadOnly = true;
            // 
            // Column_Num
            // 
            this.Column_Num.HeaderText = "兑换数量";
            this.Column_Num.Name = "Column_Num";
            this.Column_Num.ReadOnly = true;
            // 
            // Column_Time
            // 
            this.Column_Time.HeaderText = "兑换时间";
            this.Column_Time.Name = "Column_Time";
            this.Column_Time.ReadOnly = true;
            this.Column_Time.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.searchMember1);
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按会员查看";
            // 
            // searchMember1
            // 
            this.searchMember1.CardID = "";
            this.searchMember1.IsSmallControl = false;
            this.searchMember1.Location = new System.Drawing.Point(15, 13);
            this.searchMember1.Name = "searchMember1";
            this.searchMember1.Size = new System.Drawing.Size(320, 35);
            this.searchMember1.TabIndex = 0;
            this.searchMember1.EventMemberSelected += new VipSoft.Controls.EventMemberSelectedHandler(this.searchMember1_EventMemberSelected);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.White;
            this.label_Result.Location = new System.Drawing.Point(61, 162);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(77, 12);
            this.label_Result.TabIndex = 8;
            this.label_Result.Text = "label_Result";
            // 
            // GiftHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 458);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GiftHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "积分兑换历史记录";
            this.Load += new System.EventHandler(this.GiftHistory_Load);
            this.Controls.SetChildIndex(this.dataGridView_List, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label_Result, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Time;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.SearchMember searchMember1;
        private System.Windows.Forms.Label label_Result;
    }
}