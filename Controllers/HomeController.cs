using Microsoft.AspNetCore.Mvc;
using MyPotfilo.Models;
using System.Diagnostics;

namespace MyPotfilo.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Adata> _adatas = new List<Adata>()
        {
            new Adata()
            {
                Id=1,Titel="سایت کاملا اختصاصی",Image="work-victory.jpg",Description="وبسایت شما را کاملا اختصاصی و با رابط کاربری مورد نظر شما آماده میکنیم"
            },
            new Adata()
            {
                Id=1,Titel="طراحی سایت در کمترین زمان ممکن",Image="work-metiew-smith.jpg",Description="به محض به توافق رسیدن ما کار بر روی سایت شمارا آعاز و در سریعترین زمان ممکن آنرا تحویل میدهیم"
            },
            new Adata()
            {
                Id=1,Titel="تعیرات و پشتیبانی وبسایت شما",Image="work-alex-nowak.jpg",Description="اگر سایتتان توسط ما طراحی نشده نگران نباشید ما آماده ارائه خدمات پشتیبانی و تعمیرات هستیم"
            },
        };


        public IActionResult Index()
        {
            ViewData["hedingTitel"] = "MHFARHOOD";


            return View(_adatas);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}