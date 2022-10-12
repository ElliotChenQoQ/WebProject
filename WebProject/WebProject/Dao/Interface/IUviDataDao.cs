using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Core.EntityFramework;
using WebProject.Init.Base.Interface;
using WebProject.Models.BusinessModel;

namespace WebProject.Dao.Interface
{
    /// <summary>
    /// UVI資料 資料庫存取
    /// </summary>
    public interface IUviDataDao : IBaseDao
    {
        /// <summary>
        /// 新增多筆資料
        /// </summary>
        /// <param name="uviDataBos">新增資料</param>
        /// <returns>資料列受到影響數量</returns>
        Task<int> Add(List<UviDataBo> uviDataBos);

        /// <summary>
        /// 新增多筆資料
        /// </summary>
        /// <param name="uviDataBos">新增資料</param>
        /// <param name="context">EntityDB</param>
        /// <returns>資料列受到影響數量</returns>
        Task<int> Add(List<UviDataBo> uviDataBos, MainContext context);
    }
}
