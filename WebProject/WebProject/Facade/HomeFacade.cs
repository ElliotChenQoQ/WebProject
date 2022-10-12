using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Facade.Interface;
using WebProject.Init.Base;
using WebProject.Models.BusinessModel;
using WebProject.Models.ViewModel;
using WebProject.Service.Interface;

namespace WebProject.Facade
{
    public class HomeFacade : BaseFacade, IHomeFacade
    {
        /// <summary>
        /// 紫外線指數服務
        /// </summary>
        public IUviService UviService { get; set; }

        /// <summary>
        /// 取得UVI資料
        /// </summary>
        /// <returns>UVI資料</returns>
        public async Task<UviInfoVo> GetUviData()
        {
            // === 取得測站資料 ===
            List<StationInfoBo> stationInfoBos = await UviService.GetStationInfo();

            // === 取得Api資料 ===
            UviApiData uviApiData = await UviService.GetUviApiData();

            // === UviApiData To UviData ===
            List<UviDataBo> UviDataBos = await UviService.UviApiDataConvertToUviDataBo(uviApiData, stationInfoBos);

            // === 新增資料 ===
            await UviService.AddUviData(UviDataBos);

            // === 回傳顯示資料 ===
            UviInfoVo uviInfoVos = new UviInfoVo
            {
                UviDatas = Mapper.Map<List<UviDataVo>>(UviDataBos)
            };

            return uviInfoVos;
        }

        /// <summary>
        /// AutoMapper
        /// </summary>
        protected override void AutoMapperConfiguration()
        {
            Mapper = new MapperConfiguration(x =>
            {
                x.CreateMap<UviDataBo, UviDataVo>();
            }).CreateMapper();
        }
    }
}
