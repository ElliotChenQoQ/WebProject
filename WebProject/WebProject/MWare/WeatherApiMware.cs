

using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Threading.Tasks;
using WebProject.Extension;
using WebProject.Init.Base;
using WebProject.Models.ViewModel;
using WebProject.MWare.Interface;

namespace WebProject.MWare
{
    /// <summary>
    /// 氣象API MWare
    /// </summary>
    public class WeatherApiMWare : BaseMWare, IWeatherApiMWare
    {
        /// <summary>
        /// Authorization:氣象開放資料平台會員授權碼
        /// </summary>
        private string _authorization;

        /// <summary>
        /// AppSetting Configuration
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Initializes a new instance 
        /// </summary>
        /// <param name="configuration"></param>
        public WeatherApiMWare(IConfiguration configuration)
        {
            Configuration = configuration;
            _authorization = Configuration.GetValue<string>("WeatherApi:Authorization");
        }

        /// <summary>
        /// 取得UVI Api資料
        /// </summary>
        /// <returns>UVI Api資料</returns>
        public async Task<UviApiData> GetUviApiData()
        {
            // Api Uri
            Uri uri = new Uri("https://opendata.cwb.gov.tw/api/v1/rest/datastore/O-A0005-001");

            RestClient client = new RestClient(uri);
            RestRequest request = new RestRequest(uri, Method.Get);

            // Authorization
            request.AddParameter("Authorization", _authorization);

            RestResponse response = await client.ExecuteAsync(request);

            return response.Content.JsonMap<UviApiData>();
        }
    }
}
