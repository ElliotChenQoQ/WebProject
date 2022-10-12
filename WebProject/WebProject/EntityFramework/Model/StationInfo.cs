using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Model.DataModel
{
    /// <summary>
    /// 測站資訊
    /// </summary>
    [Table("STATION_INFO")]
    public class StationInfo
    {
        /// <summary>
        /// PK, 自動流水號
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        [Column("SI_SN", TypeName = "BIGINT")]
        public long SiSn { get; set; }

        /// <summary>
        /// 測站代號
        /// </summary>
        [Column("STATION_CODE", TypeName = "VARCHAR(20)")]
        public string StationCode { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [Column("CITY", TypeName = "VARCHAR(20)")]
        public string City { get; set; }

        /// <summary>
        /// 測站名稱
        /// </summary>
        [Column("STATION_NAME", TypeName = "VARCHAR(20)")]
        public string StationName { get; set; }
    }
}
