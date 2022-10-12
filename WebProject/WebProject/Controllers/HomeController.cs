using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebProject.Facade.Interface;
using WebProject.Init.Base;

namespace WebProject.Controllers
{
    public class HomeController : BaseController
    {
        public IHomeFacade HomeFacade { get; set; }

        public HomeController()
        {

        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        /// <summary>
        /// 取得UVI資料
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> GetUviData()
        {
            return Json(await HomeFacade.GetUviData());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
