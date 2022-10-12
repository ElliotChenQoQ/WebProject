using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Core.EntityFramework;
using WebProject.Dao.Interface;
using WebProject.Init.Base;
using WebProject.Model.DataModel;
using WebProject.Models.BusinessModel;

namespace WebProject.Dao
{
    /// <summary>
    /// UVI資料 資料庫存取
    /// </summary>
    public class UviDataDao : BaseDao, IUviDataDao
    {
        public UviDataDao(IServiceProvider services) : base(services)
        {
        }
        /// <summary>
        /// AutoMapper
        /// </summary>
        protected override void AutoMapperConfiguration()
        {
            Mapper = new MapperConfiguration(x =>
            {
                x.CreateMap<UviDataBo, UviData>()
                // 忽視屬性
                .ForMember(m => m.CreateDtm, s => s.Ignore());
            }).CreateMapper();
        }

        /// <summary>
        /// 新增多筆資料
        /// </summary>
        /// <param name="uviDataBos">新增資料物件</param>
        /// <returns>資料列受到影響數量</returns>
        public async Task<int> Add(List<UviDataBo> uviDataBos)
        {
            int result = 0;

            using (MainContext context = GetContext())
            {
                result = await Add(uviDataBos, context);
            }

            return result;
        }

        /// <summary>
        /// 新增多筆資料
        /// </summary>
        /// <param name="uviDataBos">新增資料物件</param>
        /// <param name="context">EntityDB</param>
        /// <returns>資料列受到影響數量</returns>
        public async Task<int> Add(List<UviDataBo> uviDataBos, MainContext context)
        {
            List<UviData> uviDatas = Mapper.Map<List<UviData>>(uviDataBos);

            await context.UviData.AddRangeAsync(uviDatas);

            int result = await context.SaveChangesAsync();

            return result;
        }
    }
}
