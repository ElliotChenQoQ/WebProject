using System.Threading.Tasks;
using WebProject.Init.Base.Interface;
using WebProject.Models.ViewModel;

namespace WebProject.MWare.Interface
{
    /// <summary>
    /// 氣象API MWare 介面
    /// </summary>
    public interface IWeatherApiMWare : IBaseMWare
    {
        /// <summary>
        /// 取得UVI Api資料
        /// </summary>
        /// <returns>UVI Api資料</returns>
        Task<UviApiData> GetUviApiData();
    }
}
