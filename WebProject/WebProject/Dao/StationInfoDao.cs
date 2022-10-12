using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Core.EntityFramework;
using WebProject.Dao.Interface;
using WebProject.Init.Base;
using WebProject.Model.DataModel;
using WebProject.Models.BusinessModel;

namespace WebProject.Dao
{
    /// <summary>
    /// 測站資訊資料庫存取
    /// </summary>
    public class StationInfoDao : BaseDao, IStationInfoDao
    {
        public StationInfoDao(IServiceProvider services) : base(services)
        {

        }

        /// <summary>
        /// AutoMapper
        /// </summary>
        protected override void AutoMapperConfiguration()
        {
            Mapper = new MapperConfiguration(x =>
            {
                x.CreateMap<StationInfo, StationInfoBo>();
            }).CreateMapper();
        }

        /// <summary>
        /// 取得資料
        /// </summary>
        /// <returns>資料清單</returns>
        public async Task<List<StationInfoBo>> Get()
        {
            using (MainContext context = GetContext())
            {
                return await Get(context);
            }
        }

        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="context">EntityDB</param>
        /// <returns>資料清單</returns>
        public async Task<List<StationInfoBo>> Get(MainContext context)
        {
            List<StationInfoBo> result = new List<StationInfoBo>();

            List<StationInfo> datas = await context.StationInfo.AsNoTracking()
                                                               .ToListAsync();

            if (datas.Any())
            {
                result = datas.ConvertAll((a) => Mapper.Map<StationInfoBo>(a));
            }

            return result;
        }
    }
}
