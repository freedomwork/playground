namespace VipSoft.Controls
{
    partial class SearchMember
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_CardID = new System.Windows.Forms.TextBox();
            this.label_Msg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Search = new AlSkin.AlControl.AlButton();
            this.SuspendLayout();
            // 
            // textBox_CardID
            // 
            this.textBox_CardID.Font = new System.Drawing.Font("宋体", 18F);
            this.textBox_CardID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_CardID.Location = new System.Drawing.Point(101, 0);
            this.textBox_CardID.Name = "textBox_CardID";
            this.textBox_CardID.Size = new System.Drawing.Size(216, 35);
            this.textBox_CardID.TabIndex = 0;
            this.textBox_CardID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_CardID_PreviewKeyDown);
            this.textBox_CardID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_CardID_KeyDown);
            // 
            // label_Msg
            // 
            this.label_Msg.AutoSize = true;
            this.label_Msg.Location = new System.Drawing.Point(6, 12);
            this.label_Msg.Name = "label_Msg";
            this.label_Msg.Size = new System.Drawing.Size(95, 12);
            this.label_Msg.TabIndex = 5;
            this.label_Msg.Text = "卡号/手机(F2)：";
            this.label_Msg.Click += new System.EventHandler(this.label_Msg_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_Search.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Search.Image = global::VipSoft.Properties.Resources.query;
            this.button_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Search.Location = new System.Drawing.Point(254, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(60, 30);
            this.button_Search.TabIndex = 7;
            this.button_Search.Text = "(F3)";
            this.button_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // SearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_CardID);
            this.Controls.Add(this.label_Msg);
            this.Name = "SearchMember";
            this.Size = new System.Drawing.Size(320, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AlSkin.AlControl.AlButton button_Search;
        public System.Windows.Forms.TextBox textBox_CardID;
        private System.Windows.Forms.Label label_Msg;
        private System.Windows.Forms.Timer timer1;
    }
}
