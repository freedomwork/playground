namespace VipSoft
{
    partial class SetClass
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
            this.groupBox2 = new YiJiaSoft.Controls.MyGroupBox();
            this.treeView_Class = new System.Windows.Forms.TreeView();
            this.groupBox_manage = new YiJiaSoft.Controls.MyGroupBox();
            this.label_ParentID = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ClassName = new System.Windows.Forms.TextBox();
            this.textBox_Parent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close = new AlSkin.AlControl.AlButton();
            this.button_Add = new AlSkin.AlControl.AlButton();
            this.contextMenuStrip_Right = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox_manage.SuspendLayout();
            this.contextMenuStrip_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.groupBox2.Controls.Add(this.treeView_Class);
            this.groupBox2.Location = new System.Drawing.Point(11, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 242);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分类列表";
            // 
            // treeView_Class
            // 
            this.treeView_Class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_Class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Class.Location = new System.Drawing.Point(3, 17);
            this.treeView_Class.Name = "treeView_Class";
            this.treeView_Class.Size = new System.Drawing.Size(194, 222);
            this.treeView_Class.TabIndex = 0;
            this.treeView_Class.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Class_NodeMouseClick);
            // 
            // groupBox_manage
            // 
            this.groupBox_manage.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_manage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.groupBox_manage.Controls.Add(this.label_ParentID);
            this.groupBox_manage.Controls.Add(this.label_ID);
            this.groupBox_manage.Controls.Add(this.label4);
            this.groupBox_manage.Controls.Add(this.label3);
            this.groupBox_manage.Controls.Add(this.textBox_ClassName);
            this.groupBox_manage.Controls.Add(this.textBox_Parent);
            this.groupBox_manage.Controls.Add(this.label2);
            this.groupBox_manage.Controls.Add(this.label1);
            this.groupBox_manage.Controls.Add(this.button_Close);
            this.groupBox_manage.Controls.Add(this.button_Add);
            this.groupBox_manage.Location = new System.Drawing.Point(217, 36);
            this.groupBox_manage.Name = "groupBox_manage";
            this.groupBox_manage.Size = new System.Drawing.Size(200, 242);
            this.groupBox_manage.TabIndex = 10;
            this.groupBox_manage.TabStop = false;
            this.groupBox_manage.Text = "新增/修改分类";
            // 
            // label_ParentID
            // 
            this.label_ParentID.AutoSize = true;
            this.label_ParentID.Location = new System.Drawing.Point(84, 135);
            this.label_ParentID.Name = "label_ParentID";
            this.label_ParentID.Size = new System.Drawing.Size(89, 12);
            this.label_ParentID.TabIndex = 10;
            this.label_ParentID.Text = "label_ParentID";
            this.label_ParentID.Visible = false;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(28, 135);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(53, 12);
            this.label_ID.TabIndex = 9;
            this.label_ID.Text = "label_ID";
            this.label_ID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "增加、删除或修改产品分类！";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "在左侧分类列表点击右键选择";
            // 
            // textBox_ClassName
            // 
            this.textBox_ClassName.Location = new System.Drawing.Point(76, 65);
            this.textBox_ClassName.Name = "textBox_ClassName";
            this.textBox_ClassName.Size = new System.Drawing.Size(100, 21);
            this.textBox_ClassName.TabIndex = 1;
            // 
            // textBox_Parent
            // 
            this.textBox_Parent.Enabled = false;
            this.textBox_Parent.Location = new System.Drawing.Point(76, 30);
            this.textBox_Parent.Name = "textBox_Parent";
            this.textBox_Parent.Size = new System.Drawing.Size(100, 21);
            this.textBox_Parent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "父类别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别名称：";
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Close.Location = new System.Drawing.Point(115, 104);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "关闭(Esc)";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Transparent;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(13, 104);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "增加分类";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // contextMenuStrip_Right
            // 
            this.contextMenuStrip_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.contextMenuStrip_Right.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Edit,
            this.toolStripMenuItem_Delete,
            this.toolStripMenuItem_Add});
            this.contextMenuStrip_Right.Name = "contextMenuStrip_Right";
            this.contextMenuStrip_Right.Size = new System.Drawing.Size(147, 70);
            // 
            // toolStripMenuItem_Edit
            // 
            this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem_Edit.Text = "修改此分类";
            this.toolStripMenuItem_Edit.Click += new System.EventHandler(this.toolStripMenuItem_Item_Click);
            // 
            // toolStripMenuItem_Delete
            // 
            this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem_Delete.Text = "删除此分类";
            this.toolStripMenuItem_Delete.Click += new System.EventHandler(this.toolStripMenuItem_Item_Click);
            // 
            // toolStripMenuItem_Add
            // 
            this.toolStripMenuItem_Add.Name = "toolStripMenuItem_Add";
            this.toolStripMenuItem_Add.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem_Add.Text = "增加下级分类";
            this.toolStripMenuItem_Add.Click += new System.EventHandler(this.toolStripMenuItem_Item_Click);
            // 
            // SetClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_manage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetClass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品分类设置";
            this.Load += new System.EventHandler(this.SetClass_Load);
            this.Controls.SetChildIndex(this.groupBox_manage, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox_manage.ResumeLayout(false);
            this.groupBox_manage.PerformLayout();
            this.contextMenuStrip_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private YiJiaSoft.Controls.MyGroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView_Class;
        private YiJiaSoft.Controls.MyGroupBox groupBox_manage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ClassName;
        private System.Windows.Forms.TextBox textBox_Parent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AlSkin.AlControl.AlButton button_Close;
        private AlSkin.AlControl.AlButton button_Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Right;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Delete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Add;
        private System.Windows.Forms.Label label_ParentID;
        private System.Windows.Forms.Label label_ID;
    }
}