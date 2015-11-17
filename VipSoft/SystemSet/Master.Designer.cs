namespace VipSoft.SystemSet
{
    partial class Master
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pager1 = new Vipsoft.Controls.Pager();
            this.delBtn = new AlSkin.AlControl.AlButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issupper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.f_issuper = new System.Windows.Forms.CheckBox();
            this.f_sex = new System.Windows.Forms.ComboBox();
            this.alButton2 = new AlSkin.AlControl.AlButton();
            this.alButton1 = new AlSkin.AlControl.AlButton();
            this.label8 = new System.Windows.Forms.Label();
            this.f_shopname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.f_shopid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.f_telphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.f_password = new System.Windows.Forms.TextBox();
            this.f_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f_account = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 343);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pager1);
            this.tabPage1.Controls.Add(this.delBtn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理员列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pager1
            // 
            this.pager1.BackGroundImage = null;
            this.pager1.CurrentPage = 0;
            this.pager1.Location = new System.Drawing.Point(6, 285);
            this.pager1.Name = "pager1";
            this.pager1.PageCount = 0;
            this.pager1.PagerWidth = 500;
            this.pager1.PageSize = 10;
            this.pager1.RecordCount = 0;
            this.pager1.Size = new System.Drawing.Size(411, 30);
            this.pager1.TabIndex = 2;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(6, 5);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(62, 23);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.id,
            this.account,
            this.name,
            this.sex,
            this.telPhone,
            this.shopid,
            this.shopname,
            this.issupper});
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(417, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = " ";
            this.checkbox.Name = "checkbox";
            this.checkbox.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // account
            // 
            this.account.DataPropertyName = "account";
            this.account.HeaderText = "编号";
            this.account.Name = "account";
            this.account.Width = 60;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.Width = 80;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.Width = 60;
            // 
            // telPhone
            // 
            this.telPhone.DataPropertyName = "telPhone";
            this.telPhone.HeaderText = "联系电话";
            this.telPhone.Name = "telPhone";
            this.telPhone.Width = 80;
            // 
            // shopid
            // 
            this.shopid.DataPropertyName = "shopid";
            this.shopid.HeaderText = "店铺ID";
            this.shopid.Name = "shopid";
            this.shopid.Width = 80;
            // 
            // shopname
            // 
            this.shopname.DataPropertyName = "shopname";
            this.shopname.HeaderText = "店铺名称";
            this.shopname.Name = "shopname";
            this.shopname.Width = 80;
            // 
            // issupper
            // 
            this.issupper.DataPropertyName = "issuper";
            this.issupper.HeaderText = "是否超级管理员";
            this.issupper.Name = "issupper";
            this.issupper.Width = 140;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新增管理员";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f_issuper);
            this.groupBox1.Controls.Add(this.f_sex);
            this.groupBox1.Controls.Add(this.alButton2);
            this.groupBox1.Controls.Add(this.alButton1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.f_shopname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.f_shopid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.f_telphone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.f_password);
            this.groupBox1.Controls.Add(this.f_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.f_account);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理员设置";
            // 
            // f_issuper
            // 
            this.f_issuper.AutoSize = true;
            this.f_issuper.Location = new System.Drawing.Point(8, 195);
            this.f_issuper.Name = "f_issuper";
            this.f_issuper.Size = new System.Drawing.Size(114, 16);
            this.f_issuper.TabIndex = 19;
            this.f_issuper.Text = "是否超级管理员:";
            this.f_issuper.UseVisualStyleBackColor = true;
            // 
            // f_sex
            // 
            this.f_sex.FormattingEnabled = true;
            this.f_sex.Location = new System.Drawing.Point(66, 101);
            this.f_sex.Name = "f_sex";
            this.f_sex.Size = new System.Drawing.Size(100, 20);
            this.f_sex.TabIndex = 18;
            // 
            // alButton2
            // 
            this.alButton2.Location = new System.Drawing.Point(104, 265);
            this.alButton2.Name = "alButton2";
            this.alButton2.Size = new System.Drawing.Size(61, 23);
            this.alButton2.TabIndex = 17;
            this.alButton2.Text = "重置";
            this.alButton2.UseVisualStyleBackColor = true;
            // 
            // alButton1
            // 
            this.alButton1.Location = new System.Drawing.Point(18, 265);
            this.alButton1.Name = "alButton1";
            this.alButton1.Size = new System.Drawing.Size(61, 23);
            this.alButton1.TabIndex = 16;
            this.alButton1.Text = "保存";
            this.alButton1.UseVisualStyleBackColor = true;
            this.alButton1.Click += new System.EventHandler(this.alButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "店铺名称:";
            // 
            // f_shopname
            // 
            this.f_shopname.Location = new System.Drawing.Point(67, 157);
            this.f_shopname.Name = "f_shopname";
            this.f_shopname.ReadOnly = true;
            this.f_shopname.Size = new System.Drawing.Size(100, 21);
            this.f_shopname.TabIndex = 13;
            this.f_shopname.Click += new System.EventHandler(this.f_shopname_Click);
            this.f_shopname.TextChanged += new System.EventHandler(this.f_shopname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "店铺ID:";
            this.label6.Visible = false;
            // 
            // f_shopid
            // 
            this.f_shopid.Location = new System.Drawing.Point(67, 221);
            this.f_shopid.Name = "f_shopid";
            this.f_shopid.ReadOnly = true;
            this.f_shopid.Size = new System.Drawing.Size(100, 21);
            this.f_shopid.TabIndex = 10;
            this.f_shopid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "电话:";
            // 
            // f_telphone
            // 
            this.f_telphone.Location = new System.Drawing.Point(67, 128);
            this.f_telphone.Name = "f_telphone";
            this.f_telphone.Size = new System.Drawing.Size(100, 21);
            this.f_telphone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "性别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码:";
            // 
            // f_password
            // 
            this.f_password.Location = new System.Drawing.Point(66, 74);
            this.f_password.Name = "f_password";
            this.f_password.Size = new System.Drawing.Size(100, 21);
            this.f_password.TabIndex = 4;
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(66, 47);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(100, 21);
            this.f_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "编号:";
            // 
            // f_account
            // 
            this.f_account.Location = new System.Drawing.Point(66, 20);
            this.f_account.Name = "f_account";
            this.f_account.Size = new System.Drawing.Size(100, 21);
            this.f_account.TabIndex = 0;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 399);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Master";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员设置";
            this.Load += new System.EventHandler(this.Master_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn telPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopid;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopname;
        private System.Windows.Forms.DataGridViewTextBoxColumn issupper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f_account;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox f_shopid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox f_telphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f_password;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox f_shopname;
        private AlSkin.AlControl.AlButton alButton2;
        private AlSkin.AlControl.AlButton alButton1;
        private System.Windows.Forms.ComboBox f_sex;
        private System.Windows.Forms.CheckBox f_issuper;
        private AlSkin.AlControl.AlButton delBtn;
        private Vipsoft.Controls.Pager pager1;

    }
}