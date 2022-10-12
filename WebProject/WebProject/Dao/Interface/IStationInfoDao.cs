using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Core.EntityFramework;
using WebProject.Init.Base.Interface;
using WebProject.Models.BusinessModel;

namespace WebProject.Dao.Interface
{
    /// <summary>
    /// 測站資訊資料庫存取
    /// </summary>
    public interface IStationInfoDao : IBaseDao
    {
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <returns>資料清單</returns>
        Task<List<StationInfoBo>> Get();

        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="context">EntityDB</param>
        /// <returns>資料清單</returns>
        Task<List<StationInfoBo>> Get(MainContext context);
    }
}
