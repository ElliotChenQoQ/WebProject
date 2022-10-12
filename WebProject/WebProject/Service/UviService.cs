using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Dao.Interface;
using WebProject.Init.Base;
using WebProject.Models.BusinessModel;
using WebProject.Models.ViewModel;
using WebProject.MWare.Interface;
using WebProject.Service.Interface;

namespace WebProject.Service
{
    /// <summary>
    /// 紫外線指數服務
    /// </summary>
    public class UviService : BaseService, IUviService
    {
        /// <summary>
        /// 氣象API MWare
        /// </summary>
        public IWeatherApiMWare WeatherApiMWare { get; set; }

        /// <summary>
        /// 測站資訊資料庫存取
        /// </summary>
        public IStationInfoDao StationInfoDao { get; set; }

        /// <summary>
        /// UVI資料 資料庫存取
        /// </summary>
        public IUviDataDao UviDataDao { get; set; }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="uviDataBos"></param>
        /// <returns></returns>
        public async Task<int> AddUviData(List<UviDataBo> uviDataBos)
        {
            return await UviDataDao.Add(uviDataBos);
        }

        /// <summary>
        /// 取得測站資料
        /// </summary>
        /// <returns></returns>
        public async Task<List<StationInfoBo>> GetStationInfo()
        {
            return await StationInfoDao.Get();
        }

        /// <summary>
        /// 取得UVI Api資料
        /// </summary>
        /// <returns>UVI Api資料</returns>
        public async Task<UviApiData> GetUviApiData()
        {
            return await WeatherApiMWare.GetUviApiData();
        }

        /// <summary>
        /// UviApiData To UviData 
        /// </summary>
        /// <returns>UVI DataBo資料清單</returns>
        public async Task<List<UviDataBo>> UviApiDataConvertToUviDataBo(UviApiData uviApiData,
                                                                        List<StationInfoBo> stationInfoBos)
        {
            Dictionary<string, string> dicCity = stationInfoBos.GroupBy(d => d.StationCode).ToDictionary(d => d.Key, d => d.First().City);
            string observationDtm = uviApiData.Records.WeatherElement.Time.DataTime.ToString();

            List<UviDataBo> UviDataBos = uviApiData.Records
                                           .WeatherElement
                                           .Location.ConvertAll(d => new UviDataBo
                                           {
                                               UviValue = Convert.ToDecimal(d.Value),
                                               StationCode = d.LocationCode,
                                               ObservationDtm = observationDtm,
                                               City = dicCity[d.LocationCode],
                                               DisplayStyle = Math.Floor(d.Value) switch
                                               {
                                                   0 => "green",
                                                   1 => "green",
                                                   2 => "green",
                                                   3 => "orange",
                                                   4 => "orange",
                                                   5 => "orange",
                                                   6 => "brown",
                                                   7 => "brown",
                                                   8 => "red",
                                                   9 => "red",
                                                   10 => "red",
                                                   _ => "purple"
                                               }
                                           });

            return UviDataBos;
        }

        /// <summary>
        /// AutoMapper
        /// </summary>
        protected override void AutoMapperConfiguration()
        {
        }
    }
}
