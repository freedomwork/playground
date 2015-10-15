using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Vipsoft.Controls
{
    public delegate void EventPanelHandler(string senderName);

    public class PanelButton : UserControl
    {
        private Label label_Title;
        private Label label_Info;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_Img;
    
        private void InitializeComponent()
        {
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_Img.Location = new System.Drawing.Point(9, 8);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Img.TabIndex = 0;
            this.pictureBox_Img.TabStop = false;
            this.pictureBox_Img.Click += new System.EventHandler(this.PanelButton_Click);
            this.pictureBox_Img.MouseEnter += new System.EventHandler(this.PanelButton_MouseEnter);
            this.pictureBox_Img.MouseLeave += new System.EventHandler(this.PanelButton_MouseLeave);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(52, 10);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(74, 22);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "会员列表";
            this.label_Title.Click += new System.EventHandler(this.PanelButton_Click);
            this.label_Title.MouseEnter += new System.EventHandler(this.PanelButton_MouseEnter);
            this.label_Title.MouseLeave += new System.EventHandler(this.PanelButton_MouseLeave);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(55, 36);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(185, 12);
            this.label_Info.TabIndex = 1;
            this.label_Info.Text = "对本系统所有的会员进行综合管理";
            this.label_Info.Click += new System.EventHandler(this.PanelButton_Click);
            this.label_Info.MouseEnter += new System.EventHandler(this.PanelButton_MouseEnter);
            this.label_Info.MouseLeave += new System.EventHandler(this.PanelButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Controls.Add(this.pictureBox_Img);
            this.panel1.Controls.Add(this.label_Info);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 60);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.PanelButton_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.PanelButton_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.PanelButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VipSoft.Properties.Resources.ico_link;
            this.pictureBox1.Location = new System.Drawing.Point(0, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 3);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PanelButton_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PanelButton_MouseLeave);
            // 
            // PanelButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "PanelButton";
            this.Size = new System.Drawing.Size(250, 60);
            this.Load += new System.EventHandler(this.PanelButton_Load);
            this.Click += new System.EventHandler(this.PanelButton_Click);
            this.Enter += new System.EventHandler(this.PanelButton_Click);
            this.MouseLeave += new System.EventHandler(this.PanelButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// 控件单击事件
        /// </summary>
        public event EventPanelHandler PanelButtonClick;
        
        public PanelButton()
        {
            InitializeComponent();
        }

        [Browsable(true), Description("控件标题"), Category("自定义属性")]
        public string Title
        {
            get { return this.label_Title.Text; }
            set { this.label_Title.Text = value; }
        }

        [Browsable(true), Description("控件说明文字"), Category("自定义属性")]
        public string Info
        {
            get { return this.label_Info.Text; }
            set { this.label_Info.Text = value; }
        }

        [Browsable(true), Description("控件图片"), Category("自定义属性")]
        public Image InfoImg
        {
            get { return this.pictureBox_Img.BackgroundImage; }
            set { this.pictureBox_Img.BackgroundImage = value; }
        }

        private void PanelButton_Load(object sender, EventArgs e)
        {
            
        }

        // 鼠标离开
        private void PanelButton_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Transparent;
            this.Cursor = Cursors.Arrow;
        }

        // 鼠标进入
        private void PanelButton_MouseEnter(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(216, 224, 234);
            this.Cursor = Cursors.Hand;
        }

        // 单击事件
        private void PanelButton_Click(object sender, EventArgs e)
        {
            PanelButtonClick(this.Name);
        }
    }
}
