﻿namespace VipSoft
{
    partial class prepaidCardRecharge
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search = new AlSkin.AlControl.AlButton();
            this.myTabControl1 = new YiJiaSoft.Controls.MyTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.Label();
            this.close = new AlSkin.AlControl.AlButton();
            this.recharge = new AlSkin.AlControl.AlButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.giftAmount = new System.Windows.Forms.TextBox();
            this.rechargeAmount = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.memberPhoto1 = new VipSoft.Controls.MemberPhoto();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.pasttime = new System.Windows.Forms.Label();
            this.totalMoney = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.v_money = new System.Windows.Forms.Label();
            this.levelid = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.v_cardid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givemoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "卡号/手机(F2):";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(116, 53);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(100, 21);
            this.search_box.TabIndex = 5;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(222, 52);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 6;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // myTabControl1
            // 
            this.myTabControl1.Controls.Add(this.tabPage1);
            this.myTabControl1.Controls.Add(this.tabPage2);
            this.myTabControl1.ItemSize = new System.Drawing.Size(0, 20);
            this.myTabControl1.Location = new System.Drawing.Point(12, 80);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.Padding = new System.Drawing.Point(9, 0);
            this.myTabControl1.PageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(523, 473);
            this.myTabControl1.TabIndex = 7;
            this.myTabControl1.SelectedIndexChanged += new System.EventHandler(this.myTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.memberPhoto1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "马上充值";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.close);
            this.groupBox2.Controls.Add(this.recharge);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.giftAmount);
            this.groupBox2.Controls.Add(this.rechargeAmount);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 248);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "储值卡充值";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(81, 112);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 12);
            this.total.TabIndex = 11;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(266, 210);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 10;
            this.close.Text = "关闭(Esc)";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // recharge
            // 
            this.recharge.Location = new System.Drawing.Point(159, 210);
            this.recharge.Name = "recharge";
            this.recharge.Size = new System.Drawing.Size(75, 23);
            this.recharge.TabIndex = 9;
            this.recharge.Text = "马上充值";
            this.recharge.UseVisualStyleBackColor = true;
            this.recharge.Click += new System.EventHandler(this.recharge_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(77, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 50);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // giftAmount
            // 
            this.giftAmount.Location = new System.Drawing.Point(82, 82);
            this.giftAmount.Name = "giftAmount";
            this.giftAmount.Size = new System.Drawing.Size(95, 21);
            this.giftAmount.TabIndex = 7;
            this.giftAmount.Text = "0.00";
            this.giftAmount.Leave += new System.EventHandler(this.calculateAmount);
            // 
            // rechargeAmount
            // 
            this.rechargeAmount.Location = new System.Drawing.Point(82, 53);
            this.rechargeAmount.Name = "rechargeAmount";
            this.rechargeAmount.Size = new System.Drawing.Size(95, 21);
            this.rechargeAmount.TabIndex = 6;
            this.rechargeAmount.Text = "0.00";
            this.rechargeAmount.Leave += new System.EventHandler(this.calculateAmount);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "充值备注:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "合计充值:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "赠送金额:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "充值金额:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "优惠选择:";
            // 
            // memberPhoto1
            // 
            this.memberPhoto1.BackColor = System.Drawing.Color.Transparent;
            this.memberPhoto1.Location = new System.Drawing.Point(355, 17);
            this.memberPhoto1.Margin = new System.Windows.Forms.Padding(0);
            this.memberPhoto1.Name = "memberPhoto1";
            this.memberPhoto1.PhotoHeight = 150;
            this.memberPhoto1.PhotoPath = "";
            this.memberPhoto1.PhotoWidth = 150;
            this.memberPhoto1.Size = new System.Drawing.Size(152, 153);
            this.memberPhoto1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.mobile);
            this.groupBox1.Controls.Add(this.pasttime);
            this.groupBox1.Controls.Add(this.totalMoney);
            this.groupBox1.Controls.Add(this.point);
            this.groupBox1.Controls.Add(this.v_money);
            this.groupBox1.Controls.Add(this.levelid);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.v_cardid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会员基本信息";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(80, 137);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 12);
            this.id.TabIndex = 16;
            this.id.Visible = false;
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Location = new System.Drawing.Point(239, 57);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(0, 12);
            this.mobile.TabIndex = 15;
            // 
            // pasttime
            // 
            this.pasttime.AutoSize = true;
            this.pasttime.Location = new System.Drawing.Point(239, 114);
            this.pasttime.Name = "pasttime";
            this.pasttime.Size = new System.Drawing.Size(11, 12);
            this.pasttime.TabIndex = 14;
            this.pasttime.Text = "";
            // 
            // totalMoney
            // 
            this.totalMoney.AutoSize = true;
            this.totalMoney.Location = new System.Drawing.Point(79, 114);
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.Size = new System.Drawing.Size(11, 12);
            this.totalMoney.TabIndex = 13;
            this.totalMoney.Text = "";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Location = new System.Drawing.Point(239, 86);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(0, 12);
            this.point.TabIndex = 12;
            // 
            // v_money
            // 
            this.v_money.AutoSize = true;
            this.v_money.Location = new System.Drawing.Point(79, 86);
            this.v_money.Name = "v_money";
            this.v_money.Size = new System.Drawing.Size(0, 12);
            this.v_money.TabIndex = 11;
            // 
            // levelid
            // 
            this.levelid.AutoSize = true;
            this.levelid.Location = new System.Drawing.Point(79, 57);
            this.levelid.Name = "levelid";
            this.levelid.Size = new System.Drawing.Size(0, 12);
            this.levelid.TabIndex = 10;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(239, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 12);
            this.name.TabIndex = 9;
            // 
            // v_cardid
            // 
            this.v_cardid.AutoSize = true;
            this.v_cardid.Location = new System.Drawing.Point(80, 28);
            this.v_cardid.Name = "v_cardid";
            this.v_cardid.Size = new System.Drawing.Size(0, 12);
            this.v_cardid.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "到期时间:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "累计消费:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "当前积分:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "卡片余额:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "手机号码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "当前等级:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "会员姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "会员卡号:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "历史充值记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardid,
            this.money,
            this.givemoney,
            this.mastername});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(6, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(502, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // cardid
            // 
            this.cardid.HeaderText = "会员卡号";
            this.cardid.Name = "cardid";
            // 
            // money
            // 
            this.money.HeaderText = "充值金额";
            this.money.Name = "money";
            // 
            // givemoney
            // 
            this.givemoney.HeaderText = "赠送金额";
            this.givemoney.Name = "givemoney";
            // 
            // mastername
            // 
            this.mastername.HeaderText = "操作员";
            this.mastername.Name = "mastername";
            // 
            // prepaidCardRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 565);
            this.Controls.Add(this.myTabControl1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Name = "prepaidCardRecharge";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "储值卡充值";
            this.Load += new System.EventHandler(this.prepaidCardRecharge_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.search_box, 0);
            this.Controls.SetChildIndex(this.search, 0);
            this.Controls.SetChildIndex(this.myTabControl1, 0);
            this.myTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box;
        private AlSkin.AlControl.AlButton search;
        private YiJiaSoft.Controls.MyTabControl myTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.MemberPhoto memberPhoto1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private AlSkin.AlControl.AlButton close;
        private AlSkin.AlControl.AlButton recharge;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox giftAmount;
        private System.Windows.Forms.TextBox rechargeAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label v_cardid;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label pasttime;
        private System.Windows.Forms.Label totalMoney;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label v_money;
        private System.Windows.Forms.Label levelid;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn givemoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastername;
    }
}