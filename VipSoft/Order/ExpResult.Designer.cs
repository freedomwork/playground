namespace VipSoft
{
    partial class ExpResult
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
            this.TB_TotalMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Card = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CardMoney_Exp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CardMoney = new System.Windows.Forms.Label();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton_Voucher = new System.Windows.Forms.RadioButton();
            this.radioButton_Credit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new YiJiaSoft.Controls.MyGroupBox();
            this.button_Close = new AlSkin.AlControl.AlButton();
            this.button_Result = new AlSkin.AlControl.AlButton();
            this.radioButton_Union = new System.Windows.Forms.RadioButton();
            this.radioButton_Card = new System.Windows.Forms.RadioButton();
            this.radioButton_Cash = new System.Windows.Forms.RadioButton();
            this.panel_Cash = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Money = new System.Windows.Forms.TextBox();
            this.label_Change = new System.Windows.Forms.Label();
            this.panel_Union = new System.Windows.Forms.Panel();
            this.label1_CardMoney2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_ChangeUnion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Money_Voucher = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Money_Credit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Money_Cash = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Money_Card = new System.Windows.Forms.TextBox();
            this.panel_Card.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.panel_Cash.SuspendLayout();
            this.panel_Union.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_TotalMoney
            // 
            this.TB_TotalMoney.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_TotalMoney.ForeColor = System.Drawing.Color.Red;
            this.TB_TotalMoney.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TB_TotalMoney.Location = new System.Drawing.Point(127, 50);
            this.TB_TotalMoney.Name = "TB_TotalMoney";
            this.TB_TotalMoney.Size = new System.Drawing.Size(200, 32);
            this.TB_TotalMoney.TabIndex = 22;
            this.TB_TotalMoney.TextChanged += new System.EventHandler(this.TB_TotalMoney_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(62, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "应付金额：";
            // 
            // panel_Card
            // 
            this.panel_Card.BackColor = System.Drawing.Color.Transparent;
            this.panel_Card.Controls.Add(this.label2);
            this.panel_Card.Controls.Add(this.label_CardMoney_Exp);
            this.panel_Card.Controls.Add(this.label1);
            this.panel_Card.Controls.Add(this.label_CardMoney);
            this.panel_Card.Location = new System.Drawing.Point(37, 99);
            this.panel_Card.Name = "panel_Card";
            this.panel_Card.Size = new System.Drawing.Size(341, 88);
            this.panel_Card.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "消费后卡内余额：";
            // 
            // label_CardMoney_Exp
            // 
            this.label_CardMoney_Exp.AutoSize = true;
            this.label_CardMoney_Exp.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CardMoney_Exp.ForeColor = System.Drawing.Color.Red;
            this.label_CardMoney_Exp.Location = new System.Drawing.Point(107, 45);
            this.label_CardMoney_Exp.Name = "label_CardMoney_Exp";
            this.label_CardMoney_Exp.Size = new System.Drawing.Size(238, 22);
            this.label_CardMoney_Exp.TabIndex = 3;
            this.label_CardMoney_Exp.Text = "label_CardMoney_Exp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前卡内余额：";
            // 
            // label_CardMoney
            // 
            this.label_CardMoney.AutoSize = true;
            this.label_CardMoney.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CardMoney.ForeColor = System.Drawing.Color.Red;
            this.label_CardMoney.Location = new System.Drawing.Point(107, 8);
            this.label_CardMoney.Name = "label_CardMoney";
            this.label_CardMoney.Size = new System.Drawing.Size(190, 22);
            this.label_CardMoney.TabIndex = 1;
            this.label_CardMoney.Text = "label_CardMoney";
            // 
            // panel_Button
            // 
            this.panel_Button.BackColor = System.Drawing.Color.Transparent;
            this.panel_Button.Controls.Add(this.label12);
            this.panel_Button.Controls.Add(this.radioButton_Voucher);
            this.panel_Button.Controls.Add(this.radioButton_Credit);
            this.panel_Button.Controls.Add(this.groupBox1);
            this.panel_Button.Controls.Add(this.button_Close);
            this.panel_Button.Controls.Add(this.button_Result);
            this.panel_Button.Controls.Add(this.radioButton_Union);
            this.panel_Button.Controls.Add(this.radioButton_Card);
            this.panel_Button.Controls.Add(this.radioButton_Cash);
            this.panel_Button.Location = new System.Drawing.Point(12, 277);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(408, 88);
            this.panel_Button.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "选择结算方式(F4)";
            // 
            // radioButton_Voucher
            // 
            this.radioButton_Voucher.AutoSize = true;
            this.radioButton_Voucher.Location = new System.Drawing.Point(235, 21);
            this.radioButton_Voucher.Name = "radioButton_Voucher";
            this.radioButton_Voucher.Size = new System.Drawing.Size(77, 16);
            this.radioButton_Voucher.TabIndex = 4;
            this.radioButton_Voucher.Text = "代金券(&4)";
            this.radioButton_Voucher.UseVisualStyleBackColor = true;
            this.radioButton_Voucher.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_Credit
            // 
            this.radioButton_Credit.AutoSize = true;
            this.radioButton_Credit.Location = new System.Drawing.Point(156, 21);
            this.radioButton_Credit.Name = "radioButton_Credit";
            this.radioButton_Credit.Size = new System.Drawing.Size(77, 16);
            this.radioButton_Credit.TabIndex = 3;
            this.radioButton_Credit.Text = "银行卡(&3)";
            this.radioButton_Credit.UseVisualStyleBackColor = true;
            this.radioButton_Credit.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 1);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Close.Location = new System.Drawing.Point(222, 52);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(101, 23);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "关闭(Esc)";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Result
            // 
            this.button_Result.BackColor = System.Drawing.Color.Transparent;
            this.button_Result.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Result.Location = new System.Drawing.Point(91, 52);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(106, 23);
            this.button_Result.TabIndex = 6;
            this.button_Result.Text = "马上结算(Enter)";
            this.button_Result.UseVisualStyleBackColor = false;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // radioButton_Union
            // 
            this.radioButton_Union.AutoSize = true;
            this.radioButton_Union.Location = new System.Drawing.Point(314, 21);
            this.radioButton_Union.Name = "radioButton_Union";
            this.radioButton_Union.Size = new System.Drawing.Size(65, 16);
            this.radioButton_Union.TabIndex = 5;
            this.radioButton_Union.Text = "联合(&5)";
            this.radioButton_Union.UseVisualStyleBackColor = true;
            this.radioButton_Union.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_Card
            // 
            this.radioButton_Card.AutoSize = true;
            this.radioButton_Card.Location = new System.Drawing.Point(25, 21);
            this.radioButton_Card.Name = "radioButton_Card";
            this.radioButton_Card.Size = new System.Drawing.Size(65, 16);
            this.radioButton_Card.TabIndex = 1;
            this.radioButton_Card.Text = "余额(&1)";
            this.radioButton_Card.UseVisualStyleBackColor = true;
            this.radioButton_Card.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_Cash
            // 
            this.radioButton_Cash.AutoSize = true;
            this.radioButton_Cash.Location = new System.Drawing.Point(91, 21);
            this.radioButton_Cash.Name = "radioButton_Cash";
            this.radioButton_Cash.Size = new System.Drawing.Size(65, 16);
            this.radioButton_Cash.TabIndex = 2;
            this.radioButton_Cash.Text = "现金(&2)";
            this.radioButton_Cash.UseVisualStyleBackColor = true;
            this.radioButton_Cash.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panel_Cash
            // 
            this.panel_Cash.BackColor = System.Drawing.Color.Transparent;
            this.panel_Cash.Controls.Add(this.label5);
            this.panel_Cash.Controls.Add(this.label6);
            this.panel_Cash.Controls.Add(this.textBox_Money);
            this.panel_Cash.Controls.Add(this.label_Change);
            this.panel_Cash.Location = new System.Drawing.Point(492, 61);
            this.panel_Cash.Name = "panel_Cash";
            this.panel_Cash.Size = new System.Drawing.Size(341, 84);
            this.panel_Cash.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "实收金额(F6)：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "找零金额：";
            // 
            // textBox_Money
            // 
            this.textBox_Money.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Money.ForeColor = System.Drawing.Color.Red;
            this.textBox_Money.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_Money.Location = new System.Drawing.Point(111, 6);
            this.textBox_Money.Name = "textBox_Money";
            this.textBox_Money.Size = new System.Drawing.Size(200, 32);
            this.textBox_Money.TabIndex = 0;
            this.textBox_Money.Text = "￥0.00";
            // 
            // label_Change
            // 
            this.label_Change.AutoSize = true;
            this.label_Change.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Change.ForeColor = System.Drawing.Color.Red;
            this.label_Change.Location = new System.Drawing.Point(107, 46);
            this.label_Change.Name = "label_Change";
            this.label_Change.Size = new System.Drawing.Size(154, 22);
            this.label_Change.TabIndex = 14;
            this.label_Change.Text = "label_Change";
            // 
            // panel_Union
            // 
            this.panel_Union.BackColor = System.Drawing.Color.Transparent;
            this.panel_Union.Controls.Add(this.label1_CardMoney2);
            this.panel_Union.Controls.Add(this.label17);
            this.panel_Union.Controls.Add(this.label_ChangeUnion);
            this.panel_Union.Controls.Add(this.label15);
            this.panel_Union.Controls.Add(this.label14);
            this.panel_Union.Controls.Add(this.textBox_Money_Voucher);
            this.panel_Union.Controls.Add(this.label13);
            this.panel_Union.Controls.Add(this.textBox_Money_Credit);
            this.panel_Union.Controls.Add(this.label10);
            this.panel_Union.Controls.Add(this.textBox_Money_Cash);
            this.panel_Union.Controls.Add(this.label9);
            this.panel_Union.Controls.Add(this.textBox_Money_Card);
            this.panel_Union.Location = new System.Drawing.Point(492, 153);
            this.panel_Union.Name = "panel_Union";
            this.panel_Union.Size = new System.Drawing.Size(416, 199);
            this.panel_Union.TabIndex = 26;
            // 
            // label1_CardMoney2
            // 
            this.label1_CardMoney2.AutoSize = true;
            this.label1_CardMoney2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_CardMoney2.ForeColor = System.Drawing.Color.Red;
            this.label1_CardMoney2.Location = new System.Drawing.Point(316, 26);
            this.label1_CardMoney2.Name = "label1_CardMoney2";
            this.label1_CardMoney2.Size = new System.Drawing.Size(124, 12);
            this.label1_CardMoney2.TabIndex = 22;
            this.label1_CardMoney2.Text = "label1_CardMoney2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 29;
            this.label17.Text = "找零金额：";
            // 
            // label_ChangeUnion
            // 
            this.label_ChangeUnion.AutoSize = true;
            this.label_ChangeUnion.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ChangeUnion.ForeColor = System.Drawing.Color.Red;
            this.label_ChangeUnion.Location = new System.Drawing.Point(106, 164);
            this.label_ChangeUnion.Name = "label_ChangeUnion";
            this.label_ChangeUnion.Size = new System.Drawing.Size(214, 22);
            this.label_ChangeUnion.TabIndex = 30;
            this.label_ChangeUnion.Text = "label_ChangeUnion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "卡内余额：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "代金券支付(F10)：";
            // 
            // textBox_Money_Voucher
            // 
            this.textBox_Money_Voucher.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Money_Voucher.ForeColor = System.Drawing.Color.Red;
            this.textBox_Money_Voucher.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_Money_Voucher.Location = new System.Drawing.Point(110, 123);
            this.textBox_Money_Voucher.Name = "textBox_Money_Voucher";
            this.textBox_Money_Voucher.Size = new System.Drawing.Size(200, 32);
            this.textBox_Money_Voucher.TabIndex = 4;
            this.textBox_Money_Voucher.Text = "￥0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "银行卡支付(F9)：";
            // 
            // textBox_Money_Credit
            // 
            this.textBox_Money_Credit.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Money_Credit.ForeColor = System.Drawing.Color.Red;
            this.textBox_Money_Credit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_Money_Credit.Location = new System.Drawing.Point(110, 83);
            this.textBox_Money_Credit.Name = "textBox_Money_Credit";
            this.textBox_Money_Credit.Size = new System.Drawing.Size(200, 32);
            this.textBox_Money_Credit.TabIndex = 3;
            this.textBox_Money_Credit.Text = "￥0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "现金支付(F8)：";
            // 
            // textBox_Money_Cash
            // 
            this.textBox_Money_Cash.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Money_Cash.ForeColor = System.Drawing.Color.Red;
            this.textBox_Money_Cash.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_Money_Cash.Location = new System.Drawing.Point(110, 43);
            this.textBox_Money_Cash.Name = "textBox_Money_Cash";
            this.textBox_Money_Cash.Size = new System.Drawing.Size(200, 32);
            this.textBox_Money_Cash.TabIndex = 2;
            this.textBox_Money_Cash.Text = "￥0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "储值卡支付(F7)：";
            // 
            // textBox_Money_Card
            // 
            this.textBox_Money_Card.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Money_Card.ForeColor = System.Drawing.Color.Red;
            this.textBox_Money_Card.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_Money_Card.Location = new System.Drawing.Point(110, 6);
            this.textBox_Money_Card.Name = "textBox_Money_Card";
            this.textBox_Money_Card.Size = new System.Drawing.Size(200, 32);
            this.textBox_Money_Card.TabIndex = 1;
            this.textBox_Money_Card.Text = "￥0.00";
            // 
            // ExpResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 377);
            this.Controls.Add(this.panel_Union);
            this.Controls.Add(this.panel_Cash);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel_Card);
            this.Controls.Add(this.TB_TotalMoney);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消费结算";
            this.Load += new System.EventHandler(this.ExpResult_Load);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TB_TotalMoney, 0);
            this.Controls.SetChildIndex(this.panel_Card, 0);
            this.Controls.SetChildIndex(this.panel_Button, 0);
            this.Controls.SetChildIndex(this.panel_Cash, 0);
            this.Controls.SetChildIndex(this.panel_Union, 0);
            this.panel_Card.ResumeLayout(false);
            this.panel_Card.PerformLayout();
            this.panel_Button.ResumeLayout(false);
            this.panel_Button.PerformLayout();
            this.panel_Cash.ResumeLayout(false);
            this.panel_Cash.PerformLayout();
            this.panel_Union.ResumeLayout(false);
            this.panel_Union.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_TotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_Card;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CardMoney_Exp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CardMoney;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton_Voucher;
        private System.Windows.Forms.RadioButton radioButton_Credit;
        private YiJiaSoft.Controls.MyGroupBox groupBox1;
        private AlSkin.AlControl.AlButton button_Close;
        private AlSkin.AlControl.AlButton button_Result;
        private System.Windows.Forms.RadioButton radioButton_Union;
        private System.Windows.Forms.RadioButton radioButton_Card;
        private System.Windows.Forms.RadioButton radioButton_Cash;
        private System.Windows.Forms.Panel panel_Cash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Money;
        private System.Windows.Forms.Label label_Change;
        private System.Windows.Forms.Panel panel_Union;
        private System.Windows.Forms.Label label1_CardMoney2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_ChangeUnion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Money_Voucher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Money_Credit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Money_Cash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Money_Card;
    }
}