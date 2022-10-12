using System;

namespace WebProject.Models.BusinessModel
{
    public class UviDataBo
    {
        /// <summary>
        /// PK, 自動流水號
        /// </summary>
        public long UdSn { get; set; }

        /// <summary>
        /// 測站代號
        /// </summary>
        public string StationCode { get; set; }

        /// <summary>
        /// 紫外線指數最大值
        /// </summary>
        public decimal? UviValue { get; set; }

        /// <summary>
        /// 觀測時間
        /// </summary>
        public string ObservationDtm { get; set; }

        /// <summary>
        /// 建立者
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDtm { get; set; }
        public string City { get; internal set; }
        public string DisplayStyle { get; internal set; }
    }
}
