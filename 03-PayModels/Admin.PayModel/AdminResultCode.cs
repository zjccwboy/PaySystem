using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.PayModel
{
    public enum AdminResultCode
    {
        /// <summary>
        /// 用户明存在
        /// </summary>
        UserNameExisted = 1000,
        /// <summary>
        /// 用户名不能为空
        /// </summary>
        UserNameNotNull = 1001,
        /// <summary>
        /// 用户名超长
        /// </summary>
        UserNameOutLength = 1002,
        /// <summary>
        /// 密码不能为空
        /// </summary>
        PasswordNotNull = 1003,
        /// <summary>
        /// 密码超长
        /// </summary>
        PasswordOutLength = 1004,
        /// <summary>
        /// 密码太短
        /// </summary>
        PasswordTooShort = 1005,
        /// <summary>
        /// 账号类型错误
        /// </summary>
        InvalidAccountType = 1006,
    }
}
