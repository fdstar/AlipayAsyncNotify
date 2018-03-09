using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlipayNotify.Domain
{
    /// <summary>
    /// alipay签名方式
    /// </summary>
    public enum AlipaySignType
    {
        /// <summary>
        /// RSA2
        /// </summary>
        RSA2 = 0,
        /// <summary>
        /// RSA
        /// </summary>
        RSA = 1
    }
}