namespace VipSoft
{
    partial class Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            this.textBox_Dictionary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myButton1 = new AlSkin.AlControl.AlButton();;
            this.myButton2 = new AlSkin.AlControl.AlButton();;
            this.SuspendLayout();
            // 
            // textBox_Dictionary
            // 
            this.textBox_Dictionary.Location = new System.Drawing.Point(12, 41);
            this.textBox_Dictionary.Multiline = true;
            this.textBox_Dictionary.Name = "textBox_Dictionary";
            this.textBox_Dictionary.Size = new System.Drawing.Size(199, 137);
            this.textBox_Dictionary.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "每行一条，请勿重复！";
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            
            
            this.myButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton1.Location = new System.Drawing.Point(27, 218);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 2;
            this.myButton1.Text = "保  存";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.Transparent;
            
            
            this.myButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton2.Location = new System.Drawing.Point(121, 218);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(75, 23);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "关闭(Esc)";
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 251);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Dictionary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dictionary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据字典设置";
            this.Load += new System.EventHandler(this.Dictionary_Load);
            this.Controls.SetChildIndex(this.textBox_Dictionary, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.myButton1, 0);
            this.Controls.SetChildIndex(this.myButton2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Dictionary;
        private System.Windows.Forms.Label label1;
        private AlSkin.AlControl.AlButton myButton1;
        private AlSkin.AlControl.AlButton myButton2;
    }
}