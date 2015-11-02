namespace VipSoft
{
    partial class memCardType
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
            this.cardType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IsExpenseGoods = new System.Windows.Forms.CheckBox();
            this.IsExpensePoint = new System.Windows.Forms.CheckBox();
            this.IsPointAuto = new System.Windows.Forms.CheckBox();
            this.save = new AlSkin.AlControl.AlButton();
            this.id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardType
            // 
            this.cardType.FormattingEnabled = true;
            this.cardType.Location = new System.Drawing.Point(127, 61);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(117, 20);
            this.cardType.TabIndex = 4;
            this.cardType.SelectedIndexChanged += new System.EventHandler(this.cardType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "会员卡类型:";
            // 
            // IsExpenseGoods
            // 
            this.IsExpenseGoods.AutoSize = true;
            this.IsExpenseGoods.BackColor = System.Drawing.Color.Transparent;
            this.IsExpenseGoods.Location = new System.Drawing.Point(48, 106);
            this.IsExpenseGoods.Name = "IsExpenseGoods";
            this.IsExpenseGoods.Size = new System.Drawing.Size(120, 16);
            this.IsExpenseGoods.TabIndex = 6;
            this.IsExpenseGoods.Text = "是否可以商品消费";
            this.IsExpenseGoods.UseVisualStyleBackColor = false;
            // 
            // IsExpensePoint
            // 
            this.IsExpensePoint.AutoSize = true;
            this.IsExpensePoint.BackColor = System.Drawing.Color.Transparent;
            this.IsExpensePoint.Location = new System.Drawing.Point(48, 137);
            this.IsExpensePoint.Name = "IsExpensePoint";
            this.IsExpensePoint.Size = new System.Drawing.Size(120, 16);
            this.IsExpensePoint.TabIndex = 7;
            this.IsExpensePoint.Text = "是否可以计次消费";
            this.IsExpensePoint.UseVisualStyleBackColor = false;
            // 
            // IsPointAuto
            // 
            this.IsPointAuto.AutoSize = true;
            this.IsPointAuto.BackColor = System.Drawing.Color.Transparent;
            this.IsPointAuto.Location = new System.Drawing.Point(48, 168);
            this.IsPointAuto.Name = "IsPointAuto";
            this.IsPointAuto.Size = new System.Drawing.Size(84, 16);
            this.IsPointAuto.TabIndex = 8;
            this.IsPointAuto.Text = "是否可积分";
            this.IsPointAuto.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(111, 209);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 27);
            this.save.TabIndex = 9;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(203, 168);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 12);
            this.id.TabIndex = 10;
            this.id.Visible = false;
            // 
            // memCardType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 285);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardType);
            this.Controls.Add(this.IsExpensePoint);
            this.Controls.Add(this.IsExpenseGoods);
            this.Controls.Add(this.IsPointAuto);
            this.Controls.Add(this.save);
            this.Name = "memCardType";
            this.Text = "卡类型设置";
            this.Load += new System.EventHandler(this.memCardType_Load);
            this.Controls.SetChildIndex(this.save, 0);
            this.Controls.SetChildIndex(this.IsPointAuto, 0);
            this.Controls.SetChildIndex(this.IsExpenseGoods, 0);
            this.Controls.SetChildIndex(this.IsExpensePoint, 0);
            this.Controls.SetChildIndex(this.cardType, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.id, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cardType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IsExpenseGoods;
        private System.Windows.Forms.CheckBox IsExpensePoint;
        private System.Windows.Forms.CheckBox IsPointAuto;
        private AlSkin.AlControl.AlButton save;
        private System.Windows.Forms.Label id;
    }
}