using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Model.DataModel
{
    /// <summary>
    /// 紫外線指數資料
    /// </summary>
    [Table("UVI_DATA")]
    public class UviData
    {
        /// <summary>
        /// PK, 自動流水號
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        [Column("UD_SN", TypeName = "BIGINT")]
        public long UdSn { get; set; }

        /// <summary>
        /// 測站代號
        /// </summary>
        [Column("STATION_CODE", TypeName = "VARCHAR(20)")]
        public string StationCode { get; set; }

        /// <summary>
        /// 紫外線指數最大值
        /// </summary>
        [Column("UVI_VALUE", TypeName = "DECIMAL(18, 12)")]
        public decimal? UviValue { get; set; }

        /// <summary>
        /// 觀測時間
        /// </summary>
        [Column("OBSERVATION_DTM", TypeName = "VARCHAR(20)")]
        public string ObservationDtm { get; set; }

        /// <summary>
        /// 建立者
        /// </summary>

        [Column("CREATE_USER", TypeName = "NVARCHAR(20)")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>

        [Column("CREATE_DTM", TypeName = "DATETIME")]
        public DateTime CreateDtm { get; set; }
    }
}
