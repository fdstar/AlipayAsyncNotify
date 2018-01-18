using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoanRepayPlanTerm Data Structure.
    /// </summary>
    [Serializable]
    public class LoanRepayPlanTerm : AopObject
    {
        /// <summary>
        /// 是否当前期
        /// </summary>
        [XmlElement("current_term")]
        public bool CurrentTerm { get; set; }

        /// <summary>
        /// 当期已还金额
        /// </summary>
        [XmlElement("paid_amt")]
        public LoanMoneyTypeAmt PaidAmt { get; set; }

        /// <summary>
        /// 剩余应还金额
        /// </summary>
        [XmlElement("remain_amt")]
        public LoanMoneyTypeAmt RemainAmt { get; set; }

        /// <summary>
        /// 分期状态，目前支持的分期状态有：  NORMAL: 正常  OVD: 逾期  CLEAR: 结清
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 本期到期日
        /// </summary>
        [XmlElement("term_end_date")]
        public string TermEndDate { get; set; }

        /// <summary>
        /// 期次号
        /// </summary>
        [XmlElement("term_no")]
        public long TermNo { get; set; }

        /// <summary>
        /// 本期开始日
        /// </summary>
        [XmlElement("term_start_date")]
        public string TermStartDate { get; set; }

        /// <summary>
        /// 当期总金额
        /// </summary>
        [XmlElement("total_amt")]
        public LoanMoneyTypeAmt TotalAmt { get; set; }
    }
}
