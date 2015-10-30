using System;
using System.Collections.Generic;
using System.Text;

namespace VipSoft.Common
{
    #region 会员卡状态
    /// <summary>
    /// 会员卡状态
    /// </summary>
    [Serializable]
    public enum CardState
    {
        /// <summary>
        /// 正常状态
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 锁定状态
        /// </summary>
        Locked = 1,
        /// <summary>
        /// 挂失状态
        /// </summary>
        Lossed = 2
    }
    #endregion
}
