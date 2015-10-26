namespace VipSoft
{
    partial class DataInput
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.myButton_Close = new AlSkin.AlControl.AlButton();
            this.myButton_DoInput = new AlSkin.AlControl.AlButton();
            this.myButton_SelectExcel = new AlSkin.AlControl.AlButton();
            this.textBox_ExcelPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_OpenExcel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(94, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(360, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // myButton_Close
            // 
            this.myButton_Close.BackColor = System.Drawing.Color.Transparent;
            this.myButton_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton_Close.Location = new System.Drawing.Point(276, 208);
            this.myButton_Close.Name = "myButton_Close";
            this.myButton_Close.Size = new System.Drawing.Size(75, 23);
            this.myButton_Close.TabIndex = 20;
            this.myButton_Close.Text = "关闭(Esc)";
            this.myButton_Close.UseVisualStyleBackColor = false;
            // 
            // myButton_DoInput
            // 
            this.myButton_DoInput.BackColor = System.Drawing.Color.Transparent;
            this.myButton_DoInput.Enabled = false;
            this.myButton_DoInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton_DoInput.Location = new System.Drawing.Point(147, 208);
            this.myButton_DoInput.Name = "myButton_DoInput";
            this.myButton_DoInput.Size = new System.Drawing.Size(90, 23);
            this.myButton_DoInput.TabIndex = 19;
            this.myButton_DoInput.Text = "马上导入数据";
            this.myButton_DoInput.UseVisualStyleBackColor = false;
            // 
            // myButton_SelectExcel
            // 
            this.myButton_SelectExcel.BackColor = System.Drawing.Color.Transparent;
            this.myButton_SelectExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton_SelectExcel.Location = new System.Drawing.Point(411, 177);
            this.myButton_SelectExcel.Name = "myButton_SelectExcel";
            this.myButton_SelectExcel.Size = new System.Drawing.Size(40, 23);
            this.myButton_SelectExcel.TabIndex = 18;
            this.myButton_SelectExcel.Text = "浏览";
            this.myButton_SelectExcel.UseVisualStyleBackColor = false;
            // 
            // textBox_ExcelPath
            // 
            this.textBox_ExcelPath.Location = new System.Drawing.Point(156, 178);
            this.textBox_ExcelPath.Name = "textBox_ExcelPath";
            this.textBox_ExcelPath.Size = new System.Drawing.Size(249, 21);
            this.textBox_ExcelPath.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(22, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "3、点我，马上导入。";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(22, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "2、选择Excel数据文件：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "1、点击     打开Excel表格，在Excel表格中录入数据。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "2、一次性导入的数据量不易过大，对于大数据量建议分批次导入。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "1、导入数据时请仔细填写表格中的每一项数据，并严格按照指定的格式录入。";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "当前进度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "导入步骤：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "注意：";
            // 
            // linkLabel_OpenExcel
            // 
            this.linkLabel_OpenExcel.AutoSize = true;
            this.linkLabel_OpenExcel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_OpenExcel.Location = new System.Drawing.Point(67, 152);
            this.linkLabel_OpenExcel.Name = "linkLabel_OpenExcel";
            this.linkLabel_OpenExcel.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_OpenExcel.TabIndex = 22;
            this.linkLabel_OpenExcel.TabStop = true;
            this.linkLabel_OpenExcel.Text = "这里";
            // 
            // DataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 282);
            this.Controls.Add(this.linkLabel_OpenExcel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.myButton_Close);
            this.Controls.Add(this.myButton_DoInput);
            this.Controls.Add(this.myButton_SelectExcel);
            this.Controls.Add(this.textBox_ExcelPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DataInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据批量导入";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.textBox_ExcelPath, 0);
            this.Controls.SetChildIndex(this.myButton_SelectExcel, 0);
            this.Controls.SetChildIndex(this.myButton_DoInput, 0);
            this.Controls.SetChildIndex(this.myButton_Close, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.Controls.SetChildIndex(this.linkLabel_OpenExcel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private AlSkin.AlControl.AlButton myButton_Close;
        private AlSkin.AlControl.AlButton myButton_DoInput;
        private AlSkin.AlControl.AlButton myButton_SelectExcel;
        private System.Windows.Forms.TextBox textBox_ExcelPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_OpenExcel;
    }
}