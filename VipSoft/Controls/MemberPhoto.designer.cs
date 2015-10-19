namespace VipSoft.Controls
{
    partial class MemberPhoto
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
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Photo.ErrorImage = global::VipSoft.Properties.Resources.nophoto;
            this.pictureBox_Photo.Image = global::VipSoft.Properties.Resources.nophoto;
            this.pictureBox_Photo.ImageLocation = "";
            this.pictureBox_Photo.InitialImage = global::VipSoft.Properties.Resources.nophoto;
            this.pictureBox_Photo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Photo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(152, 153);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Photo.TabIndex = 0;
            this.pictureBox_Photo.TabStop = false;
            // 
            // MemberPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox_Photo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MemberPhoto";
            this.Size = new System.Drawing.Size(152, 153);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Photo;

    }
}
