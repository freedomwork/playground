using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VipSoft.Controls
{
    public partial class MemberPhoto : UserControl
    {
        private int _photoWidth, _photoHeight;
        private string _photoPath = "";

        /// <summary>
        /// 照片地址
        /// </summary>
        [Browsable(true), Description("照片地址"), Category("杂项")]
        public string PhotoPath
        {
            get { return _photoPath; }
            set
            {
                if (value != null)
                {
                    _photoPath = value;
                    if (_photoPath.IndexOf("http") == 0)
                        this.pictureBox_Photo.ImageLocation = _photoPath;
                    else if (_photoPath != "")
                        this.pictureBox_Photo.ImageLocation = Application.StartupPath + _photoPath;
                    else
                        this.pictureBox_Photo.Image = global::VipSoft.Properties.Resources.nophoto;
                }
            }
        }

        /// <summary>
        /// 照片显示宽度
        /// </summary>
        [Browsable(true), Description("照片显示的宽度"), Category("杂项")]
        public int PhotoWidth
        {
            get { return _photoWidth; }
            set {
                _photoWidth = value;

                this.Width = _photoWidth;
            }
        }

        /// <summary>
        /// 照片显示高度
        /// </summary>
        [Browsable(true), Description("照片显示的高度"), Category("杂项")]
        public int PhotoHeight
        {
            get { return _photoHeight; }
            set
            {
                _photoHeight = value;

                this.Height = _photoHeight;
            }
        }

        public MemberPhoto()
        {
            _photoHeight = this.Height;
            _photoWidth = this.Width;
            _photoPath = "";
            InitializeComponent();
        }
    }
}
