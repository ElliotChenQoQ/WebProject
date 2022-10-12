using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Init.Base.Interface;
using WebProject.Models.BusinessModel;
using WebProject.Models.ViewModel;

namespace WebProject.Service.Interface
{
    /// <summary>
    /// 紫外線指數服務 
    /// </summary>
    public interface IUviService : IBaseService
    {
        /// <summary>
        /// 取得UVI Api資料
        /// </summary>
        /// <returns>UVI Api資料</returns>
        Task<UviApiData> GetUviApiData();

        /// <summary>
        /// 取得測站資料
        /// </summary>
        /// <returns>測站資料清單</returns>
        Task<List<StationInfoBo>> GetStationInfo();

        /// <summary>
        /// UviApiData To UviData 
        /// </summary>
        /// <returns>UVI DataBo資料清單</returns>
        Task<List<UviDataBo>> UviApiDataConvertToUviDataBo(UviApiData uviApiData, List<StationInfoBo> stationInfoBos);

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="uviDataBos"></param>
        /// <returns></returns>
        Task<int> AddUviData(List<UviDataBo> uviDataBos);
    }
}
