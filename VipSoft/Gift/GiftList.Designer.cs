﻿namespace VipSoft
{
    partial class GiftList
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
            this.components = new System.ComponentModel.Container();
            this.myTabControl1 = new YiJiaSoft.Controls.MyTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_photo = new System.Windows.Forms.Label();
            this.alButton1 = new AlSkin.AlControl.AlButton();
            this.label_GiftID = new System.Windows.Forms.Label();
            this.Button_Close = new AlSkin.AlControl.AlButton();
            this.Button_Add = new AlSkin.AlControl.AlButton();
            this.TextBox_Number = new YiJiaSoft.Controls.MyNumberTextBox();
            this.TextBox_Point = new YiJiaSoft.Controls.MyNumberTextBox();
            this.textBox_Photo = new System.Windows.Forms.TextBox();
            this.textBox_GiftName = new System.Windows.Forms.TextBox();
            this.textBox_GiftCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip_Right = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiftCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabControl1
            // 
            this.myTabControl1.Controls.Add(this.tabPage1);
            this.myTabControl1.Controls.Add(this.tabPage2);
            this.myTabControl1.ItemSize = new System.Drawing.Size(0, 20);
            this.myTabControl1.Location = new System.Drawing.Point(9, 38);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.Padding = new System.Drawing.Point(9, 0);
            this.myTabControl1.PageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(447, 336);
            this.myTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataGridView_List);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "兑换礼品列表";
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.AllowUserToAddRows = false;
            this.dataGridView_List.AllowUserToDeleteRows = false;
            this.dataGridView_List.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.GiftCode,
            this.Name,
            this.Point,
            this.ExchangNum,
            this.Number,
            this.Photo});
            this.dataGridView_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_List.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_List.MultiSelect = false;
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.ReadOnly = true;
            this.dataGridView_List.RowHeadersVisible = false;
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_List.Size = new System.Drawing.Size(433, 302);
            this.dataGridView_List.TabIndex = 0;
            this.dataGridView_List.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_List_CellMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label_photo);
            this.tabPage2.Controls.Add(this.alButton1);
            this.tabPage2.Controls.Add(this.label_GiftID);
            this.tabPage2.Controls.Add(this.Button_Close);
            this.tabPage2.Controls.Add(this.Button_Add);
            this.tabPage2.Controls.Add(this.TextBox_Number);
            this.tabPage2.Controls.Add(this.TextBox_Point);
            this.tabPage2.Controls.Add(this.textBox_Photo);
            this.tabPage2.Controls.Add(this.textBox_GiftName);
            this.tabPage2.Controls.Add(this.textBox_GiftCode);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(439, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新增礼品";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 156);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label_photo
            // 
            this.label_photo.AutoSize = true;
            this.label_photo.Location = new System.Drawing.Point(226, 64);
            this.label_photo.Name = "label_photo";
            this.label_photo.Size = new System.Drawing.Size(41, 12);
            this.label_photo.TabIndex = 9;
            this.label_photo.Text = "label6";
            this.label_photo.Visible = false;
            // 
            // alButton1
            // 
            this.alButton1.Location = new System.Drawing.Point(228, 90);
            this.alButton1.Name = "alButton1";
            this.alButton1.Size = new System.Drawing.Size(57, 23);
            this.alButton1.TabIndex = 8;
            this.alButton1.Text = "选择图片";
            this.alButton1.UseVisualStyleBackColor = true;
            this.alButton1.Click += new System.EventHandler(this.alButton1_Click);
            // 
            // label_GiftID
            // 
            this.label_GiftID.AutoSize = true;
            this.label_GiftID.Location = new System.Drawing.Point(213, 34);
            this.label_GiftID.Name = "label_GiftID";
            this.label_GiftID.Size = new System.Drawing.Size(0, 12);
            this.label_GiftID.TabIndex = 4;
            this.label_GiftID.Visible = false;
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.Button_Close.Location = new System.Drawing.Point(141, 192);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(75, 23);
            this.Button_Close.TabIndex = 7;
            this.Button_Close.Text = "关闭(Esc)";
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.Transparent;
            this.Button_Add.Location = new System.Drawing.Point(10, 192);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 6;
            this.Button_Add.Text = "保存信息";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // TextBox_Number
            // 
            this.TextBox_Number.Location = new System.Drawing.Point(79, 155);
            this.TextBox_Number.MaxLength = 8;
            this.TextBox_Number.Name = "TextBox_Number";
            this.TextBox_Number.Size = new System.Drawing.Size(60, 21);
            this.TextBox_Number.TabIndex = 5;
            // 
            // TextBox_Point
            // 
            this.TextBox_Point.Location = new System.Drawing.Point(79, 123);
            this.TextBox_Point.MaxLength = 8;
            this.TextBox_Point.Name = "TextBox_Point";
            this.TextBox_Point.Size = new System.Drawing.Size(60, 21);
            this.TextBox_Point.TabIndex = 4;
            // 
            // textBox_Photo
            // 
            this.textBox_Photo.Location = new System.Drawing.Point(79, 92);
            this.textBox_Photo.Name = "textBox_Photo";
            this.textBox_Photo.Size = new System.Drawing.Size(144, 21);
            this.textBox_Photo.TabIndex = 3;
            // 
            // textBox_GiftName
            // 
            this.textBox_GiftName.Location = new System.Drawing.Point(79, 61);
            this.textBox_GiftName.Name = "textBox_GiftName";
            this.textBox_GiftName.Size = new System.Drawing.Size(100, 21);
            this.textBox_GiftName.TabIndex = 2;
            // 
            // textBox_GiftCode
            // 
            this.textBox_GiftCode.Location = new System.Drawing.Point(79, 30);
            this.textBox_GiftCode.Name = "textBox_GiftCode";
            this.textBox_GiftCode.Size = new System.Drawing.Size(100, 21);
            this.textBox_GiftCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "总数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "所需积分：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "礼品图片：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "礼品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "礼品编号：";
            // 
            // contextMenuStrip_Right
            // 
            this.contextMenuStrip_Right.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Delete});
            this.contextMenuStrip_Right.Name = "contextMenuStrip_Right";
            this.contextMenuStrip_Right.Size = new System.Drawing.Size(161, 92);
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_Add.Text = "新增礼品";
            this.ToolStripMenuItem_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Right_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_Edit.Text = "修改此礼品信息";
            this.ToolStripMenuItem_Edit.Click += new System.EventHandler(this.ToolStripMenuItem_Right_Click);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_Delete.Text = "删除此礼品";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Right_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg图片|*.jpg|gif动画|*.gif";
            this.openFileDialog1.Title = "选择礼品图片";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // GiftCode
            // 
            this.GiftCode.DataPropertyName = "GiftCode";
            this.GiftCode.HeaderText = "礼品编号";
            this.GiftCode.Name = "GiftCode";
            this.GiftCode.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "礼品名称";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 120;
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "积分";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.Width = 60;
            // 
            // ExchangNum
            // 
            this.ExchangNum.DataPropertyName = "ExchangNum";
            this.ExchangNum.HeaderText = "已兑换";
            this.ExchangNum.Name = "ExchangNum";
            this.ExchangNum.ReadOnly = true;
            this.ExchangNum.Width = 80;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "剩余量";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 80;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "图片";
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Visible = false;
            // 
            // GiftList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 385);
            this.Controls.Add(this.myTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "礼品设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiftList_FormClosing);
            this.Load += new System.EventHandler(this.GiftList_Load);
            this.Controls.SetChildIndex(this.myTabControl1, 0);
            this.myTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private YiJiaSoft.Controls.MyTabControl myTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_photo;
        private AlSkin.AlControl.AlButton alButton1;
        private System.Windows.Forms.Label label_GiftID;
        private AlSkin.AlControl.AlButton Button_Close;
        private AlSkin.AlControl.AlButton Button_Add;
        private YiJiaSoft.Controls.MyNumberTextBox TextBox_Number;
        private YiJiaSoft.Controls.MyNumberTextBox TextBox_Point;
        private System.Windows.Forms.TextBox textBox_Photo;
        private System.Windows.Forms.TextBox textBox_GiftName;
        private System.Windows.Forms.TextBox textBox_GiftCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Right;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiftCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
    }
}