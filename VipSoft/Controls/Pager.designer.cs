namespace Vipsoft.Controls
{
    partial class Pager
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
            this.button_First = new System.Windows.Forms.Button();
            this.label_PageInfo = new System.Windows.Forms.Label();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.textBox_Jump = new System.Windows.Forms.TextBox();
            this.linkLabel_Jump = new System.Windows.Forms.LinkLabel();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.panel_Info.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_First
            // 
            this.button_First.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_First.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_First.FlatAppearance.BorderSize = 0;
            this.button_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_First.Image = global::VipSoft.Properties.Resources.Page_First;
            this.button_First.Location = new System.Drawing.Point(3, 3);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(20, 20);
            this.button_First.TabIndex = 1;
            this.button_First.UseVisualStyleBackColor = false;
            this.button_First.Click += new System.EventHandler(this.PageButton_Click);
            // 
            // label_PageInfo
            // 
            this.label_PageInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_PageInfo.AutoSize = true;
            this.label_PageInfo.Location = new System.Drawing.Point(33, 9);
            this.label_PageInfo.Name = "label_PageInfo";
            this.label_PageInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_PageInfo.Size = new System.Drawing.Size(215, 12);
            this.label_PageInfo.TabIndex = 2;
            this.label_PageInfo.Text = "共{0}条记录 每页{1}条 当前{2}/{3}页";
            this.label_PageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Prev
            // 
            this.button_Prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Prev.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Prev.FlatAppearance.BorderSize = 0;
            this.button_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Prev.Image = global::VipSoft.Properties.Resources.Page_Prev;
            this.button_Prev.Location = new System.Drawing.Point(27, 3);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(20, 20);
            this.button_Prev.TabIndex = 3;
            this.button_Prev.UseVisualStyleBackColor = false;
            this.button_Prev.Click += new System.EventHandler(this.PageButton_Click);
            // 
            // button_Next
            // 
            this.button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Next.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Image = global::VipSoft.Properties.Resources.Page_Next;
            this.button_Next.Location = new System.Drawing.Point(53, 3);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(20, 20);
            this.button_Next.TabIndex = 4;
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.PageButton_Click);
            // 
            // button_Last
            // 
            this.button_Last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Last.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Last.FlatAppearance.BorderSize = 0;
            this.button_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Last.Image = global::VipSoft.Properties.Resources.Page_Last;
            this.button_Last.Location = new System.Drawing.Point(79, 3);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(20, 20);
            this.button_Last.TabIndex = 5;
            this.button_Last.UseVisualStyleBackColor = false;
            this.button_Last.Click += new System.EventHandler(this.PageButton_Click);
            // 
            // textBox_Jump
            // 
            this.textBox_Jump.Location = new System.Drawing.Point(107, 3);
            this.textBox_Jump.Name = "textBox_Jump";
            this.textBox_Jump.Size = new System.Drawing.Size(35, 21);
            this.textBox_Jump.TabIndex = 6;
            this.textBox_Jump.TabStop = false;
            this.textBox_Jump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Jump_KeyDown);
            // 
            // linkLabel_Jump
            // 
            this.linkLabel_Jump.AutoSize = true;
            this.linkLabel_Jump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Jump.Location = new System.Drawing.Point(152, 7);
            this.linkLabel_Jump.Name = "linkLabel_Jump";
            this.linkLabel_Jump.Size = new System.Drawing.Size(17, 12);
            this.linkLabel_Jump.TabIndex = 7;
            this.linkLabel_Jump.TabStop = true;
            this.linkLabel_Jump.Text = "Go";
            this.linkLabel_Jump.Click += new System.EventHandler(this.linkLabel_Jump_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.label_PageInfo);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Info.Location = new System.Drawing.Point(0, 0);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(489, 30);
            this.panel_Info.TabIndex = 8;
            // 
            // panel_Button
            // 
            this.panel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Button.Controls.Add(this.button_First);
            this.panel_Button.Controls.Add(this.button_Prev);
            this.panel_Button.Controls.Add(this.linkLabel_Jump);
            this.panel_Button.Controls.Add(this.button_Next);
            this.panel_Button.Controls.Add(this.textBox_Jump);
            this.panel_Button.Controls.Add(this.button_Last);
            this.panel_Button.Location = new System.Drawing.Point(270, 3);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(180, 26);
            this.panel_Button.TabIndex = 9;
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel_Info);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(489, 30);
            this.Load += new System.EventHandler(this.Pager_Load);
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.panel_Button.ResumeLayout(false);
            this.panel_Button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Label label_PageInfo;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.TextBox textBox_Jump;
        private System.Windows.Forms.LinkLabel linkLabel_Jump;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Panel panel_Button;
    }
}
