using System.Threading.Tasks;
using WebProject.Init.Base.Interface;
using WebProject.Models.ViewModel;

namespace WebProject.Facade.Interface
{
    public interface IHomeFacade : IBaseFacade
    {
        /// <summary>
        /// 取得UVI資料
        /// </summary>
        /// <returns></returns>
        Task<UviInfoVo> GetUviData();
    }
}
